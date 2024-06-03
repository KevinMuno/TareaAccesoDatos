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
    public partial class frmInventory : Form
    {
        private readonly InventoryRepository _inventoryRepository;

        public frmInventory()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            _inventoryRepository = new InventoryRepository(connectionString);
            LoadInventory();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var inventory = new Inventory
            {
                MakeId = int.Parse(txtMakeId.Text),
                Color = txtColor.Text,
                PetName = txtPetName.Text
            };
            _inventoryRepository.Add(inventory);
            LoadInventory();
        }

        //Cargando los que estan en la tabla Inventory en el DataGrid
        private void LoadInventory()
        {
            dgvInventory.DataSource = _inventoryRepository.GetAll();

            if (dgvInventory.Columns.Contains("TimeStamp"))
            {
                dgvInventory.Columns["TimeStamp"].Visible = false;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var inventory = new Inventory
            {
                MakeId = int.Parse(txtMakeId.Text),
                Color = txtColor.Text,
                PetName = txtPetName.Text
            };
            _inventoryRepository.Update(inventory);
            LoadInventory();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvInventory.SelectedRows[0].Index;
                int id = Convert.ToInt32(dgvInventory.Rows[selectedRowIndex].Cells["Id"].Value);

                _inventoryRepository.Delete(id);
                LoadInventory();
            }
            else
            {
                MessageBox.Show("Porfavor, seleccione la fila a eliminar.");
            }
        }

        //Evento para cuando al darle click a una fila los datos que estan en el DataGrid aparezcan
        //en los textbox para una facil interaccion
        private void dgvInventory_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvInventory.SelectedRows[0].Index;
                txtMakeId.Text = dgvInventory.Rows[selectedRowIndex].Cells["MakeId"].Value.ToString();
                txtColor.Text = dgvInventory.Rows[selectedRowIndex].Cells["Color"].Value.ToString();
                txtPetName.Text = dgvInventory.Rows[selectedRowIndex].Cells["PetName"].Value.ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMakeId.Clear();
            txtColor.Clear();
            txtPetName.Clear();
        }
    }
}
