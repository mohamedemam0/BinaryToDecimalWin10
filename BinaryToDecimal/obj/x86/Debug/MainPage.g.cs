﻿#pragma checksum "c:\users\mohammed\documents\visual studio 2015\Projects\BinaryToDecimal\BinaryToDecimal\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "294FD9A442FC7640CEB1A2B35D62F690"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BinaryToDecimal
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.resultText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 2:
                {
                    global::Windows.UI.Xaml.Controls.Button element2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 23 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element2).Click += this.Button_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.bit0 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4:
                {
                    this.bit1 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5:
                {
                    this.bit2 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6:
                {
                    this.bit3 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7:
                {
                    this.bit4 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8:
                {
                    this.bit5 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9:
                {
                    this.bit6 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 10:
                {
                    this.bit7 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
