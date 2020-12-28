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
    public interface IOperationalStatusApi
    {
        /// <summary>
        /// Gets operational status of all acquirers  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="page">Pagination page. Default is 1 </param>
        /// <param name="pageSize">Items per page. Default is 20 </param>
        /// <param name="sortBy">Property to sort by </param>
        /// <param name="sortDir">Sort direction </param>
        /// <returns>AcquirerStatus</returns>
        AcquirerStatus GETOperationalStatusAcquirersFormat (string acceptVersion, string authorization, int? page, int? pageSize, string sortBy, string sortDir);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OperationalStatusApi : IOperationalStatusApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OperationalStatusApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public OperationalStatusApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OperationalStatusApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OperationalStatusApi(String basePath)
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
        /// Gets operational status of all acquirers  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="page">Pagination page. Default is 1 </param> 
        /// <param name="pageSize">Items per page. Default is 20 </param> 
        /// <param name="sortBy">Property to sort by </param> 
        /// <param name="sortDir">Sort direction </param> 
        /// <returns>AcquirerStatus</returns>            
        public AcquirerStatus GETOperationalStatusAcquirersFormat (string acceptVersion, string authorization, int? page, int? pageSize, string sortBy, string sortDir)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETOperationalStatusAcquirersFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETOperationalStatusAcquirersFormat");
            
    
            var path = "/operational-status/acquirers";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETOperationalStatusAcquirersFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETOperationalStatusAcquirersFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AcquirerStatus) ApiClient.Deserialize(response.Content, typeof(AcquirerStatus), response.Headers);
        }
    
    }
}
