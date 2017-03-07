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

namespace Fat_Percentage_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int totalCalories;
        int fatCalories;
        int percentFat;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                fatCalories = int.Parse(textBox.Text) * 9;
                totalCalories = int.Parse(textBox1.Text);
                percentFat = fatCalories/totalCalories;
                label.Content=fatCalories;
                label1.Content = percentFat;
            }
            catch (Exception)
            {

                MessageBox.Show("Please enter also the total number of calories");
            }
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
