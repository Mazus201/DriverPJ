﻿using DriverProject.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DriverProject.AppData
{
    class ClsFiltr
    {
        public static bool CorrectData;

        public static void TxbGot(TextBox textBox, string Text)
        {
            if (textBox.Text == Text)
            {
                textBox.Text = null;
                textBox.Foreground = Brushes.Black;
            }
        }
        public static void TxbLost(TextBox textBox, string Text)
        {
            if (textBox.Text == "")
            {
                textBox.Text = Text;
                textBox.Foreground = Brushes.LightGray;
            }
        }

        public static void TxbClear(TextBox textBox1, string Text)
        {
            textBox1.Foreground = Brushes.LightGray;
            textBox1.Text = Text;
        }

        public static void TxbBorder(TextBox textBox, Border border, string Text)
        {
            if (textBox.Text == Text)
            {
                border.Visibility = Visibility.Visible;
                CorrectData = false;
            }
            else
                CorrectData = true;
        }
        public static void FuncError(string ErrorText)
        {
            MessageBox1 box1 = new MessageBox1($"{ErrorText}");
            box1.ShowDialog();
        }
    }
}
