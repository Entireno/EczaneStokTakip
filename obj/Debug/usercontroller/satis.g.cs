﻿#pragma checksum "..\..\..\usercontroller\satis.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "095B2C267F6A274C3C172CC8F1FC4CF6445C0AF9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using IlacStok.usercontroller;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace IlacStok.usercontroller {
    
    
    /// <summary>
    /// satis
    /// </summary>
    public partial class satis : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\usercontroller\satis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmb_ilac;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\usercontroller\satis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_fiyat;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\usercontroller\satis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_adet;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\usercontroller\satis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_tc;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\usercontroller\satis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_toplam;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\usercontroller\satis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_satis;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\usercontroller\satis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_message;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/IlacStok;component/usercontroller/satis.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\usercontroller\satis.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\usercontroller\satis.xaml"
            ((IlacStok.usercontroller.satis)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cmb_ilac = ((System.Windows.Controls.ComboBox)(target));
            
            #line 13 "..\..\..\usercontroller\satis.xaml"
            this.cmb_ilac.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmb_ilac_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lbl_fiyat = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.txt_adet = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\..\usercontroller\satis.xaml"
            this.txt_adet.KeyDown += new System.Windows.Input.KeyEventHandler(this.txt_adet_KeyDown);
            
            #line default
            #line hidden
            
            #line 22 "..\..\..\usercontroller\satis.xaml"
            this.txt_adet.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txt_adet_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txt_tc = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\..\usercontroller\satis.xaml"
            this.txt_tc.KeyDown += new System.Windows.Input.KeyEventHandler(this.txt_tc_KeyDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lbl_toplam = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.btn_satis = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\usercontroller\satis.xaml"
            this.btn_satis.Click += new System.Windows.RoutedEventHandler(this.btn_satis_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lbl_message = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
