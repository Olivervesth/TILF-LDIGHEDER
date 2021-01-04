using System;
using System.Collections.Generic;
using System.Text;

namespace Substitution_kryptering
{
    class Encrypter
    {

        public string Table(string s, bool e)//Adds 1 to the letter if encrypting and one from letter if decrypting
        {
            string result = "";
            string[] table = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "x", "y", "z", "æ", "ø", "å" };
            for (int i = 0; i < table.Length; i++)
            {
                if (table[i] == s && e == true)
                {
                    if (i == table.Length)
                    {
                        result = table[0];
                    }
                    else
                    {
                        result = table[i + 1];

                    }
                }
                else if (table[i] == s && e == false)
                {
                    if (i == 0)
                    {
                        result = table[table.Length];
                    }
                    else
                    {
                        result = table[i - 1];

                    }
                }
            }
            return result;
        }
        public string Encrypt(string msg)
        {
            string encryptedmsg = "";
            foreach (char item in msg)
            {
                encryptedmsg += Table(item.ToString(),true);
            }
            return encryptedmsg;
        }
        public string Decrypt(string msg)
        {
            string decryptedmsg = "";
            foreach (char item in msg)
            {
                decryptedmsg += Table(item.ToString(), false);
            }
            return decryptedmsg;
        }
    }
}
