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
    public interface IFeesApi
    {
        /// <summary>
        /// Reset a formula to default  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="acquirer">&lt;p&gt;Name of acquirer&lt;/p&gt; </param>
        /// <param name="paymentMethod">&lt;p&gt;Payment method&lt;/p&gt; </param>
        /// <returns></returns>
        void DELETEFeesFormulasAcquirerPaymentMethodFormat (string acceptVersion, string authorization, string acquirer, string paymentMethod);
        /// <summary>
        /// Get fee formulas  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="acquirer">&lt;p&gt;Name of acquirer&lt;/p&gt; </param>
        /// <returns>QuickPayProtocolV10FeeFormula</returns>
        QuickPayProtocolV10FeeFormula GETFeesFormulasAcquirerFormat (string acceptVersion, string authorization, string acquirer);
        /// <summary>
        /// Get fee formula  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="acquirer">&lt;p&gt;Name of acquirer&lt;/p&gt; </param>
        /// <param name="paymentMethod">&lt;p&gt;Payment method&lt;/p&gt; </param>
        /// <returns>QuickPayProtocolV10FeeFormula</returns>
        QuickPayProtocolV10FeeFormula GETFeesFormulasAcquirerPaymentMethodFormat (string acceptVersion, string authorization, string acquirer, string paymentMethod);
        /// <summary>
        /// Get all fee formulas  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="page">&lt;p&gt;Pagination page. Default is 1&lt;/p&gt; </param>
        /// <param name="pageSize">&lt;p&gt;Items per page. Default is 20&lt;/p&gt; </param>
        /// <returns>QuickPayProtocolV10FeeFormula</returns>
        QuickPayProtocolV10FeeFormula GETFeesFormulasFormat (string acceptVersion, string authorization, int? page, int? pageSize);
        /// <summary>
        /// Update a fee formula  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="acquirer">&lt;p&gt;Name of acquirer&lt;/p&gt; </param>
        /// <param name="paymentMethod">&lt;p&gt;Payment method&lt;/p&gt; </param>
        /// <param name="formula">&lt;p&gt;The formula&lt;/p&gt; </param>
        /// <returns>QuickPayProtocolV10FeeFormula</returns>
        QuickPayProtocolV10FeeFormula PATCHFeesFormulasAcquirerPaymentMethodFormat (string acceptVersion, string authorization, string acquirer, string paymentMethod, string formula);
        /// <summary>
        /// Calculate fee  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="acquirer">&lt;p&gt;Name of acquirer&lt;/p&gt; </param>
        /// <param name="paymentMethod">&lt;p&gt;Payment method&lt;/p&gt; </param>
        /// <param name="amount">&lt;p&gt;Amount specified in smallest unit&lt;/p&gt; </param>
        /// <returns>QuickPayProtocolV10CalculatedFee</returns>
        QuickPayProtocolV10CalculatedFee POSTFeesAcquirerPaymentMethodFormat (string acceptVersion, string authorization, string acquirer, string paymentMethod, int? amount);
        /// <summary>
        /// Calculate fee for auth params. Requires one of card[number] or card[token]  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="amount">&lt;p&gt;Amount specified in smallest unit&lt;/p&gt; </param>
        /// <param name="currency">&lt;p&gt;Currency&lt;/p&gt; </param>
        /// <param name="cardApplePayToken">&lt;p&gt;Apple Pay payment-token&lt;/p&gt; </param>
        /// <param name="cardMobilepayOnlineToken">&lt;p&gt;MobilePay Online payment-token&lt;/p&gt; </param>
        /// <param name="cardToken">&lt;p&gt;Card token&lt;/p&gt; </param>
        /// <param name="cardNumber">&lt;p&gt;Card number&lt;/p&gt; </param>
        /// <param name="cardBrand">&lt;p&gt;Brand to use on multi-brand card&lt;/p&gt; </param>
        /// <param name="acquirer">&lt;p&gt;If set, will force the use of this acquirer&lt;/p&gt; </param>
        /// <returns>QuickPayProtocolV10CalculatedFee</returns>
        QuickPayProtocolV10CalculatedFee POSTFeesFormat (string acceptVersion, string authorization, int? amount, string currency, Dictionary<string, string> cardApplePayToken, Dictionary<string, string> cardMobilepayOnlineToken, string cardToken, string cardNumber, string cardBrand, string acquirer);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class FeesApi : IFeesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public FeesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FeesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FeesApi(String basePath)
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
        /// Reset a formula to default  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="acquirer">&lt;p&gt;Name of acquirer&lt;/p&gt; </param> 
        /// <param name="paymentMethod">&lt;p&gt;Payment method&lt;/p&gt; </param> 
        /// <returns></returns>            
        public void DELETEFeesFormulasAcquirerPaymentMethodFormat (string acceptVersion, string authorization, string acquirer, string paymentMethod)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling DELETEFeesFormulasAcquirerPaymentMethodFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling DELETEFeesFormulasAcquirerPaymentMethodFormat");
            
            // verify the required parameter 'acquirer' is set
            if (acquirer == null) throw new ApiException(400, "Missing required parameter 'acquirer' when calling DELETEFeesFormulasAcquirerPaymentMethodFormat");
            
            // verify the required parameter 'paymentMethod' is set
            if (paymentMethod == null) throw new ApiException(400, "Missing required parameter 'paymentMethod' when calling DELETEFeesFormulasAcquirerPaymentMethodFormat");
            
    
            var path = "/fees/formulas/{acquirer}/{payment_method}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "acquirer" + "}", ApiClient.ParameterToString(acquirer));
