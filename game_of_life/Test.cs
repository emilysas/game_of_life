using NUnit.Framework;
using System;

namespace game_of_life
{
	[TestFixture ()]
	public class CellTest
	{
		Cell liveCell;
		Cell deadCell;

		[SetUp]
		{
			liveCell = new Cell(1);
			deadCell = new Cell(0);
		}

		[Test ()]
		public void CellCanBeAlive ()
		{
			Assert.True (liveCell.IsAlive ());
		}

		[Test ()]
		public void CellCanBeDead ()
		{
			Assert.False (deadCell.IsAlive ());
		}

		[Test ()]
		public void ACellContainsBlackSquareWhenAlive ()
		{
			Assert.AreEqual ("█", liveCell.Contents ());
		}

		[Test ()]
		public void ACellContainsWhiteSquareWhenDead ()
		{
			Assert.AreEqual ("░", deadCell.Contents ());
		}

		[Test ()]
		public void ACellCanDie ()
		{
			liveCell.Die ();
			Assert.False (liveCell.IsAlive ());
	    }

		[Test ()]
		public void ACellCanLive ()
		{
			deadCell.Live ();
			Assert.True (deadCell.IsAlive ());
		}
	}
}

