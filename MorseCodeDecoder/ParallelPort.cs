using System.Runtime.InteropServices;

namespace MorseCodeDecoder
{
    class PortInterop
    {
        [DllImport("inpout32.dll", EntryPoint = "Out32")]
        public static extern void Output(int address, int value);
    }
}
