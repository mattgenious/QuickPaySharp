using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using QuickPaySharp.Client;
using QuickPaySharp.Model;

namespace QuickPaySharp.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAcquirersApi
    {
        /// <summary>
        /// Get Bambora acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <returns>AcquirerSettingsBambora</returns>
        AcquirerSettingsBambora GETAcquirersBamboraFormat (string acceptVersion, string authorization);
        /// <summary>
        /// Get Clearhaus acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <returns>AcquirerSettingsClearhaus</returns>
        AcquirerSettingsClearhaus GETAcquirersClearhausFormat (string acceptVersion, string authorization);
        /// <summary>
        /// Get Coinify acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <returns>AcquirerSettingsCoinify</returns>
        AcquirerSettingsCoinify GETAcquirersCoinifyFormat (string acceptVersion, string authorization);
        /// <summary>
        /// Get Elavon acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <returns>AcquirerSettingsElavon</returns>
        AcquirerSettingsElavon GETAcquirersElavonFormat (string acceptVersion, string authorization);
        /// <summary>
        /// Fetch acquirers  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <returns>AcquirerSettings</returns>
        AcquirerSettings GETAcquirersFormat (string acceptVersion, string authorization);
        /// <summary>
        /// Get Handelsbanken acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <returns>AcquirerSettingsHandelsbanken</returns>
        AcquirerSettingsHandelsbanken GETAcquirersHandelsbankenFormat (string acceptVersion, string authorization);
        /// <summary>
        /// Get Klarna acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <returns>AcquirerSettingsKlarna</returns>
        AcquirerSettingsKlarna GETAcquirersKlarnaFormat (string acceptVersion, string authorization);
        /// <summary>
        /// Get KlarnaPayments acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <returns>AcquirerSettingsKlarnaPayments</returns>
        AcquirerSettingsKlarnaPayments GETAcquirersKlarnapaymentsFormat (string acceptVersion, string authorization);
        /// <summary>
        /// Get MobilePay acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <returns>AcquirerSettingsMobilePay</returns>
        AcquirerSettingsMobilePay GETAcquirersMobilepayFormat (string acceptVersion, string authorization);
        /// <summary>
        /// Get MobilePayOnline acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <returns>AcquirerSettingsMobilePayOnline</returns>
        AcquirerSettingsMobilePayOnline GETAcquirersMobilepayonlineFormat (string acceptVersion, string authorization);
        /// <summary>
        /// Get MobilePaySubscriptions acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <returns>AcquirerSettingsMobilePaySubscriptions</returns>
        AcquirerSettingsMobilePaySubscriptions GETAcquirersMobilepaysubscriptionsFormat (string acceptVersion, string authorization);
        /// <summary>
        /// Get Nets acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <returns>AcquirerSettingsNets</returns>
        AcquirerSettingsNets GETAcquirersNetsFormat (string acceptVersion, string authorization);
        /// <summary>
        /// Get PayPal acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <returns>AcquirerSettingsPayPal</returns>
        AcquirerSettingsPayPal GETAcquirersPaypalFormat (string acceptVersion, string authorization);
        /// <summary>
        /// Get Paysafecard acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <returns>AcquirerSettingsPaysafecard</returns>
        AcquirerSettingsPaysafecard GETAcquirersPaysafecardFormat (string acceptVersion, string authorization);
        /// <summary>
        /// Get Resurs acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <returns>AcquirerSettingsResurs</returns>
        AcquirerSettingsResurs GETAcquirersResursFormat (string acceptVersion, string authorization);
        /// <summary>
        /// Get Sofort acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <returns>AcquirerSettingsSofort</returns>
        AcquirerSettingsSofort GETAcquirersSofortFormat (string acceptVersion, string authorization);
        /// <summary>
        /// Get Swedbank acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <returns>AcquirerSettingsSwedbank</returns>
        AcquirerSettingsSwedbank GETAcquirersSwedbankFormat (string acceptVersion, string authorization);
        /// <summary>
        /// Get Swish acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <returns>AcquirerSettingsSwish</returns>
        AcquirerSettingsSwish GETAcquirersSwishFormat (string acceptVersion, string authorization);
        /// <summary>
        /// Get Teller acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <returns>AcquirerSettingsTeller</returns>
        AcquirerSettingsTeller GETAcquirersTellerFormat (string acceptVersion, string authorization);
        /// <summary>
        /// Get Trustly acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <returns>AcquirerSettingsTrustly</returns>
        AcquirerSettingsTrustly GETAcquirersTrustlyFormat (string acceptVersion, string authorization);
        /// <summary>
        /// Get Valitor acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <returns>AcquirerSettingsValitor</returns>
        AcquirerSettingsValitor GETAcquirersValitorFormat (string acceptVersion, string authorization);
        /// <summary>
        /// Get ViaBill acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <returns>AcquirerSettingsViaBill</returns>
        AcquirerSettingsViaBill GETAcquirersViabillFormat (string acceptVersion, string authorization);
        /// <summary>
        /// Get Vipps acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <returns>AcquirerSettingsVipps</returns>
        AcquirerSettingsVipps GETAcquirersVippsFormat (string acceptVersion, string authorization);
        /// <summary>
        /// Update Bambora acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="active">Enable Bambora payments </param>
        /// <param name="identificationCode">Bambora identification number </param>
        /// <param name="businessCode">Business code (assigned by Bambora) </param>
        /// <param name="identificationCodeInt">Bambora international identification number </param>
        /// <param name="recurring">Enable recurring payments (requires agreement with Bambora) </param>
        /// <param name="americanexpress">Enable AMEX payments (requires agreement with Bambora) </param>
        /// <param name="dinersclub">Enable Diners Club payments (requires agreement with Bambora) </param>
        /// <param name="securepay">Enable SecurePay fraud protection. </param>
        /// <param name="visaMpiMerchantId">VISA MPI merchant id. Used for 3D secure transactions </param>
        /// <param name="mastercardMpiMerchantId">Mastercard MPI merchant id. Used for 3D secure transactions </param>
        /// <param name="visaBin">VISA acquirer bin used for 3D Secure </param>
        /// <param name="mastercardBin">Mastercard acquirer bin used for 3D Secure </param>
        /// <returns>AcquirerSettingsBambora</returns>
        AcquirerSettingsBambora PATCHAcquirersBamboraFormat (string acceptVersion, string authorization, bool? active, string identificationCode, string businessCode, string identificationCodeInt, bool? recurring, bool? americanexpress, bool? dinersclub, bool? securepay, string visaMpiMerchantId, string mastercardMpiMerchantId, string visaBin, string mastercardBin);
        /// <summary>
        /// Update Clearhaus acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="active">Enable ClearHaus payments </param>
        /// <param name="apiKey">Clearhaus API key (is required but may be left empty) </param>
        /// <param name="recurring">Enable recurring payments (requires agreement with Clearhaus) </param>
        /// <param name="payout">Enable payouts (requires agreement with Clearhaus) </param>
        /// <param name="applePay">Enable Apple Pay (requires agreement with Clearhaus) </param>
        /// <returns>AcquirerSettingsClearhaus</returns>
        AcquirerSettingsClearhaus PATCHAcquirersClearhausFormat (string acceptVersion, string authorization, bool? active, string apiKey, bool? recurring, bool? payout, bool? applePay);
        /// <summary>
        /// Update Coinify acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="active">Enable Coinify Bitcoin payments </param>
        /// <param name="apiKey">Coinify API key </param>
        /// <param name="apiSecret">Coinify API secret </param>
        /// <param name="ipnSecret">Coinify IPN secret (recommended) </param>
        /// <returns>AcquirerSettingsCoinify</returns>
        AcquirerSettingsCoinify PATCHAcquirersCoinifyFormat (string acceptVersion, string authorization, bool? active, string apiKey, string apiSecret, string ipnSecret);
        /// <summary>
        /// Update Elavon acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="active">Enable Elavon payments </param>
        /// <param name="identificationCode">Elavon identification number </param>
        /// <param name="businessCode">Business code (assigned by Elavon) </param>
        /// <param name="identificationCodeInt">Elavon international identification number </param>
        /// <param name="recurring">Enable recurring payments (requires agreement with Elavon) </param>
        /// <param name="americanexpress">Enable AMEX payments (requires agreement with Elavon) </param>
        /// <param name="dinersclub">Enable Diners Club payments (requires agreement with Elavon) </param>
        /// <param name="securepay">Enable SecurePay fraud protection. </param>
        /// <param name="visaMpiMerchantId">VISA MPI merchant id. Used for 3D secure transactions </param>
        /// <param name="mastercardMpiMerchantId">Mastercard MPI merchant id. Used for 3D secure transactions </param>
        /// <param name="visaBin">VISA acquirer bin used for 3D Secure </param>
        /// <param name="mastercardBin">Mastercard acquirer bin used for 3D Secure </param>
        /// <returns>AcquirerSettingsElavon</returns>
        AcquirerSettingsElavon PATCHAcquirersElavonFormat (string acceptVersion, string authorization, bool? active, string identificationCode, string businessCode, string identificationCodeInt, bool? recurring, bool? americanexpress, bool? dinersclub, bool? securepay, string visaMpiMerchantId, string mastercardMpiMerchantId, string visaBin, string mastercardBin);
        /// <summary>
        /// Update Handelsbanken acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="active">Enable Handelsbanken payments </param>
        /// <param name="identificationCode">Handelsbanken identification number </param>
        /// <param name="businessCode">Business code (assigned by Handelsbanken) </param>
        /// <param name="identificationCodeInt">Handelsbanken international identification number </param>
        /// <param name="recurring">Enable recurring payments (requires agreement with Handelsbanken) </param>
        /// <param name="americanexpress">Enable AMEX payments (requires agreement with Handelsbanken) </param>
        /// <param name="dinersclub">Enable Diners Club payments (requires agreement with Handelsbanken) </param>
        /// <param name="securepay">Enable SecurePay fraud protection. </param>
        /// <param name="visaMpiMerchantId">VISA MPI merchant id. Used for 3D secure transactions </param>
        /// <param name="mastercardMpiMerchantId">Mastercard MPI merchant id. Used for 3D secure transactions </param>
        /// <param name="visaBin">VISA acquirer bin used for 3D Secure </param>
        /// <param name="mastercardBin">Mastercard acquirer bin used for 3D Secure </param>
        /// <returns>AcquirerSettingsHandelsbanken</returns>
        AcquirerSettingsHandelsbanken PATCHAcquirersHandelsbankenFormat (string acceptVersion, string authorization, bool? active, string identificationCode, string businessCode, string identificationCodeInt, bool? recurring, bool? americanexpress, bool? dinersclub, bool? securepay, string visaMpiMerchantId, string mastercardMpiMerchantId, string visaBin, string mastercardBin);
        /// <summary>
        /// Update Klarna acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="active">Enable Klarna payments </param>
        /// <param name="eid">Klarna merchant ID </param>
        /// <param name="sharedSecret">Klarna shared secret </param>
        /// <returns>AcquirerSettingsKlarna</returns>
        AcquirerSettingsKlarna PATCHAcquirersKlarnaFormat (string acceptVersion, string authorization, bool? active, int? eid, string sharedSecret);
        /// <summary>
        /// Update KlarnaPayments acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="active">Enable Klarna payments </param>
        /// <param name="uid">Klarna username </param>
        /// <param name="password">Klarna password </param>
        /// <returns>AcquirerSettingsKlarnaPayments</returns>
        AcquirerSettingsKlarnaPayments PATCHAcquirersKlarnapaymentsFormat (string acceptVersion, string authorization, bool? active, string uid, string password);
        /// <summary>
        /// Update MobilePay acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="active">Enable MobilePay payments </param>
        /// <param name="deliveryLimitedTo">Limit MobilePay delivery address selection to theses countries. (ISO 3166-1 alpha-2 without delimiter ‘DKNOSEFI’) (Valid options are DK,NO,SE,FI) </param>
        /// <returns>AcquirerSettingsMobilePay</returns>
        AcquirerSettingsMobilePay PATCHAcquirersMobilepayFormat (string acceptVersion, string authorization, bool? active, string deliveryLimitedTo);
        /// <summary>
        /// Update MobilePayOnline acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="active">Enable MobilePay Online payments </param>
        /// <param name="merchantId">Id for the merchant </param>
        /// <param name="deliveryLimitedTo">Limit MobilePay Online delivery address selection to theses countries. (ISO 3166-1 alpha-2 without delimiter ‘DKNOSEFI’) (Valid options are DK,NO,SE,FI) </param>
        /// <returns>AcquirerSettingsMobilePayOnline</returns>
        AcquirerSettingsMobilePayOnline PATCHAcquirersMobilepayonlineFormat (string acceptVersion, string authorization, bool? active, int? merchantId, string deliveryLimitedTo);
        /// <summary>
        /// Update MobilePaySubscriptions acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="active">Enable MobilePay Subscriptions payments </param>
        /// <param name="authState">Identifier MobilePay Subscriptions uses to link requests to callbacks </param>
        /// <param name="codeVerifier">Verifies received code challenge </param>
        /// <param name="lastTokenRefresh">Unix Timestamp of last time the tokens were refreshed </param>
        /// <param name="nonce">Associate client sessions with ID Tokens to mitigate replay attacks </param>
        /// <param name="pendingStatus">0: agreement inactive, 1: flow initialised, 2: tokens received, 3: flow completed </param>
        /// <param name="provider">The provider / sales-place chosen by the merchant </param>
        /// <param name="refreshToken">Token to refresh access token for up to 1 year </param>
        /// <returns>AcquirerSettingsMobilePaySubscriptions</returns>
        AcquirerSettingsMobilePaySubscriptions PATCHAcquirersMobilepaysubscriptionsFormat (string acceptVersion, string authorization, bool? active, string authState, string codeVerifier, int? lastTokenRefresh, string nonce, int? pendingStatus, string provider, string refreshToken);
        /// <summary>
        /// Update Nets acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="active">Enable Nets/Teller payments </param>
        /// <param name="identificationCode">Nets TOF number </param>
        /// <param name="businessCode">Business code (assigned by Nets) </param>
        /// <param name="recurring">Enable recurring payments (requires agreement with Nets) </param>
        /// <param name="fbg1886">Enable Forbrugsforeningen payments (requires agreement with Nets and Forbrugsforeningen) </param>
        /// <param name="securedByNets">Enable SecuredByNets fraud protection. </param>
        /// <param name="identificationCodeInt">(Depricated; use Teller acquirer) </param>
        /// <param name="americanexpress">(Depricated; use Teller acquirer) </param>
        /// <param name="dinersclub">(Depricated; use Teller acquirer) </param>
        /// <param name="securepay">(Depricated; use Teller acquirer) </param>
        /// <param name="visaBin">(Depricated; use Teller acquirer) </param>
        /// <param name="mastercardBin">(Depricated; use Teller acquirer) </param>
        /// <returns>AcquirerSettingsNets</returns>
        AcquirerSettingsNets PATCHAcquirersNetsFormat (string acceptVersion, string authorization, bool? active, string identificationCode, string businessCode, bool? recurring, bool? fbg1886, bool? securedByNets, string identificationCodeInt, bool? americanexpress, bool? dinersclub, bool? securepay, string visaBin, string mastercardBin);
        /// <summary>
        /// Update PayPal acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="active">Enable PayPal payments </param>
        /// <param name="recurring">Enable recurring payments </param>
        /// <param name="creditCard">Allow credit-card payments. (Only for US/CA/UK merchants) </param>
        /// <param name="token">Authentication token </param>
        /// <param name="tokenSecret">Authentication token secret </param>
        /// <param name="scope">Authentication scope </param>
        /// <returns>AcquirerSettingsPayPal</returns>
        AcquirerSettingsPayPal PATCHAcquirersPaypalFormat (string acceptVersion, string authorization, bool? active, bool? recurring, bool? creditCard, string token, string tokenSecret, string scope);
        /// <summary>
        /// Update Paysafecard acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="active">Enable Paysafecard payments </param>
        /// <param name="username">Paysafecard username </param>
        /// <param name="password">Paysafecard password </param>
        /// <param name="currencies">Paysafecard currencies (Paysafecard requires agreement per currency) </param>
        /// <returns>AcquirerSettingsPaysafecard</returns>
        AcquirerSettingsPaysafecard PATCHAcquirersPaysafecardFormat (string acceptVersion, string authorization, bool? active, string username, string password, string currencies);
        /// <summary>
        /// Update Resurs acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="active">Enable Resurs payments </param>
        /// <param name="customerId">Resurs customer ID </param>
        /// <param name="customerPassword">Resurs password </param>
        /// <returns>AcquirerSettingsResurs</returns>
        AcquirerSettingsResurs PATCHAcquirersResursFormat (string acceptVersion, string authorization, bool? active, string customerId, string customerPassword);
        /// <summary>
        /// Update Sofort acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="active">Enable Sofort payments </param>
        /// <param name="customerNumber">Sofort customer number </param>
        /// <param name="projectId">Sofort Gateway project id </param>
        /// <param name="apiKey">Sofort API key </param>
        /// <param name="gateway">Enable Sofort Gateway feature </param>
        /// <param name="ideal">Enable Sofort iDeal feature </param>
        /// <param name="idealProjectId">Sofort iDeal project id </param>
        /// <param name="idealProjectPassword">Sofort iDeal project password </param>
        /// <param name="idealNotificationPassword">Sofort iDeal notification password </param>
        /// <returns>AcquirerSettingsSofort</returns>
        AcquirerSettingsSofort PATCHAcquirersSofortFormat (string acceptVersion, string authorization, bool? active, int? customerNumber, int? projectId, string apiKey, bool? gateway, bool? ideal, int? idealProjectId, string idealProjectPassword, string idealNotificationPassword);
        /// <summary>
        /// Update Swedbank acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="active">Enable Swedbank payments </param>
        /// <param name="identificationCode">Swedbank identification number </param>
        /// <param name="businessCode">Business code (assigned by Swedbank) </param>
        /// <param name="identificationCodeInt">Swedbank international identification number </param>
        /// <param name="recurring">Enable recurring payments (requires agreement with Swedbank) </param>
        /// <param name="americanexpress">Enable AMEX payments (requires agreement with Swedbank) </param>
        /// <param name="dinersclub">Enable Diners Club payments (requires agreement with Swedbank) </param>
        /// <param name="securepay">Enable SecurePay fraud protection. </param>
        /// <param name="visaMpiMerchantId">VISA MPI merchant id. Used for 3D secure transactions </param>
        /// <param name="mastercardMpiMerchantId">Mastercard MPI merchant id. Used for 3D secure transactions </param>
        /// <param name="visaBin">VISA acquirer bin used for 3D Secure </param>
        /// <param name="mastercardBin">Mastercard acquirer bin used for 3D Secure </param>
        /// <returns>AcquirerSettingsSwedbank</returns>
        AcquirerSettingsSwedbank PATCHAcquirersSwedbankFormat (string acceptVersion, string authorization, bool? active, string identificationCode, string businessCode, string identificationCodeInt, bool? recurring, bool? americanexpress, bool? dinersclub, bool? securepay, string visaMpiMerchantId, string mastercardMpiMerchantId, string visaBin, string mastercardBin);
        /// <summary>
        /// Update Swish acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="active">Enable Swish payments </param>
        /// <param name="merchantId">Swish merchant id </param>
        /// <param name="cryptographyKeyId">Swish certificate and private-key from Cryptography store </param>
        /// <returns>AcquirerSettingsSwish</returns>
        AcquirerSettingsSwish PATCHAcquirersSwishFormat (string acceptVersion, string authorization, bool? active, string merchantId, int? cryptographyKeyId);
        /// <summary>
        /// Update Teller acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="active">Enable Teller payments </param>
        /// <param name="identificationCode">Teller TOF number </param>
        /// <param name="businessCode">Business code (assigned by Teller) </param>
        /// <param name="identificationCodeInt">Teller international identification number </param>
        /// <param name="recurring">Enable recurring payments (requires agreement with Teller) </param>
        /// <param name="americanexpress">Enable AMEX payments (requires agreement with Teller) </param>
        /// <param name="dinersclub">Enable Diners Club payments (requires agreement with Teller) </param>
        /// <param name="securepay">Enable SecurePay fraud protection. (disabling requires agreement with Teller) </param>
        /// <param name="visaMpiMerchantId">VISA MPI merchant id. Used for 3D secure transactions </param>
        /// <param name="mastercardMpiMerchantId">Mastercard MPI merchant id. Used for 3D secure transactions </param>
        /// <param name="visaBin">Teller VISA acquirer bin used for 3D Secure </param>
        /// <param name="mastercardBin">Teller Mastercard acquirer bin used for 3D Secure </param>
        /// <returns>AcquirerSettingsTeller</returns>
        AcquirerSettingsTeller PATCHAcquirersTellerFormat (string acceptVersion, string authorization, bool? active, string identificationCode, string businessCode, string identificationCodeInt, bool? recurring, bool? americanexpress, bool? dinersclub, bool? securepay, string visaMpiMerchantId, string mastercardMpiMerchantId, string visaBin, string mastercardBin);
        /// <summary>
        /// Update Trustly acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="active">Enable Trustly payments </param>
        /// <param name="ideal">Enable iDeal payments </param>
        /// <param name="username">Trustly API username </param>
        /// <param name="password">Trustly API password </param>
        /// <returns>AcquirerSettingsTrustly</returns>
        AcquirerSettingsTrustly PATCHAcquirersTrustlyFormat (string acceptVersion, string authorization, bool? active, bool? ideal, string username, string password);
        /// <summary>
        /// Update Valitor acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="active">Enable Valitor payments </param>
        /// <param name="identificationCode">Valitor identification number </param>
        /// <param name="businessCode">Business code (assigned by Valitor) </param>
        /// <param name="identificationCodeInt">Valitor international identification number </param>
        /// <param name="recurring">Enable recurring payments (requires agreement with Valitor) </param>
        /// <param name="americanexpress">Enable AMEX payments (requires agreement with Valitor) </param>
        /// <param name="dinersclub">Enable Diners Club payments (requires agreement with Valitor) </param>
        /// <param name="securepay">Enable SecurePay fraud protection. </param>
        /// <param name="visaMpiMerchantId">VISA MPI merchant id. Used for 3D secure transactions </param>
        /// <param name="mastercardMpiMerchantId">Mastercard MPI merchant id. Used for 3D secure transactions </param>
        /// <param name="visaBin">VISA acquirer bin used for 3D Secure </param>
        /// <param name="mastercardBin">Mastercard acquirer bin used for 3D Secure </param>
        /// <returns>AcquirerSettingsValitor</returns>
        AcquirerSettingsValitor PATCHAcquirersValitorFormat (string acceptVersion, string authorization, bool? active, string identificationCode, string businessCode, string identificationCodeInt, bool? recurring, bool? americanexpress, bool? dinersclub, bool? securepay, string visaMpiMerchantId, string mastercardMpiMerchantId, string visaBin, string mastercardBin);
        /// <summary>
        /// Update ViaBill acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="active">Enable ViaBill payments </param>
        /// <param name="apiKey">ViaBill API key </param>
        /// <returns>AcquirerSettingsViaBill</returns>
        AcquirerSettingsViaBill PATCHAcquirersViabillFormat (string acceptVersion, string authorization, bool? active, string apiKey);
        /// <summary>
        /// Update Vipps acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="active">Enable Vipps payments </param>
        /// <param name="clientId">Vipps OAuth Client ID </param>
        /// <param name="clientSecret">Vipps OAuth Client Secret </param>
        /// <param name="serialNumber">Vipps agreement serial </param>
        /// <param name="accessTokenSubscriptionKey">Vipps Access-Token Subscription Key </param>
        /// <param name="ecommerceSubscriptionKey">Vipps eCommerce Subscription Key </param>
        /// <param name="orgno">Vipps companys organization number </param>
        /// <returns>AcquirerSettingsVipps</returns>
        AcquirerSettingsVipps PATCHAcquirersVippsFormat (string acceptVersion, string authorization, bool? active, string clientId, string clientSecret, string serialNumber, string accessTokenSubscriptionKey, string ecommerceSubscriptionKey, string orgno);
        /// <summary>
        /// Test payments via acquirer  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="acquirer">Acquirer name </param>
        /// <returns>AcquirerTest</returns>
        AcquirerTest POSTAcquirersAcquirerTestFormat (string acceptVersion, string authorization, string acquirer);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AcquirersApi : IAcquirersApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AcquirersApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AcquirersApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AcquirersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AcquirersApi(String basePath)
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
        /// Get Bambora acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <returns>AcquirerSettingsBambora</returns>            
        public AcquirerSettingsBambora GETAcquirersBamboraFormat (string acceptVersion, string authorization)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETAcquirersBamboraFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETAcquirersBamboraFormat");
            
    
            var path = "/acquirers/bambora";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersBamboraFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersBamboraFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsBambora) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsBambora), response.Headers);
        }
    
        /// <summary>
        /// Get Clearhaus acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <returns>AcquirerSettingsClearhaus</returns>            
        public AcquirerSettingsClearhaus GETAcquirersClearhausFormat (string acceptVersion, string authorization)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETAcquirersClearhausFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETAcquirersClearhausFormat");
            
    
            var path = "/acquirers/clearhaus";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersClearhausFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersClearhausFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsClearhaus) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsClearhaus), response.Headers);
        }
    
        /// <summary>
        /// Get Coinify acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <returns>AcquirerSettingsCoinify</returns>            
        public AcquirerSettingsCoinify GETAcquirersCoinifyFormat (string acceptVersion, string authorization)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETAcquirersCoinifyFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETAcquirersCoinifyFormat");
            
    
            var path = "/acquirers/coinify";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersCoinifyFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersCoinifyFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsCoinify) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsCoinify), response.Headers);
        }
    
        /// <summary>
        /// Get Elavon acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <returns>AcquirerSettingsElavon</returns>            
        public AcquirerSettingsElavon GETAcquirersElavonFormat (string acceptVersion, string authorization)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETAcquirersElavonFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETAcquirersElavonFormat");
            
    
            var path = "/acquirers/elavon";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersElavonFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersElavonFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsElavon) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsElavon), response.Headers);
        }
    
        /// <summary>
        /// Fetch acquirers  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <returns>AcquirerSettings</returns>            
        public AcquirerSettings GETAcquirersFormat (string acceptVersion, string authorization)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETAcquirersFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETAcquirersFormat");
            
    
            var path = "/acquirers";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettings) ApiClient.Deserialize(response.Content, typeof(AcquirerSettings), response.Headers);
        }
    
        /// <summary>
        /// Get Handelsbanken acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <returns>AcquirerSettingsHandelsbanken</returns>            
        public AcquirerSettingsHandelsbanken GETAcquirersHandelsbankenFormat (string acceptVersion, string authorization)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETAcquirersHandelsbankenFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETAcquirersHandelsbankenFormat");
            
    
            var path = "/acquirers/handelsbanken";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersHandelsbankenFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersHandelsbankenFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsHandelsbanken) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsHandelsbanken), response.Headers);
        }
    
        /// <summary>
        /// Get Klarna acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <returns>AcquirerSettingsKlarna</returns>            
        public AcquirerSettingsKlarna GETAcquirersKlarnaFormat (string acceptVersion, string authorization)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETAcquirersKlarnaFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETAcquirersKlarnaFormat");
            
    
            var path = "/acquirers/klarna";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersKlarnaFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersKlarnaFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsKlarna) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsKlarna), response.Headers);
        }
    
        /// <summary>
        /// Get KlarnaPayments acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <returns>AcquirerSettingsKlarnaPayments</returns>            
        public AcquirerSettingsKlarnaPayments GETAcquirersKlarnapaymentsFormat (string acceptVersion, string authorization)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETAcquirersKlarnapaymentsFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETAcquirersKlarnapaymentsFormat");
            
    
            var path = "/acquirers/klarnapayments";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersKlarnapaymentsFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersKlarnapaymentsFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsKlarnaPayments) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsKlarnaPayments), response.Headers);
        }
    
        /// <summary>
        /// Get MobilePay acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <returns>AcquirerSettingsMobilePay</returns>            
        public AcquirerSettingsMobilePay GETAcquirersMobilepayFormat (string acceptVersion, string authorization)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETAcquirersMobilepayFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETAcquirersMobilepayFormat");
            
    
            var path = "/acquirers/mobilepay";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersMobilepayFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersMobilepayFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsMobilePay) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsMobilePay), response.Headers);
        }
    
        /// <summary>
        /// Get MobilePayOnline acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <returns>AcquirerSettingsMobilePayOnline</returns>            
        public AcquirerSettingsMobilePayOnline GETAcquirersMobilepayonlineFormat (string acceptVersion, string authorization)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETAcquirersMobilepayonlineFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETAcquirersMobilepayonlineFormat");
            
    
            var path = "/acquirers/mobilepayonline";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersMobilepayonlineFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersMobilepayonlineFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsMobilePayOnline) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsMobilePayOnline), response.Headers);
        }
    
        /// <summary>
        /// Get MobilePaySubscriptions acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <returns>AcquirerSettingsMobilePaySubscriptions</returns>            
        public AcquirerSettingsMobilePaySubscriptions GETAcquirersMobilepaysubscriptionsFormat (string acceptVersion, string authorization)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETAcquirersMobilepaysubscriptionsFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETAcquirersMobilepaysubscriptionsFormat");
            
    
            var path = "/acquirers/mobilepaysubscriptions";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersMobilepaysubscriptionsFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersMobilepaysubscriptionsFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsMobilePaySubscriptions) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsMobilePaySubscriptions), response.Headers);
        }
    
        /// <summary>
        /// Get Nets acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <returns>AcquirerSettingsNets</returns>            
        public AcquirerSettingsNets GETAcquirersNetsFormat (string acceptVersion, string authorization)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETAcquirersNetsFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETAcquirersNetsFormat");
            
    
            var path = "/acquirers/nets";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersNetsFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersNetsFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsNets) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsNets), response.Headers);
        }
    
        /// <summary>
        /// Get PayPal acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <returns>AcquirerSettingsPayPal</returns>            
        public AcquirerSettingsPayPal GETAcquirersPaypalFormat (string acceptVersion, string authorization)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETAcquirersPaypalFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETAcquirersPaypalFormat");
            
    
            var path = "/acquirers/paypal";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersPaypalFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersPaypalFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsPayPal) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsPayPal), response.Headers);
        }
    
        /// <summary>
        /// Get Paysafecard acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <returns>AcquirerSettingsPaysafecard</returns>            
        public AcquirerSettingsPaysafecard GETAcquirersPaysafecardFormat (string acceptVersion, string authorization)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETAcquirersPaysafecardFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETAcquirersPaysafecardFormat");
            
    
            var path = "/acquirers/paysafecard";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersPaysafecardFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersPaysafecardFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsPaysafecard) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsPaysafecard), response.Headers);
        }
    
        /// <summary>
        /// Get Resurs acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <returns>AcquirerSettingsResurs</returns>            
        public AcquirerSettingsResurs GETAcquirersResursFormat (string acceptVersion, string authorization)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETAcquirersResursFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETAcquirersResursFormat");
            
    
            var path = "/acquirers/resurs";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersResursFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersResursFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsResurs) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsResurs), response.Headers);
        }
    
        /// <summary>
        /// Get Sofort acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <returns>AcquirerSettingsSofort</returns>            
        public AcquirerSettingsSofort GETAcquirersSofortFormat (string acceptVersion, string authorization)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETAcquirersSofortFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETAcquirersSofortFormat");
            
    
            var path = "/acquirers/sofort";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersSofortFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersSofortFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsSofort) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsSofort), response.Headers);
        }
    
        /// <summary>
        /// Get Swedbank acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <returns>AcquirerSettingsSwedbank</returns>            
        public AcquirerSettingsSwedbank GETAcquirersSwedbankFormat (string acceptVersion, string authorization)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETAcquirersSwedbankFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETAcquirersSwedbankFormat");
            
    
            var path = "/acquirers/swedbank";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersSwedbankFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersSwedbankFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsSwedbank) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsSwedbank), response.Headers);
        }
    
        /// <summary>
        /// Get Swish acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <returns>AcquirerSettingsSwish</returns>            
        public AcquirerSettingsSwish GETAcquirersSwishFormat (string acceptVersion, string authorization)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETAcquirersSwishFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETAcquirersSwishFormat");
            
    
            var path = "/acquirers/swish";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersSwishFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersSwishFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsSwish) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsSwish), response.Headers);
        }
    
        /// <summary>
        /// Get Teller acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <returns>AcquirerSettingsTeller</returns>            
        public AcquirerSettingsTeller GETAcquirersTellerFormat (string acceptVersion, string authorization)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETAcquirersTellerFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETAcquirersTellerFormat");
            
    
            var path = "/acquirers/teller";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersTellerFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersTellerFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsTeller) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsTeller), response.Headers);
        }
    
        /// <summary>
        /// Get Trustly acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <returns>AcquirerSettingsTrustly</returns>            
        public AcquirerSettingsTrustly GETAcquirersTrustlyFormat (string acceptVersion, string authorization)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETAcquirersTrustlyFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETAcquirersTrustlyFormat");
            
    
            var path = "/acquirers/trustly";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersTrustlyFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersTrustlyFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsTrustly) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsTrustly), response.Headers);
        }
    
        /// <summary>
        /// Get Valitor acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <returns>AcquirerSettingsValitor</returns>            
        public AcquirerSettingsValitor GETAcquirersValitorFormat (string acceptVersion, string authorization)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETAcquirersValitorFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETAcquirersValitorFormat");
            
    
            var path = "/acquirers/valitor";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersValitorFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersValitorFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsValitor) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsValitor), response.Headers);
        }
    
        /// <summary>
        /// Get ViaBill acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <returns>AcquirerSettingsViaBill</returns>            
        public AcquirerSettingsViaBill GETAcquirersViabillFormat (string acceptVersion, string authorization)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETAcquirersViabillFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETAcquirersViabillFormat");
            
    
            var path = "/acquirers/viabill";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersViabillFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersViabillFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsViaBill) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsViaBill), response.Headers);
        }
    
        /// <summary>
        /// Get Vipps acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <returns>AcquirerSettingsVipps</returns>            
        public AcquirerSettingsVipps GETAcquirersVippsFormat (string acceptVersion, string authorization)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETAcquirersVippsFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETAcquirersVippsFormat");
            
    
            var path = "/acquirers/vipps";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersVippsFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAcquirersVippsFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsVipps) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsVipps), response.Headers);
        }
    
        /// <summary>
        /// Update Bambora acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="active">Enable Bambora payments </param> 
        /// <param name="identificationCode">Bambora identification number </param> 
        /// <param name="businessCode">Business code (assigned by Bambora) </param> 
        /// <param name="identificationCodeInt">Bambora international identification number </param> 
        /// <param name="recurring">Enable recurring payments (requires agreement with Bambora) </param> 
        /// <param name="americanexpress">Enable AMEX payments (requires agreement with Bambora) </param> 
        /// <param name="dinersclub">Enable Diners Club payments (requires agreement with Bambora) </param> 
        /// <param name="securepay">Enable SecurePay fraud protection. </param> 
        /// <param name="visaMpiMerchantId">VISA MPI merchant id. Used for 3D secure transactions </param> 
        /// <param name="mastercardMpiMerchantId">Mastercard MPI merchant id. Used for 3D secure transactions </param> 
        /// <param name="visaBin">VISA acquirer bin used for 3D Secure </param> 
        /// <param name="mastercardBin">Mastercard acquirer bin used for 3D Secure </param> 
        /// <returns>AcquirerSettingsBambora</returns>            
        public AcquirerSettingsBambora PATCHAcquirersBamboraFormat (string acceptVersion, string authorization, bool? active, string identificationCode, string businessCode, string identificationCodeInt, bool? recurring, bool? americanexpress, bool? dinersclub, bool? securepay, string visaMpiMerchantId, string mastercardMpiMerchantId, string visaBin, string mastercardBin)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PATCHAcquirersBamboraFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PATCHAcquirersBamboraFormat");
            
            // verify the required parameter 'active' is set
            if (active == null) throw new ApiException(400, "Missing required parameter 'active' when calling PATCHAcquirersBamboraFormat");
            
            // verify the required parameter 'identificationCode' is set
            if (identificationCode == null) throw new ApiException(400, "Missing required parameter 'identificationCode' when calling PATCHAcquirersBamboraFormat");
            
            // verify the required parameter 'businessCode' is set
            if (businessCode == null) throw new ApiException(400, "Missing required parameter 'businessCode' when calling PATCHAcquirersBamboraFormat");
            
    
            var path = "/acquirers/bambora";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
            if (active != null) formParams.Add("active", ApiClient.ParameterToString(active)); // form parameter
