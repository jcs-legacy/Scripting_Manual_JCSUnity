JCS_NetworkSettings

Store all the network settings.


## Variables

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


# Functions

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
