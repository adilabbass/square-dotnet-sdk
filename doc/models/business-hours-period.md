
# Business Hours Period

Represents a period of time during which a business location is open.

## Structure

`BusinessHoursPeriod`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DayOfWeek` | [`string`](../../doc/models/day-of-week.md) | Optional | Indicates the specific day  of the week. |
| `StartLocalTime` | `string` | Optional | The start time of a business hours period, specified in local time using partial-time<br>RFC 3339 format. For example, `8:30:00` for a period starting at 8:30 in the morning.<br>Note that the seconds value is always :00, but it is appended for conformance to the RFC. |
| `EndLocalTime` | `string` | Optional | The end time of a business hours period, specified in local time using partial-time<br>RFC 3339 format. For example, `21:00:00` for a period ending at 9:00 in the evening.<br>Note that the seconds value is always :00, but it is appended for conformance to the RFC. |

## Example (as JSON)

```json
{
  "day_of_week": null,
  "start_local_time": null,
  "end_local_time": null
}
```

