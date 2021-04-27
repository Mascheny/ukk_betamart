using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace betamart
{
    public partial class BetaMart : Form
    {
        public BetaMart()
        {
            InitializeComponent();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(txtCari.Text))
                {
                    this.barangTableAdapter.Fill(this.appData.Barang);
                    barangBindingSource.DataSource = this.appData.Barang;
                    //dataGridView.DataSource = barangBindingSource;
                }
                else
                {
                    var query = from o in this.appData.Barang
                                where o.NamaBarang.Contains(txtCari.Text)
                                select o;
                    barangBindingSource.DataSource = query.ToList();
                    //dataGridView.DataSource = query.ToList();

                }
            }
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete
                ) 
            {
                if (MessageBox.Show("Hapus Data ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    barangBindingSource.RemoveCurrent();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Enabled = true;
                txtNama.Focus();
                this.appData.Barang.AddBarangRow(this.appData.Barang.NewBarangRow());
                barangBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                barangBindingSource.ResetBindings(false);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            txtNama.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            barangBindingSource.ResetBindings(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                barangBindingSource.EndEdit();
                barangTableAdapter.Update(this.appData.Barang);
                panel1.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                barangBindingSource.ResetBindings(false);
            }
        }

        private void BetaMart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.Barang' table. You can move, or remove it, as needed.
            this.barangTableAdapter.Fill(this.appData.Barang);
            barangBindingSource.DataSource = this.appData.Barang;

        }
    }
}
