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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BinaryToDecimal
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

        private int BinaryToDecimal()
        {
            int b0 = Convert.ToInt16(bit0.Text);
            int b1 = Convert.ToInt16(bit1.Text);
            int b2 = Convert.ToInt16(bit2.Text);
            int b3 = Convert.ToInt16(bit3.Text);
            int b4 = Convert.ToInt16(bit4.Text);
            int b5 = Convert.ToInt16(bit5.Text);
            int b6 = Convert.ToInt16(bit6.Text);
            int b7 = Convert.ToInt16(bit7.Text);

            int decimalResult = ((b0 * 1) + (b1 * 2) + (b2 * 4) + (b3 * 8)
                + (b4 * 16) + (b5 * 32) + (b6 * 64) + (b7 * 128));

            resultText.Text = decimalResult.ToString();
            return decimalResult;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BinaryToDecimal();
        }
    }
}
