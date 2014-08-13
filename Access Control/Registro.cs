using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CSL;
using System.Net;
using CS461_Access_Control;


namespace CS461_Access_Control
{
    public partial class Registro : Form
    {
        CS461_HL_API reader = new CS461_HL_API();
        TrustedServer server = new TrustedServer();
        Object guiLock = new Object();
        DataTable UserInfoTable = new DataTable();
        public Registro()
        {
            InitializeComponent();
        }
        delegate void update_UserInfo_Delegate(string id);

        private void update_UserInfo(string id)
        {
            if (InvokeRequired)
            {
                update_UserInfo_Delegate task = new update_UserInfo_Delegate(update_UserInfo);
                BeginInvoke(task, new object[] { id });
            }
            else
            {
                lock (guiLock)
                {
                    if (txtID.Text.Equals(id) == false)
                    {
                        reader.saveToLogInfo(String.Format("{0}, {1}", txtID.Text, id));
                        DataRow[] rows = UserInfoTable.Select(String.Format("ID = '{0}'", id));

                        if (rows.Length > 0)
                        {
                        
                            string time = String.Format("{0} {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString());
                            
                            txtID.Text = rows[0].ItemArray[0].ToString();
                           
                            try
                            {
                             
                            }
                            catch
                            {
                               
                            }
                            
                            try
                            {
                                
                            }
                            catch
                            {
                               
                            }

                          
                        }
                        else
                        {
                           
                            txtID.Text = id;
                            
                            try
                            {
                               
                            }
                            catch
                            {
                            }
                            
                        }
                    }
                    else
                    {
                        
                    }
                }
            }
        }

        private void startReadTags()
        {
            

            reader.purgeAllTags();

            server.Start();
        }

        private void stopReadTags()
        {
            

            server.Stop();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (btnRead.Text == "Pause")
                stopReadTags();
            else
                startReadTags();
        }

    }
}
