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

namespace WpfEvents
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MyButton.Click += MyButton_Click;
            MyButton.Click += MyButton_IClickedThis;
                                
        }

        void MyButton_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();

            MyLabel.Content = "Hello World!";
        }
        void MyButton_IClickedThis(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();

            MyLabel.Content = "Hello World again!";
        }
    }
}
