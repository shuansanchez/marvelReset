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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace marvelReset.Views
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class charGrid : Page
    {
        public charGrid()
        {
            this.InitializeComponent();
            JsonCall(); //async call to getCharacters
        }

        public void JsonCall() //esto tiene que estar en un command/--binding-- parece mejor binding
        {
            listaPersonajes.ItemsSource = apiRequest.GetCharacters();
            //mientras personajes %100==0, seguir pidiendo de 100 en 100
        }
    }
}