﻿using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsCalculator_6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.Windows.Forms.TableLayoutPanel input;
        private System.Windows.Forms.Label disp;
        private System.Windows.Forms.TableLayoutPanel nums;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button ce;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button res;
        private void InitializeComponent()
        {
            this.input = new System.Windows.Forms.TableLayoutPanel();
            this.disp = new System.Windows.Forms.Label();
            this.nums = new System.Windows.Forms.TableLayoutPanel();
            this.res = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.ce = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.input.SuspendLayout();
            this.nums.SuspendLayout();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Name = "input";
            this.input.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
            this.input.ColumnCount = 1;
            this.input.RowCount = 3;
            this.input.Controls.Add(this.disp, 0, 0);
            this.input.Controls.Add((Control)this.nums, 0, 1);
            this.input.Controls.Add((Control)this.res, 0, 2);
            this.input.Location = new System.Drawing.Point(15, 15);
            this.input.Margin = new System.Windows.Forms.Padding(10);
            this.input.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.input.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50));
            this.input.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80));
            this.input.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20));
            this.input.Size = new System.Drawing.Size(300, 350);
            // 
            // nums
            // 
            this.nums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nums.Name = "nums";
            this.nums.RowCount = 5;
            this.nums.ColumnCount = 4;
            this.nums.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25));
            this.nums.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25));
            this.nums.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25));
            this.nums.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25));
            this.nums.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25));
            this.nums.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25));
            this.nums.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25));
            this.nums.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25));
            this.nums.Controls.Add(this.b7, 0, 0);
            this.nums.Controls.Add(this.b8, 1, 0);
            this.nums.Controls.Add(this.b9, 2, 0);
            this.nums.Controls.Add(this.plus, 3, 0);
            this.nums.Controls.Add(this.b4, 0, 1);
            this.nums.Controls.Add(this.b5, 1, 1);
            this.nums.Controls.Add(this.b6, 2, 1);
            this.nums.Controls.Add(this.minus, 3, 1);
            this.nums.Controls.Add(this.b1, 0, 2);
            this.nums.Controls.Add(this.b2, 1, 2);
            this.nums.Controls.Add(this.b3, 2, 2);
            this.nums.Controls.Add(this.mul, 3, 2);
            this.nums.Controls.Add(this.ce, 0, 3);
            this.nums.Controls.Add(this.b0, 1, 3);
            this.nums.Controls.Add(this.point, 2, 3);
            this.nums.Controls.Add(this.div, 3, 3);
            this.nums.Size = new System.Drawing.Size(300, 300);
            // 
            // disp
            // 
            this.disp.Name = "disp";
            this.disp.Text = "0";
            this.disp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.disp.Size = new System.Drawing.Size(this.Width, 50);
            this.disp.BorderStyle = BorderStyle.None;
            this.disp.Font = new System.Drawing.Font("Arial", 19, System.Drawing.FontStyle.Bold);
            this.disp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // res
            // 
            this.res.Dock = System.Windows.Forms.DockStyle.Fill;
            this.res.Font = new Font("Arial", 20);
            this.res.Name = "res";
            this.res.Text = "=";
            this.res.TabIndex = 0;
            // 
            // plus
            // 
            this.plus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plus.Font = new Font("Arial", 20);
            this.plus.Name = "plus";
            this.plus.Text = "+";
            // 
            // minus
            // 
            this.minus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minus.Font = new Font("Arial", 20);
            this.minus.Name = "minus";
            this.minus.Text = "-";
            // 
            // mul
            // 
            this.mul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mul.Font = new Font("Arial", 20);
            this.mul.Name = "mul";
            this.mul.Text = "*";
            // 
            // div
            // 
            this.div.Dock = System.Windows.Forms.DockStyle.Fill;
            this.div.Font = new Font("Arial", 20);
            this.div.Name = "div";
            this.div.Text = "/";
            // 
            // b0
            // 
            this.b0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b0.Font = new Font("Arial", 14);
            this.b0.Name = "b0";
            this.b0.Text = "0";
            // 
            // b1
            // 
            this.b1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b1.Font = new Font("Arial", 14);
            this.b1.Name = "b1";
            this.b1.Text = "1";
            // 
            // b2
            // 
            this.b2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b2.Font = new Font("Arial", 14);
            this.b2.Name = "b2";
            this.b2.Text = "2";

            // 
            // b3
            // 
            this.b3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b3.Font = new Font("Arial", 14);
            this.b3.Name = "b3";
            this.b3.Text = "3";
            // 
            // b4
            // 
            this.b4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b4.Font = new Font("Arial", 14);
            this.b4.Name = "b4";
            this.b4.Text = "4";
            // 
            // b5
            // 
            this.b5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b5.Name = "b5";
            this.b5.Font = new Font("Arial", 14);
            this.b5.Text = "5";
            // 
            // b6
            // 
            this.b6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b6.Font = new Font("Arial", 14);
            this.b6.Name = "b6";
            this.b6.Text = "6";
            // 
            // b7
            // 
            this.b7.Name = "b7";
            this.b7.Text = "7";
            this.b7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b7.Font = new Font("Arial", 14);
            // 
            // b8
            // 
            this.b8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b8.Font = new Font("Arial", 14);
            this.b8.Name = "b8";
            this.b8.Text = "8";
            // 
            // b9
            // 
            this.b9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b9.Font = new Font("Arial", 14);
            this.b9.Name = "b9";
            this.b9.Text = "9";
            // 
            // point
            // 
            this.point.Name = "point";
            this.point.Dock = System.Windows.Forms.DockStyle.Fill;
            this.point.Font = new Font("Arial", 14, FontStyle.Bold);
            this.point.Text = ".";
            this.point.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ce
            // 
            this.ce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ce.Font = new Font("Arial", 14);
            this.ce.Name = "ce";
            this.ce.Text = "CE";

            // 
            // Form1
            //             
            this.Name = "CalculatorForm";
            this.MaximizeBox = false;
            this.KeyPreview = true;
            this.BackColor = Color.White;
            this.Controls.Add(this.input);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.MinimumSize = new System.Drawing.Size(300, 340);
            this.ClientSize = new System.Drawing.Size(330, 370);
            this.MaximumSize = new System.Drawing.Size(700, 700);
            this.input.ResumeLayout(false);
            this.input.PerformLayout();
            this.nums.ResumeLayout(false);
            this.ResumeLayout(false);

            b0.Click += new EventHandler(num_Click);
            b1.Click += new EventHandler(num_Click);
            b2.Click += new EventHandler(num_Click);
            b3.Click += new EventHandler(num_Click);
            b4.Click += new EventHandler(num_Click);
            b5.Click += new EventHandler(num_Click);
            b6.Click += new EventHandler(num_Click);
            b7.Click += new EventHandler(num_Click);
            b8.Click += new EventHandler(num_Click);
            b9.Click += new EventHandler(num_Click);
        }
    }
}
