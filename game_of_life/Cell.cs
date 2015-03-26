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
			
		public string Contents ()
		{
			string alive = "█";
			string dead = "░";

			if (IsAlive() == true) {
				return alive;
			} else {
				return dead;
			}
		}

		public void Die ()
		{
			status = 0;
		}

		public void Live ()
		{
			status = 1;
		}


	}
}

