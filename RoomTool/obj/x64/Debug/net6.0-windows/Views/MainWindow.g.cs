﻿#pragma checksum "..\..\..\..\..\Views\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95EC90095A173579951D6BA4EE73ED0D98D97E13"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using RoomTool.Views;
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


namespace RoomTool.Views {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox FirstCheckBox;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox SecondCheckBox;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ThirdCheckBox;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView FloorTree;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ApartmentsNumber;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox UseSystemParamArea;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CoefficientSettingsButton;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton ToggleButton;
        
        #line default
        #line hidden
        
        
        #line 179 "..\..\..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OkButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.26.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/RoomTool;component/views/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.26.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.FirstCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 2:
            this.SecondCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 3:
            this.ThirdCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 4:
            this.FloorTree = ((System.Windows.Controls.TreeView)(target));
            
            #line 67 "..\..\..\..\..\Views\MainWindow.xaml"
            this.FloorTree.Loaded += new System.Windows.RoutedEventHandler(this.FloorTree_Loaded);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 80 "..\..\..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SelectAll_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 81 "..\..\..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClearAll_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 82 "..\..\..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ExpandAll_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 83 "..\..\..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CollapseAll_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ApartmentsNumber = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.UseSystemParamArea = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 11:
            this.CoefficientSettingsButton = ((System.Windows.Controls.Button)(target));
            
            #line 136 "..\..\..\..\..\Views\MainWindow.xaml"
            this.CoefficientSettingsButton.Click += new System.Windows.RoutedEventHandler(this.CoefficientSettingsButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 12:
            this.ToggleButton = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 13:
            this.OkButton = ((System.Windows.Controls.Button)(target));
            
            #line 179 "..\..\..\..\..\Views\MainWindow.xaml"
            this.OkButton.Click += new System.Windows.RoutedEventHandler(this.OkButton_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
