using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MyCompany.UserControls
{
    public class MyDialogBox
    {
        public static DialogResult Show(string strMessage, string strCaption)
        {
            MyDialogForm frm = new MyDialogForm();
            frm.Text = strCaption;
            frm.lblMessage.Text = strMessage;
            return frm.ShowDialog();                        
        }
    }
}
