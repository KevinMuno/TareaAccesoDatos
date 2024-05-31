using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADONETMake
{
    public partial class frmMakes : Form
    {
        private readonly MakesRepository _makesRepository;
        public frmMakes()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            _makesRepository = new MakesRepository(connectionString);
            dgvMakes.SelectionChanged += dgvMakes_SelectionChanged;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var makes = new Makes
            {
                Name = txtName.Text
            };
            _makesRepository.Add(makes);
            LoadMakes();
        }

        private void LoadMakes()
        {
            dgvMakes.DataSource = _makesRepository.GetAll();

            if (dgvMakes.Columns.Contains("TimeStamp"))
            {
                dgvMakes.Columns["TimeStamp"].Visible = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvMakes.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvMakes.SelectedRows[0].Index;
                int id = Convert.ToInt32(dgvMakes.Rows[selectedRowIndex].Cells["ID"].Value);

                _makesRepository.Delete(id);
                LoadMakes();
            }
            else
            {
                MessageBox.Show("Porfavor, seleccione la fila a eliminar.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMakes.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvMakes.SelectedRows[0].Index;
                int id = Convert.ToInt32(dgvMakes.Rows[selectedRowIndex].Cells["ID"].Value);

                _makesRepository.Delete(id);
                LoadMakes();
            }
            else
            {
                MessageBox.Show("Porfavor, seleccione la fila a eliminar.");
            }
        }

        private void dgvMakes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMakes.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvMakes.SelectedRows[0].Index;
                txtID.Text = dgvMakes.Rows[selectedRowIndex].Cells["Id"].Value.ToString();
                txtName.Text = dgvMakes.Rows[selectedRowIndex].Cells["Name"].Value.ToString();
            }
        }

        private void frmMakes_Load(object sender, EventArgs e)
        {
            LoadMakes();
        }
    }
}
