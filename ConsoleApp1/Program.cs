using System.Runtime.Serialization;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();


         obj.list2.Add(10);
            obj.list2.Remove(10);
        foreach(var item in obj.list2)
            {
                Console.WriteLine(item);
            }
           
        }
    }
}