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
    public interface IAgreementsApi
    {
        /// <summary>
        /// Delete agreement  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Agreement id </param>
        /// <returns></returns>
        void DELETEAgreementsIdFormat (string acceptVersion, string authorization, int? id);
        /// <summary>
        /// Get agreements  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="page">Pagination page. Default is 1 </param>
        /// <param name="pageSize">Items per page. Default is 20 </param>
        /// <param name="sortBy">Property to sort by </param>
        /// <param name="sortDir">Sort direction </param>
        /// <param name="pageKey"> </param>
        /// <param name="support">Return only or filter out support agreements </param>
        /// <param name="service">Filter by system agreement service name </param>
        /// <param name="me">If set, only show the agreement of the caller </param>
        /// <param name="accountId">If set, shows agreements for another account if current account has access. </param>
        /// <returns>Agreement</returns>
        Agreement GETAgreementsFormat (string acceptVersion, string authorization, int? page, int? pageSize, string sortBy, string sortDir, int? pageKey, bool? support, string service, bool? me, int? accountId);
        /// <summary>
        /// Get agreement activity  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Agreement id </param>
        /// <param name="page">Pagination page. Default is 1 </param>
        /// <param name="pageSize">Items per page. Default is 20 </param>
        /// <param name="sortBy">Property to sort by </param>
        /// <param name="sortDir">Sort direction </param>
        /// <returns>Activity</returns>
        Activity GETAgreementsIdActivityFormat (string acceptVersion, string authorization, int? id, int? page, int? pageSize, string sortBy, string sortDir);
        /// <summary>
        /// Get agreement  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Agreement id </param>
        /// <returns>Agreement</returns>
        Agreement GETAgreementsIdFormat (string acceptVersion, string authorization, int? id);
        /// <summary>
        /// Regenerate the API key for this agreement  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Agreement id </param>
        /// <returns>Agreement</returns>
        Agreement PATCHAgreementsIdApiKeyFormat (string acceptVersion, string authorization, int? id);
        /// <summary>
        /// Update agreement  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Agreement id </param>
        /// <param name="ipRestrictionAddress">IP address </param>
        /// <param name="owner">Is account owner </param>
        /// <param name="description">Description of the account </param>
        /// <returns>Agreement</returns>
        Agreement PATCHAgreementsIdFormat (string acceptVersion, string authorization, int? id, string ipRestrictionAddress, bool? owner, string description);
        /// <summary>
        /// Create agreement  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="aclPermissionsResource">Resource uri </param>
        /// <param name="ipRestrictionAddress">IP address </param>
        /// <param name="userEmail">Email of the user to invite to this account. Only one of user_email and system_user can be specified. </param>
        /// <param name="systemUser">Create a new system user with this name. Only one of user_email and system_user can be specified. </param>
        /// <param name="owner">Is account owner. Default is false </param>
        /// <param name="description">Description of the account </param>
        /// <param name="aclPermissionsGet">Allow GET </param>
        /// <param name="aclPermissionsPost">Allow POST </param>
        /// <param name="aclPermissionsPut">Allow PUT </param>
        /// <param name="aclPermissionsDelete">Allow DELETE </param>
        /// <param name="aclPermissionsPatch">Allow PATCH </param>
        /// <returns>Agreement</returns>
        Agreement POSTAgreementsFormat (string acceptVersion, string authorization, string aclPermissionsResource, string ipRestrictionAddress, string userEmail, string systemUser, bool? owner, string description, bool? aclPermissionsGet, bool? aclPermissionsPost, bool? aclPermissionsPut, bool? aclPermissionsDelete, bool? aclPermissionsPatch);
        /// <summary>
        /// Replace agreement  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Agreement id </param>
        /// <param name="aclPermissionsResource">Resource uri </param>
        /// <param name="ipRestrictionAddress">IP address </param>
        /// <param name="owner">Is account owner </param>
        /// <param name="description">Description of the account </param>
        /// <param name="aclPermissionsGet">Allow GET </param>
        /// <param name="aclPermissionsPost">Allow POST </param>
        /// <param name="aclPermissionsPut">Allow PUT </param>
        /// <param name="aclPermissionsDelete">Allow DELETE </param>
        /// <param name="aclPermissionsPatch">Allow PATCH </param>
        /// <returns>Agreement</returns>
        Agreement PUTAgreementsIdFormat (string acceptVersion, string authorization, int? id, string aclPermissionsResource, string ipRestrictionAddress, bool? owner, string description, bool? aclPermissionsGet, bool? aclPermissionsPost, bool? aclPermissionsPut, bool? aclPermissionsDelete, bool? aclPermissionsPatch);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AgreementsApi : IAgreementsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgreementsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AgreementsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AgreementsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AgreementsApi(String basePath)
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
        /// Delete agreement  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="id">Agreement id </param> 
        /// <returns></returns>            
        public void DELETEAgreementsIdFormat (string acceptVersion, string authorization, int? id)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling DELETEAgreementsIdFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling DELETEAgreementsIdFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DELETEAgreementsIdFormat");
            
    
            var path = "/agreements/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DELETEAgreementsIdFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DELETEAgreementsIdFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get agreements  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="page">Pagination page. Default is 1 </param> 
        /// <param name="pageSize">Items per page. Default is 20 </param> 
        /// <param name="sortBy">Property to sort by </param> 
        /// <param name="sortDir">Sort direction </param> 
        /// <param name="pageKey"> </param> 
        /// <param name="support">Return only or filter out support agreements </param> 
        /// <param name="service">Filter by system agreement service name </param> 
        /// <param name="me">If set, only show the agreement of the caller </param> 
        /// <param name="accountId">If set, shows agreements for another account if current account has access. </param> 
        /// <returns>Agreement</returns>            
        public Agreement GETAgreementsFormat (string acceptVersion, string authorization, int? page, int? pageSize, string sortBy, string sortDir, int? pageKey, bool? support, string service, bool? me, int? accountId)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETAgreementsFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETAgreementsFormat");
            
    
            var path = "/agreements";
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
 if (pageKey != null) queryParams.Add("page_key", ApiClient.ParameterToString(pageKey)); // query parameter
 if (support != null) queryParams.Add("support", ApiClient.ParameterToString(support)); // query parameter
 if (service != null) queryParams.Add("service", ApiClient.ParameterToString(service)); // query parameter
 if (me != null) queryParams.Add("me", ApiClient.ParameterToString(me)); // query parameter
 if (accountId != null) queryParams.Add("account_id", ApiClient.ParameterToString(accountId)); // query parameter
             if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAgreementsFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAgreementsFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Agreement) ApiClient.Deserialize(response.Content, typeof(Agreement), response.Headers);
        }
    
        /// <summary>
        /// Get agreement activity  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="id">Agreement id </param> 
        /// <param name="page">Pagination page. Default is 1 </param> 
        /// <param name="pageSize">Items per page. Default is 20 </param> 
        /// <param name="sortBy">Property to sort by </param> 
        /// <param name="sortDir">Sort direction </param> 
        /// <returns>Activity</returns>            
        public Activity GETAgreementsIdActivityFormat (string acceptVersion, string authorization, int? id, int? page, int? pageSize, string sortBy, string sortDir)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETAgreementsIdActivityFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETAgreementsIdActivityFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GETAgreementsIdActivityFormat");
            
    
            var path = "/agreements/{id}/activity";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETAgreementsIdActivityFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAgreementsIdActivityFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Activity) ApiClient.Deserialize(response.Content, typeof(Activity), response.Headers);
        }
    
        /// <summary>
        /// Get agreement  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="id">Agreement id </param> 
        /// <returns>Agreement</returns>            
        public Agreement GETAgreementsIdFormat (string acceptVersion, string authorization, int? id)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETAgreementsIdFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETAgreementsIdFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GETAgreementsIdFormat");
            
    
            var path = "/agreements/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETAgreementsIdFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETAgreementsIdFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Agreement) ApiClient.Deserialize(response.Content, typeof(Agreement), response.Headers);
        }
    
        /// <summary>
        /// Regenerate the API key for this agreement  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="id">Agreement id </param> 
        /// <returns>Agreement</returns>            
        public Agreement PATCHAgreementsIdApiKeyFormat (string acceptVersion, string authorization, int? id)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PATCHAgreementsIdApiKeyFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PATCHAgreementsIdApiKeyFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PATCHAgreementsIdApiKeyFormat");
            
    
            var path = "/agreements/{id}/api-key";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAgreementsIdApiKeyFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAgreementsIdApiKeyFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Agreement) ApiClient.Deserialize(response.Content, typeof(Agreement), response.Headers);
        }
    
        /// <summary>
        /// Update agreement  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="id">Agreement id </param> 
        /// <param name="ipRestrictionAddress">IP address </param> 
        /// <param name="owner">Is account owner </param> 
        /// <param name="description">Description of the account </param> 
        /// <returns>Agreement</returns>            
        public Agreement PATCHAgreementsIdFormat (string acceptVersion, string authorization, int? id, string ipRestrictionAddress, bool? owner, string description)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PATCHAgreementsIdFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PATCHAgreementsIdFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PATCHAgreementsIdFormat");
            
            // verify the required parameter 'ipRestrictionAddress' is set
            if (ipRestrictionAddress == null) throw new ApiException(400, "Missing required parameter 'ipRestrictionAddress' when calling PATCHAgreementsIdFormat");
            
    
            var path = "/agreements/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
            if (owner != null) formParams.Add("owner", ApiClient.ParameterToString(owner)); // form parameter
