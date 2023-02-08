namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNhapten_TextChanged(object sender, EventArgs e)
        {
            this.ForeColor = Color.Red;
            lblLapTrinh.Text = txtNhapten.Text;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            txtNhapten.ForeColor = Color.Red;
            lblLapTrinh.Text = txtNhapten.Text;
            lblLapTrinh.ForeColor = Color.Red;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            txtNhapten.ForeColor = Color.Green;
            lblLapTrinh.Text = txtNhapten.Text;
            lblLapTrinh.ForeColor = Color.Green;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            txtNhapten.ForeColor = Color.Blue;
            lblLapTrinh.Text = txtNhapten.Text;
            lblLapTrinh.ForeColor = Color.Blue;
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            txtNhapten.ForeColor = Color.Black;
            lblLapTrinh.Text = txtNhapten.Text;
            lblLapTrinh.ForeColor = Color.Black;
        }

        private void lblLapTrinh_Click(object sender, EventArgs e)
        {
            this.Text = txtNhapten.Text;
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            txtNhapten.Font = new Font(txtNhapten.Font, FontStyle.Bold);
            lblLapTrinh.Font = new Font(lblLapTrinh.Font, FontStyle.Bold);
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            txtNhapten.Font = new Font(txtNhapten.Font, FontStyle.Italic);
            lblLapTrinh.Font = new Font(lblLapTrinh.Font, FontStyle.Italic);
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            txtNhapten.Font = new Font(txtNhapten.Font, FontStyle.Underline);
            lblLapTrinh.Font = new Font(lblLapTrinh.Font, FontStyle.Underline);
        }


    }
}