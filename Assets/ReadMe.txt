feature/Bitboards
* A bitboard is a data structure designed to efficiently encode a gameboard state as a set of bits.
* Bitboards won't do everything you need to do in a game, but they will manipulate boards states
* The concept was first used in comupter chess
* Instead of using a bunch of individual integers to represent the state of each board position, we can use a single bit.
* There are 3 main advantages of using bitboards:
	* Encode state more efficiently
	* Read & write with bitwise operations
	* Bitwise operations act in parallel processing because they can be applied to all the board cell simultaneously
* For an eight by eight game board, the bits can be stored in a long integer that has a length of 64.
* Whenever there is a one in the binary sequence of the integer, that indicates a state of the corresponding cell. For example, the first
  8-bit of the integer will relate to the top row of the board, with each storing the state of a single cell.
* Because big boards can only store one's or zero's, it is needed to separate bit boards for different states.
	Example:
		* A bitboard that records where the white cells of a chessboard are would look like this:
			10101010
			01010101
			10101010
			01010101
			10101010
			01010101
			10101010
			01010101
		* It is also required to have records of where the black cells are:
			01010101
			10101010
			01010101
			10101010
			01010101
			10101010
			01010101
			10101010
		* Following states above, the opposite state can be found using the 'not' operator
			* white = ~black
			  black = ~white
* In case of two players, one is red and one is blue, the positions of each player would be stored in a bitboard. For each player position,
  1 is assigned to record its position on the board.
* To find for example all the red players on the black squares, a bitwise operation can be used between the black bitboard (State) and the red
  bitboard (Another state).
  * Red players on black squares = black & red
  * Blue players on white sqaures = white & blue
  * All player's positions = red | blue
  * Empty sqaures positions = ~(red | blue)
* Bitboards are pretty useless unless we can put values into them and get values out. The bitboard is shown as square of numbers.
  We need to remember that it is a single integer and one dimensional. So currently there is a board that is two dimensional and a binary
  sequence that is one dimensional.
* Array flattening - Unfold the two dimensions and place them into one. The index into the array is calculated with -> row * width + column
* To place a piece into the board with row=1 and column= 5, the binary integer will look like this:
	* number[row*8 + column] = 13. The piece is going to e at the index in the binary sequence of 13
	  Now it is required to set the state of the binary index to a 1. To do that we can shift 1 to the left across to the 13th position. However,
	  there is no option to do that on the bitboard itself since it is already populated with other bits.
	  Instead we can create a bitboard with just 1 bit turned on representing that single piece and then use bitwise operation OR(|) too add this
	  bitboard to the main bitboard.
	* The method in code will look like this:
		long SetCellState(long bitboard, int row, int col)
		{
			long newBit = 1L << (row*8 + col);
			return (bitboard |= newBit);
		}
	* The method in code for getting a cell state will look like this:
		long GetCellState(long bitboard, int row, int col)
		{
			long mask = 1L << (row*8 + col);
			return ((bitboard & mask) != 0);
		}
		
8

while(8 != 0)
00001000
00001000




			