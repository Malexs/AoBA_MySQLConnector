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
    public partial class AddForm : Form
    {

        MainForm parent = null;
        Int32 stage = 0;
        String[] Info = new String[24];

        public AddForm()
        {
            InitializeComponent();
        }

        public void ValidateParent(MainForm arg)
        {
            parent = arg;
        }

        private void nextPageBtn_Click(object sender, EventArgs e)
        {
            switch (stage)
            {
                case 0:
                    infoGBox.Visible = false;
                    birthGBox.Visible = true;
                    stage++;
                    break;
                case 1:
                    birthGBox.Visible = false;
                    passportGBox.Visible = true;
                    stage++;
                    break;
                case 2:
                    passportGBox.Visible = false;
                    addrGBox.Visible = true;
                    stage++;
                    break;
                case 3:
                    addrGBox.Visible = false;
                    contactsGBox.Visible = true;
                    stage++;
                    break;
                case 4:
                    contactsGBox.Visible = false;
                    workGBox.Visible = true;
                    stage++;
                    break;
                case 5:
                    workGBox.Visible = false;
                    socialGBox.Visible = true;
                    stage++;
                    break;
                case 6:
                    //SaveInfo();
                    this.Close();
                    break;
                default:
                    MessageBox.Show("WTF!?");
                    break;
            }
        }

        private void SaveInfo()
        {
            using (MySQLConnector msc = new MySQLConnector())
            {
                //String[] str = new String[] { "Alex", "Marshin", "Sergeevich", "1995-01-20", "M", "Minsk" };
                msc.AddInformation(Info);
            }
        }

        private void dateBox_Enter(object sender, EventArgs e)
        {
            if (sender == bdayBox)
            {
                if (bdayBox.Text.Equals("yyyy-MM-dd"))
                {
                    bdayBox.ForeColor = Color.Black;
                    bdayBox.Clear();
                }
            }
            else if (sender == issueTBox)
            {
                if (issueTBox.Text.Equals("yyyy-MM-dd"))
                {
                    issueTBox.ForeColor = Color.Black;
                    issueTBox.Clear();
                }
            }
        }

        private void dateBox_Leave(object sender, EventArgs e)
        {
            if (sender == bdayBox)
            {
                if (bdayBox.Text.Equals(""))
                {
                    bdayBox.ForeColor = Color.Gray;
                    bdayBox.Text = "yyyy-MM-dd";
                }
            }
            else if (sender == issueTBox)
            {
                if (issueTBox.Text.Equals(""))
                {
                    issueTBox.ForeColor = Color.Gray;
                    issueTBox.Text = "yyyy-MM-dd";
                }
            }
            
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            switch (stage)
            {
                case 0:
                    break;
                case 1:
                    infoGBox.Visible = true;
                    birthGBox.Visible = false;
                    stage--;
                    break;
                case 2:
                    birthGBox.Visible = true;
                    passportGBox.Visible = false;
                    stage--;
                    break;
                case 3:
                    passportGBox.Visible = true;
                    addrGBox.Visible = false;
                    stage--;
                    break;
                case 4:
                    addrGBox.Visible = true;
                    contactsGBox.Visible = false;
                    stage--;
                    break;
                case 5:
                    contactsGBox.Visible = true;
                    workGBox.Visible = false;
                    stage--;
                    break;
                case 6: 
                    workGBox.Visible = true;
                    socialGBox.Visible = false;
                    stage--;
                    break;
                default:
                    MessageBox.Show("WTF!?");
                    break;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
