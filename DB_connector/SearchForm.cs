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
    public partial class SearchForm : Form
    {

        MainForm parent = null;

        public SearchForm()
        {
            InitializeComponent();
        }

        public void SaveParent(MainForm parent)
        {
            this.parent = parent;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void srchBtn_Click(object sender, EventArgs e)
        {
            using (MySQLConnector connector = new MySQLConnector())
            {
                parent.ShowSearch(connector.SelectInformation(fnameTBox.Text.Trim(),
                    snameTBox.Text.Trim(),fatNameTBox.Text.Trim()));
            }
            this.Close();
        }
    }
}
