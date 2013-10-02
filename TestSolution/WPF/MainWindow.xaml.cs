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
            MessageBox.Show(SayHello());
            MessageBox.Show(DarthVader());
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

    }
}
