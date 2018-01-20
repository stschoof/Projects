﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RegalDisplayClassWpfApplication
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Regal.Display.margin_from_top = 2;
            for (int i = 0; i < 64; i++)
            { Regal erstesRegal = new Regal();

                anzeigeFeld.Children.Add(erstesRegal.regaldisplay(erstesRegal)); }

            /*
            RegalDisplay zweitesRegal = new RegalDisplay();
            zweitesRegal.regaldisplay(anzeigeFeld, zweitesRegal); */
        }
    }
}
