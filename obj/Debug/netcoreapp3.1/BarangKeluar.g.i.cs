﻿#pragma checksum "..\..\..\BarangKeluar.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0D59F5C94D903D9BE95F6401245820D04A3DCD5B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using inventory;


namespace inventory {
    
    
    /// <summary>
    /// BarangKeluar
    /// </summary>
    public partial class BarangKeluar : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\BarangKeluar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox KodeKeluar;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\BarangKeluar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Nama;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\BarangKeluar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Tanggal;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\BarangKeluar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Jumlah;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\BarangKeluar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BarangKeluar1;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/inventory;V1.0.0.0;component/barangkeluar.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\BarangKeluar.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.KodeKeluar = ((System.Windows.Controls.TextBox)(target));
            
            #line 10 "..\..\..\BarangKeluar.xaml"
            this.KodeKeluar.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.KodeKeluar_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Nama = ((System.Windows.Controls.TextBox)(target));
            
            #line 11 "..\..\..\BarangKeluar.xaml"
            this.Nama.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Nama_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Tanggal = ((System.Windows.Controls.TextBox)(target));
            
            #line 12 "..\..\..\BarangKeluar.xaml"
            this.Tanggal.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Tanggal_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Jumlah = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\..\BarangKeluar.xaml"
            this.Jumlah.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Jumlah_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BarangKeluar1 = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\BarangKeluar.xaml"
            this.BarangKeluar1.Click += new System.Windows.RoutedEventHandler(this.OnClickInput);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