path = path.Replace("{" + "payment_method" + "}", ApiClient.ParameterToString(paymentMethod));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DELETEFeesFormulasAcquirerPaymentMethodFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DELETEFeesFormulasAcquirerPaymentMethodFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get fee formulas  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="acquirer">&lt;p&gt;Name of acquirer&lt;/p&gt; </param> 
        /// <returns>QuickPayProtocolV10FeeFormula</returns>            
        public QuickPayProtocolV10FeeFormula GETFeesFormulasAcquirerFormat (string acceptVersion, string authorization, string acquirer)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETFeesFormulasAcquirerFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETFeesFormulasAcquirerFormat");
            
            // verify the required parameter 'acquirer' is set
            if (acquirer == null) throw new ApiException(400, "Missing required parameter 'acquirer' when calling GETFeesFormulasAcquirerFormat");
            
    
            var path = "/fees/formulas/{acquirer}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "acquirer" + "}", ApiClient.ParameterToString(acquirer));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETFeesFormulasAcquirerFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETFeesFormulasAcquirerFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10FeeFormula) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10FeeFormula), response.Headers);
        }
    
        /// <summary>
        /// Get fee formula  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="acquirer">&lt;p&gt;Name of acquirer&lt;/p&gt; </param> 
        /// <param name="paymentMethod">&lt;p&gt;Payment method&lt;/p&gt; </param> 
        /// <returns>QuickPayProtocolV10FeeFormula</returns>            
        public QuickPayProtocolV10FeeFormula GETFeesFormulasAcquirerPaymentMethodFormat (string acceptVersion, string authorization, string acquirer, string paymentMethod)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETFeesFormulasAcquirerPaymentMethodFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETFeesFormulasAcquirerPaymentMethodFormat");
            
            // verify the required parameter 'acquirer' is set
            if (acquirer == null) throw new ApiException(400, "Missing required parameter 'acquirer' when calling GETFeesFormulasAcquirerPaymentMethodFormat");
            
            // verify the required parameter 'paymentMethod' is set
            if (paymentMethod == null) throw new ApiException(400, "Missing required parameter 'paymentMethod' when calling GETFeesFormulasAcquirerPaymentMethodFormat");
            
    
            var path = "/fees/formulas/{acquirer}/{payment_method}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "acquirer" + "}", ApiClient.ParameterToString(acquirer));
path = path.Replace("{" + "payment_method" + "}", ApiClient.ParameterToString(paymentMethod));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETFeesFormulasAcquirerPaymentMethodFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETFeesFormulasAcquirerPaymentMethodFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10FeeFormula) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10FeeFormula), response.Headers);
        }
    
        /// <summary>
        /// Get all fee formulas  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="page">&lt;p&gt;Pagination page. Default is 1&lt;/p&gt; </param> 
        /// <param name="pageSize">&lt;p&gt;Items per page. Default is 20&lt;/p&gt; </param> 
        /// <returns>QuickPayProtocolV10FeeFormula</returns>            
        public QuickPayProtocolV10FeeFormula GETFeesFormulasFormat (string acceptVersion, string authorization, int? page, int? pageSize)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETFeesFormulasFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETFeesFormulasFormat");
            
    
            var path = "/fees/formulas";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
             if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETFeesFormulasFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETFeesFormulasFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10FeeFormula) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10FeeFormula), response.Headers);
        }
    
        /// <summary>
        /// Update a fee formula  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="acquirer">&lt;p&gt;Name of acquirer&lt;/p&gt; </param> 
        /// <param name="paymentMethod">&lt;p&gt;Payment method&lt;/p&gt; </param> 
        /// <param name="formula">&lt;p&gt;The formula&lt;/p&gt; </param> 
        /// <returns>QuickPayProtocolV10FeeFormula</returns>            
        public QuickPayProtocolV10FeeFormula PATCHFeesFormulasAcquirerPaymentMethodFormat (string acceptVersion, string authorization, string acquirer, string paymentMethod, string formula)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PATCHFeesFormulasAcquirerPaymentMethodFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PATCHFeesFormulasAcquirerPaymentMethodFormat");
            
            // verify the required parameter 'acquirer' is set
            if (acquirer == null) throw new ApiException(400, "Missing required parameter 'acquirer' when calling PATCHFeesFormulasAcquirerPaymentMethodFormat");
            
            // verify the required parameter 'paymentMethod' is set
            if (paymentMethod == null) throw new ApiException(400, "Missing required parameter 'paymentMethod' when calling PATCHFeesFormulasAcquirerPaymentMethodFormat");
            
    
            var path = "/fees/formulas/{acquirer}/{payment_method}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "acquirer" + "}", ApiClient.ParameterToString(acquirer));
