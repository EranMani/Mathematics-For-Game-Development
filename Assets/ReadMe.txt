feature/Vectors
* Vectors are written as coordinates, like points but they are different
* A point is a single location in space, where vector can be anywhere in space
* A vector represents a direction, they it is pointing, and a magnitude held in the value of its length. By getting and
  direction and length we can tell which way it is going and also how far it is going on a graph. So, a vector is just
  a direction and magnitude in space, it doesnt specify where it starts. It represents instructions for moving from one 
  location to the next
* The magnitude of a vector is determined by Pythagoras theorem using its X and Y values. For example:
	vector (4,5)
           _________    _________    _______    __
  ||v|| = √x^2 + y^2 = √4^2 + 5^2 = √16 + 25 = √41
  * Note - double straight lines around the V is the mathematical notation for the length of a vector.
* Once we know where a vector starts, we can calculate the point where it ends by adding the starting point coordinates 
  to the vectors coordinates.
  For example:
	point (3,4)
	vector (4,5) 
	destination point = (3+4) + (4+5) = (7,9)
* We can determine if two vectors are the same by their direction and length