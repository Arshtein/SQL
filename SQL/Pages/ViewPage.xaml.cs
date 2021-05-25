using System;
using SQL.Config;
using Xamarin.Forms;

namespace SQL.Pages
{
    public partial class ViewPage : ContentPage
    {
        public ViewPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            notesList.ItemsSource = App.dB.GetItems();
            base.OnAppearing();                        
        }

        private void noteSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Note sNote = (Note)e.SelectedItem;
            MessagingCenter.Send<ViewPage, Note>(this, "dInfo", sNote);
            MessagingCenter.Send<ViewPage, Note>(this, "uInfo", sNote);
        }
    }
} 