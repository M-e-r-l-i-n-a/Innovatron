namespace Innovatron
{
    internal static class Program
    {
        public static List<string> Actions = new() { "cancel", "take" };

        public static room1 room1 = new();
        public static room2 room2 = new();
        public static room3 room3 = new();
        public static room4 room4 = new();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}