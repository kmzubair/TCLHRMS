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
    public partial class frmEarningDeductionApplied : Form
    {
        public frmEarningDeductionApplied()
        {
            InitializeComponent();
        }

        private void frmEarningDeductionApplied_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            ColumnHeader ed, from, to, amount;
            ed = new ColumnHeader();
            from = new ColumnHeader();
            to = new ColumnHeader();
            amount = new ColumnHeader();

            ed.Text = "Earning/Deduction";
            ed.TextAlign = HorizontalAlignment.Left;
            ed.Width = 200;

            from.Text = "From";
            from.TextAlign = HorizontalAlignment.Center;
            from.Width = 70;

            to.Text = "To";
            to.TextAlign = HorizontalAlignment.Left ;
            to.Width = 70;

            amount.Text = "Amount";
            amount.TextAlign = HorizontalAlignment.Right;
            amount.Width = 100;


            listView1.Columns.Add(ed);
            listView1.Columns.Add(from);
            listView1.Columns.Add(to);
            listView1.Columns.Add(amount);

            /////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////

            //string[] arr = new string[3];
            //ListViewItem itm;

            ////Add first item
            //arr[0] = "001";
            //arr[1] = "Accounts";
            //arr[2] = "Active";
            //itm = new ListViewItem(arr);
            //listView1.Items.Add(itm);

            ////Add second item
            //arr[0] = "002";
            //arr[1] = "Production";
            //arr[2] = "Active";
            //itm = new ListViewItem(arr);
            //listView1.Items.Add(itm);

            ////Add third item
            //arr[0] = "003";
            //arr[1] = "QC";
            //arr[2] = "Active";
            //itm = new ListViewItem(arr);
            //listView1.Items.Add(itm);


            /////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////

        }
    }
}
