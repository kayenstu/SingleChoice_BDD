using System;
using System.Collections.Generic;
using System.Text;

namespace SingleChoice_BDD
{
    class SingleChoice
    {
        public string name { get; set; }
        public string question { get; set; }
        public List<string> answers { get; set; } = new List<string>();
        public int choice { get; set; } = -1;

    }
}
