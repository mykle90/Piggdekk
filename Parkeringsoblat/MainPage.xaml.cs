using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;
using Parkeringsoblat.Resources;

namespace Parkeringsoblat
{
    public partial class MainPage : PhoneApplicationPage
    {
        private const string PhoneNumber = "2300";
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;
            if (settings.Contains("regnr"))
            {
                txtRegNr.Text = (string)settings["regnr"];
            }
            
            if (settings.Contains("heavy"))
            {
                bool isHeavy = (bool) settings["heavy"];
                if (isHeavy)
                {
                    heavy.IsChecked = true;
                }
                else
                {
                    notHeavy.IsChecked = true;
                }
            }
            
        }

        private string GenerateSmsCode(string regnr, bool heavy)
        {
            if (heavy) return string.Format("PIGG TUNG OSLO {0}", regnr);
            return string.Format("PIGG OSLO {0}", regnr);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;
            settings["regnr"] = txtRegNr.Text;
            settings["heavy"] = heavy.IsChecked != null && (bool)heavy.IsChecked;

            SmsComposeTask smsComposeTask = new SmsComposeTask();
            smsComposeTask.To = PhoneNumber;
            smsComposeTask.Body = GenerateSmsCode(txtRegNr.Text, heavy.IsChecked != null && (bool)heavy.IsChecked);

            smsComposeTask.Show();
        }

  
    }
}