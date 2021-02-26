
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
    public class ListDeviceCodesResponse 
    {
        public ListDeviceCodesResponse(IList<Models.Error> errors = null,
            IList<Models.DeviceCode> deviceCodes = null,
            string cursor = null)
        {
            Errors = errors;
            DeviceCodes = deviceCodes;
            Cursor = cursor;
        }

        [JsonIgnore]
        public HttpContext Context { get; internal set; }

        /// <summary>
        /// Any errors that occurred during the request.
        /// </summary>
        [JsonProperty("errors", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Models.Error> Errors { get; }

        /// <summary>
        /// The queried DeviceCode.
        /// </summary>
        [JsonProperty("device_codes", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Models.DeviceCode> DeviceCodes { get; }

        /// <summary>
        /// A pagination cursor to retrieve the next set of results for your
        /// original query to the endpoint. This value is present only if the request
        /// succeeded and additional results are available.
        /// See [Paginating results](#paginatingresults) for more information.
        /// </summary>
        [JsonProperty("cursor", NullValueHandling = NullValueHandling.Ignore)]
        public string Cursor { get; }

        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListDeviceCodesResponse : ({string.Join(", ", toStringOutput)})";
        }

        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Errors = {(Errors == null ? "null" : $"[{ string.Join(", ", Errors)} ]")}");
            toStringOutput.Add($"DeviceCodes = {(DeviceCodes == null ? "null" : $"[{ string.Join(", ", DeviceCodes)} ]")}");
            toStringOutput.Add($"Cursor = {(Cursor == null ? "null" : Cursor == string.Empty ? "" : Cursor)}");
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

            return obj is ListDeviceCodesResponse other &&
                ((Context == null && other.Context == null) || (Context?.Equals(other.Context) == true)) &&
                ((Errors == null && other.Errors == null) || (Errors?.Equals(other.Errors) == true)) &&
                ((DeviceCodes == null && other.DeviceCodes == null) || (DeviceCodes?.Equals(other.DeviceCodes) == true)) &&
                ((Cursor == null && other.Cursor == null) || (Cursor?.Equals(other.Cursor) == true));
        }

        public override int GetHashCode()
        {
            int hashCode = 456544551;

            if (Context != null)
            {
                hashCode += Context.GetHashCode();
            }

            if (Errors != null)
            {
               hashCode += Errors.GetHashCode();
            }

            if (DeviceCodes != null)
            {
               hashCode += DeviceCodes.GetHashCode();
            }

            if (Cursor != null)
            {
               hashCode += Cursor.GetHashCode();
            }

            return hashCode;
        }

        public Builder ToBuilder()
        {
            var builder = new Builder()
                .Errors(Errors)
                .DeviceCodes(DeviceCodes)
                .Cursor(Cursor);
            return builder;
        }

        public class Builder
        {
            private IList<Models.Error> errors;
            private IList<Models.DeviceCode> deviceCodes;
            private string cursor;



            public Builder Errors(IList<Models.Error> errors)
            {
                this.errors = errors;
                return this;
            }

            public Builder DeviceCodes(IList<Models.DeviceCode> deviceCodes)
            {
                this.deviceCodes = deviceCodes;
                return this;
            }

            public Builder Cursor(string cursor)
            {
                this.cursor = cursor;
                return this;
            }

            public ListDeviceCodesResponse Build()
            {
                return new ListDeviceCodesResponse(errors,
                    deviceCodes,
                    cursor);
            }
        }
    }
}