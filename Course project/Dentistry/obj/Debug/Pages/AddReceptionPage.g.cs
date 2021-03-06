﻿#pragma checksum "..\..\..\Pages\AddReceptionPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1A5E39D064136DBB7D097E8B1745D390C2691E3BC238EE70DA766FFAAB759AE7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Dentistry.Pages;
using Microsoft.Windows.Themes;
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
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Converters;
using Xceed.Wpf.Toolkit.Core;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Mag.Converters;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace Dentistry.Pages {
    
    
    /// <summary>
    /// AddReceptionPage
    /// </summary>
    public partial class AddReceptionPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\Pages\AddReceptionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.DateTimePicker DPickerReceptionDate;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Pages\AddReceptionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboDoctors;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Pages\AddReceptionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboClients;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Pages\AddReceptionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboServices;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\Pages\AddReceptionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBoxDiagnosis;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\Pages\AddReceptionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBoxPayment;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\Pages\AddReceptionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddReception;
        
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
            System.Uri resourceLocater = new System.Uri("/Dentistry;component/pages/addreceptionpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\AddReceptionPage.xaml"
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
            this.DPickerReceptionDate = ((Xceed.Wpf.Toolkit.DateTimePicker)(target));
            return;
            case 2:
            this.ComboDoctors = ((System.Windows.Controls.ComboBox)(target));
            
            #line 37 "..\..\..\Pages\AddReceptionPage.xaml"
            this.ComboDoctors.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboDoctor_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ComboClients = ((System.Windows.Controls.ComboBox)(target));
            
            #line 53 "..\..\..\Pages\AddReceptionPage.xaml"
            this.ComboClients.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboClients_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ComboServices = ((System.Windows.Controls.ComboBox)(target));
            
            #line 66 "..\..\..\Pages\AddReceptionPage.xaml"
            this.ComboServices.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboServices_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TBoxDiagnosis = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.TBoxPayment = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.BtnAddReception = ((System.Windows.Controls.Button)(target));
            
            #line 110 "..\..\..\Pages\AddReceptionPage.xaml"
            this.BtnAddReception.Click += new System.Windows.RoutedEventHandler(this.BtnAddReception_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

