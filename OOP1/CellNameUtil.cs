using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class CellNameUtil
    {

        public List<string> ListOfCells(Cell cell)
        {
            string s = cell.exp;
            List<string> res = new List<string>();
            int pos = 0;
            int lenS = s.Length;

            while (pos < lenS)
            {
                string oneOfnames = "";
                if (s[pos] <= 'Z' && s[pos] >= 'A')
                {
                    while (pos < lenS && ((s[pos] >= '0' && s[pos] <= '9') || (s[pos] <= 'Z' && s[pos] >= 'A')))
                    {
                        oneOfnames += s[pos];
                        pos++;

                    }
                    if (IsName(oneOfnames)) res.Add(oneOfnames);

                }
                pos++;
            }
            return res;
        }

        public bool IsName(string s)
        {
            int lenS = s.Length;
            string colCoord = "";
            int rowCoord = 0;
            if ((s[lenS - 1] >= 'A' && s[lenS - 1] <= 'Z'))
            {
                return false;
            }
            for (int i = 1; i < lenS; i++)
            {
                if (s[i] >= 'A' && s[i] <= 'Z')
                {
                    colCoord += s[i];
                }
                if (s[i] >= '0' && s[i] <= '9')
                {
                    rowCoord += s[i] - '0';
                    rowCoord *= 10;
                }
                if (s[i] >= 'A' && s[i] <= 'Z' && s[i - 1] >= '0' && s[i - 1] <= '9')
                {
                    return false;
                }
            }
            return true;

        }
    }
}
