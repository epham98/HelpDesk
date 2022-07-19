using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpDesk
{
    public partial class ManageTicket : Form
    {
        public ManageTicket()
        {
            InitializeComponent();
        }

        private void ticketsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ticketsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ticketDatabaseDataSet);

        }

        private void ManageTicket_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ticketDatabaseDataSet.Tickets' table. You can move, or remove it, as needed.
            this.ticketsTableAdapter.Fill(this.ticketDatabaseDataSet.Tickets);

        }
    }
}
