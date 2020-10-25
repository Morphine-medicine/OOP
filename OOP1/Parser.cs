using System;
using System.Collections.Generic;

namespace OOP1
{
    class Parser
    {
        enum Types { NONE, DELIMITER, NUMBER };
        string exp; //выражение заданое в клеточку
        int expIndex; // индекс каждого элемента в строке
        string token; // знак
        Types tokType;
        public Parser()
        {

        }

        public double Evaluate(string expstr)
        {
            if (expstr == "")
            {
                return 0.0;
            }
            double result;
            exp = expstr;
            int l = exp.Length;
            if (exp[l - 1].Equals('+') || exp[l - 1].Equals('-') || exp[l - 1].Equals('/')
                || exp[l - 1].Equals('*') || exp[l - 1].Equals('&') || exp[l - 1].Equals('|')
                || exp[l - 1].Equals('=') || exp[l - 1].Equals('>') || exp[l - 1].Equals('<') || exp[l - 1].Equals('!'))
            {
                throw(new Exception("Last lex should be expression"));
            }
            expIndex = 0;
            try
            {
                GetToken();
                if (token == "")
                {
                    return 0.0;
                    throw (new Exception("No expression"));
                    
                }
                ExpPorivn(out result);
                if (token != "")
                {
                }
                return result;
            }
            catch (Exception ex)
            {
                return 0.0;
            }
        }
        void ExpPorivn(out double result)
        {
            string op;
            double partialResult;

            ExpAndOr(out result);
            while ((op = token) == ">" || op == "<" || op == "=")
            {
                GetToken();
                ExpAndOr(out partialResult);
                switch (op)
                {
                    case ">":
                        result = result > partialResult ? 1d : 0d;
                        break;
                    case "<":
                        result = result < partialResult ? 1d : 0d;
                        break;
                    case "=":
                        result = result == partialResult ? 1d : 0d;
                        break;
                }
            }
        }

        void ExpAndOr(out double result)
        {
            string op;
            double partialResult;
            ExpPlusMin(out result);
            while ((op = token) == "&" || op == "|")
            {
                GetToken();
                ExpPlusMin(out partialResult);
                switch (op)
                {
                    case "&":
                        result = Convert.ToBoolean(partialResult) && Convert.ToBoolean(result) ? 1d : 0d;
                        break;
                    case "|":
                        result = Convert.ToBoolean(partialResult) || Convert.ToBoolean(result) ? 1d : 0d;
                        break;
                }
            }
        }
        void ExpPlusMin(out double result)
        {
            string op;
            double partialResult;
            ExpMultdiv(out result);
            while ((op = token) == "+" || op == "-")
            {
                GetToken();
                ExpMultdiv(out partialResult);
                switch (op)
                {
                    case "-":
                        result -= partialResult;
                        break;
                    case "+":
                        result += partialResult;
                        break;
                }
            }
        }

        void ExpMultdiv(out double result)
        {
            string op;
            double partialResult = 0.0;
            ExpUnar(out result);
            while ((op = token) == "/" || op == "*")
            {
                GetToken();
                ExpUnar(out partialResult);
                switch (op)
                {

                    case "/":
                        if (partialResult == 0.0)
                        {
                            result = 0;
                            return;
                        }
                        else
                        {
                            result /= partialResult;
                        }
                        break;
                    case "*":
                        result *= partialResult;
                        break;
                }
            }
        }
        
        void ExpUnar(out double result)
        {
            string op;
            op = "";
            if ((tokType == Types.DELIMITER) && token == "!")
            {
                op = token;
                GetToken();
            }
            ExpBracket(out result);
            if (op == "!")
                result = result == 0 ? 1d : 0d;
        }
        void ExpBracket(out double result)
        {
            if (token == "(")
            {
                GetToken();
                ExpPorivn(out result);
                if (token != ")")
                {
                }
                GetToken();
            }
            else Atom(out result);
        }
        void Atom(out double result)
        {
            switch (tokType)
            {
                case Types.NUMBER:
                    try
                    {
                        result = Double.Parse(token);
                    }
                    catch (FormatException)
                    {
                        result = 0.0;
                    }
                    GetToken();
                    return;
                default:
                    result = 0.0;
                    break;
            }
        }
        void GetToken()
        {
            tokType = Types.NONE;
            token = "";
            if (expIndex == exp.Length)
            {
                return;
            }
            while (expIndex < exp.Length && Char.IsWhiteSpace(exp[expIndex])) ++expIndex;
            //хвіст
            if (expIndex == exp.Length)
            {
                return;
            }
            if (IsDelim(exp[expIndex]))
            {
                token += exp[expIndex];
                expIndex++;
                tokType = Types.DELIMITER;
            }
            else if (Char.IsDigit(exp[expIndex]) || exp[expIndex] == ',' || exp[expIndex] == '.')
            {
                while (Char.IsDigit(exp[expIndex]) || exp[expIndex] == ',' || exp[expIndex] == '.')
                {
                    if (exp[expIndex] == '.')
                    {
                        token += ',';
                        expIndex++;
                    }
                    else
                    {
                        token += exp[expIndex];
                        expIndex++;
                    }

                    if (expIndex >= exp.Length) break;
                }
                tokType = Types.NUMBER;
            }
        }

        bool IsDelim(char c)
        {
            if ("+-/()<>!|&=".IndexOf(c) != -1)
                return true;
            return false;
        }
    }
}
