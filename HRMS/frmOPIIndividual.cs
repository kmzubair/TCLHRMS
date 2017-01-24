using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS
{
    public partial class frmOPIIndividual : Form
    {
        public frmOPIIndividual()
        {
            InitializeComponent();
        }

        private void frmOPIIndividual_Load(object sender, EventArgs e)
        {
            lstOPIAmount.View = View.Details;
            lstOPIAmount.GridLines = true;
            lstOPIAmount.FullRowSelect = true;

            ColumnHeader opiItem, opiFrom, opiTo, opiAmount;
            opiItem = new ColumnHeader();
            opiFrom = new ColumnHeader();
            opiTo = new ColumnHeader();
            opiAmount = new ColumnHeader();

            opiItem.Text = "OPI Item";
            opiItem.TextAlign = HorizontalAlignment.Left;
            opiItem.Width = 150;

            opiFrom.Text = "From";
            opiFrom.TextAlign = HorizontalAlignment.Center;
            opiFrom.Width = 70;

            opiTo.Text = "To";
            opiTo.TextAlign = HorizontalAlignment.Left;
            opiTo.Width = 70;

            opiAmount.Text = "Amount";
            opiAmount.TextAlign = HorizontalAlignment.Left;
            opiAmount.Width = 100;


            lstOPIAmount.Columns.Add(opiItem);
            lstOPIAmount.Columns.Add(opiFrom);
            lstOPIAmount.Columns.Add(opiTo);
            lstOPIAmount.Columns.Add(opiAmount);

        }
    }
}
