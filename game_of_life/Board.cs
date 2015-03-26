using System;
using System.Collections.Generic;

namespace game_of_life
{
	public class Board
	{
		Dictionary<string, object> grid;
		Cell cell;

		public Board ()
		{
			grid = new Dictionary<string, object> ();
			cell = new Cell(0);
			AddToGrid("A1", cell);
			AddToGrid("A2", cell);
			AddToGrid("A3", cell);
			AddToGrid("A4", cell);
			AddToGrid("A5", cell);
			AddToGrid("B1", cell);
			AddToGrid("B2", cell);
			AddToGrid("B3", cell);
			AddToGrid("B4", cell);
			AddToGrid("B5", cell);
		}

		public void AddToGrid(string coordinates, object contents)
		{
			grid.Add(coordinates, contents);
		}

		public int CellCount()
		{
			return grid.Count;
		}


	}
}

