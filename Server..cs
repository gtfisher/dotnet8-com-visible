namespace dotnet8_com_visible;

using System;
 using System.Runtime.InteropServices;

 [ComVisible(true)]
[Guid("99173B4D-CEC3-4483-A0EF-CB4B14BA1635")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IServer
{
    /// <summary>
    /// Compute the value of the constant Pi.
    /// </summary>
    double ComputePi();
}

 [ComVisible(true)]
[Guid("F2003A8E-0FF9-4C7D-A554-6E15C849946D")]
public class  Server : IServer
{
    public double ComputePi(){
        return 22/7;
    }
}
