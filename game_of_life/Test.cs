using NUnit.Framework;
using System;

namespace game_of_life
{
	[TestFixture ()]
	public class CellTest
	{
		[Test ()]
		public void CellCanBeAlive ()
		{
			Cell cell = new Cell (1);
			Assert.True (cell.IsAlive ());
		}

		[Test ()]
		public void CellCanBeDead ()
		{
			Cell cell = new Cell (0);
			Assert.False (cell.IsAlive ());
		}

		[Test ()]
		public void ACellContainsBlackSquareWhenAlive ()
		{
			Cell cell = new Cell (1);
			Assert.AreEqual ("█", cell.Contents ());
		}

		[Test ()]
		public void ACellContainsWhiteSquareWhenDead ()
		{
			Cell cell = new Cell (0);
			Assert.AreEqual ("░", cell.Contents ());
		}

		[Test ()]
		public void ACellCanDie ()
		{
			Cell cell = new Cell (1);
			cell.Die ();
			Assert.False (cell.IsAlive ());
	    }
	}
}

