namespace Rastavi_unetu_rec_na_slova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rec = textBox1.Text;
            int duzina = rec.Length;
            TextBox[] niz = new TextBox[duzina];
            for (int i = 0; i < duzina; i++)
            {
                niz[i] = new TextBox();
                niz[i].Location = new Point(label1.Location.X + i * 30, Height - 150);
                niz[i].Size = new Size(25, 15);
                niz[i].Text = rec[i].ToString();
                this.Controls.Add(niz[i]);
            }
            button1.Enabled = false;
        }
    }
}