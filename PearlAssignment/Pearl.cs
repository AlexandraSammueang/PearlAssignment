﻿namespace PearlAssignment
{
    class Pearl : IPearl
    {
        public int Size { get; set; }
        public int Price { get; set; }
        public Colour _colour { get; set; }
        public Shape _shape { get; set; }
        public Type _type { get; set; }

        #region(IComparable,(IEquatable))
        public int CompareTo(IPearl other)
        {
            if (this.Size != other.Size)
            {
                return this.Size.CompareTo(other.Size);
            }
            if (this._colour != other._colour)
            {
                return this._colour.CompareTo(other._colour);
            }
           
            return this._shape.CompareTo(other._shape);
        }
       
        public bool Equals(IPearl pearl) => (this.Size, this._colour, this._shape) == (pearl.Size, pearl._colour, pearl._shape);
        public override bool Equals(object obj) => Equals(obj as IPearl);
        public override int GetHashCode() => (Size, _colour, _shape, _type).GetHashCode();
        #endregion

        #region(Random,Price)
        public void RandomInit()
        {

            var rnd = new Random();
            bool bAllOK = false;
            while (!bAllOK)
            {
                try
                {
                    this.Size = rnd.Next(5, 26);
                    this._colour = (Colour)rnd.Next((int)Colour.Black, (int)Colour.Pink + 1);
                    this._shape = (Shape)rnd.Next((int)Shape.Round, (int)Shape.Drop + 1);
                    this._type = (Type)rnd.Next((int)Type.FreshWater, (int)Type.SaltWater + 1);

                    bAllOK = true;
                }
                catch { }
            }
        }
        
        public void GetPrice()
        {
            if (_type == Type.FreshWater)
            {
                this.Price = Size * 50;
                
            }
            if (_type == Type.SaltWater)
            {
                this.Price = Size * 100;
                
            }
         
            
            

        }

        #endregion
        public override string ToString()
        {
            return $" Price: {this.Price} Size: {this.Size} Colour: {this._colour} Shape: {this._shape}  Type: {this._type}\n";
        }

        #region(Factory)
        internal static class Factory
        {
            internal static Pearl CreateWithRandomData()
            {
                var pearl = new Pearl();
                pearl.RandomInit();
                pearl.GetPrice();
                return pearl;
            }
        }
        #endregion

    }
}
