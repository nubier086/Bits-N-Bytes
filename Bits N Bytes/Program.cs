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

            // Add sample product including Brand and Category
            DatabaseHelper.AddProduct(
                "AMD Ryzen 7 5700",
                9750,
                20,
                "Images/ryzen7.png",
                "AMD",
                "CPU"
            );

            Application.Run(new Form1());
        }
    }
}