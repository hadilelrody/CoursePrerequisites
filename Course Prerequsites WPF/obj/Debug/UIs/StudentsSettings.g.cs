#pragma checksum "..\..\..\UIs\StudentsSettings.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0954EBC2D98399E39A0BBFF4E1E68E3146F67C0C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Course_Prerequsites_WPF.UIs;
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


namespace Course_Prerequsites_WPF.UIs
{


    /// <summary>
    /// StudentsSettings
    /// </summary>
    public partial class StudentsSettings : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 12 "..\..\..\UIs\StudentsSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackBTN;

#line default
#line hidden


#line 20 "..\..\..\UIs\StudentsSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddStudentbtn;

#line default
#line hidden


#line 21 "..\..\..\UIs\StudentsSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemoveStudent;

#line default
#line hidden


#line 22 "..\..\..\UIs\StudentsSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ViewAllCoursesOfStudentbtn;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Course Prerequsites WPF;component/uis/studentssettings.xaml", System.UriKind.Relative);

#line 1 "..\..\..\UIs\StudentsSettings.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.BackBTN = ((System.Windows.Controls.Button)(target));

#line 12 "..\..\..\UIs\StudentsSettings.xaml"
                    this.BackBTN.Click += new System.Windows.RoutedEventHandler(this.BackBTN_Click);

#line default
#line hidden
                    return;
                case 2:
                    this.AddStudentbtn = ((System.Windows.Controls.Button)(target));

#line 20 "..\..\..\UIs\StudentsSettings.xaml"
                    this.AddStudentbtn.Click += new System.Windows.RoutedEventHandler(this.AddStudent_Click);

#line default
#line hidden
                    return;
                case 3:
                    this.RemoveStudent = ((System.Windows.Controls.Button)(target));

#line 21 "..\..\..\UIs\StudentsSettings.xaml"
                    this.RemoveStudent.Click += new System.Windows.RoutedEventHandler(this.RemoveStudent_Click);

#line default
#line hidden
                    return;
                case 4:
                    this.ViewAllCoursesOfStudentbtn = ((System.Windows.Controls.Button)(target));

#line 22 "..\..\..\UIs\StudentsSettings.xaml"
                    this.ViewAllCoursesOfStudentbtn.Click += new System.Windows.RoutedEventHandler(this.ViewAllCoursesOfStudentbtn_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Button EnterStudentGrades;
    }
}

