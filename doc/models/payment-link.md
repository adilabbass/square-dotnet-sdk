
# Payment Link

## Structure

`PaymentLink`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | The Square-assigned ID of the payment link. |
| `Version` | `int` | Required | The Square-assigned version number, which is incremented each time an update is committed to the payment link.<br>**Constraints**: `<= 65535` |
| `Description` | `string` | Optional | The optional description of the `payment_link` object.<br>It is primarily for use by your application and is not used anywhere.<br>**Constraints**: *Maximum Length*: `4096` |
| `OrderId` | `string` | Optional | The ID of the order associated with the payment link.<br>**Constraints**: *Maximum Length*: `192` |
| `CheckoutOptions` | [`Models.CheckoutOptions`](../../doc/models/checkout-options.md) | Optional | - |
| `PrePopulatedData` | [`Models.PrePopulatedData`](../../doc/models/pre-populated-data.md) | Optional | Describes buyer data to prepopulate in the payment form.<br>For more information,<br>see [Optional Checkout Configurations](https://developer.squareup.com/docs/checkout-api/optional-checkout-configurations). |
| `Url` | `string` | Optional | The URL of the payment link.<br>**Constraints**: *Maximum Length*: `255` |
| `CreatedAt` | `string` | Optional | The timestamp when the payment link was created, in RFC 3339 format. |
| `UpdatedAt` | `string` | Optional | The timestamp when the payment link was last updated, in RFC 3339 format. |
| `PaymentNote` | `string` | Optional | An optional note. After Square processes the payment, this note is added to the  <br>resulting `Payment`.<br>**Constraints**: *Maximum Length*: `500` |

## Example (as JSON)

```json
{
  "id": null,
  "version": 172,
  "description": null,
  "order_id": null,
  "checkout_options": null,
  "pre_populated_data": null,
  "url": null,
  "created_at": null,
  "updated_at": null,
  "payment_note": null
}
```

