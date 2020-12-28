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
    ///  Class for testing AcquirersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AcquirersApiTests
    {
        private AcquirersApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AcquirersApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AcquirersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AcquirersApi
            //Assert.IsInstanceOfType(typeof(AcquirersApi), instance, "instance is a AcquirersApi");
        }

        
        /// <summary>
        /// Test GETAcquirersBamboraFormat
        /// </summary>
        [Test]
        public void GETAcquirersBamboraFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //var response = instance.GETAcquirersBamboraFormat(acceptVersion, authorization);
            //Assert.IsInstanceOf<AcquirerSettingsBambora> (response, "response is AcquirerSettingsBambora");
        }
        
        /// <summary>
        /// Test GETAcquirersClearhausFormat
        /// </summary>
        [Test]
        public void GETAcquirersClearhausFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //var response = instance.GETAcquirersClearhausFormat(acceptVersion, authorization);
            //Assert.IsInstanceOf<AcquirerSettingsClearhaus> (response, "response is AcquirerSettingsClearhaus");
        }
        
        /// <summary>
        /// Test GETAcquirersCoinifyFormat
        /// </summary>
        [Test]
        public void GETAcquirersCoinifyFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //var response = instance.GETAcquirersCoinifyFormat(acceptVersion, authorization);
            //Assert.IsInstanceOf<AcquirerSettingsCoinify> (response, "response is AcquirerSettingsCoinify");
        }
        
        /// <summary>
        /// Test GETAcquirersElavonFormat
        /// </summary>
        [Test]
        public void GETAcquirersElavonFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //var response = instance.GETAcquirersElavonFormat(acceptVersion, authorization);
            //Assert.IsInstanceOf<AcquirerSettingsElavon> (response, "response is AcquirerSettingsElavon");
        }
        
        /// <summary>
        /// Test GETAcquirersFormat
        /// </summary>
        [Test]
        public void GETAcquirersFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //var response = instance.GETAcquirersFormat(acceptVersion, authorization);
            //Assert.IsInstanceOf<AcquirerSettings> (response, "response is AcquirerSettings");
        }
        
        /// <summary>
        /// Test GETAcquirersHandelsbankenFormat
        /// </summary>
        [Test]
        public void GETAcquirersHandelsbankenFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //var response = instance.GETAcquirersHandelsbankenFormat(acceptVersion, authorization);
            //Assert.IsInstanceOf<AcquirerSettingsHandelsbanken> (response, "response is AcquirerSettingsHandelsbanken");
        }
        
        /// <summary>
        /// Test GETAcquirersKlarnaFormat
        /// </summary>
        [Test]
        public void GETAcquirersKlarnaFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //var response = instance.GETAcquirersKlarnaFormat(acceptVersion, authorization);
            //Assert.IsInstanceOf<AcquirerSettingsKlarna> (response, "response is AcquirerSettingsKlarna");
        }
        
        /// <summary>
        /// Test GETAcquirersKlarnapaymentsFormat
        /// </summary>
        [Test]
        public void GETAcquirersKlarnapaymentsFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //var response = instance.GETAcquirersKlarnapaymentsFormat(acceptVersion, authorization);
            //Assert.IsInstanceOf<AcquirerSettingsKlarnaPayments> (response, "response is AcquirerSettingsKlarnaPayments");
        }
        
        /// <summary>
        /// Test GETAcquirersMobilepayFormat
        /// </summary>
        [Test]
        public void GETAcquirersMobilepayFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //var response = instance.GETAcquirersMobilepayFormat(acceptVersion, authorization);
            //Assert.IsInstanceOf<AcquirerSettingsMobilePay> (response, "response is AcquirerSettingsMobilePay");
        }
        
        /// <summary>
        /// Test GETAcquirersMobilepayonlineFormat
        /// </summary>
        [Test]
        public void GETAcquirersMobilepayonlineFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //var response = instance.GETAcquirersMobilepayonlineFormat(acceptVersion, authorization);
            //Assert.IsInstanceOf<AcquirerSettingsMobilePayOnline> (response, "response is AcquirerSettingsMobilePayOnline");
        }
        
        /// <summary>
        /// Test GETAcquirersMobilepaysubscriptionsFormat
        /// </summary>
        [Test]
        public void GETAcquirersMobilepaysubscriptionsFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //var response = instance.GETAcquirersMobilepaysubscriptionsFormat(acceptVersion, authorization);
            //Assert.IsInstanceOf<AcquirerSettingsMobilePaySubscriptions> (response, "response is AcquirerSettingsMobilePaySubscriptions");
        }
        
        /// <summary>
        /// Test GETAcquirersNetsFormat
        /// </summary>
        [Test]
        public void GETAcquirersNetsFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //var response = instance.GETAcquirersNetsFormat(acceptVersion, authorization);
            //Assert.IsInstanceOf<AcquirerSettingsNets> (response, "response is AcquirerSettingsNets");
        }
        
        /// <summary>
        /// Test GETAcquirersPaypalFormat
        /// </summary>
        [Test]
        public void GETAcquirersPaypalFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //var response = instance.GETAcquirersPaypalFormat(acceptVersion, authorization);
            //Assert.IsInstanceOf<AcquirerSettingsPayPal> (response, "response is AcquirerSettingsPayPal");
        }
        
        /// <summary>
        /// Test GETAcquirersPaysafecardFormat
        /// </summary>
        [Test]
        public void GETAcquirersPaysafecardFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //var response = instance.GETAcquirersPaysafecardFormat(acceptVersion, authorization);
            //Assert.IsInstanceOf<AcquirerSettingsPaysafecard> (response, "response is AcquirerSettingsPaysafecard");
        }
        
        /// <summary>
        /// Test GETAcquirersResursFormat
        /// </summary>
        [Test]
        public void GETAcquirersResursFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //var response = instance.GETAcquirersResursFormat(acceptVersion, authorization);
            //Assert.IsInstanceOf<AcquirerSettingsResurs> (response, "response is AcquirerSettingsResurs");
        }
        
        /// <summary>
        /// Test GETAcquirersSofortFormat
        /// </summary>
        [Test]
        public void GETAcquirersSofortFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //var response = instance.GETAcquirersSofortFormat(acceptVersion, authorization);
            //Assert.IsInstanceOf<AcquirerSettingsSofort> (response, "response is AcquirerSettingsSofort");
        }
        
        /// <summary>
        /// Test GETAcquirersSwedbankFormat
        /// </summary>
        [Test]
        public void GETAcquirersSwedbankFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //var response = instance.GETAcquirersSwedbankFormat(acceptVersion, authorization);
            //Assert.IsInstanceOf<AcquirerSettingsSwedbank> (response, "response is AcquirerSettingsSwedbank");
        }
        
        /// <summary>
        /// Test GETAcquirersSwishFormat
        /// </summary>
        [Test]
        public void GETAcquirersSwishFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //var response = instance.GETAcquirersSwishFormat(acceptVersion, authorization);
            //Assert.IsInstanceOf<AcquirerSettingsSwish> (response, "response is AcquirerSettingsSwish");
        }
        
        /// <summary>
        /// Test GETAcquirersTellerFormat
        /// </summary>
        [Test]
        public void GETAcquirersTellerFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //var response = instance.GETAcquirersTellerFormat(acceptVersion, authorization);
            //Assert.IsInstanceOf<AcquirerSettingsTeller> (response, "response is AcquirerSettingsTeller");
        }
        
        /// <summary>
        /// Test GETAcquirersTrustlyFormat
        /// </summary>
        [Test]
        public void GETAcquirersTrustlyFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //var response = instance.GETAcquirersTrustlyFormat(acceptVersion, authorization);
            //Assert.IsInstanceOf<AcquirerSettingsTrustly> (response, "response is AcquirerSettingsTrustly");
        }
        
        /// <summary>
        /// Test GETAcquirersValitorFormat
        /// </summary>
        [Test]
        public void GETAcquirersValitorFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //var response = instance.GETAcquirersValitorFormat(acceptVersion, authorization);
            //Assert.IsInstanceOf<AcquirerSettingsValitor> (response, "response is AcquirerSettingsValitor");
        }
        
        /// <summary>
        /// Test GETAcquirersViabillFormat
        /// </summary>
        [Test]
        public void GETAcquirersViabillFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //var response = instance.GETAcquirersViabillFormat(acceptVersion, authorization);
            //Assert.IsInstanceOf<AcquirerSettingsViaBill> (response, "response is AcquirerSettingsViaBill");
        }
        
        /// <summary>
        /// Test GETAcquirersVippsFormat
        /// </summary>
        [Test]
        public void GETAcquirersVippsFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //var response = instance.GETAcquirersVippsFormat(acceptVersion, authorization);
            //Assert.IsInstanceOf<AcquirerSettingsVipps> (response, "response is AcquirerSettingsVipps");
        }
        
        /// <summary>
        /// Test PATCHAcquirersBamboraFormat
        /// </summary>
        [Test]
        public void PATCHAcquirersBamboraFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //bool? active = null;
            //string identificationCode = null;
            //string businessCode = null;
            //string identificationCodeInt = null;
            //bool? recurring = null;
            //bool? americanexpress = null;
            //bool? dinersclub = null;
            //bool? securepay = null;
            //string visaMpiMerchantId = null;
            //string mastercardMpiMerchantId = null;
            //string visaBin = null;
            //string mastercardBin = null;
            //var response = instance.PATCHAcquirersBamboraFormat(acceptVersion, authorization, active, identificationCode, businessCode, identificationCodeInt, recurring, americanexpress, dinersclub, securepay, visaMpiMerchantId, mastercardMpiMerchantId, visaBin, mastercardBin);
            //Assert.IsInstanceOf<AcquirerSettingsBambora> (response, "response is AcquirerSettingsBambora");
        }
        
        /// <summary>
        /// Test PATCHAcquirersClearhausFormat
        /// </summary>
        [Test]
        public void PATCHAcquirersClearhausFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //bool? active = null;
            //string apiKey = null;
            //bool? recurring = null;
            //bool? payout = null;
            //bool? applePay = null;
            //var response = instance.PATCHAcquirersClearhausFormat(acceptVersion, authorization, active, apiKey, recurring, payout, applePay);
            //Assert.IsInstanceOf<AcquirerSettingsClearhaus> (response, "response is AcquirerSettingsClearhaus");
        }
        
        /// <summary>
        /// Test PATCHAcquirersCoinifyFormat
        /// </summary>
        [Test]
        public void PATCHAcquirersCoinifyFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //bool? active = null;
            //string apiKey = null;
            //string apiSecret = null;
            //string ipnSecret = null;
            //var response = instance.PATCHAcquirersCoinifyFormat(acceptVersion, authorization, active, apiKey, apiSecret, ipnSecret);
            //Assert.IsInstanceOf<AcquirerSettingsCoinify> (response, "response is AcquirerSettingsCoinify");
        }
        
        /// <summary>
        /// Test PATCHAcquirersElavonFormat
        /// </summary>
        [Test]
        public void PATCHAcquirersElavonFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //bool? active = null;
            //string identificationCode = null;
            //string businessCode = null;
            //string identificationCodeInt = null;
            //bool? recurring = null;
            //bool? americanexpress = null;
            //bool? dinersclub = null;
            //bool? securepay = null;
            //string visaMpiMerchantId = null;
            //string mastercardMpiMerchantId = null;
            //string visaBin = null;
            //string mastercardBin = null;
            //var response = instance.PATCHAcquirersElavonFormat(acceptVersion, authorization, active, identificationCode, businessCode, identificationCodeInt, recurring, americanexpress, dinersclub, securepay, visaMpiMerchantId, mastercardMpiMerchantId, visaBin, mastercardBin);
            //Assert.IsInstanceOf<AcquirerSettingsElavon> (response, "response is AcquirerSettingsElavon");
        }
        
        /// <summary>
        /// Test PATCHAcquirersHandelsbankenFormat
        /// </summary>
        [Test]
        public void PATCHAcquirersHandelsbankenFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //bool? active = null;
            //string identificationCode = null;
            //string businessCode = null;
            //string identificationCodeInt = null;
            //bool? recurring = null;
            //bool? americanexpress = null;
            //bool? dinersclub = null;
            //bool? securepay = null;
            //string visaMpiMerchantId = null;
            //string mastercardMpiMerchantId = null;
            //string visaBin = null;
            //string mastercardBin = null;
            //var response = instance.PATCHAcquirersHandelsbankenFormat(acceptVersion, authorization, active, identificationCode, businessCode, identificationCodeInt, recurring, americanexpress, dinersclub, securepay, visaMpiMerchantId, mastercardMpiMerchantId, visaBin, mastercardBin);
            //Assert.IsInstanceOf<AcquirerSettingsHandelsbanken> (response, "response is AcquirerSettingsHandelsbanken");
        }
        
        /// <summary>
        /// Test PATCHAcquirersKlarnaFormat
        /// </summary>
        [Test]
        public void PATCHAcquirersKlarnaFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //bool? active = null;
            //int? eid = null;
            //string sharedSecret = null;
            //var response = instance.PATCHAcquirersKlarnaFormat(acceptVersion, authorization, active, eid, sharedSecret);
            //Assert.IsInstanceOf<AcquirerSettingsKlarna> (response, "response is AcquirerSettingsKlarna");
        }
        
        /// <summary>
        /// Test PATCHAcquirersKlarnapaymentsFormat
        /// </summary>
        [Test]
        public void PATCHAcquirersKlarnapaymentsFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //bool? active = null;
            //string uid = null;
            //string password = null;
            //var response = instance.PATCHAcquirersKlarnapaymentsFormat(acceptVersion, authorization, active, uid, password);
            //Assert.IsInstanceOf<AcquirerSettingsKlarnaPayments> (response, "response is AcquirerSettingsKlarnaPayments");
        }
        
        /// <summary>
        /// Test PATCHAcquirersMobilepayFormat
        /// </summary>
        [Test]
        public void PATCHAcquirersMobilepayFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //bool? active = null;
            //string deliveryLimitedTo = null;
            //var response = instance.PATCHAcquirersMobilepayFormat(acceptVersion, authorization, active, deliveryLimitedTo);
            //Assert.IsInstanceOf<AcquirerSettingsMobilePay> (response, "response is AcquirerSettingsMobilePay");
        }
        
        /// <summary>
        /// Test PATCHAcquirersMobilepayonlineFormat
        /// </summary>
        [Test]
        public void PATCHAcquirersMobilepayonlineFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //bool? active = null;
            //int? merchantId = null;
            //string deliveryLimitedTo = null;
            //var response = instance.PATCHAcquirersMobilepayonlineFormat(acceptVersion, authorization, active, merchantId, deliveryLimitedTo);
            //Assert.IsInstanceOf<AcquirerSettingsMobilePayOnline> (response, "response is AcquirerSettingsMobilePayOnline");
        }
        
        /// <summary>
        /// Test PATCHAcquirersMobilepaysubscriptionsFormat
        /// </summary>
        [Test]
        public void PATCHAcquirersMobilepaysubscriptionsFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //bool? active = null;
            //string authState = null;
            //string codeVerifier = null;
            //int? lastTokenRefresh = null;
            //string nonce = null;
            //int? pendingStatus = null;
            //string provider = null;
            //string refreshToken = null;
            //var response = instance.PATCHAcquirersMobilepaysubscriptionsFormat(acceptVersion, authorization, active, authState, codeVerifier, lastTokenRefresh, nonce, pendingStatus, provider, refreshToken);
            //Assert.IsInstanceOf<AcquirerSettingsMobilePaySubscriptions> (response, "response is AcquirerSettingsMobilePaySubscriptions");
        }
        
        /// <summary>
        /// Test PATCHAcquirersNetsFormat
        /// </summary>
        [Test]
        public void PATCHAcquirersNetsFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //bool? active = null;
            //string identificationCode = null;
            //string businessCode = null;
            //bool? recurring = null;
            //bool? fbg1886 = null;
            //bool? securedByNets = null;
            //string identificationCodeInt = null;
            //bool? americanexpress = null;
            //bool? dinersclub = null;
            //bool? securepay = null;
            //string visaBin = null;
            //string mastercardBin = null;
            //var response = instance.PATCHAcquirersNetsFormat(acceptVersion, authorization, active, identificationCode, businessCode, recurring, fbg1886, securedByNets, identificationCodeInt, americanexpress, dinersclub, securepay, visaBin, mastercardBin);
            //Assert.IsInstanceOf<AcquirerSettingsNets> (response, "response is AcquirerSettingsNets");
        }
        
        /// <summary>
        /// Test PATCHAcquirersPaypalFormat
        /// </summary>
        [Test]
        public void PATCHAcquirersPaypalFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //bool? active = null;
            //bool? recurring = null;
            //bool? creditCard = null;
            //string token = null;
            //string tokenSecret = null;
            //string scope = null;
            //var response = instance.PATCHAcquirersPaypalFormat(acceptVersion, authorization, active, recurring, creditCard, token, tokenSecret, scope);
            //Assert.IsInstanceOf<AcquirerSettingsPayPal> (response, "response is AcquirerSettingsPayPal");
        }
        
        /// <summary>
        /// Test PATCHAcquirersPaysafecardFormat
        /// </summary>
        [Test]
        public void PATCHAcquirersPaysafecardFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //bool? active = null;
            //string username = null;
            //string password = null;
            //string currencies = null;
            //var response = instance.PATCHAcquirersPaysafecardFormat(acceptVersion, authorization, active, username, password, currencies);
            //Assert.IsInstanceOf<AcquirerSettingsPaysafecard> (response, "response is AcquirerSettingsPaysafecard");
        }
        
        /// <summary>
        /// Test PATCHAcquirersResursFormat
        /// </summary>
        [Test]
        public void PATCHAcquirersResursFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //bool? active = null;
            //string customerId = null;
            //string customerPassword = null;
            //var response = instance.PATCHAcquirersResursFormat(acceptVersion, authorization, active, customerId, customerPassword);
            //Assert.IsInstanceOf<AcquirerSettingsResurs> (response, "response is AcquirerSettingsResurs");
        }
        
        /// <summary>
        /// Test PATCHAcquirersSofortFormat
        /// </summary>
        [Test]
        public void PATCHAcquirersSofortFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //bool? active = null;
            //int? customerNumber = null;
            //int? projectId = null;
            //string apiKey = null;
            //bool? gateway = null;
            //bool? ideal = null;
            //int? idealProjectId = null;
            //string idealProjectPassword = null;
            //string idealNotificationPassword = null;
            //var response = instance.PATCHAcquirersSofortFormat(acceptVersion, authorization, active, customerNumber, projectId, apiKey, gateway, ideal, idealProjectId, idealProjectPassword, idealNotificationPassword);
            //Assert.IsInstanceOf<AcquirerSettingsSofort> (response, "response is AcquirerSettingsSofort");
        }
        
        /// <summary>
        /// Test PATCHAcquirersSwedbankFormat
        /// </summary>
        [Test]
        public void PATCHAcquirersSwedbankFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //bool? active = null;
            //string identificationCode = null;
            //string businessCode = null;
            //string identificationCodeInt = null;
            //bool? recurring = null;
            //bool? americanexpress = null;
            //bool? dinersclub = null;
            //bool? securepay = null;
            //string visaMpiMerchantId = null;
            //string mastercardMpiMerchantId = null;
            //string visaBin = null;
            //string mastercardBin = null;
            //var response = instance.PATCHAcquirersSwedbankFormat(acceptVersion, authorization, active, identificationCode, businessCode, identificationCodeInt, recurring, americanexpress, dinersclub, securepay, visaMpiMerchantId, mastercardMpiMerchantId, visaBin, mastercardBin);
            //Assert.IsInstanceOf<AcquirerSettingsSwedbank> (response, "response is AcquirerSettingsSwedbank");
        }
        
        /// <summary>
        /// Test PATCHAcquirersSwishFormat
        /// </summary>
        [Test]
        public void PATCHAcquirersSwishFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //bool? active = null;
            //string merchantId = null;
            //int? cryptographyKeyId = null;
            //var response = instance.PATCHAcquirersSwishFormat(acceptVersion, authorization, active, merchantId, cryptographyKeyId);
            //Assert.IsInstanceOf<AcquirerSettingsSwish> (response, "response is AcquirerSettingsSwish");
        }
        
        /// <summary>
        /// Test PATCHAcquirersTellerFormat
        /// </summary>
        [Test]
        public void PATCHAcquirersTellerFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //bool? active = null;
            //string identificationCode = null;
            //string businessCode = null;
            //string identificationCodeInt = null;
            //bool? recurring = null;
            //bool? americanexpress = null;
            //bool? dinersclub = null;
            //bool? securepay = null;
            //string visaMpiMerchantId = null;
            //string mastercardMpiMerchantId = null;
            //string visaBin = null;
            //string mastercardBin = null;
            //var response = instance.PATCHAcquirersTellerFormat(acceptVersion, authorization, active, identificationCode, businessCode, identificationCodeInt, recurring, americanexpress, dinersclub, securepay, visaMpiMerchantId, mastercardMpiMerchantId, visaBin, mastercardBin);
            //Assert.IsInstanceOf<AcquirerSettingsTeller> (response, "response is AcquirerSettingsTeller");
        }
        
        /// <summary>
        /// Test PATCHAcquirersTrustlyFormat
        /// </summary>
        [Test]
        public void PATCHAcquirersTrustlyFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //bool? active = null;
            //bool? ideal = null;
            //string username = null;
            //string password = null;
            //var response = instance.PATCHAcquirersTrustlyFormat(acceptVersion, authorization, active, ideal, username, password);
            //Assert.IsInstanceOf<AcquirerSettingsTrustly> (response, "response is AcquirerSettingsTrustly");
        }
        
        /// <summary>
        /// Test PATCHAcquirersValitorFormat
        /// </summary>
        [Test]
        public void PATCHAcquirersValitorFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //bool? active = null;
            //string identificationCode = null;
            //string businessCode = null;
            //string identificationCodeInt = null;
            //bool? recurring = null;
            //bool? americanexpress = null;
            //bool? dinersclub = null;
            //bool? securepay = null;
            //string visaMpiMerchantId = null;
            //string mastercardMpiMerchantId = null;
            //string visaBin = null;
            //string mastercardBin = null;
            //var response = instance.PATCHAcquirersValitorFormat(acceptVersion, authorization, active, identificationCode, businessCode, identificationCodeInt, recurring, americanexpress, dinersclub, securepay, visaMpiMerchantId, mastercardMpiMerchantId, visaBin, mastercardBin);
            //Assert.IsInstanceOf<AcquirerSettingsValitor> (response, "response is AcquirerSettingsValitor");
        }
        
        /// <summary>
        /// Test PATCHAcquirersViabillFormat
        /// </summary>
        [Test]
        public void PATCHAcquirersViabillFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //bool? active = null;
            //string apiKey = null;
            //var response = instance.PATCHAcquirersViabillFormat(acceptVersion, authorization, active, apiKey);
            //Assert.IsInstanceOf<AcquirerSettingsViaBill> (response, "response is AcquirerSettingsViaBill");
        }
        
        /// <summary>
        /// Test PATCHAcquirersVippsFormat
        /// </summary>
        [Test]
        public void PATCHAcquirersVippsFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //bool? active = null;
            //string clientId = null;
            //string clientSecret = null;
            //string serialNumber = null;
            //string accessTokenSubscriptionKey = null;
            //string ecommerceSubscriptionKey = null;
            //string orgno = null;
            //var response = instance.PATCHAcquirersVippsFormat(acceptVersion, authorization, active, clientId, clientSecret, serialNumber, accessTokenSubscriptionKey, ecommerceSubscriptionKey, orgno);
            //Assert.IsInstanceOf<AcquirerSettingsVipps> (response, "response is AcquirerSettingsVipps");
        }
        
        /// <summary>
        /// Test POSTAcquirersAcquirerTestFormat
        /// </summary>
        [Test]
        public void POSTAcquirersAcquirerTestFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptVersion = null;
            //string authorization = null;
            //string acquirer = null;
            //var response = instance.POSTAcquirersAcquirerTestFormat(acceptVersion, authorization, acquirer);
            //Assert.IsInstanceOf<AcquirerTest> (response, "response is AcquirerTest");
        }
        
    }

}
