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
			Cell cell = new Cell ();
			Assert.True (cell.IsAlive ());
		}
	}
}