if (identificationCode != null) formParams.Add("identification_code", ApiClient.ParameterToString(identificationCode)); // form parameter
if (identificationCodeInt != null) formParams.Add("identification_code_int", ApiClient.ParameterToString(identificationCodeInt)); // form parameter
if (businessCode != null) formParams.Add("business_code", ApiClient.ParameterToString(businessCode)); // form parameter
if (recurring != null) formParams.Add("recurring", ApiClient.ParameterToString(recurring)); // form parameter
if (americanexpress != null) formParams.Add("americanexpress", ApiClient.ParameterToString(americanexpress)); // form parameter
if (dinersclub != null) formParams.Add("dinersclub", ApiClient.ParameterToString(dinersclub)); // form parameter
if (securepay != null) formParams.Add("securepay", ApiClient.ParameterToString(securepay)); // form parameter
if (visaMpiMerchantId != null) formParams.Add("visa_mpi_merchant_id", ApiClient.ParameterToString(visaMpiMerchantId)); // form parameter
if (mastercardMpiMerchantId != null) formParams.Add("mastercard_mpi_merchant_id", ApiClient.ParameterToString(mastercardMpiMerchantId)); // form parameter
if (visaBin != null) formParams.Add("visa_bin", ApiClient.ParameterToString(visaBin)); // form parameter
if (mastercardBin != null) formParams.Add("mastercard_bin", ApiClient.ParameterToString(mastercardBin)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Patch, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersBamboraFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersBamboraFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsBambora) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsBambora), response.Headers);
        }
    
        /// <summary>
        /// Update Clearhaus acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="active">Enable ClearHaus payments </param> 
        /// <param name="apiKey">Clearhaus API key (is required but may be left empty) </param> 
        /// <param name="recurring">Enable recurring payments (requires agreement with Clearhaus) </param> 
        /// <param name="payout">Enable payouts (requires agreement with Clearhaus) </param> 
        /// <param name="applePay">Enable Apple Pay (requires agreement with Clearhaus) </param> 
        /// <returns>AcquirerSettingsClearhaus</returns>            
        public AcquirerSettingsClearhaus PATCHAcquirersClearhausFormat (string acceptVersion, string authorization, bool? active, string apiKey, bool? recurring, bool? payout, bool? applePay)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PATCHAcquirersClearhausFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PATCHAcquirersClearhausFormat");
            
            // verify the required parameter 'active' is set
            if (active == null) throw new ApiException(400, "Missing required parameter 'active' when calling PATCHAcquirersClearhausFormat");
            
            // verify the required parameter 'apiKey' is set
            if (apiKey == null) throw new ApiException(400, "Missing required parameter 'apiKey' when calling PATCHAcquirersClearhausFormat");
            
    
            var path = "/acquirers/clearhaus";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
            if (active != null) formParams.Add("active", ApiClient.ParameterToString(active)); // form parameter
