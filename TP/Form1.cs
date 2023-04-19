using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP
{
    public partial class Form1 : Form
    {
        private Bitmap originalImage; // Загруженное изображение
        private Bitmap mosaicImage; // Мозаичное изображение
        private int tileWidth; // Ширина чипа
        private int tileHeight; // Высота чипа
        private Color[] tileColors; // Массив цветов
        public Form1()
        {
            InitializeComponent();
            errorProvider1.SetError(colorBox, "Выберите цвета!");
            errorProvider1.SetError(pictureBox, "Загрузите картинку!");
        }
        private void InitializeTileColors()
        {
            // Получаем выбранные цвета из ColorBox.CheckedListBox
            List<Color> selectedColors = new List<Color>();
            foreach (object itemChecked in colorBox.CheckedItems)
            {
                string colorName = itemChecked.ToString();
                Color color = Color.FromName(colorName);
                selectedColors.Add(color);
            }

            // Инициализируем массив tileColors выбранными цветами
            tileColors = selectedColors.ToArray();
        }
        private bool CheckErrs()
        {
            try
            {
                // Проверяем, что в полях именно числа
                int p1 = int.Parse(HeightMoz.Text);
                int p2 = int.Parse(WidthMoz.Text);
                int p3 = int.Parse(HeightWall.Text);
                int p4 = int.Parse(WidthWall.Text);

                // Дополнительные проверки чекбокса и пикчербокса, а также на нули в полях
                if (colorBox.CheckedItems.Count == 0 | pictureBox.Image == null | p1 * p2 * p3 * p4 == 0) { throw new Exception(); }
            }
            catch
            {
                // Выводим окно в случае ошибки и ставим значение true
                Form2 err = new Form2();
                err.Show();
                return true;
            }
            // Если всё ок, то значение false
            return false;
        }

        private void GenerateBt_Click(object sender, EventArgs e)
        {
            InitializeTileColors();

            // Проверяем на ошибки и если они есть, то дальше не идём
            if (CheckErrs()) { return; }

            // Разбор входных значений
            int wallWidth = int.Parse(WidthWall.Text);
            int wallHeight = int.Parse(HeightWall.Text);
            tileWidth = int.Parse(WidthMoz.Text);
            tileHeight = int.Parse(HeightMoz.Text);

            // Необходимое количество плиток
            int numTilesWide = (int)Math.Ceiling((double)wallWidth / tileWidth);
            int numTilesHigh = (int)Math.Ceiling((double)wallHeight / tileHeight);

            // Изменение размера исходного изображения до необходимого размера
            Bitmap resizedImage = new Bitmap(originalImage, numTilesWide * tileWidth, numTilesHigh * tileHeight);

            // Создание новое растрового изображения для мозаичного изображения
            mosaicImage = new Bitmap(numTilesWide * tileWidth, numTilesHigh * tileHeight);

            // Создание мозаичного изображения
            for (int x = 0; x < numTilesWide; x++)
            {
                for (int y = 0; y < numTilesHigh; y++)
                {
                    // Получаем средний цвет плитки
                    int tileAverageR = 0, tileAverageG = 0, tileAverageB = 0;
                    for (int i = 0; i < tileWidth; i++)
                    {
                        for (int j = 0; j < tileHeight; j++)
                        {
                            Color pixelColor = resizedImage.GetPixel(x * tileWidth + i, y * tileHeight + j);
                            tileAverageR += pixelColor.R;
                            tileAverageG += pixelColor.G;
                            tileAverageB += pixelColor.B;
                        }
                    }
                    tileAverageR /= tileWidth * tileHeight;
                    tileAverageG /= tileWidth * tileHeight;
                    tileAverageB /= tileWidth * tileHeight;

                    // Находим ближайший подходящий цвет
                    int closestColorIndex = 0;
                    double closestColorDistance = double.MaxValue;
                    for (int i = 0; i < tileColors.Length; i++)
                    {
                        double colorDistance = Math.Sqrt(
                            Math.Pow(tileColors[i].R - tileAverageR, 2) +
                            Math.Pow(tileColors[i].G - tileAverageG, 2) +
                            Math.Pow(tileColors[i].B - tileAverageB, 2));

                        if (colorDistance < closestColorDistance)
                        {
                            closestColorIndex = i;
                            closestColorDistance = colorDistance;
                        }
                    }

                    // Установим цвет плитки в мозаичном изображении
                    Color tileColor = tileColors[closestColorIndex];
                    for (int i = 0; i < tileWidth; i++)
                    {
                        for (int j = 0; j < tileHeight; j++)
                        {
                            mosaicImage.SetPixel(x * tileWidth + i, y * tileHeight + j, tileColor);
                        }
                    }
                }
            }

            // Покажем мозаичное изображение
            pictureBox.Image = mosaicImage;
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Открываем файл изображения
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Загружаем выбранное изображение
                originalImage = new Bitmap(openFileDialog.FileName);
                pictureBox.Image = originalImage;
                errorProvider1.SetError(pictureBox, "");
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Сохраняем файл мозаичного изображения
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Image files (*.png)|*.png";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Сохраняем мозаичное изображение
                mosaicImage.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        // Дальше проверяем на различные ошибки, чтобы высвечивался значок
        private void WidthWall_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int p = int.Parse(WidthWall.Text);
                if (p <= 0) { throw new Exception(); }
            }
            catch
            {
                errorProvider1.SetError(WidthWall, "Заполните целым положительным числом!");
                return;
            }
            errorProvider1.SetError(WidthWall, "");
        }
        private void HeightWall_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int p = int.Parse(HeightWall.Text);
                if (p <= 0) { throw new Exception(); }
            }
            catch
            {
                errorProvider1.SetError(HeightWall, "Заполните целым положительным числом!");
                return;
            }
            errorProvider1.SetError(HeightWall, "");
        }
        private void WidthMoz_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int p = int.Parse(WidthMoz.Text);
                if (p <= 0) { throw new Exception(); }
            }
            catch
            {
                errorProvider1.SetError(WidthMoz, "Заполните целым положительным числом!");
                return;
            }
            errorProvider1.SetError(WidthMoz, "");
        }
        private void HeightMoz_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int p = int.Parse(HeightMoz.Text);
                if (p <= 0) { throw new Exception(); }
            }
            catch
            {
                errorProvider1.SetError(HeightMoz, "Заполните целым положительным числом!");
                return;
            }
            errorProvider1.SetError(HeightMoz, "");
        }
        private void colorBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (colorBox.CheckedItems.Count == 0)
            {
                errorProvider1.SetError(colorBox, "Выберите цвета!");
            }
            else
            {
                errorProvider1.SetError(colorBox, "");
            }
        }
    }
}