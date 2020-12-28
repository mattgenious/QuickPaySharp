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
    ///  Class for testing PaymentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PaymentsApiTests
    {
        private PaymentsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PaymentsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PaymentsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PaymentsApi
            //Assert.IsInstanceOfType(typeof(PaymentsApi), instance, "instance is a PaymentsApi");
        }

        
        /// <summary>
        /// Test DELETEPaymentsIdLinkFormat
        /// </summary>
        [Test]
        public void DELETEPaymentsIdLinkFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //int? id = null;
            //instance.DELETEPaymentsIdLinkFormat(acceptVersion, authorization, id);
            
        }
        
        /// <summary>
        /// Test GETPaymentsFormat
        /// </summary>
        [Test]
        public void GETPaymentsFormatTest()
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
            //bool? fraudSuspected = null;
            //int? page = null;
            //int? pageSize = null;
            //string sortBy = null;
            //string sortDir = null;
            //string pageKey = null;
            //var response = instance.GETPaymentsFormat(acceptVersion, authorization, dateYear, dateMonth, dateDay, dateHour, dateMinute, timestamp, minTime, maxTime, operationsSize, accepted, orderId, state, id, acquirer, fraudSuspected, page, pageSize, sortBy, sortDir, pageKey);
            //Assert.IsInstanceOf<List<Payment>> (response, "response is List<Payment>");
        }
        
        /// <summary>
        /// Test GETPaymentsIdFormat
        /// </summary>
        [Test]
        public void GETPaymentsIdFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //int? id = null;
            //int? operationsSize = null;
            //var response = instance.GETPaymentsIdFormat(acceptVersion, authorization, id, operationsSize);
            //Assert.IsInstanceOf<Payment> (response, "response is Payment");
        }
        
        /// <summary>
        /// Test GETPaymentsIdOperationsOperationIdFormat
        /// </summary>
        [Test]
        public void GETPaymentsIdOperationsOperationIdFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //int? id = null;
            //int? operationId = null;
            //var response = instance.GETPaymentsIdOperationsOperationIdFormat(acceptVersion, authorization, id, operationId);
            //Assert.IsInstanceOf<Operation> (response, "response is Operation");
        }
        
        /// <summary>
        /// Test PATCHPaymentsIdFormat
        /// </summary>
        [Test]
        public void PATCHPaymentsIdFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //int? id = null;
            //int? basketQty = null;
            //string basketItemNo = null;
            //string basketItemName = null;
            //int? basketItemPrice = null;
            //float? basketVatRate = null;
            //DateTime? deadlineAt = null;
            //string invoiceAddressName = null;
            //string invoiceAddressAtt = null;
            //string invoiceAddressCompanyName = null;
            //string invoiceAddressStreet = null;
            //string invoiceAddressHouseNumber = null;
            //string invoiceAddressHouseExtension = null;
            //string invoiceAddressCity = null;
            //string invoiceAddressZipCode = null;
            //string invoiceAddressRegion = null;
            //string invoiceAddressCountryCode = null;
            //string invoiceAddressVatNo = null;
            //string invoiceAddressPhoneNumber = null;
            //string invoiceAddressMobileNumber = null;
            //string invoiceAddressEmail = null;
            //string shippingAddressName = null;
            //string shippingAddressAtt = null;
            //string shippingAddressCompanyName = null;
            //string shippingAddressStreet = null;
            //string shippingAddressHouseNumber = null;
            //string shippingAddressHouseExtension = null;
            //string shippingAddressCity = null;
            //string shippingAddressZipCode = null;
            //string shippingAddressRegion = null;
            //string shippingAddressCountryCode = null;
            //string shippingAddressVatNo = null;
            //string shippingAddressPhoneNumber = null;
            //string shippingAddressMobileNumber = null;
            //string shippingAddressEmail = null;
            //string shippingMethod = null;
            //string shippingCompany = null;
            //int? shippingAmount = null;
            //float? shippingVatRate = null;
            //string shippingTrackingNumber = null;
            //string shippingTrackingUrl = null;
            //Dictionary<string, string> variables = null;
            //var response = instance.PATCHPaymentsIdFormat(acceptVersion, authorization, id, basketQty, basketItemNo, basketItemName, basketItemPrice, basketVatRate, deadlineAt, invoiceAddressName, invoiceAddressAtt, invoiceAddressCompanyName, invoiceAddressStreet, invoiceAddressHouseNumber, invoiceAddressHouseExtension, invoiceAddressCity, invoiceAddressZipCode, invoiceAddressRegion, invoiceAddressCountryCode, invoiceAddressVatNo, invoiceAddressPhoneNumber, invoiceAddressMobileNumber, invoiceAddressEmail, shippingAddressName, shippingAddressAtt, shippingAddressCompanyName, shippingAddressStreet, shippingAddressHouseNumber, shippingAddressHouseExtension, shippingAddressCity, shippingAddressZipCode, shippingAddressRegion, shippingAddressCountryCode, shippingAddressVatNo, shippingAddressPhoneNumber, shippingAddressMobileNumber, shippingAddressEmail, shippingMethod, shippingCompany, shippingAmount, shippingVatRate, shippingTrackingNumber, shippingTrackingUrl, variables);
            //Assert.IsInstanceOf<Payment> (response, "response is Payment");
        }
        
        /// <summary>
        /// Test PATCHPaymentsIdOperationsOperationIdFormat
        /// </summary>
        [Test]
        public void PATCHPaymentsIdOperationsOperationIdFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //int? id = null;
            //int? operationId = null;
            //bool? pending = null;
            //var response = instance.PATCHPaymentsIdOperationsOperationIdFormat(acceptVersion, authorization, id, operationId, pending);
            //Assert.IsInstanceOf<Operation> (response, "response is Operation");
        }
        
        /// <summary>
        /// Test POSTPaymentsFormat
        /// </summary>
        [Test]
        public void POSTPaymentsFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //string currency = null;
            //string orderId = null;
            //int? basketQty = null;
            //string basketItemNo = null;
            //string basketItemName = null;
            //int? basketItemPrice = null;
            //float? basketVatRate = null;
            //string invoiceAddressName = null;
            //string invoiceAddressAtt = null;
            //string invoiceAddressCompanyName = null;
            //string invoiceAddressStreet = null;
            //string invoiceAddressHouseNumber = null;
            //string invoiceAddressHouseExtension = null;
            //string invoiceAddressCity = null;
            //string invoiceAddressZipCode = null;
            //string invoiceAddressRegion = null;
            //string invoiceAddressCountryCode = null;
            //string invoiceAddressVatNo = null;
            //string invoiceAddressPhoneNumber = null;
            //string invoiceAddressMobileNumber = null;
            //string invoiceAddressEmail = null;
            //string shippingAddressName = null;
            //string shippingAddressAtt = null;
            //string shippingAddressCompanyName = null;
            //string shippingAddressStreet = null;
            //string shippingAddressHouseNumber = null;
            //string shippingAddressHouseExtension = null;
            //string shippingAddressCity = null;
            //string shippingAddressZipCode = null;
            //string shippingAddressRegion = null;
            //string shippingAddressCountryCode = null;
            //string shippingAddressVatNo = null;
            //string shippingAddressPhoneNumber = null;
            //string shippingAddressMobileNumber = null;
            //string shippingAddressEmail = null;
            //int? brandingId = null;
            //string shippingMethod = null;
            //string shippingCompany = null;
            //int? shippingAmount = null;
            //float? shippingVatRate = null;
            //string shippingTrackingNumber = null;
            //string shippingTrackingUrl = null;
            //string shopsystemName = null;
            //string shopsystemVersion = null;
            //Dictionary<string, string> variables = null;
            //string textOnStatement = null;
            //var response = instance.POSTPaymentsFormat(acceptVersion, authorization, currency, orderId, basketQty, basketItemNo, basketItemName, basketItemPrice, basketVatRate, invoiceAddressName, invoiceAddressAtt, invoiceAddressCompanyName, invoiceAddressStreet, invoiceAddressHouseNumber, invoiceAddressHouseExtension, invoiceAddressCity, invoiceAddressZipCode, invoiceAddressRegion, invoiceAddressCountryCode, invoiceAddressVatNo, invoiceAddressPhoneNumber, invoiceAddressMobileNumber, invoiceAddressEmail, shippingAddressName, shippingAddressAtt, shippingAddressCompanyName, shippingAddressStreet, shippingAddressHouseNumber, shippingAddressHouseExtension, shippingAddressCity, shippingAddressZipCode, shippingAddressRegion, shippingAddressCountryCode, shippingAddressVatNo, shippingAddressPhoneNumber, shippingAddressMobileNumber, shippingAddressEmail, brandingId, shippingMethod, shippingCompany, shippingAmount, shippingVatRate, shippingTrackingNumber, shippingTrackingUrl, shopsystemName, shopsystemVersion, variables, textOnStatement);
            //Assert.IsInstanceOf<Payment> (response, "response is Payment");
        }
        
        /// <summary>
        /// Test POSTPaymentsIdAuthorizeFormat
        /// </summary>
        [Test]
        public void POSTPaymentsIdAuthorizeFormatTest()
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
            //Dictionary<string, string> cardApplePayToken = null;
            //Dictionary<string, string> cardMobilepayOnlineToken = null;
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
            //bool? autoCapture = null;
            //string acquirer = null;
            //bool? autofee = null;
            //string customerIp = null;
            //Dictionary<string, string> extras = null;
            //bool? zeroAuth = null;
            //var response = instance.POSTPaymentsIdAuthorizeFormat(acceptVersion, authorization, id, amount, quickPayCallbackUrl, synchronized, vatRate, cardNumber, cardExpiration, cardCvd, cardToken, cardApplePayToken, cardMobilepayOnlineToken, cardIssuedTo, cardBrand, cardStatus, cardEci, cardXav, cardCavv, mobileNumber, ninNumber, ninCountryCode, ninGender, personFirstName, personLastName, personEmail, autoCapture, acquirer, autofee, customerIp, extras, zeroAuth);
            //Assert.IsInstanceOf<Payment> (response, "response is Payment");
        }
        
        /// <summary>
        /// Test POSTPaymentsIdCancelFormat
        /// </summary>
        [Test]
        public void POSTPaymentsIdCancelFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //int? id = null;
            //string quickPayCallbackUrl = null;
            //bool? synchronized = null;
            //var response = instance.POSTPaymentsIdCancelFormat(acceptVersion, authorization, id, quickPayCallbackUrl, synchronized);
            //Assert.IsInstanceOf<Payment> (response, "response is Payment");
        }
        
        /// <summary>
        /// Test POSTPaymentsIdCaptureFormat
        /// </summary>
        [Test]
        public void POSTPaymentsIdCaptureFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //int? id = null;
            //int? amount = null;
            //string quickPayCallbackUrl = null;
            //bool? synchronized = null;
            //Dictionary<string, string> extras = null;
            //var response = instance.POSTPaymentsIdCaptureFormat(acceptVersion, authorization, id, amount, quickPayCallbackUrl, synchronized, extras);
            //Assert.IsInstanceOf<Payment> (response, "response is Payment");
        }
        
        /// <summary>
        /// Test POSTPaymentsIdFraudReportFormat
        /// </summary>
        [Test]
        public void POSTPaymentsIdFraudReportFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //int? id = null;
            //string quickPayCallbackUrl = null;
            //string description = null;
            //var response = instance.POSTPaymentsIdFraudReportFormat(acceptVersion, authorization, id, quickPayCallbackUrl, description);
            //Assert.IsInstanceOf<FraudReport> (response, "response is FraudReport");
        }
        
        /// <summary>
        /// Test POSTPaymentsIdRefundFormat
        /// </summary>
        [Test]
        public void POSTPaymentsIdRefundFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //int? id = null;
            //int? amount = null;
            //string quickPayCallbackUrl = null;
            //bool? synchronized = null;
            //float? vatRate = null;
            //Dictionary<string, string> extras = null;
            //var response = instance.POSTPaymentsIdRefundFormat(acceptVersion, authorization, id, amount, quickPayCallbackUrl, synchronized, vatRate, extras);
            //Assert.IsInstanceOf<Payment> (response, "response is Payment");
        }
        
        /// <summary>
        /// Test POSTPaymentsIdRenewFormat
        /// </summary>
        [Test]
        public void POSTPaymentsIdRenewFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //int? id = null;
            //string quickPayCallbackUrl = null;
            //bool? synchronized = null;
            //var response = instance.POSTPaymentsIdRenewFormat(acceptVersion, authorization, id, quickPayCallbackUrl, synchronized);
            //Assert.IsInstanceOf<Payment> (response, "response is Payment");
        }
        
        /// <summary>
        /// Test POSTPaymentsIdSessionFormat
        /// </summary>
        [Test]
        public void POSTPaymentsIdSessionFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //int? id = null;
            //int? amount = null;
            //string quickPayCallbackUrl = null;
            //bool? synchronized = null;
            //bool? autoCapture = null;
            //string acquirer = null;
            //bool? autofee = null;
            //string customerIp = null;
            //string personFirstName = null;
            //string personLastName = null;
            //string personEmail = null;
            //Dictionary<string, string> extras = null;
            //var response = instance.POSTPaymentsIdSessionFormat(acceptVersion, authorization, id, amount, quickPayCallbackUrl, synchronized, autoCapture, acquirer, autofee, customerIp, personFirstName, personLastName, personEmail, extras);
            //Assert.IsInstanceOf<Payment> (response, "response is Payment");
        }
        
        /// <summary>
        /// Test PUTPaymentsIdLinkFormat
        /// </summary>
        [Test]
        public void PUTPaymentsIdLinkFormatTest()
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
            //bool? autoFee = null;
            //int? brandingId = null;
            //string googleAnalyticsTrackingId = null;
            //string googleAnalyticsClientId = null;
            //string acquirer = null;
            //int? deadline = null;
            //bool? framed = null;
            //Dictionary<string, string> brandingConfig = null;
            //string customerEmail = null;
            //bool? invoiceAddressSelection = null;
            //bool? shippingAddressSelection = null;
            //bool? autoCapture = null;
            //var response = instance.PUTPaymentsIdLinkFormat(acceptVersion, authorization, id, amount, agreementId, language, continueUrl, cancelUrl, callbackUrl, paymentMethods, autoFee, brandingId, googleAnalyticsTrackingId, googleAnalyticsClientId, acquirer, deadline, framed, brandingConfig, customerEmail, invoiceAddressSelection, shippingAddressSelection, autoCapture);
            //Assert.IsInstanceOf<PaymentLinkUrl> (response, "response is PaymentLinkUrl");
        }
        
    }

}