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
    public class CustomerFilter 
    {
        public CustomerFilter(Models.CustomerCreationSourceFilter creationSource = null,
            Models.TimeRange createdAt = null,
            Models.TimeRange updatedAt = null,
            Models.FilterValue groupIds = null)
        {
            CreationSource = creationSource;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            GroupIds = groupIds;
        }

        /// <summary>
        /// Creation source filter.
        /// If one or more creation sources are set, customer profiles are included in,
        /// or excluded from, the result if they match at least one of the filter
        /// criteria.
        /// </summary>
        [JsonProperty("creation_source")]
        public Models.CustomerCreationSourceFilter CreationSource { get; }

        /// <summary>
        /// Represents a generic time range. The start and end values are
        /// represented in RFC-3339 format. Time ranges are customized to be
        /// inclusive or exclusive based on the needs of a particular endpoint.
        /// Refer to the relevent endpoint-specific documentation to determine
        /// how time ranges are handled.
        /// </summary>
        [JsonProperty("created_at")]
        public Models.TimeRange CreatedAt { get; }

        /// <summary>
        /// Represents a generic time range. The start and end values are
        /// represented in RFC-3339 format. Time ranges are customized to be
        /// inclusive or exclusive based on the needs of a particular endpoint.
        /// Refer to the relevent endpoint-specific documentation to determine
        /// how time ranges are handled.
        /// </summary>
        [JsonProperty("updated_at")]
        public Models.TimeRange UpdatedAt { get; }

        /// <summary>
        /// A filter to select resources based on an exact field value. For any given
        /// value, the value can only be in one property. Depending on the field, either
        /// all properties can be set or only a subset will be available.
        /// Refer to the documentation of the field.
        /// </summary>
        [JsonProperty("group_ids")]
        public Models.FilterValue GroupIds { get; }

        public Builder ToBuilder()
        {
            var builder = new Builder()
                .CreationSource(CreationSource)
                .CreatedAt(CreatedAt)
                .UpdatedAt(UpdatedAt)
                .GroupIds(GroupIds);
            return builder;
        }

        public class Builder
        {
            private Models.CustomerCreationSourceFilter creationSource;
            private Models.TimeRange createdAt;
            private Models.TimeRange updatedAt;
            private Models.FilterValue groupIds;

            public Builder() { }
            public Builder CreationSource(Models.CustomerCreationSourceFilter value)
            {
                creationSource = value;
                return this;
            }

            public Builder CreatedAt(Models.TimeRange value)
            {
                createdAt = value;
                return this;
            }

            public Builder UpdatedAt(Models.TimeRange value)
            {
                updatedAt = value;
                return this;
            }

            public Builder GroupIds(Models.FilterValue value)
            {
                groupIds = value;
                return this;
            }

            public CustomerFilter Build()
            {
                return new CustomerFilter(creationSource,
                    createdAt,
                    updatedAt,
                    groupIds);
            }
        }
    }
}