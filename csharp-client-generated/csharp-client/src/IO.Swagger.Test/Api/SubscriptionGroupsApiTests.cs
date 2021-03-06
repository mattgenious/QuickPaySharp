/* 
 * Quickpay API v10
 *
 * <h2 id=\"authorization\">Authorization</h2>  Authorization is done using basic-auth. Authorization can be done with a user or an agreement.  <ul>   <li>When authorized with a user one is able to edit own settings, create new merchant or request access to existing merchant.</li>   <li>When authorized with an agreement one is able to perform anything on the account that agreement gives permissions to.</li> </ul>  
 *
 * OpenAPI spec version: 10.0
 * Contact: support@quickpay.net
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing SubscriptionGroupsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SubscriptionGroupsApiTests
    {
        private SubscriptionGroupsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SubscriptionGroupsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SubscriptionGroupsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SubscriptionGroupsApi
            //Assert.IsInstanceOfType(typeof(SubscriptionGroupsApi), instance, "instance is a SubscriptionGroupsApi");
        }

        
        /// <summary>
        /// Test DELETESubscriptionGroupsIdFormat
        /// </summary>
        [Test]
        public void DELETESubscriptionGroupsIdFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //int? id = null;
            //var response = instance.DELETESubscriptionGroupsIdFormat(acceptVersion, authorization, id);
            //Assert.IsInstanceOf<SubscriptionGroup> (response, "response is SubscriptionGroup");
        }
        
        /// <summary>
        /// Test GETSubscriptionGroupsFormat
        /// </summary>
        [Test]
        public void GETSubscriptionGroupsFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //int? page = null;
            //int? pageSize = null;
            //string sortBy = null;
            //string sortDir = null;
            //var response = instance.GETSubscriptionGroupsFormat(acceptVersion, authorization, page, pageSize, sortBy, sortDir);
            //Assert.IsInstanceOf<SubscriptionGroup> (response, "response is SubscriptionGroup");
        }
        
        /// <summary>
        /// Test GETSubscriptionGroupsIdFormat
        /// </summary>
        [Test]
        public void GETSubscriptionGroupsIdFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //int? id = null;
            //var response = instance.GETSubscriptionGroupsIdFormat(acceptVersion, authorization, id);
            //Assert.IsInstanceOf<SubscriptionGroup> (response, "response is SubscriptionGroup");
        }
        
        /// <summary>
        /// Test PATCHSubscriptionGroupsIdFormat
        /// </summary>
        [Test]
        public void PATCHSubscriptionGroupsIdFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //int? id = null;
            //string name = null;
            //int? amount = null;
            //string description = null;
            //var response = instance.PATCHSubscriptionGroupsIdFormat(acceptVersion, authorization, id, name, amount, description);
            //Assert.IsInstanceOf<SubscriptionGroup> (response, "response is SubscriptionGroup");
        }
        
        /// <summary>
        /// Test POSTSubscriptionGroupsFormat
        /// </summary>
        [Test]
        public void POSTSubscriptionGroupsFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //string name = null;
            //int? amount = null;
            //string currency = null;
            //string description = null;
            //var response = instance.POSTSubscriptionGroupsFormat(acceptVersion, authorization, name, amount, currency, description);
            //Assert.IsInstanceOf<SubscriptionGroup> (response, "response is SubscriptionGroup");
        }
        
        /// <summary>
        /// Test POSTSubscriptionGroupsIdCaptureFormat
        /// </summary>
        [Test]
        public void POSTSubscriptionGroupsIdCaptureFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //int? id = null;
            //string orderIdPrefix = null;
            //var response = instance.POSTSubscriptionGroupsIdCaptureFormat(acceptVersion, authorization, id, orderIdPrefix);
            //Assert.IsInstanceOf<SubscriptionGroupResult> (response, "response is SubscriptionGroupResult");
        }
        
    }

}
