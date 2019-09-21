<!--
   - $File: JCS_Settings.html $
   - $Date: 2018-10-01 14:35:21 $
   - $Revision: $
   - $Creator: Jen-Chieh Shen $
   - $Notice: See LICENSE.txt for modification and distribution information
   -                   Copyright © 2018 by Shen, Jen-Chieh $
-->


<div id="content-header">
  <h1>JCS_Settings</h1>
</div>

<p>
  Interface of all setting class.
</p>


<br/>
<h2>Variables</h2>
<br/>

<table>
  <tr>
    <td>instance</td>
    <td>Hold the settings class instance for ensuring is singleton.</td>
  </tr>
</table>


<br/>
<h2>Functions</h2>
<br/>

<table>
  <tr>
    <td>CheckSingleton</td>
    <td>Force the setting object singleton.</td>
  </tr>
  <tr>
    <td>TransferData</td>
    <td>Transfter data through one scene to another scene.</td>
  </tr>
</table>


<br/>
<h2>Example</h2>
<br/>

<p>ExampleSetting.cs</p>
<div class="code-block">
  public class ExampleSetting : MonoBehaviour
  {
      private void Awake ()
      {
          // Make the instance singleton.
          instance = CheckSingleton(instance, this);
      }
  }

</div>
