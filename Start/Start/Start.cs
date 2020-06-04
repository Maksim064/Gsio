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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            string password = InputPassword.Show(
                "Окно аутентификации пользователя",
                "Просим ввести Ваш пароль:");
            if (password != "root") //Плохой способ хранения пароля
            {
                MessageBox.Show(
                    "Извните!\n" //Сообщеине
                    + "Доступ запрещен!!!",
                    "Ошибка аутентификации", //Заголовок окна
                    MessageBoxButtons.OK, //Кнопка ОК
                    MessageBoxIcon.Stop); //Критическая кнопка
                this.Close();
            }
        }

        private void generalList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(generalList.SelectedIndex + 1)
            {
                case 1:
                    Smiles frm1 = new Smiles();
                frm1.ShowDialog();
                break;
            }

        }
    }

}
