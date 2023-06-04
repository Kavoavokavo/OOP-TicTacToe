using System;
using System.Drawing;
using System.Windows.Forms;

namespace KrestikNolik
{
    public partial class Form1 : Form
    { 
        int krestwins;
        int nolwins;
        private PictureBox[,] pbx = new PictureBox[4, 4];
        private Image Krestik;
        private Image Nolik;
        public Form1()
        {
            InitializeComponent();

            Krestik = Image.FromFile("C:\\Users\\EM\\Downloads\\krestik.jpg");
            Nolik = Image.FromFile("C:\\Users\\EM\\Downloads\\Nolik.jpg");
            for (int i = 1; i < 4; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    array[i, j] = 5;
                }
            };
        }

        int[,] array = new int[4, 4];

        int counter = 0;

        private void PictureBox11_Click(object sender, EventArgs e)
        {
            if (array[1, 1] == 5)
            {
                if (counter % 2 == 0)
                {
                    pictureBox11.Image = Krestik;
                    pictureBox11.SizeMode = PictureBoxSizeMode.CenterImage;
                    array[1, 1] = 1;
                }
                else
                {
                    pictureBox11.Image = Nolik;
                    pictureBox11.SizeMode = PictureBoxSizeMode.CenterImage;
                    array[1, 1] = 0;
                }
                counter++;
                CheckWinner();
            }
        }

        private void PictureBox12_Click(object sender, EventArgs e)
        {
            if (array[1, 2] == 5)
            {
                if (counter % 2 == 0)
                {
                    pictureBox12.Image = Krestik;
                    pictureBox12.SizeMode = PictureBoxSizeMode.CenterImage;
                    array[1, 2] = 1;
                }
                else
                {
                    pictureBox12.Image = Nolik;
                    pictureBox12.SizeMode = PictureBoxSizeMode.CenterImage;
                    array[1, 2] = 0;
                }
                counter++;
                CheckWinner();
            }
        }

        private void PictureBox13_Click(object sender, EventArgs e)
        {
            if (array[1, 3] == 5)
            {
                if (counter % 2 == 0)
                {
                    pictureBox13.Image = Krestik;
                    pictureBox13.SizeMode = PictureBoxSizeMode.CenterImage;
                    array[1, 3] = 1;
                }
                else
                {
                    pictureBox13.Image = Nolik;
                    pictureBox13.SizeMode = PictureBoxSizeMode.CenterImage;
                    array[1, 3] = 0;
                }
                counter++;
                CheckWinner();
            }
        }

        private void PictureBox21_Click(object sender, EventArgs e)
        {
            if (array[2, 1] == 5)
            {
                if (counter % 2 == 0)
                {
                    pictureBox21.Image = Krestik;
                    pictureBox21.SizeMode = PictureBoxSizeMode.CenterImage;
                    array[2, 1] = 1;
                }
                else
                {
                    pictureBox21.Image = Nolik;
                    pictureBox21.SizeMode = PictureBoxSizeMode.CenterImage;
                    array[2, 1] = 0;
                }
                counter++;
                CheckWinner();
            }
        }

        private void PictureBox22_Click(object sender, EventArgs e)
        {
            if (array[2, 2] == 5)
            {
                if (counter % 2 == 0)
                {
                    pictureBox22.Image = Krestik;
                    pictureBox22.SizeMode = PictureBoxSizeMode.CenterImage;
                    array[2, 2] = 1;
                }
                else
                {
                    pictureBox22.Image = Nolik;
                    pictureBox22.SizeMode = PictureBoxSizeMode.CenterImage;
                    array[2, 2] = 0;
                }
                counter++;
                CheckWinner();
            }
        }

        private void PictureBox23_Click(object sender, EventArgs e)
        {
            if (array[2, 3] == 5)
            {
                if (counter % 2 == 0)
                {
                    pictureBox23.Image = Krestik;
                    pictureBox23.SizeMode = PictureBoxSizeMode.CenterImage;
                    array[2, 3] = 1;
                }
                else
                {
                    pictureBox23.Image = Nolik;
                    pictureBox23.SizeMode = PictureBoxSizeMode.CenterImage;
                    array[2, 3] = 0;
                }
                counter++;
                CheckWinner();
            }
        }

