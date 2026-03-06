namespace Домашня_робота
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            string filePath = @"C:\Users\STUDENT\Downloads\dog\dog1.jpg";
            pbImage.Image = Image.FromFile(filePath);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MyHelpContact_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitForm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви точно хочете вийти?",
        "Вихід з програми",
        MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ExitForm f = new ExitForm();

            if (f.ShowDialog() == DialogResult.Cancel)
            {
                Application.Exit();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void pbImage_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
