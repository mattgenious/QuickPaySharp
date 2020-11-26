﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using QuickPaySharp.Entities.Payments;
using QuickPaySharp.Services;

namespace RechargeSharp.Services.Subscriptions
{
	public class PaymentService : QuickPaySharpService
	{
		public PaymentService(ILogger<QuickPaySharpService> logger, IHttpClientFactory httpClientFactory,
			IOptions<QuickPaySharpServiceOptions> quickPaySharpOptions) : base(logger, httpClientFactory,
			quickPaySharpOptions)
		{
		}

		private readonly List<string> timestamps = new List<string>()
		{
			"created_at",
			"updated_at"
		};

		private readonly List<string> states = new List<string>()
		{
			"initial",
			"pending",
			"new",
			"rejected",
			"processed"
		};

		private readonly List<string> acquirers = new List<string>()
		{
			"bambora",
			"clearhaus",
			"coinify",
			"elavon",
			"handelsbanken",
			"klarna",
			"klarnapayments",
			"mobilepay",
			"mobilepayonline",
			"mobilepaysubscriptions",
			"nets",
			"paypal",
			"paysafecard",
			"resurs",
			"sofort",
			"swedbank",
			"swish",
			"teller",
			"trustly",
			"valitor",
			"viabill",
			"vipps"
		};

		private readonly List<string> sortBys = new List<string>()
		{
			"id",
			"order_id",
			"created_at"
		};

		private readonly List<string> sortDirections = new List<string>()
		{
			"asc",
			"desc"
		};

		/// <summary>
		/// 
		/// </summary>
		/// <param name="year"></param>
		/// <param name="month"></param>
		/// <param name="day"></param>
		/// <param name="hour"></param>
		/// <param name="minute"></param>
		/// <param name="timestamp"></param>
		/// <param name="minTime"></param>
		/// <param name="maxTime"></param>
		/// <param name="operationsSize"></param>
		/// <param name="accepted"></param>
		/// <param name="orderId"></param>
		/// <param name="state"></param>
		/// <param name="id"></param>
		/// <param name="acquirer"></param>
		/// <param name="fraudSuspected"></param>
		/// <param name="page"></param>
		/// <param name="pageSize"></param>
		/// <param name="sortBy"></param>
		/// <param name="sortDirection"></param>
		/// <param name="pageKey"></param>
		/// <returns>list of payments</returns>
		public async Task<List<Payment>> GetPaymentsAsync(long? year, long? month, long? day, long? hour, long? minute,
			string timestamp, DateTime? minTime, DateTime? maxTime, long? operationsSize, bool? accepted,
			string? orderId, string? state, long? id, string? acquirer, bool? fraudSuspected, long? page,
			long? pageSize, string? sortBy, string? sortDirection, DateTime? pageKey)
		{
			var queryParams = $"?";
			queryParams += year != null ? $"&date[year]={year}" : "";
			queryParams += month != null ? $"&date[month]={month}" : "";
			queryParams += day != null ? $"&date[day]={day}" : "";
			queryParams += hour != null ? $"&date[hour]={hour}" : "";
			queryParams += minute != null ? $"&date[minute]={minute}" : "";
			queryParams += timestamp != null && timestamps.Contains(timestamp) ? $"&timestamp={timestamp}" : "";
			queryParams += minTime != null ? $"&min_time={minTime.Value:u}" : "";
			queryParams += maxTime != null ? $"&max_time={maxTime.Value:u}" : "";
			queryParams += operationsSize != null ? $"&operations_size={operationsSize}" : "";
			queryParams += accepted != null ? $"&accepted={accepted}" : "";
			queryParams += orderId != null ? $"&order_id={orderId}" : "";
			queryParams += state != null && states.Contains(state) ? $"&state={state}" : "";
			queryParams += id != null ? $"&id={id}" : "";
			queryParams += acquirer != null && acquirers.Contains(acquirer) ? $"&acquirer={acquirer}" : "";
			queryParams += fraudSuspected != null ? $"&fraud_suspected={fraudSuspected}" : "";
			queryParams += page != null ? $"&page={page}" : "";
			queryParams += pageSize!= null ? $"&page_size={pageSize}" : "";
			queryParams += sortBy != null && sortBys.Contains(sortBy) ? $"&sort_by={sortBy}" : "";
			queryParams += sortDirection != null && sortDirections.Contains(sortDirection) ? $"&sort_dir={sortDirection}" : "";
			queryParams += pageKey != null ? $"&page_key={pageKey.Value:u}" : "";

			var response = await GetAsync($"/payments/{queryParams}").ConfigureAwait(false);
			return JsonConvert.DeserializeObject<List<Payment>>(
				await response.Content.ReadAsStringAsync().ConfigureAwait(false));
		}

