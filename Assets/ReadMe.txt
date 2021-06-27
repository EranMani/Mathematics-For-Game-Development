* To calculate the vector between two points:
	* P1(p1x, p1y) ---------------------> P2(p2x, p2y)
	                         V
	  Vector = P2 - P1
	  Note: We take the starting point away from the destination point and that will give the vector from the starting point to the destination point
	        After getting the direction vector, we should scale it down so that the object wont jump to the destination point in one frame!
	  To get P2 for example we can use this equation - P2 = P1 + V
	  
* When updating the direction vector in the Update(), we will get slow in or slow out efffect. That is because objects coming to a stop dont instantly
  stop, they slow down as they get to their destination. This happens becuase the vector is updating every frame and every frame we make it shorter
  by a speed var multiplier, so when the object is near its destination his vector magnitude will decrease more and more until it stops.
  In order to keep the constant speed of the object (same vector magnitude) and make it stop when it reaches its destination,
  we should place the direction vector right at the Start() which will not update it every frame but keep it the same each frame, and then use a condition
  that checks the distance between the object and the destination point and stop updating if the object is closer.
* A speed variable that is applied is not an indicator of the actual speed of the object.
  Example:
	We have two objects with different distances from the destination point, which means each will have a different vector that will be multiplied
	by a speed variable to decrease its magnitude. At the moment, the two objects are not moving at the same speed and they will reach at the destination
	point at the frame, even if one object is farther away. 
	To make the speed of both objects to be exactly the same, which means that the closer object will get to the destination before the furtherest tank,
	we will use the vector NORMAL form
* Vector normal form - The normal form reduces all vectors down to a length of one. So every normal form of a vector still points 
  in the same direction as the original vector, but it has a length of one. Therefore, all the reduced vectors are going to be exactly the same length,
  which makes it useful when we want to start multiplying them by speed variables.
  * calculation of normal requires knowing the vector's direction and magnitude. The way to reduce a vector down to a length of 1 is to divide
  each coordinate element by its magnitude. The formula will look like this:
	^
	v = ( vx      vy
		----- , -----
		||v||   ||v||)
		
	v^ = the mathmeatical notation of the normal form of a vector
	Example:
		* vector = (3,4)
		                       __________    __________    ___
		  magnitude = ||v|| = √ x^2 + y^2 = √ 3^2 + 4^2 = √ 25 = 5
		  v^ = (3/5, 4/5) = (0.6, 0.8) -> This is the coordinate when the magnitude of the vector is 1


	