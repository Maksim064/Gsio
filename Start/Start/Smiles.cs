using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Start
{
    public partial class Smiles : Form
    {
        public Smiles()
        {
            InitializeComponent();
        }

        private void Smile_Load(object sender, EventArgs e)
        {

        }
        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void picSmile_Click(object sender, EventArgs e)
        {
            picSmile.BorderStyle = BorderStyle.FixedSingle; // Рамка
            picSmile.BackColor = Color.Green;
            picFrown.BackColor = Control.DefaultBackColor;
            picHappy.BackColor = Control.DefaultBackColor;
            picFrown.BorderStyle = BorderStyle.None; // Нет рамки
            picHappy.BorderStyle = BorderStyle.None; // Нет рамки
            lblMessage.Text = "Щелкнули на первый рисунок";

        }

        private void picFrown_Click(object sender, System.EventArgs e)
        {
            picSmile.BorderStyle = BorderStyle.None; // Нет рамки
            picFrown.BorderStyle = BorderStyle.FixedSingle; // Рамка
            picFrown.BackColor = Color.Green;
            picSmile.BackColor = Control.DefaultBackColor;
            picHappy.BackColor = Control.DefaultBackColor;

            picHappy.BorderStyle = BorderStyle.None; // Нет рамки
            lblMessage.Text = "Щелкнули на второй рисунок";
        }

        private void picHappy_Click(object sender, System.EventArgs e)
        {
            picSmile.BorderStyle = BorderStyle.None; // Нет рамки
            picFrown.BorderStyle = BorderStyle.None; // Нет рамки
            picHappy.BorderStyle = BorderStyle.FixedSingle; // Рамка
            picHappy.BackColor = Color.Green;
            picSmile.BackColor = Control.DefaultBackColor;
            picFrown.BackColor = Control.DefaultBackColor;
            lblMessage.Text = "Щелкнули на третий рисунок";
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close(); // Закрыть форму
        }

        static void Main()
        {
            Application.Run(new Smiles());
        }

    }
}
