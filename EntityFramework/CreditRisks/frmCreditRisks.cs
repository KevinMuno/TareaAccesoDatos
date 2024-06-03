using EntityFramework.Data;
using EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework.CreditRisks
{
    public partial class frmCreditRisks : Form
    {
        private AutoLotContext _context;

        public frmCreditRisks()
        {
            InitializeComponent();
            _context = new AutoLotContext();
            LoadCreditRisks();
        }

        //Metodo para cargar las personas que estan en CreditRisks en el DataGrid
        private void LoadCreditRisks()
        {
            try
            {
                dgvCreditRisks.DataSource = _context.CreditRisks.ToList();
                EsconderColumnas();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al cargar los que estan en CreditRisk: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void EsconderColumnas()
        {
            //Escondiendo Columnas TimeStamp y Customers ya que daban problema al correr el programa y cargar el DataGrid
            if (dgvCreditRisks.Columns.Contains("TimeStamp"))
            {
                dgvCreditRisks.Columns["TimeStamp"].Visible = false;
            }
            if (dgvCreditRisks.Columns.Contains("Customer"))
            {
                dgvCreditRisks.Columns["Customer"].Visible = false;
            }
        }

        // Agredando persona a CreditRisks
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var creditRisk = new CreditRisk
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    CustomerId = Convert.ToInt32(txtCustomerId.Text),
                };
                _context.CreditRisks.Add(creditRisk);
                _context.SaveChanges();
                LoadCreditRisks();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al agregar en CreditRisk: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Actualizando cambios que se realize en una persona que este en CreditRisks
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCreditRisks.SelectedRows.Count > 0)
                {
                    int id = (int)dgvCreditRisks.SelectedRows[0].Cells[0].Value;
                    var creditRisk = _context.CreditRisks.Find(id);
                    if (creditRisk != null)
                    {
                        creditRisk.FirstName = txtFirstName.Text;
                        creditRisk.LastName = txtLastName.Text;
                        creditRisk.CustomerId = Convert.ToInt32(txtCustomerId.Text);
                        _context.SaveChanges();
                        LoadCreditRisks();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al actualizar en CreditRisk: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Eliminando una persona que este en CreditRisks
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCreditRisks.SelectedRows.Count > 0)
                {
                    int id = (int)dgvCreditRisks.SelectedRows[0].Cells[0].Value;
                    var creditRisk = _context.CreditRisks.Find(id);
                    if (creditRisk != null)
                    {
                        _context.CreditRisks.Remove(creditRisk);
                        _context.SaveChanges();
                        LoadCreditRisks();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al eliminar en CreditRisk: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Evento para que al momento de darle click a una fila aparezcan los datos en los textbox y sea mas facil la interaccion
        private void dgvCreditRisks_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvCreditRisks.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dgvCreditRisks.SelectedRows[0].Cells[0].Value);
                    var creditRisk = _context.CreditRisks.Find(id);
                    if (creditRisk != null)
                    {
                        txtFirstName.Text = creditRisk.FirstName;
                        txtLastName.Text = creditRisk.LastName;
                        txtCustomerId.Text = creditRisk.CustomerId.ToString();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al seleccionar a alguien de CreditRisk: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCustomerId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
        }
    }
}
