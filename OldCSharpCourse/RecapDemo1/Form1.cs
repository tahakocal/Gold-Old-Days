﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateButtons();
            //this.Controls.Add(button); //butonu ekrana koyduk
            //button.Width = 50;
            //button.Height = 50;
            //button.Text = "My button"; // isim değiştirdik
        }

        private void GenerateButtons()
        {
            Button[,] buttons = new Button[15, 15]; // buton nesnesini oluşturduk
            int top = 0;
            int left = 0;
            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    left += 50;
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }

                    if ((i+j)%2==0)
                    {
                        buttons[i, j].Text = "Siyah";
                    }
                    else
                    {
                        buttons[i, j].Text = "Beyaz";
                    }

                    this.Controls.Add(buttons[i, j]);
                }

                top += 50;
                left = 0;
            }
        }
    }
}
