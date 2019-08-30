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

namespace WpfApp
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

        public async void HelloWorldButton_Click(object sender, RoutedEventArgs args)
        {
            var c = new System.Net.Http.HttpClient
            {
                BaseAddress = new Uri("https://example.com"),
            };

            var s = Grpc.Net.Client.GrpcClient.Create<MyGrpcServices.HelloWorldService.HelloWorldServiceClient>(c);
            var r = await s.SayHelloAsync(new MyGrpcServices.HelloWorldRequest { Name = "xxx" });
            MessageBox.Show(r.Message);
        }
    }
}
