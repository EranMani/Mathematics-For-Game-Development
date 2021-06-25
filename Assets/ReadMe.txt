feature/Location
* A Cartesian coordinate defines the location of a single point, according to reference axes that meet at a location called 
  Origin and extend away from that point perpendicular to each other in both the positive and negative directions.
* A point in the Cartesian space is denoted by its distance along the X axis, followed by its distance along the Y.
* X Coordinate must and always comes first, followed by the Y -> (x,y)
* The defining property of Cartesian space is that a single corner only identifies a single location. It cannot ever possibly be mistaken for any 
  other location than the one that is given.
* Cartesian coordinates can be defined for all dimensions of space from the one dimensional lumber line that has a single access to 
  the two-dimensional system, to the three dimensional system that adds the addition of the Z axes to any number of dimensions that are difficult to visualize in games.
* We generally are most concerned with representations in two and three dimensions.
* Simple data structures to hold the neceesary information to define a point would look like this:
	class coord2D
	{
		float x;
		float y;
	}
	
	class coord3D
	{
		float x;
		float y;
		float z;
	}
* We can think of space as a large rectangular prism with X, Y and Z dimensions and map it to a 3D cube. When space is represented by a cube or rectanguler 
  prism, it is called orthographic. Another type of space representation is called perspective. This warps space into a pyramid shape with the top
  cut off, in other words - Frustum.
* In unity, to define the size of an orthographic camera we will change its size and this will affect the distance amount between the origin(0,0)
  and the Y axis. For example, changing the size to 100 will give a distance of 100 from the origin to the positive or negative Y axis, which means
  it will give a size of 200 (100*2) from the end points of the positive and negative Y axis. 
  To find the end points of the X axis, we use the ratio display amount like this - (16 * size) / 10 - so when the size of the camera is 100, the Y 
  end points will be +-100 and the X axis end points will be (16*100) / 10 = +-160
* In orthographic space, the Z axis will not change the size of the object, rather change its visibility if it is behind the camera.
  orthographic space is best suited for 2D games ofcourse.






