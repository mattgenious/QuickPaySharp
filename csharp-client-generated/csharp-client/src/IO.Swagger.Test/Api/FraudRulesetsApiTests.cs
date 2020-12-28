/* 
 * Quickpay API v10
 *
 * <h2 id=\"authorization\">Authorization</h2>  <p>Authorization is done using basic-auth. Authorization can be done with a user or an agreement.</p>  <ul>   <li>When authorized with a user one is able to edit own settings, create new merchant or request access to existing merchant.</li>   <li>When authorized with an agreement one is able to perform anything on the account that agreement gives permissions to.</li> </ul>  
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
    ///  Class for testing FraudRulesetsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class FraudRulesetsApiTests
    {
        private FraudRulesetsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FraudRulesetsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FraudRulesetsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' FraudRulesetsApi
            //Assert.IsInstanceOfType(typeof(FraudRulesetsApi), instance, "instance is a FraudRulesetsApi");
        }

        
        /// <summary>
        /// Test DELETEFraudRulesetsIdFormat
        /// </summary>
        [Test]
        public void DELETEFraudRulesetsIdFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //int? id = null;
            //var response = instance.DELETEFraudRulesetsIdFormat(acceptVersion, authorization, id);
            //Assert.IsInstanceOf<FraudRuleset> (response, "response is FraudRuleset");
        }
        
        /// <summary>
        /// Test GETFraudRulesetsFormat
        /// </summary>
        [Test]
        public void GETFraudRulesetsFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //var response = instance.GETFraudRulesetsFormat(acceptVersion, authorization);
            //Assert.IsInstanceOf<FraudRuleset> (response, "response is FraudRuleset");
        }
        
        /// <summary>
        /// Test GETFraudRulesetsIdFormat
        /// </summary>
        [Test]
        public void GETFraudRulesetsIdFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //int? id = null;
            //var response = instance.GETFraudRulesetsIdFormat(acceptVersion, authorization, id);
            //Assert.IsInstanceOf<FraudRuleset> (response, "response is FraudRuleset");
        }
        
        /// <summary>
        /// Test PATCHFraudRulesetsIdFormat
        /// </summary>
        [Test]
        public void PATCHFraudRulesetsIdFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //int? id = null;
            //string filterRulesMetricName = null;
            //string filterRulesOperator = null;
            //string filterRulesValue = null;
            //string name = null;
            //string action = null;
            //string combinator = null;
            //var response = instance.PATCHFraudRulesetsIdFormat(acceptVersion, authorization, id, filterRulesMetricName, filterRulesOperator, filterRulesValue, name, action, combinator);
            //Assert.IsInstanceOf<FraudRuleset> (response, "response is FraudRuleset");
        }
        
        /// <summary>
        /// Test POSTFraudRulesetsFormat
        /// </summary>
        [Test]
        public void POSTFraudRulesetsFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //string name = null;
            //string filterRulesMetricName = null;
            //string filterRulesOperator = null;
            //string filterRulesValue = null;
            //string action = null;
            //string combinator = null;
            //var response = instance.POSTFraudRulesetsFormat(acceptVersion, authorization, name, filterRulesMetricName, filterRulesOperator, filterRulesValue, action, combinator);
            //Assert.IsInstanceOf<FraudRuleset> (response, "response is FraudRuleset");
        }
        
    }

}