namespace WinFormsComponentsProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = "Message Box Title";
            string message = "Back paint red?";
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                this.BackColor = Color.Red;

        }

        private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                errorProvider1.SetError(txtName, "��� ������!");
                button1.Enabled = false;
            }
                
            else if (txtName.Text.Length < 3)
                errorProvider1.SetError(txtName, "��� ��������!");
            else
                errorProvider1.Clear();
        }

        private void txtAge_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int age = 0;
            if (txtAge.Text.Trim() == "")
                errorProvider1.SetError(txtAge, "������� �� �����!");
            else if (!Int32.TryParse(txtAge.Text, out age))
                errorProvider1.SetError(txtAge, "������� ����� �����������!");
            else
                errorProvider1.Clear();
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "") 
            {
                
            }
        }
    }
}