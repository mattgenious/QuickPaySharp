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
    public interface IActivityApi
    {
        /// <summary>
        /// Get activity  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="userId">Limit to activity by user_id </param>
        /// <param name="targetType">Filter by target type, e.g. ‘Payment’ </param>
        /// <param name="targetId">Filter by target id, e.g. id of payment </param>
        /// <param name="support">Filter by whether a support user made the activity </param>
        /// <param name="page">Pagination page. Default is 1 </param>
        /// <param name="pageSize">Items per page. Default is 20 </param>
        /// <param name="sortBy">Property to sort by </param>
        /// <param name="sortDir">Sort direction </param>
        /// <param name="pageKey"> </param>
        /// <returns>Activity</returns>
        Activity GETActivityFormat (string acceptVersion, string authorization, int? userId, string targetType, int? targetId, bool? support, int? page, int? pageSize, string sortBy, string sortDir, string pageKey);
        /// <summary>
        /// Get a single activity entry  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Activity entry id </param>
        /// <returns>Activity</returns>
        Activity GETActivityIdFormat (string acceptVersion, string authorization, string id);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ActivityApi : IActivityApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ActivityApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ActivityApi(String basePath)
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
        /// Get activity  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="userId">Limit to activity by user_id </param> 
        /// <param name="targetType">Filter by target type, e.g. ‘Payment’ </param> 
        /// <param name="targetId">Filter by target id, e.g. id of payment </param> 
        /// <param name="support">Filter by whether a support user made the activity </param> 
        /// <param name="page">Pagination page. Default is 1 </param> 
        /// <param name="pageSize">Items per page. Default is 20 </param> 
        /// <param name="sortBy">Property to sort by </param> 
        /// <param name="sortDir">Sort direction </param> 
        /// <param name="pageKey"> </param> 
        /// <returns>Activity</returns>            
        public Activity GETActivityFormat (string acceptVersion, string authorization, int? userId, string targetType, int? targetId, bool? support, int? page, int? pageSize, string sortBy, string sortDir, string pageKey)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETActivityFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETActivityFormat");
            
    
            var path = "/activity";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (userId != null) queryParams.Add("user_id", ApiClient.ParameterToString(userId)); // query parameter
 if (targetType != null) queryParams.Add("target_type", ApiClient.ParameterToString(targetType)); // query parameter
 if (targetId != null) queryParams.Add("target_id", ApiClient.ParameterToString(targetId)); // query parameter
 if (support != null) queryParams.Add("support", ApiClient.ParameterToString(support)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
 if (sortBy != null) queryParams.Add("sort_by", ApiClient.ParameterToString(sortBy)); // query parameter
 if (sortDir != null) queryParams.Add("sort_dir", ApiClient.ParameterToString(sortDir)); // query parameter
 if (pageKey != null) queryParams.Add("page_key", ApiClient.ParameterToString(pageKey)); // query parameter
             if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETActivityFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETActivityFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Activity) ApiClient.Deserialize(response.Content, typeof(Activity), response.Headers);
        }
    
        /// <summary>
        /// Get a single activity entry  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="id">Activity entry id </param> 
        /// <returns>Activity</returns>            
        public Activity GETActivityIdFormat (string acceptVersion, string authorization, string id)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETActivityIdFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETActivityIdFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GETActivityIdFormat");
            
    
            var path = "/activity/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETActivityIdFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETActivityIdFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Activity) ApiClient.Deserialize(response.Content, typeof(Activity), response.Headers);
        }
    
    }
}
