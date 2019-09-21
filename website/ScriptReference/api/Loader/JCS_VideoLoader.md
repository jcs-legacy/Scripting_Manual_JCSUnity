<!--
   - $File: JCS_VideoLoader.html $
   - $Date: 2018-10-01 03:14:38 $
   - $Revision: $
   - $Creator: Jen-Chieh Shen $
   - $Notice: See LICENSE.txt for modification and distribution information
   -                   Copyright © 2018 by Shen, Jen-Chieh $
-->


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
