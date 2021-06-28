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


  