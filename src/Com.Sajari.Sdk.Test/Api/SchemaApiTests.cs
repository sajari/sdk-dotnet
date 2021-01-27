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
    ///  Class for testing SchemaApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SchemaApiTests : IDisposable
    {
        private SchemaApi instance;

        public SchemaApiTests()
        {
            instance = new SchemaApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SchemaApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SchemaApi
            //Assert.IsType<SchemaApi>(instance);
        }

        /// <summary>
        /// Test BatchCreateSchemaFields
        /// </summary>
        [Fact]
        public void BatchCreateSchemaFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //BatchCreateSchemaFieldsRequest batchCreateSchemaFieldsRequest = null;
            //var response = instance.BatchCreateSchemaFields(collectionId, batchCreateSchemaFieldsRequest);
            //Assert.IsType<BatchCreateSchemaFieldsResponse>(response);
        }

        /// <summary>
        /// Test CreateSchemaField
        /// </summary>
        [Fact]
        public void CreateSchemaFieldTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //SchemaField schemaField = null;
            //var response = instance.CreateSchemaField(collectionId, schemaField);
            //Assert.IsType<SchemaField>(response);
        }

        /// <summary>
        /// Test ListSchemaFields
        /// </summary>
        [Fact]
        public void ListSchemaFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //int? pageSize = null;
            //string pageToken = null;
            //var response = instance.ListSchemaFields(collectionId, pageSize, pageToken);
            //Assert.IsType<ListSchemaFieldsResponse>(response);
        }
    }
}
