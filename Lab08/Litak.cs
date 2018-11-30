using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab08
{
    public partial class fLitak : Form
    {
        private Litak TheLitak;
        internal fLitak(Litak t)
        {
            TheLitak = t;
            InitializeComponent();
        }
        
        private void btnOk_Click(object sender, EventArgs e)
        {
            TheLitak.Firm = tbFirm.Text.Trim();
            TheLitak.Name = tbName.Text.Trim();
            TheLitak.Kilkist_misc = int.Parse(tbKilkist_misc.Text.Trim());
            TheLitak.Shvidkist = double.Parse(tbShvidkist.Text.Trim());
            TheLitak.Masa = int.Parse(tbMasa.Text.Trim());
            TheLitak.Has_free_mode = chbHas_free_mode.Checked;
            TheLitak.Type = chbType.Checked;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void fLitak_Load(object sender, EventArgs e)
        {
            if (TheLitak != null)
            {
                tbFirm.Text = TheLitak.Firm;
                tbName.Text = TheLitak.Name;
                tbKilkist_misc.Text = TheLitak.Kilkist_misc.ToString();
                tbShvidkist.Text = TheLitak.Shvidkist.ToString();
                tbMasa.Text = TheLitak.Masa.ToString();
                chbHas_free_mode.Checked = TheLitak.Has_free_mode;
                chbType.Checked = TheLitak.Type;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void fLitak_Click(object sender, EventArgs e)
        {

        }
    }
}
