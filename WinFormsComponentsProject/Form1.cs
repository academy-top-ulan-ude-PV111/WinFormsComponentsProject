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
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                this.BackColor = Color.Red;

        }
    }
}