		public async Task<Subscription> CreateSubscriptionAsync(CreateSubscriptionRequest createSubscriptionRequest)
		{
			ValidateModel(createSubscriptionRequest);

			var response = await PostAsJsonAsync("/subscriptions", JsonConvert.SerializeObject(createSubscriptionRequest)).ConfigureAwait(false);
			return JsonConvert.DeserializeObject<SubscriptionResponse>(
				await response.Content.ReadAsStringAsync().ConfigureAwait(false)).Subscription;
		}

		//public async Task<bool> SubscriptionExistsAsync(long id)
		//{
		//    var response = await GetAsync($"/subscriptions/{id}").ConfigureAwait(false);
		//    return response.IsSuccessStatusCode;
		//}

		//public async Task<Subscription> GetSubscriptionAsync(long id)
		//{
		//    var response = await GetAsync($"/subscriptions/{id}").ConfigureAwait(false);
		//    return JsonConvert.DeserializeObject<SubscriptionResponse>(
		//        await response.Content.ReadAsStringAsync().ConfigureAwait(false)).Subscription;
		//}

		//private async Task<IEnumerable<Subscription>> GetSubscriptionsAsync(string queryParams)
		//{
		//    var response = await GetAsync($"/subscriptions?{queryParams}").ConfigureAwait(false);
		//    return JsonConvert.DeserializeObject<SubscriptionListResponse>(
		//        await response.Content.ReadAsStringAsync().ConfigureAwait(false)).Subscriptions;
		//}

		//public Task<IEnumerable<Subscription>> GetSubscriptionsAsync(int page = 1, int limit = 50, long? customerId = null, long? addressId = null, string status = null, long? shopifyCustomerId = null, long? shopifyVariantId = null, DateTime? createdAtMin = null, DateTime? createAtMax = null, DateTime? updatedAtMin = null, DateTime? updatedAtMax = null)
		//{
		//    var queryParams = $"page={page}&limit={limit}";
		//    queryParams += customerId != null ? $"&customer_id={customerId}" : "";
		//    queryParams += addressId != null ? $"&address_id={addressId}" : "";
		//    queryParams += status != null ? $"&status={status}" : "";
		//    queryParams += shopifyCustomerId != null ? $"&shopify_customer_id={shopifyCustomerId}" : "";
		//    queryParams += shopifyVariantId != null ? $"&shopify_variant_id={shopifyVariantId}" : "";
		//    queryParams += createdAtMin != null ? $"&created_at_min={createdAtMin?.ToString("s")}" : "";
		//    queryParams += createAtMax != null ? $"&created_at_max={createAtMax?.ToString("s")}" : "";
		//    queryParams += updatedAtMin != null ? $"&updated_at_min={updatedAtMin?.ToString("s")}" : "";
		//    queryParams += updatedAtMax != null ? $"&updated_at_max={updatedAtMax?.ToString("s")}" : "";


		//    return GetSubscriptionsAsync(queryParams);
		//}