if (apiKey != null) formParams.Add("api_key", ApiClient.ParameterToString(apiKey)); // form parameter
if (recurring != null) formParams.Add("recurring", ApiClient.ParameterToString(recurring)); // form parameter
if (payout != null) formParams.Add("payout", ApiClient.ParameterToString(payout)); // form parameter
if (applePay != null) formParams.Add("apple_pay", ApiClient.ParameterToString(applePay)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Patch, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersClearhausFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersClearhausFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsClearhaus) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsClearhaus), response.Headers);
        }
    
        /// <summary>
        /// Update Coinify acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="active">Enable Coinify Bitcoin payments </param> 
        /// <param name="apiKey">Coinify API key </param> 
        /// <param name="apiSecret">Coinify API secret </param> 
        /// <param name="ipnSecret">Coinify IPN secret (recommended) </param> 
        /// <returns>AcquirerSettingsCoinify</returns>            
        public AcquirerSettingsCoinify PATCHAcquirersCoinifyFormat (string acceptVersion, string authorization, bool? active, string apiKey, string apiSecret, string ipnSecret)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PATCHAcquirersCoinifyFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PATCHAcquirersCoinifyFormat");
            
            // verify the required parameter 'active' is set
            if (active == null) throw new ApiException(400, "Missing required parameter 'active' when calling PATCHAcquirersCoinifyFormat");
            
            // verify the required parameter 'apiKey' is set
            if (apiKey == null) throw new ApiException(400, "Missing required parameter 'apiKey' when calling PATCHAcquirersCoinifyFormat");
            
            // verify the required parameter 'apiSecret' is set
            if (apiSecret == null) throw new ApiException(400, "Missing required parameter 'apiSecret' when calling PATCHAcquirersCoinifyFormat");
            
    
            var path = "/acquirers/coinify";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
            if (active != null) formParams.Add("active", ApiClient.ParameterToString(active)); // form parameter
