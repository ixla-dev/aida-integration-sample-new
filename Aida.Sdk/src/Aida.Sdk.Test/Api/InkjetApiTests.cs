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
    ///  Class for testing InkjetApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class InkjetApiTests : IDisposable
    {
        private InkjetApi instance;

        public InkjetApiTests()
        {
            instance = new InkjetApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of InkjetApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' InkjetApi
            //Assert.IsType<InkjetApi>(instance);
        }

        /// <summary>
        /// Test CanPrint
        /// </summary>
        [Fact]
        public void CanPrintTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.CanPrint();
            //Assert.IsType<bool>(response);
        }

        /// <summary>
        /// Test CreateNewJob
        /// </summary>
        [Fact]
        public void CreateNewJobTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.CreateNewJob();
        }

        /// <summary>
        /// Test DisablePrint
        /// </summary>
        [Fact]
        public void DisablePrintTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.DisablePrint();
        }

        /// <summary>
        /// Test EnablePrint
        /// </summary>
        [Fact]
        public void EnablePrintTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.EnablePrint();
        }

        /// <summary>
        /// Test InsertImage
        /// </summary>
        [Fact]
        public void InsertImageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? x = null;
            //int? y = null;
            //List<FileParameter> images = null;
            //instance.InsertImage(x, y, images);
        }

        /// <summary>
        /// Test IsPrinting
        /// </summary>
        [Fact]
        public void IsPrintingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.IsPrinting();
        }

        /// <summary>
        /// Test IsReady
        /// </summary>
        [Fact]
        public void IsReadyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.IsReady();
        }

        /// <summary>
        /// Test Print
        /// </summary>
        [Fact]
        public void PrintTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PrintCycleModes? printCycle = null;
            //instance.Print(printCycle);
        }

        /// <summary>
        /// Test Resolution
        /// </summary>
        [Fact]
        public void ResolutionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.Resolution();
        }
    }
}
