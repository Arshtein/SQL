using System;
using SQL.Config;
using Xamarin.Forms;

namespace SQL.Pages
{
    public partial class AddPage : ContentPage
    {
        public AddPage()
        {
            InitializeComponent();
            Note nt = new Note();
            BindingContext = nt;
        }

        private void AddNote(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;
            if (!String.IsNullOrEmpty(note.Content))
            {
                App.dB.AddItem(note);
            }
            Text.Text = null;
        }
        private void ClearText(object sender, EventArgs e)
        {
            Text.Text = null;
        }

        private void tChange(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Text.Text))
            {
                Clear.IsEnabled = true;
                Add.IsEnabled = true;
            }
            else
            {
                Clear.IsEnabled = false;
                Add.IsEnabled = false;
            }
        }
    }
}