using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CS461_Access_Control
{
    public partial class frmAccessLog : Form
    {
        public frmAccessLog()
        {
            InitializeComponent();
        }

        public frmAccessLog(string[] info)
        {
            InitializeComponent();
            txtName.Text = info[1];
            txtTitle.Text = info[2];
            txtCompany.Text = info[3];
            buildTable(info[0]);
        }

        void buildTable(string id)
        {
            //Create data table
            DataTable dt = new DataTable();
            dt.Columns.Add("Access Time", typeof(String));
            dt.Columns.Add("Location", typeof(String));

            string filename = System.Environment.CurrentDirectory + "\\AccessTime.log";
            if (File.Exists(filename) == false)
            {
                //
                return;
            }

            try
            {
                StreamReader sr = new StreamReader(filename);
                sr.ReadLine();  //bypass 1st line. It defines field name.

                while(sr.EndOfStream == false)
                {
                    String str = sr.ReadLine();
                    string[] fields = str.Split(',');
                    if (id.Equals(fields[0]))
                    {
                        DataRow row = dt.NewRow();
                        if (fields.Length > 1) row[0] = fields[1];
                        if (fields.Length > 2) row[1] = fields[2];
                        dt.Rows.Add(row);
                    }
                }

                dgvTable.DataSource = dt;
                dgvTable.Columns[0].Width = 100;
                dgvTable.Columns[1].Width = 500;
            }
            catch
            {
                
            }


        }
   }
}