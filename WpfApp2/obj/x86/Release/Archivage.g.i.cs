﻿#pragma checksum "..\..\..\Archivage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3C1FA2C90E19C206DFA049D4D568E72ECB2430B0B2A8858618CC3FD123829E23"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using WpfApp2;


namespace WpfApp2 {
    
    
    /// <summary>
    /// Archivage
    /// </summary>
    public partial class Archivage : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 10 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid archivees;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid data_grid;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Donnée_Archivage;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Options_Principale;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Filtrer;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Enregistrer_Sous_Excel;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Panel_tri_Prêts;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Border_Tout_Prêts_tri;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Border_Prêts_sociaux_tri;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Border_Prêts_Electroménager_tri;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Grid_filtrage;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Remarque;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Somme_min;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Somme_max;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Prêt_Type_filtrage;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker Date_pv_min_filtrage;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker Date_pv_max_filtrage;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Employee_filtrage;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Remboursable_filtrage;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Confirmer_Flitrage;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Annuler_Filtrage;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid archi;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border border_pret;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox description_info;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox num_pv_info;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox date_pv_info;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox date_demande_info;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox primo;
        
        #line default
        #line hidden
        
        
        #line 133 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox fino;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox montant_info;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox montant_lettre_info;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Duréee;
        
        #line default
        #line hidden
        
        
        #line 141 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Some;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox motif_info;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border border_details_emp;
        
        #line default
        #line hidden
        
        
        #line 160 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nom_detail;
        
        #line default
        #line hidden
        
        
        #line 161 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox prenom_detail;
        
        #line default
        #line hidden
        
        
        #line 162 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox date_nais_info;
        
        #line default
        #line hidden
        
        
        #line 163 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox num_sec_info;
        
        #line default
        #line hidden
        
        
        #line 164 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox matricule_info;
        
        #line default
        #line hidden
        
        
        #line 165 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox date_recru_info;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox etat_soc_info;
        
        #line default
        #line hidden
        
        
        #line 172 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox grade_info;
        
        #line default
        #line hidden
        
        
        #line 173 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox service_info;
        
        #line default
        #line hidden
        
        
        #line 174 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox num_tel_info;
        
        #line default
        #line hidden
        
        
        #line 175 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ccp_info;
        
        #line default
        #line hidden
        
        
        #line 176 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox cle_ccp_info;
        
        #line default
        #line hidden
        
        
        #line 182 "..\..\..\Archivage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button retourner_detail_emp;
        
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
            System.Uri resourceLocater = new System.Uri("/EASY COS;component/archivage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Archivage.xaml"
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
            this.archivees = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.data_grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.Donnée_Archivage = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.Options_Principale = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.Filtrer = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\..\Archivage.xaml"
            this.Filtrer.Click += new System.Windows.RoutedEventHandler(this.Filtrer_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Enregistrer_Sous_Excel = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\..\Archivage.xaml"
            this.Enregistrer_Sous_Excel.Click += new System.Windows.RoutedEventHandler(this.Enregistrer_excel_click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Panel_tri_Prêts = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 9:
            this.Border_Tout_Prêts_tri = ((System.Windows.Controls.Border)(target));
            return;
            case 10:
            this.Border_Prêts_sociaux_tri = ((System.Windows.Controls.Border)(target));
            return;
            case 11:
            this.Border_Prêts_Electroménager_tri = ((System.Windows.Controls.Border)(target));
            return;
            case 12:
            this.Grid_filtrage = ((System.Windows.Controls.Grid)(target));
            return;
            case 13:
            this.Remarque = ((System.Windows.Controls.Label)(target));
            return;
            case 14:
            this.Somme_min = ((System.Windows.Controls.TextBox)(target));
            return;
            case 15:
            this.Somme_max = ((System.Windows.Controls.TextBox)(target));
            return;
            case 16:
            this.Prêt_Type_filtrage = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 17:
            this.Date_pv_min_filtrage = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 18:
            this.Date_pv_max_filtrage = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 19:
            this.Employee_filtrage = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 20:
            this.Remboursable_filtrage = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 21:
            this.Confirmer_Flitrage = ((System.Windows.Controls.Button)(target));
            return;
            case 22:
            this.Annuler_Filtrage = ((System.Windows.Controls.Button)(target));
            return;
            case 23:
            this.archi = ((System.Windows.Controls.Grid)(target));
            return;
            case 24:
            this.border_pret = ((System.Windows.Controls.Border)(target));
            return;
            case 25:
            this.description_info = ((System.Windows.Controls.TextBox)(target));
            return;
            case 26:
            this.num_pv_info = ((System.Windows.Controls.TextBox)(target));
            return;
            case 27:
            this.date_pv_info = ((System.Windows.Controls.TextBox)(target));
            return;
            case 28:
            this.date_demande_info = ((System.Windows.Controls.TextBox)(target));
            return;
            case 29:
            this.primo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 30:
            this.fino = ((System.Windows.Controls.TextBox)(target));
            return;
            case 31:
            this.montant_info = ((System.Windows.Controls.TextBox)(target));
            return;
            case 32:
            this.montant_lettre_info = ((System.Windows.Controls.TextBox)(target));
            return;
            case 33:
            this.Duréee = ((System.Windows.Controls.TextBox)(target));
            return;
            case 34:
            this.Some = ((System.Windows.Controls.TextBox)(target));
            return;
            case 35:
            this.motif_info = ((System.Windows.Controls.TextBox)(target));
            return;
            case 36:
            this.border_details_emp = ((System.Windows.Controls.Border)(target));
            return;
            case 37:
            this.nom_detail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 38:
            this.prenom_detail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 39:
            this.date_nais_info = ((System.Windows.Controls.TextBox)(target));
            return;
            case 40:
            this.num_sec_info = ((System.Windows.Controls.TextBox)(target));
            return;
            case 41:
            this.matricule_info = ((System.Windows.Controls.TextBox)(target));
            return;
            case 42:
            this.date_recru_info = ((System.Windows.Controls.TextBox)(target));
            return;
            case 43:
            this.etat_soc_info = ((System.Windows.Controls.TextBox)(target));
            return;
            case 44:
            this.grade_info = ((System.Windows.Controls.TextBox)(target));
            return;
            case 45:
            this.service_info = ((System.Windows.Controls.TextBox)(target));
            return;
            case 46:
            this.num_tel_info = ((System.Windows.Controls.TextBox)(target));
            return;
            case 47:
            this.ccp_info = ((System.Windows.Controls.TextBox)(target));
            return;
            case 48:
            this.cle_ccp_info = ((System.Windows.Controls.TextBox)(target));
            return;
            case 49:
            this.retourner_detail_emp = ((System.Windows.Controls.Button)(target));
            
            #line 182 "..\..\..\Archivage.xaml"
            this.retourner_detail_emp.Click += new System.Windows.RoutedEventHandler(this.retour_details);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 4:
            
            #line 71 "..\..\..\Archivage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.details);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

