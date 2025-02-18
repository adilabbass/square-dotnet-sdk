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
    /// TeamMemberAssignedLocations.
    /// </summary>
    public class TeamMemberAssignedLocations
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMemberAssignedLocations"/> class.
        /// </summary>
        /// <param name="assignmentType">assignment_type.</param>
        /// <param name="locationIds">location_ids.</param>
        public TeamMemberAssignedLocations(
            string assignmentType = null,
            IList<string> locationIds = null)
        {
            this.AssignmentType = assignmentType;
            this.LocationIds = locationIds;
        }

        /// <summary>
        /// Enumerates the possible assignment types that the team member can have.
        /// </summary>
        [JsonProperty("assignment_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AssignmentType { get; }

        /// <summary>
        /// The locations that the team member is assigned to.
        /// </summary>
        [JsonProperty("location_ids", NullValueHandling = NullValueHandling.Ignore)]
        public IList<string> LocationIds { get; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TeamMemberAssignedLocations : ({string.Join(", ", toStringOutput)})";
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

            return obj is TeamMemberAssignedLocations other &&
                ((this.AssignmentType == null && other.AssignmentType == null) || (this.AssignmentType?.Equals(other.AssignmentType) == true)) &&
                ((this.LocationIds == null && other.LocationIds == null) || (this.LocationIds?.Equals(other.LocationIds) == true));
        }
        
        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1779620942;
            hashCode = HashCode.Combine(this.AssignmentType, this.LocationIds);

            return hashCode;
        }
  
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AssignmentType = {(this.AssignmentType == null ? "null" : this.AssignmentType.ToString())}");
            toStringOutput.Add($"this.LocationIds = {(this.LocationIds == null ? "null" : $"[{string.Join(", ", this.LocationIds)} ]")}");
        }

        /// <summary>
        /// Converts to builder object.
        /// </summary>
        /// <returns> Builder. </returns>
        public Builder ToBuilder()
        {
            var builder = new Builder()
                .AssignmentType(this.AssignmentType)
                .LocationIds(this.LocationIds);
            return builder;
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private string assignmentType;
            private IList<string> locationIds;

             /// <summary>
             /// AssignmentType.
             /// </summary>
             /// <param name="assignmentType"> assignmentType. </param>
             /// <returns> Builder. </returns>
            public Builder AssignmentType(string assignmentType)
            {
                this.assignmentType = assignmentType;
                return this;
            }

             /// <summary>
             /// LocationIds.
             /// </summary>
             /// <param name="locationIds"> locationIds. </param>
             /// <returns> Builder. </returns>
            public Builder LocationIds(IList<string> locationIds)
            {
                this.locationIds = locationIds;
                return this;
            }

            /// <summary>
            /// Builds class object.
            /// </summary>
            /// <returns> TeamMemberAssignedLocations. </returns>
            public TeamMemberAssignedLocations Build()
            {
                return new TeamMemberAssignedLocations(
                    this.assignmentType,
                    this.locationIds);
            }
        }
    }
}