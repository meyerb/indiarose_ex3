using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour plus d'informations sur le modèle d'élément Page vierge, voir la page http://go.microsoft.com/fwlink/?LinkId=234238

namespace indiarose_ex3
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class Save : Page
    {
        public Save()
        {
            this.InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            if (!BlockTextSaveTitle.Text.Equals("") && !BlockTextSaveDescription.Text.Equals(""))
            {
                var newTodo = new Todo(BlockTextSaveTitle.Text,BlockTextSaveDescription.Text);
                MainPage._viewModel.TodoListe.Add(newTodo);
                if(MainPage._viewModel.TodoListe.Count>0)
                Frame.Navigate(typeof(MainPage));
            }
            if (BlockTextSaveTitle.Text.Equals(""))
            {
                BlockTextSaveTitle.Text = "Title...";
            }
            if (BlockTextSaveDescription.Text.Equals(""))
            {
                BlockTextSaveDescription.Text = "Description...";
            }
        }
    }
}
