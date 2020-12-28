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
    ///  Class for testing Basket
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class BasketTests
    {
        // TODO uncomment below to declare an instance variable for Basket
        //private Basket instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Basket
            //instance = new Basket();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Basket
        /// </summary>
        [Test]
        public void BasketInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Basket
            //Assert.IsInstanceOfType<Basket> (instance, "variable 'instance' is a Basket");
        }


        /// <summary>
        /// Test the property 'ItemName'
        /// </summary>
        [Test]
        public void ItemNameTest()
        {
            // TODO unit test for the property 'ItemName'
        }
        /// <summary>
        /// Test the property 'ItemNo'
        /// </summary>
        [Test]
        public void ItemNoTest()
        {
            // TODO unit test for the property 'ItemNo'
        }
        /// <summary>
        /// Test the property 'ItemPrice'
        /// </summary>
        [Test]
        public void ItemPriceTest()
        {
            // TODO unit test for the property 'ItemPrice'
        }
        /// <summary>
        /// Test the property 'Qty'
        /// </summary>
        [Test]
        public void QtyTest()
        {
            // TODO unit test for the property 'Qty'
        }
        /// <summary>
        /// Test the property 'VatRate'
        /// </summary>
        [Test]
        public void VatRateTest()
        {
            // TODO unit test for the property 'VatRate'
        }

    }

}
