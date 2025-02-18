
# Terminal Action

## Structure

`TerminalAction`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | A unique ID for this `TerminalAction`.<br>**Constraints**: *Minimum Length*: `10`, *Maximum Length*: `255` |
| `DeviceId` | `string` | Optional | The unique Id of the device intended for this `TerminalAction`.<br>The Id can be retrieved from /v2/devices api. |
| `DeadlineDuration` | `string` | Optional | The duration as an RFC 3339 duration, after which the action will be automatically canceled.<br>TerminalActions that are `PENDING` will be automatically `CANCELED` and have a cancellation reason<br>of `TIMED_OUT`<br><br>Default: 5 minutes from creation<br><br>Maximum: 5 minutes |
| `Status` | `string` | Optional | The status of the `TerminalAction`.<br>Options: `PENDING`, `IN_PROGRESS`, `CANCELED`, `COMPLETED` |
| `CancelReason` | [`string`](../../doc/models/action-cancel-reason.md) | Optional | - |
| `CreatedAt` | `string` | Optional | The time when the `TerminalAction` was created as an RFC 3339 timestamp. |
| `UpdatedAt` | `string` | Optional | The time when the `TerminalAction` was last updated as an RFC 3339 timestamp. |
| `AppId` | `string` | Optional | The ID of the application that created the action. |
| `Type` | [`string`](../../doc/models/terminal-action-action-type.md) | Optional | Describes the type of this unit and indicates which field contains the unit information. This is an ‘open’ enum. |
| `SaveCardOptions` | [`Models.SaveCardOptions`](../../doc/models/save-card-options.md) | Optional | Describes save-card action fields. |

## Example (as JSON)

```json
{
  "id": null,
  "device_id": null,
  "deadline_duration": null,
  "status": null,
  "cancel_reason": null,
  "created_at": null,
  "updated_at": null,
  "app_id": null,
  "type": null,
  "save_card_options": null
}
```

