
# Payout Entry

One or more PayoutEntries that make up a Payout. Each one has a date, amount, and type of activity.
The total amount of the payout will equal the sum of the payout entries for a batch payout

## Structure

`PayoutEntry`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A unique ID for the payout entry.<br>**Constraints**: *Minimum Length*: `1` |
| `PayoutId` | `string` | Required | The ID of the payout entries’ associated payout.<br>**Constraints**: *Minimum Length*: `1` |
| `EffectiveAt` | `string` | Optional | The timestamp of when the payout entry affected the balance, in RFC 3339 format. |
| `Type` | [`string`](../../doc/models/activity-type.md) | Optional | - |
| `GrossAmountMoney` | [`Models.Money`](../../doc/models/money.md) | Optional | Represents an amount of money. `Money` fields can be signed or unsigned.<br>Fields that do not explicitly define whether they are signed or unsigned are<br>considered unsigned and can only hold positive amounts. For signed fields, the<br>sign of the value indicates the purpose of the money transfer. See<br>[Working with Monetary Amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts)<br>for more information. |
| `FeeAmountMoney` | [`Models.Money`](../../doc/models/money.md) | Optional | Represents an amount of money. `Money` fields can be signed or unsigned.<br>Fields that do not explicitly define whether they are signed or unsigned are<br>considered unsigned and can only hold positive amounts. For signed fields, the<br>sign of the value indicates the purpose of the money transfer. See<br>[Working with Monetary Amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts)<br>for more information. |
| `NetAmountMoney` | [`Models.Money`](../../doc/models/money.md) | Optional | Represents an amount of money. `Money` fields can be signed or unsigned.<br>Fields that do not explicitly define whether they are signed or unsigned are<br>considered unsigned and can only hold positive amounts. For signed fields, the<br>sign of the value indicates the purpose of the money transfer. See<br>[Working with Monetary Amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts)<br>for more information. |
| `TypeAutomaticSavingsDetails` | [`Models.PaymentBalanceActivityAutomaticSavingsDetail`](../../doc/models/payment-balance-activity-automatic-savings-detail.md) | Optional | - |
| `TypeAutomaticSavingsReversedDetails` | [`Models.PaymentBalanceActivityAutomaticSavingsReversedDetail`](../../doc/models/payment-balance-activity-automatic-savings-reversed-detail.md) | Optional | - |
| `TypeChargeDetails` | [`Models.PaymentBalanceActivityChargeDetail`](../../doc/models/payment-balance-activity-charge-detail.md) | Optional | DESCRIPTION OF PaymentBalanceActivityChargeDetail |
| `TypeDepositFeeDetails` | [`Models.PaymentBalanceActivityDepositFeeDetail`](../../doc/models/payment-balance-activity-deposit-fee-detail.md) | Optional | - |
| `TypeDisputeDetails` | [`Models.PaymentBalanceActivityDisputeDetail`](../../doc/models/payment-balance-activity-dispute-detail.md) | Optional | - |
| `TypeFeeDetails` | [`Models.PaymentBalanceActivityFeeDetail`](../../doc/models/payment-balance-activity-fee-detail.md) | Optional | - |
| `TypeFreeProcessingDetails` | [`Models.PaymentBalanceActivityFreeProcessingDetail`](../../doc/models/payment-balance-activity-free-processing-detail.md) | Optional | - |
| `TypeHoldAdjustmentDetails` | [`Models.PaymentBalanceActivityHoldAdjustmentDetail`](../../doc/models/payment-balance-activity-hold-adjustment-detail.md) | Optional | - |
| `TypeOpenDisputeDetails` | [`Models.PaymentBalanceActivityOpenDisputeDetail`](../../doc/models/payment-balance-activity-open-dispute-detail.md) | Optional | - |
| `TypeOtherDetails` | [`Models.PaymentBalanceActivityOtherDetail`](../../doc/models/payment-balance-activity-other-detail.md) | Optional | - |
| `TypeOtherAdjustmentDetails` | [`Models.PaymentBalanceActivityOtherAdjustmentDetail`](../../doc/models/payment-balance-activity-other-adjustment-detail.md) | Optional | - |
| `TypeRefundDetails` | [`Models.PaymentBalanceActivityRefundDetail`](../../doc/models/payment-balance-activity-refund-detail.md) | Optional | - |
| `TypeReleaseAdjustmentDetails` | [`Models.PaymentBalanceActivityReleaseAdjustmentDetail`](../../doc/models/payment-balance-activity-release-adjustment-detail.md) | Optional | - |
| `TypeReserveHoldDetails` | [`Models.PaymentBalanceActivityReserveHoldDetail`](../../doc/models/payment-balance-activity-reserve-hold-detail.md) | Optional | - |
| `TypeReserveReleaseDetails` | [`Models.PaymentBalanceActivityReserveReleaseDetail`](../../doc/models/payment-balance-activity-reserve-release-detail.md) | Optional | - |
| `TypeSquareCapitalPaymentDetails` | [`Models.PaymentBalanceActivitySquareCapitalPaymentDetail`](../../doc/models/payment-balance-activity-square-capital-payment-detail.md) | Optional | - |
| `TypeSquareCapitalReversedPaymentDetails` | [`Models.PaymentBalanceActivitySquareCapitalReversedPaymentDetail`](../../doc/models/payment-balance-activity-square-capital-reversed-payment-detail.md) | Optional | - |
| `TypeTaxOnFeeDetails` | [`Models.PaymentBalanceActivityTaxOnFeeDetail`](../../doc/models/payment-balance-activity-tax-on-fee-detail.md) | Optional | - |
| `TypeThirdPartyFeeDetails` | [`Models.PaymentBalanceActivityThirdPartyFeeDetail`](../../doc/models/payment-balance-activity-third-party-fee-detail.md) | Optional | - |
| `TypeThirdPartyFeeRefundDetails` | [`Models.PaymentBalanceActivityThirdPartyFeeRefundDetail`](../../doc/models/payment-balance-activity-third-party-fee-refund-detail.md) | Optional | - |

## Example (as JSON)

```json
{
  "id": "id0",
  "payout_id": "payout_id6",
  "effective_at": null,
  "type": null,
  "gross_amount_money": null,
  "fee_amount_money": null,
  "net_amount_money": null,
  "type_automatic_savings_details": null,
  "type_automatic_savings_reversed_details": null,
  "type_charge_details": null,
  "type_deposit_fee_details": null,
  "type_dispute_details": null,
  "type_fee_details": null,
  "type_free_processing_details": null,
  "type_hold_adjustment_details": null,
  "type_open_dispute_details": null,
  "type_other_details": null,
  "type_other_adjustment_details": null,
  "type_refund_details": null,
  "type_release_adjustment_details": null,
  "type_reserve_hold_details": null,
  "type_reserve_release_details": null,
  "type_square_capital_payment_details": null,
  "type_square_capital_reversed_payment_details": null,
  "type_tax_on_fee_details": null,
  "type_third_party_fee_details": null,
  "type_third_party_fee_refund_details": null
}
```

