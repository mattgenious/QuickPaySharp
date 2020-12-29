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
    public interface ISubscriptionGroupsApi
    {
        /// <summary>
        /// Delete subscription group  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Subscription-group id </param>
        /// <returns>SubscriptionGroup</returns>
        SubscriptionGroup DELETESubscriptionGroupsIdFormat (string acceptVersion, string authorization, int? id);
        /// <summary>
        /// Get all subscription groups  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="page">Pagination page. Default is 1 </param>
        /// <param name="pageSize">Items per page. Default is 20 </param>
        /// <param name="sortBy">Property to sort by </param>
        /// <param name="sortDir">Sort direction </param>
        /// <returns>SubscriptionGroup</returns>
        SubscriptionGroup GETSubscriptionGroupsFormat (string acceptVersion, string authorization, int? page, int? pageSize, string sortBy, string sortDir);
        /// <summary>
        /// Find subscription group by id  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Subscription-group id </param>
        /// <returns>SubscriptionGroup</returns>
        SubscriptionGroup GETSubscriptionGroupsIdFormat (string acceptVersion, string authorization, int? id);
        /// <summary>
        /// Update subscription group  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Subscription-group id </param>
        /// <param name="name">Name of the group </param>
        /// <param name="amount">Amount to capture on each recurring capture </param>
        /// <param name="description">Descriptive text </param>
        /// <returns>SubscriptionGroup</returns>
        SubscriptionGroup PATCHSubscriptionGroupsIdFormat (string acceptVersion, string authorization, int? id, string name, int? amount, string description);
        /// <summary>
        /// Create subscription group  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="name">Name of the group </param>
        /// <param name="amount">Amount to capture on each recurring capture </param>
        /// <param name="currency">Currency for the amount </param>
        /// <param name="description">Descriptive text </param>
        /// <returns>SubscriptionGroup</returns>
        SubscriptionGroup POSTSubscriptionGroupsFormat (string acceptVersion, string authorization, string name, int? amount, string currency, string description);
        /// <summary>
        /// Create recurring payments on subscription group  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Subscription-group id </param>
        /// <param name="orderIdPrefix">Unique prefix for the order id of the recurring payments </param>
        /// <returns>SubscriptionGroupResult</returns>
        SubscriptionGroupResult POSTSubscriptionGroupsIdCaptureFormat (string acceptVersion, string authorization, int? id, string orderIdPrefix);
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
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="id">Subscription-group id </param> 
        /// <returns>SubscriptionGroup</returns>            
        public SubscriptionGroup DELETESubscriptionGroupsIdFormat (string acceptVersion, string authorization, int? id)
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
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DELETESubscriptionGroupsIdFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DELETESubscriptionGroupsIdFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SubscriptionGroup) ApiClient.Deserialize(response.Content, typeof(SubscriptionGroup), response.Headers);
        }
    
        /// <summary>
        /// Get all subscription groups  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="page">Pagination page. Default is 1 </param> 
        /// <param name="pageSize">Items per page. Default is 20 </param> 
        /// <param name="sortBy">Property to sort by </param> 
        /// <param name="sortDir">Sort direction </param> 
        /// <returns>SubscriptionGroup</returns>            
        public SubscriptionGroup GETSubscriptionGroupsFormat (string acceptVersion, string authorization, int? page, int? pageSize, string sortBy, string sortDir)
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
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETSubscriptionGroupsFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETSubscriptionGroupsFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SubscriptionGroup) ApiClient.Deserialize(response.Content, typeof(SubscriptionGroup), response.Headers);
        }
    
        /// <summary>
        /// Find subscription group by id  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="id">Subscription-group id </param> 
        /// <returns>SubscriptionGroup</returns>            
        public SubscriptionGroup GETSubscriptionGroupsIdFormat (string acceptVersion, string authorization, int? id)
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
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETSubscriptionGroupsIdFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETSubscriptionGroupsIdFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SubscriptionGroup) ApiClient.Deserialize(response.Content, typeof(SubscriptionGroup), response.Headers);
        }
    
        /// <summary>
        /// Update subscription group  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="id">Subscription-group id </param> 
        /// <param name="name">Name of the group </param> 
        /// <param name="amount">Amount to capture on each recurring capture </param> 
        /// <param name="description">Descriptive text </param> 
        /// <returns>SubscriptionGroup</returns>            
        public SubscriptionGroup PATCHSubscriptionGroupsIdFormat (string acceptVersion, string authorization, int? id, string name, int? amount, string description)
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
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
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
    
            return (SubscriptionGroup) ApiClient.Deserialize(response.Content, typeof(SubscriptionGroup), response.Headers);
        }
    
        /// <summary>
        /// Create subscription group  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="name">Name of the group </param> 
        /// <param name="amount">Amount to capture on each recurring capture </param> 
        /// <param name="currency">Currency for the amount </param> 
        /// <param name="description">Descriptive text </param> 
        /// <returns>SubscriptionGroup</returns>            
        public SubscriptionGroup POSTSubscriptionGroupsFormat (string acceptVersion, string authorization, string name, int? amount, string currency, string description)
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
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
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
    
            return (SubscriptionGroup) ApiClient.Deserialize(response.Content, typeof(SubscriptionGroup), response.Headers);
        }
    
        /// <summary>
        /// Create recurring payments on subscription group  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="id">Subscription-group id </param> 
        /// <param name="orderIdPrefix">Unique prefix for the order id of the recurring payments </param> 
        /// <returns>SubscriptionGroupResult</returns>            
        public SubscriptionGroupResult POSTSubscriptionGroupsIdCaptureFormat (string acceptVersion, string authorization, int? id, string orderIdPrefix)
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
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
            if (orderIdPrefix != null) formParams.Add("order_id_prefix", ApiClient.ParameterToString(orderIdPrefix)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTSubscriptionGroupsIdCaptureFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTSubscriptionGroupsIdCaptureFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SubscriptionGroupResult) ApiClient.Deserialize(response.Content, typeof(SubscriptionGroupResult), response.Headers);
        }
    
    }
}
