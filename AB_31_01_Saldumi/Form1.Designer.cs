namespace AB_31_01_Saldumi
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
            this.izmaksa = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // but1
            // 
            this.but1.Location = new System.Drawing.Point(369, 249);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(140, 61);
            this.but1.TabIndex = 0;
            this.but1.Text = "Darbība";
            this.but1.UseVisualStyleBackColor = true;
            this.but1.Click += new System.EventHandler(this.but1_Click);
            // 
            // nauda
            // 
            this.nauda.Location = new System.Drawing.Point(279, 171);
            this.nauda.Name = "nauda";
            this.nauda.Size = new System.Drawing.Size(128, 20);
            this.nauda.TabIndex = 1;
            this.nauda.TextChanged += new System.EventHandler(this.tex1_TextChanged);
            // 
            // izmaksa
            // 
            this.izmaksa.Location = new System.Drawing.Point(497, 171);
            this.izmaksa.Name = "izmaksa";
            this.izmaksa.Size = new System.Drawing.Size(123, 20);
            this.izmaksa.TabIndex = 2;
            this.izmaksa.TextChanged += new System.EventHandler(this.tex2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = " ievadiet jūsu buģetu (eiro)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kg saldumu var iegādītes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "9.88E/kg Saldumu cena";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.izmaksa);
            this.Controls.Add(this.nauda);
            this.Controls.Add(this.but1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but1;
        private System.Windows.Forms.TextBox nauda;
        private System.Windows.Forms.TextBox izmaksa;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

