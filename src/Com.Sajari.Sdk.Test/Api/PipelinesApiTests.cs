/*
 * Sajari API
 *
 * Sajari is a smart, highly-configurable, real-time search service that enables thousands of businesses worldwide to provide amazing search experiences on their websites, stores, and applications.
 *
 * The version of the OpenAPI document: v4
 * Contact: support@sajari.com
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

using Com.Sajari.Sdk.Client;
using Com.Sajari.Sdk.Api;
// uncomment below to import models
//using Com.Sajari.Sdk.Model;

namespace Com.Sajari.Sdk.Test.Api
{
    /// <summary>
    ///  Class for testing PipelinesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PipelinesApiTests : IDisposable
    {
        private PipelinesApi instance;

        public PipelinesApiTests()
        {
            instance = new PipelinesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PipelinesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PipelinesApi
            //Assert.IsType<PipelinesApi>(instance);
        }

        /// <summary>
        /// Test CreatePipeline
        /// </summary>
        [Fact]
        public void CreatePipelineTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //Pipeline pipeline = null;
            //var response = instance.CreatePipeline(collectionId, pipeline);
            //Assert.IsType<Pipeline>(response);
        }

        /// <summary>
        /// Test GeneratePipelines
        /// </summary>
        [Fact]
        public void GeneratePipelinesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //GeneratePipelinesRequest generatePipelinesRequest = null;
            //var response = instance.GeneratePipelines(collectionId, generatePipelinesRequest);
            //Assert.IsType<GeneratePipelinesResponse>(response);
        }

        /// <summary>
        /// Test GetDefaultPipeline
        /// </summary>
        [Fact]
        public void GetDefaultPipelineTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string type = null;
            //var response = instance.GetDefaultPipeline(collectionId, type);
            //Assert.IsType<GetDefaultPipelineResponse>(response);
        }

        /// <summary>
        /// Test GetDefaultVersion
        /// </summary>
        [Fact]
        public void GetDefaultVersionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string type = null;
            //string name = null;
            //string view = null;
            //var response = instance.GetDefaultVersion(collectionId, type, name, view);
            //Assert.IsType<Pipeline>(response);
        }

        /// <summary>
        /// Test GetPipeline
        /// </summary>
        [Fact]
        public void GetPipelineTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string type = null;
            //string name = null;
            //string version = null;
            //string view = null;
            //var response = instance.GetPipeline(collectionId, type, name, version, view);
            //Assert.IsType<Pipeline>(response);
        }

        /// <summary>
        /// Test ListPipelines
        /// </summary>
        [Fact]
        public void ListPipelinesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //int? pageSize = null;
            //string pageToken = null;
            //string view = null;
            //var response = instance.ListPipelines(collectionId, pageSize, pageToken, view);
            //Assert.IsType<ListPipelinesResponse>(response);
        }

        /// <summary>
        /// Test SetDefaultPipeline
        /// </summary>
        [Fact]
        public void SetDefaultPipelineTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //SetDefaultPipelineRequest setDefaultPipelineRequest = null;
            //var response = instance.SetDefaultPipeline(collectionId, setDefaultPipelineRequest);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test SetDefaultVersion
        /// </summary>
        [Fact]
        public void SetDefaultVersionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string type = null;
            //string name = null;
            //SetDefaultVersionRequest setDefaultVersionRequest = null;
            //var response = instance.SetDefaultVersion(collectionId, type, name, setDefaultVersionRequest);
            //Assert.IsType<Object>(response);
        }
    }
}