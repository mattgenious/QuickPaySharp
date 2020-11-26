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
    public interface IPaymentMethodPriorityApi
    {
        /// <summary>
        /// Get merchant payment method priority  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <returns>QuickPayProtocolV10PaymentMethodPriority</returns>
        QuickPayProtocolV10PaymentMethodPriority GETPaymentMethodPriorityFormat (string acceptVersion, string authorization);
        /// <summary>
        /// Replaces the payment method priority of the merchant  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="paymentMethodPriority">&lt;p&gt;A map of payment method to acquirers, e.g. { “visa”: [“clearhaus”, “nets”], … }&lt;/p&gt; </param>
        /// <returns></returns>
        void POSTPaymentMethodPriorityFormat (string acceptVersion, string authorization, Dictionary<string, string> paymentMethodPriority);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PaymentMethodPriorityApi : IPaymentMethodPriorityApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodPriorityApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PaymentMethodPriorityApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodPriorityApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PaymentMethodPriorityApi(String basePath)
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
        /// Get merchant payment method priority  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <returns>QuickPayProtocolV10PaymentMethodPriority</returns>            
        public QuickPayProtocolV10PaymentMethodPriority GETPaymentMethodPriorityFormat (string acceptVersion, string authorization)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETPaymentMethodPriorityFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETPaymentMethodPriorityFormat");
            
    
            var path = "/payment-method-priority";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETPaymentMethodPriorityFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETPaymentMethodPriorityFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10PaymentMethodPriority) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10PaymentMethodPriority), response.Headers);
        }
    
        /// <summary>
        /// Replaces the payment method priority of the merchant  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="paymentMethodPriority">&lt;p&gt;A map of payment method to acquirers, e.g. { “visa”: [“clearhaus”, “nets”], … }&lt;/p&gt; </param> 
        /// <returns></returns>            
        public void POSTPaymentMethodPriorityFormat (string acceptVersion, string authorization, Dictionary<string, string> paymentMethodPriority)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling POSTPaymentMethodPriorityFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling POSTPaymentMethodPriorityFormat");
            
            // verify the required parameter 'paymentMethodPriority' is set
            if (paymentMethodPriority == null) throw new ApiException(400, "Missing required parameter 'paymentMethodPriority' when calling POSTPaymentMethodPriorityFormat");
            
    
            var path = "/payment-method-priority";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
            if (paymentMethodPriority != null) formParams.Add("payment_method_priority", ApiClient.ParameterToString(paymentMethodPriority)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTPaymentMethodPriorityFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTPaymentMethodPriorityFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
