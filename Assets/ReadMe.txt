feature/Bitwise_Operations
* Electricity can be one of two states - off or on. computers use these states to represent unique data values where off represents a zero and on is a one.
* You can imagine computer memory to be comprised of many boxes where each box holds a single light bulb
* This smallest size box in memory is called a bit because it can hold a value of zero or one. It is capable of storing only two unique values.
* Two bits are capable of storing four values where each value is determined by a different sequence of zeros and ones.
* When eight bits are used, a bigger number of 01 sequences is possible. In fact, eight bits are capable of storing 256 unique sequences in computing. Eight bits is called a bite.
* The sequences of zeros and ones used in computing is called binary.
* We consider each box in the sequence to represent a value equal to two to the power of something and working from 
  right to left allocate each box with increasing power starting at zero - 2^7......2^0. We can convert each power into a decimal value.
* To convert the sequence to dennery which is a number in our regular counting system, we add together the values of each box with a one state
* The largest number you can store in a bite is when all the boxes are filled with ones. This adds up to 255 together with zero. It makes up the 256 values that a bite can hold.
* Bitwise operations -> manipulate individual bits within a single variable for bitwise operations.

* We can use bits when storing game data.
* By processing the bits and jamming them into just one value, we can make the most of computer memory
* Example:
	* Need to store an RPG characters attributes which could be any combination or all of them - 
		* Magical
		* Intelligent
		* Charismatic
		* Flying
		* Invisible
	* We only care if the character has the attribute or not, not the value related to the attribute.
	* One way to store is that each of those values is assigned to a boolean and the boolean can then be set to true or false
	* Based on whether the character has that attribute or not, a bool in C Sharp is stored in one byte, or eight bits.
	  It's the smallest data type you can have access to.
	* If a character has an attribute or not, or even a combination of attributes, a code must be done to check the value of the bools
	  and do something accordingly.
	* Instead, we can store each attribute in a single bit. This is where the integer in binary format comes in.
	* Consider each box in the integer to represent one of the attributes of the character. If the character has an attribute, 
	  the associated box is set to one, otherwise it is set to zero
	* To replace the declaration and setting of the bools, we could instead use a single integer with the binary sequence.
	* Magical   Intelligent   Charismatic   Flying   Invisible
	    1           0              1           0         0
	   2^4         2^3            2^2         2^1       2^0
	* The 10100 bit values(binary number) like this represent a multitude of values which are called - BIT FLAGS.
	* This binary number represents 20.
	* We could declare this character to have magic and charisma with int attributes equals 20 or using int attributes 
	  16 + 4 (16 represent magical and 4 represent charisma)
	* An easier way is to work in pairs of two and declare the individual attributes to have their own values like this, 
	  where we can create a bunch of static ints representing each of the flags
		* static public int MAGIC = 16;
		  static public int INTELLIGENCE = 8;
		  static public int CHARISMA = 4;
		  static public int FLY = 2;
		  static public int INVISIBLE = 1;
		  
		  int attributes = MAGIC + CHARISMA;
	* if we have more than one character, each can have a single integer that represents all of those attributes. So over many characters, we actually start to save space.
	* Another benefit of working with bits like this is by using BITWISE OPERATORS.
		* AND - at the bit level on the individual bits in a binary sequence,it performs and operations with 
		  the ones and zeros in the same columns to produce a new binary number.
		  It's exactly the same rule that you use for working out the and between two boolean values such as true
		  and false, where in this case one would be true and zero would be false.
		  Example:
			  1011
			  0011
			  ----
			  0011
		* OR - combines the individual bits. it's very similar to the Boolean or operator.
		  Example:
			  1001
			  1111
			  ----
			  1111
		* XOR(exclusive or) - combines the two values. it will only ever give you a true if only one of the values being compared is true, 
		  otherwise you get a false.
		  Example:
			  1111
			  1101
			  ----
			  0010
		* NOT - switches the bit value to the other one.
		  Example:
			~1010
			 ----
			 0101
	* We can use bitwise operators for manipulating and testing the flags in a binary sequence.
		* in the previous setting of our attribute, we were assigning a decimal value or using the addition 
		  of powers of two values.
		* Instead, we can use the bitwise operator or to combine the values
		* MAGIC -> 10000
		  CHARISMA -> 00100
		  10000
		  00100
		  -----
		  10100 -> int value of 20, same output when used addition of powers
	* Bitwise operators are faster than multiplication and division operators, but not addition and subtraction.
	  When setting the flags, it doesn't really matter which method you use.
	* Unsetting flags - To add another attribute, like INTELLIGENCE, it is done with |= to insert a flag. The &= and ~
	  can be used to take out a flag.
	  Example:
		int attributes = MAGIC | CHARISMA; -> 10100
		attributes |= INTELLIGENCE; -> 11100
		attributes &= ~MAGIC; -> (NOT ONLY)01111
		11100
		(AND)
		01111
		-----
		01100
