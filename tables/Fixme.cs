using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tables
{
    class Fixme
    {
        /* Add your functions here. You must have at least
        public static bool table(string left, string door, string right)
        to compile the project */

        static bool And(bool a, bool b)
        {
            
            if (a == false)
            {
                return false;
            }
            else
            {
                return b;
            }
        }

        static bool Or(bool a, bool b)
        {
            if (a == true)
            {
                return true;
            }
            else
            {
                return b;
            }
        }

        static bool No(bool a)
        {
            if (a == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static bool Nand(bool a, bool b)
        {
            return No(And(a, b));
        }

        static bool Nor(bool a, bool b)
        {
           return No(Or(a, b));
        }

        static bool Xor(bool a, bool b)
        {
            if (a == false )
            {
                if (b == false)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        static bool Xnor(bool a, bool b)
        {
            if (a != b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Test(string left, string gate, string right)
        {
            bool a = false;
            bool b = false;
            bool res;
            if (left == "true")
            {
                a = true;
            }
            if (right == "true")
            {
                b = true;
            }
            switch (gate)
            {
                case "and":
                    res = And(a, b);
                    break;
                case "or":
                    res = Or(a, b);
                    break;
                case "no":
                    res = No(a);
                    break;
                case "nand":
                    res = Nand(a, b);
                    break;
                case "nor":
                    res = Nor(a, b);
                    break;
                case "xor" :
                    res = Xor(a, b);
                    break;
                case "xnor":
                    res = Xnor(a, b);
                    break;
                    default:
                    res = false;
                    break;
            }
            return res;
        }

    }
}
