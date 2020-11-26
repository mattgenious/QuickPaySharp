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
    public interface ISubscriptionGroupsApi
    {
        /// <summary>
        /// Delete subscription group  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="id">&lt;p&gt;Subscription-group id&lt;/p&gt; </param>
        /// <returns>QuickPayProtocolV10SubscriptionGroup</returns>
        QuickPayProtocolV10SubscriptionGroup DELETESubscriptionGroupsIdFormat (string acceptVersion, string authorization, int? id);
        /// <summary>
        /// Get all subscription groups  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="page">&lt;p&gt;Pagination page. Default is 1&lt;/p&gt; </param>
        /// <param name="pageSize">&lt;p&gt;Items per page. Default is 20&lt;/p&gt; </param>
        /// <param name="sortBy">&lt;p&gt;Property to sort by&lt;/p&gt; </param>
        /// <param name="sortDir">&lt;p&gt;Sort direction&lt;/p&gt; </param>
        /// <returns>QuickPayProtocolV10SubscriptionGroup</returns>
        QuickPayProtocolV10SubscriptionGroup GETSubscriptionGroupsFormat (string acceptVersion, string authorization, int? page, int? pageSize, string sortBy, string sortDir);
        /// <summary>
        /// Find subscription group by id  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="id">&lt;p&gt;Subscription-group id&lt;/p&gt; </param>
        /// <returns>QuickPayProtocolV10SubscriptionGroup</returns>
        QuickPayProtocolV10SubscriptionGroup GETSubscriptionGroupsIdFormat (string acceptVersion, string authorization, int? id);
        /// <summary>
        /// Update subscription group  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="id">&lt;p&gt;Subscription-group id&lt;/p&gt; </param>
        /// <param name="name">&lt;p&gt;Name of the group&lt;/p&gt; </param>
        /// <param name="amount">&lt;p&gt;Amount to capture on each recurring capture&lt;/p&gt; </param>
        /// <param name="description">&lt;p&gt;Descriptive text&lt;/p&gt; </param>
        /// <returns>QuickPayProtocolV10SubscriptionGroup</returns>
        QuickPayProtocolV10SubscriptionGroup PATCHSubscriptionGroupsIdFormat (string acceptVersion, string authorization, int? id, string name, int? amount, string description);
        /// <summary>
        /// Create subscription group  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="name">&lt;p&gt;Name of the group&lt;/p&gt; </param>
        /// <param name="amount">&lt;p&gt;Amount to capture on each recurring capture&lt;/p&gt; </param>
        /// <param name="currency">&lt;p&gt;Currency for the amount&lt;/p&gt; </param>
        /// <param name="description">&lt;p&gt;Descriptive text&lt;/p&gt; </param>
        /// <returns>QuickPayProtocolV10SubscriptionGroup</returns>
        QuickPayProtocolV10SubscriptionGroup POSTSubscriptionGroupsFormat (string acceptVersion, string authorization, string name, int? amount, string currency, string description);
        /// <summary>
        /// Create recurring payments on subscription group  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="id">&lt;p&gt;Subscription-group id&lt;/p&gt; </param>
        /// <param name="orderIdPrefix">&lt;p&gt;Unique prefix for the order id of the recurring payments&lt;/p&gt; </param>
        /// <returns>QuickPayProtocolV10SubscriptionGroupResult</returns>
        QuickPayProtocolV10SubscriptionGroupResult POSTSubscriptionGroupsIdCaptureFormat (string acceptVersion, string authorization, int? id, string orderIdPrefix);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SubscriptionGroupsApi : ISubscriptionGroupsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SubscriptionGroupsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SubscriptionGroupsApi(String basePath)
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
        /// Delete subscription group  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="id">&lt;p&gt;Subscription-group id&lt;/p&gt; </param> 
        /// <returns>QuickPayProtocolV10SubscriptionGroup</returns>            
        public QuickPayProtocolV10SubscriptionGroup DELETESubscriptionGroupsIdFormat (string acceptVersion, string authorization, int? id)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling DELETESubscriptionGroupsIdFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling DELETESubscriptionGroupsIdFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DELETESubscriptionGroupsIdFormat");
            
    
            var path = "/subscription-groups/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DELETESubscriptionGroupsIdFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DELETESubscriptionGroupsIdFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10SubscriptionGroup) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10SubscriptionGroup), response.Headers);
        }
    
        /// <summary>
        /// Get all subscription groups  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="page">&lt;p&gt;Pagination page. Default is 1&lt;/p&gt; </param> 
        /// <param name="pageSize">&lt;p&gt;Items per page. Default is 20&lt;/p&gt; </param> 
        /// <param name="sortBy">&lt;p&gt;Property to sort by&lt;/p&gt; </param> 
        /// <param name="sortDir">&lt;p&gt;Sort direction&lt;/p&gt; </param> 
        /// <returns>QuickPayProtocolV10SubscriptionGroup</returns>            
        public QuickPayProtocolV10SubscriptionGroup GETSubscriptionGroupsFormat (string acceptVersion, string authorization, int? page, int? pageSize, string sortBy, string sortDir)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETSubscriptionGroupsFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETSubscriptionGroupsFormat");
            
    
            var path = "/subscription-groups";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
 if (sortBy != null) queryParams.Add("sort_by", ApiClient.ParameterToString(sortBy)); // query parameter
 if (sortDir != null) queryParams.Add("sort_dir", ApiClient.ParameterToString(sortDir)); // query parameter
             if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETSubscriptionGroupsFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETSubscriptionGroupsFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10SubscriptionGroup) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10SubscriptionGroup), response.Headers);
        }
    
        /// <summary>
        /// Find subscription group by id  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="id">&lt;p&gt;Subscription-group id&lt;/p&gt; </param> 
        /// <returns>QuickPayProtocolV10SubscriptionGroup</returns>            
        public QuickPayProtocolV10SubscriptionGroup GETSubscriptionGroupsIdFormat (string acceptVersion, string authorization, int? id)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETSubscriptionGroupsIdFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETSubscriptionGroupsIdFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GETSubscriptionGroupsIdFormat");
            
    
            var path = "/subscription-groups/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETSubscriptionGroupsIdFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETSubscriptionGroupsIdFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10SubscriptionGroup) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10SubscriptionGroup), response.Headers);
        }
    
        /// <summary>
        /// Update subscription group  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="id">&lt;p&gt;Subscription-group id&lt;/p&gt; </param> 
        /// <param name="name">&lt;p&gt;Name of the group&lt;/p&gt; </param> 
        /// <param name="amount">&lt;p&gt;Amount to capture on each recurring capture&lt;/p&gt; </param> 
        /// <param name="description">&lt;p&gt;Descriptive text&lt;/p&gt; </param> 
        /// <returns>QuickPayProtocolV10SubscriptionGroup</returns>            
        public QuickPayProtocolV10SubscriptionGroup PATCHSubscriptionGroupsIdFormat (string acceptVersion, string authorization, int? id, string name, int? amount, string description)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PATCHSubscriptionGroupsIdFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PATCHSubscriptionGroupsIdFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PATCHSubscriptionGroupsIdFormat");
            
    
            var path = "/subscription-groups/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
            if (name != null) formParams.Add("name", ApiClient.ParameterToString(name)); // form parameter