if (description != null) formParams.Add("description", ApiClient.ParameterToString(description)); // form parameter
if (ipRestrictionAddress != null) formParams.Add("ip_restriction[][address]", ApiClient.ParameterToString(ipRestrictionAddress)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAgreementsIdFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHAgreementsIdFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Agreement) ApiClient.Deserialize(response.Content, typeof(Agreement), response.Headers);
        }
    
        /// <summary>
        /// Create agreement  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="aclPermissionsResource">Resource uri </param> 
        /// <param name="ipRestrictionAddress">IP address </param> 
        /// <param name="userEmail">Email of the user to invite to this account. Only one of user_email and system_user can be specified. </param> 
        /// <param name="systemUser">Create a new system user with this name. Only one of user_email and system_user can be specified. </param> 
        /// <param name="owner">Is account owner. Default is false </param> 
        /// <param name="description">Description of the account </param> 
        /// <param name="aclPermissionsGet">Allow GET </param> 
        /// <param name="aclPermissionsPost">Allow POST </param> 
        /// <param name="aclPermissionsPut">Allow PUT </param> 
        /// <param name="aclPermissionsDelete">Allow DELETE </param> 
        /// <param name="aclPermissionsPatch">Allow PATCH </param> 
        /// <returns>Agreement</returns>            
        public Agreement POSTAgreementsFormat (string acceptVersion, string authorization, string aclPermissionsResource, string ipRestrictionAddress, string userEmail, string systemUser, bool? owner, string description, bool? aclPermissionsGet, bool? aclPermissionsPost, bool? aclPermissionsPut, bool? aclPermissionsDelete, bool? aclPermissionsPatch)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling POSTAgreementsFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling POSTAgreementsFormat");
            
            // verify the required parameter 'aclPermissionsResource' is set
            if (aclPermissionsResource == null) throw new ApiException(400, "Missing required parameter 'aclPermissionsResource' when calling POSTAgreementsFormat");
            
            // verify the required parameter 'ipRestrictionAddress' is set
            if (ipRestrictionAddress == null) throw new ApiException(400, "Missing required parameter 'ipRestrictionAddress' when calling POSTAgreementsFormat");
            
    
            var path = "/agreements";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
            if (userEmail != null) formParams.Add("user_email", ApiClient.ParameterToString(userEmail)); // form parameter
