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
            LoadData();

        }

        private void LoadData()
        {
            dgvInventory.DataSource = _inventoryRepository.GetAll().ToString();
        }

        private void dgvInventory_SelectionChanged(object? sender, EventArgs e)
        {
            int selectedRowIndex = dgvInventory.SelectedRows[0].Index;
            txtIDInventory.Text = dgvInventory.Rows[selectedRowIndex].Cells["ID"].Value.ToString();
            txtNameInv.Text = dgvInventory.Rows[selectedRowIndex].Cells["PETNAME"].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var inventory = new Inventory
            {
                MakeId = int.Parse(txtIDInventory.Text),
                PetName = txtNameInv.Text,
                Color = txtColor.Text
               
            };
            _inventoryRepository.Add(inventory);

            LoadData();
        }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIDInventory.Text);
            _inventoryRepository.Delete(id);
            LoadData();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var inventory = new Inventory
            {
                ID = int.Parse(txtIDInventory.Text),
                MakeId = int.Parse(txtMakeId.Text),
                Color = txtColor.Text,
                PetName = txtNameInv.Text
            };
            _inventoryRepository.Update(inventory);
            LoadData();
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            LoadData();

        }
    }
}
