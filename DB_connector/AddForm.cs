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
        Int32 stage = 0;
        Int32 massiveCount = 0;
        String[] Info = new String[26];
        String[] prevInfo = new String[26];
        String id = "";

        public AddForm()
        {
            InitializeComponent();
            updBtn.Enabled = false;
        }

        /*
         * Show registration stage depending on last stage
         * Stages:
         * 0 - user info
         * 1 - birth info
         * 2 - passport info
         * 3 - addresses info
         * 4 - contacts info
         * 5 - work info
         * 6 - social info
         */
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
                    if (bdayBox.Text.Length == bdayBox.MaxLength)
                    {
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
                        else MessageBox.Show("Some necessary fields wasn't filled");
                    }
                    else MessageBox.Show("Some necessary fields wasn't filled");
                    break;
                case 2:
                    if (CheckPassportMasks(serieTBox.Text, numberTBox.Text, idTBox.Text, authorityTBox.Text, issueTBox.Text))
                        //CheckInfoCorrection(serieTBox.Text, numberTBox.Text, idTBox.Text, authorityTBox.Text, issueTBox.Text))
                    {
                        passportGBox.Visible = false;
                        addrGBox.Visible = true;
                        curTownComBox.Focus();
                        stage++;
                    }
                    else MessageBox.Show("Some necessary fields wasn't filled");
                    break;
                case 3:
                    if (CheckInfoCorrection(curTownComBox.Text,curAddrTBox.Text,offTownComBox.Text,offAddrTBox.Text))
                    {
                        addrGBox.Visible = false;
                        contactsGBox.Visible = true;
                        hPhoneTBox.Focus();
                        stage++;
                    }
                    else MessageBox.Show("Some necessary fields wasn't filled");
                    break;
                case 4:
                    if (CheckPhonesMasks(hPhoneTBox.Text, mPhoneTBox.Text, mailTBox.Text))
                        //CheckNonrequiredInfo(0,hPhoneTBox.Text,mPhoneTBox.Text,mailTBox.Text))
                    {
                        contactsGBox.Visible = false;
                        workGBox.Visible = true;
                        wplaceTBox.Focus();
                        stage++;
                    }
                    break;
                case 5:
                    if (CheckNonrequiredInfo(1,wplaceTBox.Text, posTBox.Text, salaryTBox.Text))                   
                    {
                        workGBox.Visible = false;
                        socialGBox.Visible = true;
                        familyComBox.Focus();
                        stage++;
                    }
                    break;                   
                case 6:
                    String oldie = "",army = "";
                    if (isOldmanCBox.Checked) oldie = "1";
                        else oldie = "0";
                    if (isArmyCBox.Checked) army = "1";
                        else army = "0";
                    if (CheckInfoCorrection(familyComBox.Text, citizenComBox.Text, invalidComBox.Text, oldie,army))
                    {
                        socialGBox.Visible = false;
                        stage++;
                        SaveBtn.Visible = true;
                        updBtn.Visible = true;
                    }
                    else MessageBox.Show("Some necessary fields wasn't filled");
                    break;
                default:
                    MessageBox.Show("WTF!?");
                    break;
            }
        }

        private Boolean CheckPassportMasks(params String[] args)
        {
            //serieTBox.Text, numberTBox.Text, idTBox.Text, authorityTBox.Text, issueTBox.Text)
            if (args[0].Length < 2 || args[1].Length < 7 || args[2].Length < 14 || args[4].Length < 10)
                return false;
            else return CheckInfoCorrection(args);
        }

        private Boolean CheckPhonesMasks(params String[] args)
        {
            for (int i=0;i<2;i++)
            {
                if (args[i].Length<15 && args[i].Length>0)
                    return false;
            }
            return CheckNonrequiredInfo(0,args);
        }

        /*
         * Checking required info and saving it into massive
         */
        private Boolean CheckInfoCorrection(params String[] args)
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

        /*
         * Check non-required information
         * Agrs:
         *  mode:
         *  0 - contacts, no INTs
         *  1 - work, last INT
         */
        private Boolean CheckNonrequiredInfo(Int32 mode,params String[] args)
        {
            for (Int32 count = 0;count<=2;count++,massiveCount++)
            {
                if (args[count].Trim().Length == 0) Info[massiveCount] = "";
                else Info[massiveCount] = args[count].Trim();
            }
            if (mode==1)
            {
                if (args[2].Trim().Length==0) Info[massiveCount-1] = "0";
            }
            return true;
        }

        /*
         * Hide date tips if entered
         */
        private void dateBox_Enter(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            if (box.Text.Equals("yyyy-MM-dd"))
            {
                box.ForeColor = Color.Black;
                box.Clear();
            }
        }

        /*
         * Show date tips if nothing left in TBox
         */
        private void dateBox_Leave(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            if (box.Text.Equals(""))
            {
                box.ForeColor = Color.Gray;
                box.Text = "yyyy-MM-dd";
            }
        }

        /*
         * Return previous stage and massive iterator
         */
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
                case 7:
                    socialGBox.Visible = true;
                    stage--;
                    massiveCount = 21;
                    SaveBtn.Visible = false;
                    updBtn.Visible = false;
                    break;
                default:
                    MessageBox.Show("WTF!?");
                    break;
            }
        }

        /*
         * Button "Cancel" to leave the registration
         */
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddForm_Shown(object sender, EventArgs e)
        {
            //using (MySQLConnector con = new MySQLConnector())
            MySQLConnector msc = MySQLConnector.GetInstance();
            {
                curTownComBox.DataSource = msc.SelectInformation(0);
                curTownComBox.DisplayMember = "town_Name";
                offTownComBox.DataSource = msc.SelectInformation(0);
                offTownComBox.DisplayMember = "town_Name";
                familyComBox.DataSource = msc.SelectInformation(1);
                familyComBox.DisplayMember = "condition";
                citizenComBox.DataSource = msc.SelectInformation(3);
                citizenComBox.DisplayMember = "countries";
                invalidComBox.DataSource = msc.SelectInformation(2);
                invalidComBox.DisplayMember = "invalid_cond";                
            }
            fnameBox.Focus();
        }

        /*
         * Ban digits for text fields
         */
        private void noDigits_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') 
                || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }

        /*
         * Date info validating
         */
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
                    //Monthes: 01-12
                    if (obj.Text.Length == 5 && e.KeyChar > '1' && e.KeyChar<='9') 
                        e.Handled = true;
                    if (obj.Text.Length == 6 && obj.Text[5] == '1' && e.KeyChar > '2' && e.KeyChar <= '9')
                        e.Handled = true;
                    //Days: 01-31
                    if (obj.Text.Length == 8 && e.KeyChar > '3' && e.KeyChar <= '9')
                        e.Handled = true;
                    if (obj.Text.Length == 9 && obj.Text[8] > '2' && e.KeyChar > '1' && e.KeyChar <= '9')
                        e.Handled = true;
                    //For February days 01-28
                    else if (obj.Text.Length == 9 &&  obj.Text[5] == '0' && obj.Text[6] == '2' && obj.Text[8] > '2')
                        e.Handled = true;
                    else if (obj.Text.Length == 9 && e.KeyChar > '8' && e.KeyChar <= '9' && obj.Text[5] == '0' && obj.Text[6] == '2' && obj.Text[8] == '2')
                        e.Handled = true;
                }
            }
        }

        /*
         * Ban letters for digital fields
         */
        private void noLetters_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '+' && e.KeyChar != '(' && e.KeyChar != ')'
                && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
                e.Handled = true;
        }

        private void updBtn_Click(object sender, EventArgs e)
        {
            //using (MySQLConnector msc = new MySQLConnector())
            MySQLConnector msc = MySQLConnector.GetInstance();
            {
                try
                {
                    //CheckDifferences();
                    msc.UpdateInfo(id, CheckDifferences(), Info);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            //using (MySQLConnector msc = new MySQLConnector())
            MySQLConnector msc = MySQLConnector.GetInstance();
            {
                try
                {
                    if (msc.IfExists(Info[0], Info[1], Info[2])==false && msc.IfExistsPassport(Info[6],Info[7])==false)
                    {

                        msc.AddInformation(Info);
                        this.Close();
                        //msc.UpdateInfo(id, CheckDifferences(), Info);
                    }
                    else MessageBox.Show("Already Exists");
                    //msc.AddInformation(Info);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            //this.Close();
        }

        public void ShowSelectedUser(DataGridViewRow row)
        {
            id = row.Cells[0].Value.ToString();
            for (int i = 1; i < 25;i++ )
            {
                if (i==4 || i==11)
                {
                    prevInfo[i - 1] = StringDataFormat(row.Cells[i].Value.ToString());
                }
                else
                prevInfo[i-1] = row.Cells[i].Value.ToString();
            }
            if (row.Cells[25].Value.Equals(true)) prevInfo[24] = "1";//isOldmanCBox.Checked = true;
            if (row.Cells[26].Value.Equals(true)) prevInfo[25] = "1";//isArmyCBox.Checked = true;


            fnameBox.Text = prevInfo[0];
            sNameBox.Text = prevInfo[1];
            fatNameBox.Text = prevInfo[2];
            bdayBox.Text = prevInfo[3];
            bdayBox.ForeColor = Color.Black;
            if (prevInfo[4] == "F")
                isFemaleRBtn.Checked = true;
            bplaceBox.Text = prevInfo[5];
            serieTBox.Text = prevInfo[6];
            numberTBox.Text = prevInfo[7];
            idTBox.Text = prevInfo[8];
            authorityTBox.Text = prevInfo[9];
            issueTBox.Text = prevInfo[10];
            issueTBox.ForeColor = Color.Black;
            curTownComBox.Text = prevInfo[11];
            curAddrTBox.Text = prevInfo[12];
            offTownComBox.Text = prevInfo[13];
            offAddrTBox.Text = prevInfo[14];
            hPhoneTBox.Text = prevInfo[15];
            mPhoneTBox.Text = prevInfo[16];
            mailTBox.Text = prevInfo[17];
            wplaceTBox.Text = prevInfo[18];
            posTBox.Text = prevInfo[19];
            salaryTBox.Text = prevInfo[20];
            familyComBox.SelectedText = prevInfo[21];
            citizenComBox.SelectedText = prevInfo[22];
            invalidComBox.SelectedText = prevInfo[23];
            if (prevInfo[24]=="1") isOldmanCBox.Checked = true;
            if (prevInfo[25]=="1") isArmyCBox.Checked = true;

            SaveBtn.Enabled = false;
            updBtn.Enabled = true;
        }

        private String StringDataFormat(String sqlDate)
        {
            String result = null;
            result = sqlDate.Substring(6, 4)+"-";
            result += sqlDate.Substring(3, 2)+"-";
            result += sqlDate.Substring(0, 2);
            return result;
        }
        
        private List<Int32> CheckDifferences()
        {
            List<Int32> result = new List<Int32>();
            if (Info.Equals(prevInfo))
                return null;
            else
            {
                for (Int32 i = 0; i < Info.Length; i++)
                    if (!Info[i].Equals(prevInfo[i]))
                        result.Add(i);
                return result;
            }
        }
    }
}
