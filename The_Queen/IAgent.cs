﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Queen
{
    public interface IAgent
    {
        void Stop();
        void Resume();
        void Update();
    }
}
