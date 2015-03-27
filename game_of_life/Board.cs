using System;
using System.Collections.Generic;
using System.Text;

namespace game_of_life
{
	public class Board
	{
		int width;
		int length;
		Cell[,] grid;
		Cell cell;

		public Board (int w, int l, Cell c)
		{
			width = w;
			length = l;
			grid = new Cell [width, length];
			cell = c;
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

		public Cell GridRef(int x_coordinate, int y_coordinate)
		{
			return grid [x_coordinate, y_coordinate];
		}





	}
}

