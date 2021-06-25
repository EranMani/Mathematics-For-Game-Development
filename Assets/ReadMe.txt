feature/Location_2D_Points_On_Cartesian_Plane
* Distance between points on 2D plane - To work out a distance, you need two points or two locations.
  Any two points in an environment, 2D or 3D, can be used to form a right angle triangle. In this case it is possible
  to apply the Pythagoras's theory. The longest side of a right triangle is called the hypotenuse, and the other sides
  can be labled with any name, such as A and B.
* Pythagoras Theorem says that the length of the hypotenuse equals the square root of A squared plus B square. So that's the length of A and B squared.
  The length of A is the difference in the X direction where the player is and where the other object is.
  The length of B is the difference in the Y direction where the player is and where the other object is.
								    x2, y2
								Obj(12,10)
							*	|
	Hypotenuse			*		|
					*			| B
				*				|
			*					|
		*_______________________|
	P(3,2)          A
	 x1,y1
			      _________
	Hypotenuse = √(a² + b²)
	 _______________________	
	√(x1 - x2)² + (y1 - y2)²
	 _____________________	
	√(3 - 12)² + (2 - 10)²
	 _____________	
	√(-9)² + (-8)²
	 ___	
	√145 = 12.04
	
* The important thing is that right angled triangle is going to have one side that is parallel to the x axis and one side is parallel to the Y axis.
  And the length of those two sides are always going to give that difference that is needed to put into Pythagoras's theorem.

