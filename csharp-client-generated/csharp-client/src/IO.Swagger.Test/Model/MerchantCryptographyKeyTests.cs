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
    ///  Class for testing MerchantCryptographyKey
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class MerchantCryptographyKeyTests
    {
        // TODO uncomment below to declare an instance variable for MerchantCryptographyKey
        //private MerchantCryptographyKey instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of MerchantCryptographyKey
            //instance = new MerchantCryptographyKey();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MerchantCryptographyKey
        /// </summary>
        [Test]
        public void MerchantCryptographyKeyInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" MerchantCryptographyKey
            //Assert.IsInstanceOfType<MerchantCryptographyKey> (instance, "variable 'instance' is a MerchantCryptographyKey");
        }


        /// <summary>
        /// Test the property 'CertificateExpiresAt'
        /// </summary>
        [Test]
        public void CertificateExpiresAtTest()
        {
            // TODO unit test for the property 'CertificateExpiresAt'
        }
        /// <summary>
        /// Test the property 'CreatedAt'
        /// </summary>
        [Test]
        public void CreatedAtTest()
        {
            // TODO unit test for the property 'CreatedAt'
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
        /// Test the property 'PublicKeyHash'
        /// </summary>
        [Test]
        public void PublicKeyHashTest()
        {
            // TODO unit test for the property 'PublicKeyHash'
        }
        /// <summary>
        /// Test the property 'ShortDescription'
        /// </summary>
        [Test]
        public void ShortDescriptionTest()
        {
            // TODO unit test for the property 'ShortDescription'
        }
        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }
        /// <summary>
        /// Test the property 'UpdatedAt'
        /// </summary>
        [Test]
        public void UpdatedAtTest()
        {
            // TODO unit test for the property 'UpdatedAt'
        }

    }

}
