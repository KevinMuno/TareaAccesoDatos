
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

namespace ADONET
{
    public partial class frmMakes : Form
    {
        private readonly MakesRepository _makesRepository;
        public frmMakes()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            _makesRepository = new MakesRepository(connectionString);
            LoadMakes();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var makes = new Makes
            {
                Name = txtName.Text
            };
            _makesRepository.Add(makes);
            LoadMakes();
        }

        //Cargando los que estan en la tabla Makes en el DataGrid
        private void LoadMakes()
        {
            dgvMakes.DataSource = _makesRepository.GetAll();

            if (dgvMakes.Columns.Contains("TimeStamp"))
            {
                dgvMakes.Columns["TimeStamp"].Visible = false;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var makes = new Makes
            {
                Id = int.Parse(txtId.Text),
                Name = txtName.Text
            };
            _makesRepository.Update(makes);
            LoadMakes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMakes.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvMakes.SelectedRows[0].Index;
                int id = Convert.ToInt32(dgvMakes.Rows[selectedRowIndex].Cells["Id"].Value);

                _makesRepository.Delete(id);
                LoadMakes();
            }
            else
            {
                MessageBox.Show("Porfavor, seleccione la fila a eliminar.");
            }
        }

        //Evento para cuando al darle click a una fila los datos que estan en el DataGrid aparezcan
        //en los textbox para una facil interaccion
        private void dgvMakes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMakes.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvMakes.SelectedRows[0].Index;
                txtId.Text = dgvMakes.Rows[selectedRowIndex].Cells["Id"].Value.ToString();
                txtName.Text = dgvMakes.Rows[selectedRowIndex].Cells["Name"].Value.ToString();
            }
        }

        
    }
}
