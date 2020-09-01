using System;
using System.IO;
using Xamarin.Forms;
using Notes.Data;

namespace Notes
{
    public partial class App : Application
    {
        // Singleton
        static NoteDatabase database;

        public static NoteDatabase Database
        {
            // I need to grok the get keyword
            get
            {
                if (database == null)
                {
                    // Instantiates the singleton database in the event that it hasn't been instantiated yet
                    database = new NoteDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Notes.db3"));
                }
                return database;
            }
        }


        public App()
        {
            // what does this guy do again?
            InitializeComponent();
            // Sets up navigation
            MainPage = new NavigationPage(new NotesPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}