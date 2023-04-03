using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bars1
{
    public partial class Btn_add : UserControl
    {
        public Btn_add()
        {
            InitializeComponent();
        }

        public static Delegate Del_re;

        public void btn_add_ro_Click(object sender, EventArgs e)
        {
                Invoke((Action)(() =>
                {
                    Del_re.DynamicInvoke();
                }));
        }
    }
}
