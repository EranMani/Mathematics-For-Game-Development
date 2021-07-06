* In case of a line or plane, we want to know which side the ray has hit it from. This is important for numerous calculations such as lighting by determine
  which side of the polygon is facing the light
* In case of an object, we want to know what side the ball hit in order to calculate the correct reflection vector. To do this, we use the 
  normal with DOT product
	* If an incoming vector C and the normal N produce a DOT product of 0, then they are perpendicular and vector C must be parallel to the plane
	  or line.
	  If N.C > 0, the ray is aimed along the normal. They are heading away from the line or plane on the same side. The ray has come from the 
	  other side of the plane or line.
	  If N.C < 0, the ray is aimed counter to the normal N.
	  
	  This is the condition that is most interseting when calculating reflections and other hit conditions for ray line intersections
	  
* A very common calculation in physics and lighting systems is that of reflection, according to the laws of physics, 
  the angle of incidence equals the angle of reflection. These angles measure between the incoming and outgoing vectors and the normal to the surface.
  When an object is approaching a surface, we already know the incoming vector. We have the normal to the line or plane. We need to find the 
  vector along which the bouncing reflected object is going to travel.
  
  How to calculate:
	* Start by constructing a parallelogram from the vectors. If it scaled up in by some value, it would give us two equations
	  This means, the normal with some value can give us the equation -   n*t = r-a
	* We can measure the length of the normal times 't' with two equal measures of 'a' projected into 'n'
	* Vector projection - When one vector is projected onto another vector, it is folded down as if to sit in line with the other vector.
	  It is not rotated but projected at ninety degrees onto the other vector.
	  When both vectors are normalized, that is length of one, the resulting scale is determined by the DOT product. 
	  The resulting vector is called the orthographic projection of one vector onto another