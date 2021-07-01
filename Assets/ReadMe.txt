* A line tends to represent a path or direction, but never a solid object. Instead, the world is constructed from surfaces otherwise called planes
  or what you might refer to in a mesh as a polygon, while a line can be defined by a point and one vector.
* A plane is defined by one point and two vectors. In a case of a polygon in a mesh, the point can be one of the vertices and the vectors
  can sit along the edges.
* A plane is very much the same as a line as it goes on to infinity in all directions. A polygon, on the other hand, is a finite space.
  The correct mathematical term for a polygon is a planer patch
* Just like a line, we can also use the parametric equation for plane. For this we need to consider the point and the two vectors.
  On a polygon for example, we can work out a point and two vectors using three of the corner vertices.
* The parametric equation for a plane is pretty much the same way as a line, just as any point on a line can be defined by a point and then
  some multiple of the vector using 't' value, any point on the plane can be defined by a combination of various lengths of the two given vectors
  1) 
         u
   ^ --------- B
 v |     
   |
   A
   
   B = A + v + u
  
  2)
       u
   ^ ---- B
 v |     
   |
   A
   
   B = A + v + u * 0.5
   
   
  3)
           u
   ^ ------------- B
   |
   |
 v |     
   |
   A
   
   B = A + v*2 + u * 1.5

* Each vector can be multiplied individually by different values, therefore, instead of having just 't' in the equation
  we need to include another multiplier for the other vector 

* The parametric form for a plane is --> P(s,t) = A + v*s + u*t