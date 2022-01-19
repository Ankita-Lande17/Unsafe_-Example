// See https://aka.ms/new-console-template for more information
using System;
namespace Unsafe_Example{
class UnsafeTest
{
    unsafe static void SquarePtrParam(int* p)
    {
        *p *= *p;
    }

    unsafe static void Main()
    {
        int i = 12;
    
        SquarePtrParam(&i);
        Console.WriteLine(i);
    }
}

}