﻿#pragma checksum "..\..\..\Views\frmPrincipal.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ADA14ADB516EAB31235139A16C64437FD8A67C80"
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
using WPFExemplo.Views;


namespace WPFExemplo.Views {
    
    
    /// <summary>
    /// frmPrincipal
    /// </summary>
    public partial class frmPrincipal : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Views\frmPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNumero1;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Views\frmPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNumero2;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Views\frmPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSomar;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Views\frmPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblResultado;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Views\frmPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAbrirJanela;
        
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
            System.Uri resourceLocater = new System.Uri("/WPFExemplo;component/views/frmprincipal.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\frmPrincipal.xaml"
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
            this.txtNumero1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtNumero2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.btnSomar = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\Views\frmPrincipal.xaml"
            this.btnSomar.Click += new System.Windows.RoutedEventHandler(this.BtnSomar_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lblResultado = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.btnAbrirJanela = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\Views\frmPrincipal.xaml"
            this.btnAbrirJanela.Click += new System.Windows.RoutedEventHandler(this.BtnAbrirJanela_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

