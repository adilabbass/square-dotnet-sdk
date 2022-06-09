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
    /// OrderFulfillmentDeliveryDetails.
    /// </summary>
    public class OrderFulfillmentDeliveryDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderFulfillmentDeliveryDetails"/> class.
        /// </summary>
        /// <param name="recipient">recipient.</param>
        /// <param name="carrier">carrier.</param>
        /// <param name="shippingNote">shipping_note.</param>
        /// <param name="shippingType">shipping_type.</param>
        /// <param name="trackingNumber">tracking_number.</param>
        /// <param name="trackingUrl">tracking_url.</param>
        /// <param name="placedAt">placed_at.</param>
        /// <param name="inProgressAt">in_progress_at.</param>
        /// <param name="packagedAt">packaged_at.</param>
        /// <param name="expectedShippedAt">expected_shipped_at.</param>
        /// <param name="shippedAt">shipped_at.</param>
        /// <param name="canceledAt">canceled_at.</param>
        /// <param name="cancelReason">cancel_reason.</param>
        /// <param name="failedAt">failed_at.</param>
        /// <param name="failureReason">failure_reason.</param>
        public OrderFulfillmentDeliveryDetails(
            Models.OrderFulfillmentRecipient recipient = null,
            string carrier = null,
            string shippingNote = null,
            string shippingType = null,
            string trackingNumber = null,
            string trackingUrl = null,
            string placedAt = null,
            string inProgressAt = null,
            string packagedAt = null,
            string expectedShippedAt = null,
            string shippedAt = null,
            string canceledAt = null,
            string cancelReason = null,
            string failedAt = null,
            string failureReason = null,
            string scheduledType = "SCHEDULED",
            string deliveredAt = null,
            string prepTimeDuration = null,
            string deliveryWindowDuration = null,
            string note = null,
            string completedAt = null,
            string rejectedAt = null,
            string readyAt = null,
            string courierPickupAt = null,
            string courierPickupWindowDuration = null,
            bool isNoContactDelivery = false,
            string courierProviderName = null,
            string courierSupportPhoneNumber = null,
            string dropoffNotes = null,
            string squareDeliveryId = null,
            string externalDeliveyId = null
            )
        {

            this.Recipient = recipient;
            this.Carrier = carrier;
            this.ShippingNote = shippingNote;
            this.ShippingType = shippingType;
            this.TrackingNumber = trackingNumber;
            this.TrackingUrl = trackingUrl;
            this.PlacedAt = placedAt;
            this.InProgressAt = inProgressAt;
            this.PackagedAt = packagedAt;
            this.ExpectedShippedAt = expectedShippedAt;
            this.ShippedAt = shippedAt;
            this.CanceledAt = canceledAt;
            this.CancelReason = cancelReason;
            this.FailedAt = failedAt;
            this.FailureReason = failureReason;
            this.ScheduledType = scheduledType;
            this.PrepTimeDuration = prepTimeDuration;
            this.DeliverAt = deliveredAt;
            this.DeliveryWindowDuration = deliveryWindowDuration;
            this.Note = note;
            this.CompletedAt = completedAt;
            this.RejectedAt = rejectedAt;
            this.ReadyAt = readyAt;
            this.CourierPickupAt = courierPickupAt;
            this.CourierPickupWindowDuration = courierPickupWindowDuration;
            this.IsNoContactDelivery = isNoContactDelivery;
            this.CourierProviderName = courierProviderName;
            this.CourierSupportPhoneNumber = courierSupportPhoneNumber;
            this.DropoffNotes = dropoffNotes;
            this.SquareDeliverId = squareDeliveryId;
            this.ExternalDeliveryId = externalDeliveyId;
        }

        /// <summary>
        /// Contains information about the recipient of a fulfillment.
        /// </summary>
        [JsonProperty("recipient", NullValueHandling = NullValueHandling.Ignore)]
        public Models.OrderFulfillmentRecipient Recipient { get; }

        /// <summary>
        /// The shipping carrier being used to ship this fulfillment (such as UPS, FedEx, or USPS).
        /// </summary>
        [JsonProperty("carrier", NullValueHandling = NullValueHandling.Ignore)]
        public string Carrier { get; }

        /// <summary>
        /// A note with additional information for the shipping carrier.
        /// </summary>
        [JsonProperty("shipping_note", NullValueHandling = NullValueHandling.Ignore)]
        public string ShippingNote { get; }

        /// <summary>
        /// A description of the type of shipping product purchased from the carrier
        /// (such as First Class, Priority, or Express).
        /// </summary>
        [JsonProperty("shipping_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ShippingType { get; }

        /// <summary>
        /// The reference number provided by the carrier to track the shipment's progress.
        /// </summary>
        [JsonProperty("tracking_number", NullValueHandling = NullValueHandling.Ignore)]
        public string TrackingNumber { get; }

        /// <summary>
        /// A link to the tracking webpage on the carrier's website.
        /// </summary>
        [JsonProperty("tracking_url", NullValueHandling = NullValueHandling.Ignore)]
        public string TrackingUrl { get; }

        /// <summary>
        /// The [timestamp](https://developer.squareup.com/docs/build-basics/working-with-dates)
        /// indicating when the shipment was requested. The timestamp must be in RFC 3339 format
        /// (for example, "2016-09-04T23:59:33.123Z").
        /// </summary>
        [JsonProperty("placed_at", NullValueHandling = NullValueHandling.Ignore)]
        public string PlacedAt { get; }

        /// <summary>
        /// The [timestamp](https://developer.squareup.com/docs/build-basics/working-with-dates)
        /// indicating when this fulfillment was moved to the `RESERVED` state, which  indicates that preparation
        /// of this shipment has begun. The timestamp must be in RFC 3339 format (for example, "2016-09-04T23:59:33.123Z").
        /// </summary>
        [JsonProperty("in_progress_at", NullValueHandling = NullValueHandling.Ignore)]
        public string InProgressAt { get; }

        /// <summary>
        /// The [timestamp](https://developer.squareup.com/docs/build-basics/working-with-dates)
        /// indicating when this fulfillment was moved to the `PREPARED` state, which indicates that the
        /// fulfillment is packaged. The timestamp must be in RFC 3339 format (for example, "2016-09-04T23:59:33.123Z").
        /// </summary>
        [JsonProperty("packaged_at", NullValueHandling = NullValueHandling.Ignore)]
        public string PackagedAt { get; }

        /// <summary>
        /// The [timestamp](https://developer.squareup.com/docs/build-basics/working-with-dates)
        /// indicating when the shipment is expected to be delivered to the shipping carrier.
        /// The timestamp must be in RFC 3339 format (for example, "2016-09-04T23:59:33.123Z").
        /// </summary>
        [JsonProperty("expected_shipped_at", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpectedShippedAt { get; }

        /// <summary>
        /// The [timestamp](https://developer.squareup.com/docs/build-basics/working-with-dates)
        /// indicating when this fulfillment was moved to the `COMPLETED` state, which indicates that
        /// the fulfillment has been given to the shipping carrier. The timestamp must be in RFC 3339 format
        /// (for example, "2016-09-04T23:59:33.123Z").
        /// </summary>
        [JsonProperty("shipped_at", NullValueHandling = NullValueHandling.Ignore)]
        public string ShippedAt { get; }

        /// <summary>
        /// The [timestamp](https://developer.squareup.com/docs/build-basics/working-with-dates)
        /// indicating the shipment was canceled.
        /// The timestamp must be in RFC 3339 format (for example, "2016-09-04T23:59:33.123Z").
        /// </summary>
        [JsonProperty("canceled_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CanceledAt { get; }

        /// <summary>
        /// A description of why the shipment was canceled.
        /// </summary>
        [JsonProperty("cancel_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string CancelReason { get; }

        /// <summary>
        /// The [timestamp](https://developer.squareup.com/docs/build-basics/working-with-dates)
        /// indicating when the shipment failed to be completed. The timestamp must be in RFC 3339 format
        /// (for example, "2016-09-04T23:59:33.123Z").
        /// </summary>
        [JsonProperty("failed_at", NullValueHandling = NullValueHandling.Ignore)]
        public string FailedAt { get; }

        /// <summary>
        /// A description of why the shipment failed to be completed.
        /// </summary>
        [JsonProperty("failure_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string FailureReason { get; }

        /// </summary>
        [JsonProperty("schedule_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ScheduledType { get; }

        /// <summary>
        /// The timestamp that represents the start of the delivery period. The timestamp must be in RFC 3339 format (for example, "2016-09-04T23:59:33.123Z"). For a fulfillment with the schedule type ASAP, this is automatically set to the current time plus the expected duration to prepare the fulfillment.
        /// </summary>
        [JsonProperty("deliver_at", NullValueHandling = NullValueHandling.Ignore)]
        public string DeliverAt { get; }

        /// <summary>
        /// The duration of time it takes to prepare and deliver this fulfillment. The timestamp must be in RFC 3339 format (for example, "P1W3D").
        /// </summary>
        [JsonProperty("prep_time_duration", NullValueHandling = NullValueHandling.Ignore)]
        public string PrepTimeDuration { get; }

        /// <summary>
        /// The period of time in which the order should be delivered after the deliver_at timestamp. The timestamp must be in RFC 3339 format (for example, "P1W3D").
        /// </summary>
        [JsonProperty("delivery_window_duration", NullValueHandling = NullValueHandling.Ignore)]
        public string DeliveryWindowDuration { get; }

        /// <summary>
        /// A note meant to provide additional instructions about the delivery fulfillment displayed in the Square Point of Sale application and set by the API.
        /// </summary>
        [JsonProperty("note", NullValueHandling = NullValueHandling.Ignore)]
        public string Note { get; }


        /// <summary>
        /// The timestamp indicating when the fulfillment was completed. After the courier picked up the order, the order should be marked as completed by the seller. The timestamp must be in RFC 3339 format(for example, "2016-09-04T23:59:33.123Z").

        /// </summary>
        [JsonProperty("completed_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CompletedAt { get; }

        /// <summary>
        /// The timestamp that represents the start of the delivery period. The timestamp must be in RFC 3339 format (for example, "2016-09-04T23:59:33.123Z"). For a fulfillment with the schedule type ASAP, this is automatically set to the current time plus the expected duration to prepare the fulfillment.
        /// </summary>
        [JsonProperty("rejected_at", NullValueHandling = NullValueHandling.Ignore)]
        public string RejectedAt { get; }

        /// <summary>
        /// The timestamp that represents the start of the delivery period. The timestamp must be in RFC 3339 format (for example, "2016-09-04T23:59:33.123Z"). For a fulfillment with the schedule type ASAP, this is automatically set to the current time plus the expected duration to prepare the fulfillment.
        /// </summary>
        [JsonProperty("ready_at", NullValueHandling = NullValueHandling.Ignore)]
        public string ReadyAt { get; }

        /// <summary>
        /// The timestamp that represents the start of the delivery period. The timestamp must be in RFC 3339 format (for example, "2016-09-04T23:59:33.123Z"). For a fulfillment with the schedule type ASAP, this is automatically set to the current time plus the expected duration to prepare the fulfillment.
        /// </summary>
        [JsonProperty("delivered_at", NullValueHandling = NullValueHandling.Ignore)]
        public string DeliveredAt { get; }

        /// <summary>
        /// The timestamp that represents the start of the delivery period. The timestamp must be in RFC 3339 format (for example, "2016-09-04T23:59:33.123Z"). For a fulfillment with the schedule type ASAP, this is automatically set to the current time plus the expected duration to prepare the fulfillment.
        /// </summary>
        [JsonProperty("courier_pickup_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CourierPickupAt { get; }

        /// <summary>
        /// The timestamp that represents the start of the delivery period. The timestamp must be in RFC 3339 format (for example, "2016-09-04T23:59:33.123Z"). For a fulfillment with the schedule type ASAP, this is automatically set to the current time plus the expected duration to prepare the fulfillment.
        /// </summary>
        [JsonProperty("courier_pickup_window_duration", NullValueHandling = NullValueHandling.Ignore)]
        public string CourierPickupWindowDuration { get; }

        /// <summary>
        /// The timestamp that represents the start of the delivery period. The timestamp must be in RFC 3339 format (for example, "2016-09-04T23:59:33.123Z"). For a fulfillment with the schedule type ASAP, this is automatically set to the current time plus the expected duration to prepare the fulfillment.
        /// </summary>
        [JsonProperty("Is_no_contact_delivery", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsNoContactDelivery { get; }

        /// <summary>
        /// The timestamp that represents the start of the delivery period. The timestamp must be in RFC 3339 format (for example, "2016-09-04T23:59:33.123Z"). For a fulfillment with the schedule type ASAP, this is automatically set to the current time plus the expected duration to prepare the fulfillment.
        /// </summary>
        [JsonProperty("courier_provider_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CourierProviderName { get; }

        /// <summary>
        /// The timestamp that represents the start of the delivery period. The timestamp must be in RFC 3339 format (for example, "2016-09-04T23:59:33.123Z"). For a fulfillment with the schedule type ASAP, this is automatically set to the current time plus the expected duration to prepare the fulfillment.
        /// </summary>
        [JsonProperty("courier_support_phone_number", NullValueHandling = NullValueHandling.Ignore)]
        public string CourierSupportPhoneNumber { get; }

        /// <summary>
        /// The timestamp that represents the start of the delivery period. The timestamp must be in RFC 3339 format (for example, "2016-09-04T23:59:33.123Z"). For a fulfillment with the schedule type ASAP, this is automatically set to the current time plus the expected duration to prepare the fulfillment.
        /// </summary>
        [JsonProperty("dropoff_notes", NullValueHandling = NullValueHandling.Ignore)]
        public string DropoffNotes { get; }

        /// <summary>
        /// The timestamp that represents the start of the delivery period. The timestamp must be in RFC 3339 format (for example, "2016-09-04T23:59:33.123Z"). For a fulfillment with the schedule type ASAP, this is automatically set to the current time plus the expected duration to prepare the fulfillment.
        /// </summary>
        [JsonProperty("square_delivery_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SquareDeliverId { get; }

        /// <summary>
        /// The timestamp that represents the start of the delivery period. The timestamp must be in RFC 3339 format (for example, "2016-09-04T23:59:33.123Z"). For a fulfillment with the schedule type ASAP, this is automatically set to the current time plus the expected duration to prepare the fulfillment.
        /// </summary>
        [JsonProperty("external_delivery_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalDeliveryId { get; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"OrderFulfillmentDeliveryDetails : ({string.Join(", ", toStringOutput)})";
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

            return obj is OrderFulfillmentDeliveryDetails other &&
                ((this.Recipient == null && other.Recipient == null) || (this.Recipient?.Equals(other.Recipient) == true)) &&
                ((this.Carrier == null && other.Carrier == null) || (this.Carrier?.Equals(other.Carrier) == true)) &&
                ((this.ShippingNote == null && other.ShippingNote == null) || (this.ShippingNote?.Equals(other.ShippingNote) == true)) &&
                ((this.ShippingType == null && other.ShippingType == null) || (this.ShippingType?.Equals(other.ShippingType) == true)) &&
                ((this.TrackingNumber == null && other.TrackingNumber == null) || (this.TrackingNumber?.Equals(other.TrackingNumber) == true)) &&
                ((this.TrackingUrl == null && other.TrackingUrl == null) || (this.TrackingUrl?.Equals(other.TrackingUrl) == true)) &&
                ((this.PlacedAt == null && other.PlacedAt == null) || (this.PlacedAt?.Equals(other.PlacedAt) == true)) &&
                ((this.InProgressAt == null && other.InProgressAt == null) || (this.InProgressAt?.Equals(other.InProgressAt) == true)) &&
                ((this.PackagedAt == null && other.PackagedAt == null) || (this.PackagedAt?.Equals(other.PackagedAt) == true)) &&
                ((this.ExpectedShippedAt == null && other.ExpectedShippedAt == null) || (this.ExpectedShippedAt?.Equals(other.ExpectedShippedAt) == true)) &&
                ((this.ShippedAt == null && other.ShippedAt == null) || (this.ShippedAt?.Equals(other.ShippedAt) == true)) &&
                ((this.CanceledAt == null && other.CanceledAt == null) || (this.CanceledAt?.Equals(other.CanceledAt) == true)) &&
                ((this.CancelReason == null && other.CancelReason == null) || (this.CancelReason?.Equals(other.CancelReason) == true)) &&
                ((this.FailedAt == null && other.FailedAt == null) || (this.FailedAt?.Equals(other.FailedAt) == true)) &&
                ((this.FailureReason == null && other.FailureReason == null) || (this.FailureReason?.Equals(other.FailureReason) == true)) &&
                ((this.ScheduledType == null && other.ScheduledType == null) || (this.ScheduledType?.Equals(other.ScheduledType) == true)) &&
                ((this.PrepTimeDuration == null && other.PrepTimeDuration == null) || (this.PrepTimeDuration?.Equals(other.PrepTimeDuration) == true)) &&
                ((this.DeliverAt == null && other.DeliverAt == null) || (this.DeliverAt?.Equals(other.DeliverAt) == true)) &&
                ((this.DeliveryWindowDuration == null && other.DeliveryWindowDuration == null) || (this.DeliveryWindowDuration?.Equals(other.DeliveryWindowDuration) == true)) &&
                ((this.Note == null && other.Note == null) || (this.Note?.Equals(other.Note) == true)) &&
                ((this.CompletedAt == null && other.CompletedAt == null) || (this.CompletedAt?.Equals(other.CompletedAt) == true)) &&
                ((this.RejectedAt == null && other.RejectedAt == null) || (this.RejectedAt?.Equals(other.RejectedAt) == true)) &&
                ((this.ReadyAt == null && other.ReadyAt == null) || (this.ReadyAt?.Equals(other.ReadyAt) == true)) &&
                ((this.CourierPickupAt == null && other.CourierPickupAt == null) || (this.CourierPickupAt?.Equals(other.CourierPickupAt) == true)) &&
                ((this.CourierPickupWindowDuration == null && other.CourierPickupWindowDuration == null) || (this.CourierPickupWindowDuration?.Equals(other.CourierPickupWindowDuration) == true)) &&
                //((this.IsNoContactDelivery == null && other.IsNoContactDelivery == null) || (this.IsNoContactDelivery?.Equals(other.IsNoContactDelivery) == true)) &&
                ((this.IsNoContactDelivery == false && other.IsNoContactDelivery == false) || (this.IsNoContactDelivery.Equals(other.IsNoContactDelivery) == true)) &&
                ((this.CourierProviderName == null && other.CourierProviderName == null) || (this.CourierProviderName?.Equals(other.CourierProviderName) == true)) &&
                ((this.CourierSupportPhoneNumber == null && other.CourierSupportPhoneNumber == null) || (this.CourierSupportPhoneNumber?.Equals(other.CourierSupportPhoneNumber) == true)) &&
                ((this.DropoffNotes == null && other.DropoffNotes == null) || (this.DropoffNotes?.Equals(other.DropoffNotes) == true)) &&
                ((this.SquareDeliverId == null && other.SquareDeliverId == null) || (this.SquareDeliverId?.Equals(other.SquareDeliverId) == true)) &&
                ((this.ExternalDeliveryId == null && other.ExternalDeliveryId == null) || (this.ExternalDeliveryId?.Equals(other.ExternalDeliveryId) == true));
        }
        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1108362053;
            hashCode = HashCode.Combine(this.Recipient, this.Carrier, this.ShippingNote, this.ShippingType, this.TrackingNumber, this.TrackingUrl, this.PlacedAt);

            hashCode = HashCode.Combine(hashCode, this.InProgressAt, this.PackagedAt, this.ExpectedShippedAt, this.ShippedAt, this.CanceledAt, this.CancelReason, this.FailedAt);

            hashCode = HashCode.Combine(hashCode, this.FailureReason);

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Recipient = {(this.Recipient == null ? "null" : this.Recipient.ToString())}");
            toStringOutput.Add($"this.Carrier = {(this.Carrier == null ? "null" : this.Carrier == string.Empty ? "" : this.Carrier)}");
            toStringOutput.Add($"this.ShippingNote = {(this.ShippingNote == null ? "null" : this.ShippingNote == string.Empty ? "" : this.ShippingNote)}");
            toStringOutput.Add($"this.ShippingType = {(this.ShippingType == null ? "null" : this.ShippingType == string.Empty ? "" : this.ShippingType)}");
            toStringOutput.Add($"this.TrackingNumber = {(this.TrackingNumber == null ? "null" : this.TrackingNumber == string.Empty ? "" : this.TrackingNumber)}");
            toStringOutput.Add($"this.TrackingUrl = {(this.TrackingUrl == null ? "null" : this.TrackingUrl == string.Empty ? "" : this.TrackingUrl)}");
            toStringOutput.Add($"this.PlacedAt = {(this.PlacedAt == null ? "null" : this.PlacedAt == string.Empty ? "" : this.PlacedAt)}");
            toStringOutput.Add($"this.InProgressAt = {(this.InProgressAt == null ? "null" : this.InProgressAt == string.Empty ? "" : this.InProgressAt)}");
            toStringOutput.Add($"this.PackagedAt = {(this.PackagedAt == null ? "null" : this.PackagedAt == string.Empty ? "" : this.PackagedAt)}");
            toStringOutput.Add($"this.ExpectedShippedAt = {(this.ExpectedShippedAt == null ? "null" : this.ExpectedShippedAt == string.Empty ? "" : this.ExpectedShippedAt)}");
            toStringOutput.Add($"this.ShippedAt = {(this.ShippedAt == null ? "null" : this.ShippedAt == string.Empty ? "" : this.ShippedAt)}");
            toStringOutput.Add($"this.CanceledAt = {(this.CanceledAt == null ? "null" : this.CanceledAt == string.Empty ? "" : this.CanceledAt)}");
            toStringOutput.Add($"this.CancelReason = {(this.CancelReason == null ? "null" : this.CancelReason == string.Empty ? "" : this.CancelReason)}");
            toStringOutput.Add($"this.FailedAt = {(this.FailedAt == null ? "null" : this.FailedAt == string.Empty ? "" : this.FailedAt)}");
            toStringOutput.Add($"this.FailureReason = {(this.FailureReason == null ? "null" : this.FailureReason == string.Empty ? "" : this.FailureReason)}");
            toStringOutput.Add($"this.ScheduledType = {(this.ScheduledType == null ? "null" : this.ScheduledType == string.Empty ? "" : this.ScheduledType)}");
            toStringOutput.Add($"this.PrepTimeDuration = {(this.PrepTimeDuration == null ? "null" : this.PrepTimeDuration == string.Empty ? "" : this.PrepTimeDuration)}");
            toStringOutput.Add($"this.DeliverAt = {(this.DeliverAt == null ? "null" : this.DeliverAt == string.Empty ? "" : this.DeliverAt)}");
            toStringOutput.Add($"this.DeliveryWindowDuration = {(this.DeliveryWindowDuration == null ? "null" : this.DeliveryWindowDuration == string.Empty ? "" : this.DeliveryWindowDuration)}");
            toStringOutput.Add($"this.Note = {(this.Note == null ? "null" : this.Note == string.Empty ? "" : this.Note)}");
            toStringOutput.Add($"this.CompletedAt = {(this.CompletedAt == null ? "null" : this.CompletedAt == string.Empty ? "" : this.CompletedAt)}");
            toStringOutput.Add($"this.RejectedAt = {(this.RejectedAt == null ? "null" : this.RejectedAt == string.Empty ? "" : this.RejectedAt)}");
            toStringOutput.Add($"this.CourierPickupAt = {(this.CourierPickupAt == null ? "null" : this.CourierPickupAt == string.Empty ? "" : this.CourierPickupAt)}");
            toStringOutput.Add($"this.CourierPickupWindowDuration = {(this.CourierPickupWindowDuration == null ? "null" : this.CourierPickupWindowDuration == string.Empty ? "" : this.CourierPickupWindowDuration)}");
            toStringOutput.Add($"this.IsNoContactDelivery = {(this.IsNoContactDelivery == false ? false : this.IsNoContactDelivery == false ? false : this.IsNoContactDelivery)}");
            toStringOutput.Add($"this.CourierProviderName = {(this.CourierProviderName == null ? "null" : this.CourierProviderName == string.Empty ? "" : this.CourierProviderName)}");
            toStringOutput.Add($"this.CourierSupportPhoneNumber = {(this.CourierSupportPhoneNumber == null ? "null" : this.CourierSupportPhoneNumber == string.Empty ? "" : this.CourierSupportPhoneNumber)}");
            toStringOutput.Add($"this.DropoffNotes = {(this.DropoffNotes == null ? "null" : this.DropoffNotes == string.Empty ? "" : this.DropoffNotes)}");
            toStringOutput.Add($"this.SquareDeliverId = {(this.SquareDeliverId == null ? "null" : this.SquareDeliverId == string.Empty ? "" : this.SquareDeliverId)}");
            toStringOutput.Add($"this.ExternalDeliveryId = {(this.ExternalDeliveryId == null ? "null" : this.ExternalDeliveryId == string.Empty ? "" : this.ExternalDeliveryId)}");
        }

        /// <summary>
        /// Converts to builder object.
        /// </summary>
        /// <returns> Builder. </returns>
        public Builder ToBuilder()
        {
            var builder = new Builder()
                .Recipient(this.Recipient)
                .Carrier(this.Carrier)
                .ShippingNote(this.ShippingNote)
                .ShippingType(this.ShippingType)
                .TrackingNumber(this.TrackingNumber)
                .TrackingUrl(this.TrackingUrl)
                .PlacedAt(this.PlacedAt)
                .InProgressAt(this.InProgressAt)
                .PackagedAt(this.PackagedAt)
                .ExpectedShippedAt(this.ExpectedShippedAt)
                .ShippedAt(this.ShippedAt)
                .CanceledAt(this.CanceledAt)
                .CancelReason(this.CancelReason)
                .FailedAt(this.FailedAt)
                .FailureReason(this.FailureReason)
                .ScheduledType(this.ScheduledType)
                .PrepTimeDuration(this.PrepTimeDuration)
                .DeliveredAt(this.DeliveredAt)
                .DeliveryWindowDuration(this.DeliveryWindowDuration)
                .Note(this.Note)
                .CompletedAt(this.CompletedAt)
                .RejectedAt(this.RejectedAt)
                .ReadyAt(this.ReadyAt)
                .CourierPickupAt(this.CourierPickupAt)
                .CourierPickupWindowDuration(this.CourierPickupWindowDuration)
                .IsNoContactDelivery(this.IsNoContactDelivery)
                .CourierProviderName(this.CourierProviderName)
                .CourierSupportPhoneNumber(this.CourierSupportPhoneNumber)
                .DropoffNotes(this.DropoffNotes)
                .SquareDeliveryId(this.SquareDeliverId)
                .ExternalDeliveyId(this.ExternalDeliveryId);
            return builder;
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private Models.OrderFulfillmentRecipient recipient;
            private string carrier;
            private string shippingNote;
            private string shippingType;
            private string trackingNumber;
            private string trackingUrl;
            private string placedAt;
            private string inProgressAt;
            private string packagedAt;
            private string expectedShippedAt;
            private string shippedAt;
            private string canceledAt;
            private string cancelReason;
            private string failedAt;
            private string failureReason;
            private string scheduledType;
            private string prepTimeDuration;
            private string deliveredAt;
            private string deliveryWindowDuration;
            private string note;
            private string completedAt;
            private string rejectedAt;
            private string readyAt;
            private string courierPickupAt;
            private string courierPickupWindowDuration;
            private bool isNoContactDelivery;
            private string courierProviderName;
            private string courierSupportPhoneNumber;
            private string dropoffNotes;
            private string squareDeliveryId;
            private string externalDeliveyId;

            /// <summary>
            /// Recipient.
            /// </summary>
            /// <param name="recipient"> recipient. </param>
            /// <returns> Builder. </returns>
            public Builder Recipient(Models.OrderFulfillmentRecipient recipient)
            {
                this.recipient = recipient;
                return this;
            }

            /// <summary>
            /// Carrier.
            /// </summary>
            /// <param name="carrier"> carrier. </param>
            /// <returns> Builder. </returns>
            public Builder Carrier(string carrier)
            {
                this.carrier = carrier;
                return this;
            }

            /// <summary>
            /// ShippingNote.
            /// </summary>
            /// <param name="shippingNote"> shippingNote. </param>
            /// <returns> Builder. </returns>
            public Builder ShippingNote(string shippingNote)
            {
                this.shippingNote = shippingNote;
                return this;
            }

            /// <summary>
            /// ShippingType.
            /// </summary>
            /// <param name="shippingType"> shippingType. </param>
            /// <returns> Builder. </returns>
            public Builder ShippingType(string shippingType)
            {
                this.shippingType = shippingType;
                return this;
            }

            /// <summary>
            /// TrackingNumber.
            /// </summary>
            /// <param name="trackingNumber"> trackingNumber. </param>
            /// <returns> Builder. </returns>
            public Builder TrackingNumber(string trackingNumber)
            {
                this.trackingNumber = trackingNumber;
                return this;
            }

            /// <summary>
            /// TrackingUrl.
            /// </summary>
            /// <param name="trackingUrl"> trackingUrl. </param>
            /// <returns> Builder. </returns>
            public Builder TrackingUrl(string trackingUrl)
            {
                this.trackingUrl = trackingUrl;
                return this;
            }

            /// <summary>
            /// PlacedAt.
            /// </summary>
            /// <param name="placedAt"> placedAt. </param>
            /// <returns> Builder. </returns>
            public Builder PlacedAt(string placedAt)
            {
                this.placedAt = placedAt;
                return this;
            }

            /// <summary>
            /// InProgressAt.
            /// </summary>
            /// <param name="inProgressAt"> inProgressAt. </param>
            /// <returns> Builder. </returns>
            public Builder InProgressAt(string inProgressAt)
            {
                this.inProgressAt = inProgressAt;
                return this;
            }

            /// <summary>
            /// PackagedAt.
            /// </summary>
            /// <param name="packagedAt"> packagedAt. </param>
            /// <returns> Builder. </returns>
            public Builder PackagedAt(string packagedAt)
            {
                this.packagedAt = packagedAt;
                return this;
            }

            /// <summary>
            /// ExpectedShippedAt.
            /// </summary>
            /// <param name="expectedShippedAt"> expectedShippedAt. </param>
            /// <returns> Builder. </returns>
            public Builder ExpectedShippedAt(string expectedShippedAt)
            {
                this.expectedShippedAt = expectedShippedAt;
                return this;
            }

            /// <summary>
            /// ShippedAt.
            /// </summary>
            /// <param name="shippedAt"> shippedAt. </param>
            /// <returns> Builder. </returns>
            public Builder ShippedAt(string shippedAt)
            {
                this.shippedAt = shippedAt;
                return this;
            }

            /// <summary>
            /// CanceledAt.
            /// </summary>
            /// <param name="canceledAt"> canceledAt. </param>
            /// <returns> Builder. </returns>
            public Builder CanceledAt(string canceledAt)
            {
                this.canceledAt = canceledAt;
                return this;
            }

            /// <summary>
            /// CancelReason.
            /// </summary>
            /// <param name="cancelReason"> cancelReason. </param>
            /// <returns> Builder. </returns>
            public Builder CancelReason(string cancelReason)
            {
                this.cancelReason = cancelReason;
                return this;
            }

            /// <summary>
            /// FailedAt.
            /// </summary>
            /// <param name="failedAt"> failedAt. </param>
            /// <returns> Builder. </returns>
            public Builder FailedAt(string failedAt)
            {
                this.failedAt = failedAt;
                return this;
            }

            /// <summary>
            /// FailureReason.
            /// </summary>
            /// <param name="failureReason"> failureReason. </param>
            /// <returns> Builder. </returns>
            public Builder FailureReason(string failureReason)
            {
                this.failureReason = failureReason;
                return this;
            }
            public Builder ScheduledType(string scheduledType)
            {
                this.scheduledType = scheduledType;
                return this;
            }

            public Builder PrepTimeDuration(string prepTimeDuration)
            {
                this.prepTimeDuration = prepTimeDuration;
                return this;
            }

            public Builder DeliveredAt(string deliveredAt)
            {
                this.deliveredAt = deliveredAt;
                return this;
            }

            public Builder DeliveryWindowDuration(string deliveryWindowDuration)
            {
                this.deliveryWindowDuration = deliveryWindowDuration;
                return this;
            }

            public Builder Note(string note)
            {
                this.note = note;
                return this;
            }

            public Builder CompletedAt(string completedAt)
            {
                this.completedAt = completedAt;
                return this;
            }

            public Builder RejectedAt(string rejectedAt)
            {
                this.rejectedAt = rejectedAt;
                return this;
            }

            public Builder ReadyAt(string readyAt)
            {
                this.readyAt = readyAt;
                return this;
            }

            public Builder CourierPickupWindowDuration(string courierPickupWindowDuration)
            {
                this.courierPickupWindowDuration = courierPickupWindowDuration;
                return this;
            }

            public Builder IsNoContactDelivery(bool isNoContactDelivery)
            {
                this.isNoContactDelivery = isNoContactDelivery;
                return this;
            }

            public Builder CourierProviderName(string courierProviderName)
            {
                this.courierProviderName = courierProviderName;
                return this;
            }

            public Builder CourierSupportPhoneNumber(string courierSupportPhoneNumber)
            {
                this.courierSupportPhoneNumber = courierSupportPhoneNumber;
                return this;
            }

            public Builder DropoffNotes(string dropoffNotes)
            {
                this.dropoffNotes = dropoffNotes;
                return this;
            }

            public Builder SquareDeliveryId(string squareDeliveryId)
            {
                this.squareDeliveryId = squareDeliveryId;
                return this;
            }

            public Builder ExternalDeliveyId(string externalDeliveyId)
            {
                this.externalDeliveyId = externalDeliveyId;
                return this;
            }

            public Builder CourierPickupAt(string courierPickupAt)
            {
                this.courierPickupAt = courierPickupAt;
                return this;
            }

            /// <summary>
            /// Builds class object.
            /// </summary>
            /// <returns> OrderFulfillmentDeliveryDetails. </returns>
            public OrderFulfillmentDeliveryDetails Build()
            {
                return new OrderFulfillmentDeliveryDetails(
                    this.recipient,
                    this.carrier,
                    this.shippingNote,
                    this.shippingType,
                    this.trackingNumber,
                    this.trackingUrl,
                    this.placedAt,
                    this.inProgressAt,
                    this.packagedAt,
                    this.expectedShippedAt,
                    this.shippedAt,
                    this.canceledAt,
                    this.cancelReason,
                    this.failedAt,
                    this.failureReason,
                    this.scheduledType,
                    this.prepTimeDuration,
                    this.deliveredAt,
                    this.deliveryWindowDuration,
                    this.note,
                    this.completedAt,
                    this.rejectedAt,
                    this.readyAt,
                    this.courierPickupAt,
                    this.courierPickupWindowDuration,
                    this.isNoContactDelivery,
                    this.courierProviderName,
                    this.courierSupportPhoneNumber,
                    this.dropoffNotes,
                    this.squareDeliveryId,
                    this.externalDeliveyId);
            }
        }
    }
}