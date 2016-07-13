using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_injection
{
    interface IMailSender
    {
        void Send(string toAddress, string subject);
    }
}