		//public Task<IEnumerable<Subscription>> GetAllSubscriptionsWithParamsAsync(long? customerId = null, long? addressId = null, string status = null, long? shopifyCustomerId = null, long? shopifyVariantId = null, DateTime? createdAtMin = null, DateTime? createAtMax = null, DateTime? updatedAtMin = null, DateTime? updatedAtMax = null)
		//{
		//    var queryParams = "";
		//    queryParams += customerId != null ? $"&customer_id={customerId}" : "";
		//    queryParams += addressId != null ? $"&address_id={addressId}" : "";
		//    queryParams += status != null ? $"&status={status}" : "";
		//    queryParams += shopifyCustomerId != null ? $"&shopify_customer_id={shopifyCustomerId}" : "";
		//    queryParams += shopifyVariantId != null ? $"&shopify_variant_id={shopifyVariantId}" : "";
		//    queryParams += createdAtMin != null ? $"&created_at_min={createdAtMin?.ToString("s")}" : "";
		//    queryParams += createAtMax != null ? $"&created_at_max={createAtMax?.ToString("s")}" : "";
		//    queryParams += updatedAtMin != null ? $"&updated_at_min={updatedAtMin?.ToString("s")}" : "";
		//    queryParams += updatedAtMax != null ? $"&updated_at_max={updatedAtMax?.ToString("s")}" : "";
		//    return GetAllSubscriptionsAsync(queryParams);
		//}

		//private async Task<IEnumerable<Subscription>> GetAllSubscriptionsAsync(string queryParams)
		//{
		//    var count = await CountSubscriptionsAsync(queryParams);

		//    var taskList = new List<Task<IEnumerable<Subscription>>>();

		//    var pages = Math.Ceiling(Convert.ToDouble(count) / 250d);

		//    for (int i = 1; i <= Convert.ToInt32(pages); i++)
		//    {
		//        taskList.Add(GetSubscriptionsAsync($"page={i}&limit=250" + queryParams));
		//    }

		//    var computed = await Task.WhenAll(taskList);

		//    var result = new List<Subscription>();

		//    foreach (var subscriptions in computed)
		//    {
		//        result.AddRange(subscriptions);
		//    }

		//    return result;
		//}

		//public async Task<long> CountSubscriptionsAsync(long? customerId = null, long? addressId = null, string status = null, long? shopifyCustomerId = null, long? shopifyVariantId = null, DateTime? createdAtMin = null, DateTime? createAtMax = null, DateTime? updatedAtMin = null, DateTime? updatedAtMax = null)
		//{
		//    var queryParams = "";
		//    queryParams += customerId != null ? $"&customer_id={customerId}" : "";
		//    queryParams += addressId != null ? $"&address_id={addressId}" : "";
		//    queryParams += status != null ? $"&status={status}" : "";
		//    queryParams += shopifyCustomerId != null ? $"&shopify_customer_id={shopifyCustomerId}" : "";
		//    queryParams += shopifyVariantId != null ? $"&shopify_variant_id={shopifyVariantId}" : "";
		//    queryParams += createdAtMin != null ? $"&created_at_min={createdAtMin?.ToString("s")}" : "";
		//    queryParams += createAtMax != null ? $"&created_at_max={createAtMax?.ToString("s")}" : "";
		//    queryParams += updatedAtMin != null ? $"&updated_at_min={updatedAtMin?.ToString("s")}" : "";
		//    queryParams += updatedAtMax != null ? $"&updated_at_max={updatedAtMax?.ToString("s")}" : "";

		//    var response = await GetAsync($"/subscriptions/count?{queryParams}").ConfigureAwait(false);
		//    return JsonConvert.DeserializeObject<CountResponse>(
		//        await response.Content.ReadAsStringAsync().ConfigureAwait(false)).Count;
		//}

		//private async Task<long> CountSubscriptionsAsync(string query = null)
		//{
		//    var response = await GetAsync($"/subscriptions/count?{query}").ConfigureAwait(false);
		//    return JsonConvert.DeserializeObject<CountResponse>(
		//        await response.Content.ReadAsStringAsync().ConfigureAwait(false)).Count;
		//}

		//public async Task<Subscription> CreateSubscriptionAsync(CreateSubscriptionRequest createSubscriptionRequest)
		//{
		//    ValidateModel(createSubscriptionRequest);

