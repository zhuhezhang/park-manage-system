﻿#pragma checksum "..\..\AdCarLeaveInfoWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B321D189F459D258B7A26F0E74DCEA2A5BBE3DAB61B6C237C416E89E9A6D63DD"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Administrator;
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


namespace Administrator {
    
    
    /// <summary>
    /// AdCarLeaveInfoWindow
    /// </summary>
    public partial class AdCarLeaveInfoWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\AdCarLeaveInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ModifyButton;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\AdCarLeaveInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteButton;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\AdCarLeaveInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button QueryButton;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\AdCarLeaveInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox QueryComboBox;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\AdCarLeaveInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox QueryTextBox;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\AdCarLeaveInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid CarLeaveInfoDataGrid;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\AdCarLeaveInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExitButton;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\AdCarLeaveInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CarEnterInfoButton;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\AdCarLeaveInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UserInfoButton;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\AdCarLeaveInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AdInfoButton;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\AdCarLeaveInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ParkInfoButton;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\AdCarLeaveInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Administrator;component/adcarleaveinfowindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AdCarLeaveInfoWindow.xaml"
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
            this.ModifyButton = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\AdCarLeaveInfoWindow.xaml"
            this.ModifyButton.Click += new System.Windows.RoutedEventHandler(this.ModifyButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DeleteButton = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\AdCarLeaveInfoWindow.xaml"
            this.DeleteButton.Click += new System.Windows.RoutedEventHandler(this.DeleteButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.QueryButton = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\AdCarLeaveInfoWindow.xaml"
            this.QueryButton.Click += new System.Windows.RoutedEventHandler(this.QueryButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.QueryComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.QueryTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.CarLeaveInfoDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.ExitButton = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\AdCarLeaveInfoWindow.xaml"
            this.ExitButton.Click += new System.Windows.RoutedEventHandler(this.ExitButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.CarEnterInfoButton = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\AdCarLeaveInfoWindow.xaml"
            this.CarEnterInfoButton.Click += new System.Windows.RoutedEventHandler(this.CarEnterInfoButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.UserInfoButton = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\AdCarLeaveInfoWindow.xaml"
            this.UserInfoButton.Click += new System.Windows.RoutedEventHandler(this.UserInfoButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.AdInfoButton = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\AdCarLeaveInfoWindow.xaml"
            this.AdInfoButton.Click += new System.Windows.RoutedEventHandler(this.AdInfoButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.ParkInfoButton = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\AdCarLeaveInfoWindow.xaml"
            this.ParkInfoButton.Click += new System.Windows.RoutedEventHandler(this.ParkInfoButton_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.AddButton = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\AdCarLeaveInfoWindow.xaml"
            this.AddButton.Click += new System.Windows.RoutedEventHandler(this.AddButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

