using System;
using SQL.Config;
using Xamarin.Forms;

namespace SQL.Pages
{
    public partial class DelPage : ContentPage
    {
        Note dNote = new Note();
        public DelPage()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<ViewPage, Note>(this, "dInfo", (sender, arg) => sub(arg));
        }
        private void sub(Note nt)
        {
            dNote = nt;
            Text.Text = dNote.Content;
            Del.IsEnabled = true;
        }

        private void dbClick(object sender, EventArgs e)
        {
            App.dB.DeleteItem(dNote.Id);
            Text.Text = null;
            Del.IsEnabled = false;
        }
    }
}