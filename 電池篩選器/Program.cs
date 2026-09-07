namespace 電池篩選器
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();

            using (var loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                Application.Run(new Form1(loginForm.isPaidMember));
            }
        }
    }
}