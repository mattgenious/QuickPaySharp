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
    ///  Class for testing FeesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class FeesApiTests
    {
        private FeesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FeesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FeesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' FeesApi
            //Assert.IsInstanceOfType(typeof(FeesApi), instance, "instance is a FeesApi");
        }

        
        /// <summary>
        /// Test DELETEFeesFormulasAcquirerPaymentMethodFormat
        /// </summary>
        [Test]
        public void DELETEFeesFormulasAcquirerPaymentMethodFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //string acquirer = null;
            //string paymentMethod = null;
            //instance.DELETEFeesFormulasAcquirerPaymentMethodFormat(acceptVersion, authorization, acquirer, paymentMethod);
            
        }
        
        /// <summary>
        /// Test GETFeesFormulasAcquirerFormat
        /// </summary>
        [Test]
        public void GETFeesFormulasAcquirerFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //string acquirer = null;
            //var response = instance.GETFeesFormulasAcquirerFormat(acceptVersion, authorization, acquirer);
            //Assert.IsInstanceOf<QuickPayProtocolV10FeeFormula> (response, "response is QuickPayProtocolV10FeeFormula");
        }
        
        /// <summary>
        /// Test GETFeesFormulasAcquirerPaymentMethodFormat
        /// </summary>
        [Test]
        public void GETFeesFormulasAcquirerPaymentMethodFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //string acquirer = null;
            //string paymentMethod = null;
            //var response = instance.GETFeesFormulasAcquirerPaymentMethodFormat(acceptVersion, authorization, acquirer, paymentMethod);
            //Assert.IsInstanceOf<QuickPayProtocolV10FeeFormula> (response, "response is QuickPayProtocolV10FeeFormula");
        }
        
        /// <summary>
        /// Test GETFeesFormulasFormat
        /// </summary>
        [Test]
        public void GETFeesFormulasFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //int? page = null;
            //int? pageSize = null;
            //var response = instance.GETFeesFormulasFormat(acceptVersion, authorization, page, pageSize);
            //Assert.IsInstanceOf<QuickPayProtocolV10FeeFormula> (response, "response is QuickPayProtocolV10FeeFormula");
        }
        
        /// <summary>
        /// Test PATCHFeesFormulasAcquirerPaymentMethodFormat
        /// </summary>
        [Test]
        public void PATCHFeesFormulasAcquirerPaymentMethodFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //string acquirer = null;
            //string paymentMethod = null;
            //string formula = null;
            //var response = instance.PATCHFeesFormulasAcquirerPaymentMethodFormat(acceptVersion, authorization, acquirer, paymentMethod, formula);
            //Assert.IsInstanceOf<QuickPayProtocolV10FeeFormula> (response, "response is QuickPayProtocolV10FeeFormula");
        }
        
        /// <summary>
        /// Test POSTFeesAcquirerPaymentMethodFormat
        /// </summary>
        [Test]
        public void POSTFeesAcquirerPaymentMethodFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //string acquirer = null;
            //string paymentMethod = null;
            //int? amount = null;
            //var response = instance.POSTFeesAcquirerPaymentMethodFormat(acceptVersion, authorization, acquirer, paymentMethod, amount);
            //Assert.IsInstanceOf<QuickPayProtocolV10CalculatedFee> (response, "response is QuickPayProtocolV10CalculatedFee");
        }
        
        /// <summary>
        /// Test POSTFeesFormat
        /// </summary>
        [Test]
        public void POSTFeesFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //int? amount = null;
            //string currency = null;
            //Dictionary<string, string> cardApplePayToken = null;
            //Dictionary<string, string> cardMobilepayOnlineToken = null;
            //string cardToken = null;
            //string cardNumber = null;
            //string cardBrand = null;
            //string acquirer = null;
            //var response = instance.POSTFeesFormat(acceptVersion, authorization, amount, currency, cardApplePayToken, cardMobilepayOnlineToken, cardToken, cardNumber, cardBrand, acquirer);
            //Assert.IsInstanceOf<QuickPayProtocolV10CalculatedFee> (response, "response is QuickPayProtocolV10CalculatedFee");
        }
        
    }

}
