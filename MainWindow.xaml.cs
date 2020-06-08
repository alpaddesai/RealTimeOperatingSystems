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

namespace CodingRTOS
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Practice code examples of task management ");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Practice code examples of preemptive, nonpreemptive, priority scheduling ");

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Practice code examples using sempaphore, mutex and monitor ");

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Practice code examples displaying time partitioning ");

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Practice code examples displaying prioirty inversion and inheritance protocol ");

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Practice code examples displaying task synchronization ");

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Practice code examples displaying memory allocation and memory management unit ");

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Practice code examples displaying an embedded environment ");
        }           


        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Practice code examples displaying scheduling and execution in AMP/SMP/BMP systems ");

        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Practice code examples displaying distributed systems ");

        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Practice code examples displaying static and dynamic scheduling policies");

        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Practice code examples displaying HW and SW interrupts ");

        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Practice code examples displaying operating systems ");

        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Practice code examples displaying performance benchmarks with basic requirements ");

        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Practice code examples displaying debugging and multitasking ");

        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Practice code examples with Free RTOS ");

        }
    }
}
