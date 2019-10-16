<div id="content-header">
  <h1>JCS_BinGameData</h1>
</div>

<p>
  Interface of storing game data as binary format.
</p>


<br/>
<h2>Example</h2>
<br/>

<p>ExampleGameData.cs</p>
<div class="code-block">
  [System.Serializable]
  public class ExampleGameData : JCS_BinGameData {
      public string Name = "";  // Name of the player
      public int Gold = 0;      // Cash in the game.
  }
  
</div>

<br/>

<p>Usage</p>
<div class="code-block">
  /* Setup the path. */
  string filePath = "/path/to/save/game.data";
  
  /* Load the data. */
  var gameData = ExampleGameData.LoadFromFile-<-ExampleGameData->-(filePath);

  /* Save the data. */
  gameData.Save-<-ExampleGameData->-(filePath);

</div>


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

