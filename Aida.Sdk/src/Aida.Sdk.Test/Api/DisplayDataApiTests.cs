/*
 * aida
 *
 * 1.0.385
 *
 * The version of the OpenAPI document: 1.0.385
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xunit;

using Aida.Sdk.Client;
using Aida.Sdk.Api;
// uncomment below to import models
//using Aida.Sdk.Model;

namespace Aida.Sdk.Test.Api
{
    /// <summary>
    ///  Class for testing DisplayDataApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DisplayDataApiTests : IDisposable
    {
        private DisplayDataApi instance;

        public DisplayDataApiTests()
        {
            instance = new DisplayDataApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DisplayDataApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DisplayDataApi
            //Assert.IsType<DisplayDataApi>(instance);
        }

        /// <summary>
        /// Test IssuanceStatus
        /// </summary>
        [Fact]
        public void IssuanceStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.IssuanceStatus();
            //Assert.IsType<DisplayIssuanceStatusDto>(response);
        }

        /// <summary>
        /// Test LaserStatus
        /// </summary>
        [Fact]
        public void LaserStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.LaserStatus();
            //Assert.IsType<DisplayLaserStatusDto>(response);
        }

        /// <summary>
        /// Test SystemStatus
        /// </summary>
        [Fact]
        public void SystemStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.SystemStatus();
            //Assert.IsType<DisplaySystemStatusDto>(response);
        }

        /// <summary>
        /// Test TransportStatus
        /// </summary>
        [Fact]
        public void TransportStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.TransportStatus();
            //Assert.IsType<DisplayTransportStatusDto>(response);
        }
    }
}