if (systemUser != null) formParams.Add("system_user", ApiClient.ParameterToString(systemUser)); // form parameter
if (owner != null) formParams.Add("owner", ApiClient.ParameterToString(owner)); // form parameter
if (description != null) formParams.Add("description", ApiClient.ParameterToString(description)); // form parameter
if (aclPermissionsResource != null) formParams.Add("acl_permissions[][resource]", ApiClient.ParameterToString(aclPermissionsResource)); // form parameter
if (aclPermissionsGet != null) formParams.Add("acl_permissions[][get]", ApiClient.ParameterToString(aclPermissionsGet)); // form parameter
if (aclPermissionsPost != null) formParams.Add("acl_permissions[][post]", ApiClient.ParameterToString(aclPermissionsPost)); // form parameter
if (aclPermissionsPut != null) formParams.Add("acl_permissions[][put]", ApiClient.ParameterToString(aclPermissionsPut)); // form parameter
if (aclPermissionsDelete != null) formParams.Add("acl_permissions[][delete]", ApiClient.ParameterToString(aclPermissionsDelete)); // form parameter
if (aclPermissionsPatch != null) formParams.Add("acl_permissions[][patch]", ApiClient.ParameterToString(aclPermissionsPatch)); // form parameter
if (ipRestrictionAddress != null) formParams.Add("ip_restriction[][address]", ApiClient.ParameterToString(ipRestrictionAddress)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTAgreementsFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTAgreementsFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Agreement) ApiClient.Deserialize(response.Content, typeof(Agreement), response.Headers);
        }
    
        /// <summary>
        /// Replace agreement  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="id">Agreement id </param> 
        /// <param name="aclPermissionsResource">Resource uri </param> 
        /// <param name="ipRestrictionAddress">IP address </param> 
        /// <param name="owner">Is account owner </param> 
        /// <param name="description">Description of the account </param> 
        /// <param name="aclPermissionsGet">Allow GET </param> 
        /// <param name="aclPermissionsPost">Allow POST </param> 
        /// <param name="aclPermissionsPut">Allow PUT </param> 
        /// <param name="aclPermissionsDelete">Allow DELETE </param> 
        /// <param name="aclPermissionsPatch">Allow PATCH </param> 
        /// <returns>Agreement</returns>            
        public Agreement PUTAgreementsIdFormat (string acceptVersion, string authorization, int? id, string aclPermissionsResource, string ipRestrictionAddress, bool? owner, string description, bool? aclPermissionsGet, bool? aclPermissionsPost, bool? aclPermissionsPut, bool? aclPermissionsDelete, bool? aclPermissionsPatch)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PUTAgreementsIdFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PUTAgreementsIdFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PUTAgreementsIdFormat");
            
            // verify the required parameter 'aclPermissionsResource' is set
            if (aclPermissionsResource == null) throw new ApiException(400, "Missing required parameter 'aclPermissionsResource' when calling PUTAgreementsIdFormat");
            
            // verify the required parameter 'ipRestrictionAddress' is set
            if (ipRestrictionAddress == null) throw new ApiException(400, "Missing required parameter 'ipRestrictionAddress' when calling PUTAgreementsIdFormat");
            
    
            var path = "/agreements/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
            if (owner != null) formParams.Add("owner", ApiClient.ParameterToString(owner)); // form parameter
