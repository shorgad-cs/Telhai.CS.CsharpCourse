//--01 Using for other Namspace
using Telhai.CS.CsharpCourse.Database;

namespace Telhai.CS.CsharpCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //--02 Use Only class name
            Db d = new Db();
            FileManager fileManager = new FileManager();
            Console.ReadKey();
        
        }
    }
}