if (apiKey != null) formParams.Add("api_key", ApiClient.ParameterToString(apiKey)); // form parameter
if (apiSecret != null) formParams.Add("api_secret", ApiClient.ParameterToString(apiSecret)); // form parameter
if (ipnSecret != null) formParams.Add("ipn_secret", ApiClient.ParameterToString(ipnSecret)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Patch, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersCoinifyFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersCoinifyFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsCoinify) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsCoinify), response.Headers);
        }
    
        /// <summary>
        /// Update Elavon acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="active">Enable Elavon payments </param> 
        /// <param name="identificationCode">Elavon identification number </param> 
        /// <param name="businessCode">Business code (assigned by Elavon) </param> 
        /// <param name="identificationCodeInt">Elavon international identification number </param> 
        /// <param name="recurring">Enable recurring payments (requires agreement with Elavon) </param> 
        /// <param name="americanexpress">Enable AMEX payments (requires agreement with Elavon) </param> 
        /// <param name="dinersclub">Enable Diners Club payments (requires agreement with Elavon) </param> 
        /// <param name="securepay">Enable SecurePay fraud protection. </param> 
        /// <param name="visaMpiMerchantId">VISA MPI merchant id. Used for 3D secure transactions </param> 
        /// <param name="mastercardMpiMerchantId">Mastercard MPI merchant id. Used for 3D secure transactions </param> 
        /// <param name="visaBin">VISA acquirer bin used for 3D Secure </param> 
        /// <param name="mastercardBin">Mastercard acquirer bin used for 3D Secure </param> 
        /// <returns>AcquirerSettingsElavon</returns>            
        public AcquirerSettingsElavon PATCHAcquirersElavonFormat (string acceptVersion, string authorization, bool? active, string identificationCode, string businessCode, string identificationCodeInt, bool? recurring, bool? americanexpress, bool? dinersclub, bool? securepay, string visaMpiMerchantId, string mastercardMpiMerchantId, string visaBin, string mastercardBin)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PATCHAcquirersElavonFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PATCHAcquirersElavonFormat");
            
            // verify the required parameter 'active' is set
            if (active == null) throw new ApiException(400, "Missing required parameter 'active' when calling PATCHAcquirersElavonFormat");
            
            // verify the required parameter 'identificationCode' is set
            if (identificationCode == null) throw new ApiException(400, "Missing required parameter 'identificationCode' when calling PATCHAcquirersElavonFormat");
            
            // verify the required parameter 'businessCode' is set
            if (businessCode == null) throw new ApiException(400, "Missing required parameter 'businessCode' when calling PATCHAcquirersElavonFormat");
            
    
            var path = "/acquirers/elavon";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
            if (active != null) formParams.Add("active", ApiClient.ParameterToString(active)); // form parameter
