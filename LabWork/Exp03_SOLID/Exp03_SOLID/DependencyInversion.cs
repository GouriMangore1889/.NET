using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp03_SOLID
{
    
        // Abstraction
        public interface IMessageService
        {
            void SendMessage(string message);
        }

        // Low-level module
        public class EmailService : IMessageService
        {
            public void SendMessage(string message)
            {
                Console.WriteLine("Email sent: " + message);
            }
        }

        // High-level module depends on abstraction
        public class Notification
        {
            private IMessageService _messageService;

            public Notification(IMessageService messageService)
            {
                _messageService = messageService;
            }

            public void Notify(string message)
            {
                _messageService.SendMessage(message);
            }
        }
    
}
