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
                    int size = rnd.Next(5,26);
                   



                  
                    //            this.Type = (Type) rnd.Next((int) Type.Sweetwater, (int) Type.Saltwather + 1);

                    //string[] _firstnames = "Fred John Mary Jane Oliver Marie".Split(' ');
                    //string[] _lastnames = "Johnsson Pearsson Smith Ewans Andersson".Split(' ');
                    //            this.FirstName = _firstnames[rnd.Next(0, _firstnames.Length)];
                    //            this.LastName = _lastnames[rnd.Next(0, _lastnames.Length)];

                    bAllOK = true;
                }
                catch { }
            }
        }

    }
}
