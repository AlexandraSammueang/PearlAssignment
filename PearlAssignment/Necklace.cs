using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PearlAssignment
{
    
    class Necklace : INecklace
    {
        List<INecklace> _necklaceList = new List<INecklace>();
        public int Count()
        {
            return _necklaceList.Count;
        }

        public void Sort()
        {
            _necklaceList.Sort();
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
            for (int i = 0; i < _necklaceList.Count; i++)
            {
                sRet += $"{_necklaceList[i],-10}";
                if ((i + 1) % 10 == 0)
                    sRet += "\n";
            }
            return sRet;
        }
    }
}
