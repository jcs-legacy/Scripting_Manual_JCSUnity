<!--
   - $File: JCS_IGLogSystem.html $
   - $Date: 2018-10-01 19:39:14 $
   - $Revision: $
   - $Creator: Jen-Chieh Shen $
   - $Notice: See LICENSE.txt for modification and distribution information
   -                   Copyright © 2018 by Shen, Jen-Chieh $
-->


<div id="content-header">
  <h1>JCS_IGLogSystem</h1>
</div>

<p>
  In game log system.
</p>


<br/>
<h2>Variables</h2>
<br/>

<table>
  <tr>
    <td>mLogSpacing</td>
    <td>Space between each log message.</td>
  </tr>
</table>


<br/>
<h2>Functions</h2>
<br/>

<table>
  <tr>
    <td>SendLogMessage</td>
    <td>Make single log message on the screen.</td>
  </tr>
  <tr>
    <td>SendLogMessages</td>
    <td>Make multiple log messages on the screen.</td>
  </tr>
  <tr>
    <td>RemoveFromRenderVec</td>
    <td>Remove the log message that are outdated.</td>
  </tr>
  <tr>
    <td>UpdateSpace</td>
    <td>Update all current active log messages' spacing.</td>
  </tr>
</table>
