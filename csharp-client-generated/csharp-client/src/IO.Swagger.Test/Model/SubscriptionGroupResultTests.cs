/* 
 * Quickpay API v10
 *
 * <h2 id=\"authorization\">Authorization</h2>  Authorization is done using basic-auth. Authorization can be done with a user or an agreement.  <ul>   <li>When authorized with a user one is able to edit own settings, create new merchant or request access to existing merchant.</li>   <li>When authorized with an agreement one is able to perform anything on the account that agreement gives permissions to.</li> </ul>  
 *
 * OpenAPI spec version: 10.0
 * Contact: support@quickpay.net
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.Swagger.Api;
using IO.Swagger.Model;
using IO.Swagger.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing SubscriptionGroupResult
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class SubscriptionGroupResultTests
    {
        // TODO uncomment below to declare an instance variable for SubscriptionGroupResult
        //private SubscriptionGroupResult instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of SubscriptionGroupResult
            //instance = new SubscriptionGroupResult();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SubscriptionGroupResult
        /// </summary>
        [Test]
        public void SubscriptionGroupResultInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" SubscriptionGroupResult
            //Assert.IsInstanceOfType<SubscriptionGroupResult> (instance, "variable 'instance' is a SubscriptionGroupResult");
        }


        /// <summary>
        /// Test the property 'Message'
        /// </summary>
        [Test]
        public void MessageTest()
        {
            // TODO unit test for the property 'Message'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
        /// <summary>
        /// Test the property 'SubscriptionId'
        /// </summary>
        [Test]
        public void SubscriptionIdTest()
        {
            // TODO unit test for the property 'SubscriptionId'
        }

    }

}
