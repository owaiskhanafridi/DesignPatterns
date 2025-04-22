﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public interface IButton
    {
        void Render();
    }

    public interface ICheckbox
    {
        void Render();
    }

}
