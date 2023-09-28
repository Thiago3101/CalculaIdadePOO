namespace calculaidade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime datanasc = dateTimePicker1.Value;
            DateTime dataAtual = DateTime.Now;

            TimeSpan idade = dataAtual.Subtract(datanasc);
            label1.Text = ((int)(idade.Days / 365.2425)).ToString("");
        }
    }
}