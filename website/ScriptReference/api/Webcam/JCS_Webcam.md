# JCS_Webcam

Basic webcam class usage.

## Variables

| Name | Description |
|:---|:---|
| ManuallySetSize | Manually preserve the size in scene. |
| MustBeFullScreen | Make webcam maximize to the widest edge. |
| FPS | FPS for webcam. |
| ResumeTime | After the screenshot is taken, how fast to resume the webcam. |
| DelayTime | Delay time to fade out the splash screen. |
| TakePicKey | Key to take webcam image. |
| SavePath | Image save path. |
| SaveFilePrefix | Save file name prefix. |
| SaveExtension | Default save image file extension. |
| TakePhotoSound | Sound when taking the screenshot. |
| isPlaying | Flag to check if current webcam active. |

## Functions

| Name | Description |
|:---|:---|
| ActiveWebcam | Start the webcam if it is detected on your machine. |
| TakeSnapShotWebcam | Take a snap shot and save it in the application data path. |
| Play | Start the webcam. |
| Pause | Pause the webcam. |
| Stop | Stop the webcam. |
