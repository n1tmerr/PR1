using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class candidate
    {
        private string name;
        private int voices = 0;
        public string getName()
        {
            return name;
        }
        public void addVoice()
        {
            voices++;
        }
        public int getVoices()
        {
            return voices;
        }
    }
}
