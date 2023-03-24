using System.Text.RegularExpressions;

namespace expresionRegular
{
    public partial class Form1 : Form
    {
        string regex = "";
        string input = "";

        string regEmail = "^\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$";
        string regDate = "(\\d{2}).(\\d{2}).(\\d{4})";
        string regURL = "(https?)://(www)?.?(\\w+).(\\w+)/?(\\w+)?";
        string regIP = "(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)";

        RadioButton[] arrayRadio = new RadioButton[4]; 
        public Form1()
        {
            InitializeComponent();

            rbTexto.Checked = true;

            EnabledComponents();

            arrayRadio[0] = rbEmail;
            arrayRadio[1] = rbDate;
            arrayRadio[2] = rbURL;
            arrayRadio[3] = rbIP;
            
            rbEmail.Checked = true;
        }

        private void EnabledComponents()
        {
            lblMessage.Text = "";

            gbRegex.Visible = rbTexto.Checked;

            lblRegex.Enabled = rbTextRegex.Checked;
            txtRegex.Enabled = rbTextRegex.Checked;

            txtRegex.Text = "";
        }

        private void LoadRegex(RadioButton sender)
        {
            int index = Array.IndexOf(arrayRadio, sender);

            switch (index)
            {
                case 0:
                    // Email
                    txtRegex.Text = regEmail;
                    break;
                case 1:
                    // Date
                    txtRegex.Text = regDate;
                    break;
                case 2:
                    // URL
                    txtRegex.Text = regURL;
                    break;
                case 3:
                    // IP
                    txtRegex.Text = regIP;
                    break;
                default:
                    txtRegex.Text = "";
                    break;
            }
        }

        private void Validate()
        {
            input = txtInput.Text;
            regex = txtRegex.Text;

            bool result = Regex.IsMatch(input, regex);

            if (result) lblMessage.Text = "El texto es válido";
            else lblMessage.Text = "El texto no es válido";
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            EnabledComponents();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Validate();
        }

        private void rbRegex_CheckedChanged(object sender, EventArgs e)
        {
            LoadRegex((RadioButton) sender);
        }
    }
}