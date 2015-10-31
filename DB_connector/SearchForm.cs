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

        UserForm parent = null;
        Int32 num;
        public Int32 Number { get { return num; } }
        Type type;

        public enum Type
        {
            Users,
            Agreements,
        };

        public SearchForm(Type _type)
        {
            InitializeComponent();
            if (_type == Type.Agreements)
            {
                fnameLabel.Visible = false;
                fnameTBox.Visible = false;
                snameLabel.Text = "Agreement number";
                fathNameLabel.Visible = false;
                fatNameTBox.Visible = false;
            }
            type = _type;
        }

        public void SaveParent(UserForm parent)
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
                if (type == Type.Users)
                    parent.ShowSearch(connector.SelectInformation(fnameTBox.Text.Trim(),
                        snameTBox.Text.Trim(), fatNameTBox.Text.Trim()));
                else
                    if (snameTBox.Text.Length>0)
                        if (!Int32.TryParse(snameTBox.Text, out num))
                            num = 0;
            }
            this.Close();
        }
    }
}
