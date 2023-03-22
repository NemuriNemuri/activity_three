using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivityThreeApplication
{
    public partial class SurveyForm : Form
    {
        public SurveyForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            var strList = new ArrayList();

            // Japan
            if (firstChoice1.Checked == true)
            {
                strList.Add(firstChoice1.Text);
            }

            // Philippines
            if (firstChoice2.Checked == true)
            {
                strList.Add(firstChoice2.Text);
            }

            // Thailand
            if (firstChoice3.Checked == true)
            {
                strList.Add(firstChoice3.Text);
            }

            // Australia
            if (firstChoice4.Checked == true)
            {
                strList.Add(firstChoice4.Text);
            }

            // Others
            if (!string.IsNullOrEmpty(othersField.Text)) {
                strList.Add(othersField.Text);
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < strList.Count; ++i)
            {
                if (strList.Count == 1)
                {
                    sb.Append(strList[i]);
                    break;
                }

                if (i < strList.Count - 1)
                {
                    sb.Append(strList[i] + ", ");
                }
                else
                {
                    sb.Append("and " + strList[i]);
                }
            }

            if (strList.Count != 0)
            {
                MessageBox.Show("You selected :\n" + sb.ToString() + "\nThank you!", "Survey", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You selected nothing!", "Survey", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void firstChoiceOthers_CheckedChanged(object sender, EventArgs e)
        {
            if (firstChoiceOthers.Checked)
            {
                othersLabel.Visible = true;
                othersField.Visible = true;
            }
            else 
            {
                othersLabel.Visible = false;
                // clear the input of othersField
                othersField.Text = "";
                othersField.Visible = false;
            }
        }

    }
}
