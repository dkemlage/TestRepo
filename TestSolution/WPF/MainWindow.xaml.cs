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

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            comboBox.Items.Add("Luke");
            comboBox.Items.Add("Darth Vader");
        }

        /// <summary>
        /// This method always returns "Hello World".
        /// </summary>
        /// <returns>The string "Hello World".</returns>
        public string SayHello()
        {
            return "Hello World";
        }

        /// <summary>
        /// This method always returns "Luke, I am your father!".
        /// </summary>
        /// <returns>The string "Luke, I am your father!".</returns>
        public string DarthVader()
        {
            return "Luke, I am your father!";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

          var selected = this.comboBox.SelectedItem;

            if (selected.ToString() == "Luke")
            {
                MessageBox.Show(SayHello());
            }
            if (selected.ToString() == "Darth Vader")
            {
                MessageBox.Show(DarthVader());
            }
        }
    }
}
