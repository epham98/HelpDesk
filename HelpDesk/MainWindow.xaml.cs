using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HelpDesk
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Help_Desk_Main_Window_Loaded(object sender, RoutedEventArgs e)
        {

            HelpDesk.TicketDatabaseDataSet ticketDatabaseDataSet = ((HelpDesk.TicketDatabaseDataSet)(this.FindResource("ticketDatabaseDataSet")));
            // Load data into the table Tickets. You can modify this code as needed.
            HelpDesk.TicketDatabaseDataSetTableAdapters.TicketsTableAdapter ticketDatabaseDataSetTicketsTableAdapter = new HelpDesk.TicketDatabaseDataSetTableAdapters.TicketsTableAdapter();
            ticketDatabaseDataSetTicketsTableAdapter.Fill(ticketDatabaseDataSet.Tickets);
            System.Windows.Data.CollectionViewSource ticketsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("ticketsViewSource")));
            ticketsViewSource.View.MoveCurrentToFirst();
        }

        //opens form to edit, add, and delete tickets
        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            ManageTicket manage = new ManageTicket();
            manage.ShowDialog();
            HelpDesk.TicketDatabaseDataSet ticketDatabaseDataSet = ((HelpDesk.TicketDatabaseDataSet)(this.FindResource("ticketDatabaseDataSet")));
            // Load data into the table Tickets. You can modify this code as needed.
            HelpDesk.TicketDatabaseDataSetTableAdapters.TicketsTableAdapter ticketDatabaseDataSetTicketsTableAdapter = new HelpDesk.TicketDatabaseDataSetTableAdapters.TicketsTableAdapter();
            ticketDatabaseDataSetTicketsTableAdapter.Fill(ticketDatabaseDataSet.Tickets);
        }

        // searches table of tickets by name of technician and whether they have resolved tickets. name must be exact
        private void searchTechButton_Click(object sender, RoutedEventArgs e)
        {
            HelpDesk.TicketDatabaseDataSet ticketDatabaseDataSet = ((HelpDesk.TicketDatabaseDataSet)(this.FindResource("ticketDatabaseDataSet")));
            // Load data into the table Tickets. You can modify this code as needed.
            HelpDesk.TicketDatabaseDataSetTableAdapters.TicketsTableAdapter ticketDatabaseDataSetTicketsTableAdapter = new HelpDesk.TicketDatabaseDataSetTableAdapters.TicketsTableAdapter();
            
            // loads resolved tickets by specific technician
            if (resolvedCheckBox.IsChecked == true)
            {
                ticketDatabaseDataSetTicketsTableAdapter.FillBySearchTechResolved(ticketDatabaseDataSet.Tickets, technicianSearchBox.Text);
            }
            // loads unresolved tickets by specific technicican
            else if (unresolvedCheckBox.IsChecked == true) 
            {
                ticketDatabaseDataSetTicketsTableAdapter.FillBySearchTechUnresolved(ticketDatabaseDataSet.Tickets, technicianSearchBox.Text);
            }
            // loads all resolved tickets
            else if (resolvedCheckBox.IsChecked == true && technicianSearchBox.Text == "")
            {
                ticketDatabaseDataSetTicketsTableAdapter.FillByResolved(ticketDatabaseDataSet.Tickets);
            }
            // loads all unresolved tickets
            else if (unresolvedCheckBox.IsChecked == true && technicianSearchBox.Text == "")
            {
                ticketDatabaseDataSetTicketsTableAdapter.FillByUnresolved(ticketDatabaseDataSet.Tickets);
            }
            else
            {
                ticketDatabaseDataSetTicketsTableAdapter.FillBySearchTech(ticketDatabaseDataSet.Tickets, technicianSearchBox.Text);
            }
        }

        // resets table
        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            HelpDesk.TicketDatabaseDataSet ticketDatabaseDataSet = ((HelpDesk.TicketDatabaseDataSet)(this.FindResource("ticketDatabaseDataSet")));
            // Load data into the table Tickets. You can modify this code as needed.
            HelpDesk.TicketDatabaseDataSetTableAdapters.TicketsTableAdapter ticketDatabaseDataSetTicketsTableAdapter = new HelpDesk.TicketDatabaseDataSetTableAdapters.TicketsTableAdapter();
            ticketDatabaseDataSetTicketsTableAdapter.Fill(ticketDatabaseDataSet.Tickets);
            technicianSearchBox.Text = String.Empty;
        }
    }
}
