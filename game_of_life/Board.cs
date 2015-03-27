using System;
using System.Collections.Generic;
using System.Text;

namespace game_of_life
{
	public class Board
	{
		int width;
		int length;
		Cell cell;
		Cell[,] grid;

		public Board (int w, int l)
		{
			width = w;
			length = l;
			grid = new Cell [width, length];
			FillGrid ();
		}

		private void FillGrid()
		{
			for (int i = 0; i < width; i++) {
				for (int j = 0; j < length; j++) {
					grid[i, j] = cell;
				}
			}
		}

		public int CellCount()
		{
			return grid.Length;
		}





	}
}

