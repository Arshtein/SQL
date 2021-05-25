using System;
using Xamarin.Forms;
using SQL.Config;
using System.IO;

namespace SQL
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "notes.db";
        public static NotesRepository db;
        public static NotesRepository dB
        {
            get
            {
                if (db == null)
                {
                    db = new NotesRepository(
                        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return db;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
