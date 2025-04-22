using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    internal class SmsNotification: INotificationSender
    {
        public void Send(string recepient, string message) => Console.WriteLine($"recepient: {recepient}, message: {message}")
    }
}
