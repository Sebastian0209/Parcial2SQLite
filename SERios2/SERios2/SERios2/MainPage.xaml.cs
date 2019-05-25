using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SERios2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            nuevoButton.Clicked += NuevoButton_Clicked;
            using (var datos = new DataAccess())
            {
                datosListView.ItemsSource = datos.GetNotes();

            }
        }

        private void NuevoButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ContentsEntry.Text))
            {

                ContentsEntry.Focus();
                return;
            }
            Note note = new Note
            {
                Contents = ContentsEntry.Text,
                CreatedDate = CreatedDateDatePicker.Date,
                ModifiedDate = ModifiedDateDatePicker.Date

            };
            using (var datos = new DataAccess())
            {
                datos.InsertNote(note);
                datosListView.ItemsSource = datos.GetNotes();
            }


            ContentsEntry.Text = string.Empty;

            CreatedDateDatePicker.Date = DateTime.Now;
            ModifiedDateDatePicker.Date = DateTime.Now;



        }
    }
}
