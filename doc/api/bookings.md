# Bookings

```csharp
IBookingsApi bookingsApi = client.BookingsApi;
```

## Class Name

`BookingsApi`

## Methods

* [List Bookings](../../doc/api/bookings.md#list-bookings)
* [Create Booking](../../doc/api/bookings.md#create-booking)
* [Search Availability](../../doc/api/bookings.md#search-availability)
* [Retrieve Business Booking Profile](../../doc/api/bookings.md#retrieve-business-booking-profile)
* [List Team Member Booking Profiles](../../doc/api/bookings.md#list-team-member-booking-profiles)
* [Retrieve Team Member Booking Profile](../../doc/api/bookings.md#retrieve-team-member-booking-profile)
* [Retrieve Booking](../../doc/api/bookings.md#retrieve-booking)
* [Update Booking](../../doc/api/bookings.md#update-booking)
* [Cancel Booking](../../doc/api/bookings.md#cancel-booking)


# List Bookings

Retrieve a collection of bookings.

To call this endpoint with buyer-level permissions, set `APPOINTMENTS_READ` for the OAuth scope.
To call this endpoint with seller-level permissions, set `APPOINTMENTS_ALL_READ` and `APPOINTMENTS_READ` for the OAuth scope.

```csharp
ListBookingsAsync(
    int? limit = null,
    string cursor = null,
    string teamMemberId = null,
    string locationId = null,
    string startAtMin = null,
    string startAtMax = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `limit` | `int?` | Query, Optional | The maximum number of results per page to return in a paged response. |
| `cursor` | `string` | Query, Optional | The pagination cursor from the preceding response to return the next page of the results. Do not set this when retrieving the first page of the results. |
| `teamMemberId` | `string` | Query, Optional | The team member for whom to retrieve bookings. If this is not set, bookings of all members are retrieved. |
| `locationId` | `string` | Query, Optional | The location for which to retrieve bookings. If this is not set, all locations' bookings are retrieved. |
| `startAtMin` | `string` | Query, Optional | The RFC 3339 timestamp specifying the earliest of the start time. If this is not set, the current time is used. |
| `startAtMax` | `string` | Query, Optional | The RFC 3339 timestamp specifying the latest of the start time. If this is not set, the time of 31 days after `start_at_min` is used. |

## Response Type

[`Task<Models.ListBookingsResponse>`](../../doc/models/list-bookings-response.md)

## Example Usage

```csharp
try
{
    ListBookingsResponse result = await bookingsApi.ListBookingsAsync(null, null, null, null, null, null);
}
catch (ApiException e){};
```


# Create Booking

Creates a booking.

To call this endpoint with buyer-level permissions, set `APPOINTMENTS_WRITE` for the OAuth scope.
To call this endpoint with seller-level permissions, set `APPOINTMENTS_ALL_WRITE` and `APPOINTMENTS_WRITE` for the OAuth scope.

For calls to this endpoint with seller-level permissions to succeed, the seller must have subscribed to *Appointments Plus*
or *Appointments Premium*.

```csharp
CreateBookingAsync(
    Models.CreateBookingRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.CreateBookingRequest`](../../doc/models/create-booking-request.md) | Body, Required | An object containing the fields to POST for the request.<br><br>See the corresponding object definition for field details. |

## Response Type

[`Task<Models.CreateBookingResponse>`](../../doc/models/create-booking-response.md)

## Example Usage

```csharp
var bodyBooking = new Booking.Builder()
    .Build();
var body = new CreateBookingRequest.Builder(
        bodyBooking)
    .Build();

try
{
    CreateBookingResponse result = await bookingsApi.CreateBookingAsync(body);
}
catch (ApiException e){};
```


# Search Availability

Searches for availabilities for booking.

To call this endpoint with buyer-level permissions, set `APPOINTMENTS_READ` for the OAuth scope.
To call this endpoint with seller-level permissions, set `APPOINTMENTS_ALL_READ` and `APPOINTMENTS_READ` for the OAuth scope.

```csharp
SearchAvailabilityAsync(
    Models.SearchAvailabilityRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.SearchAvailabilityRequest`](../../doc/models/search-availability-request.md) | Body, Required | An object containing the fields to POST for the request.<br><br>See the corresponding object definition for field details. |

## Response Type

[`Task<Models.SearchAvailabilityResponse>`](../../doc/models/search-availability-response.md)

## Example Usage

```csharp
var bodyQueryFilterStartAtRange = new TimeRange.Builder()
    .Build();
var bodyQueryFilter = new SearchAvailabilityFilter.Builder(
        bodyQueryFilterStartAtRange)
    .Build();
var bodyQuery = new SearchAvailabilityQuery.Builder(
        bodyQueryFilter)
    .Build();
var body = new SearchAvailabilityRequest.Builder(
        bodyQuery)
    .Build();

try
{
    SearchAvailabilityResponse result = await bookingsApi.SearchAvailabilityAsync(body);
}
catch (ApiException e){};
```


# Retrieve Business Booking Profile

Retrieves a seller's booking profile.

```csharp
RetrieveBusinessBookingProfileAsync()
```

## Response Type

[`Task<Models.RetrieveBusinessBookingProfileResponse>`](../../doc/models/retrieve-business-booking-profile-response.md)

## Example Usage

```csharp
try
{
    RetrieveBusinessBookingProfileResponse result = await bookingsApi.RetrieveBusinessBookingProfileAsync();
}
catch (ApiException e){};
```


# List Team Member Booking Profiles

Lists booking profiles for team members.

```csharp
ListTeamMemberBookingProfilesAsync(
    bool? bookableOnly = false,
    int? limit = null,
    string cursor = null,
    string locationId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `bookableOnly` | `bool?` | Query, Optional | Indicates whether to include only bookable team members in the returned result (`true`) or not (`false`).<br>**Default**: `false` |
| `limit` | `int?` | Query, Optional | The maximum number of results to return in a paged response. |
| `cursor` | `string` | Query, Optional | The pagination cursor from the preceding response to return the next page of the results. Do not set this when retrieving the first page of the results. |
| `locationId` | `string` | Query, Optional | Indicates whether to include only team members enabled at the given location in the returned result. |

## Response Type

[`Task<Models.ListTeamMemberBookingProfilesResponse>`](../../doc/models/list-team-member-booking-profiles-response.md)

## Example Usage

```csharp
bool? bookableOnly = false;

try
{
    ListTeamMemberBookingProfilesResponse result = await bookingsApi.ListTeamMemberBookingProfilesAsync(bookableOnly, null, null, null);
}
catch (ApiException e){};
```


# Retrieve Team Member Booking Profile

Retrieves a team member's booking profile.

```csharp
RetrieveTeamMemberBookingProfileAsync(
    string teamMemberId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `teamMemberId` | `string` | Template, Required | The ID of the team member to retrieve. |

## Response Type

[`Task<Models.RetrieveTeamMemberBookingProfileResponse>`](../../doc/models/retrieve-team-member-booking-profile-response.md)

## Example Usage

```csharp
string teamMemberId = "team_member_id0";

try
{
    RetrieveTeamMemberBookingProfileResponse result = await bookingsApi.RetrieveTeamMemberBookingProfileAsync(teamMemberId);
}
catch (ApiException e){};
```


# Retrieve Booking

Retrieves a booking.

To call this endpoint with buyer-level permissions, set `APPOINTMENTS_READ` for the OAuth scope.
To call this endpoint with seller-level permissions, set `APPOINTMENTS_ALL_READ` and `APPOINTMENTS_READ` for the OAuth scope.

```csharp
RetrieveBookingAsync(
    string bookingId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `bookingId` | `string` | Template, Required | The ID of the [Booking](../../doc/models/booking.md) object representing the to-be-retrieved booking. |

## Response Type

[`Task<Models.RetrieveBookingResponse>`](../../doc/models/retrieve-booking-response.md)

## Example Usage

```csharp
string bookingId = "booking_id4";

try
{
    RetrieveBookingResponse result = await bookingsApi.RetrieveBookingAsync(bookingId);
}
catch (ApiException e){};
```


# Update Booking

Updates a booking.

To call this endpoint with buyer-level permissions, set `APPOINTMENTS_WRITE` for the OAuth scope.
To call this endpoint with seller-level permissions, set `APPOINTMENTS_ALL_WRITE` and `APPOINTMENTS_WRITE` for the OAuth scope.

For calls to this endpoint with seller-level permissions to succeed, the seller must have subscribed to *Appointments Plus*
or *Appointments Premium*.

```csharp
UpdateBookingAsync(
    string bookingId,
    Models.UpdateBookingRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `bookingId` | `string` | Template, Required | The ID of the [Booking](../../doc/models/booking.md) object representing the to-be-updated booking. |
| `body` | [`Models.UpdateBookingRequest`](../../doc/models/update-booking-request.md) | Body, Required | An object containing the fields to POST for the request.<br><br>See the corresponding object definition for field details. |

## Response Type

[`Task<Models.UpdateBookingResponse>`](../../doc/models/update-booking-response.md)

## Example Usage

```csharp
string bookingId = "booking_id4";
var bodyBooking = new Booking.Builder()
    .Build();
var body = new UpdateBookingRequest.Builder(
        bodyBooking)
    .Build();

try
{
    UpdateBookingResponse result = await bookingsApi.UpdateBookingAsync(bookingId, body);
}
catch (ApiException e){};
```


# Cancel Booking

Cancels an existing booking.

To call this endpoint with buyer-level permissions, set `APPOINTMENTS_WRITE` for the OAuth scope.
To call this endpoint with seller-level permissions, set `APPOINTMENTS_ALL_WRITE` and `APPOINTMENTS_WRITE` for the OAuth scope.

For calls to this endpoint with seller-level permissions to succeed, the seller must have subscribed to *Appointments Plus*
or *Appointments Premium*.

```csharp
CancelBookingAsync(
    string bookingId,
    Models.CancelBookingRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `bookingId` | `string` | Template, Required | The ID of the [Booking](../../doc/models/booking.md) object representing the to-be-cancelled booking. |
| `body` | [`Models.CancelBookingRequest`](../../doc/models/cancel-booking-request.md) | Body, Required | An object containing the fields to POST for the request.<br><br>See the corresponding object definition for field details. |

## Response Type

[`Task<Models.CancelBookingResponse>`](../../doc/models/cancel-booking-response.md)

## Example Usage

```csharp
string bookingId = "booking_id4";
var body = new CancelBookingRequest.Builder()
    .Build();

try
{
    CancelBookingResponse result = await bookingsApi.CancelBookingAsync(bookingId, body);
}
catch (ApiException e){};
```

