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
using Week1;

namespace Week5
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

        private void startbutton_Click(object sender, RoutedEventArgs e)
        {
            var lecturer = new { ID = 29, Name = "Dani" };
            var lecturer2 = new { ID = 30, Name = "Oshri" };
            var lecturer3 = new { ID = 31, Name = "Yair", Age = 30 };
            tbShow.Text = lecturer2.ToString() + " " + lecturer2.GetType();

            string str = "123";
            string StudentName = "Aviad";

            Student s = StudentName.ToStudent();
            
            int i = MyTools.ToInt(str);
            int i2 = str.ToInt();

            int j = "123".ToInt();

            string a = "123a";
            try
            {
                int c = Int32.Parse(a);
            }
            catch (Exception ex)
            {
                tbShow.Text = ex.Message;
                 throw new MyExpception("new message", ex);
            }
            finally
            {
                tbShow.Text = "I always happen";
            }

        }
        IEnumerable<int> Fibonacci()
        {
            int a = 1, b = 1; yield return 1; yield return 1;
            while (true) { int c = a + b; a = b; b = c; yield return c; }
        }


        private void FibonacciButton_Click(object sender, RoutedEventArgs e)
        {
            tbShow.Text = "";
            StringBuilder fib = new StringBuilder();
            foreach (var i in Fibonacci())
            {
                if (i > 1000) break;
                fib.Append(i).Append(",");
                tbShow.Text = fib.ToString();
                
            }

        }
    }
}
