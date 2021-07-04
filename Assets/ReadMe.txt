* Line intersections can be used in 2D or 3D games played in the same plane to determine collision boundaries and calculate rebounds
* Consider two lines, one defined as A with vector V and the other is B with vector s	
		B
		^
		|  v
	----|---- > A
	   u|
		|
	
	The line for A is -> A + v*t
	The line for B is -> B + u*s
	The lines will intersect where the results for these two equations are equal:
	
							A + v*t = B + u*s
							
	To simplify this further, we will remove the points A and B and replace them with a vector:
	
							v*t = B - A + u*s
							
	Since the operation (-) for two vectors will give us a new vector, we can replace them with the a new vector called C
	
							v*t = C + u*s
							
	Next, all we need to do is to find what is the 't' time along the A line and the 's' time along the B line, and this will be the intersection point
	To find at least one of them we need to eliminate either 't' or 's' in the equation
	
* 2D Perp vector - a vector that sits perpendicular, that's 90 degrees, to another and it's easily found by simply exchanging the X and Y 
  values and negating one of them. The notation for the perp vector is a V with an upside down T that signifies the perpendicular set of lines.
  For example:
	v = (9,7)
	v^t = (-7,9)
  
  In the case of negating the original X value, we end up with a perp that is ninety degrees, counterclockwise in rotation from the original V
  So Perp -> a counterclockwise vector 90 degrees to original v
  
  To solve the issue above of eliminating the 't' or 's' (line line intersection), we can use the DOT product on a vector and its perp vector,
  which will give a value of zero -> v^t(upside down t).v = 0, as any two vectors that produce a DOT product of 0 are at 90 degrees to one another.
  Another useful property of the perp vector is the DOT of a perp vector and another can be reaarranged to the negative of the perp of the other and
  the DOT product of the original vector --> v^t.u = -u^t.v
  
  PROPERTY 1 EXAMPLE:
	  v^t.v = 0
	  (10,5).(-5,10) = 10 * -5 + 5 * 10 = -50 + 50 = 0
	  
  PROPERTY 2 EXAMPLE:
	  v^t.u = -u^t.v
   (8,5)(1,2)
	  v^t = (8,5)
	  u = (1,2)
	  
	  v^t(perp vector).u = 8 * 1 + 5 * 2 = 18
	  
	  if v^t = (8,5), that would make v = (5,-8)
	  if u = (1,2), then its perp vector is (-2,1). The negative of the u perp vector is (2,-1)
	  
	  -u^t.v = (2,-1).(5,-8) = 5 *2 + -8 * -1 = 18
	  
  To summarize the conversion from original vector to perp:
	v = (8,5)
	v^t(which is the perp vector) = (-5,8)
	
	u^t = (1,2)
	u = (-2,1)
	
* Continue from finding the intersection point, we have the equation = v*t = c + u*s
  To find the 't' value, we need to eliminate the u*s - and the way to do it is to make u*s give us zero, by multiplying itself with its perp vector
  So we multiply both sides of the equation with the perp of 'u' and it will eliminate 's'. The equation will look like this:
	u^t.v*t = u^t.c + u^t.u*s
	
	u^t.v*t = u^t.c 
	t = u^t.c / u^t.v
	
  To find the 's' and eliminate 't' we will multiply both sides with the perp vector of v
    v^t.v*t = v^t.c + v^t.u*s
	0 = v^t.c + v^t.u*s
	-v^t.u*s = v^t.c
	
	Since we have a negative value on the left, we can use the second property of perps to eliminate the negative by swapping around which vector
	is the perp:
	FROM -v^t.u*s = v^t.c
	TO    u^t.v*s = v^t.c
	THEN
	s = v^t.c / u^.v
	
* The only time 2D lines won't intersect at some point is if they are parallel. We can tell if the lines are parallel as the perp of one 
  of the vectors will sit at 90 degrees to the other.

		   u
  -------|------------>	   
         | v
  -------|------------>
	     |
	     |
  u^t.v = 0 --> ---lines are parallel---