namespace PearlAssignment
{
    class Pearl :IPearl
    {
        public int Size { get; set; }
        public int Price { get; set; }
        public Colour _colour { get; set; }
        public Shape _shape { get; set; }
        public Type _type { get; set; }

        public int CompareTo(IPearl other)
        {
            throw new NotImplementedException();
        }

        public bool Equals(IPearl other)
        {
            throw new NotImplementedException();
        }

        public void RandomInit()
        {
       
         var rnd = new Random();
            bool bAllOK = false;
            while (!bAllOK)
            {
                try
                {
                    this.Size = rnd.Next(5,26);
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

        }

    }
}
