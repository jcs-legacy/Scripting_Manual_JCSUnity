<div id="content-header">
  <h1>JCS_VideoLoader</h1>
</div>

<p>
  Video loader, load an external video file.
</p>


<br/>
<h2>Functions</h2>
<br/>

<table>
  <tr>
    <td>LoadVideo</td>
    <td>Load an external video file.</td>
  </tr>
</table>


<br/>
<h2>Examle</h2>
<br/>

<div class="code-block">
  VideoPlayer vp = GetComponent-<-VideoPlayer->-();

  string filePath = "path/to/video/file.mp4";

  JCS_VideoLoader.LoadVideo(vp, filePath);
  
</div>
