﻿#pragma checksum "..\..\..\View\TacGiaView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "13CCC7D2F8F18188580245CA13ED67484ABB500D589C3DC7CE14A06F9F49A0EA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using QL_SACH.View;
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


namespace QL_SACH.View {
    
    
    /// <summary>
    /// TacGiaView
    /// </summary>
    public partial class TacGiaView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 52 "..\..\..\View\TacGiaView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbMaTacGia;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\View\TacGiaView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbTenTacGia;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\View\TacGiaView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbQueQuan;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\View\TacGiaView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbPhai;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\View\TacGiaView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpNgaySinh;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\View\TacGiaView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btThem;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\View\TacGiaView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btSua;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\..\View\TacGiaView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btXoa;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\..\View\TacGiaView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listTacGia;
        
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
            System.Uri resourceLocater = new System.Uri("/QL_SACH;component/view/tacgiaview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\TacGiaView.xaml"
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
            
            #line 14 "..\..\..\View\TacGiaView.xaml"
            ((QL_SACH.View.TacGiaView)(target)).MouseRightButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.UserControl_MouseRightButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tbMaTacGia = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tbTenTacGia = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbQueQuan = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.cbPhai = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.dpNgaySinh = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.btThem = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.btSua = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.btXoa = ((System.Windows.Controls.Button)(target));
            return;
            case 10:
            this.listTacGia = ((System.Windows.Controls.ListView)(target));
            
            #line 158 "..\..\..\View\TacGiaView.xaml"
            this.listTacGia.MouseRightButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ListView_MouseRightButtonDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
