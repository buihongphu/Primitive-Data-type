using System;
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

namespace WpfApplication8
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
        private void typeSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem selectedType = (type.SelectedItem as ListBoxItem);
            switch (selectedType.Content.ToString())
            {
             case "Int":
             showIntValue();
             break;
             case "int":
             showIntValue();
             break;
             case "Long":
             showLongValue();
             break;
             case "Float":
             showFloatValue();
             break;
             case "Double":
             showDoubleValue();
             break;
             case "Decimal":
             showDecimalValue();
             break;
             case "String":
             showStringValue();
             break;
             case "Char":
             showCharValue();
             break;
             case "Bool":
             showBoolValue();
             break;
            }
        }
        private void showIntValue()
        {
            int IntVar;
            IntVar = 42;
            value.Text = IntVar.ToString();
        }
        private void showFloatValue()
        {

            float FloatVar;

            FloatVar = 0.42F; // thêm F sau 42 để phân biệt với kiểu double

            value.Text = FloatVar.ToString();

        }

        private void showDoubleValue()
        {

            double DoubleVar;

            DoubleVar = 0.42;

            value.Text = DoubleVar.ToString();

        }

        private void showDecimalValue()
        {

            decimal DecimalVar;

            DecimalVar = 0.42M; // thêm M sau 42 để phân biệt với kiểu

            // double, float

            value.Text = DecimalVar.ToString();

        }

        private void showStringValue()
        {

            string StringVar;

            StringVar = "forty two";

            value.Text = StringVar; // không cần dùng ToString

        }

        private void showCharValue()
        {

            char CharVar;

            CharVar = 'x';

            value.Text = CharVar.ToString();

        }

        private void showBoolValue()
        {

            bool boolVar;

            boolVar = false;

            value.Text = boolVar.ToString();

        }
        private void showLongValue()
        {

            long LongVar;

            LongVar = 42L;

            value.Text = LongVar.ToString();

        }
        private void quit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}