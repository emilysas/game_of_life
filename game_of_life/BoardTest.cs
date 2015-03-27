using NUnit.Framework;
using System;

namespace game_of_life
{

	[TestFixture ()]
	public class GridTest
	{
		Board board;
		Cell cell;

		[SetUp]
		public void Init ()
		{
			cell = new Cell (0);
			board = new Board(5, 5, cell);
		}

		[Test ()]
		public void BoardStartsWithGrid5x5 ()
		{
			Assert.AreEqual (25, board.CellCount());
		}

		[Test ()]
		public void EachSquareInGridContainsACell ()
		{
			Assert.AreEqual  (cell, board.GridRef(0,0));
		}
			
	}
}

