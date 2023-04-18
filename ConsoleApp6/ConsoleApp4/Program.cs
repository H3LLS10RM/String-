using System;
using System.Reflection;

namespace Programm
{
    internal class Program
    {
        static void Main()
        {
            Type type = typeof(string);
            Console.WriteLine("Значения методов:");
            foreach (MethodInfo methods in type.GetMethods())
            {
                Console.WriteLine("\n");
                Console.WriteLine(methods.Name);
                Console.WriteLine($"Абстрактный: {methods.IsAbstract}");
                Console.WriteLine($"Защищённый(protected)?: {methods.IsFamily}");
                Console.WriteLine($"Private Protected?: {methods.IsFamilyAndAssembly}");
                Console.WriteLine($"Protected Internal?: {methods.IsFamilyOrAssembly}");
                Console.WriteLine($"Internal?: {methods.IsAssembly}");
                Console.WriteLine($"Private?: {methods.IsPrivate}");
                Console.WriteLine($"Public?: {methods.IsPublic}");
                Console.WriteLine($"Конструктор?:{methods.IsConstructor}");
                Console.WriteLine($"Static?: {methods.IsStatic}");
                Console.WriteLine($"Virtual?: {methods.IsVirtual}");
                Console.WriteLine($"Тип: {methods.ReturnType}");

            }
            Console.WriteLine("Значения конструторов: \n");
            foreach(ConstructorInfo ctor in type.GetConstructors())
            {
                string constructor = "";

                if (ctor.IsPublic)
                    constructor += "public";
                else if (ctor.IsPrivate)
                    constructor += "private";
                else if (ctor.IsAssembly)
                    constructor += "internal";
                else if (ctor.IsFamily)
                    constructor += "protected";
                else if (ctor.IsFamilyAndAssembly)
                    constructor += "private protected";
                else if (ctor.IsFamilyOrAssembly)
                    constructor += "protected internal";

                Console.Write($"{constructor} {type.Name}");
            }
            Console.WriteLine("Значения полей: \n");
            foreach(FieldInfo pole in type.GetFields())
            {
                string field = "";

                if (pole.IsPublic)
                    field += "public ";
                else if (pole.IsPrivate)
                    field += "private ";
                else if (pole.IsAssembly)
                    field += "internal ";
                else if (pole.IsFamily)
                    field += "protected ";
                else if (pole.IsFamilyAndAssembly)
                    field += "private protected ";
                else if (pole.IsFamilyOrAssembly)
                    field += "protected internal ";

                
                if (pole.IsStatic) field += "static ";

                Console.WriteLine($"{field}{pole.FieldType.Name} {pole.Name}");
            }
            Console.WriteLine("Значения свойств: \n");
            foreach (PropertyInfo prop in type.GetProperties())
            {
                Console.WriteLine("\n");
                Console.WriteLine(prop.Name);
                Console.WriteLine($"Атрибуты: {prop.Attributes}");
                Console.WriteLine($"Can Read?: {prop.CanRead}");
                Console.WriteLine($"Can Write?: {prop.CanWrite}");
                Console.WriteLine($"Get Method: {prop.GetMethod}");
                Console.WriteLine($"Set Method: {prop.SetMethod}");
                Console.WriteLine($"Property Type: {prop.PropertyType}");
                
            }
        }
    }
}
