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
    ///  Class for testing IPRestriction
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class IPRestrictionTests
    {
        // TODO uncomment below to declare an instance variable for IPRestriction
        //private IPRestriction instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of IPRestriction
            //instance = new IPRestriction();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of IPRestriction
        /// </summary>
        [Test]
        public void IPRestrictionInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" IPRestriction
            //Assert.IsInstanceOfType<IPRestriction> (instance, "variable 'instance' is a IPRestriction");
        }


        /// <summary>
        /// Test the property 'Address'
        /// </summary>
        [Test]
        public void AddressTest()
        {
            // TODO unit test for the property 'Address'
        }

    }

}
