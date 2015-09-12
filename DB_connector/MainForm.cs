using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bank_Assistant
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddInfoBtn_Click(object sender, EventArgs e)
        {
            AddForm af = new AddForm();
            af.Show();
        }

        private void ShowInfoBtn_Click(object sender, EventArgs e)
        {
            using (MySQLConnector msc = new MySQLConnector())
            {
                try
                {
                    InfoDataGrid.DataSource = msc.GetInformation();
                    InfoDataGrid.Columns[0].Visible = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void UpdBtn_Click(object sender, EventArgs e)
        {
            using (MySQLConnector msc = new MySQLConnector())
            {
                MessageBox.Show(msc.UpdateInfo());
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            using (MySQLConnector msc = new MySQLConnector())
            {
                MessageBox.Show(msc.DeleteInfo());
            }
        }
    }
}
