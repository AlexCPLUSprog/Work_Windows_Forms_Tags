using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Work_Windows_Forms_Tags
{
    public partial class Form1 : Form
    {
        Button[,] all_buttons;
        List<Image> images;

        public Form1()
        {
            InitializeComponent();
        }
        void Fill_array_of_buttons()
        {
            all_buttons = new Button[3, 3];
            all_buttons[0, 0] = button1;
            all_buttons[1, 0] = button2;
            all_buttons[2, 0] = button3;
            all_buttons[0, 1] = button4;
            all_buttons[1, 1] = button5;
            all_buttons[2, 1] = button6;
            all_buttons[0, 2] = button7;
            all_buttons[1, 2] = button8;
            all_buttons[2, 2] = button9;
        }

        void Play_game()
        {
            Random random = new Random();
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    int random_image_index = random.Next(0, images.Count);
                    all_buttons[x, y].Image = images[random_image_index];
                    images.RemoveAt(random_image_index);
                    if (x == 2 && y == 1)
                    {                                            
                        break;
                    }
                        
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Fill_array_of_buttons();
            images = new List<Image>();

            for (int i = 1; i < 9; i++)
            {                
                images.Add(Image.FromFile(Environment.CurrentDirectory + i + ".jpg"));
            }
            Play_game();
            Check_win();
        }
               
        private void button_new_game_Click(object sender, EventArgs e)
        {
            images.Clear();            
            Fill_array_of_buttons();
            images = new List<Image>(); 

            for (int i = 1; i < 9; i++)
            {
                images.Add(Image.FromFile(Environment.CurrentDirectory + i + ".jpg"));
            }
            Play_game();
            Check_win();
        }

        void button_Click(object sender, EventArgs e)
        {
            Button select_button = (Button)sender;

            if (all_buttons != null)
            {
                for (int x = 0; x < 3; x++)
                {
                    for (int y = 0; y < 3; y++)
                    {
                        if (all_buttons[x, y] == select_button)
                        {
                            Check_neighboring_cells(x, y);
                        }

                    }
                }
            } 
        }
        void Check_neighboring_cells(int x_send, int y_send)
        {
            for (int x = x_send - 1; x <= x_send + 1; x++)
            {
                for (int y = y_send - 1; y <= y_send + 1; y++)
                {
                    if (x >= 0 && x < 3 && y >= 0 && y < 3 && (x_send == x || y_send == y))
                    {
                        if (all_buttons[x, y].Image == null)
                        {
                            all_buttons[x, y].Image = all_buttons[x_send, y_send].Image;
                            all_buttons[x_send, y_send].Image = null;
                        }
                    }
                }
            }
        }

        void Check_win()
        {
            /*if (button1.Image == images[0] && button2.Image == images[1] && button3.Image == images[2] && button4.Image == images[3] && button5.Image == images[4] && button6.Image == images[5] && button7.Image == images[6] && button8.Image == images[7] && button8.Image == images[8])
            {
                MessageBox.Show("Ура! Вы победили!");
            }*/
        }

        
    }
}
