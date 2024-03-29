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
    public interface IFraudRulesetsApi
    {
        /// <summary>
        /// Delete ruleset  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Ruleset id </param>
        /// <returns>FraudRuleset</returns>
        FraudRuleset DELETEFraudRulesetsIdFormat (string acceptVersion, string authorization, int? id);
        /// <summary>
        /// Get custom defined fraud rulesets  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <returns>FraudRuleset</returns>
        FraudRuleset GETFraudRulesetsFormat (string acceptVersion, string authorization);
        /// <summary>
        /// Get ruleset by id  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Ruleset id </param>
        /// <returns>FraudRuleset</returns>
        FraudRuleset GETFraudRulesetsIdFormat (string acceptVersion, string authorization, int? id);
        /// <summary>
        /// Update a ruleset  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Ruleset id </param>
        /// <param name="filterRulesMetricName">Name af variable metric </param>
        /// <param name="filterRulesOperator">Operator </param>
        /// <param name="filterRulesValue">String representation of the value to compare to the metric </param>
        /// <param name="name">Descriptive name </param>
        /// <param name="action">Action to take when ruleset triggers </param>
        /// <param name="combinator">Method to combine filter rules </param>
        /// <returns>FraudRuleset</returns>
        FraudRuleset PATCHFraudRulesetsIdFormat (string acceptVersion, string authorization, int? id, string filterRulesMetricName, string filterRulesOperator, string filterRulesValue, string name, string action, string combinator);
        /// <summary>
        /// Create a custom fraud ruleset  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="name">Descriptive name </param>
        /// <param name="filterRulesMetricName">Name af variable metric </param>
        /// <param name="filterRulesOperator">Operator </param>
        /// <param name="filterRulesValue">String representation of the value to compare to the metric, e.g. ‘DNK’, ‘42’ or ‘DNK, DEU’ </param>
        /// <param name="action">Action to take when ruleset triggers </param>
        /// <param name="combinator">Method to combine filter rules </param>
        /// <returns>FraudRuleset</returns>
        FraudRuleset POSTFraudRulesetsFormat (string acceptVersion, string authorization, string name, string filterRulesMetricName, string filterRulesOperator, string filterRulesValue, string action, string combinator);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class FraudRulesetsApi : IFraudRulesetsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FraudRulesetsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public FraudRulesetsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FraudRulesetsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FraudRulesetsApi(String basePath)
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
        /// Delete ruleset  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="id">Ruleset id </param> 
        /// <returns>FraudRuleset</returns>            
        public FraudRuleset DELETEFraudRulesetsIdFormat (string acceptVersion, string authorization, int? id)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling DELETEFraudRulesetsIdFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling DELETEFraudRulesetsIdFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DELETEFraudRulesetsIdFormat");
            
    
            var path = "/fraud-rulesets/{id}";
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
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Delete, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DELETEFraudRulesetsIdFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DELETEFraudRulesetsIdFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FraudRuleset) ApiClient.Deserialize(response.Content, typeof(FraudRuleset), response.Headers);
        }
    
        /// <summary>
        /// Get custom defined fraud rulesets  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <returns>FraudRuleset</returns>            
        public FraudRuleset GETFraudRulesetsFormat (string acceptVersion, string authorization)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETFraudRulesetsFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETFraudRulesetsFormat");
            
    
            var path = "/fraud-rulesets";
            path = path.Replace("{format}", "json");
                
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
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETFraudRulesetsFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETFraudRulesetsFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FraudRuleset) ApiClient.Deserialize(response.Content, typeof(FraudRuleset), response.Headers);
        }
    
        /// <summary>
        /// Get ruleset by id  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="id">Ruleset id </param> 
        /// <returns>FraudRuleset</returns>            
        public FraudRuleset GETFraudRulesetsIdFormat (string acceptVersion, string authorization, int? id)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETFraudRulesetsIdFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETFraudRulesetsIdFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GETFraudRulesetsIdFormat");
            
    
            var path = "/fraud-rulesets/{id}";
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
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETFraudRulesetsIdFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETFraudRulesetsIdFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FraudRuleset) ApiClient.Deserialize(response.Content, typeof(FraudRuleset), response.Headers);
        }
    
        /// <summary>
        /// Update a ruleset  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="id">Ruleset id </param> 
        /// <param name="filterRulesMetricName">Name af variable metric </param> 
        /// <param name="filterRulesOperator">Operator </param> 
        /// <param name="filterRulesValue">String representation of the value to compare to the metric </param> 
        /// <param name="name">Descriptive name </param> 
        /// <param name="action">Action to take when ruleset triggers </param> 
        /// <param name="combinator">Method to combine filter rules </param> 
        /// <returns>FraudRuleset</returns>            
        public FraudRuleset PATCHFraudRulesetsIdFormat (string acceptVersion, string authorization, int? id, string filterRulesMetricName, string filterRulesOperator, string filterRulesValue, string name, string action, string combinator)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PATCHFraudRulesetsIdFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PATCHFraudRulesetsIdFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PATCHFraudRulesetsIdFormat");
            
            // verify the required parameter 'filterRulesMetricName' is set
            if (filterRulesMetricName == null) throw new ApiException(400, "Missing required parameter 'filterRulesMetricName' when calling PATCHFraudRulesetsIdFormat");
            
            // verify the required parameter 'filterRulesOperator' is set
            if (filterRulesOperator == null) throw new ApiException(400, "Missing required parameter 'filterRulesOperator' when calling PATCHFraudRulesetsIdFormat");
            
            // verify the required parameter 'filterRulesValue' is set
            if (filterRulesValue == null) throw new ApiException(400, "Missing required parameter 'filterRulesValue' when calling PATCHFraudRulesetsIdFormat");
            
    
            var path = "/fraud-rulesets/{id}";
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
if (filterRulesMetricName != null) formParams.Add("filter_rules[][metric_name]", ApiClient.ParameterToString(filterRulesMetricName)); // form parameter
if (filterRulesOperator != null) formParams.Add("filter_rules[][operator]", ApiClient.ParameterToString(filterRulesOperator)); // form parameter
if (filterRulesValue != null) formParams.Add("filter_rules[][value]", ApiClient.ParameterToString(filterRulesValue)); // form parameter
if (action != null) formParams.Add("action", ApiClient.ParameterToString(action)); // form parameter
if (combinator != null) formParams.Add("combinator", ApiClient.ParameterToString(combinator)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Patch, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHFraudRulesetsIdFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHFraudRulesetsIdFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FraudRuleset) ApiClient.Deserialize(response.Content, typeof(FraudRuleset), response.Headers);
        }
    
        /// <summary>
        /// Create a custom fraud ruleset  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="name">Descriptive name </param> 
        /// <param name="filterRulesMetricName">Name af variable metric </param> 
        /// <param name="filterRulesOperator">Operator </param> 
        /// <param name="filterRulesValue">String representation of the value to compare to the metric, e.g. ‘DNK’, ‘42’ or ‘DNK, DEU’ </param> 
        /// <param name="action">Action to take when ruleset triggers </param> 
        /// <param name="combinator">Method to combine filter rules </param> 
        /// <returns>FraudRuleset</returns>            
        public FraudRuleset POSTFraudRulesetsFormat (string acceptVersion, string authorization, string name, string filterRulesMetricName, string filterRulesOperator, string filterRulesValue, string action, string combinator)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling POSTFraudRulesetsFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling POSTFraudRulesetsFormat");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling POSTFraudRulesetsFormat");
            
            // verify the required parameter 'filterRulesMetricName' is set
            if (filterRulesMetricName == null) throw new ApiException(400, "Missing required parameter 'filterRulesMetricName' when calling POSTFraudRulesetsFormat");
            
            // verify the required parameter 'filterRulesOperator' is set
            if (filterRulesOperator == null) throw new ApiException(400, "Missing required parameter 'filterRulesOperator' when calling POSTFraudRulesetsFormat");
            
            // verify the required parameter 'filterRulesValue' is set
            if (filterRulesValue == null) throw new ApiException(400, "Missing required parameter 'filterRulesValue' when calling POSTFraudRulesetsFormat");
            
            // verify the required parameter 'action' is set
            if (action == null) throw new ApiException(400, "Missing required parameter 'action' when calling POSTFraudRulesetsFormat");
            
            // verify the required parameter 'combinator' is set
            if (combinator == null) throw new ApiException(400, "Missing required parameter 'combinator' when calling POSTFraudRulesetsFormat");
            
    
            var path = "/fraud-rulesets";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
            if (name != null) formParams.Add("name", ApiClient.ParameterToString(name)); // form parameter
if (filterRulesMetricName != null) formParams.Add("filter_rules[][metric_name]", ApiClient.ParameterToString(filterRulesMetricName)); // form parameter
if (filterRulesOperator != null) formParams.Add("filter_rules[][operator]", ApiClient.ParameterToString(filterRulesOperator)); // form parameter
if (filterRulesValue != null) formParams.Add("filter_rules[][value]", ApiClient.ParameterToString(filterRulesValue)); // form parameter
if (action != null) formParams.Add("action", ApiClient.ParameterToString(action)); // form parameter
if (combinator != null) formParams.Add("combinator", ApiClient.ParameterToString(combinator)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTFraudRulesetsFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTFraudRulesetsFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FraudRuleset) ApiClient.Deserialize(response.Content, typeof(FraudRuleset), response.Headers);
        }
    
    }
}
