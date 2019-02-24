﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    public interface IGamePattern<T>
    {
        T RetrieveNext();
        void Remove(int index);
        T RetrievePrevious();
        T RetrieveCurrent();
    }
}
