using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PearlAssignment
{
    public enum Colour { Black, White, Pink }

    public enum Shape { Round, Drop }

    public enum Type { FreshWater, SaltWater }
    public interface IPearl : IEquatable<IPearl>, IComparable<IPearl>
    {
        public int Size { get; set; }
        public int Price { get; set; }

        public Colour _colour { get; set; }
        public Shape _shape { get; set; }

        public Type _type { get; set; }

        public void RandomInit();
    }
}