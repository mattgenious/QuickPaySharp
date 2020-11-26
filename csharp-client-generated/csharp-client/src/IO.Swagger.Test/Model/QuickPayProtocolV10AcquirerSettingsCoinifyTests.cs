/* 
 * Quickpay API v10
 *
 * <h2 id=\"authorization\">Authorization</h2>  <p>Authorization is done using basic-auth. Authorization can be done with a user or an agreement.</p>  <ul>   <li>When authorized with a user one is able to edit own settings, create new merchant or request access to existing merchant.</li>   <li>When authorized with an agreement one is able to perform anything on the account that agreement gives permissions to.</li> </ul>  
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
    ///  Class for testing QuickPayProtocolV10AcquirerSettingsCoinify
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class QuickPayProtocolV10AcquirerSettingsCoinifyTests
    {
        // TODO uncomment below to declare an instance variable for QuickPayProtocolV10AcquirerSettingsCoinify
        //private QuickPayProtocolV10AcquirerSettingsCoinify instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of QuickPayProtocolV10AcquirerSettingsCoinify
            //instance = new QuickPayProtocolV10AcquirerSettingsCoinify();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of QuickPayProtocolV10AcquirerSettingsCoinify
        /// </summary>
        [Test]
        public void QuickPayProtocolV10AcquirerSettingsCoinifyInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" QuickPayProtocolV10AcquirerSettingsCoinify
            //Assert.IsInstanceOfType<QuickPayProtocolV10AcquirerSettingsCoinify> (instance, "variable 'instance' is a QuickPayProtocolV10AcquirerSettingsCoinify");
        }


        /// <summary>
        /// Test the property 'Active'
        /// </summary>
        [Test]
        public void ActiveTest()
        {
            // TODO unit test for the property 'Active'
        }
        /// <summary>
        /// Test the property 'ApiKey'
        /// </summary>
        [Test]
        public void ApiKeyTest()
        {
            // TODO unit test for the property 'ApiKey'
        }
        /// <summary>
        /// Test the property 'ApiSecret'
        /// </summary>
        [Test]
        public void ApiSecretTest()
        {
            // TODO unit test for the property 'ApiSecret'
        }
        /// <summary>
        /// Test the property 'IpnSecret'
        /// </summary>
        [Test]
        public void IpnSecretTest()
        {
            // TODO unit test for the property 'IpnSecret'
        }

    }

}
