# JCS_VideoLoader

Video loader, load an external video file.


## Functions

<table>
  <tr>
    <td>LoadVideo</td>
    <td>Load an external video file.</td>
  </tr>
</table>


## Example

```cs
VideoPlayer vp = GetComponent<VideoPlayer>();

string filePath = "path/to/video/file.mp4";

JCS_VideoLoader.LoadVideo(vp, filePath);
```
