﻿#pragma checksum "..\..\..\UIs\EditCourse.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28BCC0DCB2A2DB6ADF48B332F4F0FDAC74D41698"
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


namespace Course_Prerequsites_WPF.UIs {
    
    
    /// <summary>
    /// EditCourse
    /// </summary>
    public partial class EditCourse : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\UIs\EditCourse.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackBTN;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\UIs\EditCourse.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas InnerCanvas;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\UIs\EditCourse.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CurrentNumberOfStudentsTextBox;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\UIs\EditCourse.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MaximumNumberOfStudentsTextBox;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\UIs\EditCourse.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PassingGradeTextBox;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\UIs\EditCourse.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CourseGradeTextBox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\UIs\EditCourse.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox HoursTextBox;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\UIs\EditCourse.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InstructorTextBox;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\UIs\EditCourse.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DescriptionTextBox;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\UIs\EditCourse.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CourseSelection;
        
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
            System.Uri resourceLocater = new System.Uri("/Course Prerequsites WPF;component/uis/editcourse.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UIs\EditCourse.xaml"
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
            this.BackBTN = ((System.Windows.Controls.Button)(target));
            
            #line 7 "..\..\..\UIs\EditCourse.xaml"
            this.BackBTN.Click += new System.Windows.RoutedEventHandler(this.BackBTN_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.InnerCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 3:
            this.CurrentNumberOfStudentsTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.MaximumNumberOfStudentsTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.PassingGradeTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.CourseGradeTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.HoursTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.InstructorTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.DescriptionTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.CourseSelection = ((System.Windows.Controls.ComboBox)(target));
            
            #line 36 "..\..\..\UIs\EditCourse.xaml"
            this.CourseSelection.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CourseSelection_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 38 "..\..\..\UIs\EditCourse.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

