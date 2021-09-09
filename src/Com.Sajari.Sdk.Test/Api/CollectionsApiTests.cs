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
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Com.Sajari.Sdk.Client;
using Com.Sajari.Sdk.Api;
using Com.Sajari.Sdk.Model;

// uncomment below to import models
//using Com.Sajari.Sdk.Model;

namespace Com.Sajari.Sdk.Test.Api
{
    /// <summary>
    ///  Class for testing CollectionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CollectionsApiTests : IDisposable
    {
        private CollectionsApi instance;

        public CollectionsApiTests()
        {
            instance = new CollectionsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CollectionsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CollectionsApi
            //Assert.IsType<CollectionsApi>(instance);
        }

        /// <summary>
        /// Test CreateCollection
        /// </summary>
        [Fact]
        public void CreateCollectionTest()
        {
            
            Configuration config = new Configuration();
            config.BasePath = "https://api-gateway.sajari.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "mWc1UpIL9pKOY68S";
            config.Password = "twnuOBW6uiNVkD2P";

            var apiInstance = new CollectionsApi(config);

            try
            {
                // Create collection
                Collection result = apiInstance.CreateCollection("test-collection-dotnet", new Collection("My Special Dot Net Collection", new List<string>(){"example.com"}));
                Debug.WriteLine(result);
                Assert.IsType<Collection>(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CollectionsApi.CreateCollection: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

            
        }

        /// <summary>
        /// Test DeleteCollection
        /// </summary>
        [Fact]
        public void DeleteCollectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //var response = instance.DeleteCollection(collectionId);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test GetCollection
        /// </summary>
        [Fact]
        public void GetCollectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //var response = instance.GetCollection(collectionId);
            //Assert.IsType<Collection>(response);
        }

        /// <summary>
        /// Test ListCollections
        /// </summary>
        [Fact]
        public void ListCollectionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? pageSize = null;
            //string pageToken = null;
            //var response = instance.ListCollections(pageSize, pageToken);
            //Assert.IsType<ListCollectionsResponse>(response);
        }

        /// <summary>
        /// Test QueryCollection
        /// </summary>
        [Fact]
        public void QueryCollectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //QueryCollectionRequest queryCollectionRequest = null;
            //var response = instance.QueryCollection(collectionId, queryCollectionRequest);
            //Assert.IsType<QueryCollectionResponse>(response);
        }

        /// <summary>
        /// Test UpdateCollection
        /// </summary>
        [Fact]
        public void UpdateCollectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //Collection collection = null;
            //string updateMask = null;
            //var response = instance.UpdateCollection(collectionId, collection, updateMask);
            //Assert.IsType<Collection>(response);
        }
    }
}
