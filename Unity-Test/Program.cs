using Microsoft.Practices.Unity.Configuration;
using Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Unity_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IPerson, Student>("student");
            IPerson student = container.Resolve<IPerson>("student");

            student.ClassName = student.GetType().ToString();
            student.Name = "xiaoming";
            Console.WriteLine(student.ClassName);
            student.Say();

            Console.WriteLine();
            Console.WriteLine(ContainerConfiguration());

            Console.ReadLine();

        }

        public static string ContainerConfiguration()
        {
            IUnityContainer container = new UnityContainer();
           
            container.LoadConfiguration("MyContainer");
            UnityConfigurationSection section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");

            section.Configure(container, "MyContainer");

            IPerson classInfo = container.Resolve<IPerson>("Student");
            classInfo.ClassName = classInfo.GetType().ToString();

            return classInfo.ClassName;
        }
    }
}
