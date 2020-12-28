using System;
using System.Collections.Generic;
using RestSharp;
using QuickPaySharp.Client;

namespace QuickPaySharp.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IChangelogApi
    {
        /// <summary>
        /// Get the QuickPay API Changelog  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <returns></returns>
        void GETChangelogFormat (string acceptVersion, string authorization);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ChangelogApi : IChangelogApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangelogApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ChangelogApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangelogApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ChangelogApi(String basePath)
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
        /// Get the QuickPay API Changelog  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <returns></returns>            
        public void GETChangelogFormat (string acceptVersion, string authorization)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETChangelogFormat");
            
    
            var path = "/changelog";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETChangelogFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETChangelogFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
