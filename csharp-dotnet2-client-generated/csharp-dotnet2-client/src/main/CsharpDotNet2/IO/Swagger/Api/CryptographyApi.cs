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
    public interface ICryptographyApi
    {
        /// <summary>
        /// Delete certificate  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="id"> </param>
        /// <returns></returns>
        void DELETECryptographyKeysIdCertificateFormat (string acceptVersion, string authorization, int? id);
        /// <summary>
        /// Delete key  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="id"> </param>
        /// <returns></returns>
        void DELETECryptographyKeysIdFormat (string acceptVersion, string authorization, int? id);
        /// <summary>
        /// Get keys  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="type"> </param>
        /// <param name="query"> </param>
        /// <param name="sortBy">&lt;p&gt;Property to sort by&lt;/p&gt; </param>
        /// <param name="sortDir">&lt;p&gt;Sort direction&lt;/p&gt; </param>
        /// <param name="pageSize">&lt;p&gt;Items per page. Default is 20&lt;/p&gt; </param>
        /// <param name="pageKey"> </param>
        /// <returns>QuickPayProtocolV10MerchantCryptographyKey</returns>
        QuickPayProtocolV10MerchantCryptographyKey GETCryptographyKeysFormat (string acceptVersion, string authorization, string type, string query, string sortBy, string sortDir, int? pageSize, int? pageKey);
        /// <summary>
        /// Get certificate  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="id"> </param>
        /// <returns></returns>
        void GETCryptographyKeysIdCertificateFormat (string acceptVersion, string authorization, int? id);
        /// <summary>
        /// Get key  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="id"> </param>
        /// <returns>QuickPayProtocolV10MerchantCryptographyKey</returns>
        QuickPayProtocolV10MerchantCryptographyKey GETCryptographyKeysIdFormat (string acceptVersion, string authorization, int? id);
        /// <summary>
        /// update key  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="id"> </param>
        /// <param name="shortDescription"> </param>
        /// <returns>QuickPayProtocolV10MerchantCryptographyKey</returns>
        QuickPayProtocolV10MerchantCryptographyKey PATCHCryptographyKeysIdFormat (string acceptVersion, string authorization, int? id, string shortDescription);
        /// <summary>
        /// Create key  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="type"> </param>
        /// <param name="shortDescription"> </param>
        /// <param name="keySize"> </param>
        /// <param name="curve"> </param>
        /// <returns>QuickPayProtocolV10MerchantCryptographyKey</returns>
        QuickPayProtocolV10MerchantCryptographyKey POSTCryptographyKeysFormat (string acceptVersion, string authorization, string type, string shortDescription, int? keySize, string curve);
        /// <summary>
        /// Create certificate request (CSR)  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="id"> </param>
        /// <param name="subjectKey"> </param>
        /// <param name="subjectValue"> </param>
        /// <param name="subjectEncoding"> </param>
        /// <returns></returns>
        void POSTCryptographyKeysIdCsrFormat (string acceptVersion, string authorization, int? id, string subjectKey, string subjectValue, string subjectEncoding);
        /// <summary>
        /// Replace certificate  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="id"> </param>
        /// <param name="_file">&lt;p&gt;The file send as multipart&lt;/p&gt; </param>
        /// <returns></returns>
        void PUTCryptographyKeysIdCertificateFormat (string acceptVersion, string authorization, int? id, ModelFile _file);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CryptographyApi : ICryptographyApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CryptographyApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CryptographyApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CryptographyApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CryptographyApi(String basePath)
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
        /// Delete certificate  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="id"> </param> 
        /// <returns></returns>            
        public void DELETECryptographyKeysIdCertificateFormat (string acceptVersion, string authorization, int? id)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling DELETECryptographyKeysIdCertificateFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling DELETECryptographyKeysIdCertificateFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DELETECryptographyKeysIdCertificateFormat");
            
    
            var path = "/cryptography/keys/{id}/certificate";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DELETECryptographyKeysIdCertificateFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DELETECryptographyKeysIdCertificateFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete key  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="id"> </param> 
        /// <returns></returns>            
        public void DELETECryptographyKeysIdFormat (string acceptVersion, string authorization, int? id)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling DELETECryptographyKeysIdFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling DELETECryptographyKeysIdFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DELETECryptographyKeysIdFormat");
            
    
            var path = "/cryptography/keys/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DELETECryptographyKeysIdFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DELETECryptographyKeysIdFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get keys  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="type"> </param> 
        /// <param name="query"> </param> 
        /// <param name="sortBy">&lt;p&gt;Property to sort by&lt;/p&gt; </param> 
        /// <param name="sortDir">&lt;p&gt;Sort direction&lt;/p&gt; </param> 
        /// <param name="pageSize">&lt;p&gt;Items per page. Default is 20&lt;/p&gt; </param> 
        /// <param name="pageKey"> </param> 
        /// <returns>QuickPayProtocolV10MerchantCryptographyKey</returns>            
        public QuickPayProtocolV10MerchantCryptographyKey GETCryptographyKeysFormat (string acceptVersion, string authorization, string type, string query, string sortBy, string sortDir, int? pageSize, int? pageKey)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETCryptographyKeysFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETCryptographyKeysFormat");
            
    
            var path = "/cryptography/keys";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (type != null) queryParams.Add("type", ApiClient.ParameterToString(type)); // query parameter
 if (query != null) queryParams.Add("query", ApiClient.ParameterToString(query)); // query parameter
 if (sortBy != null) queryParams.Add("sort_by", ApiClient.ParameterToString(sortBy)); // query parameter
 if (sortDir != null) queryParams.Add("sort_dir", ApiClient.ParameterToString(sortDir)); // query parameter
 if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
 if (pageKey != null) queryParams.Add("page_key", ApiClient.ParameterToString(pageKey)); // query parameter
             if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETCryptographyKeysFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETCryptographyKeysFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10MerchantCryptographyKey) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10MerchantCryptographyKey), response.Headers);
        }
    
        /// <summary>
        /// Get certificate  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="id"> </param> 
        /// <returns></returns>            
        public void GETCryptographyKeysIdCertificateFormat (string acceptVersion, string authorization, int? id)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETCryptographyKeysIdCertificateFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETCryptographyKeysIdCertificateFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GETCryptographyKeysIdCertificateFormat");
            
    
            var path = "/cryptography/keys/{id}/certificate";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETCryptographyKeysIdCertificateFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETCryptographyKeysIdCertificateFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get key  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="id"> </param> 
        /// <returns>QuickPayProtocolV10MerchantCryptographyKey</returns>            
        public QuickPayProtocolV10MerchantCryptographyKey GETCryptographyKeysIdFormat (string acceptVersion, string authorization, int? id)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETCryptographyKeysIdFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETCryptographyKeysIdFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GETCryptographyKeysIdFormat");
            
    
            var path = "/cryptography/keys/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETCryptographyKeysIdFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETCryptographyKeysIdFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10MerchantCryptographyKey) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10MerchantCryptographyKey), response.Headers);
        }
    
        /// <summary>
        /// update key  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="id"> </param> 
        /// <param name="shortDescription"> </param> 
        /// <returns>QuickPayProtocolV10MerchantCryptographyKey</returns>            
        public QuickPayProtocolV10MerchantCryptographyKey PATCHCryptographyKeysIdFormat (string acceptVersion, string authorization, int? id, string shortDescription)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PATCHCryptographyKeysIdFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PATCHCryptographyKeysIdFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PATCHCryptographyKeysIdFormat");
            
    
            var path = "/cryptography/keys/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
            if (shortDescription != null) formParams.Add("short_description", ApiClient.ParameterToString(shortDescription)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHCryptographyKeysIdFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHCryptographyKeysIdFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10MerchantCryptographyKey) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10MerchantCryptographyKey), response.Headers);
        }
    
        /// <summary>
        /// Create key  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="type"> </param> 
        /// <param name="shortDescription"> </param> 
        /// <param name="keySize"> </param> 
        /// <param name="curve"> </param> 
        /// <returns>QuickPayProtocolV10MerchantCryptographyKey</returns>            
        public QuickPayProtocolV10MerchantCryptographyKey POSTCryptographyKeysFormat (string acceptVersion, string authorization, string type, string shortDescription, int? keySize, string curve)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling POSTCryptographyKeysFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling POSTCryptographyKeysFormat");
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling POSTCryptographyKeysFormat");
            
            // verify the required parameter 'shortDescription' is set
            if (shortDescription == null) throw new ApiException(400, "Missing required parameter 'shortDescription' when calling POSTCryptographyKeysFormat");
            
            // verify the required parameter 'keySize' is set
            if (keySize == null) throw new ApiException(400, "Missing required parameter 'keySize' when calling POSTCryptographyKeysFormat");
            
            // verify the required parameter 'curve' is set
            if (curve == null) throw new ApiException(400, "Missing required parameter 'curve' when calling POSTCryptographyKeysFormat");
            
    
            var path = "/cryptography/keys";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
            if (type != null) formParams.Add("type", ApiClient.ParameterToString(type)); // form parameter
