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
using System.Windows.Shapes;

namespace Applications.Desktop.AdminPanel
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Привет, мир!", "Приветственное окно", MessageBoxButton.YesNo,
                MessageBoxImage.Error);
            if (result == MessageBoxResult.Yes)
            {
                MessageBox.Show("Да", startButton.Content.ToString());
            }
            else 
            {
                MessageBox.Show("Нет", startButton.Content.ToString());
            }

            //Ctrl + K, Ctrl + D - выравнивание кода по стилю 
            //Ctrl + R, Ctrl + G - удаление неактивных и упорядочивание using
        }
    }
}