if (amount != null) formParams.Add("amount", ApiClient.ParameterToString(amount)); // form parameter
if (description != null) formParams.Add("description", ApiClient.ParameterToString(description)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHSubscriptionGroupsIdFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHSubscriptionGroupsIdFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10SubscriptionGroup) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10SubscriptionGroup), response.Headers);
        }
    
        /// <summary>
        /// Create subscription group  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="name">&lt;p&gt;Name of the group&lt;/p&gt; </param> 
        /// <param name="amount">&lt;p&gt;Amount to capture on each recurring capture&lt;/p&gt; </param> 
        /// <param name="currency">&lt;p&gt;Currency for the amount&lt;/p&gt; </param> 
        /// <param name="description">&lt;p&gt;Descriptive text&lt;/p&gt; </param> 
        /// <returns>QuickPayProtocolV10SubscriptionGroup</returns>            
        public QuickPayProtocolV10SubscriptionGroup POSTSubscriptionGroupsFormat (string acceptVersion, string authorization, string name, int? amount, string currency, string description)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling POSTSubscriptionGroupsFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling POSTSubscriptionGroupsFormat");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling POSTSubscriptionGroupsFormat");
            
            // verify the required parameter 'amount' is set
            if (amount == null) throw new ApiException(400, "Missing required parameter 'amount' when calling POSTSubscriptionGroupsFormat");
            
            // verify the required parameter 'currency' is set
            if (currency == null) throw new ApiException(400, "Missing required parameter 'currency' when calling POSTSubscriptionGroupsFormat");
            
    
            var path = "/subscription-groups";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
            if (name != null) formParams.Add("name", ApiClient.ParameterToString(name)); // form parameter
if (amount != null) formParams.Add("amount", ApiClient.ParameterToString(amount)); // form parameter
if (currency != null) formParams.Add("currency", ApiClient.ParameterToString(currency)); // form parameter
if (description != null) formParams.Add("description", ApiClient.ParameterToString(description)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTSubscriptionGroupsFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTSubscriptionGroupsFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10SubscriptionGroup) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10SubscriptionGroup), response.Headers);
        }
    
        /// <summary>
        /// Create recurring payments on subscription group  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="id">&lt;p&gt;Subscription-group id&lt;/p&gt; </param> 
        /// <param name="orderIdPrefix">&lt;p&gt;Unique prefix for the order id of the recurring payments&lt;/p&gt; </param> 
        /// <returns>QuickPayProtocolV10SubscriptionGroupResult</returns>            
        public QuickPayProtocolV10SubscriptionGroupResult POSTSubscriptionGroupsIdCaptureFormat (string acceptVersion, string authorization, int? id, string orderIdPrefix)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling POSTSubscriptionGroupsIdCaptureFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling POSTSubscriptionGroupsIdCaptureFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling POSTSubscriptionGroupsIdCaptureFormat");
            
            // verify the required parameter 'orderIdPrefix' is set
            if (orderIdPrefix == null) throw new ApiException(400, "Missing required parameter 'orderIdPrefix' when calling POSTSubscriptionGroupsIdCaptureFormat");
            
    
            var path = "/subscription-groups/{id}/capture";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
            if (orderIdPrefix != null) formParams.Add("order_id_prefix", ApiClient.ParameterToString(orderIdPrefix)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTSubscriptionGroupsIdCaptureFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTSubscriptionGroupsIdCaptureFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10SubscriptionGroupResult) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10SubscriptionGroupResult), response.Headers);
        }
    
    }
}
