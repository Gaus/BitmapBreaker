using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitmapBreaker
{
    public class Decoder
    {
        ulong[,] sumPixelColumns;
        ulong[,] sumPixelRows;
        ulong[,] pixelColumns;
        ulong[,] pixelRows;
        ulong[,] pixel;

        Bitmap bitmap;
        Graphics g;
        Rectangle row;
        Rectangle column;
        PictureBox pictureBox;
        public Decoder(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
            bitmap = new Bitmap(pictureBox.Image);

            g = Graphics.FromImage(pictureBox.Image);
            int width = bitmap.Width;
            int height = bitmap.Height;
            row = new Rectangle(0, 0, width, 1);
            column = new Rectangle(0, 0, 1, height);
            pixel = new ulong[height, width];
            pixelColumns = new ulong[width, height];
            pixelRows = new ulong[100, width];
            sumPixelColumns = new ulong[width, height];
            sumPixelRows = new ulong[height, width];
        }

        private unsafe void loadPixelData(int width, int height)
        {
            BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, width, height),
                                                    ImageLockMode.ReadOnly,
                                                    PixelFormat.Format24bppRgb);
            try
            {
                Color color;
                byte* curpos;
                byte r, g, b;
                int hue;
                int saturation;
                int brightness;
                for (int h = 0; h < height; h++)
                {
                    curpos = ((byte*)bitmapData.Scan0) + h * bitmapData.Stride;
                    for (int w = 0; w < width; w++)
                    {
                        b = *(curpos++);
                        g = *(curpos++);
                        r = *(curpos++);
                        color = Color.FromArgb(r, g, b);
                        hue = (int)(Math.Round(color.GetHue()));
                        saturation = (int)(Math.Round(color.GetSaturation() * 100, 0));
                        brightness = (int)(Math.Round(color.GetBrightness() * 100, 0));
                        pixel[h, w] = (ulong)((hue << 24) | (r << 16) | (g << 8) | b);
                    }
                }
            }
            finally
            {
                ulong[] tempColumns = new ulong[bitmap.Height];
                ulong[] tempRows = new ulong[bitmap.Width];
                for (int x = 0; x < bitmap.Width; x++)
                {
                    for (int y = 1; y < 6; y++)
                    {
                        sumPixelColumns[x, y] = pixel[(y * 30) % bitmap.Height, x];
                    }
                }
                for (int y = 0; y < bitmap.Height; y++)
                {
                    for (int x = 1; x < 4; x++)
                    {
                         sumPixelRows[y, x] = pixel[y, (x * 120) % bitmap.Width];
                    }
                }
                bitmap.UnlockBits(bitmapData);
            }
        }

        public void sortC()
        {
            loadPixelData(bitmap.Width, bitmap.Height);
            sortColumns(sumPixelColumns, 0, bitmap.Width - 1);
        }

        public void sortColumns(ulong[,] a, int l, int r)
        {
            int xField = l + (r - l) / 2;
            int i = l;
            int j = r;

            ulong[] x = new ulong[a.GetLength(1)];
            for (int k = 0; k < a.GetLength(1); k++)
                x[k] = a[xField, k];

            while (i <= j)
            {
                while (toCompare(a, x, i) == 1) i++;
                while (toCompare(a, x, j) == -1) j--;
                if (i <= j)
                {
                    swapArrays(a, i, j);
                    swapColumns(i, j);
                    i++;
                    j--;
                }
            }
            if (i < r)
                sortColumns(a, i, r);

            if (l < j)
                sortColumns(a, l, j);
        }

        public void swapColumns(int i, int j)
        {
            using (g = Graphics.FromImage(bitmap))
            {
                Bitmap temp = new Bitmap(pictureBox.Image);
                column.X = i;
                g.DrawImage(temp, j, 0, column, GraphicsUnit.Pixel);
                column.X = j;
                g.DrawImage(temp, i, 0, column, GraphicsUnit.Pixel);
                pictureBox.Image = bitmap;
                temp.Dispose();
            }
            pictureBox.Refresh();
        }

        public void sortR()
        {
            loadPixelData(bitmap.Width, bitmap.Height);
            sortRows(sumPixelRows, 0, bitmap.Height - 1);
        }

        public void sortRows(ulong[,] a, int l, int r)
        {
            int xField = l + (r - l) / 2;
            int i = l;
            int j = r;

            ulong[] x = new ulong[a.GetLength(1)];
            for (int k = 0; k < a.GetLength(1); k++)
                x[k] = a[xField, k];

            while (i <= j)
            {
                while (toCompare(a, x, i) == 1) i++;
                while (toCompare(a, x, j) == -1) j--;
                if (i <= j)
                {
                    swapRows(i, j);
                    swapArrays(a, i, j);
                    i++;
                    j--;
                }
            }
            if (i < r)
                sortRows(a, i, r);

            if (l < j)
                sortRows(a, l, j);
        }

        private int toCompare(ulong[,] a, ulong[] b, int i)
        {
            if (i >= 0)
            {
                if (a[i, 0] < b[0])
                    return 1;
                if (a[i, 0] > b[0])
                    return -1;
                if (a[i, 0] == b[0])
                    for (int k = 1; k < a.GetLength(1); k++)
                    {
                        if (a[i, k] + a[i, k - 1] < b[k] + b[k - 1])
                            return 1;
                        if (a[i, k] + a[i, k - 1] > b[k] + b[k - 1])
                            return -1;
                        if (a[i, k] + a[i, k - 1] == b[k] + b[k - 1])
                            continue;
                    }
            }
            return 0;
        }

        private void swapArrays(ulong[,] a, int i, int j)
        {
            int length = a.GetLength(1);
            ulong[] temp = new ulong[length];
            for (int k = 0; k < length; k++)
            {
                temp[k] = a[j, k];
                a[j, k] = a[i, k];
                a[i, k] = temp[k];
            }
        }

        public void swapRows(int i, int j)
        {
            using (g = Graphics.FromImage(bitmap))
            {
                Bitmap temp = new Bitmap(pictureBox.Image);
                row.Y = i;
                g.DrawImage(temp, 0, j, row, GraphicsUnit.Pixel);
                row.Y = j;
                g.DrawImage(temp, 0, i, row, GraphicsUnit.Pixel);
                pictureBox.Image = bitmap;
                temp.Dispose();
            }
            pictureBox.Refresh();
        }
    }
}
