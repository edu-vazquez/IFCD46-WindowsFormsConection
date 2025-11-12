using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsConection
{
    public partial class FormEJ06_extendido : Form
    {
        public FormEJ06_extendido()
        {
            InitializeComponent();
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            Jobs job = new Jobs(
                null,
                tbxJobTitle.Text,
                string.IsNullOrEmpty(tbxMinSalary.Text) ? (decimal?)null : decimal.Parse(tbxMinSalary.Text),
                string.IsNullOrEmpty(tbxMaxSalary.Text) ? (decimal?)null : decimal.Parse(tbxMaxSalary.Text)
            );

            try
            {

                DALJobWithConnection.Insertar(job, new DbConnect());
                ClearBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el registro: " + ex.Message);
            }
        }

        private void ClearBox()
        {
            tbxJobTitle.Clear();
            tbxMinSalary.Clear();
            tbxMaxSalary.Clear();
        }
    }
}
