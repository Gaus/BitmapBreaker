using System;
using System.Drawing;
using System.Windows.Forms;

namespace BitmapBreaker
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Decoder decoder;
        public Form1()
        {
            InitializeComponent();
            loadBitmap();
        }
        private void loadBitmap()
        {
            decoder = new Decoder(pictureBox);
        }

        private void numericColumnJ_ValueChanged(object sender, EventArgs e)
        {
            int i = (int)numericColumnI.Value;
            int j = (int)numericColumnJ.Value;
            if (i != j)
                decoder.swapColumns(i, j);
        }
        private void numericRowJ_ValueChanged(object sender, EventArgs e)
        {
            int i = (int)numericRowI.Value;
            int j = (int)numericRowJ.Value;
            if (i != j)
                decoder.swapRows(i, j);
        }

        private void numericRowI_ValueChanged(object sender, EventArgs e)
        {
            int i = (int)numericRowI.Value;
            int j = (int)numericRowJ.Value;
            if (i != j)
                decoder.swapRows(i, j);
        }

        private void numericColumnI_ValueChanged(object sender, EventArgs e)
        {

            int i = (int)numericColumnI.Value;
            int j = (int)numericColumnJ.Value;
            if (i != j)
                decoder.swapColumns(i, j);
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.C)
                decoder.sortC();
            if (e.KeyData == Keys.R)
                decoder.sortR();
        }
    }
}
