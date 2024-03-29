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

namespace RGR_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            double x1 = double.Parse(Box_x1.Text);
            double x = x1;
            double x2 = double.Parse(Box_x2.Text);
            double A = double.Parse(Box_A.Text);
            double M = double.Parse(Box_M.Text);
            double y;
            while (x <= x2)
            {
                if (x < 0)
                {
                    y = Math.Sqrt(Math.Sqrt(16 * Math.Pow(A,4) + 4 * A * A * x * x) - x * x - A * A);
                    Answer.Text += $"y({x}) = " + y.ToString() + Environment.NewLine;

                }
                else if (x >= 0)
                {
                    y = A * Math.Sqrt(3) + Math.Sqrt(A * A - Math.Pow(Math.E, -x) * Math.Sin(A * x));
                    Answer.Text += $"y({x}) = " + y.ToString() + Environment.NewLine;
                }
                x += M;
            }
        }

        
    }
}
