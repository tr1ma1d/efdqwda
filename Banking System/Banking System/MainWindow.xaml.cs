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

namespace Banking_System
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Windows_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }


        // button

        private void btLogin_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void btLogIn_Click_1(object sender, RoutedEventArgs e)
        {
            LogIn logIn = new LogIn();
            try
            {
                if (logIn != null)
                {
                    this.Close();
                    logIn.Show();

                }
            }
            catch
            {

            }
        }
    }
}
