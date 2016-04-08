using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
        public static MyViewModel _viewModel;



        public MainPage()
        {
            InitializeComponent();
            _viewModel = new MyViewModel {TodoListe = new ObservableCollection<Todo>()};
            NavigationCacheMode=NavigationCacheMode.Enabled;
            DataContext = _viewModel;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Save));
        }

        private void ButtonTodo_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof (EditDelete),new Todo("dd","dd"));
        }
    }

    public class Todo
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public Todo(String t,String d)
        {
                Title = t;
                Description = d;
        }

        private void EditDelete()
        {

        }

        public void EditTodo(String t, String d)
        {
                Title = t;
                Description = d;
        }
    }

    public class MyViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Todo> _liste;

        public ObservableCollection<Todo> TodoListe
        {
            get { return _liste; }
            set
            {
                _liste = value;
                RaisePropertyChanged("TodoListe");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
