<div id="content-header">
  <h1>JCS_AudioLoader</h1>
</div>

<p>
  Audio loader, load an external audio file.
</p>


<br/>
<h2>Functions</h2>
<br/>

<table>
  <tr>
    <td>LoadAudio</td>
    <td>Load the music from the path in runtime.</td>
  </tr>
</table>


<br/>
<h2>Example</h2>
<br/>

<div class="code-block">
  private void Start()
  {
      string filePath = "path/to/file.ogg";
      AudioClip cl;
  
      // Start loading the audio file.
      StartCoroutine(JCS_AudioLoader.LoadAudio(cl, filePath, DoneLoadMusic));
  }

  /// -<-summary->-
  /// Callback after the audio is loaded.
  /// -<-/summary->-
  private void DoneLoadMusic(AudioClip ac)
  {
      Debug.Log("Done loading the audio file!");
  }

</div>
