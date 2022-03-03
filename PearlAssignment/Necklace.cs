using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PearlAssignment
{
    
    class Necklace : INecklace
    {
        List<IPearl> _pearlLists = new List<IPearl>();
        public IPearl this[int idx] => _pearlLists[idx];
        #region(Count)
        
        public int Count()
        {
            return _pearlLists.Count;
        }

      

        #endregion
        public void Sort()
        {
            _pearlLists.Sort();
        }        
        
        public void RandomInit(int NrOfPearls)
        {
            var rnd = new Random();
            for (int i = 0; i < NrOfPearls; i++)
            {
                _pearlLists.Add(Pearl.Factory.CreateWithRandomData()); 
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
        public int Count(Type type)
        {
            //int count = 0;

            //for (int i = 0; i < _pearlLists.Count; i++)
            //{
            //    if (type == _pearlLists[i]._type)
            //    {
            //        count++;
            //    }


            //}

            //return count;

            int c = 0;
            foreach (var item in _pearlLists )
            {
                if (type == item._type)
                   c++;
            }
            return c;
        }
        public int IndexOf(IPearl pearl) => _pearlLists.IndexOf(pearl);

        public decimal GetPrice()
        {
            decimal TotalPrice = 0M;

            for (int p = 0; p < _pearlLists.Count; p++)
            {
                TotalPrice += _pearlLists[p].Price;
            }

            return TotalPrice;
        }

        //public int IndexOf(IPearl pearl) => _pearlLists.IndexOf(pearl);
        //public IPearl this[int idx] { get { return _pearlLists[idx]; } }
        #region(Factory)
        internal static class Factory
        {
            internal static Necklace CreateWithRandomData(int NrOfPearls)
            {
                var _necklace = new Necklace();
                _necklace.RandomInit(NrOfPearls);
                
                return _necklace;
            }

          
        }
        #endregion
    }
}
