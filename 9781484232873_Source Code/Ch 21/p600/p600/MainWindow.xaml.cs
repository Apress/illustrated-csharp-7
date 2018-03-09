using System.Threading.Tasks;
using System.Windows;

namespace MessagePump
{
   public partial class MainWindow : Window
   {
      public MainWindow()
      {
         InitializeComponent();
      }

      private async void btnDoStuff_Click( object sender, RoutedEventArgs e )
      {
         btnDoStuff.IsEnabled = false;
         lblStatus.Content = "Doing Stuff";
         await Task.Delay( 4000 );
         lblStatus.Content = "Not Doing Anything";
         btnDoStuff.IsEnabled = true;
      }
   }
}