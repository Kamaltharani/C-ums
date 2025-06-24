using System;
using System.Windows.Forms;
using Unicom_TIC.CONTROLLER;
using Unicom_TIC.MODELS;

namespace Unicom_TIC.view
{
    public partial class StaffForm2 : Form
    {
        private StaffController controller = new StaffController(); // ✅ Use correct type

        public StaffForm2()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            dataGridView2.DataSource = controller.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff
            {
                Name = textBoxName.Text,
                Position = textBoxPosition.Text,
                 Contact = textBoxContact.Text
            };
            controller.Add(staff); // ✅ No need for 'object value ='
            LoadData();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Staff staff = new Staff
                {
                    StaffId = Convert.ToInt32(dataGridView2.CurrentRow.Cells["StaffId"].Value),
                    Name = textBoxName.Text,
                    Position = textBoxPosition.Text,
                    Contact = textBoxContact.Text
                };
                controller.Update(staff);
                LoadData();
                ClearFields();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView2.CurrentRow.Cells["StaffId"].Value);
                controller.Delete(id);
                LoadData();
                ClearFields();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                textBoxName.Text = row.Cells["Name"].Value?.ToString();
                textBoxPosition.Text = row.Cells["Position"].Value?.ToString();
                textBoxContact.Text = row.Cells["Contact"].Value?.ToString();
            }
        }

        private void ClearFields()
        {
            textBoxName.Clear();
            textBoxPosition.Clear();
            textBoxContact.Clear();
        }
    }
}
