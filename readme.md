# Virtual AR Ring Try-on App

An Augmented Reality Android App, made using Unity (C#) and OpenCV, to implement virtual trials of ornamental rings.

<br>
<p align="center">
  <img height="400" width="230" src="https://raw.githubusercontent.com/rohangupta/ar-ring-try-on/master/Images/Picture7.png">    
  &nbsp; 
  <img height="400" width="230" src="https://raw.githubusercontent.com/rohangupta/ar-ring-try-on/master/Images/Picture9.png">
</p>
<br>

## Process
### 1. Hand and finger detection using OpenCV

The hand and fingers detection is based on skin color detection. The application is initialized by sampling color from the hand of the user with the help of seven square color trackers or ROIs.

<p align="center">
  <img height="400" width="600" src="https://raw.githubusercontent.com/rohangupta/ar-ring-try-on/master/Images/Picture1.png">
</p>

The hand, the foreground, is then extracted from the background by thresholding with the sampled color profile. Each of the seven color in the profile produces a binary segmentation image. Then, all these seven binary images are added up to form a single binary image. This binary image is made smooth and denoised using image median blurring filters.

<p align="center">
  <img height="400" width="700" src="https://raw.githubusercontent.com/rohangupta/ar-ring-try-on/master/Images/Picture2.png">
</p>

<br>
After the generation of the binary representation of the hand, the image is processed in the following manner:

<p align="center">
  <img height="300" width="700" src="https://raw.githubusercontent.com/rohangupta/ar-ring-try-on/master/Images/Picture3.png">
</p>

This procedure helps in finding the ring finger of the user and getting the appropriate information required to place the ring in the next stage.

But, this procedure produces some noisy convexity defects too. To filter out these false convexity defects, we set the following constraints:
1.	The **length or depth of the defect (L) &gt; L<sub>bb</sub> / 5.5**
2.	The **angle between the lines** going from the defect to the neighboring convex polygon vertices **(&alpha;) &lt; 95**

<p align="center">
  <img height="300" width="300" src="https://raw.githubusercontent.com/rohangupta/ar-ring-try-on/master/Images/Picture4.png">
</p>
<br>

Now, to finally place the ring on the user's finger, the coordinates of the two leftmost convexity defects are found.

<p align="center">
  <img height="300" width="250" src="https://raw.githubusercontent.com/rohangupta/ar-ring-try-on/master/Images/Picture5.png">
</p>
<br>

The following **3 transformational components** are then set and passed to Unity,
1.	**Position**: The ring is placed on the midpoint of the points P1 and P2
2.	**Rotation**: The ring is rotated by an angle equal to the angle made by the line P1P2 with the horizontal axis
3.	**Scale**: The scale of the ring is set according to the length of the line segment P1P2


### 2. AR in Unity

The Unity Game Engine enables us to add a third dimension to the 2D input of the camera. A Scene is set in Unity as follows:

<p align="center">
  <img height="400" width="700" src="https://raw.githubusercontent.com/rohangupta/ar-ring-try-on/master/Images/Picture6.png">
</p>
<br>

The Scene consists of the following components:
1.	**Main Camera** – Captures the scene and displays the final output
2.	**Plane** - Acts as a screen to display the input camera feed
3.	**Directional Light** – Illuminates the scene
4.	**Rings** – 5 3D ring models (Imported into Unity)

The rings are referenced as **Game Objects** and are **transformed (position, rotation and scale)** according to the data received from the 1st phase. This finally places the ring model on the user's finger.

## Results

<p align="center">
  <img height="400" width="230" src="https://raw.githubusercontent.com/rohangupta/ar-ring-try-on/master/Images/Picture9.png">    
  &nbsp; 
  <img height="400" width="230" src="https://raw.githubusercontent.com/rohangupta/ar-ring-try-on/master/Images/Picture10.png">
</p>
<p align="center">
  <img height="400" width="230" src="https://raw.githubusercontent.com/rohangupta/ar-ring-try-on/master/Images/Picture12.png">    
  &nbsp; 
  <img height="400" width="230" src="https://raw.githubusercontent.com/rohangupta/ar-ring-try-on/master/Images/Picture11.png">
</p>

## Built With

- [Unity 2018.1.2f1](https://unity3d.com/)
- [OpenCV](https://opencv.org/)

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
<br>