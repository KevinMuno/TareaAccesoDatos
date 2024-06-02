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

namespace InventoryADONET
{
    public partial class frmInventory : Form
    {
        private readonly InventoryRepository _inventoryRepository;
        public frmInventory()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["constringI"].ConnectionString;
            _inventoryRepository = new InventoryRepository(connectionString);
            dgvInventory.SelectionChanged += dgvInventory_SelectionChanged;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var inventory = new Inventory
            {
                MakeId = int.Parse(txtMakeId.Text),
                Color = txtColor.Text,
                PetName = txtPetName.Text
            };
            _inventoryRepository.Add(inventory);
            LoadData();
        }

        private void LoadData()
        {
            dgvInventory.DataSource = _inventoryRepository.GetAll();

            if (dgvInventory.Columns.Contains("TimeStamp"))
            {
                dgvInventory.Columns["TimeStamp"].Visible = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var inventory = new Inventory
            {
                Id = int.Parse(txtID.Text),
                MakeId = int.Parse(txtMakeId.Text),
                Color = txtColor.Text,
                PetName = txtPetName.Text
            };
            _inventoryRepository.Update(inventory);
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvInventory.SelectedRows[0].Index;
                int id = Convert.ToInt32(dgvInventory.Rows[selectedRowIndex].Cells["Id"].Value);

                _inventoryRepository.Delete(id);
                LoadData();
            }
            else
            {
                MessageBox.Show("Porfavor, seleccione la fila a eliminar.");
            }
        }

        private void dgvInventory_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvInventory.SelectedRows[0].Index;
                txtID.Text = dgvInventory.Rows[selectedRowIndex].Cells["Id"].Value.ToString();
                txtMakeId.Text = dgvInventory.Rows[selectedRowIndex].Cells["MakeId"].Value.ToString();
                txtColor.Text = dgvInventory.Rows[selectedRowIndex].Cells["Color"].Value.ToString();
                txtPetName.Text = dgvInventory.Rows[selectedRowIndex].Cells["PetName"].Value.ToString();
            }
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtColor.Clear();
            txtID.Clear();
            txtMakeId.Clear();
            txtPetName.Clear();
            txtMakeId.Focus();
        }
    }
}
