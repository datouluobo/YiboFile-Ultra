using System;

namespace YiboFile
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            var app = new UltraApp();
            app.InitializeComponent(); // 加载 App.xaml 资源
            app.Run();
        }
    }
}
