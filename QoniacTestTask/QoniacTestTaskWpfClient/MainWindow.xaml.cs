using System;
using System.ServiceModel;
using System.Windows;

namespace QoniacTestTaskWpfClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly QoniacTestTaskServiceClient _client = new QoniacTestTaskServiceClient();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show(_client.ParsePrice(PriceTextBox.Text));
            }
            catch (FaultException<string> exception)
            {
                MessageBox.Show(exception.Detail);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
