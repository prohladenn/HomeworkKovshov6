﻿using System;
using System.Windows.Forms;

namespace WindowsFormsCalculator_6
{
    public partial class Form1 : Form
    {
        float x = 0f;
        float result = 0f;
        float num = 0f;
        byte op = 0;
        int p = 0;
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик нажатия на =
        /// </summary>
        ///<remarks>
        /// Выполняет арифметическое действие, а результат сохраняет в буфере обмена
        /// </remarks>
        void res_Click(object o, EventArgs e)
        {
            switch (op)
            {
                case 0:
                    result += x;
                    break;
                case 1:
                    result -= x;
                    break;
                case 2:
                    result *= x;
                    break;
                case 3:
                    if (x == 0)
                    {
                        disp.Text = "Деление на 0";
                        Clipboard.SetText("Деление на 0");
                        x = 0;
                        p = 0;
                        return;
                    }
                    else
                    {
                        result /= x;
                        break;
                    }
            }
            disp.Text = this.result.ToString();
            Clipboard.SetText(result.ToString());
            x = 0;
            p = 0;
        }
        /// <summary>
        /// Обработчик нажатия клавиш
        /// </summary>
        void form_KeyDown(object o, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                num = int.Parse(e.KeyChar.ToString());
                numInput();
            }
            else if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                point_Click(o, e);
            }
            else if (e.KeyChar == '+')
            {
                oper_Click(o, e);
                plus_Click(o, e);
            }
            else if (e.KeyChar == '-')
            {
                oper_Click(o, e);
                minus_Click(o, e);
            }
            else if (e.KeyChar == '*')
            {
                oper_Click(o, e);
                mul_Click(o, e);
            }
            else if (e.KeyChar == '/')
            {
                oper_Click(o, e);
                div_Click(o, e);
            }
            else if (e.KeyChar == '=')
            {
                res_Click(o, e);
            }
        }
        /// <summary>
        /// Обработчик нажатия на любую из цифр 
        /// </summary>
        void num_Click(object o, EventArgs e)
        {
            num = int.Parse((o as Button).Text);
            numInput();
        }
        /// <summary>
        /// Изменение текущего числа в зависимости от пользовательсного ввода
        /// </summary>
        void numInput()
        {
            if (p == 0)
            {
                this.x = this.x * 10 + num;
            }
            else
            {
                for (int i = 0; i < p; i++)
                {
                    num /= 10;
                }
                p++;
                x += num;
            }
            disp.Text = this.x.ToString();
        }
        /// <summary>
        /// Обработчик нажатия на +, -, * или /
        /// </summary>
        void oper_Click(object o, EventArgs e)
        {
            if (x != 0)
            {
                result = x;
                x = 0;
            }
            p = 0;
        }
        /// <summary>
        /// Обработчик нажатия на +
        /// </summary>
        /// <param name="o">объект</param>
        /// <param name="e">событие</param>
        void plus_Click(object o, EventArgs e)
        {
            op = 0;
        }
        /// <summary>
        /// Обработчик нажатия на -
        /// </summary>
        /// <param name="o">объект</param>
        /// <param name="e">событие</param>
        void minus_Click(object o, EventArgs e)
        {
            op = 1;
        }
        /// <summary>
        /// Обработчик нажатия на *
        /// </summary>
        /// <param name="o">объект</param>
        /// <param name="e">событие</param>
        void mul_Click(object o, EventArgs e)
        {
            op = 2;
        }
        /// <summary>
        /// Обработчик нажатия на /
        /// </summary>
        /// <param name="o">объект</param>
        /// <param name="e">событие</param>
        void div_Click(object o, EventArgs e)
        {
            op = 3;
        }
        /// <summary>
        /// Обработчик нажатия на .
        /// </summary>
        void point_Click(object o, EventArgs e)
        {
            p = 1;
            disp.Text = x + ",";
        }
        /// <summary>
        /// Обработчик нажатия на сброс
        /// </summary>
        void ce_Click(object o, EventArgs e)
        {
            result = 0;
            x = 0;
            p = 0;
            disp.Text = "0";
        }
    }
}
