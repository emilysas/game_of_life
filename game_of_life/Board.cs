using System;
using System.Collections.Generic;
using System.Text;

namespace game_of_life
{
	public class Board
	{
		Dictionary<string, Cell> grid;
		Cell cell;

		public Board ()
		{
			grid = new Dictionary<string, Cell> ();
			cell = new Cell (0);
			CreateGrid (cell);
		}

		public void AddToGrid(string coordinates, Cell cell)
		{
			grid.Add(coordinates, cell);
		}

		public void CreateGrid(Cell cell)
		{
			for (int i = 1; i <= 5; i++)
			{
				for (int j = 0; j < 5; j++)
				{
					int unicode = (0007 + j);
					StringBuilder gridRef = new StringBuilder ();
					gridRef.Append ("\\u")
						.Append (unicode)
						.Append(i);
					string coordinate = gridRef.ToString();
					AddToGrid(coordinate, cell);
				}
			}
		}

		public int CellCount()
		{
			return grid.Count;
		}




	}
}

