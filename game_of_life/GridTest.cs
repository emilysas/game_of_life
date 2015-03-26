using NUnit.Framework;
using System;

namespace game_of_life
{

	[TestFixture ()]
	public class GridTest
	{
		Grid grid;

		[SetUp]
		public void Init ()
		{
			grid = new Grid();
		}

		[Test ()]
		public void GridStartsWith10Rows ()
		{
			Assert.AreEqual (10, grid.Rows());
		}

		[Test ()]
		public void GridStartsWith10Columns ()
		{
			Assert.AreEqual (10, grid.Columns());
		}
	}
}

