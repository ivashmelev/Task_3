using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Task_3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string fileName = tb_nameFile.Text;
            string location = tb_location.Text;
            string text = rhtb_field.Text;
            File.WriteAllText($@"{location}\{fileName}.txt", text);
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            string fileName = tb_nameFile.Text;
            string location = tb_location.Text;
            StreamReader txtRead = new StreamReader($@"{location}\{fileName}.txt");
            
            string text = txtRead.ReadToEnd();
            rhtb_field.Text = text;
        }
    }
}
