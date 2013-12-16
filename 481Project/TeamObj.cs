using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _481Project
{
    public class TeamObj
    {

        private string name = "";
        public string Name { get { return name; } }
        private string slogan = "";
        public string Slogan { get { return slogan; } }
        private string descritpion = "";
        public string Description { get { return descritpion; } }

        public TeamObj(string n, string s, string des)
        {
            name = n;
            slogan = s;
            descritpion = des;
        }

    }
}
