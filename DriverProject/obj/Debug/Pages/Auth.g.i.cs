﻿#pragma checksum "..\..\..\Pages\Auth.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "679CA368A57B045BD6A289985D740FBA32CE2326623B2225FF823A3E0D09D7A0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using DriverProject.Pages;
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


namespace DriverProject.Pages {
    
    
    /// <summary>
    /// Auth
    /// </summary>
    public partial class Auth : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\Pages\Auth.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbLogin;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Pages\Auth.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border BdLogin;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\Auth.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbPass;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Pages\Auth.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border BdPass;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Pages\Auth.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAuth;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Pages\Auth.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Hyperlink HLReg;
        
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
            System.Uri resourceLocater = new System.Uri("/DriverProject;component/pages/auth.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Auth.xaml"
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
            this.TxbLogin = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\..\Pages\Auth.xaml"
            this.TxbLogin.GotFocus += new System.Windows.RoutedEventHandler(this.TxbLogin_GotFocus);
            
            #line default
            #line hidden
            
            #line 22 "..\..\..\Pages\Auth.xaml"
            this.TxbLogin.LostFocus += new System.Windows.RoutedEventHandler(this.TxbLogin_LostFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BdLogin = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            this.TxbPass = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\..\Pages\Auth.xaml"
            this.TxbPass.GotFocus += new System.Windows.RoutedEventHandler(this.TxbPass_GotFocus);
            
            #line default
            #line hidden
            
            #line 28 "..\..\..\Pages\Auth.xaml"
            this.TxbPass.LostFocus += new System.Windows.RoutedEventHandler(this.TxbPass_LostFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BdPass = ((System.Windows.Controls.Border)(target));
            return;
            case 5:
            this.BtnAuth = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\Pages\Auth.xaml"
            this.BtnAuth.Click += new System.Windows.RoutedEventHandler(this.BtnAuth_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.HLReg = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 39 "..\..\..\Pages\Auth.xaml"
            this.HLReg.Click += new System.Windows.RoutedEventHandler(this.HLReg_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

