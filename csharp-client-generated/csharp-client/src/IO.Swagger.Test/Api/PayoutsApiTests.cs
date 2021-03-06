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
    ///  Class for testing PayoutsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PayoutsApiTests
    {
        private PayoutsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PayoutsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PayoutsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PayoutsApi
            //Assert.IsInstanceOfType(typeof(PayoutsApi), instance, "instance is a PayoutsApi");
        }

        
        /// <summary>
        /// Test DELETEPayoutsIdLinkFormat
        /// </summary>
        [Test]
        public void DELETEPayoutsIdLinkFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //int? id = null;
            //instance.DELETEPayoutsIdLinkFormat(acceptVersion, authorization, id);
            
        }
        
        /// <summary>
        /// Test GETPayoutsFormat
        /// </summary>
        [Test]
        public void GETPayoutsFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //int? dateYear = null;
            //int? dateMonth = null;
            //int? dateDay = null;
            //int? dateHour = null;
            //int? dateMinute = null;
            //string timestamp = null;
            //string minTime = null;
            //string maxTime = null;
            //int? operationsSize = null;
            //bool? accepted = null;
            //string orderId = null;
            //string state = null;
            //int? id = null;
            //string acquirer = null;
            //int? page = null;
            //int? pageSize = null;
            //string sortBy = null;
            //string sortDir = null;
            //var response = instance.GETPayoutsFormat(acceptVersion, authorization, dateYear, dateMonth, dateDay, dateHour, dateMinute, timestamp, minTime, maxTime, operationsSize, accepted, orderId, state, id, acquirer, page, pageSize, sortBy, sortDir);
            //Assert.IsInstanceOf<Payout> (response, "response is Payout");
        }
        
        /// <summary>
        /// Test GETPayoutsIdFormat
        /// </summary>
        [Test]
        public void GETPayoutsIdFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //int? id = null;
            //int? operationsSize = null;
            //var response = instance.GETPayoutsIdFormat(acceptVersion, authorization, id, operationsSize);
            //Assert.IsInstanceOf<Payout> (response, "response is Payout");
        }
        
        /// <summary>
        /// Test GETPayoutsIdOperationsOperationIdFormat
        /// </summary>
        [Test]
        public void GETPayoutsIdOperationsOperationIdFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //int? id = null;
            //int? operationId = null;
            //var response = instance.GETPayoutsIdOperationsOperationIdFormat(acceptVersion, authorization, id, operationId);
            //Assert.IsInstanceOf<Operation> (response, "response is Operation");
        }
        
        /// <summary>
        /// Test PATCHPayoutsIdFormat
        /// </summary>
        [Test]
        public void PATCHPayoutsIdFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //int? id = null;
            //string variables = null;
            //var response = instance.PATCHPayoutsIdFormat(acceptVersion, authorization, id, variables);
            //Assert.IsInstanceOf<Payout> (response, "response is Payout");
        }
        
        /// <summary>
        /// Test POSTPayoutsFormat
        /// </summary>
        [Test]
        public void POSTPayoutsFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //string currency = null;
            //string orderId = null;
            //string variables = null;
            //string textOnStatement = null;
            //var response = instance.POSTPayoutsFormat(acceptVersion, authorization, currency, orderId, variables, textOnStatement);
            //Assert.IsInstanceOf<Payout> (response, "response is Payout");
        }
        
        /// <summary>
        /// Test POSTPayoutsIdCreditFormat
        /// </summary>
        [Test]
        public void POSTPayoutsIdCreditFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //int? id = null;
            //int? amount = null;
            //string quickPayCallbackUrl = null;
            //bool? synchronized = null;
            //float? vatRate = null;
            //string cardNumber = null;
            //string cardExpiration = null;
            //string cardCvd = null;
            //string cardToken = null;
            //string cardApplePayToken = null;
            //string cardMobilepayOnlineToken = null;
            //string cardIssuedTo = null;
            //string cardBrand = null;
            //string cardStatus = null;
            //string cardEci = null;
            //string cardXav = null;
            //string cardCavv = null;
            //string mobileNumber = null;
            //string ninNumber = null;
            //string ninCountryCode = null;
            //string ninGender = null;
            //string personFirstName = null;
            //string personLastName = null;
            //string personEmail = null;
            //string acquirer = null;
            //string customerIp = null;
            //string extras = null;
            //var response = instance.POSTPayoutsIdCreditFormat(acceptVersion, authorization, id, amount, quickPayCallbackUrl, synchronized, vatRate, cardNumber, cardExpiration, cardCvd, cardToken, cardApplePayToken, cardMobilepayOnlineToken, cardIssuedTo, cardBrand, cardStatus, cardEci, cardXav, cardCavv, mobileNumber, ninNumber, ninCountryCode, ninGender, personFirstName, personLastName, personEmail, acquirer, customerIp, extras);
            //Assert.IsInstanceOf<Payout> (response, "response is Payout");
        }
        
        /// <summary>
        /// Test PUTPayoutsIdLinkFormat
        /// </summary>
        [Test]
        public void PUTPayoutsIdLinkFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //int? id = null;
            //int? amount = null;
            //int? agreementId = null;
            //string language = null;
            //string continueUrl = null;
            //string cancelUrl = null;
            //string callbackUrl = null;
            //string paymentMethods = null;
            //int? brandingId = null;
            //string googleAnalyticsTrackingId = null;
            //string googleAnalyticsClientId = null;
            //string acquirer = null;
            //bool? framed = null;
            //string brandingConfig = null;
            //var response = instance.PUTPayoutsIdLinkFormat(acceptVersion, authorization, id, amount, agreementId, language, continueUrl, cancelUrl, callbackUrl, paymentMethods, brandingId, googleAnalyticsTrackingId, googleAnalyticsClientId, acquirer, framed, brandingConfig);
            //Assert.IsInstanceOf<PaymentLinkUrl> (response, "response is PaymentLinkUrl");
        }
        
    }

}
