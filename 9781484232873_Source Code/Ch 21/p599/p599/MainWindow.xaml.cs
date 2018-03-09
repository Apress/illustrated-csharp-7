using System.Threading;
using System.Windows;

namespace MessagePump
{
   public partial class MainWindow : Window
   {
      public MainWindow()
      {
         InitializeComponent();
      }

      private void btnDoStuff_Click( object sender, RoutedEventArgs e )
      {
         btnDoStuff.IsEnabled = false;
         lblStatus.Content    = "Doing Stuff";
         Thread.Sleep( 4000 );
         lblStatus.Content    = "Not Doing Anything";
         btnDoStuff.IsEnabled = true;
      }
   }
}