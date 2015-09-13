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
                    InfoDataGrid.DataSource = msc.SelectInformation();
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
            Int32 i = InfoDataGrid.CurrentRow.Index;
            String selectedString = InfoDataGrid[0, i].Value.ToString();//if (InfoDataGrid.)
            Console.WriteLine(selectedString);
            using (MySQLConnector msc = new MySQLConnector())
            {
                MessageBox.Show(msc.DeleteInfo(selectedString));
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.SaveParent(this);
            searchForm.Show();
        }

        public void ShowSearch(DataTable table)
        {
            InfoDataGrid.DataSource = table;
            InfoDataGrid.Columns[0].Visible = false;
        }
    }
}
