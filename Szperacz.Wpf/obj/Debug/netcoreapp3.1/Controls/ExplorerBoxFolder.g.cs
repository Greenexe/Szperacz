﻿#pragma checksum "..\..\..\..\Controls\ExplorerBoxFolder.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8387204969079750F152B01E9FCC2BBAD6FAA61B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using MvvmCross.Platforms.Wpf.Binding;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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
using Szperacz.Wpf.Controls;
using Szperacz.Wpf.Icons;


namespace Szperacz.Wpf.Controls {
    
    
    /// <summary>
    /// ExplorerBoxFolder
    /// </summary>
    public partial class ExplorerBoxFolder : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\Controls\ExplorerBoxFolder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Szperacz.Wpf.Controls.ExplorerBoxFolder ExplorerWindow;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\Controls\ExplorerBoxFolder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridExplorer;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Controls\ExplorerBoxFolder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combo;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Controls\ExplorerBoxFolder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlockWatermark;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\Controls\ExplorerBoxFolder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxPath;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\Controls\ExplorerBoxFolder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Szperacz.Wpf;component/controls/explorerboxfolder.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Controls\ExplorerBoxFolder.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ExplorerWindow = ((Szperacz.Wpf.Controls.ExplorerBoxFolder)(target));
            return;
            case 2:
            this.gridExplorer = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.combo = ((System.Windows.Controls.ComboBox)(target));
            
            #line 21 "..\..\..\..\Controls\ExplorerBoxFolder.xaml"
            this.combo.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.combo_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.textBlockWatermark = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.textBoxPath = ((System.Windows.Controls.TextBox)(target));
            
            #line 51 "..\..\..\..\Controls\ExplorerBoxFolder.xaml"
            this.textBoxPath.GotFocus += new System.Windows.RoutedEventHandler(this.textBoxPath_GotFocus);
            
            #line default
            #line hidden
            
            #line 51 "..\..\..\..\Controls\ExplorerBoxFolder.xaml"
            this.textBoxPath.LostFocus += new System.Windows.RoutedEventHandler(this.textBoxPath_LostFocus);
            
            #line default
            #line hidden
            
            #line 52 "..\..\..\..\Controls\ExplorerBoxFolder.xaml"
            this.textBoxPath.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textBoxPath_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.button = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

