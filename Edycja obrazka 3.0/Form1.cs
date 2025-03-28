namespace Edycja_obrazka_3._0
{
    public partial class Form1 : Form
    {
        private Bitmap? originalImage = null; // Nullable, aby unikn¹æ problemów z null
        private bool isGreenFilterApplied = false;

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

        private void btnOnlyGreen_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null) return;

            if (!isGreenFilterApplied)
            {
                originalImage = new Bitmap(pictureBox.Image);
                Bitmap bmp = new Bitmap(originalImage);

                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        Color pixel = bmp.GetPixel(x, y);

                        if (!(pixel.G > pixel.R && pixel.G > pixel.B))
                        {
                            bmp.SetPixel(x, y, Color.Black);
                        }
                    }
                }
                pictureBox.Image = bmp;
                isGreenFilterApplied = true;
            }
            else
            {
                pictureBox.Image = new Bitmap(originalImage);
                isGreenFilterApplied = false;
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

        private void btnInvert_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                Bitmap bmp = new Bitmap(pictureBox.Image);
                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        Color pixel = bmp.GetPixel(x, y);
                        bmp.SetPixel(x, y, Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B));
                    }
                }
                pictureBox.Image = bmp;
            }
        }

        private void btnUpsideDown_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                pictureBox.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                pictureBox.Refresh();
            }
        }
    }
}
