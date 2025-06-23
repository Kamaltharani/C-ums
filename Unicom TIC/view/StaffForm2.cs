using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom_TIC.CONTROLLER;
using Unicom_TIC.MADELS;

namespace Unicom_TIC.view
{
    public partial class StaffForm2 : Form
    {
        private object txtPosition;
        private object txtContact;
        private object controller;

        public StaffForm2()
        {
            InitializeComponent();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff
            {
                Name = txtName.Text,
                Position = txtPosition.Text,
                Contact = txtContact.Text
            };
            object value = controller.Add(staff);
            LoadData();
        }

        private void LoadData()
        {
            throw new NotImplementedException();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Staff staff = new Staff
                {
                    StaffId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["StaffId"].Value),
                    Name = txtName.Text,
                    Position = txtPosition.Text,
                    Contact = txtContact.Text
                };
                controller.Update(staff);
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["StaffId"].Value);
                controller.Delete(id);
                LoadData();
            }
        }
    }
}
