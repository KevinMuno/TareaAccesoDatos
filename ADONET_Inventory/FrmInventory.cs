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
using System.Xml.Linq;

namespace ADONET_Inventory
{
    public partial class FrmInventory : Form
    {
        private readonly InventoryRepository _inventoryRepository;
        public FrmInventory()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            _inventoryRepository = new InventoryRepository(connectionString);
            dgvInventory.SelectionChanged += dgvInventory_SelectionChanged;
        }

        private void dgvInventory_SelectionChanged(object? sender, EventArgs e)
        {
            int selectedRowIndex = dgvInventory.SelectedRows[0].Index;
            txtIDInventory.Text = dgvInventory.Rows[selectedRowIndex].Cells["ID"].Value.ToString();
            txtNameInv.Text = dgvInventory.Rows[selectedRowIndex].Cells["NAME"].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var inventory = new Inventory
            {
                PetName = txtNameInv.Text,
            };
            _inventoryRepository.Add(inventory);

            LoadInventory();
        }

        private void LoadInventory()
        {
            dgvInventory.DataSource = _inventoryRepository.GetAll();

            if (dgvInventory.Columns.Contains("TimeStamp"))
            {
                dgvInventory.Columns["TimeStamp"].Visible = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvInventory.SelectedRows[0].Index;
                int id = Convert.ToInt32(dgvInventory.Rows[selectedRowIndex].Cells["ID"].Value);

                _inventoryRepository.Delete(id);
                LoadInventory();
            }
            else
            {
                MessageBox.Show("Porfavor, seleccione la fila a eliminar.");
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvInventory.SelectedRows[0].Index;
                int id = Convert.ToInt32(dgvInventory.Rows[selectedRowIndex].Cells["ID"].Value);

                _inventoryRepository.Delete(id);
                LoadInventory();
            }
            else
            {
                MessageBox.Show("Porfavor, seleccione la fila a eliminar.");
            }
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            LoadInventory(); 

        }
    }
}
