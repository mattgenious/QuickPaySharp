using System;
using System.Collections.Generic;
using RestSharp;
using QuickPaySharp.Client;
using QuickPaySharp.Model;

namespace QuickPaySharp.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAccountApi
    {
        /// <summary>
        /// Delete 04 platform settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <returns>Zero4PlatformSettings</returns>
        Zero4PlatformSettings DELETEAccount04PlatformFormat (string acceptVersion, string authorization);
        /// <summary>
        /// Delete merchant account  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <returns></returns>
        void DELETEAccountFormat (string acceptVersion, string authorization);
        /// <summary>
        /// Deletes the current merchant logo  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="logoType">Type of logo </param>
        /// <returns></returns>
        void DELETEAccountLogoFormat (string acceptVersion, string authorization, string logoType);
        /// <summary>
        /// Get 04 platform settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <returns>Zero4PlatformSettings</returns>
        Zero4PlatformSettings GETAccount04PlatformFormat (string acceptVersion, string authorization);
        /// <summary>
        /// Get merchant account  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <returns>Merchant</returns>
        Merchant GETAccountFormat (string acceptVersion, string authorization);
        /// <summary>
        /// Gets the merchant logo as a raw download or a 404 if none exists  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="logoType">Type of logo </param>
        /// <returns></returns>
        void GETAccountLogoFormat (string acceptVersion, string authorization, string logoType);
        /// <summary>
        /// Gets the private key of the merchant  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <returns>PrivateKey</returns>
        PrivateKey GETAccountPrivateKeyFormat (string acceptVersion, string authorization);
        /// <summary>
        /// Update merchant account  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="customerAddressName">Name </param>
        /// <param name="customerAddressAtt">Att </param>
        /// <param name="customerAddressStreet">Street </param>
        /// <param name="customerAddressCity">City </param>
        /// <param name="customerAddressZipCode">Zip code </param>
        /// <param name="customerAddressRegion">Region </param>
        /// <param name="customerAddressCountryCode">Three letter country code according to ISO 3166-1 Alpha-3 </param>
        /// <param name="customerAddressVatNo">VAT registration number </param>
        /// <param name="billingAddressName">Name </param>
        /// <param name="billingAddressAtt">Att </param>
        /// <param name="billingAddressStreet">Street </param>
        /// <param name="billingAddressCity">City </param>
        /// <param name="billingAddressZipCode">Zip code </param>
        /// <param name="billingAddressRegion">Region </param>
        /// <param name="billingAddressCountryCode">Three letter country code according to ISO 3166-1 Alpha-3 </param>
        /// <param name="billingAddressVatNo">VAT registration number </param>
        /// <param name="callbackUrl">Callback url </param>
        /// <param name="acquirerSettingsBamboraActive">Enable Bambora payments </param>
        /// <param name="acquirerSettingsBamboraIdentificationCode">Bambora identification number </param>
        /// <param name="acquirerSettingsBamboraIdentificationCodeInt">Bambora international identification number </param>
        /// <param name="acquirerSettingsBamboraBusinessCode">Business code (assigned by Bambora) </param>
        /// <param name="acquirerSettingsBamboraRecurring">Enable recurring payments (requires agreement with Bambora) </param>
        /// <param name="acquirerSettingsBamboraAmericanexpress">Enable AMEX payments (requires agreement with Bambora) </param>
        /// <param name="acquirerSettingsBamboraDinersclub">Enable Diners Club payments (requires agreement with Bambora) </param>
        /// <param name="acquirerSettingsBamboraSecurepay">Enable SecurePay fraud protection. </param>
        /// <param name="acquirerSettingsBamboraVisaMpiMerchantId">VISA MPI merchant id. Used for 3D secure transactions </param>
        /// <param name="acquirerSettingsBamboraMastercardMpiMerchantId">Mastercard MPI merchant id. Used for 3D secure transactions </param>
        /// <param name="acquirerSettingsBamboraVisaBin">VISA acquirer bin used for 3D Secure </param>
        /// <param name="acquirerSettingsBamboraMastercardBin">Mastercard acquirer bin used for 3D Secure </param>
        /// <param name="acquirerSettingsClearhausActive">Enable ClearHaus payments </param>
        /// <param name="acquirerSettingsClearhausApiKey">Clearhaus API key (is required but may be left empty) </param>
        /// <param name="acquirerSettingsClearhausRecurring">Enable recurring payments (requires agreement with Clearhaus) </param>
        /// <param name="acquirerSettingsClearhausPayout">Enable payouts (requires agreement with Clearhaus) </param>
        /// <param name="acquirerSettingsClearhausApplePay">Enable Apple Pay (requires agreement with Clearhaus) </param>
        /// <param name="acquirerSettingsElavonActive">Enable Elavon payments </param>
        /// <param name="acquirerSettingsElavonIdentificationCode">Elavon identification number </param>
        /// <param name="acquirerSettingsElavonIdentificationCodeInt">Elavon international identification number </param>
        /// <param name="acquirerSettingsElavonBusinessCode">Business code (assigned by Elavon) </param>
        /// <param name="acquirerSettingsElavonRecurring">Enable recurring payments (requires agreement with Elavon) </param>
        /// <param name="acquirerSettingsElavonAmericanexpress">Enable AMEX payments (requires agreement with Elavon) </param>
        /// <param name="acquirerSettingsElavonDinersclub">Enable Diners Club payments (requires agreement with Elavon) </param>
        /// <param name="acquirerSettingsElavonSecurepay">Enable SecurePay fraud protection. </param>
        /// <param name="acquirerSettingsElavonVisaMpiMerchantId">VISA MPI merchant id. Used for 3D secure transactions </param>
        /// <param name="acquirerSettingsElavonMastercardMpiMerchantId">Mastercard MPI merchant id. Used for 3D secure transactions </param>
        /// <param name="acquirerSettingsElavonVisaBin">VISA acquirer bin used for 3D Secure </param>
        /// <param name="acquirerSettingsElavonMastercardBin">Mastercard acquirer bin used for 3D Secure </param>
        /// <param name="acquirerSettingsHandelsbankenActive">Enable Handelsbanken payments </param>
        /// <param name="acquirerSettingsHandelsbankenIdentificationCode">Handelsbanken identification number </param>
        /// <param name="acquirerSettingsHandelsbankenIdentificationCodeInt">Handelsbanken international identification number </param>
        /// <param name="acquirerSettingsHandelsbankenBusinessCode">Business code (assigned by Handelsbanken) </param>
        /// <param name="acquirerSettingsHandelsbankenRecurring">Enable recurring payments (requires agreement with Handelsbanken) </param>
        /// <param name="acquirerSettingsHandelsbankenAmericanexpress">Enable AMEX payments (requires agreement with Handelsbanken) </param>
        /// <param name="acquirerSettingsHandelsbankenDinersclub">Enable Diners Club payments (requires agreement with Handelsbanken) </param>
        /// <param name="acquirerSettingsHandelsbankenSecurepay">Enable SecurePay fraud protection. </param>
        /// <param name="acquirerSettingsHandelsbankenVisaMpiMerchantId">VISA MPI merchant id. Used for 3D secure transactions </param>
        /// <param name="acquirerSettingsHandelsbankenMastercardMpiMerchantId">Mastercard MPI merchant id. Used for 3D secure transactions </param>
        /// <param name="acquirerSettingsHandelsbankenVisaBin">VISA acquirer bin used for 3D Secure </param>
        /// <param name="acquirerSettingsHandelsbankenMastercardBin">Mastercard acquirer bin used for 3D Secure </param>
        /// <param name="acquirerSettingsKlarnaActive">Enable Klarna payments </param>
        /// <param name="acquirerSettingsKlarnaEid">Klarna merchant ID </param>
        /// <param name="acquirerSettingsKlarnaSharedSecret">Klarna shared secret </param>
        /// <param name="acquirerSettingsMobilepayActive">Enable MobilePay payments </param>
        /// <param name="acquirerSettingsMobilepayDeliveryLimitedTo">Limit MobilePay delivery address selection to theses countries. (ISO 3166-1 alpha-2 without delimiter ‘DKNOSEFI’) (Valid options are DK,NO,SE,FI) </param>
        /// <param name="acquirerSettingsMobilepaysubscriptionsActive">Enable MobilePay Subscriptions payments </param>
        /// <param name="acquirerSettingsMobilepaysubscriptionsAuthState">Identifier MobilePay Subscriptions uses to link requests to callbacks </param>
        /// <param name="acquirerSettingsMobilepaysubscriptionsCodeVerifier">Verifies received code challenge </param>
        /// <param name="acquirerSettingsMobilepaysubscriptionsLastTokenRefresh">Unix Timestamp of last time the tokens were refreshed </param>
        /// <param name="acquirerSettingsMobilepaysubscriptionsNonce">Associate client sessions with ID Tokens to mitigate replay attacks </param>
        /// <param name="acquirerSettingsMobilepaysubscriptionsPendingStatus">0: agreement inactive, 1: flow initialised, 2: tokens received, 3: flow completed </param>
        /// <param name="acquirerSettingsMobilepaysubscriptionsProvider">The provider / sales-place chosen by the merchant </param>
        /// <param name="acquirerSettingsMobilepaysubscriptionsRefreshToken">Token to refresh access token for up to 1 year </param>
        /// <param name="acquirerSettingsNetsActive">Enable Nets/Teller payments </param>
        /// <param name="acquirerSettingsNetsIdentificationCode">Nets TOF number </param>
        /// <param name="acquirerSettingsNetsBusinessCode">Business code (assigned by Nets) </param>
        /// <param name="acquirerSettingsNetsRecurring">Enable recurring payments (requires agreement with Nets) </param>
        /// <param name="acquirerSettingsNetsFbg1886">Enable Forbrugsforeningen payments (requires agreement with Nets and Forbrugsforeningen) </param>
        /// <param name="acquirerSettingsNetsSecuredByNets">Enable SecuredByNets fraud protection. </param>
        /// <param name="acquirerSettingsNetsIdentificationCodeInt">(Depricated; use Teller acquirer) </param>
        /// <param name="acquirerSettingsNetsAmericanexpress">(Depricated; use Teller acquirer) </param>
        /// <param name="acquirerSettingsNetsDinersclub">(Depricated; use Teller acquirer) </param>
        /// <param name="acquirerSettingsNetsSecurepay">(Depricated; use Teller acquirer) </param>
        /// <param name="acquirerSettingsNetsVisaBin">(Depricated; use Teller acquirer) </param>
        /// <param name="acquirerSettingsNetsMastercardBin">(Depricated; use Teller acquirer) </param>
        /// <param name="acquirerSettingsPaypalActive">Enable PayPal payments </param>
        /// <param name="acquirerSettingsPaypalRecurring">Enable recurring payments </param>
        /// <param name="acquirerSettingsPaypalCreditCard">Allow credit-card payments. (Only for US/CA/UK merchants) </param>
        /// <param name="acquirerSettingsPaypalToken">Authentication token </param>
        /// <param name="acquirerSettingsPaypalTokenSecret">Authentication token secret </param>
        /// <param name="acquirerSettingsPaypalScope">Authentication scope </param>
        /// <param name="acquirerSettingsSofortActive">Enable Sofort payments </param>
        /// <param name="acquirerSettingsSofortCustomerNumber">Sofort customer number </param>
        /// <param name="acquirerSettingsSofortProjectId">Sofort Gateway project id </param>
        /// <param name="acquirerSettingsSofortApiKey">Sofort API key </param>
        /// <param name="acquirerSettingsSofortGateway">Enable Sofort Gateway feature </param>
        /// <param name="acquirerSettingsSofortIdeal">Enable Sofort iDeal feature </param>
        /// <param name="acquirerSettingsSofortIdealProjectId">Sofort iDeal project id </param>
        /// <param name="acquirerSettingsSofortIdealProjectPassword">Sofort iDeal project password </param>
        /// <param name="acquirerSettingsSofortIdealNotificationPassword">Sofort iDeal notification password </param>
        /// <param name="acquirerSettingsSwedbankActive">Enable Swedbank payments </param>
        /// <param name="acquirerSettingsSwedbankIdentificationCode">Swedbank identification number </param>
        /// <param name="acquirerSettingsSwedbankIdentificationCodeInt">Swedbank international identification number </param>
        /// <param name="acquirerSettingsSwedbankBusinessCode">Business code (assigned by Swedbank) </param>
        /// <param name="acquirerSettingsSwedbankRecurring">Enable recurring payments (requires agreement with Swedbank) </param>
        /// <param name="acquirerSettingsSwedbankAmericanexpress">Enable AMEX payments (requires agreement with Swedbank) </param>
        /// <param name="acquirerSettingsSwedbankDinersclub">Enable Diners Club payments (requires agreement with Swedbank) </param>
        /// <param name="acquirerSettingsSwedbankSecurepay">Enable SecurePay fraud protection. </param>
        /// <param name="acquirerSettingsSwedbankVisaMpiMerchantId">VISA MPI merchant id. Used for 3D secure transactions </param>
        /// <param name="acquirerSettingsSwedbankMastercardMpiMerchantId">Mastercard MPI merchant id. Used for 3D secure transactions </param>
        /// <param name="acquirerSettingsSwedbankVisaBin">VISA acquirer bin used for 3D Secure </param>
        /// <param name="acquirerSettingsSwedbankMastercardBin">Mastercard acquirer bin used for 3D Secure </param>
        /// <param name="acquirerSettingsTellerActive">Enable Teller payments </param>
        /// <param name="acquirerSettingsTellerIdentificationCode">Teller TOF number </param>
        /// <param name="acquirerSettingsTellerIdentificationCodeInt">Teller international identification number </param>
        /// <param name="acquirerSettingsTellerBusinessCode">Business code (assigned by Teller) </param>
        /// <param name="acquirerSettingsTellerRecurring">Enable recurring payments (requires agreement with Teller) </param>
        /// <param name="acquirerSettingsTellerAmericanexpress">Enable AMEX payments (requires agreement with Teller) </param>
        /// <param name="acquirerSettingsTellerDinersclub">Enable Diners Club payments (requires agreement with Teller) </param>
        /// <param name="acquirerSettingsTellerSecurepay">Enable SecurePay fraud protection. (disabling requires agreement with Teller) </param>
        /// <param name="acquirerSettingsTellerVisaMpiMerchantId">VISA MPI merchant id. Used for 3D secure transactions </param>
        /// <param name="acquirerSettingsTellerMastercardMpiMerchantId">Mastercard MPI merchant id. Used for 3D secure transactions </param>
        /// <param name="acquirerSettingsTellerVisaBin">Teller VISA acquirer bin used for 3D Secure </param>
        /// <param name="acquirerSettingsTellerMastercardBin">Teller Mastercard acquirer bin used for 3D Secure </param>
        /// <param name="acquirerSettingsValitorActive">Enable Valitor payments </param>
        /// <param name="acquirerSettingsValitorIdentificationCode">Valitor identification number </param>
        /// <param name="acquirerSettingsValitorIdentificationCodeInt">Valitor international identification number </param>
        /// <param name="acquirerSettingsValitorBusinessCode">Business code (assigned by Valitor) </param>
        /// <param name="acquirerSettingsValitorRecurring">Enable recurring payments (requires agreement with Valitor) </param>
        /// <param name="acquirerSettingsValitorAmericanexpress">Enable AMEX payments (requires agreement with Valitor) </param>
        /// <param name="acquirerSettingsValitorDinersclub">Enable Diners Club payments (requires agreement with Valitor) </param>
        /// <param name="acquirerSettingsValitorSecurepay">Enable SecurePay fraud protection. </param>
        /// <param name="acquirerSettingsValitorVisaMpiMerchantId">VISA MPI merchant id. Used for 3D secure transactions </param>
        /// <param name="acquirerSettingsValitorMastercardMpiMerchantId">Mastercard MPI merchant id. Used for 3D secure transactions </param>
        /// <param name="acquirerSettingsValitorVisaBin">VISA acquirer bin used for 3D Secure </param>
        /// <param name="acquirerSettingsValitorMastercardBin">Mastercard acquirer bin used for 3D Secure </param>
        /// <param name="acquirerSettingsViabillActive">Enable ViaBill payments </param>
        /// <param name="acquirerSettingsViabillApiKey">ViaBill API key </param>
        /// <param name="integrationSettingsEconomicActive">Enable e-conomic integration </param>
        /// <param name="integrationSettingsEconomicAgreement">e-conomic agreement no. </param>
        /// <param name="integrationSettingsEconomicAgreementToken">economic agreement grant token </param>
        /// <param name="pciSaqA">Enable SAQ A </param>
        /// <param name="pciSaqAEp">Enable SAQ A-EP </param>
        /// <param name="pciSaqB">Enable SAQ B </param>
        /// <param name="pciSaqBIp">Enable SAQ B-IP </param>
        /// <param name="pciSaqC">Enable SAQ C </param>
        /// <param name="pciSaqCVt">Enable SAQ C-VT </param>
        /// <param name="pciSaqDMerchant">Enable SAQ D Merchant </param>
        /// <param name="pciSaqDServiceProvider">Enable SAQ D Service Provider </param>
        /// <param name="pciSaqP2peHw">Enable SAQ P2PE-HW </param>
        /// <param name="autofee">Add automatic fee on all payments </param>
        /// <param name="defaultPaymentMethods">Comma separated list of default payment methods </param>
        /// <param name="shopUrl">Shop URL (deprecated, use shop_urls instead) </param>
        /// <param name="shopUrls">Shop URLs </param>
        /// <param name="contactEmail">Contact email </param>
        /// <param name="shopName">Shop name </param>
        /// <param name="shopsystem">Shop system </param>
        /// <param name="timezone">&lt;table&gt;   &lt;tbody&gt;     &lt;tr&gt;       &lt;td&gt;Timezone UTC offsets in Zulu (+&lt;/td&gt;       &lt;td&gt;-)hh:mm&lt;/td&gt;     &lt;/tr&gt;   &lt;/tbody&gt; &lt;/table&gt; </param>
        /// <param name="locale">Locale as a two letter language code </param>
        /// <param name="defaultBrandingId">Id of default branding </param>
        /// <param name="loggingStopsAt">Timestamp when logging is active </param>
        /// <param name="allowTestTransactions">Allow test transactions </param>
        /// <param name="defaultPaymentLanguage">Default payment language (Two letter language code, ISO-639-1) </param>
        /// <param name="defaultTextOnStatement">Text to be displayed on cardholder’s statement. Max 22 ASCII chars. Currently supported by Clearhaus only. </param>
        /// <param name="defaultBrandingConfig">Default branding config. Can be overwritten in branding or in request to payment window </param>
        /// <returns>Merchant</returns>
        Merchant PATCHAccountFormat (string acceptVersion, string authorization, string customerAddressName, string customerAddressAtt, string customerAddressStreet, string customerAddressCity, string customerAddressZipCode, string customerAddressRegion, string customerAddressCountryCode, string customerAddressVatNo, string billingAddressName, string billingAddressAtt, string billingAddressStreet, string billingAddressCity, string billingAddressZipCode, string billingAddressRegion, string billingAddressCountryCode, string billingAddressVatNo, string callbackUrl, bool? acquirerSettingsBamboraActive, string acquirerSettingsBamboraIdentificationCode, string acquirerSettingsBamboraIdentificationCodeInt, string acquirerSettingsBamboraBusinessCode, bool? acquirerSettingsBamboraRecurring, bool? acquirerSettingsBamboraAmericanexpress, bool? acquirerSettingsBamboraDinersclub, bool? acquirerSettingsBamboraSecurepay, string acquirerSettingsBamboraVisaMpiMerchantId, string acquirerSettingsBamboraMastercardMpiMerchantId, string acquirerSettingsBamboraVisaBin, string acquirerSettingsBamboraMastercardBin, bool? acquirerSettingsClearhausActive, string acquirerSettingsClearhausApiKey, bool? acquirerSettingsClearhausRecurring, bool? acquirerSettingsClearhausPayout, bool? acquirerSettingsClearhausApplePay, bool? acquirerSettingsElavonActive, string acquirerSettingsElavonIdentificationCode, string acquirerSettingsElavonIdentificationCodeInt, string acquirerSettingsElavonBusinessCode, bool? acquirerSettingsElavonRecurring, bool? acquirerSettingsElavonAmericanexpress, bool? acquirerSettingsElavonDinersclub, bool? acquirerSettingsElavonSecurepay, string acquirerSettingsElavonVisaMpiMerchantId, string acquirerSettingsElavonMastercardMpiMerchantId, string acquirerSettingsElavonVisaBin, string acquirerSettingsElavonMastercardBin, bool? acquirerSettingsHandelsbankenActive, string acquirerSettingsHandelsbankenIdentificationCode, string acquirerSettingsHandelsbankenIdentificationCodeInt, string acquirerSettingsHandelsbankenBusinessCode, bool? acquirerSettingsHandelsbankenRecurring, bool? acquirerSettingsHandelsbankenAmericanexpress, bool? acquirerSettingsHandelsbankenDinersclub, bool? acquirerSettingsHandelsbankenSecurepay, string acquirerSettingsHandelsbankenVisaMpiMerchantId, string acquirerSettingsHandelsbankenMastercardMpiMerchantId, string acquirerSettingsHandelsbankenVisaBin, string acquirerSettingsHandelsbankenMastercardBin, bool? acquirerSettingsKlarnaActive, int? acquirerSettingsKlarnaEid, string acquirerSettingsKlarnaSharedSecret, bool? acquirerSettingsMobilepayActive, string acquirerSettingsMobilepayDeliveryLimitedTo, bool? acquirerSettingsMobilepaysubscriptionsActive, string acquirerSettingsMobilepaysubscriptionsAuthState, string acquirerSettingsMobilepaysubscriptionsCodeVerifier, int? acquirerSettingsMobilepaysubscriptionsLastTokenRefresh, string acquirerSettingsMobilepaysubscriptionsNonce, int? acquirerSettingsMobilepaysubscriptionsPendingStatus, string acquirerSettingsMobilepaysubscriptionsProvider, string acquirerSettingsMobilepaysubscriptionsRefreshToken, bool? acquirerSettingsNetsActive, string acquirerSettingsNetsIdentificationCode, string acquirerSettingsNetsBusinessCode, bool? acquirerSettingsNetsRecurring, bool? acquirerSettingsNetsFbg1886, bool? acquirerSettingsNetsSecuredByNets, string acquirerSettingsNetsIdentificationCodeInt, bool? acquirerSettingsNetsAmericanexpress, bool? acquirerSettingsNetsDinersclub, bool? acquirerSettingsNetsSecurepay, string acquirerSettingsNetsVisaBin, string acquirerSettingsNetsMastercardBin, bool? acquirerSettingsPaypalActive, bool? acquirerSettingsPaypalRecurring, bool? acquirerSettingsPaypalCreditCard, string acquirerSettingsPaypalToken, string acquirerSettingsPaypalTokenSecret, string acquirerSettingsPaypalScope, bool? acquirerSettingsSofortActive, int? acquirerSettingsSofortCustomerNumber, int? acquirerSettingsSofortProjectId, string acquirerSettingsSofortApiKey, bool? acquirerSettingsSofortGateway, bool? acquirerSettingsSofortIdeal, int? acquirerSettingsSofortIdealProjectId, string acquirerSettingsSofortIdealProjectPassword, string acquirerSettingsSofortIdealNotificationPassword, bool? acquirerSettingsSwedbankActive, string acquirerSettingsSwedbankIdentificationCode, string acquirerSettingsSwedbankIdentificationCodeInt, string acquirerSettingsSwedbankBusinessCode, bool? acquirerSettingsSwedbankRecurring, bool? acquirerSettingsSwedbankAmericanexpress, bool? acquirerSettingsSwedbankDinersclub, bool? acquirerSettingsSwedbankSecurepay, string acquirerSettingsSwedbankVisaMpiMerchantId, string acquirerSettingsSwedbankMastercardMpiMerchantId, string acquirerSettingsSwedbankVisaBin, string acquirerSettingsSwedbankMastercardBin, bool? acquirerSettingsTellerActive, string acquirerSettingsTellerIdentificationCode, string acquirerSettingsTellerIdentificationCodeInt, string acquirerSettingsTellerBusinessCode, bool? acquirerSettingsTellerRecurring, bool? acquirerSettingsTellerAmericanexpress, bool? acquirerSettingsTellerDinersclub, bool? acquirerSettingsTellerSecurepay, string acquirerSettingsTellerVisaMpiMerchantId, string acquirerSettingsTellerMastercardMpiMerchantId, string acquirerSettingsTellerVisaBin, string acquirerSettingsTellerMastercardBin, bool? acquirerSettingsValitorActive, string acquirerSettingsValitorIdentificationCode, string acquirerSettingsValitorIdentificationCodeInt, string acquirerSettingsValitorBusinessCode, bool? acquirerSettingsValitorRecurring, bool? acquirerSettingsValitorAmericanexpress, bool? acquirerSettingsValitorDinersclub, bool? acquirerSettingsValitorSecurepay, string acquirerSettingsValitorVisaMpiMerchantId, string acquirerSettingsValitorMastercardMpiMerchantId, string acquirerSettingsValitorVisaBin, string acquirerSettingsValitorMastercardBin, bool? acquirerSettingsViabillActive, string acquirerSettingsViabillApiKey, bool? integrationSettingsEconomicActive, string integrationSettingsEconomicAgreement, string integrationSettingsEconomicAgreementToken, bool? pciSaqA, bool? pciSaqAEp, bool? pciSaqB, bool? pciSaqBIp, bool? pciSaqC, bool? pciSaqCVt, bool? pciSaqDMerchant, bool? pciSaqDServiceProvider, bool? pciSaqP2peHw, bool? autofee, string defaultPaymentMethods, string shopUrl, string shopUrls, string contactEmail, string shopName, string shopsystem, string timezone, string locale, int? defaultBrandingId, string loggingStopsAt, bool? allowTestTransactions, string defaultPaymentLanguage, string defaultTextOnStatement, string defaultBrandingConfig);
        /// <summary>
        /// Regenerates the private key of the merchant  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <returns>PrivateKey</returns>
        PrivateKey PATCHAccountPrivateKeyFormat (string acceptVersion, string authorization);
        /// <summary>
        /// Creates or replaces the current merchant logo  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="_file">The logo as a multipart file. If the logo_type is ‘mobilepay’, the logo must be a 250px x 250px PNG file </param>
        /// <param name="logoType">Type of logo </param>
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
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <returns>Zero4PlatformSettings</returns>            
        public Zero4PlatformSettings DELETEAccount04PlatformFormat (string acceptVersion, string authorization)
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
    
            return (Zero4PlatformSettings) ApiClient.Deserialize(response.Content, typeof(Zero4PlatformSettings), response.Headers);
        }
    
        /// <summary>
        /// Delete merchant account  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
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
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="logoType">Type of logo </param> 
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
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <returns>Zero4PlatformSettings</returns>            
        public Zero4PlatformSettings GETAccount04PlatformFormat (string acceptVersion, string authorization)
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
    
            return (Zero4PlatformSettings) ApiClient.Deserialize(response.Content, typeof(Zero4PlatformSettings), response.Headers);
        }
    
        /// <summary>
        /// Get merchant account  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <returns>Merchant</returns>            
        public Merchant GETAccountFormat (string acceptVersion, string authorization)
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
    
            return (Merchant) ApiClient.Deserialize(response.Content, typeof(Merchant), response.Headers);
        }
    
        /// <summary>
        /// Gets the merchant logo as a raw download or a 404 if none exists  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="logoType">Type of logo </param> 
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
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <returns>PrivateKey</returns>            
        public PrivateKey GETAccountPrivateKeyFormat (string acceptVersion, string authorization)
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
    
            return (PrivateKey) ApiClient.Deserialize(response.Content, typeof(PrivateKey), response.Headers);
        }
    
        /// <summary>
        /// Update merchant account  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="customerAddressName">Name </param> 
        /// <param name="customerAddressAtt">Att </param> 
        /// <param name="customerAddressStreet">Street </param> 
        /// <param name="customerAddressCity">City </param> 
        /// <param name="customerAddressZipCode">Zip code </param> 
        /// <param name="customerAddressRegion">Region </param> 
        /// <param name="customerAddressCountryCode">Three letter country code according to ISO 3166-1 Alpha-3 </param> 
        /// <param name="customerAddressVatNo">VAT registration number </param> 
        /// <param name="billingAddressName">Name </param> 
        /// <param name="billingAddressAtt">Att </param> 
        /// <param name="billingAddressStreet">Street </param> 
        /// <param name="billingAddressCity">City </param> 
        /// <param name="billingAddressZipCode">Zip code </param> 
        /// <param name="billingAddressRegion">Region </param> 
        /// <param name="billingAddressCountryCode">Three letter country code according to ISO 3166-1 Alpha-3 </param> 
        /// <param name="billingAddressVatNo">VAT registration number </param> 
        /// <param name="callbackUrl">Callback url </param> 
        /// <param name="acquirerSettingsBamboraActive">Enable Bambora payments </param> 
        /// <param name="acquirerSettingsBamboraIdentificationCode">Bambora identification number </param> 
        /// <param name="acquirerSettingsBamboraIdentificationCodeInt">Bambora international identification number </param> 
        /// <param name="acquirerSettingsBamboraBusinessCode">Business code (assigned by Bambora) </param> 
        /// <param name="acquirerSettingsBamboraRecurring">Enable recurring payments (requires agreement with Bambora) </param> 
        /// <param name="acquirerSettingsBamboraAmericanexpress">Enable AMEX payments (requires agreement with Bambora) </param> 
        /// <param name="acquirerSettingsBamboraDinersclub">Enable Diners Club payments (requires agreement with Bambora) </param> 
        /// <param name="acquirerSettingsBamboraSecurepay">Enable SecurePay fraud protection. </param> 
        /// <param name="acquirerSettingsBamboraVisaMpiMerchantId">VISA MPI merchant id. Used for 3D secure transactions </param> 
        /// <param name="acquirerSettingsBamboraMastercardMpiMerchantId">Mastercard MPI merchant id. Used for 3D secure transactions </param> 
        /// <param name="acquirerSettingsBamboraVisaBin">VISA acquirer bin used for 3D Secure </param> 
        /// <param name="acquirerSettingsBamboraMastercardBin">Mastercard acquirer bin used for 3D Secure </param> 
        /// <param name="acquirerSettingsClearhausActive">Enable ClearHaus payments </param> 
        /// <param name="acquirerSettingsClearhausApiKey">Clearhaus API key (is required but may be left empty) </param> 
        /// <param name="acquirerSettingsClearhausRecurring">Enable recurring payments (requires agreement with Clearhaus) </param> 
        /// <param name="acquirerSettingsClearhausPayout">Enable payouts (requires agreement with Clearhaus) </param> 
        /// <param name="acquirerSettingsClearhausApplePay">Enable Apple Pay (requires agreement with Clearhaus) </param> 
        /// <param name="acquirerSettingsElavonActive">Enable Elavon payments </param> 
        /// <param name="acquirerSettingsElavonIdentificationCode">Elavon identification number </param> 
        /// <param name="acquirerSettingsElavonIdentificationCodeInt">Elavon international identification number </param> 
        /// <param name="acquirerSettingsElavonBusinessCode">Business code (assigned by Elavon) </param> 
        /// <param name="acquirerSettingsElavonRecurring">Enable recurring payments (requires agreement with Elavon) </param> 
        /// <param name="acquirerSettingsElavonAmericanexpress">Enable AMEX payments (requires agreement with Elavon) </param> 
        /// <param name="acquirerSettingsElavonDinersclub">Enable Diners Club payments (requires agreement with Elavon) </param> 
        /// <param name="acquirerSettingsElavonSecurepay">Enable SecurePay fraud protection. </param> 
        /// <param name="acquirerSettingsElavonVisaMpiMerchantId">VISA MPI merchant id. Used for 3D secure transactions </param> 
        /// <param name="acquirerSettingsElavonMastercardMpiMerchantId">Mastercard MPI merchant id. Used for 3D secure transactions </param> 
        /// <param name="acquirerSettingsElavonVisaBin">VISA acquirer bin used for 3D Secure </param> 
        /// <param name="acquirerSettingsElavonMastercardBin">Mastercard acquirer bin used for 3D Secure </param> 
        /// <param name="acquirerSettingsHandelsbankenActive">Enable Handelsbanken payments </param> 
        /// <param name="acquirerSettingsHandelsbankenIdentificationCode">Handelsbanken identification number </param> 
        /// <param name="acquirerSettingsHandelsbankenIdentificationCodeInt">Handelsbanken international identification number </param> 
        /// <param name="acquirerSettingsHandelsbankenBusinessCode">Business code (assigned by Handelsbanken) </param> 
        /// <param name="acquirerSettingsHandelsbankenRecurring">Enable recurring payments (requires agreement with Handelsbanken) </param> 
        /// <param name="acquirerSettingsHandelsbankenAmericanexpress">Enable AMEX payments (requires agreement with Handelsbanken) </param> 
        /// <param name="acquirerSettingsHandelsbankenDinersclub">Enable Diners Club payments (requires agreement with Handelsbanken) </param> 
        /// <param name="acquirerSettingsHandelsbankenSecurepay">Enable SecurePay fraud protection. </param> 
        /// <param name="acquirerSettingsHandelsbankenVisaMpiMerchantId">VISA MPI merchant id. Used for 3D secure transactions </param> 
        /// <param name="acquirerSettingsHandelsbankenMastercardMpiMerchantId">Mastercard MPI merchant id. Used for 3D secure transactions </param> 
        /// <param name="acquirerSettingsHandelsbankenVisaBin">VISA acquirer bin used for 3D Secure </param> 
        /// <param name="acquirerSettingsHandelsbankenMastercardBin">Mastercard acquirer bin used for 3D Secure </param> 
        /// <param name="acquirerSettingsKlarnaActive">Enable Klarna payments </param> 
        /// <param name="acquirerSettingsKlarnaEid">Klarna merchant ID </param> 
        /// <param name="acquirerSettingsKlarnaSharedSecret">Klarna shared secret </param> 
        /// <param name="acquirerSettingsMobilepayActive">Enable MobilePay payments </param> 
        /// <param name="acquirerSettingsMobilepayDeliveryLimitedTo">Limit MobilePay delivery address selection to theses countries. (ISO 3166-1 alpha-2 without delimiter ‘DKNOSEFI’) (Valid options are DK,NO,SE,FI) </param> 
        /// <param name="acquirerSettingsMobilepaysubscriptionsActive">Enable MobilePay Subscriptions payments </param> 
        /// <param name="acquirerSettingsMobilepaysubscriptionsAuthState">Identifier MobilePay Subscriptions uses to link requests to callbacks </param> 
        /// <param name="acquirerSettingsMobilepaysubscriptionsCodeVerifier">Verifies received code challenge </param> 
        /// <param name="acquirerSettingsMobilepaysubscriptionsLastTokenRefresh">Unix Timestamp of last time the tokens were refreshed </param> 
        /// <param name="acquirerSettingsMobilepaysubscriptionsNonce">Associate client sessions with ID Tokens to mitigate replay attacks </param> 
        /// <param name="acquirerSettingsMobilepaysubscriptionsPendingStatus">0: agreement inactive, 1: flow initialised, 2: tokens received, 3: flow completed </param> 
        /// <param name="acquirerSettingsMobilepaysubscriptionsProvider">The provider / sales-place chosen by the merchant </param> 
        /// <param name="acquirerSettingsMobilepaysubscriptionsRefreshToken">Token to refresh access token for up to 1 year </param> 
        /// <param name="acquirerSettingsNetsActive">Enable Nets/Teller payments </param> 
        /// <param name="acquirerSettingsNetsIdentificationCode">Nets TOF number </param> 
        /// <param name="acquirerSettingsNetsBusinessCode">Business code (assigned by Nets) </param> 
        /// <param name="acquirerSettingsNetsRecurring">Enable recurring payments (requires agreement with Nets) </param> 
        /// <param name="acquirerSettingsNetsFbg1886">Enable Forbrugsforeningen payments (requires agreement with Nets and Forbrugsforeningen) </param> 
        /// <param name="acquirerSettingsNetsSecuredByNets">Enable SecuredByNets fraud protection. </param> 
        /// <param name="acquirerSettingsNetsIdentificationCodeInt">(Depricated; use Teller acquirer) </param> 
        /// <param name="acquirerSettingsNetsAmericanexpress">(Depricated; use Teller acquirer) </param> 
        /// <param name="acquirerSettingsNetsDinersclub">(Depricated; use Teller acquirer) </param> 
        /// <param name="acquirerSettingsNetsSecurepay">(Depricated; use Teller acquirer) </param> 
        /// <param name="acquirerSettingsNetsVisaBin">(Depricated; use Teller acquirer) </param> 
        /// <param name="acquirerSettingsNetsMastercardBin">(Depricated; use Teller acquirer) </param> 
        /// <param name="acquirerSettingsPaypalActive">Enable PayPal payments </param> 
        /// <param name="acquirerSettingsPaypalRecurring">Enable recurring payments </param> 
        /// <param name="acquirerSettingsPaypalCreditCard">Allow credit-card payments. (Only for US/CA/UK merchants) </param> 
        /// <param name="acquirerSettingsPaypalToken">Authentication token </param> 
        /// <param name="acquirerSettingsPaypalTokenSecret">Authentication token secret </param> 
        /// <param name="acquirerSettingsPaypalScope">Authentication scope </param> 
        /// <param name="acquirerSettingsSofortActive">Enable Sofort payments </param> 
        /// <param name="acquirerSettingsSofortCustomerNumber">Sofort customer number </param> 
        /// <param name="acquirerSettingsSofortProjectId">Sofort Gateway project id </param> 
        /// <param name="acquirerSettingsSofortApiKey">Sofort API key </param> 
        /// <param name="acquirerSettingsSofortGateway">Enable Sofort Gateway feature </param> 
        /// <param name="acquirerSettingsSofortIdeal">Enable Sofort iDeal feature </param> 
        /// <param name="acquirerSettingsSofortIdealProjectId">Sofort iDeal project id </param> 
        /// <param name="acquirerSettingsSofortIdealProjectPassword">Sofort iDeal project password </param> 
        /// <param name="acquirerSettingsSofortIdealNotificationPassword">Sofort iDeal notification password </param> 
        /// <param name="acquirerSettingsSwedbankActive">Enable Swedbank payments </param> 
        /// <param name="acquirerSettingsSwedbankIdentificationCode">Swedbank identification number </param> 
        /// <param name="acquirerSettingsSwedbankIdentificationCodeInt">Swedbank international identification number </param> 
        /// <param name="acquirerSettingsSwedbankBusinessCode">Business code (assigned by Swedbank) </param> 
        /// <param name="acquirerSettingsSwedbankRecurring">Enable recurring payments (requires agreement with Swedbank) </param> 
        /// <param name="acquirerSettingsSwedbankAmericanexpress">Enable AMEX payments (requires agreement with Swedbank) </param> 
        /// <param name="acquirerSettingsSwedbankDinersclub">Enable Diners Club payments (requires agreement with Swedbank) </param> 
        /// <param name="acquirerSettingsSwedbankSecurepay">Enable SecurePay fraud protection. </param> 
        /// <param name="acquirerSettingsSwedbankVisaMpiMerchantId">VISA MPI merchant id. Used for 3D secure transactions </param> 
        /// <param name="acquirerSettingsSwedbankMastercardMpiMerchantId">Mastercard MPI merchant id. Used for 3D secure transactions </param> 
        /// <param name="acquirerSettingsSwedbankVisaBin">VISA acquirer bin used for 3D Secure </param> 
        /// <param name="acquirerSettingsSwedbankMastercardBin">Mastercard acquirer bin used for 3D Secure </param> 
        /// <param name="acquirerSettingsTellerActive">Enable Teller payments </param> 
        /// <param name="acquirerSettingsTellerIdentificationCode">Teller TOF number </param> 
        /// <param name="acquirerSettingsTellerIdentificationCodeInt">Teller international identification number </param> 
        /// <param name="acquirerSettingsTellerBusinessCode">Business code (assigned by Teller) </param> 
        /// <param name="acquirerSettingsTellerRecurring">Enable recurring payments (requires agreement with Teller) </param> 
        /// <param name="acquirerSettingsTellerAmericanexpress">Enable AMEX payments (requires agreement with Teller) </param> 
        /// <param name="acquirerSettingsTellerDinersclub">Enable Diners Club payments (requires agreement with Teller) </param> 
        /// <param name="acquirerSettingsTellerSecurepay">Enable SecurePay fraud protection. (disabling requires agreement with Teller) </param> 
        /// <param name="acquirerSettingsTellerVisaMpiMerchantId">VISA MPI merchant id. Used for 3D secure transactions </param> 
        /// <param name="acquirerSettingsTellerMastercardMpiMerchantId">Mastercard MPI merchant id. Used for 3D secure transactions </param> 
        /// <param name="acquirerSettingsTellerVisaBin">Teller VISA acquirer bin used for 3D Secure </param> 
        /// <param name="acquirerSettingsTellerMastercardBin">Teller Mastercard acquirer bin used for 3D Secure </param> 
        /// <param name="acquirerSettingsValitorActive">Enable Valitor payments </param> 
        /// <param name="acquirerSettingsValitorIdentificationCode">Valitor identification number </param> 
        /// <param name="acquirerSettingsValitorIdentificationCodeInt">Valitor international identification number </param> 
        /// <param name="acquirerSettingsValitorBusinessCode">Business code (assigned by Valitor) </param> 
        /// <param name="acquirerSettingsValitorRecurring">Enable recurring payments (requires agreement with Valitor) </param> 
        /// <param name="acquirerSettingsValitorAmericanexpress">Enable AMEX payments (requires agreement with Valitor) </param> 
        /// <param name="acquirerSettingsValitorDinersclub">Enable Diners Club payments (requires agreement with Valitor) </param> 
        /// <param name="acquirerSettingsValitorSecurepay">Enable SecurePay fraud protection. </param> 
        /// <param name="acquirerSettingsValitorVisaMpiMerchantId">VISA MPI merchant id. Used for 3D secure transactions </param> 
        /// <param name="acquirerSettingsValitorMastercardMpiMerchantId">Mastercard MPI merchant id. Used for 3D secure transactions </param> 
        /// <param name="acquirerSettingsValitorVisaBin">VISA acquirer bin used for 3D Secure </param> 
        /// <param name="acquirerSettingsValitorMastercardBin">Mastercard acquirer bin used for 3D Secure </param> 
        /// <param name="acquirerSettingsViabillActive">Enable ViaBill payments </param> 
        /// <param name="acquirerSettingsViabillApiKey">ViaBill API key </param> 
        /// <param name="integrationSettingsEconomicActive">Enable e-conomic integration </param> 
        /// <param name="integrationSettingsEconomicAgreement">e-conomic agreement no. </param> 
        /// <param name="integrationSettingsEconomicAgreementToken">economic agreement grant token </param> 
        /// <param name="pciSaqA">Enable SAQ A </param> 
        /// <param name="pciSaqAEp">Enable SAQ A-EP </param> 
        /// <param name="pciSaqB">Enable SAQ B </param> 
        /// <param name="pciSaqBIp">Enable SAQ B-IP </param> 
        /// <param name="pciSaqC">Enable SAQ C </param> 
        /// <param name="pciSaqCVt">Enable SAQ C-VT </param> 
        /// <param name="pciSaqDMerchant">Enable SAQ D Merchant </param> 
        /// <param name="pciSaqDServiceProvider">Enable SAQ D Service Provider </param> 
        /// <param name="pciSaqP2peHw">Enable SAQ P2PE-HW </param> 
        /// <param name="autofee">Add automatic fee on all payments </param> 
        /// <param name="defaultPaymentMethods">Comma separated list of default payment methods </param> 
        /// <param name="shopUrl">Shop URL (deprecated, use shop_urls instead) </param> 
        /// <param name="shopUrls">Shop URLs </param> 
        /// <param name="contactEmail">Contact email </param> 
        /// <param name="shopName">Shop name </param> 
        /// <param name="shopsystem">Shop system </param> 
        /// <param name="timezone">&lt;table&gt;   &lt;tbody&gt;     &lt;tr&gt;       &lt;td&gt;Timezone UTC offsets in Zulu (+&lt;/td&gt;       &lt;td&gt;-)hh:mm&lt;/td&gt;     &lt;/tr&gt;   &lt;/tbody&gt; &lt;/table&gt; </param> 
        /// <param name="locale">Locale as a two letter language code </param> 
        /// <param name="defaultBrandingId">Id of default branding </param> 
        /// <param name="loggingStopsAt">Timestamp when logging is active </param> 
        /// <param name="allowTestTransactions">Allow test transactions </param> 
        /// <param name="defaultPaymentLanguage">Default payment language (Two letter language code, ISO-639-1) </param> 
        /// <param name="defaultTextOnStatement">Text to be displayed on cardholder’s statement. Max 22 ASCII chars. Currently supported by Clearhaus only. </param> 
        /// <param name="defaultBrandingConfig">Default branding config. Can be overwritten in branding or in request to payment window </param> 
        /// <returns>Merchant</returns>            
        public Merchant PATCHAccountFormat (string acceptVersion, string authorization, string customerAddressName, string customerAddressAtt, string customerAddressStreet, string customerAddressCity, string customerAddressZipCode, string customerAddressRegion, string customerAddressCountryCode, string customerAddressVatNo, string billingAddressName, string billingAddressAtt, string billingAddressStreet, string billingAddressCity, string billingAddressZipCode, string billingAddressRegion, string billingAddressCountryCode, string billingAddressVatNo, string callbackUrl, bool? acquirerSettingsBamboraActive, string acquirerSettingsBamboraIdentificationCode, string acquirerSettingsBamboraIdentificationCodeInt, string acquirerSettingsBamboraBusinessCode, bool? acquirerSettingsBamboraRecurring, bool? acquirerSettingsBamboraAmericanexpress, bool? acquirerSettingsBamboraDinersclub, bool? acquirerSettingsBamboraSecurepay, string acquirerSettingsBamboraVisaMpiMerchantId, string acquirerSettingsBamboraMastercardMpiMerchantId, string acquirerSettingsBamboraVisaBin, string acquirerSettingsBamboraMastercardBin, bool? acquirerSettingsClearhausActive, string acquirerSettingsClearhausApiKey, bool? acquirerSettingsClearhausRecurring, bool? acquirerSettingsClearhausPayout, bool? acquirerSettingsClearhausApplePay, bool? acquirerSettingsElavonActive, string acquirerSettingsElavonIdentificationCode, string acquirerSettingsElavonIdentificationCodeInt, string acquirerSettingsElavonBusinessCode, bool? acquirerSettingsElavonRecurring, bool? acquirerSettingsElavonAmericanexpress, bool? acquirerSettingsElavonDinersclub, bool? acquirerSettingsElavonSecurepay, string acquirerSettingsElavonVisaMpiMerchantId, string acquirerSettingsElavonMastercardMpiMerchantId, string acquirerSettingsElavonVisaBin, string acquirerSettingsElavonMastercardBin, bool? acquirerSettingsHandelsbankenActive, string acquirerSettingsHandelsbankenIdentificationCode, string acquirerSettingsHandelsbankenIdentificationCodeInt, string acquirerSettingsHandelsbankenBusinessCode, bool? acquirerSettingsHandelsbankenRecurring, bool? acquirerSettingsHandelsbankenAmericanexpress, bool? acquirerSettingsHandelsbankenDinersclub, bool? acquirerSettingsHandelsbankenSecurepay, string acquirerSettingsHandelsbankenVisaMpiMerchantId, string acquirerSettingsHandelsbankenMastercardMpiMerchantId, string acquirerSettingsHandelsbankenVisaBin, string acquirerSettingsHandelsbankenMastercardBin, bool? acquirerSettingsKlarnaActive, int? acquirerSettingsKlarnaEid, string acquirerSettingsKlarnaSharedSecret, bool? acquirerSettingsMobilepayActive, string acquirerSettingsMobilepayDeliveryLimitedTo, bool? acquirerSettingsMobilepaysubscriptionsActive, string acquirerSettingsMobilepaysubscriptionsAuthState, string acquirerSettingsMobilepaysubscriptionsCodeVerifier, int? acquirerSettingsMobilepaysubscriptionsLastTokenRefresh, string acquirerSettingsMobilepaysubscriptionsNonce, int? acquirerSettingsMobilepaysubscriptionsPendingStatus, string acquirerSettingsMobilepaysubscriptionsProvider, string acquirerSettingsMobilepaysubscriptionsRefreshToken, bool? acquirerSettingsNetsActive, string acquirerSettingsNetsIdentificationCode, string acquirerSettingsNetsBusinessCode, bool? acquirerSettingsNetsRecurring, bool? acquirerSettingsNetsFbg1886, bool? acquirerSettingsNetsSecuredByNets, string acquirerSettingsNetsIdentificationCodeInt, bool? acquirerSettingsNetsAmericanexpress, bool? acquirerSettingsNetsDinersclub, bool? acquirerSettingsNetsSecurepay, string acquirerSettingsNetsVisaBin, string acquirerSettingsNetsMastercardBin, bool? acquirerSettingsPaypalActive, bool? acquirerSettingsPaypalRecurring, bool? acquirerSettingsPaypalCreditCard, string acquirerSettingsPaypalToken, string acquirerSettingsPaypalTokenSecret, string acquirerSettingsPaypalScope, bool? acquirerSettingsSofortActive, int? acquirerSettingsSofortCustomerNumber, int? acquirerSettingsSofortProjectId, string acquirerSettingsSofortApiKey, bool? acquirerSettingsSofortGateway, bool? acquirerSettingsSofortIdeal, int? acquirerSettingsSofortIdealProjectId, string acquirerSettingsSofortIdealProjectPassword, string acquirerSettingsSofortIdealNotificationPassword, bool? acquirerSettingsSwedbankActive, string acquirerSettingsSwedbankIdentificationCode, string acquirerSettingsSwedbankIdentificationCodeInt, string acquirerSettingsSwedbankBusinessCode, bool? acquirerSettingsSwedbankRecurring, bool? acquirerSettingsSwedbankAmericanexpress, bool? acquirerSettingsSwedbankDinersclub, bool? acquirerSettingsSwedbankSecurepay, string acquirerSettingsSwedbankVisaMpiMerchantId, string acquirerSettingsSwedbankMastercardMpiMerchantId, string acquirerSettingsSwedbankVisaBin, string acquirerSettingsSwedbankMastercardBin, bool? acquirerSettingsTellerActive, string acquirerSettingsTellerIdentificationCode, string acquirerSettingsTellerIdentificationCodeInt, string acquirerSettingsTellerBusinessCode, bool? acquirerSettingsTellerRecurring, bool? acquirerSettingsTellerAmericanexpress, bool? acquirerSettingsTellerDinersclub, bool? acquirerSettingsTellerSecurepay, string acquirerSettingsTellerVisaMpiMerchantId, string acquirerSettingsTellerMastercardMpiMerchantId, string acquirerSettingsTellerVisaBin, string acquirerSettingsTellerMastercardBin, bool? acquirerSettingsValitorActive, string acquirerSettingsValitorIdentificationCode, string acquirerSettingsValitorIdentificationCodeInt, string acquirerSettingsValitorBusinessCode, bool? acquirerSettingsValitorRecurring, bool? acquirerSettingsValitorAmericanexpress, bool? acquirerSettingsValitorDinersclub, bool? acquirerSettingsValitorSecurepay, string acquirerSettingsValitorVisaMpiMerchantId, string acquirerSettingsValitorMastercardMpiMerchantId, string acquirerSettingsValitorVisaBin, string acquirerSettingsValitorMastercardBin, bool? acquirerSettingsViabillActive, string acquirerSettingsViabillApiKey, bool? integrationSettingsEconomicActive, string integrationSettingsEconomicAgreement, string integrationSettingsEconomicAgreementToken, bool? pciSaqA, bool? pciSaqAEp, bool? pciSaqB, bool? pciSaqBIp, bool? pciSaqC, bool? pciSaqCVt, bool? pciSaqDMerchant, bool? pciSaqDServiceProvider, bool? pciSaqP2peHw, bool? autofee, string defaultPaymentMethods, string shopUrl, string shopUrls, string contactEmail, string shopName, string shopsystem, string timezone, string locale, int? defaultBrandingId, string loggingStopsAt, bool? allowTestTransactions, string defaultPaymentLanguage, string defaultTextOnStatement, string defaultBrandingConfig)
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
if (acquirerSettingsPaypalScope != null) formParams.Add("acquirer_settings[paypal][scope]", ApiClient.ParameterToString(acquirerSettingsPaypalScope)); // form parameter
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
if (shopUrls != null) formParams.Add("shop_urls", ApiClient.ParameterToString(shopUrls)); // form parameter
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
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAccountFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAccountFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Merchant) ApiClient.Deserialize(response.Content, typeof(Merchant), response.Headers);
        }
    
        /// <summary>
        /// Regenerates the private key of the merchant  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <returns>PrivateKey</returns>            
        public PrivateKey PATCHAccountPrivateKeyFormat (string acceptVersion, string authorization)
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
    
            return (PrivateKey) ApiClient.Deserialize(response.Content, typeof(PrivateKey), response.Headers);
        }
    
        /// <summary>
        /// Creates or replaces the current merchant logo  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="_file">The logo as a multipart file. If the logo_type is ‘mobilepay’, the logo must be a 250px x 250px PNG file </param> 
        /// <param name="logoType">Type of logo </param> 
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
