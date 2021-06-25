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

namespace Calc
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string number1 = null;
        public static int comma = 0;
        public static int func = 0;
        public static int PorM = 0;
        public static int sw = 0;
        public static int lght = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            tbConcl.Text += 0;
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            tbConcl.Text += 1;
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            tbConcl.Text += 2;
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            tbConcl.Text += 3;
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            tbConcl.Text += 4;
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            tbConcl.Text += 5;
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            tbConcl.Text += 6;
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            tbConcl.Text += 7;
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            tbConcl.Text += 8;
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            tbConcl.Text += 9;
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tbConcl.Text = null;
                comma = 0;
                PorM = 0;
                func = 0;
                number1 = null;
            }
            catch (Exception)
            {
                tbConcl.Text = "Ошибка";
            }

        }

        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int lenght = tbConcl.Text.Length - 1;
                string text = tbConcl.Text;
                tbConcl.Text = null;
                for (int i = 0; i < lenght; i++)
                {
                    tbConcl.Text += text[i];
                }
            }
            catch (Exception)
            {
                tbConcl.Text = "Ошибка";
            }

        }

        private void btnComma_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (comma == 0)
                {
                    tbConcl.Text += ",";
                    comma = 1;
                }
            }
            catch (Exception)
            {
                tbConcl.Text = "Ошибка";
            }


        }

        private void btnProc_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((number1 != string.Empty) && (tbConcl.Text != "-"))
                {
                    number1 = tbConcl.Text;
                    tbConcl.Text = null;
                    func = 1;
                    btnRes.IsEnabled = true;
                    comma = 0;
                }
            }
            catch (Exception)
            {
                tbConcl.Text = "Ошибка";
            }

        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                number1 = tbConcl.Text;
                if ((number1 != string.Empty) && (tbConcl.Text != "-"))
                {
                    tbConcl.Text = null;
                    func = 5;
                    comma = 0;

                    btnRes.IsEnabled = true;
                }
            }
            catch (Exception)
            {
                tbConcl.Text = "Ошибка";
            }

        }

        private void btnMyltiply_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                number1 = tbConcl.Text;
                if ((number1 != string.Empty) && (tbConcl.Text != "-"))
                {
                    tbConcl.Text = null;
                    func = 6;
                    comma = 0;

                    btnRes.IsEnabled = true;
                }
            }
            catch (Exception)
            {
                tbConcl.Text = "Ошибка";
            }

        }

        private void btnMinus_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (tbConcl.Text == string.Empty)
                {
                    tbConcl.Text = "-";
                    PorM = 1;
                }
                else if ((tbConcl.Text != null) && (tbConcl.Text != "-"))
                {
                    number1 = tbConcl.Text;
                    if (number1 != string.Empty)
                    {
                        tbConcl.Text = null;
                        func = 7;
                        PorM = 0;
                        comma = 0;

                        btnRes.IsEnabled = true;
                    }
                }

            }
            catch (Exception)
            {
                tbConcl.Text = "Ошибка";
            }


        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                number1 = tbConcl.Text;
                if ((number1 != string.Empty) && (tbConcl.Text != "-"))
                {
                    tbConcl.Text = null;
                    func = 8;
                    comma = 0;

                    btnRes.IsEnabled = true;
                }
            }
            catch (Exception)
            {
                tbConcl.Text = "Ошибка";
            }

        }

        private void btnRes_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((number1 != string.Empty) && (tbConcl.Text != "-") && (tbConcl.Text != string.Empty))
                {
                    if (func == 1)
                    {
                        tbConcl.Text = Calculat.Mod(number1, tbConcl.Text);

                        number1 = null;
                        comma = 0;
                    }
                    else if (func == 5)
                    {
                        tbConcl.Text = Calculat.Divide(number1, tbConcl.Text);
                        if (tbConcl.Text.Length > 10)
                        {
                            string text = tbConcl.Text;
                            tbConcl.Text = null;
                            for (int i = 0; i < 10; i++)
                            {
                                tbConcl.Text += text[i];
                            }

                        }
                        comma = 0;
                        number1 = null;
                    }
                    else if (func == 7)
                    {
                        tbConcl.Text = Calculat.Minus(Convert.ToDouble(number1), Convert.ToDouble(tbConcl.Text)).ToString();
                        comma = 0;
                        number1 = null;
                    }
                    else if (func == 8)
                    {
                        tbConcl.Text = Calculat.Plus(Convert.ToDouble(number1), Convert.ToDouble(tbConcl.Text)).ToString();

                        string str = tbConcl.Text;
                        if (tbConcl.Text.Length > 11)
                        {
                            tbConcl.Text = null;
                            tbConcl.Text = Convert.ToString(str[0]) + "," + Convert.ToString(str[1]) + Convert.ToString(str[2]);
                            tbConcl.Text += $"×10^{str.Length - 1}";
                        }

                        comma = 0;
                        number1 = null;
                    }

                    btnRes.IsEnabled = false;
                }
            }
            catch (Exception)
            {
                tbConcl.Text = "Ошибка";
            }


        }

    }
}
