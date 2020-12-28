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
    ///  Class for testing FeeFormula
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class FeeFormulaTests
    {
        // TODO uncomment below to declare an instance variable for FeeFormula
        //private FeeFormula instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of FeeFormula
            //instance = new FeeFormula();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FeeFormula
        /// </summary>
        [Test]
        public void FeeFormulaInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" FeeFormula
            //Assert.IsInstanceOfType<FeeFormula> (instance, "variable 'instance' is a FeeFormula");
        }


        /// <summary>
        /// Test the property 'Acquirer'
        /// </summary>
        [Test]
        public void AcquirerTest()
        {
            // TODO unit test for the property 'Acquirer'
        }
        /// <summary>
        /// Test the property 'Formula'
        /// </summary>
        [Test]
        public void FormulaTest()
        {
            // TODO unit test for the property 'Formula'
        }
        /// <summary>
        /// Test the property 'PaymentMethod'
        /// </summary>
        [Test]
        public void PaymentMethodTest()
        {
            // TODO unit test for the property 'PaymentMethod'
        }
        /// <summary>
        /// Test the property 'Standard'
        /// </summary>
        [Test]
        public void StandardTest()
        {
            // TODO unit test for the property 'Standard'
        }

    }

}
