using System;
using System.Collections.Generic;
using System.Text;

namespace Startliste
{
    class Club
    {
        private string _name;
        private List<Registration> _registrations;

        public Club(string name, List<Registration> registrations)
        {
            _name = name;
            _registrations = registrations;
        }
    }
}
