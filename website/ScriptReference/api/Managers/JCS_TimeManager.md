# JCS_TimeManager

Holding all the information about the time in real life.


## Variables

<table>
  <tr>
    <td>mCurrentTimeRange</td>
    <td>Time range at the current region.</td>
  </tr>
  <tr>
    <td>mCurrentSeasonType</td>
    <td>Season current time.</td>
  </tr>
  <tr>
    <td>mCurrentWeatherType</td>
    <td>Weather current time period.</td>
  </tr>
</table>


## Functions

<table>
  <tr>
    <td>GetCurrentTime</td>
    <td>Get the current time in base on time zone in OS.</td>
  </tr>
  <tr>
    <td>LoadCurrentTimeRange</td>
    <td>Get the current time base on the OS time.</td>
  </tr>
  <tr>
    <td>isInTheMorning</td>
    <td>Is current time in the morning. (5am ~ 8am)</td>
  </tr>
  <tr>
    <td>isMorning</td>
    <td>Is current time morning. (8pm ~ 12pm)</td>
  </tr>
  <tr>
    <td>isNoon</td>
    <td>Is current time noon? (12pm ~ 14pm)</td>
  </tr>
  <tr>
    <td>isAfternoon</td>
    <td>Is current time afternoon? (14pm ~ 17pm)</td>
  </tr>
  <tr>
    <td>isEvening</td>
    <td>Is current time evening? (17pm ~ 19pm)</td>
  </tr>
  <tr>
    <td>isAtNight</td>
    <td>Is current time night? (19pm ~ 22pm)</td>
  </tr>
  <tr>
    <td>isLateAtNight</td>
    <td>Is current time late at night? (22pm ~ 2am)</td>
  </tr>
  <tr>
    <td>isBeforeDawn</td>
    <td>Is current time before dawn? (2am ~ 5am)</td>
  </tr>
  <tr>
    <td>GetCurrentSeason</td>
    <td>Get the season base on the OS's time's month.</td>
  </tr>
  <tr>
    <td>isSpring</td>
    <td>Is sping time? (3 ~ 5)</td>
  </tr>
  <tr>
    <td>isSummer</td>
    <td>Is summer time? (6 ~ 8)</td>
  </tr>
  <tr>
    <td>isFall</td>
    <td>Is fall time? (9 ~ 11)</td>
  </tr>
  <tr>
    <td>isWinter</td>
    <td>Is winter time? (12 ~ 2)</td>
  </tr>
  <tr>
    <td>GetCurrentWeather</td>
    <td>Get the current weather base on the website api.</td>
  </tr>
</table>
