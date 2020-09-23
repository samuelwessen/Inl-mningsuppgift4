using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.Azure.Devices.Client;
using SharedLibraries.Services;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace inlämningsuppgift4uwp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        private static readonly DeviceClient deviceClient = DeviceClient.CreateFromConnectionString("HostName=ec-win20-samuelw-iothub.azure-devices.net;DeviceId=inlamningsuppgift4UWP_Iot;SharedAccessKey=F/Df2VzzrF00N6pFEGLqDj/wplLDaCujvOoH9Wn7oj8=", TransportType.Mqtt);


        private void btnSendMessage_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DeviceService.SendMessageAsync(deviceClient).GetAwaiter();
            }
            catch{  }

            

        }
    }
}
