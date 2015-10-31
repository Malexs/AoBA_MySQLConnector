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

        private void openUserBtn_Click(object sender, EventArgs e)
        {
            UserForm uf = new UserForm();
            uf.Show();
        }

        private void addDepositeBtn_Click(object sender, EventArgs e)
        {
            AddDepoForm addDepoForm = new AddDepoForm(AddDepoForm.Type.Add);
            addDepoForm.ShowDialog();
        }

        private void depoUpdBtn_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm(SearchForm.Type.Agreements);
            sf.ShowDialog();
            AddDepoForm adf = new AddDepoForm(AddDepoForm.Type.Update);
            adf.SetUser(sf.Number);
        }
    }
}
