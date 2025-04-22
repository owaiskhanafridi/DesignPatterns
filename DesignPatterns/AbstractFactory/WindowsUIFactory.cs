using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    internal class WindowsUIFactory: IUIFactory
    {
        public void CreateButton() => new WindowsButton();
        public void CreateCheckbox() => new WindowsCheckbox();


    }
}
