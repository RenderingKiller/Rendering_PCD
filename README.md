# Rendering_PCD
IDE : Unity3D 2018.1.1f1

Running the Demo:
1 Go to Assets\Scenes, double-click Scene.unity file.
2 Click Play button.

Two scripts file for moving the player and rotating the camera.
1 CharacterLook.cs
2 CharacterMove.cs

Point Cloud Data.
1 I use the third party library, which is Point Cloud Free Viewer. It can convert .off 3D file to .prefab file. 
  Here the Generated file is xyzrgb_manuscript.prefab which can be used by Unity3D directly. As long as understanding the format of the     .off file, it's easy to implement the import/export interface. I would do this if the time is allowed.
  
Optimization:
1 Using the LOD group which is support by Unity3D and Occlusion culling to optimize the number of the triangle in the scene.
2 Tiling Optimization: In this demo, the ground only has two triangles, Just increase the Tiling number to make the ground more clearly.