if (shortDescription != null) formParams.Add("short_description", ApiClient.ParameterToString(shortDescription)); // form parameter
if (keySize != null) formParams.Add("key_size", ApiClient.ParameterToString(keySize)); // form parameter
if (curve != null) formParams.Add("curve", ApiClient.ParameterToString(curve)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTCryptographyKeysFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTCryptographyKeysFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10MerchantCryptographyKey) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10MerchantCryptographyKey), response.Headers);
        }
    
        /// <summary>
        /// Create certificate request (CSR)  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="id"> </param> 
        /// <param name="subjectKey"> </param> 
        /// <param name="subjectValue"> </param> 
        /// <param name="subjectEncoding"> </param> 
        /// <returns></returns>            
        public void POSTCryptographyKeysIdCsrFormat (string acceptVersion, string authorization, int? id, string subjectKey, string subjectValue, string subjectEncoding)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling POSTCryptographyKeysIdCsrFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling POSTCryptographyKeysIdCsrFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling POSTCryptographyKeysIdCsrFormat");
            
            // verify the required parameter 'subjectKey' is set
            if (subjectKey == null) throw new ApiException(400, "Missing required parameter 'subjectKey' when calling POSTCryptographyKeysIdCsrFormat");
            
            // verify the required parameter 'subjectValue' is set
            if (subjectValue == null) throw new ApiException(400, "Missing required parameter 'subjectValue' when calling POSTCryptographyKeysIdCsrFormat");
            
            // verify the required parameter 'subjectEncoding' is set
            if (subjectEncoding == null) throw new ApiException(400, "Missing required parameter 'subjectEncoding' when calling POSTCryptographyKeysIdCsrFormat");
            
    
            var path = "/cryptography/keys/{id}/csr";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
            if (subjectKey != null) formParams.Add("subject[][key]", ApiClient.ParameterToString(subjectKey)); // form parameter
if (subjectValue != null) formParams.Add("subject[][value]", ApiClient.ParameterToString(subjectValue)); // form parameter
if (subjectEncoding != null) formParams.Add("subject[][encoding]", ApiClient.ParameterToString(subjectEncoding)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTCryptographyKeysIdCsrFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTCryptographyKeysIdCsrFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Replace certificate  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="id"> </param> 
        /// <param name="_file">&lt;p&gt;The file send as multipart&lt;/p&gt; </param> 
        /// <returns></returns>            
        public void PUTCryptographyKeysIdCertificateFormat (string acceptVersion, string authorization, int? id, ModelFile _file)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PUTCryptographyKeysIdCertificateFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PUTCryptographyKeysIdCertificateFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PUTCryptographyKeysIdCertificateFormat");
            
            // verify the required parameter '_file' is set
            if (_file == null) throw new ApiException(400, "Missing required parameter '_file' when calling PUTCryptographyKeysIdCertificateFormat");
            
    
            var path = "/cryptography/keys/{id}/certificate";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
                        postBody = ApiClient.Serialize(_file); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTCryptographyKeysIdCertificateFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTCryptographyKeysIdCertificateFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