		//    var response = await PostAsJsonAsync("/subscriptions", JsonConvert.SerializeObject(createSubscriptionRequest)).ConfigureAwait(false);
		//    return JsonConvert.DeserializeObject<SubscriptionResponse>(
		//        await response.Content.ReadAsStringAsync().ConfigureAwait(false)).Subscription;
		//}
		//public async Task<Subscription> ChangeNextChargeDateAsync(long id, DateTime date)
		//{
		//    var response = await PostAsJsonAsync($"/subscriptions/{id}/set_next_charge_date", JsonConvert.SerializeObject(new ChangeNextChargeDateRequest { Date = date.ToString("yyyy-MM-dd") })).ConfigureAwait(false);
		//    return JsonConvert.DeserializeObject<SubscriptionResponse>(
		//        await response.Content.ReadAsStringAsync().ConfigureAwait(false)).Subscription;
		//}
		//public async Task<Subscription> ChangeAddressAsync(long id, ChangeAddressRequest changeAddressRequest)
		//{
		//    ValidateModel(changeAddressRequest);

		//    var response = await PostAsJsonAsync($"/subscriptions/{id}/change_address", JsonConvert.SerializeObject(changeAddressRequest)).ConfigureAwait(false);
		//    return JsonConvert.DeserializeObject<SubscriptionResponse>(
		//        await response.Content.ReadAsStringAsync().ConfigureAwait(false)).Subscription;
		//}
		//public async Task<Subscription> CancelSubscriptionAsync(long id, CancelSubscriptionRequest cancelSubscriptionRequest)
		//{
		//    ValidateModel(cancelSubscriptionRequest);

		//    var response = await PostAsJsonAsync($"/subscriptions/{id}/cancel", JsonConvert.SerializeObject(cancelSubscriptionRequest)).ConfigureAwait(false);
		//    return JsonConvert.DeserializeObject<SubscriptionResponse>(
		//        await response.Content.ReadAsStringAsync().ConfigureAwait(false)).Subscription;
		//}
		//public async Task<Subscription> ActivateSubscriptionAsync(long id)
		//{
		//    var response = await PostAsJsonAsync($"/subscriptions/{id}/activate", "{}").ConfigureAwait(false);

		//    if ((await response.Content.ReadAsStringAsync()).Contains("item already set to active"))
		//    {
		//        return await GetSubscriptionAsync(id);
		//    }
		//    else
		//    {
		//        return JsonConvert.DeserializeObject<SubscriptionResponse>(
		//            await response.Content.ReadAsStringAsync().ConfigureAwait(false)).Subscription;
		//    }
		//}
		//public async Task<Subscription> UpdateSubscriptionAsync(long id, UpdateSubscriptionRequest updateSubscriptionRequest)
		//{
		//    ValidateModel(updateSubscriptionRequest);

		//    var response = await PutAsJsonAsync($"/subscriptions/{id}", JsonConvert.SerializeObject(updateSubscriptionRequest)).ConfigureAwait(false);
		//    return JsonConvert.DeserializeObject<SubscriptionResponse>(
		//        await response.Content.ReadAsStringAsync().ConfigureAwait(false)).Subscription;
		//}
		//public async Task<Subscription> DelayChargeRegenAsync(long id, DelayChargeRegenRequest delayChargeRegenRequest)
		//{
		//    ValidateModel(delayChargeRegenRequest);

		//    var response = await PutAsJsonAsync($"/subscriptions/{id}", JsonConvert.SerializeObject(delayChargeRegenRequest)).ConfigureAwait(false);
		//    return JsonConvert.DeserializeObject<SubscriptionResponse>(
		//        await response.Content.ReadAsStringAsync().ConfigureAwait(false)).Subscription;
		//}

		//public async Task DeleteSubscriptionAsync(long id)
		//{
		//    var response = await DeleteAsync($"/subscriptions/{id}").ConfigureAwait(false);
		//}
	}
}