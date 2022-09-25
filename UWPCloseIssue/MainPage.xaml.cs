using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core.Preview;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPCloseIssue
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            SystemNavigationManagerPreview.GetForCurrentView().CloseRequested += MainPage_CloseRequested;
            Window.Current.Activate();
        }

        private void MainPage_CloseRequested(object sender, SystemNavigationCloseRequestedPreviewEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int num = 100;
            int[] x = new int[num];
            x[0] = 1;
            for (int i = 1; i < num; i++)
            {
                x[i] = x[i - 1] + 2;
            }

            
            List<int> sum = new List<int>();
            for (int a=0; a < num-2; a++)
            {
                for (int b=1; b < num-1; b++)
                {
                    for (int c=2; c < num; c++)
                    {
                        int temp = x[a] + x[b] + x[c];
                        if (sum.Contains(temp) == false)
                            sum.Add(temp);
                    }
                }
            }
            result.Text = sum.Count.ToString();
        }
    }
}
