using System;
using System.Collections.Generic;
using System.Text;

namespace Startliste
{
    class Registration
    {
        private string _startNumber;
        private string _name;
        private Club _club;
        private string _nationality;
        private string _group;
        private string _class;

        public Registration(string startNumber, string name, Club club, string nationality, string group, string @class)
        {
            _startNumber = startNumber;
            _name = name;
            _club = club;
            _nationality = nationality;
            _group = group;
            _class = @class;
        }

        public string GetName()
        {
            return _name;
        }
        public Club GetClub()
        {
            return _club;
        }
        
    }
}
