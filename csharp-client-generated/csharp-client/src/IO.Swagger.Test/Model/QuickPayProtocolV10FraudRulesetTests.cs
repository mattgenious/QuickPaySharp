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
    ///  Class for testing QuickPayProtocolV10FraudRuleset
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class QuickPayProtocolV10FraudRulesetTests
    {
        // TODO uncomment below to declare an instance variable for QuickPayProtocolV10FraudRuleset
        //private QuickPayProtocolV10FraudRuleset instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of QuickPayProtocolV10FraudRuleset
            //instance = new QuickPayProtocolV10FraudRuleset();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of QuickPayProtocolV10FraudRuleset
        /// </summary>
        [Test]
        public void QuickPayProtocolV10FraudRulesetInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" QuickPayProtocolV10FraudRuleset
            //Assert.IsInstanceOfType<QuickPayProtocolV10FraudRuleset> (instance, "variable 'instance' is a QuickPayProtocolV10FraudRuleset");
        }


        /// <summary>
        /// Test the property 'Action'
        /// </summary>
        [Test]
        public void ActionTest()
        {
            // TODO unit test for the property 'Action'
        }
        /// <summary>
        /// Test the property 'Combinator'
        /// </summary>
        [Test]
        public void CombinatorTest()
        {
            // TODO unit test for the property 'Combinator'
        }
        /// <summary>
        /// Test the property 'FilterRules'
        /// </summary>
        [Test]
        public void FilterRulesTest()
        {
            // TODO unit test for the property 'FilterRules'
        }
        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'MerchantId'
        /// </summary>
        [Test]
        public void MerchantIdTest()
        {
            // TODO unit test for the property 'MerchantId'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }

    }

}
