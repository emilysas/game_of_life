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
			Assert.True (cell.IsDead ());
		}
	}
}

