﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Defination
{
    public interface ICompare<T>
    {
        int CompareTo(T comparableInstance);
    }
}
