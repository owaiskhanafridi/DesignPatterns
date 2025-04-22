using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class MacButton : IButton
    {
        public void Render() => Console.WriteLine("Rendering Mac Button");
    }

    public class MacCheckbox : ICheckbox 
    { 
        public void Render() => Console.WriteLine("Rendering Mac Checkbox");
    }
}
