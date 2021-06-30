* When moving from 2D to 3D space, we introduce a third dimension and thus add another coordinate.
* A 3D vector is treated in the same way it exists in 3D space and therefore has a measurement along the Z axis and is represented by three values.
* To update the formulas that were used in 2D to work on 3D, we just add the Z axis value as well
	Example:
					  _________________________________________________
		* Distance - √(p2.x - p1.x)^2 + (p2.y - p1.y)^2 + (p2.z - p1.z)^2
					__________________
		* Length - √ x^2 + y^2 + z ^ 2
		* Dot product - v.x * w.x + v.y * w.y + v.z * w.z
		* Cross product - stays the same, since it needs a 3D vector for its calculation
		* Normal form - v^ = (v.x / ||v|| (length), v.y / ||v||, v.z / ||v||)
		* Adding a vector to a point - only add the Z axis element to the calculation.
		  p2 = p1 + v
		  v = p2 - p1