path = path.Replace("{" + "payment_method" + "}", ApiClient.ParameterToString(paymentMethod));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
            if (formula != null) formParams.Add("formula", ApiClient.ParameterToString(formula)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHFeesFormulasAcquirerPaymentMethodFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHFeesFormulasAcquirerPaymentMethodFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10FeeFormula) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10FeeFormula), response.Headers);
        }
    
        /// <summary>
        /// Calculate fee  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="acquirer">&lt;p&gt;Name of acquirer&lt;/p&gt; </param> 
        /// <param name="paymentMethod">&lt;p&gt;Payment method&lt;/p&gt; </param> 
        /// <param name="amount">&lt;p&gt;Amount specified in smallest unit&lt;/p&gt; </param> 
        /// <returns>QuickPayProtocolV10CalculatedFee</returns>            
        public QuickPayProtocolV10CalculatedFee POSTFeesAcquirerPaymentMethodFormat (string acceptVersion, string authorization, string acquirer, string paymentMethod, int? amount)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling POSTFeesAcquirerPaymentMethodFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling POSTFeesAcquirerPaymentMethodFormat");
            
            // verify the required parameter 'acquirer' is set
            if (acquirer == null) throw new ApiException(400, "Missing required parameter 'acquirer' when calling POSTFeesAcquirerPaymentMethodFormat");
            
            // verify the required parameter 'paymentMethod' is set
            if (paymentMethod == null) throw new ApiException(400, "Missing required parameter 'paymentMethod' when calling POSTFeesAcquirerPaymentMethodFormat");
            
            // verify the required parameter 'amount' is set
            if (amount == null) throw new ApiException(400, "Missing required parameter 'amount' when calling POSTFeesAcquirerPaymentMethodFormat");
            
    
            var path = "/fees/{acquirer}/{payment_method}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "acquirer" + "}", ApiClient.ParameterToString(acquirer));
path = path.Replace("{" + "payment_method" + "}", ApiClient.ParameterToString(paymentMethod));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
            if (amount != null) formParams.Add("amount", ApiClient.ParameterToString(amount)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTFeesAcquirerPaymentMethodFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTFeesAcquirerPaymentMethodFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10CalculatedFee) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10CalculatedFee), response.Headers);
        }
    
        /// <summary>
        /// Calculate fee for auth params. Requires one of card[number] or card[token]  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="amount">&lt;p&gt;Amount specified in smallest unit&lt;/p&gt; </param> 
        /// <param name="currency">&lt;p&gt;Currency&lt;/p&gt; </param> 
        /// <param name="cardApplePayToken">&lt;p&gt;Apple Pay payment-token&lt;/p&gt; </param> 
        /// <param name="cardMobilepayOnlineToken">&lt;p&gt;MobilePay Online payment-token&lt;/p&gt; </param> 
        /// <param name="cardToken">&lt;p&gt;Card token&lt;/p&gt; </param> 
        /// <param name="cardNumber">&lt;p&gt;Card number&lt;/p&gt; </param> 
        /// <param name="cardBrand">&lt;p&gt;Brand to use on multi-brand card&lt;/p&gt; </param> 
        /// <param name="acquirer">&lt;p&gt;If set, will force the use of this acquirer&lt;/p&gt; </param> 
        /// <returns>QuickPayProtocolV10CalculatedFee</returns>            
        public QuickPayProtocolV10CalculatedFee POSTFeesFormat (string acceptVersion, string authorization, int? amount, string currency, Dictionary<string, string> cardApplePayToken, Dictionary<string, string> cardMobilepayOnlineToken, string cardToken, string cardNumber, string cardBrand, string acquirer)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling POSTFeesFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling POSTFeesFormat");
            
            // verify the required parameter 'amount' is set
            if (amount == null) throw new ApiException(400, "Missing required parameter 'amount' when calling POSTFeesFormat");
            
    
            var path = "/fees";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
            if (amount != null) formParams.Add("amount", ApiClient.ParameterToString(amount)); // form parameter
if (currency != null) formParams.Add("currency", ApiClient.ParameterToString(currency)); // form parameter
if (cardApplePayToken != null) formParams.Add("card[apple_pay_token]", ApiClient.ParameterToString(cardApplePayToken)); // form parameter
if (cardMobilepayOnlineToken != null) formParams.Add("card[mobilepay_online_token]", ApiClient.ParameterToString(cardMobilepayOnlineToken)); // form parameter
if (cardToken != null) formParams.Add("card[token]", ApiClient.ParameterToString(cardToken)); // form parameter
if (cardNumber != null) formParams.Add("card[number]", ApiClient.ParameterToString(cardNumber)); // form parameter
if (cardBrand != null) formParams.Add("card[brand]", ApiClient.ParameterToString(cardBrand)); // form parameter
if (acquirer != null) formParams.Add("acquirer", ApiClient.ParameterToString(acquirer)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTFeesFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTFeesFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10CalculatedFee) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10CalculatedFee), response.Headers);
        }
    
    }
}
