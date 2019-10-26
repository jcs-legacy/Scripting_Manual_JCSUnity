# JCS_Settings

Interface of all setting class.


## Variables

<table>
  <tr>
    <td>instance</td>
    <td>Hold the settings class instance for ensuring is singleton.</td>
  </tr>
</table>


## Functions

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


## Example

ExampleSetting.cs

```cs
  public class ExampleSetting : MonoBehaviour
  {
      private void Awake ()
      {
          // Make the instance singleton.
          instance = CheckSingleton(instance, this);
      }
  }
```
