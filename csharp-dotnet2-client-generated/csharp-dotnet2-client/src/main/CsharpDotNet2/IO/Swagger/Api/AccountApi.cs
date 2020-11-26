using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAccountApi
    {
        /// <summary>
        /// Delete 04 platform settings  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <returns>QuickPayProtocolV10Zero4PlatformSettings</returns>
        QuickPayProtocolV10Zero4PlatformSettings DELETEAccount04PlatformFormat (string acceptVersion, string authorization);
        /// <summary>
        /// Delete merchant account  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <returns></returns>
        void DELETEAccountFormat (string acceptVersion, string authorization);
        /// <summary>
        /// Deletes the current merchant logo  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="logoType">&lt;p&gt;Type of logo&lt;/p&gt; </param>
        /// <returns></returns>
        void DELETEAccountLogoFormat (string acceptVersion, string authorization, string logoType);
        /// <summary>
        /// Get 04 platform settings  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <returns>QuickPayProtocolV10Zero4PlatformSettings</returns>
        QuickPayProtocolV10Zero4PlatformSettings GETAccount04PlatformFormat (string acceptVersion, string authorization);
        /// <summary>
        /// Get merchant account  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <returns>QuickPayProtocolV10Merchant</returns>
        QuickPayProtocolV10Merchant GETAccountFormat (string acceptVersion, string authorization);
        /// <summary>
        /// Gets the merchant logo as a raw download or a 404 if none exists  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="logoType">&lt;p&gt;Type of logo&lt;/p&gt; </param>
        /// <returns></returns>
        void GETAccountLogoFormat (string acceptVersion, string authorization, string logoType);
        /// <summary>
        /// Gets the private key of the merchant  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <returns>QuickPayProtocolV10PrivateKey</returns>
        QuickPayProtocolV10PrivateKey GETAccountPrivateKeyFormat (string acceptVersion, string authorization);
        /// <summary>
        /// Update merchant account  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="customerAddressName">&lt;p&gt;Name&lt;/p&gt; </param>
        /// <param name="customerAddressAtt">&lt;p&gt;Att&lt;/p&gt; </param>
        /// <param name="customerAddressStreet">&lt;p&gt;Street&lt;/p&gt; </param>
        /// <param name="customerAddressCity">&lt;p&gt;City&lt;/p&gt; </param>
        /// <param name="customerAddressZipCode">&lt;p&gt;Zip code&lt;/p&gt; </param>
        /// <param name="customerAddressRegion">&lt;p&gt;Region&lt;/p&gt; </param>
        /// <param name="customerAddressCountryCode">&lt;p&gt;Three letter country code according to ISO 3166-1 Alpha-3&lt;/p&gt; </param>
        /// <param name="customerAddressVatNo">&lt;p&gt;VAT registration number&lt;/p&gt; </param>
        /// <param name="billingAddressName">&lt;p&gt;Name&lt;/p&gt; </param>
        /// <param name="billingAddressAtt">&lt;p&gt;Att&lt;/p&gt; </param>
        /// <param name="billingAddressStreet">&lt;p&gt;Street&lt;/p&gt; </param>
        /// <param name="billingAddressCity">&lt;p&gt;City&lt;/p&gt; </param>
        /// <param name="billingAddressZipCode">&lt;p&gt;Zip code&lt;/p&gt; </param>
        /// <param name="billingAddressRegion">&lt;p&gt;Region&lt;/p&gt; </param>
        /// <param name="billingAddressCountryCode">&lt;p&gt;Three letter country code according to ISO 3166-1 Alpha-3&lt;/p&gt; </param>
        /// <param name="billingAddressVatNo">&lt;p&gt;VAT registration number&lt;/p&gt; </param>
        /// <param name="callbackUrl">&lt;p&gt;Callback url&lt;/p&gt; </param>
        /// <param name="acquirerSettingsBamboraActive">&lt;p&gt;Enable Bambora payments&lt;/p&gt; </param>
        /// <param name="acquirerSettingsBamboraIdentificationCode">&lt;p&gt;Bambora identification number&lt;/p&gt; </param>
        /// <param name="acquirerSettingsBamboraIdentificationCodeInt">&lt;p&gt;Bambora international identification number&lt;/p&gt; </param>
        /// <param name="acquirerSettingsBamboraBusinessCode">&lt;p&gt;Business code (assigned by Bambora)&lt;/p&gt; </param>
        /// <param name="acquirerSettingsBamboraRecurring">&lt;p&gt;Enable recurring payments (requires agreement with Bambora)&lt;/p&gt; </param>
        /// <param name="acquirerSettingsBamboraAmericanexpress">&lt;p&gt;Enable AMEX payments (requires agreement with Bambora)&lt;/p&gt; </param>
        /// <param name="acquirerSettingsBamboraDinersclub">&lt;p&gt;Enable Diners Club payments (requires agreement with Bambora)&lt;/p&gt; </param>
        /// <param name="acquirerSettingsBamboraSecurepay">&lt;p&gt;Enable SecurePay fraud protection.&lt;/p&gt; </param>
        /// <param name="acquirerSettingsBamboraVisaMpiMerchantId">&lt;p&gt;VISA MPI merchant id. Used for 3D secure transactions&lt;/p&gt; </param>
        /// <param name="acquirerSettingsBamboraMastercardMpiMerchantId">&lt;p&gt;Mastercard MPI merchant id. Used for 3D secure transactions&lt;/p&gt; </param>
        /// <param name="acquirerSettingsBamboraVisaBin">&lt;p&gt;VISA acquirer bin used for 3D Secure&lt;/p&gt; </param>
        /// <param name="acquirerSettingsBamboraMastercardBin">&lt;p&gt;Mastercard acquirer bin used for 3D Secure&lt;/p&gt; </param>
        /// <param name="acquirerSettingsClearhausActive">&lt;p&gt;Enable ClearHaus payments&lt;/p&gt; </param>
        /// <param name="acquirerSettingsClearhausApiKey">&lt;p&gt;Clearhaus API key (is required but may be left empty)&lt;/p&gt; </param>
        /// <param name="acquirerSettingsClearhausRecurring">&lt;p&gt;Enable recurring payments (requires agreement with Clearhaus)&lt;/p&gt; </param>
        /// <param name="acquirerSettingsClearhausPayout">&lt;p&gt;Enable payouts (requires agreement with Clearhaus)&lt;/p&gt; </param>
        /// <param name="acquirerSettingsClearhausApplePay">&lt;p&gt;Enable Apple Pay (requires agreement with Clearhaus)&lt;/p&gt; </param>
        /// <param name="acquirerSettingsElavonActive">&lt;p&gt;Enable Elavon payments&lt;/p&gt; </param>
        /// <param name="acquirerSettingsElavonIdentificationCode">&lt;p&gt;Elavon identification number&lt;/p&gt; </param>
        /// <param name="acquirerSettingsElavonIdentificationCodeInt">&lt;p&gt;Elavon international identification number&lt;/p&gt; </param>
        /// <param name="acquirerSettingsElavonBusinessCode">&lt;p&gt;Business code (assigned by Elavon)&lt;/p&gt; </param>
        /// <param name="acquirerSettingsElavonRecurring">&lt;p&gt;Enable recurring payments (requires agreement with Elavon)&lt;/p&gt; </param>
        /// <param name="acquirerSettingsElavonAmericanexpress">&lt;p&gt;Enable AMEX payments (requires agreement with Elavon)&lt;/p&gt; </param>
        /// <param name="acquirerSettingsElavonDinersclub">&lt;p&gt;Enable Diners Club payments (requires agreement with Elavon)&lt;/p&gt; </param>
        /// <param name="acquirerSettingsElavonSecurepay">&lt;p&gt;Enable SecurePay fraud protection.&lt;/p&gt; </param>
        /// <param name="acquirerSettingsElavonVisaMpiMerchantId">&lt;p&gt;VISA MPI merchant id. Used for 3D secure transactions&lt;/p&gt; </param>
        /// <param name="acquirerSettingsElavonMastercardMpiMerchantId">&lt;p&gt;Mastercard MPI merchant id. Used for 3D secure transactions&lt;/p&gt; </param>
        /// <param name="acquirerSettingsElavonVisaBin">&lt;p&gt;VISA acquirer bin used for 3D Secure&lt;/p&gt; </param>
        /// <param name="acquirerSettingsElavonMastercardBin">&lt;p&gt;Mastercard acquirer bin used for 3D Secure&lt;/p&gt; </param>
        /// <param name="acquirerSettingsHandelsbankenActive">&lt;p&gt;Enable Handelsbanken payments&lt;/p&gt; </param>
        /// <param name="acquirerSettingsHandelsbankenIdentificationCode">&lt;p&gt;Handelsbanken identification number&lt;/p&gt; </param>
        /// <param name="acquirerSettingsHandelsbankenIdentificationCodeInt">&lt;p&gt;Handelsbanken international identification number&lt;/p&gt; </param>
        /// <param name="acquirerSettingsHandelsbankenBusinessCode">&lt;p&gt;Business code (assigned by Handelsbanken)&lt;/p&gt; </param>
        /// <param name="acquirerSettingsHandelsbankenRecurring">&lt;p&gt;Enable recurring payments (requires agreement with Handelsbanken)&lt;/p&gt; </param>
        /// <param name="acquirerSettingsHandelsbankenAmericanexpress">&lt;p&gt;Enable AMEX payments (requires agreement with Handelsbanken)&lt;/p&gt; </param>
        /// <param name="acquirerSettingsHandelsbankenDinersclub">&lt;p&gt;Enable Diners Club payments (requires agreement with Handelsbanken)&lt;/p&gt; </param>
        /// <param name="acquirerSettingsHandelsbankenSecurepay">&lt;p&gt;Enable SecurePay fraud protection.&lt;/p&gt; </param>
        /// <param name="acquirerSettingsHandelsbankenVisaMpiMerchantId">&lt;p&gt;VISA MPI merchant id. Used for 3D secure transactions&lt;/p&gt; </param>
        /// <param name="acquirerSettingsHandelsbankenMastercardMpiMerchantId">&lt;p&gt;Mastercard MPI merchant id. Used for 3D secure transactions&lt;/p&gt; </param>
        /// <param name="acquirerSettingsHandelsbankenVisaBin">&lt;p&gt;VISA acquirer bin used for 3D Secure&lt;/p&gt; </param>
        /// <param name="acquirerSettingsHandelsbankenMastercardBin">&lt;p&gt;Mastercard acquirer bin used for 3D Secure&lt;/p&gt; </param>
        /// <param name="acquirerSettingsKlarnaActive">&lt;p&gt;Enable Klarna payments&lt;/p&gt; </param>
        /// <param name="acquirerSettingsKlarnaEid">&lt;p&gt;Klarna merchant ID&lt;/p&gt; </param>
        /// <param name="acquirerSettingsKlarnaSharedSecret">&lt;p&gt;Klarna shared secret&lt;/p&gt; </param>
        /// <param name="acquirerSettingsMobilepayActive">&lt;p&gt;Enable MobilePay payments&lt;/p&gt; </param>
        /// <param name="acquirerSettingsMobilepayDeliveryLimitedTo">&lt;p&gt;Limit MobilePay delivery address selection to theses countries. (ISO 3166-1 alpha-2 without delimiter ‘DKNOSEFI’) (Valid options are DK,NO,SE,FI)&lt;/p&gt; </param>
        /// <param name="acquirerSettingsMobilepaysubscriptionsActive">&lt;p&gt;Enable MobilePay Subscriptions payments&lt;/p&gt; </param>
        /// <param name="acquirerSettingsMobilepaysubscriptionsAuthState">&lt;p&gt;Identifier MobilePay Subscriptions uses to link requests to callbacks&lt;/p&gt; </param>
        /// <param name="acquirerSettingsMobilepaysubscriptionsCodeVerifier">&lt;p&gt;Verifies received code challenge&lt;/p&gt; </param>
        /// <param name="acquirerSettingsMobilepaysubscriptionsLastTokenRefresh">&lt;p&gt;Unix Timestamp of last time the tokens were refreshed&lt;/p&gt; </param>
        /// <param name="acquirerSettingsMobilepaysubscriptionsNonce">&lt;p&gt;Associate client sessions with ID Tokens to mitigate replay attacks&lt;/p&gt; </param>
        /// <param name="acquirerSettingsMobilepaysubscriptionsPendingStatus">&lt;p&gt;0: agreement inactive, 1: flow initialised, 2: tokens received, 3: flow completed&lt;/p&gt; </param>
        /// <param name="acquirerSettingsMobilepaysubscriptionsProvider">&lt;p&gt;The provider / sales-place chosen by the merchant&lt;/p&gt; </param>
        /// <param name="acquirerSettingsMobilepaysubscriptionsRefreshToken">&lt;p&gt;Token to refresh access token for up to 1 year&lt;/p&gt; </param>
        /// <param name="acquirerSettingsNetsActive">&lt;p&gt;Enable Nets/Teller payments&lt;/p&gt; </param>
        /// <param name="acquirerSettingsNetsIdentificationCode">&lt;p&gt;Nets TOF number&lt;/p&gt; </param>
        /// <param name="acquirerSettingsNetsBusinessCode">&lt;p&gt;Business code (assigned by Nets)&lt;/p&gt; </param>
        /// <param name="acquirerSettingsNetsRecurring">&lt;p&gt;Enable recurring payments (requires agreement with Nets)&lt;/p&gt; </param>
        /// <param name="acquirerSettingsNetsFbg1886">&lt;p&gt;Enable Forbrugsforeningen payments (requires agreement with Nets and Forbrugsforeningen)&lt;/p&gt; </param>
        /// <param name="acquirerSettingsNetsSecuredByNets">&lt;p&gt;Enable SecuredByNets fraud protection.&lt;/p&gt; </param>
        /// <param name="acquirerSettingsNetsIdentificationCodeInt">&lt;p&gt;(Depricated; use Teller acquirer)&lt;/p&gt; </param>
        /// <param name="acquirerSettingsNetsAmericanexpress">&lt;p&gt;(Depricated; use Teller acquirer)&lt;/p&gt; </param>
        /// <param name="acquirerSettingsNetsDinersclub">&lt;p&gt;(Depricated; use Teller acquirer)&lt;/p&gt; </param>
        /// <param name="acquirerSettingsNetsSecurepay">&lt;p&gt;(Depricated; use Teller acquirer)&lt;/p&gt; </param>
        /// <param name="acquirerSettingsNetsVisaBin">&lt;p&gt;(Depricated; use Teller acquirer)&lt;/p&gt; </param>
        /// <param name="acquirerSettingsNetsMastercardBin">&lt;p&gt;(Depricated; use Teller acquirer)&lt;/p&gt; </param>
        /// <param name="acquirerSettingsPaypalActive">&lt;p&gt;Enable PayPal payments&lt;/p&gt; </param>
        /// <param name="acquirerSettingsPaypalRecurring">&lt;p&gt;Enable recurring payments&lt;/p&gt; </param>
        /// <param name="acquirerSettingsPaypalCreditCard">&lt;p&gt;Allow credit-card payments. (Only for US/CA/UK merchants)&lt;/p&gt; </param>
        /// <param name="acquirerSettingsPaypalToken">&lt;p&gt;Authentication token&lt;/p&gt; </param>
        /// <param name="acquirerSettingsPaypalTokenSecret">&lt;p&gt;Authentication token secret&lt;/p&gt; </param>
        /// <param name="acquirerSettingsPaypalScope">&lt;p&gt;Authentication scope&lt;/p&gt; </param>
        /// <param name="acquirerSettingsSofortActive">&lt;p&gt;Enable Sofort payments&lt;/p&gt; </param>
        /// <param name="acquirerSettingsSofortCustomerNumber">&lt;p&gt;Sofort customer number&lt;/p&gt; </param>
        /// <param name="acquirerSettingsSofortProjectId">&lt;p&gt;Sofort Gateway project id&lt;/p&gt; </param>
        /// <param name="acquirerSettingsSofortApiKey">&lt;p&gt;Sofort API key&lt;/p&gt; </param>
        /// <param name="acquirerSettingsSofortGateway">&lt;p&gt;Enable Sofort Gateway feature&lt;/p&gt; </param>
        /// <param name="acquirerSettingsSofortIdeal">&lt;p&gt;Enable Sofort iDeal feature&lt;/p&gt; </param>
        /// <param name="acquirerSettingsSofortIdealProjectId">&lt;p&gt;Sofort iDeal project id&lt;/p&gt; </param>
        /// <param name="acquirerSettingsSofortIdealProjectPassword">&lt;p&gt;Sofort iDeal project password&lt;/p&gt; </param>
        /// <param name="acquirerSettingsSofortIdealNotificationPassword">&lt;p&gt;Sofort iDeal notification password&lt;/p&gt; </param>
        /// <param name="acquirerSettingsSwedbankActive">&lt;p&gt;Enable Swedbank payments&lt;/p&gt; </param>
        /// <param name="acquirerSettingsSwedbankIdentificationCode">&lt;p&gt;Swedbank identification number&lt;/p&gt; </param>
        /// <param name="acquirerSettingsSwedbankIdentificationCodeInt">&lt;p&gt;Swedbank international identification number&lt;/p&gt; </param>
        /// <param name="acquirerSettingsSwedbankBusinessCode">&lt;p&gt;Business code (assigned by Swedbank)&lt;/p&gt; </param>
        /// <param name="acquirerSettingsSwedbankRecurring">&lt;p&gt;Enable recurring payments (requires agreement with Swedbank)&lt;/p&gt; </param>
        /// <param name="acquirerSettingsSwedbankAmericanexpress">&lt;p&gt;Enable AMEX payments (requires agreement with Swedbank)&lt;/p&gt; </param>
        /// <param name="acquirerSettingsSwedbankDinersclub">&lt;p&gt;Enable Diners Club payments (requires agreement with Swedbank)&lt;/p&gt; </param>
        /// <param name="acquirerSettingsSwedbankSecurepay">&lt;p&gt;Enable SecurePay fraud protection.&lt;/p&gt; </param>
        /// <param name="acquirerSettingsSwedbankVisaMpiMerchantId">&lt;p&gt;VISA MPI merchant id. Used for 3D secure transactions&lt;/p&gt; </param>
        /// <param name="acquirerSettingsSwedbankMastercardMpiMerchantId">&lt;p&gt;Mastercard MPI merchant id. Used for 3D secure transactions&lt;/p&gt; </param>
        /// <param name="acquirerSettingsSwedbankVisaBin">&lt;p&gt;VISA acquirer bin used for 3D Secure&lt;/p&gt; </param>
        /// <param name="acquirerSettingsSwedbankMastercardBin">&lt;p&gt;Mastercard acquirer bin used for 3D Secure&lt;/p&gt; </param>
        /// <param name="acquirerSettingsTellerActive">&lt;p&gt;Enable Teller payments&lt;/p&gt; </param>
        /// <param name="acquirerSettingsTellerIdentificationCode">&lt;p&gt;Teller TOF number&lt;/p&gt; </param>
        /// <param name="acquirerSettingsTellerIdentificationCodeInt">&lt;p&gt;Teller international identification number&lt;/p&gt; </param>
        /// <param name="acquirerSettingsTellerBusinessCode">&lt;p&gt;Business code (assigned by Teller)&lt;/p&gt; </param>
        /// <param name="acquirerSettingsTellerRecurring">&lt;p&gt;Enable recurring payments (requires agreement with Teller)&lt;/p&gt; </param>
        /// <param name="acquirerSettingsTellerAmericanexpress">&lt;p&gt;Enable AMEX payments (requires agreement with Teller)&lt;/p&gt; </param>
        /// <param name="acquirerSettingsTellerDinersclub">&lt;p&gt;Enable Diners Club payments (requires agreement with Teller)&lt;/p&gt; </param>
        /// <param name="acquirerSettingsTellerSecurepay">&lt;p&gt;Enable SecurePay fraud protection. (disabling requires agreement with Teller)&lt;/p&gt; </param>
        /// <param name="acquirerSettingsTellerVisaMpiMerchantId">&lt;p&gt;VISA MPI merchant id. Used for 3D secure transactions&lt;/p&gt; </param>
        /// <param name="acquirerSettingsTellerMastercardMpiMerchantId">&lt;p&gt;Mastercard MPI merchant id. Used for 3D secure transactions&lt;/p&gt; </param>
        /// <param name="acquirerSettingsTellerVisaBin">&lt;p&gt;Teller VISA acquirer bin used for 3D Secure&lt;/p&gt; </param>
        /// <param name="acquirerSettingsTellerMastercardBin">&lt;p&gt;Teller Mastercard acquirer bin used for 3D Secure&lt;/p&gt; </param>
        /// <param name="acquirerSettingsValitorActive">&lt;p&gt;Enable Valitor payments&lt;/p&gt; </param>
        /// <param name="acquirerSettingsValitorIdentificationCode">&lt;p&gt;Valitor identification number&lt;/p&gt; </param>
        /// <param name="acquirerSettingsValitorIdentificationCodeInt">&lt;p&gt;Valitor international identification number&lt;/p&gt; </param>
        /// <param name="acquirerSettingsValitorBusinessCode">&lt;p&gt;Business code (assigned by Valitor)&lt;/p&gt; </param>
        /// <param name="acquirerSettingsValitorRecurring">&lt;p&gt;Enable recurring payments (requires agreement with Valitor)&lt;/p&gt; </param>
        /// <param name="acquirerSettingsValitorAmericanexpress">&lt;p&gt;Enable AMEX payments (requires agreement with Valitor)&lt;/p&gt; </param>
        /// <param name="acquirerSettingsValitorDinersclub">&lt;p&gt;Enable Diners Club payments (requires agreement with Valitor)&lt;/p&gt; </param>
        /// <param name="acquirerSettingsValitorSecurepay">&lt;p&gt;Enable SecurePay fraud protection.&lt;/p&gt; </param>
        /// <param name="acquirerSettingsValitorVisaMpiMerchantId">&lt;p&gt;VISA MPI merchant id. Used for 3D secure transactions&lt;/p&gt; </param>
        /// <param name="acquirerSettingsValitorMastercardMpiMerchantId">&lt;p&gt;Mastercard MPI merchant id. Used for 3D secure transactions&lt;/p&gt; </param>
        /// <param name="acquirerSettingsValitorVisaBin">&lt;p&gt;VISA acquirer bin used for 3D Secure&lt;/p&gt; </param>
        /// <param name="acquirerSettingsValitorMastercardBin">&lt;p&gt;Mastercard acquirer bin used for 3D Secure&lt;/p&gt; </param>
        /// <param name="acquirerSettingsViabillActive">&lt;p&gt;Enable ViaBill payments&lt;/p&gt; </param>
        /// <param name="acquirerSettingsViabillApiKey">&lt;p&gt;ViaBill API key&lt;/p&gt; </param>
        /// <param name="integrationSettingsEconomicActive">&lt;p&gt;Enable e-conomic integration&lt;/p&gt; </param>
        /// <param name="integrationSettingsEconomicAgreement">&lt;p&gt;e-conomic agreement no.&lt;/p&gt; </param>
        /// <param name="integrationSettingsEconomicAgreementToken">&lt;p&gt;economic agreement grant token&lt;/p&gt; </param>
        /// <param name="pciSaqA">&lt;p&gt;Enable SAQ A&lt;/p&gt; </param>
        /// <param name="pciSaqAEp">&lt;p&gt;Enable SAQ A-EP&lt;/p&gt; </param>
        /// <param name="pciSaqB">&lt;p&gt;Enable SAQ B&lt;/p&gt; </param>
        /// <param name="pciSaqBIp">&lt;p&gt;Enable SAQ B-IP&lt;/p&gt; </param>
        /// <param name="pciSaqC">&lt;p&gt;Enable SAQ C&lt;/p&gt; </param>
        /// <param name="pciSaqCVt">&lt;p&gt;Enable SAQ C-VT&lt;/p&gt; </param>
        /// <param name="pciSaqDMerchant">&lt;p&gt;Enable SAQ D Merchant&lt;/p&gt; </param>
        /// <param name="pciSaqDServiceProvider">&lt;p&gt;Enable SAQ D Service Provider&lt;/p&gt; </param>
        /// <param name="pciSaqP2peHw">&lt;p&gt;Enable SAQ P2PE-HW&lt;/p&gt; </param>
        /// <param name="autofee">&lt;p&gt;Add automatic fee on all payments&lt;/p&gt; </param>
        /// <param name="defaultPaymentMethods">&lt;p&gt;Comma separated list of default payment methods&lt;/p&gt; </param>
        /// <param name="shopUrl">&lt;p&gt;Shop URL (deprecated, use shop_urls instead)&lt;/p&gt; </param>
        /// <param name="shopUrls">&lt;p&gt;Shop URLs&lt;/p&gt; </param>
        /// <param name="contactEmail">&lt;p&gt;Contact email&lt;/p&gt; </param>
        /// <param name="shopName">&lt;p&gt;Shop name&lt;/p&gt; </param>
        /// <param name="shopsystem">&lt;p&gt;Shop system&lt;/p&gt; </param>
        /// <param name="timezone">&lt;table&gt;   &lt;tbody&gt;     &lt;tr&gt;       &lt;td&gt;Timezone UTC offsets in Zulu (+&lt;/td&gt;       &lt;td&gt;-)hh:mm&lt;/td&gt;     &lt;/tr&gt;   &lt;/tbody&gt; &lt;/table&gt; </param>
        /// <param name="locale">&lt;p&gt;Locale as a two letter language code&lt;/p&gt; </param>
        /// <param name="defaultBrandingId">&lt;p&gt;Id of default branding&lt;/p&gt; </param>
        /// <param name="loggingStopsAt">&lt;p&gt;Timestamp when logging is active&lt;/p&gt; </param>
        /// <param name="allowTestTransactions">&lt;p&gt;Allow test transactions&lt;/p&gt; </param>
        /// <param name="defaultPaymentLanguage">&lt;p&gt;Default payment language (Two letter language code, ISO-639-1)&lt;/p&gt; </param>
        /// <param name="defaultTextOnStatement">&lt;p&gt;Text to be displayed on cardholder’s statement. Max 22 ASCII chars. Currently supported by Clearhaus only.&lt;/p&gt; </param>
        /// <param name="defaultBrandingConfig">&lt;p&gt;Default branding config. Can be overwritten in branding or in request to payment window&lt;/p&gt; </param>
        /// <returns>QuickPayProtocolV10Merchant</returns>
        QuickPayProtocolV10Merchant PATCHAccountFormat (string acceptVersion, string authorization, string customerAddressName, string customerAddressAtt, string customerAddressStreet, string customerAddressCity, string customerAddressZipCode, string customerAddressRegion, string customerAddressCountryCode, string customerAddressVatNo, string billingAddressName, string billingAddressAtt, string billingAddressStreet, string billingAddressCity, string billingAddressZipCode, string billingAddressRegion, string billingAddressCountryCode, string billingAddressVatNo, string callbackUrl, bool? acquirerSettingsBamboraActive, string acquirerSettingsBamboraIdentificationCode, string acquirerSettingsBamboraIdentificationCodeInt, string acquirerSettingsBamboraBusinessCode, bool? acquirerSettingsBamboraRecurring, bool? acquirerSettingsBamboraAmericanexpress, bool? acquirerSettingsBamboraDinersclub, bool? acquirerSettingsBamboraSecurepay, string acquirerSettingsBamboraVisaMpiMerchantId, string acquirerSettingsBamboraMastercardMpiMerchantId, string acquirerSettingsBamboraVisaBin, string acquirerSettingsBamboraMastercardBin, bool? acquirerSettingsClearhausActive, string acquirerSettingsClearhausApiKey, bool? acquirerSettingsClearhausRecurring, bool? acquirerSettingsClearhausPayout, bool? acquirerSettingsClearhausApplePay, bool? acquirerSettingsElavonActive, string acquirerSettingsElavonIdentificationCode, string acquirerSettingsElavonIdentificationCodeInt, string acquirerSettingsElavonBusinessCode, bool? acquirerSettingsElavonRecurring, bool? acquirerSettingsElavonAmericanexpress, bool? acquirerSettingsElavonDinersclub, bool? acquirerSettingsElavonSecurepay, string acquirerSettingsElavonVisaMpiMerchantId, string acquirerSettingsElavonMastercardMpiMerchantId, string acquirerSettingsElavonVisaBin, string acquirerSettingsElavonMastercardBin, bool? acquirerSettingsHandelsbankenActive, string acquirerSettingsHandelsbankenIdentificationCode, string acquirerSettingsHandelsbankenIdentificationCodeInt, string acquirerSettingsHandelsbankenBusinessCode, bool? acquirerSettingsHandelsbankenRecurring, bool? acquirerSettingsHandelsbankenAmericanexpress, bool? acquirerSettingsHandelsbankenDinersclub, bool? acquirerSettingsHandelsbankenSecurepay, string acquirerSettingsHandelsbankenVisaMpiMerchantId, string acquirerSettingsHandelsbankenMastercardMpiMerchantId, string acquirerSettingsHandelsbankenVisaBin, string acquirerSettingsHandelsbankenMastercardBin, bool? acquirerSettingsKlarnaActive, int? acquirerSettingsKlarnaEid, string acquirerSettingsKlarnaSharedSecret, bool? acquirerSettingsMobilepayActive, string acquirerSettingsMobilepayDeliveryLimitedTo, bool? acquirerSettingsMobilepaysubscriptionsActive, string acquirerSettingsMobilepaysubscriptionsAuthState, string acquirerSettingsMobilepaysubscriptionsCodeVerifier, int? acquirerSettingsMobilepaysubscriptionsLastTokenRefresh, string acquirerSettingsMobilepaysubscriptionsNonce, int? acquirerSettingsMobilepaysubscriptionsPendingStatus, Dictionary<string, string> acquirerSettingsMobilepaysubscriptionsProvider, string acquirerSettingsMobilepaysubscriptionsRefreshToken, bool? acquirerSettingsNetsActive, string acquirerSettingsNetsIdentificationCode, string acquirerSettingsNetsBusinessCode, bool? acquirerSettingsNetsRecurring, bool? acquirerSettingsNetsFbg1886, bool? acquirerSettingsNetsSecuredByNets, string acquirerSettingsNetsIdentificationCodeInt, bool? acquirerSettingsNetsAmericanexpress, bool? acquirerSettingsNetsDinersclub, bool? acquirerSettingsNetsSecurepay, string acquirerSettingsNetsVisaBin, string acquirerSettingsNetsMastercardBin, bool? acquirerSettingsPaypalActive, bool? acquirerSettingsPaypalRecurring, bool? acquirerSettingsPaypalCreditCard, string acquirerSettingsPaypalToken, string acquirerSettingsPaypalTokenSecret, List<string> acquirerSettingsPaypalScope, bool? acquirerSettingsSofortActive, int? acquirerSettingsSofortCustomerNumber, int? acquirerSettingsSofortProjectId, string acquirerSettingsSofortApiKey, bool? acquirerSettingsSofortGateway, bool? acquirerSettingsSofortIdeal, int? acquirerSettingsSofortIdealProjectId, string acquirerSettingsSofortIdealProjectPassword, string acquirerSettingsSofortIdealNotificationPassword, bool? acquirerSettingsSwedbankActive, string acquirerSettingsSwedbankIdentificationCode, string acquirerSettingsSwedbankIdentificationCodeInt, string acquirerSettingsSwedbankBusinessCode, bool? acquirerSettingsSwedbankRecurring, bool? acquirerSettingsSwedbankAmericanexpress, bool? acquirerSettingsSwedbankDinersclub, bool? acquirerSettingsSwedbankSecurepay, string acquirerSettingsSwedbankVisaMpiMerchantId, string acquirerSettingsSwedbankMastercardMpiMerchantId, string acquirerSettingsSwedbankVisaBin, string acquirerSettingsSwedbankMastercardBin, bool? acquirerSettingsTellerActive, string acquirerSettingsTellerIdentificationCode, string acquirerSettingsTellerIdentificationCodeInt, string acquirerSettingsTellerBusinessCode, bool? acquirerSettingsTellerRecurring, bool? acquirerSettingsTellerAmericanexpress, bool? acquirerSettingsTellerDinersclub, bool? acquirerSettingsTellerSecurepay, string acquirerSettingsTellerVisaMpiMerchantId, string acquirerSettingsTellerMastercardMpiMerchantId, string acquirerSettingsTellerVisaBin, string acquirerSettingsTellerMastercardBin, bool? acquirerSettingsValitorActive, string acquirerSettingsValitorIdentificationCode, string acquirerSettingsValitorIdentificationCodeInt, string acquirerSettingsValitorBusinessCode, bool? acquirerSettingsValitorRecurring, bool? acquirerSettingsValitorAmericanexpress, bool? acquirerSettingsValitorDinersclub, bool? acquirerSettingsValitorSecurepay, string acquirerSettingsValitorVisaMpiMerchantId, string acquirerSettingsValitorMastercardMpiMerchantId, string acquirerSettingsValitorVisaBin, string acquirerSettingsValitorMastercardBin, bool? acquirerSettingsViabillActive, string acquirerSettingsViabillApiKey, bool? integrationSettingsEconomicActive, string integrationSettingsEconomicAgreement, string integrationSettingsEconomicAgreementToken, bool? pciSaqA, bool? pciSaqAEp, bool? pciSaqB, bool? pciSaqBIp, bool? pciSaqC, bool? pciSaqCVt, bool? pciSaqDMerchant, bool? pciSaqDServiceProvider, bool? pciSaqP2peHw, bool? autofee, string defaultPaymentMethods, string shopUrl, List<string> shopUrls, string contactEmail, string shopName, string shopsystem, string timezone, string locale, int? defaultBrandingId, string loggingStopsAt, bool? allowTestTransactions, string defaultPaymentLanguage, string defaultTextOnStatement, Dictionary<string, string> defaultBrandingConfig);
        /// <summary>
        /// Regenerates the private key of the merchant  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <returns>QuickPayProtocolV10PrivateKey</returns>
        QuickPayProtocolV10PrivateKey PATCHAccountPrivateKeyFormat (string acceptVersion, string authorization);
        /// <summary>
        /// Creates or replaces the current merchant logo  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="_file">&lt;p&gt;The logo as a multipart file. If the logo_type is ‘mobilepay’, the logo must be a 250px x 250px PNG file&lt;/p&gt; </param>
        /// <param name="logoType">&lt;p&gt;Type of logo&lt;/p&gt; </param>
        /// <returns></returns>
        void PUTAccountLogoFormat (string acceptVersion, string authorization, string _file, string logoType);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AccountApi : IAccountApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AccountApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccountApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Delete 04 platform settings  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <returns>QuickPayProtocolV10Zero4PlatformSettings</returns>            
        public QuickPayProtocolV10Zero4PlatformSettings DELETEAccount04PlatformFormat (string acceptVersion, string authorization)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling DELETEAccount04PlatformFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling DELETEAccount04PlatformFormat");
            
    
            var path = "/account/04-platform";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DELETEAccount04PlatformFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DELETEAccount04PlatformFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10Zero4PlatformSettings) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10Zero4PlatformSettings), response.Headers);
        }
    
        /// <summary>
        /// Delete merchant account  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <returns></returns>            
        public void DELETEAccountFormat (string acceptVersion, string authorization)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling DELETEAccountFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling DELETEAccountFormat");
            
    
            var path = "/account";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DELETEAccountFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DELETEAccountFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Deletes the current merchant logo  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="logoType">&lt;p&gt;Type of logo&lt;/p&gt; </param> 
        /// <returns></returns>            
        public void DELETEAccountLogoFormat (string acceptVersion, string authorization, string logoType)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling DELETEAccountLogoFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling DELETEAccountLogoFormat");
            
    
            var path = "/account/logo";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (logoType != null) queryParams.Add("logo_type", ApiClient.ParameterToString(logoType)); // query parameter
             if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DELETEAccountLogoFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DELETEAccountLogoFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get 04 platform settings  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <returns>QuickPayProtocolV10Zero4PlatformSettings</returns>            
        public QuickPayProtocolV10Zero4PlatformSettings GETAccount04PlatformFormat (string acceptVersion, string authorization)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETAccount04PlatformFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETAccount04PlatformFormat");
            
    
            var path = "/account/04-platform";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAccount04PlatformFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAccount04PlatformFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10Zero4PlatformSettings) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10Zero4PlatformSettings), response.Headers);
        }
    
        /// <summary>
        /// Get merchant account  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <returns>QuickPayProtocolV10Merchant</returns>            
        public QuickPayProtocolV10Merchant GETAccountFormat (string acceptVersion, string authorization)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETAccountFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETAccountFormat");
            
    
            var path = "/account";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAccountFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAccountFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10Merchant) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10Merchant), response.Headers);
        }
    
        /// <summary>
        /// Gets the merchant logo as a raw download or a 404 if none exists  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="logoType">&lt;p&gt;Type of logo&lt;/p&gt; </param> 
        /// <returns></returns>            
        public void GETAccountLogoFormat (string acceptVersion, string authorization, string logoType)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETAccountLogoFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETAccountLogoFormat");
            
    
            var path = "/account/logo";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (logoType != null) queryParams.Add("logo_type", ApiClient.ParameterToString(logoType)); // query parameter
             if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAccountLogoFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAccountLogoFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets the private key of the merchant  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <returns>QuickPayProtocolV10PrivateKey</returns>            
        public QuickPayProtocolV10PrivateKey GETAccountPrivateKeyFormat (string acceptVersion, string authorization)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETAccountPrivateKeyFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETAccountPrivateKeyFormat");
            
    
            var path = "/account/private-key";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAccountPrivateKeyFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAccountPrivateKeyFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10PrivateKey) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10PrivateKey), response.Headers);
        }
    
        /// <summary>
        /// Update merchant account  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="customerAddressName">&lt;p&gt;Name&lt;/p&gt; </param> 
        /// <param name="customerAddressAtt">&lt;p&gt;Att&lt;/p&gt; </param> 
        /// <param name="customerAddressStreet">&lt;p&gt;Street&lt;/p&gt; </param> 
        /// <param name="customerAddressCity">&lt;p&gt;City&lt;/p&gt; </param> 
        /// <param name="customerAddressZipCode">&lt;p&gt;Zip code&lt;/p&gt; </param> 
        /// <param name="customerAddressRegion">&lt;p&gt;Region&lt;/p&gt; </param> 
        /// <param name="customerAddressCountryCode">&lt;p&gt;Three letter country code according to ISO 3166-1 Alpha-3&lt;/p&gt; </param> 
        /// <param name="customerAddressVatNo">&lt;p&gt;VAT registration number&lt;/p&gt; </param> 
        /// <param name="billingAddressName">&lt;p&gt;Name&lt;/p&gt; </param> 
        /// <param name="billingAddressAtt">&lt;p&gt;Att&lt;/p&gt; </param> 
        /// <param name="billingAddressStreet">&lt;p&gt;Street&lt;/p&gt; </param> 
        /// <param name="billingAddressCity">&lt;p&gt;City&lt;/p&gt; </param> 
        /// <param name="billingAddressZipCode">&lt;p&gt;Zip code&lt;/p&gt; </param> 
        /// <param name="billingAddressRegion">&lt;p&gt;Region&lt;/p&gt; </param> 
        /// <param name="billingAddressCountryCode">&lt;p&gt;Three letter country code according to ISO 3166-1 Alpha-3&lt;/p&gt; </param> 
        /// <param name="billingAddressVatNo">&lt;p&gt;VAT registration number&lt;/p&gt; </param> 
        /// <param name="callbackUrl">&lt;p&gt;Callback url&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsBamboraActive">&lt;p&gt;Enable Bambora payments&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsBamboraIdentificationCode">&lt;p&gt;Bambora identification number&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsBamboraIdentificationCodeInt">&lt;p&gt;Bambora international identification number&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsBamboraBusinessCode">&lt;p&gt;Business code (assigned by Bambora)&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsBamboraRecurring">&lt;p&gt;Enable recurring payments (requires agreement with Bambora)&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsBamboraAmericanexpress">&lt;p&gt;Enable AMEX payments (requires agreement with Bambora)&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsBamboraDinersclub">&lt;p&gt;Enable Diners Club payments (requires agreement with Bambora)&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsBamboraSecurepay">&lt;p&gt;Enable SecurePay fraud protection.&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsBamboraVisaMpiMerchantId">&lt;p&gt;VISA MPI merchant id. Used for 3D secure transactions&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsBamboraMastercardMpiMerchantId">&lt;p&gt;Mastercard MPI merchant id. Used for 3D secure transactions&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsBamboraVisaBin">&lt;p&gt;VISA acquirer bin used for 3D Secure&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsBamboraMastercardBin">&lt;p&gt;Mastercard acquirer bin used for 3D Secure&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsClearhausActive">&lt;p&gt;Enable ClearHaus payments&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsClearhausApiKey">&lt;p&gt;Clearhaus API key (is required but may be left empty)&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsClearhausRecurring">&lt;p&gt;Enable recurring payments (requires agreement with Clearhaus)&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsClearhausPayout">&lt;p&gt;Enable payouts (requires agreement with Clearhaus)&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsClearhausApplePay">&lt;p&gt;Enable Apple Pay (requires agreement with Clearhaus)&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsElavonActive">&lt;p&gt;Enable Elavon payments&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsElavonIdentificationCode">&lt;p&gt;Elavon identification number&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsElavonIdentificationCodeInt">&lt;p&gt;Elavon international identification number&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsElavonBusinessCode">&lt;p&gt;Business code (assigned by Elavon)&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsElavonRecurring">&lt;p&gt;Enable recurring payments (requires agreement with Elavon)&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsElavonAmericanexpress">&lt;p&gt;Enable AMEX payments (requires agreement with Elavon)&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsElavonDinersclub">&lt;p&gt;Enable Diners Club payments (requires agreement with Elavon)&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsElavonSecurepay">&lt;p&gt;Enable SecurePay fraud protection.&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsElavonVisaMpiMerchantId">&lt;p&gt;VISA MPI merchant id. Used for 3D secure transactions&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsElavonMastercardMpiMerchantId">&lt;p&gt;Mastercard MPI merchant id. Used for 3D secure transactions&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsElavonVisaBin">&lt;p&gt;VISA acquirer bin used for 3D Secure&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsElavonMastercardBin">&lt;p&gt;Mastercard acquirer bin used for 3D Secure&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsHandelsbankenActive">&lt;p&gt;Enable Handelsbanken payments&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsHandelsbankenIdentificationCode">&lt;p&gt;Handelsbanken identification number&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsHandelsbankenIdentificationCodeInt">&lt;p&gt;Handelsbanken international identification number&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsHandelsbankenBusinessCode">&lt;p&gt;Business code (assigned by Handelsbanken)&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsHandelsbankenRecurring">&lt;p&gt;Enable recurring payments (requires agreement with Handelsbanken)&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsHandelsbankenAmericanexpress">&lt;p&gt;Enable AMEX payments (requires agreement with Handelsbanken)&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsHandelsbankenDinersclub">&lt;p&gt;Enable Diners Club payments (requires agreement with Handelsbanken)&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsHandelsbankenSecurepay">&lt;p&gt;Enable SecurePay fraud protection.&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsHandelsbankenVisaMpiMerchantId">&lt;p&gt;VISA MPI merchant id. Used for 3D secure transactions&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsHandelsbankenMastercardMpiMerchantId">&lt;p&gt;Mastercard MPI merchant id. Used for 3D secure transactions&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsHandelsbankenVisaBin">&lt;p&gt;VISA acquirer bin used for 3D Secure&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsHandelsbankenMastercardBin">&lt;p&gt;Mastercard acquirer bin used for 3D Secure&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsKlarnaActive">&lt;p&gt;Enable Klarna payments&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsKlarnaEid">&lt;p&gt;Klarna merchant ID&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsKlarnaSharedSecret">&lt;p&gt;Klarna shared secret&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsMobilepayActive">&lt;p&gt;Enable MobilePay payments&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsMobilepayDeliveryLimitedTo">&lt;p&gt;Limit MobilePay delivery address selection to theses countries. (ISO 3166-1 alpha-2 without delimiter ‘DKNOSEFI’) (Valid options are DK,NO,SE,FI)&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsMobilepaysubscriptionsActive">&lt;p&gt;Enable MobilePay Subscriptions payments&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsMobilepaysubscriptionsAuthState">&lt;p&gt;Identifier MobilePay Subscriptions uses to link requests to callbacks&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsMobilepaysubscriptionsCodeVerifier">&lt;p&gt;Verifies received code challenge&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsMobilepaysubscriptionsLastTokenRefresh">&lt;p&gt;Unix Timestamp of last time the tokens were refreshed&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsMobilepaysubscriptionsNonce">&lt;p&gt;Associate client sessions with ID Tokens to mitigate replay attacks&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsMobilepaysubscriptionsPendingStatus">&lt;p&gt;0: agreement inactive, 1: flow initialised, 2: tokens received, 3: flow completed&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsMobilepaysubscriptionsProvider">&lt;p&gt;The provider / sales-place chosen by the merchant&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsMobilepaysubscriptionsRefreshToken">&lt;p&gt;Token to refresh access token for up to 1 year&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsNetsActive">&lt;p&gt;Enable Nets/Teller payments&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsNetsIdentificationCode">&lt;p&gt;Nets TOF number&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsNetsBusinessCode">&lt;p&gt;Business code (assigned by Nets)&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsNetsRecurring">&lt;p&gt;Enable recurring payments (requires agreement with Nets)&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsNetsFbg1886">&lt;p&gt;Enable Forbrugsforeningen payments (requires agreement with Nets and Forbrugsforeningen)&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsNetsSecuredByNets">&lt;p&gt;Enable SecuredByNets fraud protection.&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsNetsIdentificationCodeInt">&lt;p&gt;(Depricated; use Teller acquirer)&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsNetsAmericanexpress">&lt;p&gt;(Depricated; use Teller acquirer)&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsNetsDinersclub">&lt;p&gt;(Depricated; use Teller acquirer)&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsNetsSecurepay">&lt;p&gt;(Depricated; use Teller acquirer)&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsNetsVisaBin">&lt;p&gt;(Depricated; use Teller acquirer)&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsNetsMastercardBin">&lt;p&gt;(Depricated; use Teller acquirer)&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsPaypalActive">&lt;p&gt;Enable PayPal payments&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsPaypalRecurring">&lt;p&gt;Enable recurring payments&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsPaypalCreditCard">&lt;p&gt;Allow credit-card payments. (Only for US/CA/UK merchants)&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsPaypalToken">&lt;p&gt;Authentication token&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsPaypalTokenSecret">&lt;p&gt;Authentication token secret&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsPaypalScope">&lt;p&gt;Authentication scope&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsSofortActive">&lt;p&gt;Enable Sofort payments&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsSofortCustomerNumber">&lt;p&gt;Sofort customer number&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsSofortProjectId">&lt;p&gt;Sofort Gateway project id&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsSofortApiKey">&lt;p&gt;Sofort API key&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsSofortGateway">&lt;p&gt;Enable Sofort Gateway feature&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsSofortIdeal">&lt;p&gt;Enable Sofort iDeal feature&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsSofortIdealProjectId">&lt;p&gt;Sofort iDeal project id&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsSofortIdealProjectPassword">&lt;p&gt;Sofort iDeal project password&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsSofortIdealNotificationPassword">&lt;p&gt;Sofort iDeal notification password&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsSwedbankActive">&lt;p&gt;Enable Swedbank payments&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsSwedbankIdentificationCode">&lt;p&gt;Swedbank identification number&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsSwedbankIdentificationCodeInt">&lt;p&gt;Swedbank international identification number&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsSwedbankBusinessCode">&lt;p&gt;Business code (assigned by Swedbank)&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsSwedbankRecurring">&lt;p&gt;Enable recurring payments (requires agreement with Swedbank)&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsSwedbankAmericanexpress">&lt;p&gt;Enable AMEX payments (requires agreement with Swedbank)&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsSwedbankDinersclub">&lt;p&gt;Enable Diners Club payments (requires agreement with Swedbank)&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsSwedbankSecurepay">&lt;p&gt;Enable SecurePay fraud protection.&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsSwedbankVisaMpiMerchantId">&lt;p&gt;VISA MPI merchant id. Used for 3D secure transactions&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsSwedbankMastercardMpiMerchantId">&lt;p&gt;Mastercard MPI merchant id. Used for 3D secure transactions&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsSwedbankVisaBin">&lt;p&gt;VISA acquirer bin used for 3D Secure&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsSwedbankMastercardBin">&lt;p&gt;Mastercard acquirer bin used for 3D Secure&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsTellerActive">&lt;p&gt;Enable Teller payments&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsTellerIdentificationCode">&lt;p&gt;Teller TOF number&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsTellerIdentificationCodeInt">&lt;p&gt;Teller international identification number&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsTellerBusinessCode">&lt;p&gt;Business code (assigned by Teller)&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsTellerRecurring">&lt;p&gt;Enable recurring payments (requires agreement with Teller)&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsTellerAmericanexpress">&lt;p&gt;Enable AMEX payments (requires agreement with Teller)&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsTellerDinersclub">&lt;p&gt;Enable Diners Club payments (requires agreement with Teller)&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsTellerSecurepay">&lt;p&gt;Enable SecurePay fraud protection. (disabling requires agreement with Teller)&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsTellerVisaMpiMerchantId">&lt;p&gt;VISA MPI merchant id. Used for 3D secure transactions&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsTellerMastercardMpiMerchantId">&lt;p&gt;Mastercard MPI merchant id. Used for 3D secure transactions&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsTellerVisaBin">&lt;p&gt;Teller VISA acquirer bin used for 3D Secure&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsTellerMastercardBin">&lt;p&gt;Teller Mastercard acquirer bin used for 3D Secure&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsValitorActive">&lt;p&gt;Enable Valitor payments&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsValitorIdentificationCode">&lt;p&gt;Valitor identification number&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsValitorIdentificationCodeInt">&lt;p&gt;Valitor international identification number&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsValitorBusinessCode">&lt;p&gt;Business code (assigned by Valitor)&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsValitorRecurring">&lt;p&gt;Enable recurring payments (requires agreement with Valitor)&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsValitorAmericanexpress">&lt;p&gt;Enable AMEX payments (requires agreement with Valitor)&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsValitorDinersclub">&lt;p&gt;Enable Diners Club payments (requires agreement with Valitor)&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsValitorSecurepay">&lt;p&gt;Enable SecurePay fraud protection.&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsValitorVisaMpiMerchantId">&lt;p&gt;VISA MPI merchant id. Used for 3D secure transactions&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsValitorMastercardMpiMerchantId">&lt;p&gt;Mastercard MPI merchant id. Used for 3D secure transactions&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsValitorVisaBin">&lt;p&gt;VISA acquirer bin used for 3D Secure&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsValitorMastercardBin">&lt;p&gt;Mastercard acquirer bin used for 3D Secure&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsViabillActive">&lt;p&gt;Enable ViaBill payments&lt;/p&gt; </param> 
        /// <param name="acquirerSettingsViabillApiKey">&lt;p&gt;ViaBill API key&lt;/p&gt; </param> 
        /// <param name="integrationSettingsEconomicActive">&lt;p&gt;Enable e-conomic integration&lt;/p&gt; </param> 
        /// <param name="integrationSettingsEconomicAgreement">&lt;p&gt;e-conomic agreement no.&lt;/p&gt; </param> 
        /// <param name="integrationSettingsEconomicAgreementToken">&lt;p&gt;economic agreement grant token&lt;/p&gt; </param> 
        /// <param name="pciSaqA">&lt;p&gt;Enable SAQ A&lt;/p&gt; </param> 
        /// <param name="pciSaqAEp">&lt;p&gt;Enable SAQ A-EP&lt;/p&gt; </param> 
        /// <param name="pciSaqB">&lt;p&gt;Enable SAQ B&lt;/p&gt; </param> 
        /// <param name="pciSaqBIp">&lt;p&gt;Enable SAQ B-IP&lt;/p&gt; </param> 
        /// <param name="pciSaqC">&lt;p&gt;Enable SAQ C&lt;/p&gt; </param> 
        /// <param name="pciSaqCVt">&lt;p&gt;Enable SAQ C-VT&lt;/p&gt; </param> 
        /// <param name="pciSaqDMerchant">&lt;p&gt;Enable SAQ D Merchant&lt;/p&gt; </param> 
        /// <param name="pciSaqDServiceProvider">&lt;p&gt;Enable SAQ D Service Provider&lt;/p&gt; </param> 
        /// <param name="pciSaqP2peHw">&lt;p&gt;Enable SAQ P2PE-HW&lt;/p&gt; </param> 
        /// <param name="autofee">&lt;p&gt;Add automatic fee on all payments&lt;/p&gt; </param> 
        /// <param name="defaultPaymentMethods">&lt;p&gt;Comma separated list of default payment methods&lt;/p&gt; </param> 
        /// <param name="shopUrl">&lt;p&gt;Shop URL (deprecated, use shop_urls instead)&lt;/p&gt; </param> 
        /// <param name="shopUrls">&lt;p&gt;Shop URLs&lt;/p&gt; </param> 
        /// <param name="contactEmail">&lt;p&gt;Contact email&lt;/p&gt; </param> 
        /// <param name="shopName">&lt;p&gt;Shop name&lt;/p&gt; </param> 
        /// <param name="shopsystem">&lt;p&gt;Shop system&lt;/p&gt; </param> 
        /// <param name="timezone">&lt;table&gt;   &lt;tbody&gt;     &lt;tr&gt;       &lt;td&gt;Timezone UTC offsets in Zulu (+&lt;/td&gt;       &lt;td&gt;-)hh:mm&lt;/td&gt;     &lt;/tr&gt;   &lt;/tbody&gt; &lt;/table&gt; </param> 
        /// <param name="locale">&lt;p&gt;Locale as a two letter language code&lt;/p&gt; </param> 
        /// <param name="defaultBrandingId">&lt;p&gt;Id of default branding&lt;/p&gt; </param> 
        /// <param name="loggingStopsAt">&lt;p&gt;Timestamp when logging is active&lt;/p&gt; </param> 
        /// <param name="allowTestTransactions">&lt;p&gt;Allow test transactions&lt;/p&gt; </param> 
        /// <param name="defaultPaymentLanguage">&lt;p&gt;Default payment language (Two letter language code, ISO-639-1)&lt;/p&gt; </param> 
        /// <param name="defaultTextOnStatement">&lt;p&gt;Text to be displayed on cardholder’s statement. Max 22 ASCII chars. Currently supported by Clearhaus only.&lt;/p&gt; </param> 
        /// <param name="defaultBrandingConfig">&lt;p&gt;Default branding config. Can be overwritten in branding or in request to payment window&lt;/p&gt; </param> 
        /// <returns>QuickPayProtocolV10Merchant</returns>            
        public QuickPayProtocolV10Merchant PATCHAccountFormat (string acceptVersion, string authorization, string customerAddressName, string customerAddressAtt, string customerAddressStreet, string customerAddressCity, string customerAddressZipCode, string customerAddressRegion, string customerAddressCountryCode, string customerAddressVatNo, string billingAddressName, string billingAddressAtt, string billingAddressStreet, string billingAddressCity, string billingAddressZipCode, string billingAddressRegion, string billingAddressCountryCode, string billingAddressVatNo, string callbackUrl, bool? acquirerSettingsBamboraActive, string acquirerSettingsBamboraIdentificationCode, string acquirerSettingsBamboraIdentificationCodeInt, string acquirerSettingsBamboraBusinessCode, bool? acquirerSettingsBamboraRecurring, bool? acquirerSettingsBamboraAmericanexpress, bool? acquirerSettingsBamboraDinersclub, bool? acquirerSettingsBamboraSecurepay, string acquirerSettingsBamboraVisaMpiMerchantId, string acquirerSettingsBamboraMastercardMpiMerchantId, string acquirerSettingsBamboraVisaBin, string acquirerSettingsBamboraMastercardBin, bool? acquirerSettingsClearhausActive, string acquirerSettingsClearhausApiKey, bool? acquirerSettingsClearhausRecurring, bool? acquirerSettingsClearhausPayout, bool? acquirerSettingsClearhausApplePay, bool? acquirerSettingsElavonActive, string acquirerSettingsElavonIdentificationCode, string acquirerSettingsElavonIdentificationCodeInt, string acquirerSettingsElavonBusinessCode, bool? acquirerSettingsElavonRecurring, bool? acquirerSettingsElavonAmericanexpress, bool? acquirerSettingsElavonDinersclub, bool? acquirerSettingsElavonSecurepay, string acquirerSettingsElavonVisaMpiMerchantId, string acquirerSettingsElavonMastercardMpiMerchantId, string acquirerSettingsElavonVisaBin, string acquirerSettingsElavonMastercardBin, bool? acquirerSettingsHandelsbankenActive, string acquirerSettingsHandelsbankenIdentificationCode, string acquirerSettingsHandelsbankenIdentificationCodeInt, string acquirerSettingsHandelsbankenBusinessCode, bool? acquirerSettingsHandelsbankenRecurring, bool? acquirerSettingsHandelsbankenAmericanexpress, bool? acquirerSettingsHandelsbankenDinersclub, bool? acquirerSettingsHandelsbankenSecurepay, string acquirerSettingsHandelsbankenVisaMpiMerchantId, string acquirerSettingsHandelsbankenMastercardMpiMerchantId, string acquirerSettingsHandelsbankenVisaBin, string acquirerSettingsHandelsbankenMastercardBin, bool? acquirerSettingsKlarnaActive, int? acquirerSettingsKlarnaEid, string acquirerSettingsKlarnaSharedSecret, bool? acquirerSettingsMobilepayActive, string acquirerSettingsMobilepayDeliveryLimitedTo, bool? acquirerSettingsMobilepaysubscriptionsActive, string acquirerSettingsMobilepaysubscriptionsAuthState, string acquirerSettingsMobilepaysubscriptionsCodeVerifier, int? acquirerSettingsMobilepaysubscriptionsLastTokenRefresh, string acquirerSettingsMobilepaysubscriptionsNonce, int? acquirerSettingsMobilepaysubscriptionsPendingStatus, Dictionary<string, string> acquirerSettingsMobilepaysubscriptionsProvider, string acquirerSettingsMobilepaysubscriptionsRefreshToken, bool? acquirerSettingsNetsActive, string acquirerSettingsNetsIdentificationCode, string acquirerSettingsNetsBusinessCode, bool? acquirerSettingsNetsRecurring, bool? acquirerSettingsNetsFbg1886, bool? acquirerSettingsNetsSecuredByNets, string acquirerSettingsNetsIdentificationCodeInt, bool? acquirerSettingsNetsAmericanexpress, bool? acquirerSettingsNetsDinersclub, bool? acquirerSettingsNetsSecurepay, string acquirerSettingsNetsVisaBin, string acquirerSettingsNetsMastercardBin, bool? acquirerSettingsPaypalActive, bool? acquirerSettingsPaypalRecurring, bool? acquirerSettingsPaypalCreditCard, string acquirerSettingsPaypalToken, string acquirerSettingsPaypalTokenSecret, List<string> acquirerSettingsPaypalScope, bool? acquirerSettingsSofortActive, int? acquirerSettingsSofortCustomerNumber, int? acquirerSettingsSofortProjectId, string acquirerSettingsSofortApiKey, bool? acquirerSettingsSofortGateway, bool? acquirerSettingsSofortIdeal, int? acquirerSettingsSofortIdealProjectId, string acquirerSettingsSofortIdealProjectPassword, string acquirerSettingsSofortIdealNotificationPassword, bool? acquirerSettingsSwedbankActive, string acquirerSettingsSwedbankIdentificationCode, string acquirerSettingsSwedbankIdentificationCodeInt, string acquirerSettingsSwedbankBusinessCode, bool? acquirerSettingsSwedbankRecurring, bool? acquirerSettingsSwedbankAmericanexpress, bool? acquirerSettingsSwedbankDinersclub, bool? acquirerSettingsSwedbankSecurepay, string acquirerSettingsSwedbankVisaMpiMerchantId, string acquirerSettingsSwedbankMastercardMpiMerchantId, string acquirerSettingsSwedbankVisaBin, string acquirerSettingsSwedbankMastercardBin, bool? acquirerSettingsTellerActive, string acquirerSettingsTellerIdentificationCode, string acquirerSettingsTellerIdentificationCodeInt, string acquirerSettingsTellerBusinessCode, bool? acquirerSettingsTellerRecurring, bool? acquirerSettingsTellerAmericanexpress, bool? acquirerSettingsTellerDinersclub, bool? acquirerSettingsTellerSecurepay, string acquirerSettingsTellerVisaMpiMerchantId, string acquirerSettingsTellerMastercardMpiMerchantId, string acquirerSettingsTellerVisaBin, string acquirerSettingsTellerMastercardBin, bool? acquirerSettingsValitorActive, string acquirerSettingsValitorIdentificationCode, string acquirerSettingsValitorIdentificationCodeInt, string acquirerSettingsValitorBusinessCode, bool? acquirerSettingsValitorRecurring, bool? acquirerSettingsValitorAmericanexpress, bool? acquirerSettingsValitorDinersclub, bool? acquirerSettingsValitorSecurepay, string acquirerSettingsValitorVisaMpiMerchantId, string acquirerSettingsValitorMastercardMpiMerchantId, string acquirerSettingsValitorVisaBin, string acquirerSettingsValitorMastercardBin, bool? acquirerSettingsViabillActive, string acquirerSettingsViabillApiKey, bool? integrationSettingsEconomicActive, string integrationSettingsEconomicAgreement, string integrationSettingsEconomicAgreementToken, bool? pciSaqA, bool? pciSaqAEp, bool? pciSaqB, bool? pciSaqBIp, bool? pciSaqC, bool? pciSaqCVt, bool? pciSaqDMerchant, bool? pciSaqDServiceProvider, bool? pciSaqP2peHw, bool? autofee, string defaultPaymentMethods, string shopUrl, List<string> shopUrls, string contactEmail, string shopName, string shopsystem, string timezone, string locale, int? defaultBrandingId, string loggingStopsAt, bool? allowTestTransactions, string defaultPaymentLanguage, string defaultTextOnStatement, Dictionary<string, string> defaultBrandingConfig)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PATCHAccountFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PATCHAccountFormat");
            
    
            var path = "/account";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
            if (customerAddressName != null) formParams.Add("customer_address[name]", ApiClient.ParameterToString(customerAddressName)); // form parameter
