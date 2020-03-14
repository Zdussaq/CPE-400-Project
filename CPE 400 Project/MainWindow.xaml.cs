﻿using CPE400Project.EnvironmentData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace CPE400Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        #region Constructors

        public MainWindow()
        {
            InitializeComponent();

            Map = new Map(1000,1600);
            MapGrid.Map = Map;
            DataContext = this;



        }

        #endregion Constructors

        #region Properties

        public Map Map { get; set; }

        #endregion Properties

        #region PrivateFunctions


        #endregion PrivateFunctions

        #region PublicFunctions


        #endregion Public FUnctions

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MapGrid.Map = new Map(500,500);
        }
    }
}
