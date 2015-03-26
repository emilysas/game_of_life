using NUnit.Framework;
using System;

namespace game_of_life
{

	[TestFixture ()]
	public class GridTest
	{
		Board board;

		[SetUp]
		public void Init ()
		{
			board = new Board();
		}

		[Test ()]
		public void BoardStartsWithGrid5x5 ()
		{
			Assert.AreEqual (25, board.CellCount);
		}
			
	}
}

