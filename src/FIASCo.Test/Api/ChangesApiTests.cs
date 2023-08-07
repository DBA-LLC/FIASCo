/*
 * SPAS API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using FIASCo.Client;
using FIASCo.Api;
// uncomment below to import models
//using FIASCo.Model;

namespace FIASCo.Test.Api
{
    /// <summary>
    ///  Class for testing ChangesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ChangesApiTests : IDisposable
    {
        private ChangesApi instance;

        public ChangesApiTests()
        {
            instance = new ChangesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ChangesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ChangesApi
            //Assert.IsType<ChangesApi>(instance);
        }

        /// <summary>
        /// Test ApiSpasV20GetChangesGet
        /// </summary>
        [Fact]
        public void ApiSpasV20GetChangesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //int? changeMask = null;
            //int? regionCode = null;
            //var response = instance.ApiSpasV20GetChangesGet(startDate, endDate, changeMask, regionCode);
            //Assert.IsType<IdResult>(response);
        }

        /// <summary>
        /// Test ApiSpasV20GetSearchResultBlockGet
        /// </summary>
        [Fact]
        public void ApiSpasV20GetSearchResultBlockGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? taskId = null;
            //int? blockIndex = null;
            //var response = instance.ApiSpasV20GetSearchResultBlockGet(taskId, blockIndex);
            //Assert.IsType<IFetchChangesTaskResultBlock>(response);
        }

        /// <summary>
        /// Test ApiSpasV20GetSearchTaskStatusGet
        /// </summary>
        [Fact]
        public void ApiSpasV20GetSearchTaskStatusGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? taskId = null;
            //var response = instance.ApiSpasV20GetSearchTaskStatusGet(taskId);
            //Assert.IsType<IFetchChangesTaskStatus>(response);
        }
    }
}
