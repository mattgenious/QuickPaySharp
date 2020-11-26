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
    public interface IAclResourcesApi
    {
        /// <summary>
        /// Get acl resources  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="page">&lt;p&gt;Pagination page. Default is 1&lt;/p&gt; </param>
        /// <param name="pageSize">&lt;p&gt;Items per page. Default is 20&lt;/p&gt; </param>
        /// <returns>QuickPayProtocolV10AclResource</returns>
        QuickPayProtocolV10AclResource GETAclResourcesFormat (string acceptVersion, string authorization, int? page, int? pageSize);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AclResourcesApi : IAclResourcesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AclResourcesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AclResourcesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AclResourcesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AclResourcesApi(String basePath)
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
        /// Get acl resources  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="page">&lt;p&gt;Pagination page. Default is 1&lt;/p&gt; </param> 
        /// <param name="pageSize">&lt;p&gt;Items per page. Default is 20&lt;/p&gt; </param> 
        /// <returns>QuickPayProtocolV10AclResource</returns>            
        public QuickPayProtocolV10AclResource GETAclResourcesFormat (string acceptVersion, string authorization, int? page, int? pageSize)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETAclResourcesFormat");
            
    
            var path = "/acl-resources";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETAclResourcesFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAclResourcesFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10AclResource) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10AclResource), response.Headers);
        }
    
    }
}
