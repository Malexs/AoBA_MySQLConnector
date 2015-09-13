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
        Int32 massiveCount = 0;
        String[] Info = new String[26];

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
                    if (CheckInfoCorrection(fnameBox.Text,sNameBox.Text,fatNameBox.Text))
                    {
                        infoGBox.Visible = false;
                        birthGBox.Visible = true;
                        bplaceBox.Focus();
                        stage++;
                    }
                    else MessageBox.Show("Some necessary fields wasn't filled");
                    break;
                case 1:
                    String sex = "";
                    if (isMaleRBtn.Checked)
                        sex = "M";
                    else sex = "F";
                    if (CheckInfoCorrection(bdayBox.Text, sex, bplaceBox.Text))
                    {
                        birthGBox.Visible = false;
                        passportGBox.Visible = true;
                        serieTBox.Focus();
                        stage++;
                    }
                    break;
                case 2:
                    if (CheckInfoCorrection(serieTBox.Text, numberTBox.Text, idTBox.Text, authorityTBox.Text, issueTBox.Text))
                    {
                        passportGBox.Visible = false;
                        addrGBox.Visible = true;
                        curTownTBox.Focus();
                        stage++;
                    }
                    break;
                case 3:
                    if (CheckInfoCorrection(curTownTBox.Text,curAddrTBox.Text,offTownTBox.Text,offAddrTBox.Text))
                    {
                        addrGBox.Visible = false;
                        contactsGBox.Visible = true;
                        hPhoneTBox.Focus();
                        stage++;
                    }
                    break;
                case 4:
                    if (CheckInfoCorrection(hPhoneTBox.Text,mPhoneTBox.Text,mailTBox.Text))
                    {
                        contactsGBox.Visible = false;
                        workGBox.Visible = true;
                        wplaceTBox.Focus();
                        stage++;
                    }
                    break;
                case 5:
                    if (CheckInfoCorrection(wplaceTBox.Text,posTBox.Text,salaryTBox.Text))                   
                    {
                        workGBox.Visible = false;
                        socialGBox.Visible = true;
                        familyTBox.Focus();
                        stage++;
                    }
                    break;                   
                case 6:
                    String oldie = "",army = "";
                    if (isOldmanCBox.Checked) oldie = "1";
                        else oldie = "0";
                    if (isArmyCBox.Checked) army = "1";
                        else army = "0";
                    if (CheckInfoCorrection(familyTBox.Text, citizenTBox.Text, invalidLabel.Text, oldie,army))
                    {
                        socialGBox.Visible = false;
                        stage++;
                    }
                    break;
                case 7:
                    SendInfo();
                    this.Close();
                    break;
                default:
                    MessageBox.Show("WTF!?");
                    break;
            }
        }


        private Boolean CheckInfoCorrection(params String[] args) //Int32 start,Int32 end,
        {
            Int32 count = 0;
            switch (args.Length)
            {
                case 2:
                    if (args[0].Trim().Length == 0 || args[1].Trim().Length == 0)
                        return false;
                    break;
                case 3:
                    if (args[0].Trim().Length == 0 || args[1].Trim().Length == 0 || args[2].Trim().Length == 0)
                        return false;
                    break;
                case 4:
                    if (args[0].Trim().Length == 0 || args[1].Trim().Length == 0 || args[2].Trim().Length == 0
                            || args[3].Trim().Length == 0)
                        return false;
                    break;
                case 5:
                    if (args[0].Trim().Length == 0 || args[1].Trim().Length == 0 || args[2].Trim().Length == 0
                            || args[3].Trim().Length == 0 || args[4].Trim().Length == 0)
                        return false;
                    break;
                default:
                    return false;
            }

                for (count = 1;count <= args.Length; count++, massiveCount++)
                    Info[massiveCount] = args[count-1].Trim();
                return true;
        }

        private void SendInfo()
        {
            using (MySQLConnector msc = new MySQLConnector())
            {
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
                    massiveCount = 0;
                    stage--;
                    break;
                case 2:
                    birthGBox.Visible = true;
                    passportGBox.Visible = false;
                    stage--;
                    massiveCount = 3;
                    break;
                case 3:
                    passportGBox.Visible = true;
                    addrGBox.Visible = false;
                    stage--;
                    massiveCount = 6;
                    break;
                case 4:
                    addrGBox.Visible = true;
                    contactsGBox.Visible = false;
                    massiveCount = 11;
                    stage--;
                    break;
                case 5:
                    contactsGBox.Visible = true;
                    workGBox.Visible = false;
                    massiveCount = 15;
                    stage--;
                    break;
                case 6: 
                    workGBox.Visible = true;
                    socialGBox.Visible = false;
                    massiveCount = 18;
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

        private void AddForm_Shown(object sender, EventArgs e)
        {
            fnameBox.Focus();
        }

        private void noDigits_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') 
                || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }

        private void dates_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox obj = (TextBox)sender;
            if((e.KeyChar<'0' || e.KeyChar>'9') && e.KeyChar!='-'
                && e.KeyChar!=(char)Keys.Back && e.KeyChar!=(char)Keys.Delete)
            {
                    e.Handled = true;
            }
            else
            {
                if ((obj.Text.Length < 4 || (obj.Text.Length > 4 && obj.Text.Length < 7) 
                    || obj.Text.Length > 7) && e.KeyChar == '-')
                    e.Handled = true;
                else 
                {
                    if ((obj.Text.Length==4 || obj.Text.Length==7)&&(e.KeyChar>='0' && e.KeyChar<='9'))
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void noLetters_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '+' && e.KeyChar != '(' && e.KeyChar != ')'
                && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
                e.Handled = true;
        }



    }
}
