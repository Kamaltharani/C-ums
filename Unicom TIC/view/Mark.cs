using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unicom_TIC.view
{
    public partial class Mark : Form
    {
        public Mark()
        {
            InitializeComponent();
        }

        private void Mark_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtExamId.Text, txtSubjectId.Text, txtScore.Text);
            ClearFie1ds();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.CurrentRow.Cells[0].Value = txtExamID.Text;
                dataGridView1.CurrentRow.Cells[1].Value = txtSubjectId.Text;
                dataGridView1.CurrentRow.Cells[2].Value = txtScore.Text;

            }
        }
    }
}
