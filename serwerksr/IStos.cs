using System;
using System.Runtime.InteropServices;
using System.Reflection;

namespace serwerksr
{
    [Guid("57BD4399-E51B-40DB-B11A-59948343AEE6"),
    ComVisible(true),
    InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IStos
    {
        int Push(int v);
        int Pop(out int v);
    }
}
