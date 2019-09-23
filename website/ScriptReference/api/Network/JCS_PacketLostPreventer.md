<div id="content-header">
  <h1>JCS_PacketLostPreventer</h1>
</div>

<p>
  Prevent the packet have been lost. If the packet is lost we
  keep tracking the packet and resend the responed until the
  server's response had arrived. This usually deal with the
  UDP type communication.
</p>


<br/>
<h2>Variables</h2>
<br/>

<table>
  <tr>
    <td>mResendTime</td>
    <td>Interval the packet resend.</td>
  </tr>
  <tr>
    <td>mWaitingPacketIds</td>
    <td>Packet's ID that are still waiting for resend/process.</td>
  </tr>
</table>


<br/>
<h2>Functions</h2>
<br/>

<table>
  <tr>
    <td>AddTrack</td>
    <td>
      Track this packet. If the packet does not responed.
      keep sending the packet until the packet responed by the
      server.
    </td>
  </tr>
  <tr>
    <td>IsPreventing</td>
    <td>Check if this preventer still preventing any data packet lost issue.</td>
  </tr>
  <tr>
    <td>ClearTracking</td>
    <td>Clear all tracking packets.</td>
  </tr>
</table>
