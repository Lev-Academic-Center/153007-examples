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

namespace _153007_examples
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

        private void week1_Click(object sender, RoutedEventArgs e)
        {
            Student s1 = new Student();

            s1.Name = "Cinderella";
            s1.Age = 18;

            tbMain.Text = "hello " + s1.Name + " " + s1.Age;
        }
    }
}
