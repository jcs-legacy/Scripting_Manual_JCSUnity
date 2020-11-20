# JCS_TextTimer

Render timer in the text.

## Variables

| Name            | Description                            |
|:----------------|:---------------------------------------|
| mTextContainer  | Target text renderer.                  |
| mTextMesh       | Target text renderer.                  |
| mActive         | Timer active or not active.            |
| mCurrentHours   | Current hours in the game.             |
| mCurrentMinutes | Current minutes in the game.           |
| mCurrentSeconds | Current seconds in the game.           |
| mDelimiterText  | Text add between each unit.            |
| mRoundUp        | Do round up instead of round down.     |
| mHideWhenZero   | Hide the number when is zero.          |
| mHourSound      | Sound played when hours get reduced.   |
| mMinuteSound    | Sound played when minutes get reduced. |
| mSecondSound    | Sound played when seconds get reduced. |

## Functions

| Name           | Description              |
|:---------------|:-------------------------|
| SetCurrentTime | Set the current time.    |
| IsTimeUp       | Check if the time is up? |
| UpdateTimeUI   | Update the time UI.      |
