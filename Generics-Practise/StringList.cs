﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Practise
{
    internal class StringList
    {
        private string[] stringArray;

        public StringList()
        {
            stringArray = Array.Empty<string>();               
        }


        public void Add(string num)
        {
            Array.Resize(ref stringArray, stringArray.Length + 1);
            stringArray[stringArray.Length - 1] = num;
        }

        public string[] GetAll()
        {
            return stringArray;
        }

        
    }
}