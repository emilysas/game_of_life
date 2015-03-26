using System;

namespace game_of_life
{
	public class Grid
	{
		int rows;
		int columns;

		public Grid ()
		{
			rows = 10;
			columns = 10;
		}

		public int Rows ()
		{
			return rows;
		}

		public int Columns ()
		{
			return columns;
		}
	}
}

