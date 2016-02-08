using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomaTestWindowsForms
{
    //(Лиза) Открывающая форма
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Переход к заполнению
        private void toForm1_Click(object sender, EventArgs e)
        {   
            AddForm firstForm = new AddForm();
            firstForm.Show();
            this.Hide();
        }
        // Выход
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
