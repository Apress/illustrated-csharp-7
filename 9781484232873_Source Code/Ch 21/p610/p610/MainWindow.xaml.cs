using System.Windows;
using System.ComponentModel;
using System.Threading;

namespace SimpleWorker
{
   public partial class MainWindow : Window
   {
      BackgroundWorker bgWorker = new BackgroundWorker();
      public MainWindow()
      {
         InitializeComponent();

         // Set BackgroundWorker properties
         bgWorker.WorkerReportsProgress      = true;
         bgWorker.WorkerSupportsCancellation = true;

         // Connect handlers to BackgroundWorker object.
         bgWorker.DoWork             += DoWork_Handler;
         bgWorker.ProgressChanged    += ProgressChanged_Handler;
         bgWorker.RunWorkerCompleted += RunWorkerCompleted_Handler;
      }

      private void btnProcess_Click( object sender, RoutedEventArgs e )
      {
         if ( !bgWorker.IsBusy )
            bgWorker.RunWorkerAsync();
      }

      private void ProgressChanged_Handler( object sender,
      ProgressChangedEventArgs args )
      {
         progressBar.Value = args.ProgressPercentage;
      }

      private void DoWork_Handler( object sender, DoWorkEventArgs args )
      {
         BackgroundWorker worker = sender as BackgroundWorker;
         for ( int i = 1; i <= 10; i++ )
         {
            if ( worker.CancellationPending )
            {
               args.Cancel = true;
               break;
            }
            else
            {
               worker.ReportProgress( i * 10 );
               Thread.Sleep( 500 );
            }
         }
      }

      private void RunWorkerCompleted_Handler( object sender,
      RunWorkerCompletedEventArgs args )
      {
         progressBar.Value = 0;
         if ( args.Cancelled )
            MessageBox.Show( "Process was cancelled.", "Process Cancelled" );
         else
            MessageBox.Show( "Process completed normally.", "Process Completed" );
      }

      private void btnCancel_Click( object sender, RoutedEventArgs e )
      {
         bgWorker.CancelAsync();
      }
   }
}