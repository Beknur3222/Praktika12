using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika12
{
    class Program
    {
        static void Main()
        {
            MyClass myObject = new MyClass();

            myObject.PropertyChanged += HandlePropertyChanged;

            myObject.Name = "NewName";

            Console.ReadLine();
        }

        static void HandlePropertyChanged(object sender, PropertyEventArgs e)
        {
            Console.WriteLine($"Property '{e.PropertyName}' changed");
        }
    }

}
