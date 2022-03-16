using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KeyDeck
{
    public class Keyboard
    {
        //public KeyboardList[] Keyboards { get; set; }
        public List<KeyboardList> Keyboards { get; set; }
    }

    public class KeyboardList
    {
        public string Keyboard { get; set; }
        //public Keydata[] KeyData { get; set; }
        public List<KeyData> KeyData { get; set; }
    }

    public class KeyData
    {
        public Nullable<ushort> Key { get; set; }
        public string Function { get; set; }
        public string FunctionData { get; set; }
    }

}
