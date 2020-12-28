/* 
 * Quickpay API v10
 *
 * <h2 id=\"authorization\">Authorization</h2>  Authorization is done using basic-auth. Authorization can be done with a user or an agreement.  <ul>   <li>When authorized with a user one is able to edit own settings, create new merchant or request access to existing merchant.</li>   <li>When authorized with an agreement one is able to perform anything on the account that agreement gives permissions to.</li> </ul>  
 *
 * OpenAPI spec version: 10.0
 * Contact: support@quickpay.net
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IActivityApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get activity
        /// </summary>
        /// <remarks>
        ///  
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="userId">Limit to activity by user_id  (optional)</param>
        /// <param name="targetType">Filter by target type, e.g. ‘Payment’  (optional)</param>
        /// <param name="targetId">Filter by target id, e.g. id of payment  (optional)</param>
        /// <param name="support">Filter by whether a support user made the activity  (optional)</param>
        /// <param name="page">Pagination page. Default is 1  (optional, default to 1)</param>
        /// <param name="pageSize">Items per page. Default is 20  (optional, default to 20)</param>
        /// <param name="sortBy">Property to sort by  (optional, default to created_at)</param>
        /// <param name="sortDir">Sort direction  (optional, default to desc)</param>
        /// <param name="pageKey">  (optional)</param>
        /// <returns>Activity</returns>
        Activity GETActivityFormat (string acceptVersion, string authorization, int? userId = null, string targetType = null, int? targetId = null, bool? support = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDir = null, string pageKey = null);

        /// <summary>
        /// Get activity
        /// </summary>
        /// <remarks>
        ///  
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="userId">Limit to activity by user_id  (optional)</param>
        /// <param name="targetType">Filter by target type, e.g. ‘Payment’  (optional)</param>
        /// <param name="targetId">Filter by target id, e.g. id of payment  (optional)</param>
        /// <param name="support">Filter by whether a support user made the activity  (optional)</param>
        /// <param name="page">Pagination page. Default is 1  (optional, default to 1)</param>
        /// <param name="pageSize">Items per page. Default is 20  (optional, default to 20)</param>
        /// <param name="sortBy">Property to sort by  (optional, default to created_at)</param>
        /// <param name="sortDir">Sort direction  (optional, default to desc)</param>
        /// <param name="pageKey">  (optional)</param>
        /// <returns>ApiResponse of Activity</returns>
        ApiResponse<Activity> GETActivityFormatWithHttpInfo (string acceptVersion, string authorization, int? userId = null, string targetType = null, int? targetId = null, bool? support = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDir = null, string pageKey = null);
        /// <summary>
        /// Get a single activity entry
        /// </summary>
        /// <remarks>
        ///  
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Activity entry id </param>
        /// <returns>Activity</returns>
        Activity GETActivityIdFormat (string acceptVersion, string authorization, string id);

        /// <summary>
        /// Get a single activity entry
        /// </summary>
        /// <remarks>
        ///  
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Activity entry id </param>
        /// <returns>ApiResponse of Activity</returns>
        ApiResponse<Activity> GETActivityIdFormatWithHttpInfo (string acceptVersion, string authorization, string id);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get activity
        /// </summary>
        /// <remarks>
        ///  
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="userId">Limit to activity by user_id  (optional)</param>
        /// <param name="targetType">Filter by target type, e.g. ‘Payment’  (optional)</param>
        /// <param name="targetId">Filter by target id, e.g. id of payment  (optional)</param>
        /// <param name="support">Filter by whether a support user made the activity  (optional)</param>
        /// <param name="page">Pagination page. Default is 1  (optional, default to 1)</param>
        /// <param name="pageSize">Items per page. Default is 20  (optional, default to 20)</param>
        /// <param name="sortBy">Property to sort by  (optional, default to created_at)</param>
        /// <param name="sortDir">Sort direction  (optional, default to desc)</param>
        /// <param name="pageKey">  (optional)</param>
        /// <returns>Task of Activity</returns>
        System.Threading.Tasks.Task<Activity> GETActivityFormatAsync (string acceptVersion, string authorization, int? userId = null, string targetType = null, int? targetId = null, bool? support = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDir = null, string pageKey = null);

        /// <summary>
        /// Get activity
        /// </summary>
        /// <remarks>
        ///  
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="userId">Limit to activity by user_id  (optional)</param>
        /// <param name="targetType">Filter by target type, e.g. ‘Payment’  (optional)</param>
        /// <param name="targetId">Filter by target id, e.g. id of payment  (optional)</param>
        /// <param name="support">Filter by whether a support user made the activity  (optional)</param>
        /// <param name="page">Pagination page. Default is 1  (optional, default to 1)</param>
        /// <param name="pageSize">Items per page. Default is 20  (optional, default to 20)</param>
        /// <param name="sortBy">Property to sort by  (optional, default to created_at)</param>
        /// <param name="sortDir">Sort direction  (optional, default to desc)</param>
        /// <param name="pageKey">  (optional)</param>
        /// <returns>Task of ApiResponse (Activity)</returns>
        System.Threading.Tasks.Task<ApiResponse<Activity>> GETActivityFormatAsyncWithHttpInfo (string acceptVersion, string authorization, int? userId = null, string targetType = null, int? targetId = null, bool? support = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDir = null, string pageKey = null);
        /// <summary>
        /// Get a single activity entry
        /// </summary>
        /// <remarks>
        ///  
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Activity entry id </param>
        /// <returns>Task of Activity</returns>
        System.Threading.Tasks.Task<Activity> GETActivityIdFormatAsync (string acceptVersion, string authorization, string id);

        /// <summary>
        /// Get a single activity entry
        /// </summary>
        /// <remarks>
        ///  
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Activity entry id </param>
        /// <returns>Task of ApiResponse (Activity)</returns>
        System.Threading.Tasks.Task<ApiResponse<Activity>> GETActivityIdFormatAsyncWithHttpInfo (string acceptVersion, string authorization, string id);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ActivityApi : IActivityApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ActivityApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ActivityApi(IO.Swagger.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = IO.Swagger.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IO.Swagger.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Get activity  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="userId">Limit to activity by user_id  (optional)</param>
        /// <param name="targetType">Filter by target type, e.g. ‘Payment’  (optional)</param>
        /// <param name="targetId">Filter by target id, e.g. id of payment  (optional)</param>
        /// <param name="support">Filter by whether a support user made the activity  (optional)</param>
        /// <param name="page">Pagination page. Default is 1  (optional, default to 1)</param>
        /// <param name="pageSize">Items per page. Default is 20  (optional, default to 20)</param>
        /// <param name="sortBy">Property to sort by  (optional, default to created_at)</param>
        /// <param name="sortDir">Sort direction  (optional, default to desc)</param>
        /// <param name="pageKey">  (optional)</param>
        /// <returns>Activity</returns>
        public Activity GETActivityFormat (string acceptVersion, string authorization, int? userId = null, string targetType = null, int? targetId = null, bool? support = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDir = null, string pageKey = null)
        {
             ApiResponse<Activity> localVarResponse = GETActivityFormatWithHttpInfo(acceptVersion, authorization, userId, targetType, targetId, support, page, pageSize, sortBy, sortDir, pageKey);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get activity  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="userId">Limit to activity by user_id  (optional)</param>
        /// <param name="targetType">Filter by target type, e.g. ‘Payment’  (optional)</param>
        /// <param name="targetId">Filter by target id, e.g. id of payment  (optional)</param>
        /// <param name="support">Filter by whether a support user made the activity  (optional)</param>
        /// <param name="page">Pagination page. Default is 1  (optional, default to 1)</param>
        /// <param name="pageSize">Items per page. Default is 20  (optional, default to 20)</param>
        /// <param name="sortBy">Property to sort by  (optional, default to created_at)</param>
        /// <param name="sortDir">Sort direction  (optional, default to desc)</param>
        /// <param name="pageKey">  (optional)</param>
        /// <returns>ApiResponse of Activity</returns>
        public ApiResponse< Activity > GETActivityFormatWithHttpInfo (string acceptVersion, string authorization, int? userId = null, string targetType = null, int? targetId = null, bool? support = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDir = null, string pageKey = null)
        {
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null)
                throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling ActivityApi->GETActivityFormat");
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling ActivityApi->GETActivityFormat");

            var localVarPath = "/activity";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/xml",
                "application/json",
                "application/octet-stream",
                "text/plain"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (userId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "user_id", userId)); // query parameter
            if (targetType != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "target_type", targetType)); // query parameter
            if (targetId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "target_id", targetId)); // query parameter
            if (support != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "support", support)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (sortBy != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sort_by", sortBy)); // query parameter
            if (sortDir != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sort_dir", sortDir)); // query parameter
            if (pageKey != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page_key", pageKey)); // query parameter
            if (acceptVersion != null) localVarHeaderParams.Add("Accept-Version", this.Configuration.ApiClient.ParameterToString(acceptVersion)); // header parameter
            if (authorization != null) localVarHeaderParams.Add("Authorization", this.Configuration.ApiClient.ParameterToString(authorization)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GETActivityFormat", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Activity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Activity) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Activity)));
        }

        /// <summary>
        /// Get activity  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="userId">Limit to activity by user_id  (optional)</param>
        /// <param name="targetType">Filter by target type, e.g. ‘Payment’  (optional)</param>
        /// <param name="targetId">Filter by target id, e.g. id of payment  (optional)</param>
        /// <param name="support">Filter by whether a support user made the activity  (optional)</param>
        /// <param name="page">Pagination page. Default is 1  (optional, default to 1)</param>
        /// <param name="pageSize">Items per page. Default is 20  (optional, default to 20)</param>
        /// <param name="sortBy">Property to sort by  (optional, default to created_at)</param>
        /// <param name="sortDir">Sort direction  (optional, default to desc)</param>
        /// <param name="pageKey">  (optional)</param>
        /// <returns>Task of Activity</returns>
        public async System.Threading.Tasks.Task<Activity> GETActivityFormatAsync (string acceptVersion, string authorization, int? userId = null, string targetType = null, int? targetId = null, bool? support = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDir = null, string pageKey = null)
        {
             ApiResponse<Activity> localVarResponse = await GETActivityFormatAsyncWithHttpInfo(acceptVersion, authorization, userId, targetType, targetId, support, page, pageSize, sortBy, sortDir, pageKey);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get activity  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="userId">Limit to activity by user_id  (optional)</param>
        /// <param name="targetType">Filter by target type, e.g. ‘Payment’  (optional)</param>
        /// <param name="targetId">Filter by target id, e.g. id of payment  (optional)</param>
        /// <param name="support">Filter by whether a support user made the activity  (optional)</param>
        /// <param name="page">Pagination page. Default is 1  (optional, default to 1)</param>
        /// <param name="pageSize">Items per page. Default is 20  (optional, default to 20)</param>
        /// <param name="sortBy">Property to sort by  (optional, default to created_at)</param>
        /// <param name="sortDir">Sort direction  (optional, default to desc)</param>
        /// <param name="pageKey">  (optional)</param>
        /// <returns>Task of ApiResponse (Activity)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Activity>> GETActivityFormatAsyncWithHttpInfo (string acceptVersion, string authorization, int? userId = null, string targetType = null, int? targetId = null, bool? support = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDir = null, string pageKey = null)
        {
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null)
                throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling ActivityApi->GETActivityFormat");
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling ActivityApi->GETActivityFormat");

            var localVarPath = "/activity";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/xml",
                "application/json",
                "application/octet-stream",
                "text/plain"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (userId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "user_id", userId)); // query parameter
            if (targetType != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "target_type", targetType)); // query parameter
            if (targetId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "target_id", targetId)); // query parameter
            if (support != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "support", support)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (sortBy != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sort_by", sortBy)); // query parameter
            if (sortDir != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sort_dir", sortDir)); // query parameter
            if (pageKey != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page_key", pageKey)); // query parameter
            if (acceptVersion != null) localVarHeaderParams.Add("Accept-Version", this.Configuration.ApiClient.ParameterToString(acceptVersion)); // header parameter
            if (authorization != null) localVarHeaderParams.Add("Authorization", this.Configuration.ApiClient.ParameterToString(authorization)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GETActivityFormat", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Activity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Activity) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Activity)));
        }

        /// <summary>
        /// Get a single activity entry  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Activity entry id </param>
        /// <returns>Activity</returns>
        public Activity GETActivityIdFormat (string acceptVersion, string authorization, string id)
        {
             ApiResponse<Activity> localVarResponse = GETActivityIdFormatWithHttpInfo(acceptVersion, authorization, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a single activity entry  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Activity entry id </param>
        /// <returns>ApiResponse of Activity</returns>
        public ApiResponse< Activity > GETActivityIdFormatWithHttpInfo (string acceptVersion, string authorization, string id)
        {
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null)
                throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling ActivityApi->GETActivityIdFormat");
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling ActivityApi->GETActivityIdFormat");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ActivityApi->GETActivityIdFormat");

            var localVarPath = "/activity/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/xml",
                "application/json",
                "application/octet-stream",
                "text/plain"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (acceptVersion != null) localVarHeaderParams.Add("Accept-Version", this.Configuration.ApiClient.ParameterToString(acceptVersion)); // header parameter
            if (authorization != null) localVarHeaderParams.Add("Authorization", this.Configuration.ApiClient.ParameterToString(authorization)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GETActivityIdFormat", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Activity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Activity) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Activity)));
        }

        /// <summary>
        /// Get a single activity entry  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Activity entry id </param>
        /// <returns>Task of Activity</returns>
        public async System.Threading.Tasks.Task<Activity> GETActivityIdFormatAsync (string acceptVersion, string authorization, string id)
        {
             ApiResponse<Activity> localVarResponse = await GETActivityIdFormatAsyncWithHttpInfo(acceptVersion, authorization, id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a single activity entry  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Activity entry id </param>
        /// <returns>Task of ApiResponse (Activity)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Activity>> GETActivityIdFormatAsyncWithHttpInfo (string acceptVersion, string authorization, string id)
        {
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null)
                throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling ActivityApi->GETActivityIdFormat");
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling ActivityApi->GETActivityIdFormat");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ActivityApi->GETActivityIdFormat");

            var localVarPath = "/activity/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/xml",
                "application/json",
                "application/octet-stream",
                "text/plain"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (acceptVersion != null) localVarHeaderParams.Add("Accept-Version", this.Configuration.ApiClient.ParameterToString(acceptVersion)); // header parameter
            if (authorization != null) localVarHeaderParams.Add("Authorization", this.Configuration.ApiClient.ParameterToString(authorization)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GETActivityIdFormat", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Activity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Activity) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Activity)));
        }

    }
}
