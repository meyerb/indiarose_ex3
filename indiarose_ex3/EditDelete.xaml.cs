﻿using System;
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
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour plus d'informations sur le modèle d'élément Page vierge, voir la page http://go.microsoft.com/fwlink/?LinkId=234238

namespace indiarose_ex3
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class EditDelete : Page
    {
        private Todo _todo;

        public EditDelete(Todo t)
        {
            this.InitializeComponent();
            _todo = t;
            TextTitle.Text = "Title :"+_todo.Title;
            TextDescription.Text = "Description :"+_todo.Description;
        }

        public void Delete()
        {
           // _todo.DeleteTodo();
        }
    }
}
