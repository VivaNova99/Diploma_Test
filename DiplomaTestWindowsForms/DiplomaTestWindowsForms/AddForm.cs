using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomaTestWindowsForms
{
    public partial class AddForm : Form
    {
        // (Лиза) Строка меню
        private MainMenu menu; // главное меню
        public AddForm()
        {
            InitializeComponent();
            this.AutoScroll = true;
            menu = new MainMenu(); //создание 
            MenuItem mFile = menu.MenuItems.Add("Окно");
            mFile.MenuItems.Add(new MenuItem("Выйти",
               new EventHandler(this.fileExit_Click), Shortcut.CtrlX));
            mFile.MenuItems.Add(new MenuItem("Сохранить",
                new EventHandler(this.fileSave_Click), Shortcut.CtrlS));
            mFile.MenuItems.Add(new MenuItem("Основное меню",
                new EventHandler(this.fileMainMenu_Click), Shortcut.CtrlM));
            this.Menu = menu;
            //mFile.MenuItems.Add(new MenuItem("")
            //this.Menu = menu;this.BackgroundImage = new Bitmap(@"C:\Users\Liza\Documents\Diploma_Test\background");
            
        }

        private void fileExit_Click(object sender, EventArgs e)
        {
            this.Close();		// Выход из приложения
        }

        private void fileSave_Click(object sender, EventArgs e)
        {
            //this.Close();		// Сохранение в документ
        }

        private void fileMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void personalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diploma_TestDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diploma_TestDataSet.Kodi_OKIN_Grazhdanstvo". При необходимости она может быть перемещена или удалена.
            this.kodi_OKIN_GrazhdanstvoTableAdapter.Fill(this.diploma_TestDataSet.Kodi_OKIN_Grazhdanstvo);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diploma_TestDataSet.Personal". При необходимости она может быть перемещена или удалена.
            this.personalTableAdapter.Fill(this.diploma_TestDataSet.Personal);
        }

        //private void nazvanijeOrganizatsii_fkTextBox_TextChanged(object sender, EventArgs e)
        //{
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            // (Вера) Открытие файла, сгенерированного отдельно
            Process.Start(@"C:\Users\Liza\Documents\Diploma_Test\LichnayaKartochkaRabotnika.docx");
        }
        // (Лиза) Подсветка нажатой клавиши
        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;   
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Bisque;
        }

        // (Лиза) Ограничения на ввод 
        private void snilsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
            snilsTextBox.MaxLength = 12;
        }

        private void innTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
        }
    }
}