if (description != null) formParams.Add("description", ApiClient.ParameterToString(description)); // form parameter
if (aclPermissionsResource != null) formParams.Add("acl_permissions[][resource]", ApiClient.ParameterToString(aclPermissionsResource)); // form parameter
if (aclPermissionsGet != null) formParams.Add("acl_permissions[][get]", ApiClient.ParameterToString(aclPermissionsGet)); // form parameter
if (aclPermissionsPost != null) formParams.Add("acl_permissions[][post]", ApiClient.ParameterToString(aclPermissionsPost)); // form parameter
if (aclPermissionsPut != null) formParams.Add("acl_permissions[][put]", ApiClient.ParameterToString(aclPermissionsPut)); // form parameter
if (aclPermissionsDelete != null) formParams.Add("acl_permissions[][delete]", ApiClient.ParameterToString(aclPermissionsDelete)); // form parameter
if (aclPermissionsPatch != null) formParams.Add("acl_permissions[][patch]", ApiClient.ParameterToString(aclPermissionsPatch)); // form parameter
if (ipRestrictionAddress != null) formParams.Add("ip_restriction[][address]", ApiClient.ParameterToString(ipRestrictionAddress)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTAgreementsIdFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTAgreementsIdFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Agreement) ApiClient.Deserialize(response.Content, typeof(Agreement), response.Headers);
        }
    
    }
}
