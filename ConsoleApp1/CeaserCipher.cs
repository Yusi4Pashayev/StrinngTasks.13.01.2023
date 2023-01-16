using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskString
{
    internal class CeaserCipher
    {
        internal string Code(string str, int slide)
        {
            string code = "";
            int a;

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                {
                    if (char.IsUpper(str[i]))
                    {
                        a = ((str[i] + slide) - 65) % 26 + 65;
                        code += (char)a;
                    }

                    else if (char.IsLower(str[i]))
                    {
                        a = ((str[i] + slide) - 97) % 26 + 97;
                        code += (char)a;
                    }
                }

                else
                    code += str[i];
            }

            return code;
        }

        internal string DeCode(string str, int slide)
        {
            string decode = "";
            int a;
            slide = slide % 26;

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                {
                    if (char.IsUpper(str[i]))
                    {
                        a = ((str[i] - slide) - 65 + 26) % 26 + 65;
                        decode += (char)a;
                    }

                    else if (char.IsLower(str[i]))
                    {
                        a = ((str[i] - slide) - 97 + 26) % 26 + 97;
                        decode += (char)a;
                    }
                }

                else
                    decode += str[i];
            }

            return decode;

        }

        internal void Print(string a)
        {
            Console.WriteLine(a);
        }
    }
}
