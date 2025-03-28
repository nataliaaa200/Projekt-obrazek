namespace Edycja_obrazka_3._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png|All Files|*.*";  // Mo¿na dodaæ inne formaty plików
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                pictureBox.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                Image img = pictureBox.Image;
                if (rdo90.Checked) img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                if (rdo180.Checked) img.RotateFlip(RotateFlipType.Rotate180FlipNone);
                if (rdo270.Checked) img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                pictureBox.Refresh();
            }
        }
    }
}