if (identificationCode != null) formParams.Add("identification_code", ApiClient.ParameterToString(identificationCode)); // form parameter
if (identificationCodeInt != null) formParams.Add("identification_code_int", ApiClient.ParameterToString(identificationCodeInt)); // form parameter
if (businessCode != null) formParams.Add("business_code", ApiClient.ParameterToString(businessCode)); // form parameter
if (recurring != null) formParams.Add("recurring", ApiClient.ParameterToString(recurring)); // form parameter
if (americanexpress != null) formParams.Add("americanexpress", ApiClient.ParameterToString(americanexpress)); // form parameter
if (dinersclub != null) formParams.Add("dinersclub", ApiClient.ParameterToString(dinersclub)); // form parameter
if (securepay != null) formParams.Add("securepay", ApiClient.ParameterToString(securepay)); // form parameter
if (visaMpiMerchantId != null) formParams.Add("visa_mpi_merchant_id", ApiClient.ParameterToString(visaMpiMerchantId)); // form parameter
if (mastercardMpiMerchantId != null) formParams.Add("mastercard_mpi_merchant_id", ApiClient.ParameterToString(mastercardMpiMerchantId)); // form parameter
if (visaBin != null) formParams.Add("visa_bin", ApiClient.ParameterToString(visaBin)); // form parameter
if (mastercardBin != null) formParams.Add("mastercard_bin", ApiClient.ParameterToString(mastercardBin)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Patch, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersElavonFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersElavonFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsElavon) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsElavon), response.Headers);
        }
    
        /// <summary>
        /// Update Handelsbanken acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="active">Enable Handelsbanken payments </param> 
        /// <param name="identificationCode">Handelsbanken identification number </param> 
        /// <param name="businessCode">Business code (assigned by Handelsbanken) </param> 
        /// <param name="identificationCodeInt">Handelsbanken international identification number </param> 
        /// <param name="recurring">Enable recurring payments (requires agreement with Handelsbanken) </param> 
        /// <param name="americanexpress">Enable AMEX payments (requires agreement with Handelsbanken) </param> 
        /// <param name="dinersclub">Enable Diners Club payments (requires agreement with Handelsbanken) </param> 
        /// <param name="securepay">Enable SecurePay fraud protection. </param> 
        /// <param name="visaMpiMerchantId">VISA MPI merchant id. Used for 3D secure transactions </param> 
        /// <param name="mastercardMpiMerchantId">Mastercard MPI merchant id. Used for 3D secure transactions </param> 
        /// <param name="visaBin">VISA acquirer bin used for 3D Secure </param> 
        /// <param name="mastercardBin">Mastercard acquirer bin used for 3D Secure </param> 
        /// <returns>AcquirerSettingsHandelsbanken</returns>            
        public AcquirerSettingsHandelsbanken PATCHAcquirersHandelsbankenFormat (string acceptVersion, string authorization, bool? active, string identificationCode, string businessCode, string identificationCodeInt, bool? recurring, bool? americanexpress, bool? dinersclub, bool? securepay, string visaMpiMerchantId, string mastercardMpiMerchantId, string visaBin, string mastercardBin)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PATCHAcquirersHandelsbankenFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PATCHAcquirersHandelsbankenFormat");
            
            // verify the required parameter 'active' is set
            if (active == null) throw new ApiException(400, "Missing required parameter 'active' when calling PATCHAcquirersHandelsbankenFormat");
            
            // verify the required parameter 'identificationCode' is set
            if (identificationCode == null) throw new ApiException(400, "Missing required parameter 'identificationCode' when calling PATCHAcquirersHandelsbankenFormat");
            
            // verify the required parameter 'businessCode' is set
            if (businessCode == null) throw new ApiException(400, "Missing required parameter 'businessCode' when calling PATCHAcquirersHandelsbankenFormat");
            
    
            var path = "/acquirers/handelsbanken";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
            if (active != null) formParams.Add("active", ApiClient.ParameterToString(active)); // form parameter
if (identificationCode != null) formParams.Add("identification_code", ApiClient.ParameterToString(identificationCode)); // form parameter
if (identificationCodeInt != null) formParams.Add("identification_code_int", ApiClient.ParameterToString(identificationCodeInt)); // form parameter
if (businessCode != null) formParams.Add("business_code", ApiClient.ParameterToString(businessCode)); // form parameter
if (recurring != null) formParams.Add("recurring", ApiClient.ParameterToString(recurring)); // form parameter
if (americanexpress != null) formParams.Add("americanexpress", ApiClient.ParameterToString(americanexpress)); // form parameter
if (dinersclub != null) formParams.Add("dinersclub", ApiClient.ParameterToString(dinersclub)); // form parameter
if (securepay != null) formParams.Add("securepay", ApiClient.ParameterToString(securepay)); // form parameter
if (visaMpiMerchantId != null) formParams.Add("visa_mpi_merchant_id", ApiClient.ParameterToString(visaMpiMerchantId)); // form parameter
if (mastercardMpiMerchantId != null) formParams.Add("mastercard_mpi_merchant_id", ApiClient.ParameterToString(mastercardMpiMerchantId)); // form parameter
if (visaBin != null) formParams.Add("visa_bin", ApiClient.ParameterToString(visaBin)); // form parameter
if (mastercardBin != null) formParams.Add("mastercard_bin", ApiClient.ParameterToString(mastercardBin)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Patch, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersHandelsbankenFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersHandelsbankenFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsHandelsbanken) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsHandelsbanken), response.Headers);
        }
    
        /// <summary>
        /// Update Klarna acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="active">Enable Klarna payments </param> 
        /// <param name="eid">Klarna merchant ID </param> 
        /// <param name="sharedSecret">Klarna shared secret </param> 
        /// <returns>AcquirerSettingsKlarna</returns>            
        public AcquirerSettingsKlarna PATCHAcquirersKlarnaFormat (string acceptVersion, string authorization, bool? active, int? eid, string sharedSecret)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PATCHAcquirersKlarnaFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PATCHAcquirersKlarnaFormat");
            
            // verify the required parameter 'active' is set
            if (active == null) throw new ApiException(400, "Missing required parameter 'active' when calling PATCHAcquirersKlarnaFormat");
            
            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling PATCHAcquirersKlarnaFormat");
            
            // verify the required parameter 'sharedSecret' is set
            if (sharedSecret == null) throw new ApiException(400, "Missing required parameter 'sharedSecret' when calling PATCHAcquirersKlarnaFormat");
            
    
            var path = "/acquirers/klarna";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
            if (active != null) formParams.Add("active", ApiClient.ParameterToString(active)); // form parameter
if (eid != null) formParams.Add("eid", ApiClient.ParameterToString(eid)); // form parameter
if (sharedSecret != null) formParams.Add("shared_secret", ApiClient.ParameterToString(sharedSecret)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Patch, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersKlarnaFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersKlarnaFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsKlarna) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsKlarna), response.Headers);
        }
    
        /// <summary>
        /// Update KlarnaPayments acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="active">Enable Klarna payments </param> 
        /// <param name="uid">Klarna username </param> 
        /// <param name="password">Klarna password </param> 
        /// <returns>AcquirerSettingsKlarnaPayments</returns>            
        public AcquirerSettingsKlarnaPayments PATCHAcquirersKlarnapaymentsFormat (string acceptVersion, string authorization, bool? active, string uid, string password)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PATCHAcquirersKlarnapaymentsFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PATCHAcquirersKlarnapaymentsFormat");
            
            // verify the required parameter 'active' is set
            if (active == null) throw new ApiException(400, "Missing required parameter 'active' when calling PATCHAcquirersKlarnapaymentsFormat");
            
            // verify the required parameter 'uid' is set
            if (uid == null) throw new ApiException(400, "Missing required parameter 'uid' when calling PATCHAcquirersKlarnapaymentsFormat");
            
            // verify the required parameter 'password' is set
            if (password == null) throw new ApiException(400, "Missing required parameter 'password' when calling PATCHAcquirersKlarnapaymentsFormat");
            
    
            var path = "/acquirers/klarnapayments";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
            if (active != null) formParams.Add("active", ApiClient.ParameterToString(active)); // form parameter
if (uid != null) formParams.Add("uid", ApiClient.ParameterToString(uid)); // form parameter
if (password != null) formParams.Add("password", ApiClient.ParameterToString(password)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Patch, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersKlarnapaymentsFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersKlarnapaymentsFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsKlarnaPayments) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsKlarnaPayments), response.Headers);
        }
    
        /// <summary>
        /// Update MobilePay acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="active">Enable MobilePay payments </param> 
        /// <param name="deliveryLimitedTo">Limit MobilePay delivery address selection to theses countries. (ISO 3166-1 alpha-2 without delimiter ‘DKNOSEFI’) (Valid options are DK,NO,SE,FI) </param> 
        /// <returns>AcquirerSettingsMobilePay</returns>            
        public AcquirerSettingsMobilePay PATCHAcquirersMobilepayFormat (string acceptVersion, string authorization, bool? active, string deliveryLimitedTo)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PATCHAcquirersMobilepayFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PATCHAcquirersMobilepayFormat");
            
            // verify the required parameter 'active' is set
            if (active == null) throw new ApiException(400, "Missing required parameter 'active' when calling PATCHAcquirersMobilepayFormat");
            
    
            var path = "/acquirers/mobilepay";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
            if (active != null) formParams.Add("active", ApiClient.ParameterToString(active)); // form parameter
if (deliveryLimitedTo != null) formParams.Add("delivery_limited_to", ApiClient.ParameterToString(deliveryLimitedTo)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Patch, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersMobilepayFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersMobilepayFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsMobilePay) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsMobilePay), response.Headers);
        }
    
        /// <summary>
        /// Update MobilePayOnline acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="active">Enable MobilePay Online payments </param> 
        /// <param name="merchantId">Id for the merchant </param> 
        /// <param name="deliveryLimitedTo">Limit MobilePay Online delivery address selection to theses countries. (ISO 3166-1 alpha-2 without delimiter ‘DKNOSEFI’) (Valid options are DK,NO,SE,FI) </param> 
        /// <returns>AcquirerSettingsMobilePayOnline</returns>            
        public AcquirerSettingsMobilePayOnline PATCHAcquirersMobilepayonlineFormat (string acceptVersion, string authorization, bool? active, int? merchantId, string deliveryLimitedTo)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PATCHAcquirersMobilepayonlineFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PATCHAcquirersMobilepayonlineFormat");
            
            // verify the required parameter 'active' is set
            if (active == null) throw new ApiException(400, "Missing required parameter 'active' when calling PATCHAcquirersMobilepayonlineFormat");
            
    
            var path = "/acquirers/mobilepayonline";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
            if (active != null) formParams.Add("active", ApiClient.ParameterToString(active)); // form parameter
