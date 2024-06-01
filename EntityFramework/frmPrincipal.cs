using EntityFramework.CreditRisks;
using EntityFramework.Customers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            frmCustomers frmCustomers = new frmCustomers();
            frmCustomers.ShowDialog();
        }

        private void btnCreditRisks_Click(object sender, EventArgs e)
        {
           frmCreditRisks frmCreditRisks = new frmCreditRisks();
            frmCreditRisks.ShowDialog();
        }
    }
}
