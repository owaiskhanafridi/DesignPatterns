using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public interface IUIFactory
    {
        void CreateButton();
        void CreateCheckbox();
    }
}
