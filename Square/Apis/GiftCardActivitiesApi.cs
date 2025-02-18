namespace Square.Apis
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Newtonsoft.Json.Converters;
    using Square;
    using Square.Authentication;
    using Square.Http.Client;
    using Square.Http.Request;
    using Square.Http.Request.Configuration;
    using Square.Http.Response;
    using Square.Utilities;

    /// <summary>
    /// GiftCardActivitiesApi.
    /// </summary>
    internal class GiftCardActivitiesApi : BaseApi, IGiftCardActivitiesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GiftCardActivitiesApi"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        /// <param name="httpCallBack"> httpCallBack. </param>
        internal GiftCardActivitiesApi(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers, HttpCallBack httpCallBack = null)
            : base(config, httpClient, authManagers, httpCallBack)
        {
        }

        /// <summary>
        /// Lists gift card activities. By default, you get gift card activities for all.
        /// gift cards in the seller's account. You can optionally specify query parameters to.
        /// filter the list. For example, you can get a list of gift card activities for a gift card,.
        /// for all gift cards in a specific region, or for activities within a time window.
        /// </summary>
        /// <param name="giftCardId">Optional parameter: If a gift card ID is provided, the endpoint returns activities related  to the specified gift card. Otherwise, the endpoint returns all gift card activities for  the seller..</param>
        /// <param name="type">Optional parameter: If a [type]($m/GiftCardActivityType) is provided, the endpoint returns gift card activities of the specified type.  Otherwise, the endpoint returns all types of gift card activities..</param>
        /// <param name="locationId">Optional parameter: If a location ID is provided, the endpoint returns gift card activities for the specified location.  Otherwise, the endpoint returns gift card activities for all locations..</param>
        /// <param name="beginTime">Optional parameter: The timestamp for the beginning of the reporting period, in RFC 3339 format. This start time is inclusive. The default value is the current time minus one year..</param>
        /// <param name="endTime">Optional parameter: The timestamp for the end of the reporting period, in RFC 3339 format. This end time is inclusive. The default value is the current time..</param>
        /// <param name="limit">Optional parameter: If a limit is provided, the endpoint returns the specified number  of results (or fewer) per page. The maximum value is 100. The default value is 50. For more information, see [Pagination](https://developer.squareup.com/docs/working-with-apis/pagination)..</param>
        /// <param name="cursor">Optional parameter: A pagination cursor returned by a previous call to this endpoint. Provide this cursor to retrieve the next set of results for the original query. If a cursor is not provided, the endpoint returns the first page of the results. For more information, see [Pagination](https://developer.squareup.com/docs/working-with-apis/pagination)..</param>
        /// <param name="sortOrder">Optional parameter: The order in which the endpoint returns the activities, based on `created_at`. - `ASC` - Oldest to newest. - `DESC` - Newest to oldest (default)..</param>
        /// <returns>Returns the Models.ListGiftCardActivitiesResponse response from the API call.</returns>
        public Models.ListGiftCardActivitiesResponse ListGiftCardActivities(
                string giftCardId = null,
                string type = null,
                string locationId = null,
                string beginTime = null,
                string endTime = null,
                int? limit = null,
                string cursor = null,
                string sortOrder = null)
        {
            Task<Models.ListGiftCardActivitiesResponse> t = this.ListGiftCardActivitiesAsync(giftCardId, type, locationId, beginTime, endTime, limit, cursor, sortOrder);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Lists gift card activities. By default, you get gift card activities for all.
        /// gift cards in the seller's account. You can optionally specify query parameters to.
        /// filter the list. For example, you can get a list of gift card activities for a gift card,.
        /// for all gift cards in a specific region, or for activities within a time window.
        /// </summary>
        /// <param name="giftCardId">Optional parameter: If a gift card ID is provided, the endpoint returns activities related  to the specified gift card. Otherwise, the endpoint returns all gift card activities for  the seller..</param>
        /// <param name="type">Optional parameter: If a [type]($m/GiftCardActivityType) is provided, the endpoint returns gift card activities of the specified type.  Otherwise, the endpoint returns all types of gift card activities..</param>
        /// <param name="locationId">Optional parameter: If a location ID is provided, the endpoint returns gift card activities for the specified location.  Otherwise, the endpoint returns gift card activities for all locations..</param>
        /// <param name="beginTime">Optional parameter: The timestamp for the beginning of the reporting period, in RFC 3339 format. This start time is inclusive. The default value is the current time minus one year..</param>
        /// <param name="endTime">Optional parameter: The timestamp for the end of the reporting period, in RFC 3339 format. This end time is inclusive. The default value is the current time..</param>
        /// <param name="limit">Optional parameter: If a limit is provided, the endpoint returns the specified number  of results (or fewer) per page. The maximum value is 100. The default value is 50. For more information, see [Pagination](https://developer.squareup.com/docs/working-with-apis/pagination)..</param>
        /// <param name="cursor">Optional parameter: A pagination cursor returned by a previous call to this endpoint. Provide this cursor to retrieve the next set of results for the original query. If a cursor is not provided, the endpoint returns the first page of the results. For more information, see [Pagination](https://developer.squareup.com/docs/working-with-apis/pagination)..</param>
        /// <param name="sortOrder">Optional parameter: The order in which the endpoint returns the activities, based on `created_at`. - `ASC` - Oldest to newest. - `DESC` - Newest to oldest (default)..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListGiftCardActivitiesResponse response from the API call.</returns>
        public async Task<Models.ListGiftCardActivitiesResponse> ListGiftCardActivitiesAsync(
                string giftCardId = null,
                string type = null,
                string locationId = null,
                string beginTime = null,
                string endTime = null,
                int? limit = null,
                string cursor = null,
                string sortOrder = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/v2/gift-cards/activities");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "gift_card_id", giftCardId },
                { "type", type },
                { "location_id", locationId },
                { "begin_time", beginTime },
                { "end_time", endTime },
                { "limit", limit },
                { "cursor", cursor },
                { "sort_order", sortOrder },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
                { "Square-Version", this.Config.SquareVersion },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken: cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            var responseModel = ApiHelper.JsonDeserialize<Models.ListGiftCardActivitiesResponse>(response.Body);
            responseModel.Context = context;
            return responseModel;
        }

        /// <summary>
        /// Creates a gift card activity to manage the balance or state of a [gift card]($m/GiftCard). .
        /// For example, you create an `ACTIVATE` activity to activate a gift card with an initial balance .
        /// before the gift card can be used.
        /// </summary>
        /// <param name="body">Required parameter: An object containing the fields to POST for the request.  See the corresponding object definition for field details..</param>
        /// <returns>Returns the Models.CreateGiftCardActivityResponse response from the API call.</returns>
        public Models.CreateGiftCardActivityResponse CreateGiftCardActivity(
                Models.CreateGiftCardActivityRequest body)
        {
            Task<Models.CreateGiftCardActivityResponse> t = this.CreateGiftCardActivityAsync(body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Creates a gift card activity to manage the balance or state of a [gift card]($m/GiftCard). .
        /// For example, you create an `ACTIVATE` activity to activate a gift card with an initial balance .
        /// before the gift card can be used.
        /// </summary>
        /// <param name="body">Required parameter: An object containing the fields to POST for the request.  See the corresponding object definition for field details..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CreateGiftCardActivityResponse response from the API call.</returns>
        public async Task<Models.CreateGiftCardActivityResponse> CreateGiftCardActivityAsync(
                Models.CreateGiftCardActivityRequest body,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/v2/gift-cards/activities");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
                { "Content-Type", "application/json" },
                { "Square-Version", this.Config.SquareVersion },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(body);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken: cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            var responseModel = ApiHelper.JsonDeserialize<Models.CreateGiftCardActivityResponse>(response.Body);
            responseModel.Context = context;
            return responseModel;
        }
    }
}