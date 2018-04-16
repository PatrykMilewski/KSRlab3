using System.Runtime.InteropServices;
using System.Reflection;

namespace serwerksr
{
    [Guid("6B920DFC-E058-4A99-802D-C8FD0DCD0E97"),
    ComVisible(true),
    ClassInterface(ClassInterfaceType.None),
    ProgId("KSR.Stos.3")]
    public class Stos : IStos
    {

        int[] stack = new int[100];
        int head = 0;

        public Stos() { }

        public int Push(int v)
        {
            stack[head++] = v;
            return 1;
        }
        public int Pop(out int v)
        {
            v = stack[--head];
            return v;
        }
    }
}
