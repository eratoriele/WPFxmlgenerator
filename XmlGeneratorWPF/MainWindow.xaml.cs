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

namespace XmlGeneratorWPF
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

        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            turnAllInvisible();

        }

        private void PlateRecognitionButton_Click(object sender, RoutedEventArgs e)
        {
            turnAllInvisible();
            // Set required fields to visible
            fromTextBox.Visibility = Visibility.Visible;
            fromTextBlock.Visibility = Visibility.Visible;
            toTextBox.Visibility = Visibility.Visible;
            toTextBlock.Visibility = Visibility.Visible;
            dPathTextBlock.Visibility = Visibility.Visible;
            dPathTextBox.Visibility = Visibility.Visible;

            plateRecognitionButton.IsEnabled = false;

            fromTextBox.Focus();
        }

        private void SecurityRecordingButton_Click(object sender, RoutedEventArgs e)
        {
            turnAllInvisible();
            // Set required fields to visible
            fromTextBox.Visibility = Visibility.Visible;
            fromTextBlock.Visibility = Visibility.Visible;
            toTextBox.Visibility = Visibility.Visible;
            toTextBlock.Visibility = Visibility.Visible;
            sPathTextBlock.Visibility = Visibility.Visible;
            sPathTextBox.Visibility = Visibility.Visible;
            dPathTextBlock.Visibility = Visibility.Visible;
            dPathTextBox.Visibility = Visibility.Visible;

            securityRecordingButton.IsEnabled = false;

            fromTextBox.Focus();
        }

        // Turns every button except for 3 main buttons to invisible, so that when a new one is selected,
        // Only the relevant ones are shown
        private void turnAllInvisible()
        {
            fromTextBox.Visibility = Visibility.Collapsed;
            fromTextBlock.Visibility = Visibility.Collapsed;
            toTextBox.Visibility = Visibility.Collapsed;
            toTextBlock.Visibility = Visibility.Collapsed;
            sPathTextBlock.Visibility = Visibility.Collapsed;
            sPathTextBox.Visibility = Visibility.Collapsed;
            dPathTextBlock.Visibility = Visibility.Collapsed;
            dPathTextBox.Visibility = Visibility.Collapsed;

            operationButton.IsEnabled = true;
            plateRecognitionButton.IsEnabled = true;
            securityRecordingButton.IsEnabled = true;
        }
    }
}