        private void PictureBox31_Click(object sender, EventArgs e)
        {
            if (array[3, 1] == 5)
            {
                if (counter % 2 == 0)
                {
                    pictureBox31.Image = Krestik;
                    pictureBox31.SizeMode = PictureBoxSizeMode.CenterImage;
                    array[3, 1] = 1;
                }
                else
                {
                    pictureBox31.Image = Nolik;
                    pictureBox31.SizeMode = PictureBoxSizeMode.CenterImage;
                    array[3, 1] = 0;
                }
                counter++;
                CheckWinner();
            }
        }

        private void PictureBox32_Click(object sender, EventArgs e)
        {
            if (array[3, 2] == 5)
            {
                if (counter % 2 == 0)
                {
                    pictureBox32.Image = Krestik;
                    pictureBox32.SizeMode = PictureBoxSizeMode.CenterImage;
                    array[3, 2] = 1;
                }
                else
                {
                    pictureBox32.Image = Nolik;
                    pictureBox32.SizeMode = PictureBoxSizeMode.CenterImage;
                    array[3, 2] = 0;
                }
                counter++;
                CheckWinner();
            }
        }
        private void PictureBox33_Click(object sender, EventArgs e)
        {
            if (array[3, 3] == 5)
            {
                if (counter % 2 == 0)
                {
                    pictureBox33.Image = Krestik;
                    pictureBox33.SizeMode = PictureBoxSizeMode.CenterImage;
                    array[3, 3] = 1;
                }
                else
                {
                    pictureBox33.Image = Nolik;
                    pictureBox33.SizeMode = PictureBoxSizeMode.CenterImage;
                    array[3, 3] = 0;
                }
                counter++;
                CheckWinner();
            }
        }
        
        int winner = 10;
        private void CheckWinner()
        {
            //победа крестиков
            for (int i = 1; i < 4; i++)
            {
                if (array[i, 1] == 1 && array[i, 2] == 1 && array[i, 3] == 1)
                {
                    MessageBox.Show("Победа крестиков");
                    krestwins++;
                    krestbox.Text = "" + krestwins + "";
                    reset();

                }
                if (array[1, i] == 1 && array[2, i] == 1 && array[3, i] == 1)
                {
                    MessageBox.Show("Победа крестиков");
                    krestwins++;
                    krestbox.Text = "" + krestwins + "";
                    reset();
                }
            }

            if (array[1, 1] == 1 && array[2, 2] == 1 && array[3, 3] == 1)
            {
                MessageBox.Show("Победа крестиков");
                krestwins++;
                krestbox.Text = "" + krestwins + "";
                reset();
            }

            if (array[1, 3] == 1 && array[2, 2] == 1 && array[3, 1] == 1)
            {
                MessageBox.Show("Победа крестиков");
                krestwins++;
                krestbox.Text = "" + krestwins + "";
                reset();
            }
            //победа ноликов
            for (int i = 1; i < 4; i++)
            {
                if (array[i, 1] == 0 && array[i, 2] == 0 && array[i, 3] == 0)
                {
                    MessageBox.Show("Победа ноликов");
                    nolwins++;
                    nolbox.Text = "" + nolwins + "";
                    reset();
                }
                if (array[1, i] == 0 && array[2, i] == 0 && array[3, i] == 0)
                {
                    MessageBox.Show("Победа ноликов");
                    nolwins++;
                    nolbox.Text = "" + nolwins + "";
                    reset();
                }
            }

            if (array[1, 1] == 0 && array[2, 2] == 0 && array[3, 3] == 0)
            {
                MessageBox.Show("Победа ноликов");
                nolwins++;
                nolbox.Text = "" + nolwins + "";
                reset();
            }

            if (array[1, 3] == 0 && array[2, 2] == 0 && array[3, 1] == 0)
            {
                MessageBox.Show("Победа ноликов");
                nolwins++;
                nolbox.Text = "" + nolwins + "";
                reset();
            }
            //ничья
            if (counter == 9 && winner == 10)
            {
                winner = 5;
                MessageBox.Show("Ничья");
                reset();
            }
        }
        private void reset_Click(object sender, EventArgs e) { reset(); }
        private void reset()
        {
            for (int i = 1; i < 4; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    array[i, j] = 5;
                }
            }
            counter = 0;
            winner = 10;
            pictureBox11.Image = null;
            pictureBox12.Image = null;
            pictureBox13.Image = null;
            pictureBox21.Image = null;
            pictureBox22.Image = null;
            pictureBox23.Image = null;
            pictureBox31.Image = null;
            pictureBox32.Image = null;
            pictureBox33.Image = null;
        }
    }
}

