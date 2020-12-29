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
    public interface IBrandingsApi
    {
        /// <summary>
        /// Delete a branding  
        /// </summary>
        /// <param name="id">Branding id </param>
        /// <returns></returns>
        void DELETEBrandingsIdFormat (int? id);
        /// <summary>
        /// Deletes a branding resource  
        /// </summary>
        /// <param name="id">Branding id </param>
        /// <param name="resourceName"> </param>
        /// <returns></returns>
        void DELETEBrandingsIdresourceNameFormat (int? id, string resourceName);
        /// <summary>
        /// Get brandings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="except">Specifies which attributes to skip. Default is ‘resources.data’ </param>
        /// <param name="only">Specifies which attributes to include. (Overrides except default) </param>
        /// <param name="page">Pagination page. Default is 1 </param>
        /// <param name="pageSize">Items per page. Default is 20 </param>
        /// <param name="sortBy">Property to sort by </param>
        /// <param name="sortDir">Sort direction </param>
        /// <returns>Branding</returns>
        Branding GETBrandingsFormat (string acceptVersion, string authorization, string except, string only, int? page, int? pageSize, string sortBy, string sortDir);
        /// <summary>
        /// Get a branding  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Branding id </param>
        /// <param name="except">Specifies which attributes to skip. Default is ‘resources.data’ </param>
        /// <param name="only">Specifies which attributes to include. (Overrides except default) </param>
        /// <returns>Branding</returns>
        Branding GETBrandingsIdFormat (string acceptVersion, string authorization, int? id, string except, string only);
        /// <summary>
        /// Gets a branding resource as a file  
        /// </summary>
        /// <param name="id">Branding id </param>
        /// <param name="resourceName"> </param>
        /// <returns></returns>
        void GETBrandingsIdresourceNameFormat (int? id, string resourceName);
        /// <summary>
        /// Update a branding  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Branding id </param>
        /// <param name="name">Descriptive name of the branding </param>
        /// <param name="except">Specifies which attributes to skip. Default is ‘resources.data’ </param>
        /// <param name="only">Specifies which attributes to include. (Overrides except default) </param>
        /// <returns>Branding</returns>
        Branding PATCHBrandingsIdFormat (string acceptVersion, string authorization, int? id, string name, string except, string only);
        /// <summary>
        /// Create a branding  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="name">Descriptive name of the branding </param>
        /// <returns>Branding</returns>
        Branding POSTBrandingsFormat (string acceptVersion, string authorization, string name);
        /// <summary>
        /// Copies branding and returns the new branding  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Branding id </param>
        /// <param name="except">Specifies which attributes to skip. Default is ‘resources.data’ </param>
        /// <param name="only">Specifies which attributes to include. (Overrides except default) </param>
        /// <returns>Branding</returns>
        Branding POSTBrandingsIdCopyFormat (string acceptVersion, string authorization, int? id, string except, string only);
        /// <summary>
        /// Uploads a file and creates or replaces a resource  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Branding id </param>
        /// <param name="_file">The file send as multipart </param>
        /// <param name="resourceName"> </param>
        /// <returns></returns>
        void PUTBrandingsIdresourceNameFormat (string acceptVersion, string authorization, int? id, string _file, string resourceName);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BrandingsApi : IBrandingsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrandingsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public BrandingsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BrandingsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BrandingsApi(String basePath)
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
        /// Delete a branding  
        /// </summary>
        /// <param name="id">Branding id </param> 
        /// <returns></returns>            
        public void DELETEBrandingsIdFormat (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DELETEBrandingsIdFormat");
            
    
            var path = "/brandings/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DELETEBrandingsIdFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DELETEBrandingsIdFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Deletes a branding resource  
        /// </summary>
        /// <param name="id">Branding id </param> 
        /// <param name="resourceName"> </param> 
        /// <returns></returns>            
        public void DELETEBrandingsIdresourceNameFormat (int? id, string resourceName)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DELETEBrandingsIdresourceNameFormat");
            
    
            var path = "/brandings/{id}/*resource_name";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (resourceName != null) queryParams.Add("resource_name", ApiClient.ParameterToString(resourceName)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DELETEBrandingsIdresourceNameFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DELETEBrandingsIdresourceNameFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get brandings  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="except">Specifies which attributes to skip. Default is ‘resources.data’ </param> 
        /// <param name="only">Specifies which attributes to include. (Overrides except default) </param> 
        /// <param name="page">Pagination page. Default is 1 </param> 
        /// <param name="pageSize">Items per page. Default is 20 </param> 
        /// <param name="sortBy">Property to sort by </param> 
        /// <param name="sortDir">Sort direction </param> 
        /// <returns>Branding</returns>            
        public Branding GETBrandingsFormat (string acceptVersion, string authorization, string except, string only, int? page, int? pageSize, string sortBy, string sortDir)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETBrandingsFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETBrandingsFormat");
            
    
            var path = "/brandings";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (except != null) queryParams.Add("except", ApiClient.ParameterToString(except)); // query parameter
 if (only != null) queryParams.Add("only", ApiClient.ParameterToString(only)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETBrandingsFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETBrandingsFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Branding) ApiClient.Deserialize(response.Content, typeof(Branding), response.Headers);
        }
    
        /// <summary>
        /// Get a branding  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="id">Branding id </param> 
        /// <param name="except">Specifies which attributes to skip. Default is ‘resources.data’ </param> 
        /// <param name="only">Specifies which attributes to include. (Overrides except default) </param> 
        /// <returns>Branding</returns>            
        public Branding GETBrandingsIdFormat (string acceptVersion, string authorization, int? id, string except, string only)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETBrandingsIdFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETBrandingsIdFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GETBrandingsIdFormat");
            
    
            var path = "/brandings/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (except != null) queryParams.Add("except", ApiClient.ParameterToString(except)); // query parameter
 if (only != null) queryParams.Add("only", ApiClient.ParameterToString(only)); // query parameter
             if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETBrandingsIdFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETBrandingsIdFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Branding) ApiClient.Deserialize(response.Content, typeof(Branding), response.Headers);
        }
    
        /// <summary>
        /// Gets a branding resource as a file  
        /// </summary>
        /// <param name="id">Branding id </param> 
        /// <param name="resourceName"> </param> 
        /// <returns></returns>            
        public void GETBrandingsIdresourceNameFormat (int? id, string resourceName)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GETBrandingsIdresourceNameFormat");
            
    
            var path = "/brandings/{id}/*resource_name";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (resourceName != null) queryParams.Add("resource_name", ApiClient.ParameterToString(resourceName)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETBrandingsIdresourceNameFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETBrandingsIdresourceNameFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update a branding  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="id">Branding id </param> 
        /// <param name="name">Descriptive name of the branding </param> 
        /// <param name="except">Specifies which attributes to skip. Default is ‘resources.data’ </param> 
        /// <param name="only">Specifies which attributes to include. (Overrides except default) </param> 
        /// <returns>Branding</returns>            
        public Branding PATCHBrandingsIdFormat (string acceptVersion, string authorization, int? id, string name, string except, string only)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PATCHBrandingsIdFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PATCHBrandingsIdFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PATCHBrandingsIdFormat");
            
    
            var path = "/brandings/{id}";
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
if (except != null) formParams.Add("except", ApiClient.ParameterToString(except)); // form parameter
if (only != null) formParams.Add("only", ApiClient.ParameterToString(only)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHBrandingsIdFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHBrandingsIdFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Branding) ApiClient.Deserialize(response.Content, typeof(Branding), response.Headers);
        }
    
        /// <summary>
        /// Create a branding  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="name">Descriptive name of the branding </param> 
        /// <returns>Branding</returns>            
        public Branding POSTBrandingsFormat (string acceptVersion, string authorization, string name)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling POSTBrandingsFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling POSTBrandingsFormat");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling POSTBrandingsFormat");
            
    
            var path = "/brandings";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
            if (name != null) formParams.Add("name", ApiClient.ParameterToString(name)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTBrandingsFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTBrandingsFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Branding) ApiClient.Deserialize(response.Content, typeof(Branding), response.Headers);
        }
    
        /// <summary>
        /// Copies branding and returns the new branding  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="id">Branding id </param> 
        /// <param name="except">Specifies which attributes to skip. Default is ‘resources.data’ </param> 
        /// <param name="only">Specifies which attributes to include. (Overrides except default) </param> 
        /// <returns>Branding</returns>            
        public Branding POSTBrandingsIdCopyFormat (string acceptVersion, string authorization, int? id, string except, string only)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling POSTBrandingsIdCopyFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling POSTBrandingsIdCopyFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling POSTBrandingsIdCopyFormat");
            
    
            var path = "/brandings/{id}/copy";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
            if (except != null) formParams.Add("except", ApiClient.ParameterToString(except)); // form parameter
if (only != null) formParams.Add("only", ApiClient.ParameterToString(only)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTBrandingsIdCopyFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTBrandingsIdCopyFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Branding) ApiClient.Deserialize(response.Content, typeof(Branding), response.Headers);
        }
    
        /// <summary>
        /// Uploads a file and creates or replaces a resource  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="id">Branding id </param> 
        /// <param name="_file">The file send as multipart </param> 
        /// <param name="resourceName"> </param> 
        /// <returns></returns>            
        public void PUTBrandingsIdresourceNameFormat (string acceptVersion, string authorization, int? id, string _file, string resourceName)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PUTBrandingsIdresourceNameFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PUTBrandingsIdresourceNameFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PUTBrandingsIdresourceNameFormat");
            
            // verify the required parameter '_file' is set
            if (_file == null) throw new ApiException(400, "Missing required parameter '_file' when calling PUTBrandingsIdresourceNameFormat");
            
    
            var path = "/brandings/{id}/*resource_name";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
            if (_file != null) formParams.Add("file", ApiClient.ParameterToString(_file)); // form parameter
if (resourceName != null) formParams.Add("resource_name", ApiClient.ParameterToString(resourceName)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTBrandingsIdresourceNameFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTBrandingsIdresourceNameFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
