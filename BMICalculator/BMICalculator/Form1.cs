namespace BMICalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            txtTinggi.Text = "";
            txtBerat.Text = "";
            txtHasil.Text = "";

            radKg.Checked = false;
            radLb.Checked = false;
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            double berat = Convert.ToDouble(txtBerat.Text);
            double tinggi = Convert.ToDouble(txtTinggi.Text);
            double hasil = 0.0;

            if (radKg.Checked)
            {
                hasil = berat / (tinggi * tinggi);
            }
            else
            if (radLb.Checked)
            {
                berat = berat / 2.205;
                hasil = berat / (tinggi * tinggi);
            }
            txtHasil.Text = "Nilai BMI Anda adalah: " + hasil.ToString("#.#");
        }
    }
}