if (customerAddressAtt != null) formParams.Add("customer_address[att]", ApiClient.ParameterToString(customerAddressAtt)); // form parameter
if (customerAddressStreet != null) formParams.Add("customer_address[street]", ApiClient.ParameterToString(customerAddressStreet)); // form parameter
if (customerAddressCity != null) formParams.Add("customer_address[city]", ApiClient.ParameterToString(customerAddressCity)); // form parameter
if (customerAddressZipCode != null) formParams.Add("customer_address[zip_code]", ApiClient.ParameterToString(customerAddressZipCode)); // form parameter
if (customerAddressRegion != null) formParams.Add("customer_address[region]", ApiClient.ParameterToString(customerAddressRegion)); // form parameter
if (customerAddressCountryCode != null) formParams.Add("customer_address[country_code]", ApiClient.ParameterToString(customerAddressCountryCode)); // form parameter
if (customerAddressVatNo != null) formParams.Add("customer_address[vat_no]", ApiClient.ParameterToString(customerAddressVatNo)); // form parameter
if (billingAddressName != null) formParams.Add("billing_address[name]", ApiClient.ParameterToString(billingAddressName)); // form parameter
if (billingAddressAtt != null) formParams.Add("billing_address[att]", ApiClient.ParameterToString(billingAddressAtt)); // form parameter
if (billingAddressStreet != null) formParams.Add("billing_address[street]", ApiClient.ParameterToString(billingAddressStreet)); // form parameter
if (billingAddressCity != null) formParams.Add("billing_address[city]", ApiClient.ParameterToString(billingAddressCity)); // form parameter
if (billingAddressZipCode != null) formParams.Add("billing_address[zip_code]", ApiClient.ParameterToString(billingAddressZipCode)); // form parameter
if (billingAddressRegion != null) formParams.Add("billing_address[region]", ApiClient.ParameterToString(billingAddressRegion)); // form parameter
if (billingAddressCountryCode != null) formParams.Add("billing_address[country_code]", ApiClient.ParameterToString(billingAddressCountryCode)); // form parameter
if (billingAddressVatNo != null) formParams.Add("billing_address[vat_no]", ApiClient.ParameterToString(billingAddressVatNo)); // form parameter
if (callbackUrl != null) formParams.Add("callback_url", ApiClient.ParameterToString(callbackUrl)); // form parameter
if (acquirerSettingsBamboraActive != null) formParams.Add("acquirer_settings[bambora][active]", ApiClient.ParameterToString(acquirerSettingsBamboraActive)); // form parameter
if (acquirerSettingsBamboraIdentificationCode != null) formParams.Add("acquirer_settings[bambora][identification_code]", ApiClient.ParameterToString(acquirerSettingsBamboraIdentificationCode)); // form parameter
if (acquirerSettingsBamboraIdentificationCodeInt != null) formParams.Add("acquirer_settings[bambora][identification_code_int]", ApiClient.ParameterToString(acquirerSettingsBamboraIdentificationCodeInt)); // form parameter
if (acquirerSettingsBamboraBusinessCode != null) formParams.Add("acquirer_settings[bambora][business_code]", ApiClient.ParameterToString(acquirerSettingsBamboraBusinessCode)); // form parameter
if (acquirerSettingsBamboraRecurring != null) formParams.Add("acquirer_settings[bambora][recurring]", ApiClient.ParameterToString(acquirerSettingsBamboraRecurring)); // form parameter
if (acquirerSettingsBamboraAmericanexpress != null) formParams.Add("acquirer_settings[bambora][americanexpress]", ApiClient.ParameterToString(acquirerSettingsBamboraAmericanexpress)); // form parameter
if (acquirerSettingsBamboraDinersclub != null) formParams.Add("acquirer_settings[bambora][dinersclub]", ApiClient.ParameterToString(acquirerSettingsBamboraDinersclub)); // form parameter
if (acquirerSettingsBamboraSecurepay != null) formParams.Add("acquirer_settings[bambora][securepay]", ApiClient.ParameterToString(acquirerSettingsBamboraSecurepay)); // form parameter
if (acquirerSettingsBamboraVisaMpiMerchantId != null) formParams.Add("acquirer_settings[bambora][visa_mpi_merchant_id]", ApiClient.ParameterToString(acquirerSettingsBamboraVisaMpiMerchantId)); // form parameter
if (acquirerSettingsBamboraMastercardMpiMerchantId != null) formParams.Add("acquirer_settings[bambora][mastercard_mpi_merchant_id]", ApiClient.ParameterToString(acquirerSettingsBamboraMastercardMpiMerchantId)); // form parameter
if (acquirerSettingsBamboraVisaBin != null) formParams.Add("acquirer_settings[bambora][visa_bin]", ApiClient.ParameterToString(acquirerSettingsBamboraVisaBin)); // form parameter
if (acquirerSettingsBamboraMastercardBin != null) formParams.Add("acquirer_settings[bambora][mastercard_bin]", ApiClient.ParameterToString(acquirerSettingsBamboraMastercardBin)); // form parameter
if (acquirerSettingsClearhausActive != null) formParams.Add("acquirer_settings[clearhaus][active]", ApiClient.ParameterToString(acquirerSettingsClearhausActive)); // form parameter
if (acquirerSettingsClearhausApiKey != null) formParams.Add("acquirer_settings[clearhaus][api_key]", ApiClient.ParameterToString(acquirerSettingsClearhausApiKey)); // form parameter
if (acquirerSettingsClearhausRecurring != null) formParams.Add("acquirer_settings[clearhaus][recurring]", ApiClient.ParameterToString(acquirerSettingsClearhausRecurring)); // form parameter
if (acquirerSettingsClearhausPayout != null) formParams.Add("acquirer_settings[clearhaus][payout]", ApiClient.ParameterToString(acquirerSettingsClearhausPayout)); // form parameter
if (acquirerSettingsClearhausApplePay != null) formParams.Add("acquirer_settings[clearhaus][apple_pay]", ApiClient.ParameterToString(acquirerSettingsClearhausApplePay)); // form parameter
if (acquirerSettingsElavonActive != null) formParams.Add("acquirer_settings[elavon][active]", ApiClient.ParameterToString(acquirerSettingsElavonActive)); // form parameter
if (acquirerSettingsElavonIdentificationCode != null) formParams.Add("acquirer_settings[elavon][identification_code]", ApiClient.ParameterToString(acquirerSettingsElavonIdentificationCode)); // form parameter
if (acquirerSettingsElavonIdentificationCodeInt != null) formParams.Add("acquirer_settings[elavon][identification_code_int]", ApiClient.ParameterToString(acquirerSettingsElavonIdentificationCodeInt)); // form parameter
if (acquirerSettingsElavonBusinessCode != null) formParams.Add("acquirer_settings[elavon][business_code]", ApiClient.ParameterToString(acquirerSettingsElavonBusinessCode)); // form parameter
if (acquirerSettingsElavonRecurring != null) formParams.Add("acquirer_settings[elavon][recurring]", ApiClient.ParameterToString(acquirerSettingsElavonRecurring)); // form parameter
if (acquirerSettingsElavonAmericanexpress != null) formParams.Add("acquirer_settings[elavon][americanexpress]", ApiClient.ParameterToString(acquirerSettingsElavonAmericanexpress)); // form parameter
if (acquirerSettingsElavonDinersclub != null) formParams.Add("acquirer_settings[elavon][dinersclub]", ApiClient.ParameterToString(acquirerSettingsElavonDinersclub)); // form parameter
if (acquirerSettingsElavonSecurepay != null) formParams.Add("acquirer_settings[elavon][securepay]", ApiClient.ParameterToString(acquirerSettingsElavonSecurepay)); // form parameter
if (acquirerSettingsElavonVisaMpiMerchantId != null) formParams.Add("acquirer_settings[elavon][visa_mpi_merchant_id]", ApiClient.ParameterToString(acquirerSettingsElavonVisaMpiMerchantId)); // form parameter
if (acquirerSettingsElavonMastercardMpiMerchantId != null) formParams.Add("acquirer_settings[elavon][mastercard_mpi_merchant_id]", ApiClient.ParameterToString(acquirerSettingsElavonMastercardMpiMerchantId)); // form parameter
if (acquirerSettingsElavonVisaBin != null) formParams.Add("acquirer_settings[elavon][visa_bin]", ApiClient.ParameterToString(acquirerSettingsElavonVisaBin)); // form parameter
if (acquirerSettingsElavonMastercardBin != null) formParams.Add("acquirer_settings[elavon][mastercard_bin]", ApiClient.ParameterToString(acquirerSettingsElavonMastercardBin)); // form parameter
if (acquirerSettingsHandelsbankenActive != null) formParams.Add("acquirer_settings[handelsbanken][active]", ApiClient.ParameterToString(acquirerSettingsHandelsbankenActive)); // form parameter
if (acquirerSettingsHandelsbankenIdentificationCode != null) formParams.Add("acquirer_settings[handelsbanken][identification_code]", ApiClient.ParameterToString(acquirerSettingsHandelsbankenIdentificationCode)); // form parameter
if (acquirerSettingsHandelsbankenIdentificationCodeInt != null) formParams.Add("acquirer_settings[handelsbanken][identification_code_int]", ApiClient.ParameterToString(acquirerSettingsHandelsbankenIdentificationCodeInt)); // form parameter
if (acquirerSettingsHandelsbankenBusinessCode != null) formParams.Add("acquirer_settings[handelsbanken][business_code]", ApiClient.ParameterToString(acquirerSettingsHandelsbankenBusinessCode)); // form parameter
if (acquirerSettingsHandelsbankenRecurring != null) formParams.Add("acquirer_settings[handelsbanken][recurring]", ApiClient.ParameterToString(acquirerSettingsHandelsbankenRecurring)); // form parameter
if (acquirerSettingsHandelsbankenAmericanexpress != null) formParams.Add("acquirer_settings[handelsbanken][americanexpress]", ApiClient.ParameterToString(acquirerSettingsHandelsbankenAmericanexpress)); // form parameter
if (acquirerSettingsHandelsbankenDinersclub != null) formParams.Add("acquirer_settings[handelsbanken][dinersclub]", ApiClient.ParameterToString(acquirerSettingsHandelsbankenDinersclub)); // form parameter
if (acquirerSettingsHandelsbankenSecurepay != null) formParams.Add("acquirer_settings[handelsbanken][securepay]", ApiClient.ParameterToString(acquirerSettingsHandelsbankenSecurepay)); // form parameter
if (acquirerSettingsHandelsbankenVisaMpiMerchantId != null) formParams.Add("acquirer_settings[handelsbanken][visa_mpi_merchant_id]", ApiClient.ParameterToString(acquirerSettingsHandelsbankenVisaMpiMerchantId)); // form parameter
if (acquirerSettingsHandelsbankenMastercardMpiMerchantId != null) formParams.Add("acquirer_settings[handelsbanken][mastercard_mpi_merchant_id]", ApiClient.ParameterToString(acquirerSettingsHandelsbankenMastercardMpiMerchantId)); // form parameter
if (acquirerSettingsHandelsbankenVisaBin != null) formParams.Add("acquirer_settings[handelsbanken][visa_bin]", ApiClient.ParameterToString(acquirerSettingsHandelsbankenVisaBin)); // form parameter
if (acquirerSettingsHandelsbankenMastercardBin != null) formParams.Add("acquirer_settings[handelsbanken][mastercard_bin]", ApiClient.ParameterToString(acquirerSettingsHandelsbankenMastercardBin)); // form parameter
if (acquirerSettingsKlarnaActive != null) formParams.Add("acquirer_settings[klarna][active]", ApiClient.ParameterToString(acquirerSettingsKlarnaActive)); // form parameter
if (acquirerSettingsKlarnaEid != null) formParams.Add("acquirer_settings[klarna][eid]", ApiClient.ParameterToString(acquirerSettingsKlarnaEid)); // form parameter
if (acquirerSettingsKlarnaSharedSecret != null) formParams.Add("acquirer_settings[klarna][shared_secret]", ApiClient.ParameterToString(acquirerSettingsKlarnaSharedSecret)); // form parameter
if (acquirerSettingsMobilepayActive != null) formParams.Add("acquirer_settings[mobilepay][active]", ApiClient.ParameterToString(acquirerSettingsMobilepayActive)); // form parameter
if (acquirerSettingsMobilepayDeliveryLimitedTo != null) formParams.Add("acquirer_settings[mobilepay][delivery_limited_to]", ApiClient.ParameterToString(acquirerSettingsMobilepayDeliveryLimitedTo)); // form parameter
if (acquirerSettingsMobilepaysubscriptionsActive != null) formParams.Add("acquirer_settings[mobilepaysubscriptions][active]", ApiClient.ParameterToString(acquirerSettingsMobilepaysubscriptionsActive)); // form parameter
if (acquirerSettingsMobilepaysubscriptionsAuthState != null) formParams.Add("acquirer_settings[mobilepaysubscriptions][auth_state]", ApiClient.ParameterToString(acquirerSettingsMobilepaysubscriptionsAuthState)); // form parameter
if (acquirerSettingsMobilepaysubscriptionsCodeVerifier != null) formParams.Add("acquirer_settings[mobilepaysubscriptions][code_verifier]", ApiClient.ParameterToString(acquirerSettingsMobilepaysubscriptionsCodeVerifier)); // form parameter
if (acquirerSettingsMobilepaysubscriptionsLastTokenRefresh != null) formParams.Add("acquirer_settings[mobilepaysubscriptions][last_token_refresh]", ApiClient.ParameterToString(acquirerSettingsMobilepaysubscriptionsLastTokenRefresh)); // form parameter
if (acquirerSettingsMobilepaysubscriptionsNonce != null) formParams.Add("acquirer_settings[mobilepaysubscriptions][nonce]", ApiClient.ParameterToString(acquirerSettingsMobilepaysubscriptionsNonce)); // form parameter
if (acquirerSettingsMobilepaysubscriptionsPendingStatus != null) formParams.Add("acquirer_settings[mobilepaysubscriptions][pending_status]", ApiClient.ParameterToString(acquirerSettingsMobilepaysubscriptionsPendingStatus)); // form parameter
if (acquirerSettingsMobilepaysubscriptionsProvider != null) formParams.Add("acquirer_settings[mobilepaysubscriptions][provider]", ApiClient.ParameterToString(acquirerSettingsMobilepaysubscriptionsProvider)); // form parameter
if (acquirerSettingsMobilepaysubscriptionsRefreshToken != null) formParams.Add("acquirer_settings[mobilepaysubscriptions][refresh_token]", ApiClient.ParameterToString(acquirerSettingsMobilepaysubscriptionsRefreshToken)); // form parameter
if (acquirerSettingsNetsActive != null) formParams.Add("acquirer_settings[nets][active]", ApiClient.ParameterToString(acquirerSettingsNetsActive)); // form parameter
if (acquirerSettingsNetsIdentificationCode != null) formParams.Add("acquirer_settings[nets][identification_code]", ApiClient.ParameterToString(acquirerSettingsNetsIdentificationCode)); // form parameter
if (acquirerSettingsNetsBusinessCode != null) formParams.Add("acquirer_settings[nets][business_code]", ApiClient.ParameterToString(acquirerSettingsNetsBusinessCode)); // form parameter
if (acquirerSettingsNetsRecurring != null) formParams.Add("acquirer_settings[nets][recurring]", ApiClient.ParameterToString(acquirerSettingsNetsRecurring)); // form parameter
if (acquirerSettingsNetsFbg1886 != null) formParams.Add("acquirer_settings[nets][fbg1886]", ApiClient.ParameterToString(acquirerSettingsNetsFbg1886)); // form parameter
if (acquirerSettingsNetsSecuredByNets != null) formParams.Add("acquirer_settings[nets][secured_by_nets]", ApiClient.ParameterToString(acquirerSettingsNetsSecuredByNets)); // form parameter
if (acquirerSettingsNetsIdentificationCodeInt != null) formParams.Add("acquirer_settings[nets][identification_code_int]", ApiClient.ParameterToString(acquirerSettingsNetsIdentificationCodeInt)); // form parameter
if (acquirerSettingsNetsAmericanexpress != null) formParams.Add("acquirer_settings[nets][americanexpress]", ApiClient.ParameterToString(acquirerSettingsNetsAmericanexpress)); // form parameter
if (acquirerSettingsNetsDinersclub != null) formParams.Add("acquirer_settings[nets][dinersclub]", ApiClient.ParameterToString(acquirerSettingsNetsDinersclub)); // form parameter
if (acquirerSettingsNetsSecurepay != null) formParams.Add("acquirer_settings[nets][securepay]", ApiClient.ParameterToString(acquirerSettingsNetsSecurepay)); // form parameter
if (acquirerSettingsNetsVisaBin != null) formParams.Add("acquirer_settings[nets][visa_bin]", ApiClient.ParameterToString(acquirerSettingsNetsVisaBin)); // form parameter
if (acquirerSettingsNetsMastercardBin != null) formParams.Add("acquirer_settings[nets][mastercard_bin]", ApiClient.ParameterToString(acquirerSettingsNetsMastercardBin)); // form parameter
if (acquirerSettingsPaypalActive != null) formParams.Add("acquirer_settings[paypal][active]", ApiClient.ParameterToString(acquirerSettingsPaypalActive)); // form parameter
if (acquirerSettingsPaypalRecurring != null) formParams.Add("acquirer_settings[paypal][recurring]", ApiClient.ParameterToString(acquirerSettingsPaypalRecurring)); // form parameter
if (acquirerSettingsPaypalCreditCard != null) formParams.Add("acquirer_settings[paypal][credit_card]", ApiClient.ParameterToString(acquirerSettingsPaypalCreditCard)); // form parameter
if (acquirerSettingsPaypalToken != null) formParams.Add("acquirer_settings[paypal][token]", ApiClient.ParameterToString(acquirerSettingsPaypalToken)); // form parameter
if (acquirerSettingsPaypalTokenSecret != null) formParams.Add("acquirer_settings[paypal][token_secret]", ApiClient.ParameterToString(acquirerSettingsPaypalTokenSecret)); // form parameter
if (acquirerSettingsSofortActive != null) formParams.Add("acquirer_settings[sofort][active]", ApiClient.ParameterToString(acquirerSettingsSofortActive)); // form parameter
if (acquirerSettingsSofortCustomerNumber != null) formParams.Add("acquirer_settings[sofort][customer_number]", ApiClient.ParameterToString(acquirerSettingsSofortCustomerNumber)); // form parameter
if (acquirerSettingsSofortProjectId != null) formParams.Add("acquirer_settings[sofort][project_id]", ApiClient.ParameterToString(acquirerSettingsSofortProjectId)); // form parameter
if (acquirerSettingsSofortApiKey != null) formParams.Add("acquirer_settings[sofort][api_key]", ApiClient.ParameterToString(acquirerSettingsSofortApiKey)); // form parameter
if (acquirerSettingsSofortGateway != null) formParams.Add("acquirer_settings[sofort][gateway]", ApiClient.ParameterToString(acquirerSettingsSofortGateway)); // form parameter
if (acquirerSettingsSofortIdeal != null) formParams.Add("acquirer_settings[sofort][ideal]", ApiClient.ParameterToString(acquirerSettingsSofortIdeal)); // form parameter
if (acquirerSettingsSofortIdealProjectId != null) formParams.Add("acquirer_settings[sofort][ideal_project_id]", ApiClient.ParameterToString(acquirerSettingsSofortIdealProjectId)); // form parameter
if (acquirerSettingsSofortIdealProjectPassword != null) formParams.Add("acquirer_settings[sofort][ideal_project_password]", ApiClient.ParameterToString(acquirerSettingsSofortIdealProjectPassword)); // form parameter
if (acquirerSettingsSofortIdealNotificationPassword != null) formParams.Add("acquirer_settings[sofort][ideal_notification_password]", ApiClient.ParameterToString(acquirerSettingsSofortIdealNotificationPassword)); // form parameter
if (acquirerSettingsSwedbankActive != null) formParams.Add("acquirer_settings[swedbank][active]", ApiClient.ParameterToString(acquirerSettingsSwedbankActive)); // form parameter
if (acquirerSettingsSwedbankIdentificationCode != null) formParams.Add("acquirer_settings[swedbank][identification_code]", ApiClient.ParameterToString(acquirerSettingsSwedbankIdentificationCode)); // form parameter
if (acquirerSettingsSwedbankIdentificationCodeInt != null) formParams.Add("acquirer_settings[swedbank][identification_code_int]", ApiClient.ParameterToString(acquirerSettingsSwedbankIdentificationCodeInt)); // form parameter
if (acquirerSettingsSwedbankBusinessCode != null) formParams.Add("acquirer_settings[swedbank][business_code]", ApiClient.ParameterToString(acquirerSettingsSwedbankBusinessCode)); // form parameter
if (acquirerSettingsSwedbankRecurring != null) formParams.Add("acquirer_settings[swedbank][recurring]", ApiClient.ParameterToString(acquirerSettingsSwedbankRecurring)); // form parameter
if (acquirerSettingsSwedbankAmericanexpress != null) formParams.Add("acquirer_settings[swedbank][americanexpress]", ApiClient.ParameterToString(acquirerSettingsSwedbankAmericanexpress)); // form parameter
if (acquirerSettingsSwedbankDinersclub != null) formParams.Add("acquirer_settings[swedbank][dinersclub]", ApiClient.ParameterToString(acquirerSettingsSwedbankDinersclub)); // form parameter
if (acquirerSettingsSwedbankSecurepay != null) formParams.Add("acquirer_settings[swedbank][securepay]", ApiClient.ParameterToString(acquirerSettingsSwedbankSecurepay)); // form parameter
if (acquirerSettingsSwedbankVisaMpiMerchantId != null) formParams.Add("acquirer_settings[swedbank][visa_mpi_merchant_id]", ApiClient.ParameterToString(acquirerSettingsSwedbankVisaMpiMerchantId)); // form parameter
if (acquirerSettingsSwedbankMastercardMpiMerchantId != null) formParams.Add("acquirer_settings[swedbank][mastercard_mpi_merchant_id]", ApiClient.ParameterToString(acquirerSettingsSwedbankMastercardMpiMerchantId)); // form parameter
if (acquirerSettingsSwedbankVisaBin != null) formParams.Add("acquirer_settings[swedbank][visa_bin]", ApiClient.ParameterToString(acquirerSettingsSwedbankVisaBin)); // form parameter
if (acquirerSettingsSwedbankMastercardBin != null) formParams.Add("acquirer_settings[swedbank][mastercard_bin]", ApiClient.ParameterToString(acquirerSettingsSwedbankMastercardBin)); // form parameter
if (acquirerSettingsTellerActive != null) formParams.Add("acquirer_settings[teller][active]", ApiClient.ParameterToString(acquirerSettingsTellerActive)); // form parameter
if (acquirerSettingsTellerIdentificationCode != null) formParams.Add("acquirer_settings[teller][identification_code]", ApiClient.ParameterToString(acquirerSettingsTellerIdentificationCode)); // form parameter
if (acquirerSettingsTellerIdentificationCodeInt != null) formParams.Add("acquirer_settings[teller][identification_code_int]", ApiClient.ParameterToString(acquirerSettingsTellerIdentificationCodeInt)); // form parameter
if (acquirerSettingsTellerBusinessCode != null) formParams.Add("acquirer_settings[teller][business_code]", ApiClient.ParameterToString(acquirerSettingsTellerBusinessCode)); // form parameter
if (acquirerSettingsTellerRecurring != null) formParams.Add("acquirer_settings[teller][recurring]", ApiClient.ParameterToString(acquirerSettingsTellerRecurring)); // form parameter
if (acquirerSettingsTellerAmericanexpress != null) formParams.Add("acquirer_settings[teller][americanexpress]", ApiClient.ParameterToString(acquirerSettingsTellerAmericanexpress)); // form parameter
if (acquirerSettingsTellerDinersclub != null) formParams.Add("acquirer_settings[teller][dinersclub]", ApiClient.ParameterToString(acquirerSettingsTellerDinersclub)); // form parameter
if (acquirerSettingsTellerSecurepay != null) formParams.Add("acquirer_settings[teller][securepay]", ApiClient.ParameterToString(acquirerSettingsTellerSecurepay)); // form parameter
if (acquirerSettingsTellerVisaMpiMerchantId != null) formParams.Add("acquirer_settings[teller][visa_mpi_merchant_id]", ApiClient.ParameterToString(acquirerSettingsTellerVisaMpiMerchantId)); // form parameter
if (acquirerSettingsTellerMastercardMpiMerchantId != null) formParams.Add("acquirer_settings[teller][mastercard_mpi_merchant_id]", ApiClient.ParameterToString(acquirerSettingsTellerMastercardMpiMerchantId)); // form parameter
if (acquirerSettingsTellerVisaBin != null) formParams.Add("acquirer_settings[teller][visa_bin]", ApiClient.ParameterToString(acquirerSettingsTellerVisaBin)); // form parameter
if (acquirerSettingsTellerMastercardBin != null) formParams.Add("acquirer_settings[teller][mastercard_bin]", ApiClient.ParameterToString(acquirerSettingsTellerMastercardBin)); // form parameter
if (acquirerSettingsValitorActive != null) formParams.Add("acquirer_settings[valitor][active]", ApiClient.ParameterToString(acquirerSettingsValitorActive)); // form parameter
if (acquirerSettingsValitorIdentificationCode != null) formParams.Add("acquirer_settings[valitor][identification_code]", ApiClient.ParameterToString(acquirerSettingsValitorIdentificationCode)); // form parameter
if (acquirerSettingsValitorIdentificationCodeInt != null) formParams.Add("acquirer_settings[valitor][identification_code_int]", ApiClient.ParameterToString(acquirerSettingsValitorIdentificationCodeInt)); // form parameter
if (acquirerSettingsValitorBusinessCode != null) formParams.Add("acquirer_settings[valitor][business_code]", ApiClient.ParameterToString(acquirerSettingsValitorBusinessCode)); // form parameter
if (acquirerSettingsValitorRecurring != null) formParams.Add("acquirer_settings[valitor][recurring]", ApiClient.ParameterToString(acquirerSettingsValitorRecurring)); // form parameter
if (acquirerSettingsValitorAmericanexpress != null) formParams.Add("acquirer_settings[valitor][americanexpress]", ApiClient.ParameterToString(acquirerSettingsValitorAmericanexpress)); // form parameter
if (acquirerSettingsValitorDinersclub != null) formParams.Add("acquirer_settings[valitor][dinersclub]", ApiClient.ParameterToString(acquirerSettingsValitorDinersclub)); // form parameter
if (acquirerSettingsValitorSecurepay != null) formParams.Add("acquirer_settings[valitor][securepay]", ApiClient.ParameterToString(acquirerSettingsValitorSecurepay)); // form parameter
if (acquirerSettingsValitorVisaMpiMerchantId != null) formParams.Add("acquirer_settings[valitor][visa_mpi_merchant_id]", ApiClient.ParameterToString(acquirerSettingsValitorVisaMpiMerchantId)); // form parameter
if (acquirerSettingsValitorMastercardMpiMerchantId != null) formParams.Add("acquirer_settings[valitor][mastercard_mpi_merchant_id]", ApiClient.ParameterToString(acquirerSettingsValitorMastercardMpiMerchantId)); // form parameter
if (acquirerSettingsValitorVisaBin != null) formParams.Add("acquirer_settings[valitor][visa_bin]", ApiClient.ParameterToString(acquirerSettingsValitorVisaBin)); // form parameter
if (acquirerSettingsValitorMastercardBin != null) formParams.Add("acquirer_settings[valitor][mastercard_bin]", ApiClient.ParameterToString(acquirerSettingsValitorMastercardBin)); // form parameter
if (acquirerSettingsViabillActive != null) formParams.Add("acquirer_settings[viabill][active]", ApiClient.ParameterToString(acquirerSettingsViabillActive)); // form parameter
if (acquirerSettingsViabillApiKey != null) formParams.Add("acquirer_settings[viabill][api_key]", ApiClient.ParameterToString(acquirerSettingsViabillApiKey)); // form parameter
if (integrationSettingsEconomicActive != null) formParams.Add("integration_settings[economic][active]", ApiClient.ParameterToString(integrationSettingsEconomicActive)); // form parameter
if (integrationSettingsEconomicAgreement != null) formParams.Add("integration_settings[economic][agreement]", ApiClient.ParameterToString(integrationSettingsEconomicAgreement)); // form parameter
if (integrationSettingsEconomicAgreementToken != null) formParams.Add("integration_settings[economic][agreement_token]", ApiClient.ParameterToString(integrationSettingsEconomicAgreementToken)); // form parameter
if (pciSaqA != null) formParams.Add("pci[saq_a]", ApiClient.ParameterToString(pciSaqA)); // form parameter
if (pciSaqAEp != null) formParams.Add("pci[saq_a_ep]", ApiClient.ParameterToString(pciSaqAEp)); // form parameter
if (pciSaqB != null) formParams.Add("pci[saq_b]", ApiClient.ParameterToString(pciSaqB)); // form parameter
if (pciSaqBIp != null) formParams.Add("pci[saq_b_ip]", ApiClient.ParameterToString(pciSaqBIp)); // form parameter
if (pciSaqC != null) formParams.Add("pci[saq_c]", ApiClient.ParameterToString(pciSaqC)); // form parameter
if (pciSaqCVt != null) formParams.Add("pci[saq_c_vt]", ApiClient.ParameterToString(pciSaqCVt)); // form parameter
if (pciSaqDMerchant != null) formParams.Add("pci[saq_d_merchant]", ApiClient.ParameterToString(pciSaqDMerchant)); // form parameter
if (pciSaqDServiceProvider != null) formParams.Add("pci[saq_d_service_provider]", ApiClient.ParameterToString(pciSaqDServiceProvider)); // form parameter
if (pciSaqP2peHw != null) formParams.Add("pci[saq_p2pe_hw]", ApiClient.ParameterToString(pciSaqP2peHw)); // form parameter
if (autofee != null) formParams.Add("autofee", ApiClient.ParameterToString(autofee)); // form parameter
if (defaultPaymentMethods != null) formParams.Add("default_payment_methods", ApiClient.ParameterToString(defaultPaymentMethods)); // form parameter
if (shopUrl != null) formParams.Add("shop_url", ApiClient.ParameterToString(shopUrl)); // form parameter
if (contactEmail != null) formParams.Add("contact_email", ApiClient.ParameterToString(contactEmail)); // form parameter
if (shopName != null) formParams.Add("shop_name", ApiClient.ParameterToString(shopName)); // form parameter
if (shopsystem != null) formParams.Add("shopsystem", ApiClient.ParameterToString(shopsystem)); // form parameter
if (timezone != null) formParams.Add("timezone", ApiClient.ParameterToString(timezone)); // form parameter
if (locale != null) formParams.Add("locale", ApiClient.ParameterToString(locale)); // form parameter
if (defaultBrandingId != null) formParams.Add("default_branding_id", ApiClient.ParameterToString(defaultBrandingId)); // form parameter
if (loggingStopsAt != null) formParams.Add("logging_stops_at", ApiClient.ParameterToString(loggingStopsAt)); // form parameter
if (allowTestTransactions != null) formParams.Add("allow_test_transactions", ApiClient.ParameterToString(allowTestTransactions)); // form parameter
if (defaultPaymentLanguage != null) formParams.Add("default_payment_language", ApiClient.ParameterToString(defaultPaymentLanguage)); // form parameter
if (defaultTextOnStatement != null) formParams.Add("default_text_on_statement", ApiClient.ParameterToString(defaultTextOnStatement)); // form parameter
if (defaultBrandingConfig != null) formParams.Add("default_branding_config", ApiClient.ParameterToString(defaultBrandingConfig)); // form parameter
            postBody = ApiClient.Serialize(shopUrls); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAccountFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAccountFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10Merchant) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10Merchant), response.Headers);
        }
    
        /// <summary>
        /// Regenerates the private key of the merchant  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <returns>QuickPayProtocolV10PrivateKey</returns>            
        public QuickPayProtocolV10PrivateKey PATCHAccountPrivateKeyFormat (string acceptVersion, string authorization)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PATCHAccountPrivateKeyFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PATCHAccountPrivateKeyFormat");
            
    
            var path = "/account/private-key";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAccountPrivateKeyFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAccountPrivateKeyFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10PrivateKey) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10PrivateKey), response.Headers);
        }
    
        /// <summary>
        /// Creates or replaces the current merchant logo  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="_file">&lt;p&gt;The logo as a multipart file. If the logo_type is ‘mobilepay’, the logo must be a 250px x 250px PNG file&lt;/p&gt; </param> 
        /// <param name="logoType">&lt;p&gt;Type of logo&lt;/p&gt; </param> 
        /// <returns></returns>            
        public void PUTAccountLogoFormat (string acceptVersion, string authorization, string _file, string logoType)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PUTAccountLogoFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PUTAccountLogoFormat");
            
            // verify the required parameter '_file' is set
            if (_file == null) throw new ApiException(400, "Missing required parameter '_file' when calling PUTAccountLogoFormat");
            
    
            var path = "/account/logo";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
            if (_file != null) formParams.Add("file", ApiClient.ParameterToString(_file)); // form parameter
if (logoType != null) formParams.Add("logo_type", ApiClient.ParameterToString(logoType)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTAccountLogoFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTAccountLogoFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
