using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LABA16MDK1.PAGE
{
    /// <summary>
    /// Логика взаимодействия для Task1Page.xaml
    /// </summary>
    public partial class Task1Page : Page
    {
        public Task1Page()
        {
            InitializeComponent();
        }
        private void inputField_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(inputField.Text))
            {
                inputField.Tag = null;
                return;
            }

            if (int.TryParse(inputField.Text, out int value) && value >= 1 && value <= 100)
            {
                inputField.Tag = "Valid";
            }
            else
            {
                inputField.Tag = "Invalid";
            }
        }
    }
}


  
