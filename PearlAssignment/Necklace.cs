using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PearlAssignment
{
    
    class Necklace : INecklace
    {
        List<Pearl> _pearlLists = new List<Pearl>();
        public int Count()
        {
            return _pearlLists.Count;
        }

        public void Sort()
        {
            _pearlLists.Sort();
        }

        //public int Count(int year)
        //{
        //    int count = 0;
        //    foreach (Pearl pearl1 in _necklaceList)
        //    {
        //        if (pearl. == year)
        //        {
        //            count++;
        //        }

        //    }
        //    return count;
        //}
        public override string ToString()
        {
            string sRet = "";
            for (int i = 0; i < _pearlLists.Count; i++)
            {
                sRet += $"{_pearlLists[i],-10}";
                if ((i + 1) % 10 == 0)
                    sRet += "\n";
            }
            return sRet;
        }
    }
}
