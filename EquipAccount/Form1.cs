namespace EquipAccount
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists("users.txt"))
            {
                List<string> s = File.ReadAllLines("users.txt").ToList();
                if (!s.Contains($"[{textBox1.Text}={textBox2.Text}]"))
                {
                    MessageBox.Show("Введены неверные данные авторизации", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Введены неверные данные авторизации", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            new MainForm().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new RegisterForm().Show();

        }
    }
}