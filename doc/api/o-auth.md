# O Auth

```csharp
IOAuthApi oAuthApi = client.OAuthApi;
```

## Class Name

`OAuthApi`

## Methods

* [Renew Token](../../doc/api/o-auth.md#renew-token)
* [Revoke Token](../../doc/api/o-auth.md#revoke-token)
* [Obtain Token](../../doc/api/o-auth.md#obtain-token)


# Renew Token

**This endpoint is deprecated.**

`RenewToken` is deprecated. For information about refreshing OAuth access tokens, see
[Migrate from Renew to Refresh OAuth Tokens](https://developer.squareup.com/docs/oauth-api/migrate-to-refresh-tokens).

Renews an OAuth access token before it expires.

OAuth access tokens besides your application's personal access token expire after 30 days.
You can also renew expired tokens within 15 days of their expiration.
You cannot renew an access token that has been expired for more than 15 days.
Instead, the associated user must recomplete the OAuth flow from the beginning.

__Important:__ The `Authorization` header for this endpoint must have the
following format:

```
Authorization: Client APPLICATION_SECRET
```

Replace `APPLICATION_SECRET` with the application secret on the Credentials
page in the [Developer Dashboard](https://developer.squareup.com/apps).

:information_source: **Note** This endpoint does not require authentication.

```csharp
RenewTokenAsync(
    string clientId,
    Models.RenewTokenRequest body,
    string authorization)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `clientId` | `string` | Template, Required | Your application ID, which is available in the OAuth page in the [Developer Dashboard](https://developer.squareup.com/apps). |
| `body` | [`Models.RenewTokenRequest`](../../doc/models/renew-token-request.md) | Body, Required | An object containing the fields to POST for the request.<br><br>See the corresponding object definition for field details. |
| `authorization` | `string` | Header, Required | Client APPLICATION_SECRET |

## Response Type

[`Task<Models.RenewTokenResponse>`](../../doc/models/renew-token-response.md)

## Example Usage

```csharp
string clientId = "client_id8";
var body = new RenewTokenRequest.Builder()
    .AccessToken("ACCESS_TOKEN")
    .Build();
string authorization = "Client CLIENT_SECRET";

try
{
    RenewTokenResponse result = await oAuthApi.RenewTokenAsync(clientId, body, authorization);
}
catch (ApiException e){};
```


# Revoke Token

Revokes an access token generated with the OAuth flow.

If an account has more than one OAuth access token for your application, this
endpoint revokes all of them, regardless of which token you specify. When an
OAuth access token is revoked, all of the active subscriptions associated
with that OAuth token are canceled immediately.

__Important:__ The `Authorization` header for this endpoint must have the
following format:

```
Authorization: Client APPLICATION_SECRET
```

Replace `APPLICATION_SECRET` with the application secret on the OAuth
page for your application on the Developer Dashboard.

:information_source: **Note** This endpoint does not require authentication.

```csharp
RevokeTokenAsync(
    Models.RevokeTokenRequest body,
    string authorization)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.RevokeTokenRequest`](../../doc/models/revoke-token-request.md) | Body, Required | An object containing the fields to POST for the request.<br><br>See the corresponding object definition for field details. |
| `authorization` | `string` | Header, Required | Client APPLICATION_SECRET |

## Response Type

[`Task<Models.RevokeTokenResponse>`](../../doc/models/revoke-token-response.md)

## Example Usage

```csharp
var body = new RevokeTokenRequest.Builder()
    .ClientId("CLIENT_ID")
    .AccessToken("ACCESS_TOKEN")
    .Build();
string authorization = "Client CLIENT_SECRET";

try
{
    RevokeTokenResponse result = await oAuthApi.RevokeTokenAsync(body, authorization);
}
catch (ApiException e){};
```


# Obtain Token

Returns an OAuth access token and a refresh token unless the
`short_lived` parameter is set to `true`, in which case the endpoint
returns only an access token.

The `grant_type` parameter specifies the type of OAuth request. If
`grant_type` is `authorization_code`, you must include the authorization
code you received when a seller granted you authorization. If `grant_type`
is `refresh_token`, you must provide a valid refresh token. If you are using
an old version of the Square APIs (prior to March 13, 2019), `grant_type`
can be `migration_token` and you must provide a valid migration token.

You can use the `scopes` parameter to limit the set of permissions granted
to the access token and refresh token. You can use the `short_lived` parameter
to create an access token that expires in 24 hours.

__Note:__ OAuth tokens should be encrypted and stored on a secure server.
Application clients should never interact directly with OAuth tokens.

:information_source: **Note** This endpoint does not require authentication.

```csharp
ObtainTokenAsync(
    Models.ObtainTokenRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.ObtainTokenRequest`](../../doc/models/obtain-token-request.md) | Body, Required | An object containing the fields to POST for the request.<br><br>See the corresponding object definition for field details. |

## Response Type

[`Task<Models.ObtainTokenResponse>`](../../doc/models/obtain-token-response.md)

## Example Usage

```csharp
var body = new ObtainTokenRequest.Builder(
        "APPLICATION_ID",
        "APPLICATION_SECRET",
        "authorization_code")
    .Code("CODE_FROM_AUTHORIZE")
    .Build();

try
{
    ObtainTokenResponse result = await oAuthApi.ObtainTokenAsync(body);
}
catch (ApiException e){};
```

