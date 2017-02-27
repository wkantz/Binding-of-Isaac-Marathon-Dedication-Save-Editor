using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isaac_Achievement_Unlocker
{
    class SaveFile
    {
        public bool Enabled { get; set; }
        public string Location { get; set; }
        public SaveFile()
        {
            Enabled = false;
            Location = "";
        }
    }
}
