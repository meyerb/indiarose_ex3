using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.ApplicationInsights.Extensibility.Implementation;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace indiarose_ex3
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<Todo> _todoListe;

        public ObservableCollection<Todo> TodoListe
        {
            get { return _todoListe; }
            set { _todoListe = value; }
        }

        public MainPage()
        {
            this.InitializeComponent();
            TodoListe=new ObservableCollection<Todo>();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Save));
        }
    }

    public class Todo
    {
        private TextBlock _textBlock1;
        private TextBlock _textBlock2;

        public Todo(String t,String d)
        {
            _textBlock1.Text = t;
            _textBlock2.Text = d;
        }

        public void EditTodo(String t, String d)
        {
            _textBlock1.Text = t;
            _textBlock2.Text = d;
        }
    }
}
