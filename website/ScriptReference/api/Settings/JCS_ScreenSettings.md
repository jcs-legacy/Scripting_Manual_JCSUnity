# JCS_ScreenSettings

Screen related settings.


## Variables

<table>
  <tr>
    <td>onScreenResize</td>
    <td>Callback execute when the screen resized.</td>
  </tr>
  <tr>
    <td>RESIZE_TO_ASPECT_WHEN_APP_STARTS</td>
    <td>Resize the screen/window to certain aspect when the application starts.</td>
  </tr>
  <tr>
    <td>RESIZE_TO_STANDARD_WHEN_APP_STARTS</td>
    <td>Resize the screen/window to standard resoltuion when application starts.</td>
  </tr>
  <tr>
    <td>RESIZE_TO_ASPECT_EVERYTIME_SCENE_LOADED</td>
    <td>Resize the screen/window everytime a scene are loaded.</td>
  </tr>
  <tr>
    <td>RESIZE_TO_SMALLER_EDGE</td>
    <td>When resize, resize to the smaller edge, if not true will resize to larger edge.</td>
  </tr>
  <tr>
    <td>mResizablePanelsColor</td>
    <td>Defualt color to aspect panels.</td>
  </tr>
  <tr>
    <td>STANDARD_SCREEN_WIDTH</td>
    <td>Standard screen width to calculate the worldspace obejct's camera view.</td>
  </tr>
  <tr>
    <td>STANDARD_SCREEN_HEIGHT</td>
    <td>Standard screen height to calculate the worldspace obejct's camera view.</td>
  </tr>
</table>


## Functions

<table>
  <tr>
    <td>BlackspaceWidth</td>
    <td>Return width of the blackspace on the screen, if any after resizing the screen.</td>
  </tr>
  <tr>
    <td>BlackspaceHeight</td>
    <td>Return height of the blackspace on the screen, if any after resizing the screen.</td>
  </tr>
  <tr>
    <td>VisibleScreenWidth</td>
    <td>Get the visible of the screen width.</td>
  </tr>
  <tr>
    <td>VisibleScreenHeight</td>
    <td>Get the size of the screen height.</td>
  </tr>
  <tr>
    <td>ForceAspectScreenOnce</td>
    <td>Make the screen in certain aspect ratio.</td>
  </tr>
  <tr>
    <td>ForceStandardScreenOnce</td>
    <td>Resize the screen resolution to standard resolution once.</td>
  </tr>
</table>
