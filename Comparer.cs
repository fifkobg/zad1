using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympiada
{
    internal class IComparer:IComparer<Olympiada>
    {
        public int Compare(Olympiada x, Olympiada y)
        {
            return x.Points.CompareTo(y.Points);
        }
    }
}
