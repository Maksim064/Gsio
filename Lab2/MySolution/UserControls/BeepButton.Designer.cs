﻿namespace MyCompany.UserControls
{
    partial class BeepButton
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
        }

        /*protected override void OnClick(EventArgs e)
        {
            // Проиграть системный звук
            SystemSounds.Exclamation.Play();// Сочный через внешние динамики
            //SystemSounds.Beep.Play(); // Простой через внешние динамики
//System.Console.Beep(); // Простой через внутренний динамик
// Подняться до базового класса Control,
// чтобы сгенерировать его событие Click и
// запустить наш будущий обработчик ButtonOnClick
            base.OnClick(e);
            #endregion
        }*/
    }
}
#endregion