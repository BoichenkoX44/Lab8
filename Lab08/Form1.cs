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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            Litak litak = new Litak();
            fLitak ft = new fLitak(litak);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                tbPhonesInfo.Text +=
                string.Format("Фірма: {0} | Назва: {1} | Кількість місць: {2} | Швидкість {3} | Масса: {4}|  [{5} | {6}] | ",
                litak.Firm, litak.Name, litak.Kilkist_misc,
                litak.Shvidkist, litak.Masa,
                litak.Has_free_mode ? "Мае беспілотний режим" : "Немае безпілотноо режиму",
                litak.Type ? "Військовий" : "Для утворення перельотів");
                
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?",
           "Припинити роботу", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }

        private void tbPhonesInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void fMain_Click(object sender, EventArgs e)
        {

        }
    }
}
