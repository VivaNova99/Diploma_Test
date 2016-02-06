using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Office.Tools.Word;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Office = Microsoft.Office.Core;
using Word = Microsoft.Office.Interop.Word;

namespace WordDocument2
{
    public partial class ThisDocument
    {
        // (Вера) Отображение панели действий, добавлено из руководства о привязке данных
        private ActionsPaneControl1 actions = new ActionsPaneControl1();
        
        private void ThisDocument_Startup(object sender, System.EventArgs e)
        {
            // TODO: удалите эту строку кода, чтобы удалить AutoFill по умолчанию для ''diploma_TestDataSet.Personal''.
            if (this.NeedsFill("diploma_TestDataSet"))
            {
                this.personalTableAdapter.Fill(this.diploma_TestDataSet.Personal);
                // (Вера) Отображение панели действий, добавлено из руководства о привязке данных
                this.ActionsPane.Controls.Add(actions);
            }
        }

        private void ThisDocument_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region Код, созданный конструктором VSTO

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(this.ThisDocument_Startup);
            this.Shutdown += new System.EventHandler(this.ThisDocument_Shutdown);

        }

        #endregion
    }
}
