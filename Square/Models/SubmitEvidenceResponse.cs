
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Square.Http.Client;
using Square;
using Square.Utilities;

namespace Square.Models
{
    public class SubmitEvidenceResponse 
    {
        public SubmitEvidenceResponse(IList<Models.Error> errors = null,
            Models.Dispute dispute = null)
        {
            Errors = errors;
            Dispute = dispute;
        }

        [JsonIgnore]
        public HttpContext Context { get; internal set; }

        /// <summary>
        /// Information about errors encountered during the request.
        /// </summary>
        [JsonProperty("errors", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Models.Error> Errors { get; }

        /// <summary>
        /// Represents a dispute a cardholder initiated with their bank.
        /// </summary>
        [JsonProperty("dispute", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Dispute Dispute { get; }

        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SubmitEvidenceResponse : ({string.Join(", ", toStringOutput)})";
        }

        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Errors = {(Errors == null ? "null" : $"[{ string.Join(", ", Errors)} ]")}");
            toStringOutput.Add($"Dispute = {(Dispute == null ? "null" : Dispute.ToString())}");
        }

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

            return obj is SubmitEvidenceResponse other &&
                ((Context == null && other.Context == null) || (Context?.Equals(other.Context) == true)) &&
                ((Errors == null && other.Errors == null) || (Errors?.Equals(other.Errors) == true)) &&
                ((Dispute == null && other.Dispute == null) || (Dispute?.Equals(other.Dispute) == true));
        }

        public override int GetHashCode()
        {
            int hashCode = -1624046680;

            if (Context != null)
            {
                hashCode += Context.GetHashCode();
            }

            if (Errors != null)
            {
               hashCode += Errors.GetHashCode();
            }

            if (Dispute != null)
            {
               hashCode += Dispute.GetHashCode();
            }

            return hashCode;
        }

        public Builder ToBuilder()
        {
            var builder = new Builder()
                .Errors(Errors)
                .Dispute(Dispute);
            return builder;
        }

        public class Builder
        {
            private IList<Models.Error> errors;
            private Models.Dispute dispute;



            public Builder Errors(IList<Models.Error> errors)
            {
                this.errors = errors;
                return this;
            }

            public Builder Dispute(Models.Dispute dispute)
            {
                this.dispute = dispute;
                return this;
            }

            public SubmitEvidenceResponse Build()
            {
                return new SubmitEvidenceResponse(errors,
                    dispute);
            }
        }
    }
}