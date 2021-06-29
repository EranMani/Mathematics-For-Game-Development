* Dot product - The sum of the multiplication of the corresponding components or coordinate values in two vectors.
* Given the vectors V and W, the product is found by multiplying both X values together, both Y values together, and then adding the result.
* It is written as an equation with a single dot between the vector names.
  d = v . w
* The full equation will look like this -> v.x * w.x + v.y * w.y
  For example:
	v = (3,4)
	w = (0,1)
	d = 3 * 0 + 4 * 1 = 4
* The final value tells us a few things about the relative orientations of the vectors. If the DOT product value is greater than zero, 
  then the angle between the vectors is less than 90 degrees. If the DOT product is equal to zero, then the angle is exactly 90 degrees.
  If the DOT product is less than zero, then the angle must be greater than 90 degrees.
  if v . x > 0 ----> less then 90 degress
  if v . x = 0 ----> exactly 90 degrees
  if v . x < 0 ----> greater then 90 degrees
* Where is this useful in games? It allows to determine where one game object is in relation to another game object.
  For example:
	* We have a tank and a fuel objects
	  The vector showing the forward direction of the tank is the irection that the tank is looking in
	  If we draw another vector to the fuel from the tank, you can then use the DOT product to determine if the fuel is in front or behind the tank
		* If the fuel is in sight of the tank, the DOT product of these vectors will be greater than zero.
		* If the fuel is behind the tank, then the DOT product will be less than zero.
		* If we want to turn the tank to the fuel, then we need to find the actual angle between forward facing direction of the tank and the 
		  direction of the fuel
	* Some kind of camera that wants to detect whether the character has walked into a certain space

* Rotations - To rotate a vector about an angle, the X and Y components need to be manipulated with sine and cosine functions
              The equation will look like this:
				* v.x = x * cos(angle) - y * sin(angle)
				  v.y = x * sin(angle) + y * cos(angle)
				  
				  v = (x * cos(angle) - y * sin(angle), x * sin(angle) + y * cos(angle))
* In computer graphics there are two types of coordinate system. There is a right hand coordinate system and a left hand coordinate system.
  Based on the direction of the Z axis in the environment, that dictates the way that rotations are going to occur. Unity is using the left coordinate
  system which means the positive rotations are going to go anti clockwise.
  
* Cross product - The cross product of two vectors results in another vector. It is performed on vectors in three dimensions, but in 2D it is
				  relevant to determine which way to turn to face one object towards another. In 2D, it has a third dimension that is coming out of the
				  screen.
				  Given the two vectors W and Y, the cross product is defind like this:
					* v = (v.x, v.y, v.z)
					  w = (w.x, w.y, w.z)
					  vxw = (v.y * w.z - v.z * w.y, v.z * w.x - v.x * w.z, v.x * w.y - v.y * w.x)
					  * It is called a cross product as it multiplies each component of the vectors with every other component.
						The resulting vector is one that is perpendicular to the other two.
				  * The cross product is not reversible.
				  * In determining whether we do an anticlockwise or a clockwise turn, the clue is in the results of the cross product.
				    In the case where we want to turn clockwise, the Z coordinate is a negative value ->  (v x w).z < 0 = clockwise turn
				    In the case where we want to turn anticlockwise, the Z value is a positive value -> (v x w).z > 0 = anticlockwise turn
				  * In case of turning clockwise, we turn anticlockwise all the way around in a circle until we get to the same position
				    we'd be facing if we had done a clockwise turn with the given angle.
					To calculate that turn, it's going to be the entire degrees in a circle, which is 360 minus the given angle.
					angle = 2PI - angle