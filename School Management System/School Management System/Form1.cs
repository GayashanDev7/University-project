namespace School_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
                label5.Text = progressBar1.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();
                Form2 fm2 = new Form2();
                fm2.Show();
                this.Hide();
            }
        }
    }
}