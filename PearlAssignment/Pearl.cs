namespace PearlAssignment
{
    class Pearl
    {
       

        public void RandomInit()
        {
       

        var rnd = new Random();
        bool bAllOK = false;
            while (!bAllOK)
            {
                try
                {
                    int size = rnd.Next(5,26);
                    //color
                    //Form
                    //Type enum


                  
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
