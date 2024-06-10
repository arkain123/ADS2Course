using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    internal class Hash
    {
        public const int LEN = 101;
        public string[] arr = new string[LEN];
        public string lastname = "";

        public string[] Arr
        {
            get { return arr; }
        }

        public int GetLEN()
        {
            return LEN;
        }

        public Hash()
        {
            for (int i = 0; i < LEN; i++)
            {
                arr[i] = "0";
            }
        }

        public int Hashing(int key) // метод свертки
        {
            int result = 0;
            while (key > 0)
            {
                result += key % 100;
                key = (key - key % 100) / 100;
            }
            return result;
        }

        public int StringToInt(string s)
        {
            int k = 0;
            while (s.Length > 0)
            {
                k += ((int)s[s.Count()-1]) % 100;
                s = s.Remove(s.Length - 1);
            }
            return k;
        }
        
        public string AddElement(string skey)
        {
            lastname = skey;
            int hkey = Hashing(StringToInt(lastname));
            return TryInserting(hkey);
        }

        // Литвиненко и Гунич и Кременчуков
        // Паксой и Кременчуков
        // Ваделевич и Карпуть
        public string TryInserting(int hkey)
        {
            while (hkey > 100)
            {
                hkey -= 101;
            }

            if (arr[hkey] == "0")
            {
                arr[hkey] = lastname;
                return "Done! Added to " + hkey + " position.";
            }
            TryInserting(LinearProbing(hkey));
            return "Conflict on position " + hkey + "!";
        }

        public int LinearProbing(int key)
        {
            int pkey = key * 2;
            while (pkey + 1 > LEN) pkey -= LEN;
            return pkey;
        }
    }
}
