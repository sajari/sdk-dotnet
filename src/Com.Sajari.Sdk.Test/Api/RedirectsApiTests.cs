/*
 * Search.io API
 *
 * Search.io offers a search and discovery service with Neuralsearch®, the world's first instant AI search technology. Businesses of all sizes use Search.io to build site search and discovery solutions that maximize e-commerce revenue, optimize on-site customer experience, and scale their online presence.
 *
 * The version of the OpenAPI document: v4
 * Contact: support@search.io
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
    ///  Class for testing RedirectsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class RedirectsApiTests : IDisposable
    {
        private RedirectsApi instance;

        public RedirectsApiTests()
        {
            instance = new RedirectsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RedirectsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' RedirectsApi
            //Assert.IsType<RedirectsApi>(instance);
        }

        /// <summary>
        /// Test CreateRedirect
        /// </summary>
        [Fact]
        public void CreateRedirectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //Redirect redirect = null;
            //var response = instance.CreateRedirect(collectionId, redirect);
            //Assert.IsType<Redirect>(response);
        }

        /// <summary>
        /// Test DeleteRedirect
        /// </summary>
        [Fact]
        public void DeleteRedirectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string redirectId = null;
            //var response = instance.DeleteRedirect(collectionId, redirectId);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test GetRedirect
        /// </summary>
        [Fact]
        public void GetRedirectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string redirectId = null;
            //var response = instance.GetRedirect(collectionId, redirectId);
            //Assert.IsType<Redirect>(response);
        }

        /// <summary>
        /// Test ListRedirects
        /// </summary>
        [Fact]
        public void ListRedirectsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //int? pageSize = null;
            //string pageToken = null;
            //var response = instance.ListRedirects(collectionId, pageSize, pageToken);
            //Assert.IsType<ListRedirectsResponse>(response);
        }

        /// <summary>
        /// Test UpdateRedirect
        /// </summary>
        [Fact]
        public void UpdateRedirectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string redirectId = null;
            //string updateMask = null;
            //Redirect redirect = null;
            //var response = instance.UpdateRedirect(collectionId, redirectId, updateMask, redirect);
            //Assert.IsType<Redirect>(response);
        }
    }
}
