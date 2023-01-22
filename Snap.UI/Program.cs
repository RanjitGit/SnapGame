using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;

namespace Snap.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new HostBuilder()
               .ConfigureServices((hostContext, services) =>
               {
                   services.AddScoped<Snap>();
                   services.AddLogging(option =>
                   {
                       option.SetMinimumLevel(LogLevel.Information);
                       option.AddNLog("nlog.config");
                   });
               });

            var host = builder.Build();

            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            ApplicationConfiguration.Initialize();

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                try
                {
                    var snap = services.GetRequiredService<Snap>();
                    Application.Run(snap);
                }
                catch (Exception ex)
                {
                    ShowExceptionDetails(ex);
                }
            }
        }

        /// <summary>
        /// All exceptions thrown by the main thread are handled over this method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            ShowExceptionDetails(e.Exception);
        }

        /// <summary>
        /// All exceptions thrown by additional threads are handled in this method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            ShowExceptionDetails((Exception)e.ExceptionObject);
        }

        static void ShowExceptionDetails(Exception ex)
        {
            // Do logging of exception details
            MessageBox.Show(ex.Message, ex.TargetSite?.ToString(),MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}