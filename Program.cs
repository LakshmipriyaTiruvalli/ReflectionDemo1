using System;
using System.Reflection;

namespace ReflectionDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Type T = Type.GetType("ReflectionDemo.Customer");
            Console.WriteLine("------Information about the class-----");
            Console.WriteLine("Full name is...{0}", T.FullName);
            Console.WriteLine("Name of the class is...{0}", T.Name);
            Console.WriteLine("Name of the namespace is...{0}", T.Namespace);
            Console.WriteLine("-----Properties present inside class-----");
            PropertyInfo[] properties = T.GetProperties();
            foreach(PropertyInfo property in properties)
            {
                Console.WriteLine(property.Name);
            }
            Console.WriteLine("----Methods present inside the class------");
            MethodInfo[] methods= T.GetMethods();
            foreach(MethodInfo method in methods)
            {
                Console.WriteLine(method.Name);
            }
            Console.WriteLine("------Constructors present inside the class-----");
            ConstructorInfo[] constructors= T.GetConstructors();
            foreach(ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.Name);
            }
            Console.ReadLine();
        }
    }
    public class Customer
    {
        public int id { get; set; }
        public string Name { get; set; }
        public Customer(int ID,string Name)
        {
            this.id = ID;
            this.Name = Name;
        }
        public Customer()
        {
            this.id = -1;
            this.Name = string.Empty;
        }
        public void PrintID()
        {
            Console.WriteLine("ID= {0}", this.id);
        }
        public void PrintName()
        {
            Console.WriteLine("Name= {0}", this.Name);
        }
    }
}
