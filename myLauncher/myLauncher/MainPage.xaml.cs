using System;
using Windows.ApplicationModel;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.ApplicationModel.Core;
using Windows.UI;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace myLauncher
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Loaded += PageOnLoaded;
            Window.Current.Activated += Current_Activated;
        }

        private static void PageOnLoaded(object sender, RoutedEventArgs e)
        {
            ApplyTransparencyToTitlebar();
        }

        private static void ApplyTransparencyToTitlebar()
        {
            var formattableTitleBar = ApplicationView.GetForCurrentView().TitleBar;
            formattableTitleBar.ButtonBackgroundColor = Colors.Transparent;
            var coreTitleBar = CoreApplication.GetCurrentView().TitleBar;
            coreTitleBar.ExtendViewIntoTitleBar = true;
        }


        private void Current_Activated(object sender, Windows.UI.Core.WindowActivatedEventArgs e)
        {
            if (e.WindowActivationState == CoreWindowActivationState.Deactivated)
            {
                close();
            }
        }


        private void close()
        {
            //close the Launcher
            ApplicationView.GetForCurrentView().TryConsolidateAsync();
        }



        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Edge DEV");
            close();
        }

        private async void Button2_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Chrome");
            close();
        }

        private async void Button3_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Opera");
            close();
        }



        private async void Button4_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("VS2022");
            close();
        }

        private async void Button5_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("VSCodePreview");
            close();
        }

        private async void Button6_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("VSCodeStable");
            close();
        }




        private async void Button7_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("uTorrent Pro");
            close();
        }

        private async void Button8_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Beyond Compare (Adm)");
            close();
        }

        private async void Button9_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("CCleaner");
            close();
        }

        private async void Button10_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Core Temp");
            close();
        }

        private async void Button11_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("CPU-Z");
            close();
        }

        private async void Button12_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("MusicBee");
            close();
        }

        private async void Button13_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("PDF-XChange Editor");
            close();
        }

        private async void Button14_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Revo Uninstaller Pro");
            close();
        }

        private async void Button15_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("VLC");
            close();
        }

        private async void Button16_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("WinRAR");
            close();
        }







        private async void Button17_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Acronis True Image");
            close();
        }

        private async void Button18_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Bulk File Changer");
            close();
        }

        private async void Button19_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Camtasia Studio");
            close();
        }

        private async void Button20_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Desfragmentar e Otimizar Unidades");
            close();
        }

        private async void Button21_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Driver Booster");
            close();
        }

        private async void Button22_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Duplicate Cleaner Pro");
            close();
        }

        private async void Button23_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("EaseUS Partition Master");
            close();
        }

        private async void Button24_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Font Creator (Portable)");
            close();
        }

        private async void Button25_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("HandBrake");
            close();
        }

        private async void Button26_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("MemoNotes");
            close();
        }

        private async void Button27_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("NVIDIA Painel de Controle");
            close();
        }

        private async void Button28_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("PatchCleaner");
            close();
        }

        private async void Button29_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("PerfectDisk");
            close();
        }

        private async void Button30_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Rainmeter");
            close();
        }

        private async void Button31_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Recuva");
            close();
        }

        private async void Button32_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Rufus");
            close();
        }

        private async void Button33_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Switch Sound File Converter");
            close();
        }

        private async void Button34_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Tornado ThrottleStop");
            close();
        }

        private async void Button35_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("TPM 2.0 error fix");
            close();
        }

        private async void Button36_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("TreeSize");
            close();
        }
    }
}
