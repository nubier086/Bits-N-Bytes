using Bits_N_Bytes.Database;
namespace Bits_N_Bytes
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            DatabaseHelper.InitializeDatabase();

            // CPUs
            DatabaseHelper.AddProduct("AMD Ryzen 7 5700", 9750, 20, "Images/ryzen7.png", "AMD", "CPU");
            DatabaseHelper.AddProduct("AMD Ryzen 9 9950X3D", 49999, 20, "Images/ryzen9.png", "AMD", "CPU");
            DatabaseHelper.AddProduct("Ryzen 5 9600X", 17999, 20, "Images/ryzen5.png", "AMD", "CPU");
            DatabaseHelper.AddProduct("Core Ultra 9 285K", 42999, 20, "Images/intel9.png", "Intel", "CPU");
            DatabaseHelper.AddProduct("Core Ultra 7 265K", 29999, 20, "Images/intel7.png", "Intel", "CPU");
            DatabaseHelper.AddProduct("Core Ultra 5 245K", 19999, 20, "Images/intel5.png", "Intel", "CPU");

            // GPUs
            DatabaseHelper.AddProduct("RTX 5070", 45999, 20, "Images/rtx5070.png", "NVIDIA", "GPU");
            DatabaseHelper.AddProduct("RTX 5070 Ti", 55999, 20, "Images/rtx5070ti.png", "NVIDIA", "GPU");
            DatabaseHelper.AddProduct("RTX 5080", 75999, 20, "Images/rtx5080.png", "NVIDIA", "GPU");
            DatabaseHelper.AddProduct("RTX 5090", 139999, 20, "Images/rtx5090.png", "NVIDIA", "GPU");
            DatabaseHelper.AddProduct("RTX 5060 Ti", 32999, 20, "Images/rtx5060ti.png", "NVIDIA", "GPU");

            // Motherboards
            DatabaseHelper.AddProduct("MEG Z890 ACE", 39999, 20, "Images/mb1.png", "MSI", "Motherboard");
            DatabaseHelper.AddProduct("MPG Z890 Carbon WiFi", 32999, 20, "Images/mb2.png", "MSI", "Motherboard");
            DatabaseHelper.AddProduct("MAG Z890 Tomahawk", 24999, 20, "Images/mb3.png", "MSI", "Motherboard");
            DatabaseHelper.AddProduct("MAG Z890 Tomahawk WiFi", 26999, 20, "Images/mb4.png", "MSI", "Motherboard");
            DatabaseHelper.AddProduct("PRO Z890-P WiFi", 18999, 20, "Images/mb5.png", "MSI", "Motherboard");

            // RAM
            DatabaseHelper.AddProduct("Trident Z5 Royal Neo", 15999, 20, "Images/ram1.png", "G.Skill", "RAM");
            DatabaseHelper.AddProduct("Trident Z5 RGB", 12999, 20, "Images/ram2.png", "G.Skill", "RAM");
            DatabaseHelper.AddProduct("Ripjaws M5 RGB", 10999, 20, "Images/ram3.png", "G.Skill", "RAM");
            DatabaseHelper.AddProduct("Flare X5", 8999, 20, "Images/ram4.png", "G.Skill", "RAM");

            // PC Bundles
            DatabaseHelper.AddProduct("Bundle 1", 129999, 20, "Images/bundle1.png", "Bits N Bytes", "Bundle");
            DatabaseHelper.AddProduct("Bundle 2", 159999, 20, "Images/bundle2.png", "Bits N Bytes", "Bundle");
            DatabaseHelper.AddProduct("Bundle 3", 199999, 20, "Images/bundle3.png", "Bits N Bytes", "Bundle");


            Application.Run(new Form1());
        }
    }


}