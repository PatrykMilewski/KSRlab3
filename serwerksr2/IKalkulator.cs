using System;
using System.Runtime.InteropServices;
using System.Reflection;

namespace serwerksr2
{
    [Guid("3F5A083C-73A8-4B2C-B4CF-BA72098827CC"),
    ComVisible(true),
    InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IKalkulator
    {
        int Add(out int v, int a, int b);
        int Sub(out int v, int a, int b);
    }
}
