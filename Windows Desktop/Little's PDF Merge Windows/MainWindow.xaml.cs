﻿               /*++++++ooo++-                                                                                                                             |
             :++-```````````.+y/                                                                                                                          |
           .ys``````    ```````:s+`                                                                                                                       |
          .mo``.-``      `oyo/``.-ss-                                                                                                                     |
         .h+`.dh+y       `ydhN.````.+s/                                                                                                                   |
       `+h-```oss+        `-:.```````.:so`                                                                                                                |
      +d+.````````   `.`     ``````````.-+/-                                                                                                              |
    `yh-````````    oooo/     ````.:``````.:o/`                                                                                                           |
   .dh.`````````    .+:.`      ```oyy-``````.+y+`                                                                                                         |
  -my.````os.```  -/-h+:o.     `.+``/d+```````.oy.                                                                                                        |
 `ds.```.ysod/```  ./y+-`    ``-:`   .hy:```````.d                                 ...                                           `.......`                |
-do````.h+  -+y/.```-+-`````.:od      `+d+.``````N     .:+++++++++/                ://              `-/+++++++++.               -ooo+++++.   /++          |
do````.s:     shhs+/:::::/+syyyd        ./s+:..:od    .os+---------  `..`     ...  ...   ``.......  +so:--------`   ``......`   /ss.-----`...oso....      |
m-```:y.      oyyyyhyyyhhhhyyyyh+         `.//+//.    -ss:````````   -ss-     os+  /ss` -+ooooooo+` oso.```````    -+oooooooo/  /ss:ooooo.+ooossooo+`     |
d...+o` :-::::+ooooooooooosssssss///////`              :+o++++++oo/` -ss-     os+  /ss` oso```````  ./o+++++++o+-  oso`````/ss. /ss`````` ```oso````      |
/+++-   ////////////+++++++++++++ooooooo.               ````````.os+ -ss:     os+  /ss` os+           ````````/ss. os+     :ss. /ss`         oso          |
        ////////////+++++++++++++ooooooo.             `::::::::::os/ `+so:::::os+  /ss` +so:::::::` -:::::::::+so` +so:::::+so` /ss`         oso          |
        //:://////-++//+///+++++//++/+oo. `````       .++++++++++/-   `-/+++++++:  :++  `:++++++++` /++++++++++:`  `:+++++++/.  :++          /++          |
        +/-:/-/://-+/-/+::/+:+:+./+/-+oo.``````                                                                                                           |
        +/:::::-//./+-:+//-+:/:o:ooo:/oo-`````                                                                                                            |
        +++++++++++++++++++++oooooooooos-``                                                                                                               |
        +++++++++++++++++++++oooooooooos-                                                                                                                 |
        +++++++++++++++++++ooooooooooooo.                                                                                                                 |  
        /+++///++++++++++++++++++++++oo+`                                                                                                                 |
         .--`````````.s//o```````````.`                                                                                                                   |
         .-.         od  N-          .:                                                                                                                   |
        ./`          oy  N/          .N                                                                                                                   |
        oh           +y  ds         .d/                                                                                                                   |
        .my`         os  .m:      -sN/                                                                                                                    |
         `+d/       -m+   `sooo+oo/.                                                                                                                      |
            :ooossooy:                                                                                                                                    | 
__________________________________________________________________________________________________________________________________________________________| 

 *This file is a modified file from a open source project.
 *This file is part of Little's PDF Merge.
 -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
 | Contact Infomation                 | Program Infomation                              | Tools Used                                                    | Libs Used                        | Software Requirements    | Hardware Requirements | Codes used             |  
 |  *Email : mailto:suiciwd@gmail.com |  *Name : SuicSoft LittleSoft Little's PDF Merge |  *Microsoft Visual Studio  *Microsoft Blend for Visual Studio |  *iTextSharp (iText .NET Port)   |  *Windows Vista or newer |  *1Ghz or faster CPU  |  *http://goo.gl/3r5oj2 |
 |  *Web : http://www.suicsoft.com    |  *Version : 2.2.1                               |  *Microsoft SDKs           *Microsoft .NET Framework 4.5      |                                  |  *.NET Framework 4.5.1   |  *512mb RAM           |  *http://goo.gl/anfIDg |
 -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
 License.txt is included with the Visual Studio Project ,installer and portable.

 *SUMMARY - THE SHORT EULA WHICH SAYS EVERYTHING:
 *Thanks for using SuicSoft Software! All SuicSoft Software are FREE and don't have malware! This is the friendly & short license, You can read the full license below
 *You can share our software by always linking directly to www.suicsoft.com, no - you can't distrubute our software - we're the ones who are distrubuting it, don't go and host our software on those websites with malware.
 *If you don't listen to us and continue to use SuicSoft Software while doing one of those things, you must remove all SuicSoft Software from your machine(s)

 *DISCLAIMER:
 *THE APPLICATION AND ANY RELATED DOCUMENTATION IS PROVIDED "AS IS" WITHOUT ANY WARRANTIES. AND THAT THE VENDOR DOES NOT WARRANT THAT THIS SUICSOFT SOFTWARE WILL RUN UNINTERRUPTED OR ERROR FREE NOR THAT THIS SUICSOFT SOFTWARE WILL OPERATE WITH HARDWARE AND/OR SOFTWARE NOT PROVIDED BY THE VENDOR, EITHER EXPRESS OR IMPLIED, INCLUDING, BUT NOT LIMITED TO, IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR PURPOSE. THE ENTIRE RISK ARISING OUT OF USE OR PERFORMANCE OF THE SOFTWARE REMAINS WITH YOU
 ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
 *THE FULL EULA:
 *This SuicSoft Software is released as freeware. 
 *You are NOT allowed to: 
 *Distribute this program through floppy disks, CD-ROMs, Internet Services, or any other way
 *Link SuicSoft Software download links to a website which is not www.suicsoft.com
 *Link SuicSoft Software to websites which host malware, adware or spyware
|---------------------------------------------------------------------------------------------------------|
|*If you AGREE and do one of those bad things, you must remove any SuicSoft Software from your machine(s) |
|---------------------------------------------------------------------------------------------------------|
 *DISCLAIMER:
 *THE APPLICATION AND ANY RELATED DOCUMENTATION IS PROVIDED "AS IS" WITHOUT ANY WARRANTIES. AND THAT THE VENDOR DOES NOT WARRANT THAT THIS SUICSOFT SOFTWARE WILL RUN UNINTERRUPTED OR ERROR FREE NOR THAT THIS SUICSOFT SOFTWARE WILL OPERATE WITH HARDWARE AND/OR SOFTWARE NOT PROVIDED BY THE VENDOR, EITHER EXPRESS OR IMPLIED, INCLUDING, BUT NOT LIMITED TO, IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR PURPOSE. THE ENTIRE RISK ARISING OUT OF USE OR PERFORMANCE OF THE SOFTWARE REMAINS WITH YOU
 */
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Input;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using SuicSoft.LittleSoft.LittlesPDFMerge.Core;
using iTextSharp.text.pdf;
using System.Threading;
using System.Reflection;
using System.Security;
namespace SuicSoft.LittleSoft.LittlesPDFMerge.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    [CLSCompliant(false)]
    partial class MainWindow : MetroWindow
    {
        #region Fullscreen Window
         private static Button btn = new Button() { Content = new System.Windows.Shapes.Path() { Fill = Brushes.White, Data = System.Windows.Media.Geometry.Parse("M5,5H10V7H7V10H5V5M14,5H19V10H17V7H14V5M17,14H19V19H14V17H17V14M10,17V19H5V14H7V17H10Z") } };

        void btn_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)GetValue(IsFullscreenProperty) == false)  
                SetValue(IsFullscreenProperty, true);
            else
                SetValue(IsFullscreenProperty, false);
        }

        public static bool GetIsFullscreen(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsFullscreenProperty);
        }

        public static void SetIsFullscreen(DependencyObject obj, bool value)
        {
            obj.SetValue(IsFullscreenProperty, value);
        }
        static WindowStyle _WindowStyle;
        static WindowState _WindowState;
        public static readonly DependencyProperty IsFullscreenProperty =
            DependencyProperty.RegisterAttached("Fullscreen",
            typeof(bool), typeof(MainWindow), new PropertyMetadata
            (false, new PropertyChangedCallback(IsFullscreenChangedChanged)));

        private static void IsFullscreenChangedChanged
        (DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if ((bool)e.NewValue == true)
            {
                ((System.Windows.Shapes.Path)btn.Content).Data = Geometry.Parse("M14,14H19V16H16V19H14V14M5,14H10V19H8V16H5V14M8,5H10V10H5V8H8V5M19,8V10H14V5H16V8H19Z");
                d.SetValue(IgnoreTaskbarOnMaximizeProperty, true);
                d.SetValue(ShowTitleBarProperty, false);
                _WindowStyle = (WindowStyle)d.GetValue(Window.WindowStyleProperty);
                _WindowState = (WindowState)d.GetValue(Window.WindowStateProperty);
                d.SetValue(Window.WindowStyleProperty, WindowStyle.None);
                d.SetValue(Window.WindowStateProperty, WindowState.Maximized);
            }
            else
            {
                ((System.Windows.Shapes.Path)btn.Content).Data = Geometry.Parse("M5,5H10V7H7V10H5V5M14,5H19V10H17V7H14V5M17,14H19V19H14V17H17V14M10,17V19H5V14H7V17H10Z");
                d.SetValue(ShowTitleBarProperty, true);
                d.SetValue(IgnoreTaskbarOnMaximizeProperty, false);
                d.SetValue(Window.WindowStyleProperty, _WindowStyle);
                d.SetValue(Window.WindowStateProperty, _WindowState);

            }
        }
        void StateChange(object sender, System.EventArgs e)
        {
            if ((bool)GetValue(IsFullscreenProperty) == true & WindowState == System.Windows.WindowState.Normal)
                SetValue(IsFullscreenProperty, false);
        }
#endregion

        public MainWindow()
        {
            StateChanged += StateChange;
            btn.Click += btn_Click;
            var commands = new WindowCommands();
            commands.Items.Add(btn);
            RightWindowCommands = commands;

            PdfReader.unethicalreading = true;
            // Create new stopwatch
            Stopwatch stopwatch = new Stopwatch();

            // Begin timing
            stopwatch.Start();
            InitializeComponent();
            // Stop timing
            stopwatch.Stop();
            Debug.WriteLine("Time to draw controls: {0}", stopwatch.Elapsed);

            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            if (HasTouchInput())
                //Make things bigger.
                split.Height = 30;
            // Stop timing
            stopwatch2.Stop();

            Debug.WriteLine("Time to run init code: {0}", stopwatch2.Elapsed);
        }
        private static bool IsDialogOpen;

        #region Constants
        private const int WM_DWMCOLORIZATIONCOLORCHANGED = 800;
        #endregion

        #region Overrides
        protected override void OnSourceInitialized(EventArgs e)
        {

            base.OnSourceInitialized(e);
            HwndSource source = PresentationSource.FromVisual(this) as HwndSource;
            source.AddHook(WndProc);
        }
        #endregion

        #region Window Message Handler (WndProc)
        private IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam,ref bool handled)
        {

            // Handle messages...
            if (msg == WM_DWMCOLORIZATIONCOLORCHANGED)
            {

                   //Read theme settings.
                    System.Drawing.Color clr = System.Drawing.Color.FromArgb((Int32)Registry.GetValue("HKEY_CURRENT_USER\\" + "Software\\Microsoft\\Windows\\DWM", "ColorizationColor", "00000000"));
                    var colors = new MaterialPallete(Color.FromArgb(clr.A, clr.R, clr.G, clr.B));
                    Resources["AccentColor"] = new SolidColorBrush(colors.AccentColor);
                    Resources["PrimaryColor"] = new SolidColorBrush(colors.PrimaryColor);
                    Resources["LightPrimaryColor"] = new SolidColorBrush(colors.LightPrimaryColor);
                    Resources["WindowTitleColorBrush"] = new SolidColorBrush(colors.DarkPrimaryColor);
            }

            return IntPtr.Zero;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Checks if the device has a touch screen.
        /// </summary>
        /// <returns>True if the device uses a touch screen</returns>
        private static bool HasTouchInput()
        {
            return Tablet.TabletDevices.OfType<TabletDevice>().Any(t => t.Type == TabletDeviceType.Touch);
        }
        /// <summary>
        /// Updates the UI (disable and enable controls).
        /// </summary>
        private void UpdateUI()
        {
            if (FilesBox.Items.Count == 1)
            {
                bm.IsEnabled = true;
                rb.IsEnabled = true;
                ub.IsEnabled = false;
                db.IsEnabled = false;

            }
            else if (FilesBox.Items.Count == 0)
            {
                bm.IsEnabled = false;
                rb.IsEnabled = false;
                ub.IsEnabled = false;
                db.IsEnabled = false;

            }
            else
            {
                ub.IsEnabled = true;
                db.IsEnabled = true;
                bm.IsEnabled = true;
                rb.IsEnabled = true;
            }
        }
        private async void ShowPasswordBox(string file)
        {
            //Show the user the password dialog.
            string result = await this.ShowInputAsync("PDF not allowed", "Enter the password for " + Path.GetFileName(file) + " to open the file. Enter the password 'hack' to crack the password", new LoginDialogSettings { UsernameWatermark = "Password", PasswordWatermark = "Enter Password Again", AffirmativeButtonText = "Ok", ColorScheme = MetroDialogColorScheme.Accented });
            if (!String.IsNullOrWhiteSpace(result))
            {
                try
                {
                    //Use iTextSharp.text.pdf.PdfReader to open the pdf.
                    using (PdfReader reader = new PdfReader(file, System.Text.Encoding.Default.GetBytes(result)))
                    { }
                    //Check if passowrd is correct
                }
                catch{
                        //If it isn't. Ask for the password again and return
                        ShowPasswordBox(file);
                        return;
                }
                AddFileToListBox(file,result.ToSecureString());
                result = String.Empty;
                GC.Collect();
            }
        }
        public async Task<MessageDialogResult> DonNotShowAgainDialog(string title, string message, string id)
        {
            const string regpath = "Software\\SuicSoft\\LittlePDFMerge"; //Example : Software\\Company\ProductName.
            //Open registry key for editing and reading.
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(regpath, true))
            {
                //Check if do not show this again has been clicked before
                if ((int)key.GetValue(id, 0) == 0)
                {
                    MessageDialogResult result = await this.ShowMessageAsync(title, message, MessageDialogStyle.AffirmativeAndNegativeAndSingleAuxiliary, new MetroDialogSettings { FirstAuxiliaryButtonText = "Don't show again", ColorScheme = MetroDialogColorScheme.Accented });
                    if (result == MessageDialogResult.FirstAuxiliary)
                    {
                        //Don't show again
                        key.SetValue(id, 1);
                        //Return ok button
                        return MessageDialogResult.Affirmative;
                    }
                    return result;
                }
            //Return ok button
            return MessageDialogResult.Affirmative;
            }
        }
        private async void AddInputFile(string file)
        {
            switch (Combiner.TestSourceFile(File.ReadAllBytes(file)))
            {
                //File is corrupt pdf.
                case Combiner.SourceTestResult.Unreadable:
                    //Tell the user the pdf is corrupt.
                    Dispatcher.Invoke(new Action(() => this.ShowMessageAsync("The file " + Path.GetFileName(file) + " could not be opened as a PDF or image", "Some thing went wrong when opening " + Path.GetFileName(file))));
                    break;
                //File is a protected pdf.
                case Combiner.SourceTestResult.Protected:
                    PdfReader.unethicalreading = false;
                    try
                    {
                        using (PdfReader reader = new PdfReader(file))
                        {
                            if (!reader.IsOpenedWithFullPermissions)
                                Dispatcher.Invoke(new Action(async () =>
                                {
                                    if (MessageDialogResult.Affirmative == await this.DonNotShowAgainDialog("The file " + " is a protected file", "Opening protected files may not be allowed by the pdf author", "Lawyer"))
                                        //That dog wants to open protected files.
                                        PdfReader.unethicalreading = true;
                                    else
                                        return;
                                }));
                        }
                    }
                    catch
                    {
                        Dispatcher.Invoke(new Action(() => ShowPasswordBox(file)));
                        return;
                    }
                       
                    
                    break;
                //File is a valid pdf.
                case Combiner.SourceTestResult.Ok:
                    //Add the pdf to the ListBox.
                    AddFileToListBox(file, null);
                    break;
                //File is a image (maybe not valid!).
                case Combiner.SourceTestResult.Image:
                    break;
                //File is unknown
                case Combiner.SourceTestResult.Unknown:
                    await Dispatcher.BeginInvoke(new Action(() => this.ShowMessageAsync("Invalid format", "The file you selected is not a supported format. More supported formats coming soon.")));
                    break;

            }
            
        }
        private void AddFileToListBox(string file, SecureString password)
        {
            
            #if CSharp6
            password?.MakeReadOnly();
            #else
            if (password != null)
            {
                password.MakeReadOnly();
            }
            #endif
            Dispatcher.BeginInvoke(new Action(() => FilesBox.Items.Add(new ListBoxItem { Content = file, Tag = password })));
            Dispatcher.BeginInvoke(new Action(() => UpdateUI()));
        }
        #endregion

        /// <summary>
        /// When the user clicks add file
        /// </summary>
        private void AddFilebtn_Click(object sender, RoutedEventArgs e)
        {
            //To get the button click animation to show. We need to open the Microsoft.Win32.OpenFileDialog in a new thread.
            new System.Threading.Thread(new System.Threading.ThreadStart(delegate(){
                //Tell the dialog is open.
                IsDialogOpen = true;
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.DefaultExt = ".pdf";
                openFileDialog.Filter = "Portable Document Format (*.pdf)|*.pdf|Text files (*.txt)|*.txt";
                openFileDialog.Multiselect = true;
                if (openFileDialog.ShowDialog() == true){
                    foreach (var file in openFileDialog.FileNames)
                        AddInputFile(file);
                }//Tell the dialog closed.
                IsDialogOpen = false;
            })) { Name = "Open file dialog thread." }.Start();
            
        }
        /// <summary>
        /// Moves the selected item up or down.
        /// </summary>
        /// <param name="sender">db for down and ub for up.</param>
        private void MI(object sender, RoutedEventArgs e)
        {
            //The old index
            int indexold = FilesBox.SelectedIndex;
            //The selected item
            object dataItem = FilesBox.SelectedItem;


            int index = FilesBox.SelectedIndex;

            if (sender == ub) index--;
            if (sender == db) index++;

            FilesBox.Items.Remove(dataItem);
            FilesBox.Items.Insert(index, dataItem);
            FilesBox.SelectedIndex = 0;
            FilesBox.SelectedIndex = index;
          
        }

        private async void btnmerge_Click(object sender, RoutedEventArgs e)
        {
            bool p = false;
            foreach (ListBoxItem item in FilesBox.Items)
            {
                if (item.Tag != null)
                {
                    p = true;
                    break;
                }
            }
            //if (p)
            //{
            //    if (MessageDialogResult.Affirmative == await this.ShowMessageAsync("Password protected pdf", "One or more of the pdfs you are merging are password protected. Do you want to protect the merged pdf with a pasword?", MessageDialogStyle.AffirmativeAndNegative, new MetroDialogSettings() { AffirmativeButtonText = "Yes", NegativeButtonText = "No" })
            //    {

            //    }


            //}
            //To get the button click animation to show. We need to open the Microsoft.Win32.SaveFileDialog in a new thread.
            new System.Threading.Thread(new System.Threading.ThreadStart(delegate()
            {

                int count = 0;
                string CurrentItem = null;
                Dispatcher.Invoke(new Action(() =>
                    {
                        count = FilesBox.Items.Count;
                        CurrentItem = ((ListBoxItem)FilesBox.Items[0]).Content.ToString();
                    }));
                SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog() { Title = count > 1 ? String.Format("Merging {0} File(s)", count) : String.Format("Converting {0}", CurrentItem) };
                if (saveFileDialog.ShowDialog() == true)
                    using (Combiner comb = new Combiner())
                    {
                        comb.d = saveFileDialog.FileName;
                        string n = String.Empty;
                        Parallel.For(0,count,i=>
                        {
                            SecureString tag = null;
                            Dispatcher.Invoke(new Action(() =>
                                {
                                    var item = ((ListBoxItem)FilesBox.Items[i]);
                                    n = item.Content.ToString();
                                    tag = (SecureString)item.Tag;
                                }));
                            comb.AddFile(File.ReadAllBytes(n), Combiner.ProtectPassword((SecureString)tag));
                            tag.Dispose();
                        });
                    }
                if (!String.IsNullOrEmpty(saveFileDialog.FileName))
                    System.Diagnostics.Process.Start(saveFileDialog.FileName);
            })).Start();
        }
        
        private void Border_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (TitleText.ActualHeight < 70)
            {
                vb.Stretch = Stretch.None;
                ButtonsPanel.VerticalAlignment = System.Windows.VerticalAlignment.Center;
                var anim = new ThicknessAnimation { To = new Thickness(55, 0, 0, 0), Duration = new Duration(new TimeSpan(0, 0, 0, 0, 100)) };
                ButtonsPanel.Margin = new Thickness(55, 0, 0, 0);
            }
            if (TitleText.ActualHeight > 70)
            {
                ButtonsPanel.VerticalAlignment = System.Windows.VerticalAlignment.Bottom;
                ButtonsPanel.Margin = new Thickness(0, 0, 0, 0);
            }
            if ((TitleText.ActualHeight < 84))
            {
                var anim = new DoubleAnimation
                {
                    To = 0,
                    Duration = new TimeSpan(0, 0, 0, 0, 150),
                };
                vb.Stretch = Stretch.None;
                TitleLabel.BeginAnimation(UIElement.OpacityProperty, anim);

            }

            else
            {
                vb.Stretch = Stretch.Uniform;
                var anim = new DoubleAnimation
                {
                    To = 1,
                    Duration = new TimeSpan(0, 0, 0, 0, 150),
                };
                TitleLabel.BeginAnimation(UIElement.OpacityProperty, anim);
            }
        }

        private void MetroWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (IsDialogOpen == true) e.Cancel = true;
        }

        private void TitleLabel_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.LeftShift) | Keyboard.IsKeyDown(Key.RightShift))
            {
                TitleLabel.Content = "Little's PDF Flags";
            }
        }
        bool loadico;
        private void metroWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (e.NewSize.Width < 320)
            {
                loadico = true;
                Icon = null;
            }
            else if (e.NewSize.Width > 320 & loadico)
                Icon = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/LPM.Windows;component/Fonts-Icons/Icon.ico", UriKind.Absolute));
        }
    }
}

