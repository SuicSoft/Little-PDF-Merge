﻿/* SuicSoft 2014-2015
 * Contact : mailto:suiciwd@gmail.com
 * Web : http://suicsoft.com | http://suicsoft.github.io
 * Github : http://github.com/suicsoft/Little-PDF-Merge
 
 * Read more in LICENSE.md
 */

/* File Description
 * The view model used for the palette selector.
 */

//For palette.
using MaterialDesignColors;
//For palette
using MaterialDesignThemes.Wpf;
//For the arrays
using System.Collections.Generic;
//For the commands
using System.Windows.Input;
//For those linq stuff.
using System.Linq;
//For disk I/O.
using System.IO;
//WPF.
using System.Windows;
//Registry and dialogs.
using Microsoft.Win32;
using Microsoft.Practices.Prism.Commands;
using System;
using System.Windows.Media.Animation;
using System.Windows.Controls;
using System.Threading;
using System.Windows.Media;
namespace SuicSoft.LittlesPDFMerge.Windows
{
    /// <summary>
    /// The view model for the palette selector.
    /// </summary>
    public class PaletteSelectorViewModel
    {
        #region Constructor
        /// <summary>
        /// Initailizes the palette selector view model.
        /// </summary>
        public PaletteSelectorViewModel()
        {
            //Set variables
            Swatches = new SwatchesProvider().Swatches.ToList();
            ResetCommand = new DelegateCommand(Reset);
            ApplyPrimaryCommand = new DelegateCommand<Swatch>(ApplyPrimary);
            ApplyAccentCommand = new DelegateCommand<Swatch>(ApplyAccent);
            SaveCommand = new DelegateCommand(Save);
        }
        #endregion

        #region Variables
        /// <summary>
        /// The index of the primary color
        /// </summary>
        private static int PrimaryIndex;
        /// <summary>
        /// The index if the accent color
        /// </summary>
        private static int AccentIndex;
        /// <summary>
        /// A list of all the Material Design swatches
        /// </summary>
        public static List<Swatch> Swatches { get; set; }
        #endregion

        #region Commands
        /// <summary>
        /// Save the color settings
        /// </summary>
        public ICommand SaveCommand { get; set; }
        /// <summary>
        /// Reset the color settings
        /// </summary>
        public ICommand ResetCommand { get; set; }
        /// <summary>
        /// Sets the accent color.
        /// </summary>
        public ICommand ApplyAccentCommand { get; set; }
        /// <summary>
        /// Sets the primary color
        /// </summary>
        public ICommand ApplyPrimaryCommand { get; set; }
        #endregion

        #region Methods
          #region Save / Reset
        /// <summary>
        /// Save the color settings
        /// </summary>
        private static void Save()
        {
            //Save accent.
            Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\SuicSoft\\LittlePDFMerge", "Accent", AccentIndex);
            //Save primary.
            Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\SuicSoft\\LittlePDFMerge", "Primary", PrimaryIndex);
        }
        private static bool _ischecked;
        public static bool IsChecked
        {
            get { return _ischecked; }
            set
            {
                new PaletteHelper().SetLightDark(value);
                _ischecked = value;
            }
        }
        /// <summary>
        /// Reset the color settings
        /// </summary>
        private static void Reset()
        {
            //Replace primary with default.
            ApplyPrimary(Swatches[1]);
            //Replace accent with default.
            ApplyAccent(Swatches[9]);
            //Write the defaults to the registry.
            Save();
        }
        #endregion

          #region Apply Colors
        /// <summary>
        /// Sets the primary color.
        /// </summary>
        /// <param name="swatch">The primary color to set.</param>
        private static void ApplyPrimary(Swatch swatch)
        {
            EventHandler h = (sender, e) =>
            {
                ((ColorZone)((VisualBrush)((MainWindow)Application.Current.MainWindow).Ink.Fill).Visual).Mode = ColorZoneMode.Accent;
                //Add some ink.
                Panel.SetZIndex(((MainWindow)Application.Current.MainWindow).Ink, 0);
                Grid.SetRow(((MainWindow)Application.Current.MainWindow).Ink, 1);
            };
            //Multithreading to get a smooth ink effect
            ThreadPool.QueueUserWorkItem(delegate
            {
                //Replace the color.
                new PaletteHelper().ReplacePrimaryColor(swatch);
                //Set the color index
                PrimaryIndex = Swatches.FindIndex(x => x == swatch);
                //Start the animation
                Application.Current.Dispatcher.Invoke(new Action(() =>
                {
                    ((ColorZone)((VisualBrush)((MainWindow)Application.Current.MainWindow).Ink.Fill).Visual).Mode  = ColorZoneMode.PrimaryDark;
                    Panel.SetZIndex(((MainWindow)Application.Current.MainWindow).Ink, 1);
                    Grid.SetRow(((MainWindow)Application.Current.MainWindow).Ink, 0);
                    ((Storyboard)((MainWindow)Application.Current.MainWindow).Resources["InkSplash"]).Completed += h;
                    ((Storyboard)((MainWindow)Application.Current.MainWindow).Resources["InkSplash"]).Begin();
                }));
                
            }, null);
        }
        /// <summary>
        /// Sets the accent color.
        /// </summary>
        /// <param name="swatch">The accent color to set.</param>
        private static void ApplyAccent(Swatch swatch)
        {
            ThreadPool.QueueUserWorkItem(delegate
            {
                //Replace the color.
                new PaletteHelper().ReplaceAccentColor(swatch);
                //Set the color index
                Application.Current.Dispatcher.Invoke(new Action(() =>AccentIndex = Swatches.FindIndex(x => x == swatch)));
            }, null);
            
        }
        #endregion
        #endregion
    }
}
