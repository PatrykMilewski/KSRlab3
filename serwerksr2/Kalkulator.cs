using System.Runtime.InteropServices;
using System.Reflection;

namespace serwerksr2
{
    [Guid("F3371A3D-0C76-4328-8BAC-3F179AB4A75B"),
    ComVisible(true),
    ClassInterface(ClassInterfaceType.None),
    ProgId("KSR.Kalkulator.3")]
    public class Kalkulator : IKalkulator
    {

        public Kalkulator() { }

        public int Add(out int v, int a, int b)
        {
            v = a + b;
            return v;
        }
        public int Sub(out int v, int a, int b)
        {
            v = a - b;
            return v;
        }
    }
}
