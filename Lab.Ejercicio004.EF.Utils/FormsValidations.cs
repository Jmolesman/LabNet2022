using System.Windows.Forms;

namespace Lab.Ejercicio004.EF.Utils
{
    public static class FormsValidations
    {

        public static bool CheckFrmForOpenTwice(string name, Form parent)
        {
            foreach (Form ChildForm in parent.MdiChildren)
            {
                if (ChildForm.Name == name)
                {
                    ChildForm.Focus();
                    return true;

                }
            }
            return false;
        }
    }

}
