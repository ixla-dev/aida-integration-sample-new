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
    ///  Class for testing AuditApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AuditApiTests : IDisposable
    {
        private AuditApi instance;

        public AuditApiTests()
        {
            instance = new AuditApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AuditApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AuditApi
            //Assert.IsType<AuditApi>(instance);
        }

        /// <summary>
        /// Test GetJobTemplateAudit
        /// </summary>
        [Fact]
        public void GetJobTemplateAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? startTimeStamp = null;
            //DateTime? endTimeStamp = null;
            //int? jobTemplateId = null;
            //List<string> operation = null;
            //string layoutName = null;
            //string ocrName = null;
            //string autoposName = null;
            //string webhookName = null;
            //int? page = null;
            //int? pageSize = null;
            //string query = null;
            //string sortCriteriaPropertyName = null;
            //SortDirection? sortCriteriaDirection = null;
            //var response = instance.GetJobTemplateAudit(startTimeStamp, endTimeStamp, jobTemplateId, operation, layoutName, ocrName, autoposName, webhookName, page, pageSize, query, sortCriteriaPropertyName, sortCriteriaDirection);
            //Assert.IsType<List<JobTemplateAuditEntryDto>>(response);
        }

        /// <summary>
        /// Test GetWorkflowAudit
        /// </summary>
        [Fact]
        public void GetWorkflowAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? startTimeStamp = null;
            //DateTime? endTimeStamp = null;
            //int? jobTemplateId = null;
            //string workflowId = null;
            //int? recordId = null;
            //string sessionId = null;
            //List<string> operation = null;
            //string layoutName = null;
            //string ocrName = null;
            //string autoposName = null;
            //string webhookName = null;
            //string sourcePosition = null;
            //string position = null;
            //bool? success = null;
            //string result = null;
            //int? page = null;
            //int? pageSize = null;
            //string query = null;
            //string sortCriteriaPropertyName = null;
            //SortDirection? sortCriteriaDirection = null;
            //var response = instance.GetWorkflowAudit(startTimeStamp, endTimeStamp, jobTemplateId, workflowId, recordId, sessionId, operation, layoutName, ocrName, autoposName, webhookName, sourcePosition, position, success, result, page, pageSize, query, sortCriteriaPropertyName, sortCriteriaDirection);
            //Assert.IsType<List<WorkflowAuditEntryDto>>(response);
        }
    }
}
