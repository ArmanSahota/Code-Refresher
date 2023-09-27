using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Refresher
{
    internal class Player
    {
        string _name;
        int _number;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }


        public Player (string Name, int number)
        {
         _name = Name;
         _number = number;
        }




    }
}