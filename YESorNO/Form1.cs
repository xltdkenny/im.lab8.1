using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YESorNO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(questionTextBox.Text)) { MessageBox.Show("Введите вопрос"); return;  }
            double p = 0.5;  // вероятность
            Random rand = new Random();
            bool result = rand.NextDouble() <= p;  // Генерация результата с вероятностью p
            
            resultTextBox.Clear();
            resultTextBox.AppendText(questionTextBox.Text + " - " + (result ? "Да" : "Нет") + "\r\n");
            questionTextBox.Clear();
        }
    }
}
