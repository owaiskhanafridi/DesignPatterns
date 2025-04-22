using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public interface INotificationSender
    {
        void Send(string recipient, string message);
    }
}
