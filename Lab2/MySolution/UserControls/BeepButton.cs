using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Media;


namespace MyCompany.UserControls
{
    public partial class BeepButton : Button
    {
        public BeepButton()
        {
            InitializeComponent();
        }

        public BeepButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }

    partial class BeepButton
    {
        // Переопределяем виртуальный метод диспетчеризации
        // класса Control (задействуется наследуемый метод
        // диспетчеризации класса кнопки)
        protected override void OnClick(EventArgs e)
        {
            //base.OnClick(e);
            // Проиграть системный звук
            SystemSounds.Exclamation.Play();// Сочный через внешние динамики
            base.OnClick(e);
        }
    }
}
