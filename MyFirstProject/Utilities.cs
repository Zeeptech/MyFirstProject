using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public class Utilities
    {
        public static bool IsInArray(string[] arrays, string keyword)
        {
            bool exist = false;
            if (Array.Exists(arrays, item => item.ToLower() == keyword.ToLower()))
            {

                exist = true;
            }
            return exist;


        }
    }
}