* Bit masking - A mask defines which bits you want to keep, and which bits you want to clear.
                Masking is the act of applying a mask to a value. In this case, we're working with ones and zeros.
				For example, we have an attribute string and then we have a particular mask that we want to match.
				* attributes -> 0011001
				  magic -> 0010000 (a mask that will contain the binary for MAGIC attribute to match)
				  
				  00-1-1001
				  -------  -> Use & operator to check if result is 0 or not. (NOTE) & operator will result in 1 only if both bits are 1
				  00-1-0000
				  
				  By using & we can check for both one's in the binaries and if we have it, then the result should not be zero
				  if ((attributes & MAGIC) != 0){do something}

* Bit shifting - An operation performed on all the bits in a binary sequence. The shift moves all by the requested number of places in either the left or right direction.
				 Example:
					00011 <- left shift = (all numbers are shuffled to the left and a zero is placed on the end) 00110
					00011 -> right shift = (moves the bits in the other direction) 00001
					
				* A left shift is performed using two less than signs - 00011 << 1 = 00110
																		00011 << 3 = 11000
				* To perform a right shift we use two greater then signs - 00001 >> 1 = 00000
																		   10011 >> 3 = 00010
																		   
				* We can use the shifting for multitude of things:
					* you can set your flags rather than having to remember the binary sequence of pairs of two.
					* Example:
						static public int MAGIC = 1 << 5; --> 00010000
						static public int INTELLIGENCE = 1 << 4; -> 00001000
						static public int CHARISMA = 1 << 3; -> 00000100
						static public int FLY = 1 << 2; -> 00000010
						static public int INVISIBLE = 1; -> 00000001
					* Shifting is particularly useful for packing and unpacking since we can condense a multitude of values into a single integer, such as the character attributes.
					  It makes sense to also do this with networking applications. This allows for packing several pieces of data into less memory, making it quicker to transport over network.
					  Example:
						A = 1001111
						B = 10110
						C = 0011
						Unpack A,B,C into X variable by this order
						So...
						A << 9 - left shift with jumps of 9 will return - 1001111000000000
						X |= A (bitwise OR to add A into X)
						B << 4 - left shift with jumps of 4 will return - 0000000101100000
						X |= B
						Finally -> X |= C (does'nt need shifting since its the last binary to add)
						X = 0000000000000000 (16 bits)
					* When unpacking a binary, before we need to record or remember all of the lengths of each individual sequence.
					  To make it work we create a mask that will get all of the bits for each value.
					  Example:
						X = 0011001|11000|0101
						To get the A sequence we will create a mask of one's (1111111000000000) and use the bitwise operator
						AND to clear all the unnecessary one's
						Mask = 1111111|00000|0000
						X & MASK = 0011001|11000|0101
						Then we need to shift to the right so -- A = (X & MaskA) >> 9
						
* Bit toggling - To do that we can use the XOR (^) bitwise operator. It will look at all things together and as long
                 as only one of them is true, you get a true. If both of them are true, you get a false. If both of them
				 are false then you get false.
				 Example:
					attributes = 00010010
					magic =      00010000
					fly =        00000010
					
					attributes ^= magic
					attributes = 00000010
					
					attributes ^= fly
					attributes = 00000000
					
					attributes ^= magic
					attributes = 00010000




		







