﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.34209
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

#pragma warning disable 414
namespace WordDocument2 {
    
    
    /// 
    [Microsoft.VisualStudio.Tools.Applications.Runtime.StartupObjectAttribute(0)]
    [global::System.Security.Permissions.PermissionSetAttribute(global::System.Security.Permissions.SecurityAction.Demand, Name="FullTrust")]
    public sealed partial class ThisDocument : Microsoft.Office.Tools.Word.DocumentBase {
        
        internal Microsoft.Office.Tools.ActionsPane ActionsPane;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl plainTextContentControl1;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl plainTextContentControl2;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl plainTextContentControl3;
        
        internal Microsoft.Office.Tools.Word.DatePickerContentControl datePickerContentControl1;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl plainTextContentControl4;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl plainTextContentControl5;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl plainTextContentControl6;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl plainTextContentControl7;
        
        internal Microsoft.Office.Tools.Word.DatePickerContentControl datePickerContentControl2;
        
        internal Microsoft.Office.Tools.Word.DatePickerContentControl datePickerContentControl3;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl plainTextContentControl8;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")]
        private global::System.Object missing = global::System.Type.Missing;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")]
        internal Microsoft.Office.Interop.Word.Application ThisApplication;
        
        internal WordDocument2.Diploma_TestDataSet diploma_TestDataSet;
        
        internal WordDocument2.Diploma_TestDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        
        internal WordDocument2.Diploma_TestDataSetTableAdapters.PersonalTableAdapter personalTableAdapter;
        
        internal System.Windows.Forms.BindingSource personalBindingSource;
        
