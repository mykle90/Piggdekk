﻿#pragma checksum "C:\Users\Tore Myklebust\Documents\Visual Studio 2013\Projects\Parkeringsoblat\Piggdekk\Parkeringsoblat\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "634B476C630A6FC3167F640A2A5CD064"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Parkeringsoblat {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBox txtRegNr;
        
        internal System.Windows.Controls.TextBlock _as;
        
        internal System.Windows.Controls.RadioButton notHeavy;
        
        internal System.Windows.Controls.RadioButton heavy;
        
        internal System.Windows.Controls.Button btnOrder;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Parkeringsoblat;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.txtRegNr = ((System.Windows.Controls.TextBox)(this.FindName("txtRegNr")));
            this._as = ((System.Windows.Controls.TextBlock)(this.FindName("_as")));
            this.notHeavy = ((System.Windows.Controls.RadioButton)(this.FindName("notHeavy")));
            this.heavy = ((System.Windows.Controls.RadioButton)(this.FindName("heavy")));
            this.btnOrder = ((System.Windows.Controls.Button)(this.FindName("btnOrder")));
        }
    }
}

