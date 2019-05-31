using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Version1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int X_Car1, Y_Car1, X_Car2, Y_Car2, X_Car3, Y_Car3, X_Player, Y_Player;
        int X_Road1, X_Road2, X_Road3, X_Road4, X_Road5;
        int Y_Road1, Y_Road2, Y_Road3, Y_Road4, Y_Road5;
        private void tmRoad_Tick(object sender, EventArgs e)
        {
            X_Road1 = ptrRoad1.Location.X;
            Y_Road1 = ptrRoad1.Location.Y;
            X_Road1 -= 10;
            if (X_Road1 + ptrRoad1.Size.Width < 0)
            {
                X_Road1 = this.Size.Width;
            }
            ptrRoad1.Location = new Point(X_Road1, Y_Road1);

            X_Road2 = ptrRoad2.Location.X;
            Y_Road2 = ptrRoad2.Location.Y;
            X_Road2 -= 10;
            if (X_Road2 + ptrRoad2.Size.Width < 0)
            {
                X_Road2 = this.Size.Width;
            }
            ptrRoad2.Location = new Point(X_Road2, Y_Road2);

            X_Road3 = ptrRoad3.Location.X;
            Y_Road3 = ptrRoad3.Location.Y;
            X_Road3 -= 10;
            if (X_Road3 + ptrRoad3.Size.Width < 0)
            {
                X_Road3 = this.Size.Width;
            }
            ptrRoad3.Location = new Point(X_Road3, Y_Road3);

            X_Road4 = ptrRoad4.Location.X;
            Y_Road4 = ptrRoad4.Location.Y;
            X_Road4 -= 10;
            if (X_Road4 + ptrRoad4.Size.Width < 0)
            {
                X_Road4 = this.Size.Width;
            }
            ptrRoad4.Location = new Point(X_Road4, Y_Road4);

            X_Road5 = ptrRoad5.Location.X;
            Y_Road5 = ptrRoad5.Location.Y;
            X_Road5 -= 10;
            if (X_Road5 + ptrRoad5.Size.Width < 0)
            {
                X_Road5 = this.Size.Width;
            }
            ptrRoad5.Location = new Point(X_Road5, Y_Road5);
        }

        Random rd1;
        Random rd2;
        Random rd3;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            X_Player = ptrPlayer.Location.X;
            Y_Player = ptrPlayer.Location.Y;
            if ((Keys)e.KeyCode == Keys.Up)
            {
                
                if (Y_Player >= 0)
                {
                    Y_Player -= 8;
                    ptrPlayer.Location = new Point(X_Player, Y_Player);
                }
            }
            else if ((Keys)e.KeyCode == Keys.Down)
            {
                if (Y_Player + ptrPlayer.Size.Height + 40 <= this.Size.Height)
                {
                    Y_Player += 8;
                    ptrPlayer.Location = new Point(X_Player, Y_Player);
                }
            }
            else if ((Keys)e.KeyCode == Keys.Right)
            {
                
                if (X_Player + ptrPlayer.Size.Width + 23 <= this.Size.Width)
                {
                    X_Player += 8;
                    ptrPlayer.Location = new Point(X_Player, Y_Player);
                }
                
            }
            else if ((Keys)e.KeyCode == Keys.Left)
            {
                if (X_Player - 8 >= 0)
                {
                    X_Player -= 8;
                    ptrPlayer.Location = new Point(X_Player, Y_Player);
                }
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            rd1 = new Random();
            rd2 = new Random();
            rd3 = new Random();

            this.Size = new Size(800, 350);

            // Hiện xe Player
            ptrPlayer.Image = Image.FromFile("image/PlayerCar.png");
            ptrPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
            ptrPlayer.Size = new Size(80, 25);
            ptrPlayer.Location = new Point(50, 50);

            tmCar1.Start();

            // Hiện xe chướng ngại vật 1
            ptr1.Image = Image.FromFile("image/Car1.png");
            ptr1.SizeMode = PictureBoxSizeMode.StretchImage;
            ptr1.Size = new Size(80, 30);
            ptr1.Location = new Point(this.Size.Width - ptr1.Size.Width - 20, 10);

            // Hiện xe chướng ngại vật 2
            ptr2.Image = Image.FromFile("image/Car2.png");
            ptr2.SizeMode = PictureBoxSizeMode.StretchImage;
            ptr2.Size = new Size(80, 25);
            ptr2.Location = new Point(this.Size.Width - ptr1.Size.Width - 20, ptr1.Location.Y + ptr1.Size.Height + 30);

            // Hiện xe chướng ngại vật 3
            ptr3.Image = Image.FromFile("image/Car3.png");
            ptr3.SizeMode = PictureBoxSizeMode.StretchImage;
            ptr3.Size = new Size(80, 25);
            ptr3.Location = new Point(this.Size.Width - ptr1.Size.Width - 20, ptr2.Location.Y + ptr2.Size.Height + 30);

            // Hiện Lằn đường
            ptrRoad1.Image = Image.FromFile("image/road.png");
            ptrRoad1.SizeMode = PictureBoxSizeMode.StretchImage;
            ptrRoad1.Size = new Size(80, 10);

            ptrRoad2.Image = Image.FromFile("image/road.png");
            ptrRoad2.SizeMode = PictureBoxSizeMode.StretchImage;
            ptrRoad2.Size = new Size(80, 10);

            ptrRoad3.Image = Image.FromFile("image/road.png");
            ptrRoad3.SizeMode = PictureBoxSizeMode.StretchImage;
            ptrRoad3.Size = new Size(80, 10);

            ptrRoad4.Image = Image.FromFile("image/road.png");
            ptrRoad4.SizeMode = PictureBoxSizeMode.StretchImage;
            ptrRoad4.Size = new Size(80, 10);

            ptrRoad5.Image = Image.FromFile("image/road.png");
            ptrRoad5.SizeMode = PictureBoxSizeMode.StretchImage;
            ptrRoad5.Size = new Size(80, 10);

            tmRoad.Start();

        }

        private void tmCar1_Tick(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            

            Y_Car1 = ptr1.Location.Y;
            X_Car1 = ptr1.Location.X;
            X_Car1 -= 4;
            if (X_Car1 + ptr1.Size.Width < 0)
            {
                X_Car1 = this.Size.Width + ptr1.Size.Width;
                Y_Car1 = rd1.Next(0, this.Size.Height - ptr1.Size.Height - 30);
            }
            ptr1.Location = new Point(X_Car1, Y_Car1);

            Y_Car2 = ptr2.Location.Y;
            X_Car2 = ptr2.Location.X;
            X_Car2 -= 6;
            if (X_Car2 + ptr2.Size.Width < 0)
            {
                X_Car2 = this.Size.Width + ptr2.Size.Width;
                Y_Car2 = rd2.Next(0, this.Size.Height - ptr1.Size.Height - 30);
            }
            ptr2.Location = new Point(X_Car2, Y_Car2);

            Y_Car3 = ptr3.Location.Y;
            X_Car3 = ptr3.Location.X;
            X_Car3 -= 8;
            if (X_Car3 + ptr3.Size.Width < 0)
            {
                X_Car3 = this.Size.Width + ptr3.Size.Width;
                Y_Car3 = rd3.Next(0, this.Size.Height - ptr1.Size.Height - 30);
            }
            ptr3.Location = new Point(X_Car3, Y_Car3);

            // Kiểm tra đụng độ với xe 1
            if (X_Car1 >= X_Player && X_Car1 <= X_Player + ptrPlayer.Size.Width && Y_Player >= Y_Car1 && Y_Player <= Y_Car1 + ptr1.Size.Height || Y_Car1 >= Y_Player && Y_Car1 <= Y_Player + ptrPlayer.Size.Height && X_Car1 >= X_Player && X_Car1 <= X_Player + ptrPlayer.Size.Width || X_Player >= X_Car1 && X_Player <= X_Car1 + ptr1.Size.Width && Y_Player >= Y_Car1 && Y_Player <= Y_Car1 + ptr1.Size.Height || X_Player >= X_Car1 && X_Player <= X_Car1 + ptr1.Size.Width && Y_Car1 >= Y_Player && Y_Car1 <= Y_Player + ptrPlayer.Size.Height)
            {
                tmCar1.Stop();
                tmRoad.Stop();
                MessageBox.Show("Bùm");
            }

            // Kiểm tra đụng độ với xe 2
            if (X_Car2 >= X_Player && X_Car2 <= X_Player + ptrPlayer.Size.Width && Y_Player >= Y_Car2 && Y_Player <= Y_Car2 + ptr2.Size.Height || Y_Car2 >= Y_Player && Y_Car2 <= Y_Player + ptrPlayer.Size.Height && X_Car2 >= X_Player && X_Car2 <= X_Player + ptrPlayer.Size.Width || X_Player >= X_Car2 && X_Player <= X_Car2 + ptr2.Size.Width && Y_Player >= Y_Car2 && Y_Player <= Y_Car2 + ptr2.Size.Height || X_Player >= X_Car2 && X_Player <= X_Car2 + ptr2.Size.Width && Y_Car2 >= Y_Player && Y_Car2 <= Y_Player + ptrPlayer.Size.Height)
            {
                tmCar1.Stop();
                tmRoad.Stop();
                MessageBox.Show("Bùm");
            }

            // Kiểm tra đụng độ với xe 3
            if (X_Car3 >= X_Player && X_Car3 <= X_Player + ptrPlayer.Size.Width && Y_Player >= Y_Car3 && Y_Player <= Y_Car3 + ptr3.Size.Height || Y_Car3 >= Y_Player && Y_Car3 <= Y_Player + ptrPlayer.Size.Height && X_Car3 >= X_Player && X_Car3 <= X_Player + ptrPlayer.Size.Width || X_Player >= X_Car3 && X_Player <= X_Car3 + ptr3.Size.Width && Y_Player >= Y_Car3 && Y_Player <= Y_Car3 + ptr3.Size.Height || X_Player >= X_Car3 && X_Player <= X_Car3 + ptr3.Size.Width && Y_Car3 >= Y_Player && Y_Car3 <= Y_Player + ptrPlayer.Size.Height)
            {
                tmCar1.Stop();
                tmRoad.Stop();
                MessageBox.Show("Bùm");
            }

        }
    }
}
