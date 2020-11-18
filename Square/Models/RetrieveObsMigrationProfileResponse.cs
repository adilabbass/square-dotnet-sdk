using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Square;
using Square.Utilities;

namespace Square.Models
{
    public class RetrieveObsMigrationProfileResponse 
    {
        public RetrieveObsMigrationProfileResponse(bool? bannerEnabled = null,
            string bannerText = null,
            string bannerCtaText = null,
            string bannerCtaUrl = null,
            IList<Models.Error> errors = null)
        {
            BannerEnabled = bannerEnabled;
            BannerText = bannerText;
            BannerCtaText = bannerCtaText;
            BannerCtaUrl = bannerCtaUrl;
            Errors = errors;
        }

        /// <summary>
        /// Indicates whether the seller has enabled the COVID banner (`true`) or not (`false`).
        /// </summary>
        [JsonProperty("banner_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BannerEnabled { get; }

        /// <summary>
        /// The text appearing on the COVID banner.
        /// </summary>
        [JsonProperty("banner_text", NullValueHandling = NullValueHandling.Ignore)]
        public string BannerText { get; }

        /// <summary>
        /// The text of the label of the CTA button beneath the banner.
        /// </summary>
        [JsonProperty("banner_cta_text", NullValueHandling = NullValueHandling.Ignore)]
        public string BannerCtaText { get; }

        /// <summary>
        /// The URL to link to when the CTA button is clicked.
        /// </summary>
        [JsonProperty("banner_cta_url", NullValueHandling = NullValueHandling.Ignore)]
        public string BannerCtaUrl { get; }

        /// <summary>
        /// Any errors that occurred during the request.
        /// </summary>
        [JsonProperty("errors", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Models.Error> Errors { get; }

        public Builder ToBuilder()
        {
            var builder = new Builder()
                .BannerEnabled(BannerEnabled)
                .BannerText(BannerText)
                .BannerCtaText(BannerCtaText)
                .BannerCtaUrl(BannerCtaUrl)
                .Errors(Errors);
            return builder;
        }

        public class Builder
        {
            private bool? bannerEnabled;
            private string bannerText;
            private string bannerCtaText;
            private string bannerCtaUrl;
            private IList<Models.Error> errors;



            public Builder BannerEnabled(bool? bannerEnabled)
            {
                this.bannerEnabled = bannerEnabled;
                return this;
            }

            public Builder BannerText(string bannerText)
            {
                this.bannerText = bannerText;
                return this;
            }

            public Builder BannerCtaText(string bannerCtaText)
            {
                this.bannerCtaText = bannerCtaText;
                return this;
            }

            public Builder BannerCtaUrl(string bannerCtaUrl)
            {
                this.bannerCtaUrl = bannerCtaUrl;
                return this;
            }

            public Builder Errors(IList<Models.Error> errors)
            {
                this.errors = errors;
                return this;
            }

            public RetrieveObsMigrationProfileResponse Build()
            {
                return new RetrieveObsMigrationProfileResponse(bannerEnabled,
                    bannerText,
                    bannerCtaText,
                    bannerCtaUrl,
                    errors);
            }
        }
    }
}