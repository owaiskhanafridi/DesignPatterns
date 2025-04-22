using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class WindowsButton : IButton
    {
        public void Render() => Console.WriteLine("Rendering Windows Button");
    }

    public class WindowsCheckbox : ICheckbox
    {
        public void Render() => Console.WriteLine("Rendering Windows Checkbox");
    }
}
