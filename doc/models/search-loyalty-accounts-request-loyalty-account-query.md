
# Search Loyalty Accounts Request Loyalty Account Query

The search criteria for the loyalty accounts.

## Structure

`SearchLoyaltyAccountsRequestLoyaltyAccountQuery`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Mappings` | [`IList<Models.LoyaltyAccountMapping>`](../../doc/models/loyalty-account-mapping.md) | Optional | The set of mappings to use in the loyalty account search.<br><br>This cannot be combined with `customer_ids`.<br><br>Max: 30 mappings |
| `CustomerIds` | `IList<string>` | Optional | The set of customer IDs to use in the loyalty account search.<br><br>This cannot be combined with `mappings`.<br><br>Max: 30 customer IDs |

## Example (as JSON)

```json
{
  "mappings": null,
  "customer_ids": null
}
```

