﻿namespace AB_31_01_Saldumi
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.but1 = new System.Windows.Forms.Button();
            this.nauda = new System.Windows.Forms.TextBox();
            this.daudzums = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Šokolāde = new System.Windows.Forms.CheckBox();
            this.cepumi = new System.Windows.Forms.CheckBox();
            this.sula = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.vards = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // but1
            // 
            this.but1.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.but1.BackColor = System.Drawing.Color.DimGray;
            this.but1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.but1.Location = new System.Drawing.Point(420, 216);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(140, 61);
            this.but1.TabIndex = 0;
            this.but1.Text = "Darbība";
            this.but1.UseVisualStyleBackColor = false;
            this.but1.Click += new System.EventHandler(this.but1_Click);
            // 
            // nauda
            // 
            this.nauda.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.nauda.Location = new System.Drawing.Point(281, 171);
            this.nauda.Name = "nauda";
            this.nauda.Size = new System.Drawing.Size(128, 20);
            this.nauda.TabIndex = 1;
            this.nauda.TextChanged += new System.EventHandler(this.tex1_TextChanged);
            // 
            // daudzums
            // 
            this.daudzums.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.daudzums.Location = new System.Drawing.Point(437, 171);
            this.daudzums.Name = "daudzums";
            this.daudzums.Size = new System.Drawing.Size(123, 20);
            this.daudzums.TabIndex = 2;
            this.daudzums.TextChanged += new System.EventHandler(this.tex2_TextChanged);
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(278, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = " ievadiet jūsu buģetu (eiro)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(434, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kg saldumu var iegādītes";
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(276, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 5;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Šokolāde
            // 
            this.Šokolāde.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.Šokolāde.AutoSize = true;
            this.Šokolāde.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Šokolāde.Location = new System.Drawing.Point(279, 260);
            this.Šokolāde.Name = "Šokolāde";
            this.Šokolāde.Size = new System.Drawing.Size(71, 17);
            this.Šokolāde.TabIndex = 6;
            this.Šokolāde.Text = "Šokolāde";
            this.Šokolāde.UseVisualStyleBackColor = false;
            this.Šokolāde.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // cepumi
            // 
            this.cepumi.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.cepumi.AutoSize = true;
            this.cepumi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cepumi.Location = new System.Drawing.Point(279, 237);
            this.cepumi.Name = "cepumi";
            this.cepumi.Size = new System.Drawing.Size(60, 17);
            this.cepumi.TabIndex = 7;
            this.cepumi.Text = "cepumi";
            this.cepumi.UseVisualStyleBackColor = false;
            this.cepumi.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // sula
            // 
            this.sula.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.sula.AutoSize = true;
            this.sula.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sula.Location = new System.Drawing.Point(281, 214);
            this.sula.Name = "sula";
            this.sula.Size = new System.Drawing.Size(45, 17);
            this.sula.TabIndex = 8;
            this.sula.Text = "sula";
            this.sula.UseVisualStyleBackColor = false;
            this.sula.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(150, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "6.00/kg Sulas cena";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(150, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "5.00/kg Cepumu cena";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(148, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "3.00/kg Šokolādes cena";
            // 
            // vards
            // 
            this.vards.Location = new System.Drawing.Point(153, 114);
            this.vards.Name = "vards";
            this.vards.Size = new System.Drawing.Size(128, 20);
            this.vards.TabIndex = 12;
            this.vards.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(12, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ievadiet savu vārdu uzvārdu";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 171);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.BackgroundImage = global::AB_31_01_Saldumi.Properties.Resources.Mani_saldumi_1_koncas_3;
            this.ClientSize = new System.Drawing.Size(649, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.vards);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sula);
            this.Controls.Add(this.cepumi);
            this.Controls.Add(this.Šokolāde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.daudzums);
            this.Controls.Add(this.nauda);
            this.Controls.Add(this.but1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but1;
        private System.Windows.Forms.TextBox nauda;
        private System.Windows.Forms.TextBox daudzums;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox Šokolāde;
        private System.Windows.Forms.CheckBox cepumi;
        private System.Windows.Forms.CheckBox sula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox vards;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

