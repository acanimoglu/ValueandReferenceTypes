using System;

namespace ValueandReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int num1 = 10;
            int num2 = 30;
            num1 = num2;
            //num1=30
            num2 = 65;
            int[] nums=new int[] {10,20,30};
            int[] nums2 = new int[] { 100, 200, 300 };
            nums = nums2;
            nums2[0] = 999;
            //nums[0]=999
            //int, decimal, float,double, bool data types are value types
            //array, class interface data types are referencce types
            //in the memory there is two areas called stack and heap
            // value types  are created at the stack
            //reference types are created at the stack with their address
            //thus it will be a connection at the reference types beetween stack and heap beyond reference types which held by address
        }
    }
}
