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
                if (x <= 0)
                {
                    y = (A / 2) * (Math.Pow(Math.E, (x / A)) + Math.Pow(Math.E, (-x / A)));
                    Answer.Text += $"y({x}) = " + y.ToString() + Environment.NewLine;

                }
                else if (x > 0)
                {
                    y = 4 * Math.Pow(A, 3) / (x * x + 4 * A * A);
                    Answer.Text += $"y({x}) = " + y.ToString() + Environment.NewLine;
                }
                x += M;
            }
        }

        
    }
}