        private System.ComponentModel.IContainer components;
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        public ThisDocument(global::Microsoft.Office.Tools.Word.Factory factory, global::System.IServiceProvider serviceProvider) : 
                base(factory, serviceProvider, "ThisDocument", "ThisDocument") {
            Globals.Factory = factory;
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected override void Initialize() {
            base.Initialize();
            this.ThisApplication = this.GetHostItem<Microsoft.Office.Interop.Word.Application>(typeof(Microsoft.Office.Interop.Word.Application), "Application");
            Globals.ThisDocument = this;
            global::System.Windows.Forms.Application.EnableVisualStyles();
            this.InitializeCachedData();
            this.InitializeControls();
            this.InitializeComponents();
            this.InitializeData();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected override void FinishInitialization() {
            this.InternalStartup();
            this.OnStartup();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected override void InitializeDataBindings() {
            this.BeginInitialization();
            this.BindToData();
            this.EndInitialization();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void InitializeCachedData() {
            if ((this.DataHost == null)) {
                return;
            }
            if (this.DataHost.IsCacheInitialized) {
                this.DataHost.FillCachedData(this);
            }
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void InitializeData() {
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void BindToData() {
            this.plainTextContentControl1.DataBindings.Add("Text", this.personalBindingSource, "Familija", true, this.plainTextContentControl1.DataBindings.DefaultDataSourceUpdateMode);
            this.plainTextContentControl2.DataBindings.Add("Text", this.personalBindingSource, "Imja", true, this.plainTextContentControl2.DataBindings.DefaultDataSourceUpdateMode);
            this.plainTextContentControl3.DataBindings.Add("Text", this.personalBindingSource, "Otchestvo", true, this.plainTextContentControl3.DataBindings.DefaultDataSourceUpdateMode);
            this.datePickerContentControl1.DataBindings.Add("Text", this.personalBindingSource, "DataRozhdenija", true, this.datePickerContentControl1.DataBindings.DefaultDataSourceUpdateMode);
            this.plainTextContentControl4.DataBindings.Add("Text", this.personalBindingSource, "MestoRozhdenija", true, this.plainTextContentControl4.DataBindings.DefaultDataSourceUpdateMode);
            this.plainTextContentControl5.DataBindings.Add("Text", this.personalBindingSource, "Grazhdanstvo", true, this.plainTextContentControl5.DataBindings.DefaultDataSourceUpdateMode);
            this.plainTextContentControl6.DataBindings.Add("Text", this.personalBindingSource, "Obrazovanije", true, this.plainTextContentControl6.DataBindings.DefaultDataSourceUpdateMode);
            this.plainTextContentControl7.DataBindings.Add("Text", this.personalBindingSource, "NomerTD", true, this.plainTextContentControl7.DataBindings.DefaultDataSourceUpdateMode);
            this.datePickerContentControl2.DataBindings.Add("Text", this.personalBindingSource, "DataTD", true, this.datePickerContentControl2.DataBindings.DefaultDataSourceUpdateMode);
            this.datePickerContentControl3.DataBindings.Add("Text", this.personalBindingSource, "DataNachalaRaboti", true, this.datePickerContentControl3.DataBindings.DefaultDataSourceUpdateMode);
            this.plainTextContentControl8.DataBindings.Add("Text", this.personalBindingSource, "NazvanijeOrganizatsii_fk", true, this.plainTextContentControl8.DataBindings.DefaultDataSourceUpdateMode);
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        private void StartCaching(string MemberName) {
            this.DataHost.StartCaching(this, MemberName);
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        private void StopCaching(string MemberName) {
            this.DataHost.StopCaching(this, MemberName);
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        private bool IsCached(string MemberName) {
            return this.DataHost.IsCached(this, MemberName);
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void BeginInitialization() {
            this.BeginInit();
            this.ActionsPane.BeginInit();
            this.plainTextContentControl1.BeginInit();
            this.plainTextContentControl2.BeginInit();
            this.plainTextContentControl3.BeginInit();
            this.datePickerContentControl1.BeginInit();
            this.plainTextContentControl4.BeginInit();
            this.plainTextContentControl5.BeginInit();
            this.plainTextContentControl6.BeginInit();
            this.plainTextContentControl7.BeginInit();
            this.datePickerContentControl2.BeginInit();
            this.datePickerContentControl3.BeginInit();
            this.plainTextContentControl8.BeginInit();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void EndInitialization() {
            this.plainTextContentControl8.EndInit();
            this.datePickerContentControl3.EndInit();
            this.datePickerContentControl2.EndInit();
            this.plainTextContentControl7.EndInit();
            this.plainTextContentControl6.EndInit();
            this.plainTextContentControl5.EndInit();
            this.plainTextContentControl4.EndInit();
            this.datePickerContentControl1.EndInit();
            this.plainTextContentControl3.EndInit();
            this.plainTextContentControl2.EndInit();
            this.plainTextContentControl1.EndInit();
            this.ActionsPane.EndInit();
            this.EndInit();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void InitializeControls() {
            this.ActionsPane = Globals.Factory.CreateActionsPane(null, null, "ActionsPane", "ActionsPane", this);
            this.plainTextContentControl1 = Globals.Factory.CreatePlainTextContentControl(null, null, "3071906199", "plainTextContentControl1", this);
            this.plainTextContentControl2 = Globals.Factory.CreatePlainTextContentControl(null, null, "3161261275", "plainTextContentControl2", this);
            this.plainTextContentControl3 = Globals.Factory.CreatePlainTextContentControl(null, null, "2315366281", "plainTextContentControl3", this);
            this.datePickerContentControl1 = Globals.Factory.CreateDatePickerContentControl(null, null, "1450737942", "datePickerContentControl1", this);
            this.plainTextContentControl4 = Globals.Factory.CreatePlainTextContentControl(null, null, "1565920347", "plainTextContentControl4", this);
            this.plainTextContentControl5 = Globals.Factory.CreatePlainTextContentControl(null, null, "1082257741", "plainTextContentControl5", this);
            this.plainTextContentControl6 = Globals.Factory.CreatePlainTextContentControl(null, null, "2609999804", "plainTextContentControl6", this);
            this.plainTextContentControl7 = Globals.Factory.CreatePlainTextContentControl(null, null, "3540000730", "plainTextContentControl7", this);
            this.datePickerContentControl2 = Globals.Factory.CreateDatePickerContentControl(null, null, "1992911680", "datePickerContentControl2", this);
            this.datePickerContentControl3 = Globals.Factory.CreateDatePickerContentControl(null, null, "29238880", "datePickerContentControl3", this);
            this.plainTextContentControl8 = Globals.Factory.CreatePlainTextContentControl(null, null, "1831788734", "plainTextContentControl8", this);
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void InitializeComponents() {
            this.components = new System.ComponentModel.Container();
            if ((this.diploma_TestDataSet == null)) {
                // Instantiate the object if not yet loaded from the data cache.
                this.diploma_TestDataSet = new WordDocument2.Diploma_TestDataSet();
            }
            this.tableAdapterManager = new WordDocument2.Diploma_TestDataSetTableAdapters.TableAdapterManager();
            this.personalTableAdapter = new WordDocument2.Diploma_TestDataSetTableAdapters.PersonalTableAdapter();
            this.personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.diploma_TestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).BeginInit();
            // 
            // ActionsPane
            // 
            this.ActionsPane.AutoSize = false;
            this.ActionsPane.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            // 
            // plainTextContentControl1
            // 
            this.plainTextContentControl1.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // plainTextContentControl2
            // 
            this.plainTextContentControl2.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // plainTextContentControl3
            // 
            this.plainTextContentControl3.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // datePickerContentControl1
            // 
            this.datePickerContentControl1.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // plainTextContentControl4
            // 
            this.plainTextContentControl4.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // plainTextContentControl5
            // 
            this.plainTextContentControl5.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // plainTextContentControl6
            // 
            this.plainTextContentControl6.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // plainTextContentControl7
            // 
            this.plainTextContentControl7.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // datePickerContentControl2
            // 
            this.datePickerContentControl2.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // datePickerContentControl3
            // 
            this.datePickerContentControl3.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // diploma_TestDataSet
            // 
            this.diploma_TestDataSet.DataSetName = "Diploma_TestDataSet";
            this.diploma_TestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.EducationTableAdapter = null;
            this.tableAdapterManager.Kodi_OKATOTableAdapter = null;
            this.tableAdapterManager.Kodi_OKIN_GrazhdanstvoTableAdapter = null;
            this.tableAdapterManager.Kodi_OKIN_InYazikTableAdapter = null;
            this.tableAdapterManager.Kodi_OKIN_ObrazovanijeTableAdapter = null;
            this.tableAdapterManager.Kodi_OKIN_StepenYazikaTableAdapter = null;
            this.tableAdapterManager.Kodi_OKPDTRTableAdapter = null;
            this.tableAdapterManager.Kodi_OKSOTableAdapter = null;
            this.tableAdapterManager.LanguagesTableAdapter = null;
            this.tableAdapterManager.OrganizationTableAdapter = null;
            this.tableAdapterManager.PersonalTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WordDocument2.Diploma_TestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // personalTableAdapter
            // 
            this.personalTableAdapter.ClearBeforeFill = true;
            // 
            // personalBindingSource
            // 
            this.personalBindingSource.DataMember = "Personal";
            this.personalBindingSource.DataSource = this.diploma_TestDataSet;
            // 
            // plainTextContentControl8
            // 
            this.plainTextContentControl8.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // ThisDocument
            // 
            ((System.ComponentModel.ISupportInitialize)(this.diploma_TestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).EndInit();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        private bool NeedsFill(string MemberName) {
            return this.DataHost.NeedsFill(this, MemberName);
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected override void OnShutdown() {
            this.plainTextContentControl8.Dispose();
            this.datePickerContentControl3.Dispose();
            this.datePickerContentControl2.Dispose();
            this.plainTextContentControl7.Dispose();
            this.plainTextContentControl6.Dispose();
            this.plainTextContentControl5.Dispose();
            this.plainTextContentControl4.Dispose();
            this.datePickerContentControl1.Dispose();
            this.plainTextContentControl3.Dispose();
            this.plainTextContentControl2.Dispose();
            this.plainTextContentControl1.Dispose();
            this.ActionsPane.Dispose();
            base.OnShutdown();
        }
    }
    
    /// 
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")]
    internal sealed partial class Globals {
        
        /// 
        private Globals() {
        }
        
        private static ThisDocument _ThisDocument;
        
        private static global::Microsoft.Office.Tools.Word.Factory _factory;
        
        private static ThisRibbonCollection _ThisRibbonCollection;
        
        internal static ThisDocument ThisDocument {
            get {
                return _ThisDocument;
            }
            set {
                if ((_ThisDocument == null)) {
                    _ThisDocument = value;
                }
                else {
                    throw new System.NotSupportedException();
                }
            }
        }
        
        internal static global::Microsoft.Office.Tools.Word.Factory Factory {
            get {
                return _factory;
            }
            set {
                if ((_factory == null)) {
                    _factory = value;
                }
                else {
                    throw new System.NotSupportedException();
                }
            }
        }
        
        internal static ThisRibbonCollection Ribbons {
            get {
                if ((_ThisRibbonCollection == null)) {
                    _ThisRibbonCollection = new ThisRibbonCollection(_factory.GetRibbonFactory());
                }
                return _ThisRibbonCollection;
            }
        }
    }
    
    /// 
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")]
    internal sealed partial class ThisRibbonCollection : Microsoft.Office.Tools.Ribbon.RibbonCollectionBase {
        
        /// 
        internal ThisRibbonCollection(global::Microsoft.Office.Tools.Ribbon.RibbonFactory factory) : 
                base(factory) {
        }
    }
}