using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Startliste
{
    class HandleFile
    {
        private List<string> _lines = new List<string>();
        private List<Registration> _registrations = new List<Registration>();
        private List<string> allClubNames = new List<string>();
        
        public void run()
        {
            MakeLines();
            MakeRegistrations();
            //ShowName();
        }
        private void MakeLines()
        {
            StreamReader reader = new StreamReader(@"C:\Users\GET\source\repos\Startliste\Startliste\startlist.csv");
            while (!reader.EndOfStream)
            {
                _lines.Add(reader.ReadLine().Replace("\"", ""));
            }
            _lines.Remove(_lines[0]);
        }
        private void MakeRegistrations()
        {
            var i = 1;
            foreach (var line in _lines)
            {
                var word = line.Split(",");
                allClubNames.Add(word[2]);
            }

            foreach (var line in _lines)
            {
                var word = line.Split(",");
                if (!isNewClub(allClubNames, word[2])) i++;
                _registrations.Add(new Registration(word[0], word[1], new Club(word[2], i), word[3], word[4],
                    word[5]));
            }
        }

        private bool isNewClub(List<string> clubNames, string word)
        {
            foreach (var club in clubNames)
            {
                if (club != word) return true;
            }
            return false;
        }
        //private void ShowName()
        //{
        //    foreach (var registration in _registrations)
        //    {
        //        Console.Write(registration.GetClub()._Id + " ");
        //    }
        //}
    }
}
