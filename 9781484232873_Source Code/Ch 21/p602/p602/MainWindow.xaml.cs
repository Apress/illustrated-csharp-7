using System.Threading.Tasks;
using System.Windows;
namespace AsyncLambda
{
   public partial class MainWindow : Window
   {
      public MainWindow()
      {
         InitializeComponent();

         startWorkButton.Click += async ( sender, e ) =>
         {
            SetGuiValues( false, "Work Started" );
            await DoSomeWork();
            SetGuiValues( true, "Work Finished" );
         };
      }

      private void SetGuiValues( bool buttonEnabled, string status )
      {
         startWorkButton.IsEnabled = buttonEnabled;
         workStartedTextBlock.Text = status;
      }
      private Task DoSomeWork()
      {
         return Task.Delay( 2500 );
      }
   }
}