namespace DiplomaTestWindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label dataPrikazaOPriemeLabel;
            System.Windows.Forms.Label dataTDLabel;
            System.Windows.Forms.Label nomerTDLabel;
            System.Windows.Forms.Label vidRabotiLabel;
            System.Windows.Forms.Label kharakterRabotiLabel;
            System.Windows.Forms.Label dataNachalaRabotiLabel;
            System.Windows.Forms.Label professijaDrugajaLabel;
            System.Windows.Forms.Label professijaLabel;
            System.Windows.Forms.Label obrazovanijeLabel;
            System.Windows.Forms.Label grazhdanstvoLabel;
            System.Windows.Forms.Label mestoRozhdenijaLabel;
            System.Windows.Forms.Label dataRozhdenijaLabel;
            System.Windows.Forms.Label fioVRoditelnomLabel;
            System.Windows.Forms.Label fioLabel;
            System.Windows.Forms.Label otchestvoLabel;
            System.Windows.Forms.Label imjaLabel;
            System.Windows.Forms.Label familijaLabel;
            System.Windows.Forms.Label polLabel;
            System.Windows.Forms.Label snilsLabel;
            System.Windows.Forms.Label innLabel;
            System.Windows.Forms.Label tabNomerLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label nazvanijeOrganizatsii_fkLabel;
            this.diploma_TestDataSet = new DiplomaTestWindowsForms.Diploma_TestDataSet();
            this.personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalTableAdapter = new DiplomaTestWindowsForms.Diploma_TestDataSetTableAdapters.PersonalTableAdapter();
            this.tableAdapterManager = new DiplomaTestWindowsForms.Diploma_TestDataSetTableAdapters.TableAdapterManager();
            this.personalBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.personalBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataPrikazaOPriemeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataTDDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nomerTDTextBox = new System.Windows.Forms.TextBox();
            this.vidRabotiTextBox = new System.Windows.Forms.TextBox();
            this.kharakterRabotiTextBox = new System.Windows.Forms.TextBox();
            this.dataNachalaRabotiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.professijaDrugajaTextBox = new System.Windows.Forms.TextBox();
            this.professijaTextBox = new System.Windows.Forms.TextBox();
            this.obrazovanijeTextBox = new System.Windows.Forms.TextBox();
            this.grazhdanstvoTextBox = new System.Windows.Forms.TextBox();
            this.mestoRozhdenijaTextBox = new System.Windows.Forms.TextBox();
            this.dataRozhdenijaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fioVRoditelnomTextBox = new System.Windows.Forms.TextBox();
            this.fioTextBox = new System.Windows.Forms.TextBox();
            this.otchestvoTextBox = new System.Windows.Forms.TextBox();
            this.imjaTextBox = new System.Windows.Forms.TextBox();
            this.familijaTextBox = new System.Windows.Forms.TextBox();
            this.polTextBox = new System.Windows.Forms.TextBox();
            this.snilsTextBox = new System.Windows.Forms.TextBox();
            this.innTextBox = new System.Windows.Forms.TextBox();
            this.tabNomerTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nazvanijeOrganizatsii_fkTextBox = new System.Windows.Forms.TextBox();
            dataPrikazaOPriemeLabel = new System.Windows.Forms.Label();
            dataTDLabel = new System.Windows.Forms.Label();
            nomerTDLabel = new System.Windows.Forms.Label();
            vidRabotiLabel = new System.Windows.Forms.Label();
            kharakterRabotiLabel = new System.Windows.Forms.Label();
            dataNachalaRabotiLabel = new System.Windows.Forms.Label();
            professijaDrugajaLabel = new System.Windows.Forms.Label();
            professijaLabel = new System.Windows.Forms.Label();
            obrazovanijeLabel = new System.Windows.Forms.Label();
            grazhdanstvoLabel = new System.Windows.Forms.Label();
            mestoRozhdenijaLabel = new System.Windows.Forms.Label();
            dataRozhdenijaLabel = new System.Windows.Forms.Label();
            fioVRoditelnomLabel = new System.Windows.Forms.Label();
            fioLabel = new System.Windows.Forms.Label();
            otchestvoLabel = new System.Windows.Forms.Label();
            imjaLabel = new System.Windows.Forms.Label();
            familijaLabel = new System.Windows.Forms.Label();
            polLabel = new System.Windows.Forms.Label();
            snilsLabel = new System.Windows.Forms.Label();
            innLabel = new System.Windows.Forms.Label();
            tabNomerLabel = new System.Windows.Forms.Label();
            nazvanijeOrganizatsii_fkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.diploma_TestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingNavigator)).BeginInit();
            this.personalBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataPrikazaOPriemeLabel
            // 
            dataPrikazaOPriemeLabel.AutoSize = true;
            dataPrikazaOPriemeLabel.Location = new System.Drawing.Point(35, 633);
            dataPrikazaOPriemeLabel.Name = "dataPrikazaOPriemeLabel";
            dataPrikazaOPriemeLabel.Size = new System.Drawing.Size(114, 13);
            dataPrikazaOPriemeLabel.TabIndex = 45;
            dataPrikazaOPriemeLabel.Text = "Data Prikaza OPrieme:";
            // 
            // dataTDLabel
            // 
            dataTDLabel.AutoSize = true;
            dataTDLabel.Location = new System.Drawing.Point(35, 607);
            dataTDLabel.Name = "dataTDLabel";
            dataTDLabel.Size = new System.Drawing.Size(51, 13);
            dataTDLabel.TabIndex = 43;
            dataTDLabel.Text = "Data TD:";
            // 
            // nomerTDLabel
            // 
            nomerTDLabel.AutoSize = true;
            nomerTDLabel.Location = new System.Drawing.Point(35, 580);
            nomerTDLabel.Name = "nomerTDLabel";
            nomerTDLabel.Size = new System.Drawing.Size(59, 13);
            nomerTDLabel.TabIndex = 41;
            nomerTDLabel.Text = "Nomer TD:";
            // 
            // vidRabotiLabel
            // 
            vidRabotiLabel.AutoSize = true;
            vidRabotiLabel.Location = new System.Drawing.Point(35, 554);
            vidRabotiLabel.Name = "vidRabotiLabel";
            vidRabotiLabel.Size = new System.Drawing.Size(59, 13);
            vidRabotiLabel.TabIndex = 39;
            vidRabotiLabel.Text = "Vid Raboti:";
            // 
            // kharakterRabotiLabel
            // 
            kharakterRabotiLabel.AutoSize = true;
            kharakterRabotiLabel.Location = new System.Drawing.Point(35, 528);
            kharakterRabotiLabel.Name = "kharakterRabotiLabel";
            kharakterRabotiLabel.Size = new System.Drawing.Size(90, 13);
            kharakterRabotiLabel.TabIndex = 37;
            kharakterRabotiLabel.Text = "Kharakter Raboti:";
            // 
            // dataNachalaRabotiLabel
            // 
            dataNachalaRabotiLabel.AutoSize = true;
            dataNachalaRabotiLabel.Location = new System.Drawing.Point(35, 503);
            dataNachalaRabotiLabel.Name = "dataNachalaRabotiLabel";
            dataNachalaRabotiLabel.Size = new System.Drawing.Size(110, 13);
            dataNachalaRabotiLabel.TabIndex = 35;
            dataNachalaRabotiLabel.Text = "Data Nachala Raboti:";
            // 
            // professijaDrugajaLabel
            // 
            professijaDrugajaLabel.AutoSize = true;
            professijaDrugajaLabel.Location = new System.Drawing.Point(35, 476);
            professijaDrugajaLabel.Name = "professijaDrugajaLabel";
            professijaDrugajaLabel.Size = new System.Drawing.Size(95, 13);
            professijaDrugajaLabel.TabIndex = 33;
            professijaDrugajaLabel.Text = "Professija Drugaja:";
            // 
            // professijaLabel
            // 
            professijaLabel.AutoSize = true;
            professijaLabel.Location = new System.Drawing.Point(35, 450);
            professijaLabel.Name = "professijaLabel";
            professijaLabel.Size = new System.Drawing.Size(55, 13);
            professijaLabel.TabIndex = 31;
            professijaLabel.Text = "Professija:";
            // 
            // obrazovanijeLabel
            // 
            obrazovanijeLabel.AutoSize = true;
            obrazovanijeLabel.Location = new System.Drawing.Point(35, 424);
            obrazovanijeLabel.Name = "obrazovanijeLabel";
            obrazovanijeLabel.Size = new System.Drawing.Size(72, 13);
            obrazovanijeLabel.TabIndex = 29;
            obrazovanijeLabel.Text = "Obrazovanije:";
            // 
            // grazhdanstvoLabel
            // 
            grazhdanstvoLabel.AutoSize = true;
            grazhdanstvoLabel.Location = new System.Drawing.Point(35, 398);
            grazhdanstvoLabel.Name = "grazhdanstvoLabel";
            grazhdanstvoLabel.Size = new System.Drawing.Size(76, 13);
            grazhdanstvoLabel.TabIndex = 27;
            grazhdanstvoLabel.Text = "Grazhdanstvo:";
            // 
            // mestoRozhdenijaLabel
            // 
            mestoRozhdenijaLabel.AutoSize = true;
            mestoRozhdenijaLabel.Location = new System.Drawing.Point(35, 372);
            mestoRozhdenijaLabel.Name = "mestoRozhdenijaLabel";
            mestoRozhdenijaLabel.Size = new System.Drawing.Size(95, 13);
            mestoRozhdenijaLabel.TabIndex = 25;
            mestoRozhdenijaLabel.Text = "Mesto Rozhdenija:";
            // 
            // dataRozhdenijaLabel
            // 
            dataRozhdenijaLabel.AutoSize = true;
            dataRozhdenijaLabel.Location = new System.Drawing.Point(35, 347);
            dataRozhdenijaLabel.Name = "dataRozhdenijaLabel";
            dataRozhdenijaLabel.Size = new System.Drawing.Size(89, 13);
            dataRozhdenijaLabel.TabIndex = 23;
            dataRozhdenijaLabel.Text = "Data Rozhdenija:";
            // 
            // fioVRoditelnomLabel
            // 
            fioVRoditelnomLabel.AutoSize = true;
            fioVRoditelnomLabel.Location = new System.Drawing.Point(35, 320);
            fioVRoditelnomLabel.Name = "fioVRoditelnomLabel";
            fioVRoditelnomLabel.Size = new System.Drawing.Size(87, 13);
            fioVRoditelnomLabel.TabIndex = 21;
            fioVRoditelnomLabel.Text = "Fio VRoditelnom:";
            // 
            // fioLabel
            // 
            fioLabel.AutoSize = true;
            fioLabel.Location = new System.Drawing.Point(35, 294);
            fioLabel.Name = "fioLabel";
            fioLabel.Size = new System.Drawing.Size(24, 13);
            fioLabel.TabIndex = 19;
            fioLabel.Text = "Fio:";
            // 
            // otchestvoLabel
            // 
            otchestvoLabel.AutoSize = true;
            otchestvoLabel.Location = new System.Drawing.Point(35, 268);
            otchestvoLabel.Name = "otchestvoLabel";
            otchestvoLabel.Size = new System.Drawing.Size(59, 13);
            otchestvoLabel.TabIndex = 17;
            otchestvoLabel.Text = "Otchestvo:";
            // 
            // imjaLabel
            // 
            imjaLabel.AutoSize = true;
            imjaLabel.Location = new System.Drawing.Point(35, 242);
            imjaLabel.Name = "imjaLabel";
            imjaLabel.Size = new System.Drawing.Size(29, 13);
            imjaLabel.TabIndex = 15;
            imjaLabel.Text = "Imja:";
            // 
            // familijaLabel
            // 
            familijaLabel.AutoSize = true;
            familijaLabel.Location = new System.Drawing.Point(35, 216);
            familijaLabel.Name = "familijaLabel";
            familijaLabel.Size = new System.Drawing.Size(44, 13);
            familijaLabel.TabIndex = 13;
            familijaLabel.Text = "Familija:";
            // 
            // polLabel
            // 
            polLabel.AutoSize = true;
            polLabel.Location = new System.Drawing.Point(35, 190);
            polLabel.Name = "polLabel";
            polLabel.Size = new System.Drawing.Size(25, 13);
            polLabel.TabIndex = 11;
            polLabel.Text = "Pol:";
            // 
            // snilsLabel
            // 
            snilsLabel.AutoSize = true;
            snilsLabel.Location = new System.Drawing.Point(35, 164);
            snilsLabel.Name = "snilsLabel";
            snilsLabel.Size = new System.Drawing.Size(32, 13);
            snilsLabel.TabIndex = 9;
            snilsLabel.Text = "Snils:";
            // 
            // innLabel
            // 
            innLabel.AutoSize = true;
            innLabel.Location = new System.Drawing.Point(35, 138);
            innLabel.Name = "innLabel";
            innLabel.Size = new System.Drawing.Size(25, 13);
            innLabel.TabIndex = 7;
            innLabel.Text = "Inn:";
            // 
            // tabNomerLabel
            // 
            tabNomerLabel.AutoSize = true;
            tabNomerLabel.Location = new System.Drawing.Point(35, 112);
            tabNomerLabel.Name = "tabNomerLabel";
            tabNomerLabel.Size = new System.Drawing.Size(63, 13);
            tabNomerLabel.TabIndex = 5;
            tabNomerLabel.Text = "Tab Nomer:";
            // 
            // diploma_TestDataSet
            // 
            this.diploma_TestDataSet.DataSetName = "Diploma_TestDataSet";
            this.diploma_TestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personalBindingSource
            // 
            this.personalBindingSource.DataMember = "Personal";
            this.personalBindingSource.DataSource = this.diploma_TestDataSet;
            // 
            // personalTableAdapter
            // 
            this.personalTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
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
            this.tableAdapterManager.PersonalTableAdapter = this.personalTableAdapter;
            this.tableAdapterManager.UpdateOrder = DiplomaTestWindowsForms.Diploma_TestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // personalBindingNavigator
            // 
            this.personalBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.personalBindingNavigator.BindingSource = this.personalBindingSource;
            this.personalBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.personalBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.personalBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.personalBindingNavigatorSaveItem});
            this.personalBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.personalBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.personalBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.personalBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.personalBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.personalBindingNavigator.Name = "personalBindingNavigator";
            this.personalBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.personalBindingNavigator.Size = new System.Drawing.Size(421, 25);
            this.personalBindingNavigator.TabIndex = 0;
            this.personalBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // personalBindingNavigatorSaveItem
            // 
            this.personalBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.personalBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("personalBindingNavigatorSaveItem.Image")));
            this.personalBindingNavigatorSaveItem.Name = "personalBindingNavigatorSaveItem";
            this.personalBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.personalBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.personalBindingNavigatorSaveItem.Click += new System.EventHandler(this.personalBindingNavigatorSaveItem_Click);
            // 
            // dataPrikazaOPriemeDateTimePicker
            // 
            this.dataPrikazaOPriemeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personalBindingSource, "DataPrikazaOPrieme", true));
            this.dataPrikazaOPriemeDateTimePicker.Location = new System.Drawing.Point(167, 629);
            this.dataPrikazaOPriemeDateTimePicker.Name = "dataPrikazaOPriemeDateTimePicker";
            this.dataPrikazaOPriemeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataPrikazaOPriemeDateTimePicker.TabIndex = 46;
            // 
            // dataTDDateTimePicker
            // 
            this.dataTDDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personalBindingSource, "DataTD", true));
            this.dataTDDateTimePicker.Location = new System.Drawing.Point(167, 603);
            this.dataTDDateTimePicker.Name = "dataTDDateTimePicker";
            this.dataTDDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataTDDateTimePicker.TabIndex = 44;
            // 
            // nomerTDTextBox
            // 
            this.nomerTDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "NomerTD", true));
            this.nomerTDTextBox.Location = new System.Drawing.Point(167, 577);
            this.nomerTDTextBox.Name = "nomerTDTextBox";
            this.nomerTDTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomerTDTextBox.TabIndex = 42;
            // 
            // vidRabotiTextBox
            // 
            this.vidRabotiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "VidRaboti", true));
            this.vidRabotiTextBox.Location = new System.Drawing.Point(167, 551);
            this.vidRabotiTextBox.Name = "vidRabotiTextBox";
            this.vidRabotiTextBox.Size = new System.Drawing.Size(200, 20);
            this.vidRabotiTextBox.TabIndex = 40;
            // 
            // kharakterRabotiTextBox
            // 
            this.kharakterRabotiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "KharakterRaboti", true));
            this.kharakterRabotiTextBox.Location = new System.Drawing.Point(167, 525);
            this.kharakterRabotiTextBox.Name = "kharakterRabotiTextBox";
            this.kharakterRabotiTextBox.Size = new System.Drawing.Size(200, 20);
            this.kharakterRabotiTextBox.TabIndex = 38;
            // 
            // dataNachalaRabotiDateTimePicker
            // 
            this.dataNachalaRabotiDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personalBindingSource, "DataNachalaRaboti", true));
            this.dataNachalaRabotiDateTimePicker.Location = new System.Drawing.Point(167, 499);
            this.dataNachalaRabotiDateTimePicker.Name = "dataNachalaRabotiDateTimePicker";
            this.dataNachalaRabotiDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataNachalaRabotiDateTimePicker.TabIndex = 36;
            // 
            // professijaDrugajaTextBox
            // 
            this.professijaDrugajaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "ProfessijaDrugaja", true));
            this.professijaDrugajaTextBox.Location = new System.Drawing.Point(167, 473);
            this.professijaDrugajaTextBox.Name = "professijaDrugajaTextBox";
            this.professijaDrugajaTextBox.Size = new System.Drawing.Size(200, 20);
            this.professijaDrugajaTextBox.TabIndex = 34;
            // 
            // professijaTextBox
            // 
            this.professijaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Professija", true));
            this.professijaTextBox.Location = new System.Drawing.Point(167, 447);
            this.professijaTextBox.Name = "professijaTextBox";
            this.professijaTextBox.Size = new System.Drawing.Size(200, 20);
            this.professijaTextBox.TabIndex = 32;
            // 
            // obrazovanijeTextBox
            // 
            this.obrazovanijeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Obrazovanije", true));
            this.obrazovanijeTextBox.Location = new System.Drawing.Point(167, 421);
            this.obrazovanijeTextBox.Name = "obrazovanijeTextBox";
            this.obrazovanijeTextBox.Size = new System.Drawing.Size(200, 20);
            this.obrazovanijeTextBox.TabIndex = 30;
            // 
            // grazhdanstvoTextBox
            // 
            this.grazhdanstvoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Grazhdanstvo", true));
            this.grazhdanstvoTextBox.Location = new System.Drawing.Point(167, 395);
            this.grazhdanstvoTextBox.Name = "grazhdanstvoTextBox";
            this.grazhdanstvoTextBox.Size = new System.Drawing.Size(200, 20);
            this.grazhdanstvoTextBox.TabIndex = 28;
            // 
            // mestoRozhdenijaTextBox
            // 
            this.mestoRozhdenijaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "MestoRozhdenija", true));
            this.mestoRozhdenijaTextBox.Location = new System.Drawing.Point(167, 369);
            this.mestoRozhdenijaTextBox.Name = "mestoRozhdenijaTextBox";
            this.mestoRozhdenijaTextBox.Size = new System.Drawing.Size(200, 20);
            this.mestoRozhdenijaTextBox.TabIndex = 26;
            // 
            // dataRozhdenijaDateTimePicker
            // 
            this.dataRozhdenijaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personalBindingSource, "DataRozhdenija", true));
            this.dataRozhdenijaDateTimePicker.Location = new System.Drawing.Point(167, 343);
            this.dataRozhdenijaDateTimePicker.Name = "dataRozhdenijaDateTimePicker";
            this.dataRozhdenijaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataRozhdenijaDateTimePicker.TabIndex = 24;
            // 
            // fioVRoditelnomTextBox
            // 
            this.fioVRoditelnomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "FioVRoditelnom", true));
            this.fioVRoditelnomTextBox.Location = new System.Drawing.Point(167, 317);
            this.fioVRoditelnomTextBox.Name = "fioVRoditelnomTextBox";
            this.fioVRoditelnomTextBox.Size = new System.Drawing.Size(200, 20);
            this.fioVRoditelnomTextBox.TabIndex = 22;
            // 
            // fioTextBox
            // 
            this.fioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Fio", true));
            this.fioTextBox.Location = new System.Drawing.Point(167, 291);
            this.fioTextBox.Name = "fioTextBox";
            this.fioTextBox.Size = new System.Drawing.Size(200, 20);
            this.fioTextBox.TabIndex = 20;
            // 
            // otchestvoTextBox
            // 
            this.otchestvoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Otchestvo", true));
            this.otchestvoTextBox.Location = new System.Drawing.Point(167, 265);
            this.otchestvoTextBox.Name = "otchestvoTextBox";
            this.otchestvoTextBox.Size = new System.Drawing.Size(200, 20);
            this.otchestvoTextBox.TabIndex = 18;
            // 
            // imjaTextBox
            // 
            this.imjaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Imja", true));
            this.imjaTextBox.Location = new System.Drawing.Point(167, 239);
            this.imjaTextBox.Name = "imjaTextBox";
            this.imjaTextBox.Size = new System.Drawing.Size(200, 20);
            this.imjaTextBox.TabIndex = 16;
            // 
            // familijaTextBox
            // 
            this.familijaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Familija", true));
            this.familijaTextBox.Location = new System.Drawing.Point(167, 213);
            this.familijaTextBox.Name = "familijaTextBox";
            this.familijaTextBox.Size = new System.Drawing.Size(200, 20);
            this.familijaTextBox.TabIndex = 14;
            // 
            // polTextBox
            // 
            this.polTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Pol", true));
            this.polTextBox.Location = new System.Drawing.Point(167, 187);
            this.polTextBox.Name = "polTextBox";
            this.polTextBox.Size = new System.Drawing.Size(200, 20);
            this.polTextBox.TabIndex = 12;
            // 
            // snilsTextBox
            // 
            this.snilsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Snils", true));
            this.snilsTextBox.Location = new System.Drawing.Point(167, 161);
            this.snilsTextBox.Name = "snilsTextBox";
            this.snilsTextBox.Size = new System.Drawing.Size(200, 20);
            this.snilsTextBox.TabIndex = 10;
            // 
            // innTextBox
            // 
            this.innTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Inn", true));
            this.innTextBox.Location = new System.Drawing.Point(167, 135);
            this.innTextBox.Name = "innTextBox";
            this.innTextBox.Size = new System.Drawing.Size(200, 20);
            this.innTextBox.TabIndex = 8;
            // 
            // tabNomerTextBox
            // 
            this.tabNomerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "TabNomer", true));
            this.tabNomerTextBox.Location = new System.Drawing.Point(167, 109);
            this.tabNomerTextBox.Name = "tabNomerTextBox";
            this.tabNomerTextBox.Size = new System.Drawing.Size(200, 20);
            this.tabNomerTextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 23);
            this.button1.TabIndex = 47;
            this.button1.Text = "Показать личную карточку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nazvanijeOrganizatsii_fkLabel
            // 
            nazvanijeOrganizatsii_fkLabel.AutoSize = true;
            nazvanijeOrganizatsii_fkLabel.Location = new System.Drawing.Point(35, 85);
            nazvanijeOrganizatsii_fkLabel.Name = "nazvanijeOrganizatsii_fkLabel";
            nazvanijeOrganizatsii_fkLabel.Size = new System.Drawing.Size(126, 13);
            nazvanijeOrganizatsii_fkLabel.TabIndex = 47;
            nazvanijeOrganizatsii_fkLabel.Text = "Nazvanije Organizatsii fk:";
            // 
            // nazvanijeOrganizatsii_fkTextBox
            // 
            this.nazvanijeOrganizatsii_fkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "NazvanijeOrganizatsii_fk", true));
            this.nazvanijeOrganizatsii_fkTextBox.Location = new System.Drawing.Point(167, 82);
            this.nazvanijeOrganizatsii_fkTextBox.Name = "nazvanijeOrganizatsii_fkTextBox";
            this.nazvanijeOrganizatsii_fkTextBox.Size = new System.Drawing.Size(200, 20);
            this.nazvanijeOrganizatsii_fkTextBox.TabIndex = 48;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 671);
            this.Controls.Add(nazvanijeOrganizatsii_fkLabel);
            this.Controls.Add(this.nazvanijeOrganizatsii_fkTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(tabNomerLabel);
            this.Controls.Add(this.tabNomerTextBox);
            this.Controls.Add(innLabel);
            this.Controls.Add(this.innTextBox);
            this.Controls.Add(snilsLabel);
            this.Controls.Add(this.snilsTextBox);
            this.Controls.Add(polLabel);
            this.Controls.Add(this.polTextBox);
            this.Controls.Add(familijaLabel);
            this.Controls.Add(this.familijaTextBox);
            this.Controls.Add(imjaLabel);
            this.Controls.Add(this.imjaTextBox);
            this.Controls.Add(otchestvoLabel);
            this.Controls.Add(this.otchestvoTextBox);
            this.Controls.Add(fioLabel);
            this.Controls.Add(this.fioTextBox);
            this.Controls.Add(fioVRoditelnomLabel);
            this.Controls.Add(this.fioVRoditelnomTextBox);
            this.Controls.Add(dataRozhdenijaLabel);
            this.Controls.Add(this.dataRozhdenijaDateTimePicker);
            this.Controls.Add(mestoRozhdenijaLabel);
            this.Controls.Add(this.mestoRozhdenijaTextBox);
            this.Controls.Add(grazhdanstvoLabel);
            this.Controls.Add(this.grazhdanstvoTextBox);
            this.Controls.Add(obrazovanijeLabel);
            this.Controls.Add(this.obrazovanijeTextBox);
            this.Controls.Add(professijaLabel);
            this.Controls.Add(this.professijaTextBox);
            this.Controls.Add(professijaDrugajaLabel);
            this.Controls.Add(this.professijaDrugajaTextBox);
            this.Controls.Add(dataNachalaRabotiLabel);
            this.Controls.Add(this.dataNachalaRabotiDateTimePicker);
            this.Controls.Add(kharakterRabotiLabel);
            this.Controls.Add(this.kharakterRabotiTextBox);
            this.Controls.Add(vidRabotiLabel);
            this.Controls.Add(this.vidRabotiTextBox);
            this.Controls.Add(nomerTDLabel);
            this.Controls.Add(this.nomerTDTextBox);
            this.Controls.Add(dataTDLabel);
            this.Controls.Add(this.dataTDDateTimePicker);
            this.Controls.Add(dataPrikazaOPriemeLabel);
            this.Controls.Add(this.dataPrikazaOPriemeDateTimePicker);
            this.Controls.Add(this.personalBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diploma_TestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingNavigator)).EndInit();
            this.personalBindingNavigator.ResumeLayout(false);
            this.personalBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Diploma_TestDataSet diploma_TestDataSet;
        private System.Windows.Forms.BindingSource personalBindingSource;
        private Diploma_TestDataSetTableAdapters.PersonalTableAdapter personalTableAdapter;
        private Diploma_TestDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator personalBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton personalBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker dataPrikazaOPriemeDateTimePicker;
        private System.Windows.Forms.DateTimePicker dataTDDateTimePicker;
        private System.Windows.Forms.TextBox nomerTDTextBox;
        private System.Windows.Forms.TextBox vidRabotiTextBox;
        private System.Windows.Forms.TextBox kharakterRabotiTextBox;
        private System.Windows.Forms.DateTimePicker dataNachalaRabotiDateTimePicker;
        private System.Windows.Forms.TextBox professijaDrugajaTextBox;
        private System.Windows.Forms.TextBox professijaTextBox;
        private System.Windows.Forms.TextBox obrazovanijeTextBox;
        private System.Windows.Forms.TextBox grazhdanstvoTextBox;
        private System.Windows.Forms.TextBox mestoRozhdenijaTextBox;
        private System.Windows.Forms.DateTimePicker dataRozhdenijaDateTimePicker;
        private System.Windows.Forms.TextBox fioVRoditelnomTextBox;
        private System.Windows.Forms.TextBox fioTextBox;
        private System.Windows.Forms.TextBox otchestvoTextBox;
        private System.Windows.Forms.TextBox imjaTextBox;
        private System.Windows.Forms.TextBox familijaTextBox;
        private System.Windows.Forms.TextBox polTextBox;
        private System.Windows.Forms.TextBox snilsTextBox;
        private System.Windows.Forms.TextBox innTextBox;
        private System.Windows.Forms.TextBox tabNomerTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nazvanijeOrganizatsii_fkTextBox;
    }
}

