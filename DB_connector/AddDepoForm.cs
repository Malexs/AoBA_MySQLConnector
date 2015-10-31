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
    public partial class AddDepoForm : Form
    {
        private MySQLConnector mySQLconnect;
        DataTable info;
        Int32 currIndex = 0;
        DataGridViewRow client;
        DateTime depoStart = DateTime.Today,
            depoEnd = DateTime.Today,
            agrEnd = DateTime.Today;
        Type type;

        public enum Type
        {
            Add,
            Update,
        };

        public AddDepoForm(Type _type)
        {
            InitializeComponent();
            mySQLconnect = MySQLConnector.GetInstance();
            depoTypeCBox.DataSource = mySQLconnect.SelectDepoInfo();
            depoTypeCBox.DisplayMember = "Type_name";
            numTBox.Text = SetAgreementNumber(mySQLconnect.SelectLastAgreement()).ToString();
            type = _type;
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today;
        }

        private Int32 SetAgreementNumber(DataTable dt)
        {
            if (dt == null) return 1;
            else return (Int32)dt.Rows[0].ItemArray[0] + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.ShowDialog();
            client = userForm.SelectedClient;
            if (client!=null)
            {
                clientTBox.Text = "";
                for (int i = 1; i < 4; i++)
                    clientTBox.Text += client.Cells[i].Value.ToString() + " ";
            }
        }

        private void depoTypeCBox_SelectedValueChanged(object sender, EventArgs e)
        {
            info = mySQLconnect.SelectDepoInfo(depoTypeCBox.SelectedIndex+1);
            depositCBox.DataSource = info;
            depositCBox.DisplayMember = "Deposit_name";
        }

        private void depositCBox_SelectedValueChanged(object sender, EventArgs e)
        {
            currIndex = depositCBox.SelectedIndex;
            if (depoTypeCBox.SelectedIndex == 0)
            {
                label2.Text = "Тип: " + info.Rows[currIndex].ItemArray[1].ToString()
                    + "\nНазвание: " + info.Rows[currIndex].ItemArray[2].ToString()
                    + "\nВалюта: " + info.Rows[currIndex].ItemArray[3].ToString()
                    + "\nМин. вклад: " + info.Rows[currIndex].ItemArray[4].ToString()
                    + "\nВремя: " + info.Rows[currIndex].ItemArray[5].ToString()
                    + "\nГод. процент: " + info.Rows[currIndex].ItemArray[6].ToString();
                label8.Visible = true;
            }
            else
            {
                label2.Text = "Тип: " + info.Rows[currIndex].ItemArray[1].ToString()
                    + "\nНазвание: " + info.Rows[currIndex].ItemArray[2].ToString()
                    + "\nВалюта: " + info.Rows[currIndex].ItemArray[3].ToString()
                    + "\nГод. процент: " + info.Rows[currIndex].ItemArray[6].ToString();
                label8.Visible = false;
            }
            DateTime tmp = dateTimePicker1.Value;
            dateTimePicker1.Value = tmp.AddDays(1);
            dateTimePicker1.Value = tmp;
        }

        private void summTBox_Leave(object sender, EventArgs e)
        {
            if (summTBox.Text.Length!=0)
            {
                if (!(Int32.Parse(summTBox.Text)<(Int32)info.Rows[currIndex].ItemArray[4]))
                {
                    summErrLabel.Visible = false;
                    return;
                }
            }
            summErrLabel.Visible = true;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
                mySQLconnect.AddInformation(numTBox.Text, info.Rows[currIndex].ItemArray[0].ToString(), info.Rows[currIndex].ItemArray[3].ToString(),
                                                label5.Text.Substring(15), label8.Text.Substring(13), summTBox.Text, client.Cells[0].Value.ToString(), dateRebuild(dateTimePicker2.Value.ToString()));
                this.Close();
        }

        /*
         * Date info validating
         */
        private void dates_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox obj = (TextBox)sender;
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '-'
                && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
            }
            else
            {
                if ((obj.Text.Length < 4 || (obj.Text.Length > 4 && obj.Text.Length < 7)
                    || obj.Text.Length > 7) && e.KeyChar == '-')
                    e.Handled = true;
                else
                    if ((obj.Text.Length == 4 || obj.Text.Length == 7) && (e.KeyChar >= '0' && e.KeyChar <= '9'))
                    {
                        e.Handled = true;
                    }
            }
        }

        public void SetUser(Int32 number)
        {
            if (number != 0)
            {
                mySQLconnect = MySQLConnector.GetInstance();
                DataTable info = mySQLconnect.SelectAgreementInfo(number);
                if (info != null)
                {
                    DataRow user = info.Rows[0];
                    DateTime.TryParse(dateRebuild(user[1].ToString().Substring(0, 10)), out depoStart);
                    DateTime.TryParse(dateRebuild(user[2].ToString().Substring(0, 10)), out depoEnd);
                    DateTime.TryParse(dateRebuild(user[3].ToString().Substring(0, 10)), out agrEnd);
                    numTBox.Text = user[0].ToString(); //номер договора
                    dateTimePicker1.MinDate = depoStart;
                    dateTimePicker1.Value = depoStart;
                    //label5.Text = "Date selected: " + depoStart.ToString();
                    label8.Text = "Date of end: " + dateRebuild(depoEnd.ToString());
                    dateTimePicker2.MinDate = agrEnd.AddDays(-1);
                    dateTimePicker2.Value = agrEnd.AddDays(-1);
                    summTBox.Text = user[4].ToString();//сумма вклада
                    for (int i = 5; i <= 7; i++)
                        clientTBox.Text += user[i].ToString() + " ";
                    this.ShowDialog();
                    return;
                }
            }
        }

        private String dateRebuild(String prevDate)
        {
            String result = "";
            result += prevDate.Substring(6, 4) + "-" + prevDate.Substring(3, 2) + "-" + prevDate.Substring(0, 2);
            return result;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //DateTime.TryParse(dateTimePicker1.Text, out depoStart);
            depoStart = dateTimePicker1.Value;
            String tm = dateRebuild(depoStart.ToString());
            label5.Text = "Date Selected: " + tm;
            label8.Text = "";
            if (info.Rows[currIndex].ItemArray[1].ToString() == "Termed")
            {
                Int32 day = (Int32)info.Rows[currIndex].ItemArray[5];
                if (day>0)
                    depoEnd = depoStart.AddDays(day);
                tm = dateRebuild(depoEnd.ToString());
                label8.Text = "Date of end: " + tm;
                dateTimePicker2.MinDate = depoEnd;
                dateTimePicker2.Value = depoEnd;
                return;
            }
            dateTimePicker2.MinDate = depoStart;
            depoEnd = DateTime.MaxValue;
        }
    }
}
