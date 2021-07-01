* Vector - represented by an arrow in space with no position, but has a direction and a magnitude(length)
* Line - defined by two points. A line passes through these points and continues to infinity in both direction.
* Line Segment - a small part of a line that terminates on both ends.
* Ray - kind of like a vector in that it has a direction but unlike a vector it has a starting point and continues off into infinity

* Parametric form - Think of a line or a line segment as a point and a vector. The point is known. On the other end of this line segment, the 
  equation to find the point is the point + vector.
  
  A --------- B
		v
  B = A + v
  
  To find the halfway along this line will be -> center point = A + v * 0.5
  To find the quarter way along this line will be -> quarter point = A + v * 0.25
  
  Any point on the line above can be found by adding some multiple of the vector to point A. 
  At A, the multiple of the vector will be zero and at B the multiple will be 1
	* A = A + v * 0
	  B = B + v * 1
  
  It means that any point on the line can be calculated with -> B = A + v * t(t= ranges between zero and one inclusive)
  0 <= t <= 1
  
  B = A + v * t --> the parametric form of the equation of a line segment.
  
  As lines and rays are versions of a line segment, the same formula can be used for all. The only difference factor is the range of T.
  For aline the range of T will be -> infinity <= t <= infinity
  For a ray the range of T will be -> 0 <=t <= infinity
  
  In a line, since point B is the only point on the end, the equation should be like this -> L(t) = A + v*t
  
  Example:
    MAIN EQUATION -> L(t) = A + v*t
	A -------------------------- B
   (10,0,2)                     (-5,10,5)
		   v = (B-A) = (-15,10,3)
		   v*t = (-15t, 10t, 3t)
		   L(t) = (10 - 15t, 10t, 2 + 3t) -> PARAMETRIC FORM
		   
* Linear interpolation - By using the parametric equation using time as t (for example Time.time in unity), it is called a linear interpolation
						 In unity, there is a linear interpolation method which called - Lerp