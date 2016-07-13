using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dependency_injection
{
    class FormHandler
    {
        readonly IMailSender mailsender;
        public FormHandler(IMailSender mailsender)
        {
            this.mailsender = mailsender;
        }

        public FormHandler()
        {

        }

        public void tightly_coupled_Handle(string toaddress)
        {
            new TightlyCoupled().Send(toaddress, "this is non ninject example");
        }

        public void basic_decoupling_Handle(string toaddress)
        {
            new BasicDecoupling().Send(toaddress, "this is non ninject  example");
        }

        public void ManuallyDI_Handle(string toAddress)
        {
            mailsender.Send(toAddress, "This is non-Ninject example Manually DI");
        }

        public void NinjectHandle(string toAddress)
        {
            mailsender.Send(toAddress, "This is Ninject example DI");
        }

    }
}
