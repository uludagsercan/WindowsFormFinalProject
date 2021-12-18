using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers.AutoFac;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        public static IContainer Container;
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Container = Configure();
            Application.Run(new Form1(Container));
            
        }

        static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new AutoFacBusinessModule());
            builder.RegisterType<Form1>();
            builder.RegisterType<AdminForm>();
            builder.RegisterType<AdminStudentForm>();
            builder.RegisterType<AdminStaffForm>();
           
            return builder.Build();
        }
     
    }
}
