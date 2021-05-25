using System;
using SQL.Config;
using Xamarin.Forms;

namespace SQL.Pages
{
    public partial class UpdatePage : ContentPage
    {
        Note uNote = new Note();
        public UpdatePage()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<ViewPage, Note>(this, "uInfo", (sender, arg) => sub(arg));
        }
        private void sub(Note nt)
        {
            uNote = nt;
            Text.Text = uNote.Content;
            Upd.IsEnabled = true;
            Text.IsEnabled = true;
        }
        private void udClick(object sender, EventArgs e)
        {
            Upd.IsEnabled = false;
            uNote.Content = Text.Text;
            App.dB.UpdateItem(uNote);
            uNote = null;
            Text.Text = null;
            Text.IsEnabled = true;
        }

    }
}