if (merchantId != null) formParams.Add("merchant_id", ApiClient.ParameterToString(merchantId)); // form parameter
if (deliveryLimitedTo != null) formParams.Add("delivery_limited_to", ApiClient.ParameterToString(deliveryLimitedTo)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Patch, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersMobilepayonlineFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersMobilepayonlineFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsMobilePayOnline) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsMobilePayOnline), response.Headers);
        }
    
        /// <summary>
        /// Update MobilePaySubscriptions acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="active">Enable MobilePay Subscriptions payments </param> 
        /// <param name="authState">Identifier MobilePay Subscriptions uses to link requests to callbacks </param> 
        /// <param name="codeVerifier">Verifies received code challenge </param> 
        /// <param name="lastTokenRefresh">Unix Timestamp of last time the tokens were refreshed </param> 
        /// <param name="nonce">Associate client sessions with ID Tokens to mitigate replay attacks </param> 
        /// <param name="pendingStatus">0: agreement inactive, 1: flow initialised, 2: tokens received, 3: flow completed </param> 
        /// <param name="provider">The provider / sales-place chosen by the merchant </param> 
        /// <param name="refreshToken">Token to refresh access token for up to 1 year </param> 
        /// <returns>AcquirerSettingsMobilePaySubscriptions</returns>            
        public AcquirerSettingsMobilePaySubscriptions PATCHAcquirersMobilepaysubscriptionsFormat (string acceptVersion, string authorization, bool? active, string authState, string codeVerifier, int? lastTokenRefresh, string nonce, int? pendingStatus, string provider, string refreshToken)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PATCHAcquirersMobilepaysubscriptionsFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PATCHAcquirersMobilepaysubscriptionsFormat");
            
            // verify the required parameter 'active' is set
            if (active == null) throw new ApiException(400, "Missing required parameter 'active' when calling PATCHAcquirersMobilepaysubscriptionsFormat");
            
    
            var path = "/acquirers/mobilepaysubscriptions";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
            if (active != null) formParams.Add("active", ApiClient.ParameterToString(active)); // form parameter
if (authState != null) formParams.Add("auth_state", ApiClient.ParameterToString(authState)); // form parameter
if (codeVerifier != null) formParams.Add("code_verifier", ApiClient.ParameterToString(codeVerifier)); // form parameter
if (lastTokenRefresh != null) formParams.Add("last_token_refresh", ApiClient.ParameterToString(lastTokenRefresh)); // form parameter
if (nonce != null) formParams.Add("nonce", ApiClient.ParameterToString(nonce)); // form parameter
if (pendingStatus != null) formParams.Add("pending_status", ApiClient.ParameterToString(pendingStatus)); // form parameter
if (provider != null) formParams.Add("provider", ApiClient.ParameterToString(provider)); // form parameter
if (refreshToken != null) formParams.Add("refresh_token", ApiClient.ParameterToString(refreshToken)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Patch, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersMobilepaysubscriptionsFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersMobilepaysubscriptionsFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsMobilePaySubscriptions) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsMobilePaySubscriptions), response.Headers);
        }
    
        /// <summary>
        /// Update Nets acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="active">Enable Nets/Teller payments </param> 
        /// <param name="identificationCode">Nets TOF number </param> 
        /// <param name="businessCode">Business code (assigned by Nets) </param> 
        /// <param name="recurring">Enable recurring payments (requires agreement with Nets) </param> 
        /// <param name="fbg1886">Enable Forbrugsforeningen payments (requires agreement with Nets and Forbrugsforeningen) </param> 
        /// <param name="securedByNets">Enable SecuredByNets fraud protection. </param> 
        /// <param name="identificationCodeInt">(Depricated; use Teller acquirer) </param> 
        /// <param name="americanexpress">(Depricated; use Teller acquirer) </param> 
        /// <param name="dinersclub">(Depricated; use Teller acquirer) </param> 
        /// <param name="securepay">(Depricated; use Teller acquirer) </param> 
        /// <param name="visaBin">(Depricated; use Teller acquirer) </param> 
        /// <param name="mastercardBin">(Depricated; use Teller acquirer) </param> 
        /// <returns>AcquirerSettingsNets</returns>            
        public AcquirerSettingsNets PATCHAcquirersNetsFormat (string acceptVersion, string authorization, bool? active, string identificationCode, string businessCode, bool? recurring, bool? fbg1886, bool? securedByNets, string identificationCodeInt, bool? americanexpress, bool? dinersclub, bool? securepay, string visaBin, string mastercardBin)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PATCHAcquirersNetsFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PATCHAcquirersNetsFormat");
            
            // verify the required parameter 'active' is set
            if (active == null) throw new ApiException(400, "Missing required parameter 'active' when calling PATCHAcquirersNetsFormat");
            
            // verify the required parameter 'identificationCode' is set
            if (identificationCode == null) throw new ApiException(400, "Missing required parameter 'identificationCode' when calling PATCHAcquirersNetsFormat");
            
            // verify the required parameter 'businessCode' is set
            if (businessCode == null) throw new ApiException(400, "Missing required parameter 'businessCode' when calling PATCHAcquirersNetsFormat");
            
    
            var path = "/acquirers/nets";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
            if (active != null) formParams.Add("active", ApiClient.ParameterToString(active)); // form parameter
if (identificationCode != null) formParams.Add("identification_code", ApiClient.ParameterToString(identificationCode)); // form parameter
if (businessCode != null) formParams.Add("business_code", ApiClient.ParameterToString(businessCode)); // form parameter
if (recurring != null) formParams.Add("recurring", ApiClient.ParameterToString(recurring)); // form parameter
if (fbg1886 != null) formParams.Add("fbg1886", ApiClient.ParameterToString(fbg1886)); // form parameter
if (securedByNets != null) formParams.Add("secured_by_nets", ApiClient.ParameterToString(securedByNets)); // form parameter
if (identificationCodeInt != null) formParams.Add("identification_code_int", ApiClient.ParameterToString(identificationCodeInt)); // form parameter
if (americanexpress != null) formParams.Add("americanexpress", ApiClient.ParameterToString(americanexpress)); // form parameter
if (dinersclub != null) formParams.Add("dinersclub", ApiClient.ParameterToString(dinersclub)); // form parameter
if (securepay != null) formParams.Add("securepay", ApiClient.ParameterToString(securepay)); // form parameter
if (visaBin != null) formParams.Add("visa_bin", ApiClient.ParameterToString(visaBin)); // form parameter
if (mastercardBin != null) formParams.Add("mastercard_bin", ApiClient.ParameterToString(mastercardBin)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Patch, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersNetsFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersNetsFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsNets) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsNets), response.Headers);
        }
    
        /// <summary>
        /// Update PayPal acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="active">Enable PayPal payments </param> 
        /// <param name="recurring">Enable recurring payments </param> 
        /// <param name="creditCard">Allow credit-card payments. (Only for US/CA/UK merchants) </param> 
        /// <param name="token">Authentication token </param> 
        /// <param name="tokenSecret">Authentication token secret </param> 
        /// <param name="scope">Authentication scope </param> 
        /// <returns>AcquirerSettingsPayPal</returns>            
        public AcquirerSettingsPayPal PATCHAcquirersPaypalFormat (string acceptVersion, string authorization, bool? active, bool? recurring, bool? creditCard, string token, string tokenSecret, string scope)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PATCHAcquirersPaypalFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PATCHAcquirersPaypalFormat");
            
            // verify the required parameter 'active' is set
            if (active == null) throw new ApiException(400, "Missing required parameter 'active' when calling PATCHAcquirersPaypalFormat");
            
    
            var path = "/acquirers/paypal";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
            if (active != null) formParams.Add("active", ApiClient.ParameterToString(active)); // form parameter
if (recurring != null) formParams.Add("recurring", ApiClient.ParameterToString(recurring)); // form parameter
if (creditCard != null) formParams.Add("credit_card", ApiClient.ParameterToString(creditCard)); // form parameter
if (token != null) formParams.Add("token", ApiClient.ParameterToString(token)); // form parameter
if (tokenSecret != null) formParams.Add("token_secret", ApiClient.ParameterToString(tokenSecret)); // form parameter
if (scope != null) formParams.Add("scope", ApiClient.ParameterToString(scope)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Patch, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersPaypalFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersPaypalFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsPayPal) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsPayPal), response.Headers);
        }
    
        /// <summary>
        /// Update Paysafecard acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="active">Enable Paysafecard payments </param> 
        /// <param name="username">Paysafecard username </param> 
        /// <param name="password">Paysafecard password </param> 
        /// <param name="currencies">Paysafecard currencies (Paysafecard requires agreement per currency) </param> 
        /// <returns>AcquirerSettingsPaysafecard</returns>            
        public AcquirerSettingsPaysafecard PATCHAcquirersPaysafecardFormat (string acceptVersion, string authorization, bool? active, string username, string password, string currencies)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PATCHAcquirersPaysafecardFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PATCHAcquirersPaysafecardFormat");
            
            // verify the required parameter 'active' is set
            if (active == null) throw new ApiException(400, "Missing required parameter 'active' when calling PATCHAcquirersPaysafecardFormat");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling PATCHAcquirersPaysafecardFormat");
            
            // verify the required parameter 'password' is set
            if (password == null) throw new ApiException(400, "Missing required parameter 'password' when calling PATCHAcquirersPaysafecardFormat");
            
            // verify the required parameter 'currencies' is set
            if (currencies == null) throw new ApiException(400, "Missing required parameter 'currencies' when calling PATCHAcquirersPaysafecardFormat");
            
    
            var path = "/acquirers/paysafecard";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
            if (active != null) formParams.Add("active", ApiClient.ParameterToString(active)); // form parameter
if (username != null) formParams.Add("username", ApiClient.ParameterToString(username)); // form parameter
if (password != null) formParams.Add("password", ApiClient.ParameterToString(password)); // form parameter
if (currencies != null) formParams.Add("currencies", ApiClient.ParameterToString(currencies)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Patch, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersPaysafecardFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersPaysafecardFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsPaysafecard) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsPaysafecard), response.Headers);
        }
    
        /// <summary>
        /// Update Resurs acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="active">Enable Resurs payments </param> 
        /// <param name="customerId">Resurs customer ID </param> 
        /// <param name="customerPassword">Resurs password </param> 
        /// <returns>AcquirerSettingsResurs</returns>            
        public AcquirerSettingsResurs PATCHAcquirersResursFormat (string acceptVersion, string authorization, bool? active, string customerId, string customerPassword)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PATCHAcquirersResursFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PATCHAcquirersResursFormat");
            
            // verify the required parameter 'active' is set
            if (active == null) throw new ApiException(400, "Missing required parameter 'active' when calling PATCHAcquirersResursFormat");
            
            // verify the required parameter 'customerId' is set
            if (customerId == null) throw new ApiException(400, "Missing required parameter 'customerId' when calling PATCHAcquirersResursFormat");
            
            // verify the required parameter 'customerPassword' is set
            if (customerPassword == null) throw new ApiException(400, "Missing required parameter 'customerPassword' when calling PATCHAcquirersResursFormat");
            
    
            var path = "/acquirers/resurs";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
            if (active != null) formParams.Add("active", ApiClient.ParameterToString(active)); // form parameter
