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
    ///  Class for testing EventsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class EventsApiTests : IDisposable
    {
        private EventsApi instance;

        public EventsApiTests()
        {
            instance = new EventsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EventsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' EventsApi
            //Assert.IsType<EventsApi>(instance);
        }

        /// <summary>
        /// Test SendEvent
        /// </summary>
        [Fact]
        public void SendEventTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SendEventRequest sendEventRequest = null;
            //var response = instance.SendEvent(sendEventRequest);
            //Assert.IsType<Object>(response);
        }
    }
}
