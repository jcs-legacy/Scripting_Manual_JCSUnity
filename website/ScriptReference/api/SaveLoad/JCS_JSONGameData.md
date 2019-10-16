# JCS_JSONGameData

Interface to store game data in JSON format.


## Example

```cs
[System.Serializable]
public class ExampleGameData : JCS_JSONGameData {
    public string Name = "";  // Name of the player.
    public string Gold = "";  // Cash in the game.
}
```


## Usage

```cs
/* Setup the path. */
string filePath = "/path/to/save/game.data";

/* Load the data. */
var gameData = ExampleGameData.LoadFromFile<ExampleGameData>(filePath);

/* Save the data. */
gameData.Save<ExampleGameData>(filePath);
```


## Functions

<table>
  <tr>
    <td>Save</td>
    <td>Save the game data to file.</td>
  </tr>
  <tr>
    <td>LoadFromFile</td>
    <td>Load the game data from file.</td>
  </tr>
</table>
