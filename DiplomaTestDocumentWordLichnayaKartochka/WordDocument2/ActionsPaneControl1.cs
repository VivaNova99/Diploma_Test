using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Office = Microsoft.Office.Core;

namespace WordDocument2
{
    partial class ActionsPaneControl1 : UserControl
    {
        public ActionsPaneControl1()
        {
            InitializeComponent();
            // (Вера) Заполнение элемента управления данными, добавлено из руководства о привязке данных
            this.Load += new EventHandler(ActionsPaneControl1_Load);
        }

        private void personalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diploma_TestDataSet);

        }

        private void ActionsPaneControl1_Load(object sender, EventArgs e)
        {
            // (Вера) Установка свойств привязки данных элемента управления, добавлено из руководства о привязке данных к Экселю
            this.comboBox1.DataSource = Globals.ThisDocument.personalBindingSource;
            this.comboBox1.DisplayMember = "Fio";
        }

        private void fioComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Choose_Click(object sender, EventArgs e)
        {
            
        }
    }
}
