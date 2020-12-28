/* 
 * Quickpay API v10
 *
 * <h2 id=\"authorization\">Authorization</h2>  <p>Authorization is done using basic-auth. Authorization can be done with a user or an agreement.</p>  <ul>   <li>When authorized with a user one is able to edit own settings, create new merchant or request access to existing merchant.</li>   <li>When authorized with an agreement one is able to perform anything on the account that agreement gives permissions to.</li> </ul>  
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
    public interface IPaymentMethodPriorityApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get merchant payment method priority
        /// </summary>
        /// <remarks>
        ///  
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <returns>PaymentMethodPriority</returns>
        PaymentMethodPriority GETPaymentMethodPriorityFormat (string acceptVersion, string authorization);

        /// <summary>
        /// Get merchant payment method priority
        /// </summary>
        /// <remarks>
        ///  
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <returns>ApiResponse of PaymentMethodPriority</returns>
        ApiResponse<PaymentMethodPriority> GETPaymentMethodPriorityFormatWithHttpInfo (string acceptVersion, string authorization);
        /// <summary>
        /// Replaces the payment method priority of the merchant
        /// </summary>
        /// <remarks>
        ///  
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="paymentMethodPriority">&lt;p&gt;A map of payment method to acquirers, e.g. { “visa”: [“clearhaus”, “nets”], … }&lt;/p&gt; </param>
        /// <returns></returns>
        void POSTPaymentMethodPriorityFormat (string acceptVersion, string authorization, Dictionary<string, string> paymentMethodPriority);

        /// <summary>
        /// Replaces the payment method priority of the merchant
        /// </summary>
        /// <remarks>
        ///  
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="paymentMethodPriority">&lt;p&gt;A map of payment method to acquirers, e.g. { “visa”: [“clearhaus”, “nets”], … }&lt;/p&gt; </param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> POSTPaymentMethodPriorityFormatWithHttpInfo (string acceptVersion, string authorization, Dictionary<string, string> paymentMethodPriority);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get merchant payment method priority
        /// </summary>
        /// <remarks>
        ///  
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <returns>Task of PaymentMethodPriority</returns>
        System.Threading.Tasks.Task<PaymentMethodPriority> GETPaymentMethodPriorityFormatAsync (string acceptVersion, string authorization);

        /// <summary>
        /// Get merchant payment method priority
        /// </summary>
        /// <remarks>
        ///  
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <returns>Task of ApiResponse (PaymentMethodPriority)</returns>
        System.Threading.Tasks.Task<ApiResponse<PaymentMethodPriority>> GETPaymentMethodPriorityFormatAsyncWithHttpInfo (string acceptVersion, string authorization);
        /// <summary>
        /// Replaces the payment method priority of the merchant
        /// </summary>
        /// <remarks>
        ///  
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="paymentMethodPriority">&lt;p&gt;A map of payment method to acquirers, e.g. { “visa”: [“clearhaus”, “nets”], … }&lt;/p&gt; </param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task POSTPaymentMethodPriorityFormatAsync (string acceptVersion, string authorization, Dictionary<string, string> paymentMethodPriority);

        /// <summary>
        /// Replaces the payment method priority of the merchant
        /// </summary>
        /// <remarks>
        ///  
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="paymentMethodPriority">&lt;p&gt;A map of payment method to acquirers, e.g. { “visa”: [“clearhaus”, “nets”], … }&lt;/p&gt; </param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> POSTPaymentMethodPriorityFormatAsyncWithHttpInfo (string acceptVersion, string authorization, Dictionary<string, string> paymentMethodPriority);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PaymentMethodPriorityApi : IPaymentMethodPriorityApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodPriorityApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PaymentMethodPriorityApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodPriorityApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PaymentMethodPriorityApi(IO.Swagger.Client.Configuration configuration = null)
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
        /// Get merchant payment method priority  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <returns>PaymentMethodPriority</returns>
        public PaymentMethodPriority GETPaymentMethodPriorityFormat (string acceptVersion, string authorization)
        {
             ApiResponse<PaymentMethodPriority> localVarResponse = GETPaymentMethodPriorityFormatWithHttpInfo(acceptVersion, authorization);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get merchant payment method priority  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <returns>ApiResponse of PaymentMethodPriority</returns>
        public ApiResponse< PaymentMethodPriority > GETPaymentMethodPriorityFormatWithHttpInfo (string acceptVersion, string authorization)
        {
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null)
                throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PaymentMethodPriorityApi->GETPaymentMethodPriorityFormat");
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling PaymentMethodPriorityApi->GETPaymentMethodPriorityFormat");

            var localVarPath = "/payment-method-priority";
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

            if (acceptVersion != null) localVarHeaderParams.Add("Accept-Version", this.Configuration.ApiClient.ParameterToString(acceptVersion)); // header parameter
            if (authorization != null) localVarHeaderParams.Add("Authorization", this.Configuration.ApiClient.ParameterToString(authorization)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GETPaymentMethodPriorityFormat", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PaymentMethodPriority>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PaymentMethodPriority) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaymentMethodPriority)));
        }

        /// <summary>
        /// Get merchant payment method priority  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <returns>Task of PaymentMethodPriority</returns>
        public async System.Threading.Tasks.Task<PaymentMethodPriority> GETPaymentMethodPriorityFormatAsync (string acceptVersion, string authorization)
        {
             ApiResponse<PaymentMethodPriority> localVarResponse = await GETPaymentMethodPriorityFormatAsyncWithHttpInfo(acceptVersion, authorization);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get merchant payment method priority  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <returns>Task of ApiResponse (PaymentMethodPriority)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PaymentMethodPriority>> GETPaymentMethodPriorityFormatAsyncWithHttpInfo (string acceptVersion, string authorization)
        {
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null)
                throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PaymentMethodPriorityApi->GETPaymentMethodPriorityFormat");
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling PaymentMethodPriorityApi->GETPaymentMethodPriorityFormat");

            var localVarPath = "/payment-method-priority";
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

            if (acceptVersion != null) localVarHeaderParams.Add("Accept-Version", this.Configuration.ApiClient.ParameterToString(acceptVersion)); // header parameter
            if (authorization != null) localVarHeaderParams.Add("Authorization", this.Configuration.ApiClient.ParameterToString(authorization)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GETPaymentMethodPriorityFormat", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PaymentMethodPriority>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PaymentMethodPriority) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaymentMethodPriority)));
        }

        /// <summary>
        /// Replaces the payment method priority of the merchant  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="paymentMethodPriority">&lt;p&gt;A map of payment method to acquirers, e.g. { “visa”: [“clearhaus”, “nets”], … }&lt;/p&gt; </param>
        /// <returns></returns>
        public void POSTPaymentMethodPriorityFormat (string acceptVersion, string authorization, Dictionary<string, string> paymentMethodPriority)
        {
             POSTPaymentMethodPriorityFormatWithHttpInfo(acceptVersion, authorization, paymentMethodPriority);
        }

        /// <summary>
        /// Replaces the payment method priority of the merchant  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="paymentMethodPriority">&lt;p&gt;A map of payment method to acquirers, e.g. { “visa”: [“clearhaus”, “nets”], … }&lt;/p&gt; </param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> POSTPaymentMethodPriorityFormatWithHttpInfo (string acceptVersion, string authorization, Dictionary<string, string> paymentMethodPriority)
        {
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null)
                throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PaymentMethodPriorityApi->POSTPaymentMethodPriorityFormat");
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling PaymentMethodPriorityApi->POSTPaymentMethodPriorityFormat");
            // verify the required parameter 'paymentMethodPriority' is set
            if (paymentMethodPriority == null)
                throw new ApiException(400, "Missing required parameter 'paymentMethodPriority' when calling PaymentMethodPriorityApi->POSTPaymentMethodPriorityFormat");

            var localVarPath = "/payment-method-priority";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
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

            if (acceptVersion != null) localVarHeaderParams.Add("Accept-Version", this.Configuration.ApiClient.ParameterToString(acceptVersion)); // header parameter
            if (authorization != null) localVarHeaderParams.Add("Authorization", this.Configuration.ApiClient.ParameterToString(authorization)); // header parameter
            if (paymentMethodPriority != null) localVarFormParams.Add("payment_method_priority", this.Configuration.ApiClient.ParameterToString(paymentMethodPriority)); // form parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("POSTPaymentMethodPriorityFormat", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Replaces the payment method priority of the merchant  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="paymentMethodPriority">&lt;p&gt;A map of payment method to acquirers, e.g. { “visa”: [“clearhaus”, “nets”], … }&lt;/p&gt; </param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task POSTPaymentMethodPriorityFormatAsync (string acceptVersion, string authorization, Dictionary<string, string> paymentMethodPriority)
        {
             await POSTPaymentMethodPriorityFormatAsyncWithHttpInfo(acceptVersion, authorization, paymentMethodPriority);

        }

        /// <summary>
        /// Replaces the payment method priority of the merchant  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="paymentMethodPriority">&lt;p&gt;A map of payment method to acquirers, e.g. { “visa”: [“clearhaus”, “nets”], … }&lt;/p&gt; </param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> POSTPaymentMethodPriorityFormatAsyncWithHttpInfo (string acceptVersion, string authorization, Dictionary<string, string> paymentMethodPriority)
        {
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null)
                throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PaymentMethodPriorityApi->POSTPaymentMethodPriorityFormat");
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling PaymentMethodPriorityApi->POSTPaymentMethodPriorityFormat");
            // verify the required parameter 'paymentMethodPriority' is set
            if (paymentMethodPriority == null)
                throw new ApiException(400, "Missing required parameter 'paymentMethodPriority' when calling PaymentMethodPriorityApi->POSTPaymentMethodPriorityFormat");

            var localVarPath = "/payment-method-priority";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
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

            if (acceptVersion != null) localVarHeaderParams.Add("Accept-Version", this.Configuration.ApiClient.ParameterToString(acceptVersion)); // header parameter
            if (authorization != null) localVarHeaderParams.Add("Authorization", this.Configuration.ApiClient.ParameterToString(authorization)); // header parameter
            if (paymentMethodPriority != null) localVarFormParams.Add("payment_method_priority", this.Configuration.ApiClient.ParameterToString(paymentMethodPriority)); // form parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("POSTPaymentMethodPriorityFormat", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

    }
}