if (customerId != null) formParams.Add("customer_id", ApiClient.ParameterToString(customerId)); // form parameter
if (customerPassword != null) formParams.Add("customer_password", ApiClient.ParameterToString(customerPassword)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Patch, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersResursFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersResursFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsResurs) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsResurs), response.Headers);
        }
    
        /// <summary>
        /// Update Sofort acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="active">Enable Sofort payments </param> 
        /// <param name="customerNumber">Sofort customer number </param> 
        /// <param name="projectId">Sofort Gateway project id </param> 
        /// <param name="apiKey">Sofort API key </param> 
        /// <param name="gateway">Enable Sofort Gateway feature </param> 
        /// <param name="ideal">Enable Sofort iDeal feature </param> 
        /// <param name="idealProjectId">Sofort iDeal project id </param> 
        /// <param name="idealProjectPassword">Sofort iDeal project password </param> 
        /// <param name="idealNotificationPassword">Sofort iDeal notification password </param> 
        /// <returns>AcquirerSettingsSofort</returns>            
        public AcquirerSettingsSofort PATCHAcquirersSofortFormat (string acceptVersion, string authorization, bool? active, int? customerNumber, int? projectId, string apiKey, bool? gateway, bool? ideal, int? idealProjectId, string idealProjectPassword, string idealNotificationPassword)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PATCHAcquirersSofortFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PATCHAcquirersSofortFormat");
            
            // verify the required parameter 'active' is set
            if (active == null) throw new ApiException(400, "Missing required parameter 'active' when calling PATCHAcquirersSofortFormat");
            
            // verify the required parameter 'customerNumber' is set
            if (customerNumber == null) throw new ApiException(400, "Missing required parameter 'customerNumber' when calling PATCHAcquirersSofortFormat");
            
            // verify the required parameter 'projectId' is set
            if (projectId == null) throw new ApiException(400, "Missing required parameter 'projectId' when calling PATCHAcquirersSofortFormat");
            
            // verify the required parameter 'apiKey' is set
            if (apiKey == null) throw new ApiException(400, "Missing required parameter 'apiKey' when calling PATCHAcquirersSofortFormat");
            
    
            var path = "/acquirers/sofort";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
            if (active != null) formParams.Add("active", ApiClient.ParameterToString(active)); // form parameter
if (customerNumber != null) formParams.Add("customer_number", ApiClient.ParameterToString(customerNumber)); // form parameter
if (projectId != null) formParams.Add("project_id", ApiClient.ParameterToString(projectId)); // form parameter
if (apiKey != null) formParams.Add("api_key", ApiClient.ParameterToString(apiKey)); // form parameter
if (gateway != null) formParams.Add("gateway", ApiClient.ParameterToString(gateway)); // form parameter
if (ideal != null) formParams.Add("ideal", ApiClient.ParameterToString(ideal)); // form parameter
if (idealProjectId != null) formParams.Add("ideal_project_id", ApiClient.ParameterToString(idealProjectId)); // form parameter
if (idealProjectPassword != null) formParams.Add("ideal_project_password", ApiClient.ParameterToString(idealProjectPassword)); // form parameter
if (idealNotificationPassword != null) formParams.Add("ideal_notification_password", ApiClient.ParameterToString(idealNotificationPassword)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Patch, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersSofortFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersSofortFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsSofort) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsSofort), response.Headers);
        }
    
        /// <summary>
        /// Update Swedbank acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="active">Enable Swedbank payments </param> 
        /// <param name="identificationCode">Swedbank identification number </param> 
        /// <param name="businessCode">Business code (assigned by Swedbank) </param> 
        /// <param name="identificationCodeInt">Swedbank international identification number </param> 
        /// <param name="recurring">Enable recurring payments (requires agreement with Swedbank) </param> 
        /// <param name="americanexpress">Enable AMEX payments (requires agreement with Swedbank) </param> 
        /// <param name="dinersclub">Enable Diners Club payments (requires agreement with Swedbank) </param> 
        /// <param name="securepay">Enable SecurePay fraud protection. </param> 
        /// <param name="visaMpiMerchantId">VISA MPI merchant id. Used for 3D secure transactions </param> 
        /// <param name="mastercardMpiMerchantId">Mastercard MPI merchant id. Used for 3D secure transactions </param> 
        /// <param name="visaBin">VISA acquirer bin used for 3D Secure </param> 
        /// <param name="mastercardBin">Mastercard acquirer bin used for 3D Secure </param> 
        /// <returns>AcquirerSettingsSwedbank</returns>            
        public AcquirerSettingsSwedbank PATCHAcquirersSwedbankFormat (string acceptVersion, string authorization, bool? active, string identificationCode, string businessCode, string identificationCodeInt, bool? recurring, bool? americanexpress, bool? dinersclub, bool? securepay, string visaMpiMerchantId, string mastercardMpiMerchantId, string visaBin, string mastercardBin)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PATCHAcquirersSwedbankFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PATCHAcquirersSwedbankFormat");
            
            // verify the required parameter 'active' is set
            if (active == null) throw new ApiException(400, "Missing required parameter 'active' when calling PATCHAcquirersSwedbankFormat");
            
            // verify the required parameter 'identificationCode' is set
            if (identificationCode == null) throw new ApiException(400, "Missing required parameter 'identificationCode' when calling PATCHAcquirersSwedbankFormat");
            
            // verify the required parameter 'businessCode' is set
            if (businessCode == null) throw new ApiException(400, "Missing required parameter 'businessCode' when calling PATCHAcquirersSwedbankFormat");
            
    
            var path = "/acquirers/swedbank";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
            if (active != null) formParams.Add("active", ApiClient.ParameterToString(active)); // form parameter
if (identificationCode != null) formParams.Add("identification_code", ApiClient.ParameterToString(identificationCode)); // form parameter
if (identificationCodeInt != null) formParams.Add("identification_code_int", ApiClient.ParameterToString(identificationCodeInt)); // form parameter
if (businessCode != null) formParams.Add("business_code", ApiClient.ParameterToString(businessCode)); // form parameter
if (recurring != null) formParams.Add("recurring", ApiClient.ParameterToString(recurring)); // form parameter
if (americanexpress != null) formParams.Add("americanexpress", ApiClient.ParameterToString(americanexpress)); // form parameter
if (dinersclub != null) formParams.Add("dinersclub", ApiClient.ParameterToString(dinersclub)); // form parameter
if (securepay != null) formParams.Add("securepay", ApiClient.ParameterToString(securepay)); // form parameter
if (visaMpiMerchantId != null) formParams.Add("visa_mpi_merchant_id", ApiClient.ParameterToString(visaMpiMerchantId)); // form parameter
if (mastercardMpiMerchantId != null) formParams.Add("mastercard_mpi_merchant_id", ApiClient.ParameterToString(mastercardMpiMerchantId)); // form parameter
if (visaBin != null) formParams.Add("visa_bin", ApiClient.ParameterToString(visaBin)); // form parameter
if (mastercardBin != null) formParams.Add("mastercard_bin", ApiClient.ParameterToString(mastercardBin)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Patch, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersSwedbankFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersSwedbankFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsSwedbank) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsSwedbank), response.Headers);
        }
    
        /// <summary>
        /// Update Swish acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="active">Enable Swish payments </param> 
        /// <param name="merchantId">Swish merchant id </param> 
        /// <param name="cryptographyKeyId">Swish certificate and private-key from Cryptography store </param> 
        /// <returns>AcquirerSettingsSwish</returns>            
        public AcquirerSettingsSwish PATCHAcquirersSwishFormat (string acceptVersion, string authorization, bool? active, string merchantId, int? cryptographyKeyId)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PATCHAcquirersSwishFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PATCHAcquirersSwishFormat");
            
            // verify the required parameter 'active' is set
            if (active == null) throw new ApiException(400, "Missing required parameter 'active' when calling PATCHAcquirersSwishFormat");
            
            // verify the required parameter 'merchantId' is set
            if (merchantId == null) throw new ApiException(400, "Missing required parameter 'merchantId' when calling PATCHAcquirersSwishFormat");
            
    
            var path = "/acquirers/swish";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
            if (active != null) formParams.Add("active", ApiClient.ParameterToString(active)); // form parameter
if (merchantId != null) formParams.Add("merchant_id", ApiClient.ParameterToString(merchantId)); // form parameter
if (cryptographyKeyId != null) formParams.Add("cryptography_key_id", ApiClient.ParameterToString(cryptographyKeyId)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Patch, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersSwishFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersSwishFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsSwish) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsSwish), response.Headers);
        }
    
        /// <summary>
        /// Update Teller acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="active">Enable Teller payments </param> 
        /// <param name="identificationCode">Teller TOF number </param> 
        /// <param name="businessCode">Business code (assigned by Teller) </param> 
        /// <param name="identificationCodeInt">Teller international identification number </param> 
        /// <param name="recurring">Enable recurring payments (requires agreement with Teller) </param> 
        /// <param name="americanexpress">Enable AMEX payments (requires agreement with Teller) </param> 
        /// <param name="dinersclub">Enable Diners Club payments (requires agreement with Teller) </param> 
        /// <param name="securepay">Enable SecurePay fraud protection. (disabling requires agreement with Teller) </param> 
        /// <param name="visaMpiMerchantId">VISA MPI merchant id. Used for 3D secure transactions </param> 
        /// <param name="mastercardMpiMerchantId">Mastercard MPI merchant id. Used for 3D secure transactions </param> 
        /// <param name="visaBin">Teller VISA acquirer bin used for 3D Secure </param> 
        /// <param name="mastercardBin">Teller Mastercard acquirer bin used for 3D Secure </param> 
        /// <returns>AcquirerSettingsTeller</returns>            
        public AcquirerSettingsTeller PATCHAcquirersTellerFormat (string acceptVersion, string authorization, bool? active, string identificationCode, string businessCode, string identificationCodeInt, bool? recurring, bool? americanexpress, bool? dinersclub, bool? securepay, string visaMpiMerchantId, string mastercardMpiMerchantId, string visaBin, string mastercardBin)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PATCHAcquirersTellerFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PATCHAcquirersTellerFormat");
            
            // verify the required parameter 'active' is set
            if (active == null) throw new ApiException(400, "Missing required parameter 'active' when calling PATCHAcquirersTellerFormat");
            
            // verify the required parameter 'identificationCode' is set
            if (identificationCode == null) throw new ApiException(400, "Missing required parameter 'identificationCode' when calling PATCHAcquirersTellerFormat");
            
            // verify the required parameter 'businessCode' is set
            if (businessCode == null) throw new ApiException(400, "Missing required parameter 'businessCode' when calling PATCHAcquirersTellerFormat");
            
    
            var path = "/acquirers/teller";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
            if (active != null) formParams.Add("active", ApiClient.ParameterToString(active)); // form parameter
