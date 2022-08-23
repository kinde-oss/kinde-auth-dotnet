﻿using Kinde.Api.Enums;
using Kinde.Api.Models.Configuration;
using Kinde.Api.Models.User;

namespace Kinde.Api.Flows
{
    public class AuthorizationCodeFlow : BaseAuthorizationFlow<AuthorizationCodeConfiguration>, IAuthorizationFlow, ICodeFlow
    {
        public override IUserActionResolver UserActionsResolver { get; init; } 

        public AuthorizationCodeFlow(IIdentityProviderConfiguration identityProviderConfiguration, AuthorizationCodeConfiguration configuration) : base(identityProviderConfiguration, configuration)
        {
            UserActionsResolver = new AuthorizationCodeUserActionResolver(identityProviderConfiguration.ReplyUrl, configuration.State);
        }
        public override async Task<AuthotizationStates> Authorize(HttpClient httpClient)
        {
            var parameters = CreateBaseRequestParameters();
            parameters.Add("response_type", "code");
            parameters.Add("grant_type", "authorization_code");
            parameters.Add("state", Configuration.State);
            return await base.SendRequest(httpClient, parameters);

        }
        public override void OnCodeRecieved(HttpClient httpClient, string state, string code)
        {
            var parameters = new Dictionary<string, string>();

            parameters.Add("grant_type", "authorization_code");
            parameters.Add("client_id", Configuration.ClientId);
            parameters.Add("client_secret", Configuration.ClientSecret);
            parameters.Add("scope", Configuration.Scope);
            parameters.Add("code", code);
            parameters.Add("redirect_uri", IdentityProviderConfiguration.ReplyUrl);
            SendCode(httpClient, parameters);

        }
    }
}