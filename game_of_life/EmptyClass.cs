using System;

namespace game_of_life
{
	public class Cell
	{
		int status;

		public Cell ()
		{
			status = 1;
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

