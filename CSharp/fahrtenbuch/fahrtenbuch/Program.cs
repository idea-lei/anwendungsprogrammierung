namespace fahrtenbuch
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize(); // F11
            using (AppDbContext db = new AppDbContext())
            {
                db.Database.EnsureCreated();
            }
            Application.Run(new Form1());
        }
    }
}