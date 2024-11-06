/*
 * Kinde Management API
 *
 * Provides endpoints to manage your Kinde Businesses
 *
 * The version of the OpenAPI document: 1
 * Contact: support@kinde.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xunit;

using Kinde.Api.Client;
using Kinde.Api.Api;
// uncomment below to import models
//using Kinde.Api.Model;

namespace Kinde.Api.Test.Api
{
    /// <summary>
    ///  Class for testing EnvironmentVariablesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class EnvironmentVariablesApiTests : IDisposable
    {
        private EnvironmentVariablesApi instance;

        public EnvironmentVariablesApiTests()
        {
            instance = new EnvironmentVariablesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EnvironmentVariablesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' EnvironmentVariablesApi
            //Assert.IsType<EnvironmentVariablesApi>(instance);
        }

        /// <summary>
        /// Test CreateEnvironmentVariable
        /// </summary>
        [Fact]
        public void CreateEnvironmentVariableTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateEnvironmentVariableRequest createEnvironmentVariableRequest = null;
            //var response = instance.CreateEnvironmentVariable(createEnvironmentVariableRequest);
            //Assert.IsType<CreateEnvironmentVariableResponse>(response);
        }

        /// <summary>
        /// Test DeleteEnvironmentVariable
        /// </summary>
        [Fact]
        public void DeleteEnvironmentVariableTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string variableId = null;
            //var response = instance.DeleteEnvironmentVariable(variableId);
            //Assert.IsType<DeleteEnvironmentVariableResponse>(response);
        }

        /// <summary>
        /// Test GetEnvironmentVariable
        /// </summary>
        [Fact]
        public void GetEnvironmentVariableTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string variableId = null;
            //var response = instance.GetEnvironmentVariable(variableId);
            //Assert.IsType<GetEnvironmentVariableResponse>(response);
        }

        /// <summary>
        /// Test GetEnvironmentVariables
        /// </summary>
        [Fact]
        public void GetEnvironmentVariablesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetEnvironmentVariables();
            //Assert.IsType<GetEnvironmentVariablesResponse>(response);
        }

        /// <summary>
        /// Test UpdateEnvironmentVariable
        /// </summary>
        [Fact]
        public void UpdateEnvironmentVariableTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string variableId = null;
            //UpdateEnvironmentVariableRequest updateEnvironmentVariableRequest = null;
            //var response = instance.UpdateEnvironmentVariable(variableId, updateEnvironmentVariableRequest);
            //Assert.IsType<UpdateEnvironmentVariableResponse>(response);
        }
    }
}