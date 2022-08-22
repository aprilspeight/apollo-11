# <p align="center">Sample Name</p>
<p align="center">
  <a href="https://github.com/aprilspeight/<repo-name>/blob/master/README.md#requirements">Requirements</a> |
  <a href="https://github.com/aprilspeight/<repo-name>/blob/master/README.md#videos">Video</a> |
  <a href="https://github.com/aprilspeight/<repo-name>/blob/master/README.md#view-the-sample">View the Sample</a> | 
  <a href="https://github.com/aprilspeight/<repo-name>/blob/master/README.md#resources">Resources</a> | 
  <a href="https://github.com/aprilspeight/<repo-name>/blob/master/README.md#contact">Contact</a>
</p>

For this <i>Made with MRTK</i> project, I decided to revisit my love of space exploration and bring the educational experience into VR. I created my very own interactive Apollo 11 exhibit with 3D models courtesy of the Smithsonian 3D Digitization project and NASA.

## Requirements

- Unity 2020.3.37f1
- Meta Quest or Meta Quest 2
- Oculus Link cable (to view on device via Unity in Play mode)

## Videos

A demo of the project is available on YouTube. Check out the video here: [https://youtu.be/H5a1kmKHmoo](https://youtu.be/H5a1kmKHmoo)

## View the Sample

<b>Disclaimer</b>: I have two disclaimers folks. First, you <b>must</b> create an Azure Speech Service to use the transcription feature that accompanies the <b>Neil Armstrong</b> and <b>Command Module</b> exhibits. New to Azure? No worries! You can sign-up for a free account by visiting: [https://azure.microsoft.com/free/](https://azure.microsoft.com/free/)

Second, this experience has <b>only</b> been optimized to view via the Oculus Link workflow. Should you decide to deploy the experience to your device, you'll be responsible for modifying to better suit optimization for the device.

With the business out of the way, let's view the sample!

1. Ensure that you have <b>Android Build Support</b> and it's corresponding modules for <b>Unity 2020.3.37f1</b>.
1. Clone or download this repository and add the project to the Unity Hub.
1. Open the project in Unity.
1. Enable <b>Developer Mode</b> for your Meta Quest or Meta Quest 2. To do so, follow steps 1-7 within [<i>Connect Headset over USB</i>](https://developer.oculus.com/documentation/unity/unity-enable-device/#connect-headset-over-usb). <b>DO NOT BUILD AND RUN</b>. 

    If your device is already in <b>Developer Mode</b>, then connect your device to your computer via the Oculus Link cable, put on the headset, and click <b>Allow</b> when promoted to allow access to data.

    After your device is connected to the computer <b>and</b> in Developer Mode, open the <b>Oculus Link</b> app on the device.
1. Within Unity, in the <b>Hierarchy</b>, select the <b>Exhibit-Descriptions</b> GameObject.
1. In the <b>Inspector</b>, add your <b>Speech Service Subscription Key</b> and <b>Speech Service Region</b> for the Azure Speech resource that was mentioned in the disclaimer. You can find these two values within the <b>Keys and Endpoint</b> section of the Azure Portal for your Speech service resource. If you <b>do not</b> intend to use the transcription feature of the experience (pressing the red button to generate an audio clip playback for the text on the wall) then you can ignore this step.
1. Press <b>Play</b>. The Meta Quest/Meta Quest 2 will start the experience within <b>Oculus Link</b>. If the Oculus Link app is not already opened, the device will provide a pop-up link to the app for you to open.

## Resources

- [MRTK](https://aka.ms/mrtk)
- [Smithsonian 3D Digitization](https://3d.si.edu/)
- [NASA Astromaterials 3D](https://ares.jsc.nasa.gov/astromaterials3d/)

## Contact

Have a question or issue trying the sample? Submit an issue to the repo!
