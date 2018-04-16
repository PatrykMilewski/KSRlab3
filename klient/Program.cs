using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klient
{
    class Program
    {
        static void Main(string[] args)
        {
            TestStos();

            TestKalkulator();
        }

        public static void TestStos()
        {
            Type stos = Type.GetTypeFromProgID("KSR.Stos.3");

            object stosInstance = Activator.CreateInstance(stos);
            stos.InvokeMember("Push", System.Reflection.BindingFlags.InvokeMethod, null, stosInstance, new object[] { 5 });

            object[] args2 = new object[] { null };
            stos.InvokeMember("Pop", System.Reflection.BindingFlags.InvokeMethod, null, stosInstance, args2);

            Console.WriteLine("Pop = {0}", (int)args2[0]);
        }

        public static void TestKalkulator()
        {
            Type kalkulator = Type.GetTypeFromProgID("KSR.Kalkulator.3");

            object stosInstance = Activator.CreateInstance(kalkulator);

            object[] args1 = new object[] { 0, 7, 2 };
            kalkulator.InvokeMember("Add", System.Reflection.BindingFlags.InvokeMethod, null, stosInstance, args1);
            Console.WriteLine("Add = {0}", (int)args1[0]);

            object[] args2 = new object[] { 0, 7, 2 };
            kalkulator.InvokeMember("Sub", System.Reflection.BindingFlags.InvokeMethod, null, stosInstance, args2);

            Console.WriteLine("Sub = {0}", (int)args2[0]);
        }
    }
}
