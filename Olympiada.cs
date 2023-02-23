using System;

namespace Olympiada
{
	internal class Olympiada:IComparable<Olympiada>, IPrint
    {
		private string nameOlymp;
        public string NameOlymp
		{
			get { return nameOlymp; }
			set { nameOlymp = value; }
		}
        private int points;
        public int Points
		{
			get { return points; }
			set { points = value; }
		}
		public Olympiada(string nameOlymp, int points)
		{
			this.nameOlymp = nameOlymp;
			this.points = points;
		}
		public void Print()
		{
			Console.WriteLine(nameOlymp+" has "+points+" points");
		}
        public int CompareTo(Olympiada other)
        {
            return NameOlymp.CompareTo(other.NameOlymp);
        }
    }
}
