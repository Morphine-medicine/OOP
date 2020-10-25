using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Indexator
    {
            public int Pow(int x, int n)
            {
                if (n == 0 && x != 0) return 1;
                for (int i = 0; i < n - 1; i++)
                {
                    x *= x;
                }
                return x;
            }

            public string ChangeLetter(string s, char c, int pos)
            {
                string res = "";
                for (int i = 0; i < pos; i++)
                {
                    res += s[i];
                }
                res += c;
                if (pos <= s.Length - 1)
                {
                    for (int i = pos + 1; i < s.Length; i++)
                    {
                        res += s[i];
                    }
                }
                return res;
            }
            private string ForNextLetter(string s, int zero)
            {
                try
                {
                    int pos = s.Length - zero - 1;
                    if (s[pos] == 'Z')
                    {
                        s = ChangeLetter(s, 'A', pos);
                        if (pos == 0) return s + 'A';
                        else return ForNextLetter(s, zero + 1);
                    }
                    else s = ChangeLetter(s, (char)(s[pos] + 1), pos);

                    return s;
                }
                catch (IndexOutOfRangeException)
                { return "A"; }

            }
            public string NextLetter(string s)
            {
                return ForNextLetter(s, 0);
            }


            public int LetterToNumber(string s)
            {
                int res = 0;
                int n = s.Length;
                for (int i = 0; i < n; i++)
                {
                    res += Pow(26, n - i - 1) * ((s[i] - 0) - 65 + 1);// 26 - количество букв в англ алфавите, 65 - код буквы А
                }
                return res;
            }

            public string NumberToLetter(int n)
            {
                string res = "A";
                while (LetterToNumber(res) != n)
                {
                    res = NextLetter(res);
                }
                return res;
            }
        }
}
