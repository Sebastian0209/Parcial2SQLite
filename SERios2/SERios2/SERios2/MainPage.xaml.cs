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

        }
    }
}
