using System;
using System.Collections.Generic;

namespace game_of_life
{
	public class Board
	{
		Dictionary<string, object> grid;
		Cell liveCell;
		Cell deadCell;

		public Board ()
		{
			grid = new Dictionary<string, object> ();
			liveCell = new Cell(0);
			deadCell = new Cell (1);
			AddToGrid("A1", liveCell);
			AddToGrid("A2", liveCell);
			AddToGrid("A3", deadCell);
			AddToGrid("A4", liveCell);
			AddToGrid("A5", deadCell);
			AddToGrid("B1", liveCell);
			AddToGrid("B2", deadCell);
			AddToGrid("B3", deadCell);
			AddToGrid("B4", deadCell);
			AddToGrid("B5", liveCell);
			AddToGrid("C1", liveCell);
			AddToGrid("C2", liveCell);
			AddToGrid("C3", deadCell);
			AddToGrid("C4", liveCell);
			AddToGrid("C5", deadCell);
			AddToGrid("D1", liveCell);
			AddToGrid("D2", deadCell);
			AddToGrid("D3", deadCell);
			AddToGrid("D4", deadCell);
			AddToGrid("D5", liveCell);
			AddToGrid("E1", liveCell);
			AddToGrid("E2", deadCell);
			AddToGrid("E3", deadCell);
			AddToGrid("E4", deadCell);
			AddToGrid("E5", liveCell);
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

