* Recap:
	Paramteric form of a line - L(t) = A + w*t
	Paramteric form of a plane - P(a,e) = B + v*a + u*e
	
* To determine where a line right or line segment intersects with a plane, we need to find:
	A + w*t  = B + v*a + u*e
	Since this is a complex equation to solve at its current state, we can use something in the form of the line intersection where we are 
	solving two time variables instead of three. This involves the idea of normals.
	
* Normals - the cross product of two vectors gives a third vector that sits at 90 degrees to the others. Since vectors are not anchored to any 
            particular location, they are just a direction and magnitude , they could be anywhere.
			n(normal) = v x w
			No matter where 'n' in space is placed, it will always sit perpendicular to the plane defined by the 2 vectors. This new vector 
			is called a - NORMAL - and it sits normal to the plain defined by the two vectors. Because 'n' is perpendicular to both we know that:
			n.v = 0
			n.w = 0
			In case we have two points and we need to find the vector of it, it will look like this -> n.(PointB - PointA) = 0
			The content above is called - the point normal form of a plane
			
* A line also has a point normal form. All we need is the start and end points of a line segment to calculate the vector between them
  and find the normal. For that we can use the PERP vector.
           v
  A ------------------ B
			|
			| n
			|
	n.(B-A) = 0
	v = B - A
	n = v^t
	
* To simplify, we can express the plane in normal form as - n.(H(hitpoint)-B(point of the plane)) = 0. We know that the line for some value of T is
  going to intersect the hit point, therefore the hit point also equals - H = A + w*t (see reference image)
  This can be expanded to -> H = n.(A + w*t - B) = 0
							     n.(A-B) + n.w*t = 0
								 
							t = -n(A-B) / n.w
  First we work out the 't' value and then substitue it back into the line equation to find the coordinates for the hit location
  
  
  
     