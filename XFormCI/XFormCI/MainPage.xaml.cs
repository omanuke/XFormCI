using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace XFormCI
{
    public partial class MainPage : ContentPage
    {
        private int _counter;
        private int _logExCounter;

        public MainPage()
        {
            InitializeComponent();
        }

        private void ToSecondClicked(object sender, EventArgs e)
        {
            (Application.Current.MainPage as NavigationPage)?.PushAsync(new SecondPage());
        }

        private void OnProgress(object sender, EventArgs e)
        {
            Analytics.TrackEvent("ReportProgress",
                new Dictionary<string, string>() {{"counter", (_counter++).ToString()}});
        }

        private void OnRaiseEx(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnLogEx(object sender, EventArgs e)
        {
            try
            {
                throw new ArithmeticException();
            }
            catch (Exception ex)
            {
                Crashes.TrackError(ex,
                    new Dictionary<string, string>() {{"logExCounter", (_logExCounter++).ToString()}});
            }
        }
    }
}
