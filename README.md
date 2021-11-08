# 3D-Vision-Cone
Cone detector for 3D, can detect objects within a cone dynamically. Cone can be resized and rotated at run time.
![Alt Text](ConeCast.gif)

# How To Use?
Simply add ConeDetection script to a GameObject.
GameObjectsInCone is a public list of all objects detected.

# How It Works?
The algorithm solves the cone detection analytically, the obstruction is solved numerically. It uses a SphereCast to store all objects within the given radius, then using a mathematical formula, decides if that objects exists within the cone.

![Alt Text](https://i.imgur.com/8oZEqxJ.png)

# Obstructed View
To find if an object is behind another, it uses the bounds of the collider, at each edge of the bounds it casts a ray from the origin, to the end of the cone. If an object is found it is added to a list of objects detected.
