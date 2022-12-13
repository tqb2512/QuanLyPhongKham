using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Function.MainForm
{
    internal class MF_Functions
    {
        public void resizeAllTabPages(Size size)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form form in fc)
            {
                if (form.Name != "MF_MainForm")
                {
                    form.Size = size;
                }
            }
        }
    }
}
