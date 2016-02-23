using Prism.Commands;
using System;
using System.Net.NetworkInformation;
using System.Threading;

namespace SuicSoft.LittlesPDFMerge.Windows
{
    class ViewModel
    {
        public ViewModel()
        {
            NetworkChange.NetworkAvailabilityChanged += NetworkChange_NetworkAvailabilityChanged;
        }
        public bool isavalible = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
        void NetworkChange_NetworkAvailabilityChanged(object sender, NetworkAvailabilityEventArgs e)
        {
            isavalible = e.IsAvailable;
            mOpenSupportWebsiteCommand.RaiseCanExecuteChanged();
            OpenSupportWebsiteCommand.RaiseCanExecuteChanged();
        }
        /// <summary>
        /// Command for opening a website.
        /// </summary>
        public DelegateCommand<string> OpenSupportWebsiteCommand
        {
            get
            {
                mOpenSupportWebsiteCommand = mOpenSupportWebsiteCommand == null ? new DelegateCommand<String>(OpenWebsite, CanAccessWeb) : mOpenSupportWebsiteCommand;
                return mOpenSupportWebsiteCommand;
            }
        }
        private DelegateCommand<string> mOpenSupportWebsiteCommand;
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
        public bool CanAccessWeb(string url)
        {
            try
            {
                using (Ping ping = new Ping()) return isavalible ? ping.Send(new Uri((string)url).Host).Status == IPStatus.Success ? true : false : false;
            }
            catch { return false; }
        }
        private void OpenWebsite(string url)
        {
            new Thread(new System.Threading.ThreadStart(delegate()
                 {
                     System.Diagnostics.Process.Start(url as string);
                 })).Start();
        }
    }
}
