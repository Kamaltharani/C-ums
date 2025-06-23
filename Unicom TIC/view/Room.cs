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
    public partial class Room : Form
    {
        public Room()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(DataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.Remove(DataGridView1.Currentrow);
                ClearFie1ds();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtRoomName.Text, txtRoomType.Txet);
            ClearFie1ds();
        }

        private void btnUpdata_Click(object sender, EventArgs e)
        {
            if(DataGridView1.CurrentRow != null)
            {
                dataGridView1.CurrentRow.Cell[0].Value = txtRoomName.Text;
                dataGridView1.currentRow.Cell[1].Value = txtRoomType.Text;
                ClearFie1ds();
            }
        }
    }
}
