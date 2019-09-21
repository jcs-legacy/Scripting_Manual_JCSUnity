<!--
   - $File: JCS_NetworkSettings.html $
   - $Date: 2018-10-01 02:53:32 $
   - $Revision: $
   - $Creator: Jen-Chieh Shen $
   - $Notice: See LICENSE.txt for modification and distribution information
   -                   Copyright © 2018 by Shen, Jen-Chieh $
-->


<div id="content-header">
  <h1>JCS_NetworkSettings</h1>
</div>

<p>
  Store all the network settings.
</p>


<br/>
<h2>Variables</h2>
<br/>

<table>
  <tr>
    <td>CLIENT_MODE</td>
    <td>Current mode this client in, should be update by the server!</td>
  </tr>
  <tr>
    <td>ON_SWITCH_SERVER</td>
    <td>On switching the server?</td>
  </tr>
  <tr>
    <td>FORCE_SWITCH_SERVER</td>
    <td>Flag to check if is force switching the server.</td>
  </tr>
  <tr>
    <td>ONLINE_MODE</td>
    <td>Is the current game with online mode active?</td>
  </tr>
  <tr>
    <td>PROTOCAL_TYPE</td>
    <td>Type of the client protocal.</td>
  </tr>
  <tr>
    <td>HOST_NAME</td>
    <td>Client hostname.</td>
  </tr>
  <tr>
    <td>PORT</td>
    <td>Client port.</td>
  </tr>
  <tr>
    <td>CHANNEL_COUNT</td>
    <td>Channel count in this game.</td>
  </tr>
</table>


<br/>
<h2>Functions</h2>
<br/>

<table>
  <tr>
    <td>CreateNetwork</td>
    <td>Create socket and connect to the target hostname and target port</td>
  </tr>
  <tr>
    <td>CloseSocket</td>
    <td>Close the current socket the safe way.</td>
  </tr>
  <tr>
    <td>GetGameSocket</td>
    <td>Returns the game client socket.</td>
  </tr>
  <tr>
    <td>SwitchServer</td>
    <td>Switch the server.</td>
  </tr>
  <tr>
    <td></td>
  </tr>
</table>
