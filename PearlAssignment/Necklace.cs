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

        public Necklace(int NrOfPearls)
        {
            //var rnd = new Random();
            for (int i = 0; i < NrOfPearls; i++)
            {
                _pearlLists.Add(new Pearl()); 
            }
        }
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

        //internal static class Factory
        //{
        //    internal static INecklace CreateWithRandomData()
        //    {
        //        var _necklace = new Pearl();
        //        pearl.RandomInit();
        //        pearl.GetPrice();
        //        return _necklace;
        //    }
        //}
    }
}
