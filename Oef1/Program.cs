namespace Oef1
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
            string naam = Environment.UserName;
            string tijd = DateTime.Now.ToShortTimeString();
            string date = DateTime.Now.ToShortDateString();

            MessageBox.Show(" hello " + naam +  " het is " + tijd  +  " op "+ date);
        }
    }
}