namespace Square.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Square;
    using Square.Utilities;

    /// <summary>
    /// RetrieveCustomerCustomAttributeRequest.
    /// </summary>
    public class RetrieveCustomerCustomAttributeRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveCustomerCustomAttributeRequest"/> class.
        /// </summary>
        /// <param name="withDefinition">with_definition.</param>
        /// <param name="version">version.</param>
        public RetrieveCustomerCustomAttributeRequest(
            bool? withDefinition = null,
            int? version = null)
        {
            this.WithDefinition = withDefinition;
            this.Version = version;
        }

        /// <summary>
        /// Indicates whether to return the [custom attribute definition]($m/CustomAttributeDefinition) in the `definition` field of
        /// the custom attribute. Set this parameter to `true` to get the name and description of the custom
        /// attribute, information about the data type, or other definition details. The default value is `false`.
        /// </summary>
        [JsonProperty("with_definition", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WithDefinition { get; }

        /// <summary>
        /// The current version of the custom attribute, which is used for strongly consistent reads to
        /// guarantee that you receive the most up-to-date data. When included in the request, Square
        /// returns the specified version or a higher version if one exists. If the specified version is
        /// higher than the current version, Square returns a `BAD_REQUEST` error.
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public int? Version { get; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RetrieveCustomerCustomAttributeRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            return obj is RetrieveCustomerCustomAttributeRequest other &&
                ((this.WithDefinition == null && other.WithDefinition == null) || (this.WithDefinition?.Equals(other.WithDefinition) == true)) &&
                ((this.Version == null && other.Version == null) || (this.Version?.Equals(other.Version) == true));
        }
        
        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -2144154743;
            hashCode = HashCode.Combine(this.WithDefinition, this.Version);

            return hashCode;
        }
  
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.WithDefinition = {(this.WithDefinition == null ? "null" : this.WithDefinition.ToString())}");
            toStringOutput.Add($"this.Version = {(this.Version == null ? "null" : this.Version.ToString())}");
        }

        /// <summary>
        /// Converts to builder object.
        /// </summary>
        /// <returns> Builder. </returns>
        public Builder ToBuilder()
        {
            var builder = new Builder()
                .WithDefinition(this.WithDefinition)
                .Version(this.Version);
            return builder;
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private bool? withDefinition;
            private int? version;

             /// <summary>
             /// WithDefinition.
             /// </summary>
             /// <param name="withDefinition"> withDefinition. </param>
             /// <returns> Builder. </returns>
            public Builder WithDefinition(bool? withDefinition)
            {
                this.withDefinition = withDefinition;
                return this;
            }

             /// <summary>
             /// Version.
             /// </summary>
             /// <param name="version"> version. </param>
             /// <returns> Builder. </returns>
            public Builder Version(int? version)
            {
                this.version = version;
                return this;
            }

            /// <summary>
            /// Builds class object.
            /// </summary>
            /// <returns> RetrieveCustomerCustomAttributeRequest. </returns>
            public RetrieveCustomerCustomAttributeRequest Build()
            {
                return new RetrieveCustomerCustomAttributeRequest(
                    this.withDefinition,
                    this.version);
            }
        }
    }
}