if (identificationCode != null) formParams.Add("identification_code", ApiClient.ParameterToString(identificationCode)); // form parameter
if (identificationCodeInt != null) formParams.Add("identification_code_int", ApiClient.ParameterToString(identificationCodeInt)); // form parameter
if (businessCode != null) formParams.Add("business_code", ApiClient.ParameterToString(businessCode)); // form parameter
if (recurring != null) formParams.Add("recurring", ApiClient.ParameterToString(recurring)); // form parameter
if (americanexpress != null) formParams.Add("americanexpress", ApiClient.ParameterToString(americanexpress)); // form parameter
if (dinersclub != null) formParams.Add("dinersclub", ApiClient.ParameterToString(dinersclub)); // form parameter
if (securepay != null) formParams.Add("securepay", ApiClient.ParameterToString(securepay)); // form parameter
if (visaMpiMerchantId != null) formParams.Add("visa_mpi_merchant_id", ApiClient.ParameterToString(visaMpiMerchantId)); // form parameter
if (mastercardMpiMerchantId != null) formParams.Add("mastercard_mpi_merchant_id", ApiClient.ParameterToString(mastercardMpiMerchantId)); // form parameter
if (visaBin != null) formParams.Add("visa_bin", ApiClient.ParameterToString(visaBin)); // form parameter
if (mastercardBin != null) formParams.Add("mastercard_bin", ApiClient.ParameterToString(mastercardBin)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Patch, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersTellerFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersTellerFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsTeller) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsTeller), response.Headers);
        }
    
        /// <summary>
        /// Update Trustly acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="active">Enable Trustly payments </param> 
        /// <param name="ideal">Enable iDeal payments </param> 
        /// <param name="username">Trustly API username </param> 
        /// <param name="password">Trustly API password </param> 
        /// <returns>AcquirerSettingsTrustly</returns>            
        public AcquirerSettingsTrustly PATCHAcquirersTrustlyFormat (string acceptVersion, string authorization, bool? active, bool? ideal, string username, string password)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PATCHAcquirersTrustlyFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PATCHAcquirersTrustlyFormat");
            
            // verify the required parameter 'active' is set
            if (active == null) throw new ApiException(400, "Missing required parameter 'active' when calling PATCHAcquirersTrustlyFormat");
            
            // verify the required parameter 'ideal' is set
            if (ideal == null) throw new ApiException(400, "Missing required parameter 'ideal' when calling PATCHAcquirersTrustlyFormat");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling PATCHAcquirersTrustlyFormat");
            
            // verify the required parameter 'password' is set
            if (password == null) throw new ApiException(400, "Missing required parameter 'password' when calling PATCHAcquirersTrustlyFormat");
            
    
            var path = "/acquirers/trustly";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
            if (active != null) formParams.Add("active", ApiClient.ParameterToString(active)); // form parameter
if (ideal != null) formParams.Add("ideal", ApiClient.ParameterToString(ideal)); // form parameter
if (username != null) formParams.Add("username", ApiClient.ParameterToString(username)); // form parameter
if (password != null) formParams.Add("password", ApiClient.ParameterToString(password)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Patch, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersTrustlyFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersTrustlyFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsTrustly) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsTrustly), response.Headers);
        }
    
        /// <summary>
        /// Update Valitor acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="active">Enable Valitor payments </param> 
        /// <param name="identificationCode">Valitor identification number </param> 
        /// <param name="businessCode">Business code (assigned by Valitor) </param> 
        /// <param name="identificationCodeInt">Valitor international identification number </param> 
        /// <param name="recurring">Enable recurring payments (requires agreement with Valitor) </param> 
        /// <param name="americanexpress">Enable AMEX payments (requires agreement with Valitor) </param> 
        /// <param name="dinersclub">Enable Diners Club payments (requires agreement with Valitor) </param> 
        /// <param name="securepay">Enable SecurePay fraud protection. </param> 
        /// <param name="visaMpiMerchantId">VISA MPI merchant id. Used for 3D secure transactions </param> 
        /// <param name="mastercardMpiMerchantId">Mastercard MPI merchant id. Used for 3D secure transactions </param> 
        /// <param name="visaBin">VISA acquirer bin used for 3D Secure </param> 
        /// <param name="mastercardBin">Mastercard acquirer bin used for 3D Secure </param> 
        /// <returns>AcquirerSettingsValitor</returns>            
        public AcquirerSettingsValitor PATCHAcquirersValitorFormat (string acceptVersion, string authorization, bool? active, string identificationCode, string businessCode, string identificationCodeInt, bool? recurring, bool? americanexpress, bool? dinersclub, bool? securepay, string visaMpiMerchantId, string mastercardMpiMerchantId, string visaBin, string mastercardBin)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PATCHAcquirersValitorFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PATCHAcquirersValitorFormat");
            
            // verify the required parameter 'active' is set
            if (active == null) throw new ApiException(400, "Missing required parameter 'active' when calling PATCHAcquirersValitorFormat");
            
            // verify the required parameter 'identificationCode' is set
            if (identificationCode == null) throw new ApiException(400, "Missing required parameter 'identificationCode' when calling PATCHAcquirersValitorFormat");
            
            // verify the required parameter 'businessCode' is set
            if (businessCode == null) throw new ApiException(400, "Missing required parameter 'businessCode' when calling PATCHAcquirersValitorFormat");
            
    
            var path = "/acquirers/valitor";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
            if (active != null) formParams.Add("active", ApiClient.ParameterToString(active)); // form parameter
if (identificationCode != null) formParams.Add("identification_code", ApiClient.ParameterToString(identificationCode)); // form parameter
if (identificationCodeInt != null) formParams.Add("identification_code_int", ApiClient.ParameterToString(identificationCodeInt)); // form parameter
if (businessCode != null) formParams.Add("business_code", ApiClient.ParameterToString(businessCode)); // form parameter
if (recurring != null) formParams.Add("recurring", ApiClient.ParameterToString(recurring)); // form parameter
if (americanexpress != null) formParams.Add("americanexpress", ApiClient.ParameterToString(americanexpress)); // form parameter
if (dinersclub != null) formParams.Add("dinersclub", ApiClient.ParameterToString(dinersclub)); // form parameter
if (securepay != null) formParams.Add("securepay", ApiClient.ParameterToString(securepay)); // form parameter
if (visaMpiMerchantId != null) formParams.Add("visa_mpi_merchant_id", ApiClient.ParameterToString(visaMpiMerchantId)); // form parameter
if (mastercardMpiMerchantId != null) formParams.Add("mastercard_mpi_merchant_id", ApiClient.ParameterToString(mastercardMpiMerchantId)); // form parameter
if (visaBin != null) formParams.Add("visa_bin", ApiClient.ParameterToString(visaBin)); // form parameter
if (mastercardBin != null) formParams.Add("mastercard_bin", ApiClient.ParameterToString(mastercardBin)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Patch, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersValitorFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersValitorFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsValitor) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsValitor), response.Headers);
        }
    
        /// <summary>
        /// Update ViaBill acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="active">Enable ViaBill payments </param> 
        /// <param name="apiKey">ViaBill API key </param> 
        /// <returns>AcquirerSettingsViaBill</returns>            
        public AcquirerSettingsViaBill PATCHAcquirersViabillFormat (string acceptVersion, string authorization, bool? active, string apiKey)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PATCHAcquirersViabillFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PATCHAcquirersViabillFormat");
            
            // verify the required parameter 'active' is set
            if (active == null) throw new ApiException(400, "Missing required parameter 'active' when calling PATCHAcquirersViabillFormat");
            
            // verify the required parameter 'apiKey' is set
            if (apiKey == null) throw new ApiException(400, "Missing required parameter 'apiKey' when calling PATCHAcquirersViabillFormat");
            
    
            var path = "/acquirers/viabill";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
            if (active != null) formParams.Add("active", ApiClient.ParameterToString(active)); // form parameter
if (apiKey != null) formParams.Add("api_key", ApiClient.ParameterToString(apiKey)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Patch, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersViabillFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersViabillFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsViaBill) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsViaBill), response.Headers);
        }
    
        /// <summary>
        /// Update Vipps acquirer settings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="active">Enable Vipps payments </param> 
        /// <param name="clientId">Vipps OAuth Client ID </param> 
        /// <param name="clientSecret">Vipps OAuth Client Secret </param> 
        /// <param name="serialNumber">Vipps agreement serial </param> 
        /// <param name="accessTokenSubscriptionKey">Vipps Access-Token Subscription Key </param> 
        /// <param name="ecommerceSubscriptionKey">Vipps eCommerce Subscription Key </param> 
        /// <param name="orgno">Vipps companys organization number </param> 
        /// <returns>AcquirerSettingsVipps</returns>            
        public AcquirerSettingsVipps PATCHAcquirersVippsFormat (string acceptVersion, string authorization, bool? active, string clientId, string clientSecret, string serialNumber, string accessTokenSubscriptionKey, string ecommerceSubscriptionKey, string orgno)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PATCHAcquirersVippsFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PATCHAcquirersVippsFormat");
            
            // verify the required parameter 'active' is set
            if (active == null) throw new ApiException(400, "Missing required parameter 'active' when calling PATCHAcquirersVippsFormat");
            
            // verify the required parameter 'clientId' is set
            if (clientId == null) throw new ApiException(400, "Missing required parameter 'clientId' when calling PATCHAcquirersVippsFormat");
            
            // verify the required parameter 'clientSecret' is set
            if (clientSecret == null) throw new ApiException(400, "Missing required parameter 'clientSecret' when calling PATCHAcquirersVippsFormat");
            
            // verify the required parameter 'serialNumber' is set
            if (serialNumber == null) throw new ApiException(400, "Missing required parameter 'serialNumber' when calling PATCHAcquirersVippsFormat");
            
            // verify the required parameter 'accessTokenSubscriptionKey' is set
            if (accessTokenSubscriptionKey == null) throw new ApiException(400, "Missing required parameter 'accessTokenSubscriptionKey' when calling PATCHAcquirersVippsFormat");
            
            // verify the required parameter 'ecommerceSubscriptionKey' is set
            if (ecommerceSubscriptionKey == null) throw new ApiException(400, "Missing required parameter 'ecommerceSubscriptionKey' when calling PATCHAcquirersVippsFormat");
            
    
            var path = "/acquirers/vipps";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
            if (active != null) formParams.Add("active", ApiClient.ParameterToString(active)); // form parameter
if (clientId != null) formParams.Add("client_id", ApiClient.ParameterToString(clientId)); // form parameter
if (clientSecret != null) formParams.Add("client_secret", ApiClient.ParameterToString(clientSecret)); // form parameter
if (serialNumber != null) formParams.Add("serial_number", ApiClient.ParameterToString(serialNumber)); // form parameter
if (accessTokenSubscriptionKey != null) formParams.Add("access_token_subscription_key", ApiClient.ParameterToString(accessTokenSubscriptionKey)); // form parameter
if (ecommerceSubscriptionKey != null) formParams.Add("ecommerce_subscription_key", ApiClient.ParameterToString(ecommerceSubscriptionKey)); // form parameter
if (orgno != null) formParams.Add("orgno", ApiClient.ParameterToString(orgno)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Patch, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersVippsFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAcquirersVippsFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerSettingsVipps) ApiClient.Deserialize(response.Content, typeof(AcquirerSettingsVipps), response.Headers);
        }
    
        /// <summary>
        /// Test payments via acquirer  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="acquirer">Acquirer name </param> 
        /// <returns>AcquirerTest</returns>            
        public AcquirerTest POSTAcquirersAcquirerTestFormat (string acceptVersion, string authorization, string acquirer)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling POSTAcquirersAcquirerTestFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling POSTAcquirersAcquirerTestFormat");
            
            // verify the required parameter 'acquirer' is set
            if (acquirer == null) throw new ApiException(400, "Missing required parameter 'acquirer' when calling POSTAcquirersAcquirerTestFormat");
            
    
            var path = "/acquirers/{acquirer}/test";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "acquirer" + "}", ApiClient.ParameterToString(acquirer));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTAcquirersAcquirerTestFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTAcquirersAcquirerTestFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerTest) ApiClient.Deserialize(response.Content, typeof(AcquirerTest), response.Headers);
        }
    
    }
}
