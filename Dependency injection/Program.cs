using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using System.Reflection;
using Ninject.Modules;


namespace Dependency_injection
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Tightly Coupled*/
            new FormHandler().tightly_coupled_Handle("test@test.com");


            /*Basic decoupling*/
            IMailSender Basic_decoupling_mailsender = new BasicDecoupling();
            new FormHandler(Basic_decoupling_mailsender).basic_decoupling_Handle("a@a.com");



            /*Manual DI*/
            IMailSender ManualDI_mailsender = new ManualDI();
            new FormHandler(ManualDI_mailsender).ManuallyDI_Handle("test@test.com");
     


          

            /*Ninject*/
            var kernel = new StandardKernel();
            new NinjectDI(kernel).Load();
            kernel.Load(Assembly.GetExecutingAssembly());

            var NinjectmailSender = kernel.Get<IMailSender>();

            var NinjectformHandler = new FormHandler(NinjectmailSender);
            NinjectformHandler.NinjectHandle("Ninject@Ninject.com");
            Console.ReadLine();
        }
    }
}
