using System;

namespace game_of_life
{
	public class Cell
	{
		int status;

		public Cell (int startpoint)
		{
			status = startpoint;
		}

		public Boolean IsAlive ()
		{
			if (status == 1) {
				return true;
			} else {
			    return false;
			}
		}


	}
}

//string dead = ░;
//string alive = █;

