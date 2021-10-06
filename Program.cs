using System;
using OpenTK.Windowing.Desktop;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var nativeWindowSettings = new NativeWindowSettings() //settingan window
            {
                Size = new OpenTK.Mathematics.Vector2i(800, 800),
                Title = "Pertemuan 1"
            };

            //ngeloop Window sampai program diclose, setelah slesai memori akan di free
            using (var window = new Window(GameWindowSettings.Default,nativeWindowSettings))
            {
                window.Run();
            }
        }
    }
}
