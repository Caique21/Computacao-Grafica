namespace Trabalho
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbHSIvalue = new System.Windows.Forms.Label();
            this.lbHSI = new System.Windows.Forms.Label();
            this.lbCMYvalue = new System.Windows.Forms.Label();
            this.lbCMY = new System.Windows.Forms.Label();
            this.lbRGBvalue = new System.Windows.Forms.Label();
            this.lbRGB = new System.Windows.Forms.Label();
            this.lbS = new System.Windows.Forms.Label();
            this.lbH = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btAbrirImagem = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.lbI = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(585, 267);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseClick);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.PictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.PictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(675, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(675, 104);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(113, 85);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(675, 195);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(113, 85);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(629, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "H";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(630, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "S";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(633, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "I";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.trackBar3);
            this.panel1.Controls.Add(this.lbI);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbHSIvalue);
            this.panel1.Controls.Add(this.lbHSI);
            this.panel1.Controls.Add(this.lbCMYvalue);
            this.panel1.Controls.Add(this.lbCMY);
            this.panel1.Controls.Add(this.lbRGBvalue);
            this.panel1.Controls.Add(this.lbRGB);
            this.panel1.Controls.Add(this.lbS);
            this.panel1.Controls.Add(this.lbH);
            this.panel1.Controls.Add(this.trackBar2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.btAbrirImagem);
            this.panel1.Location = new System.Drawing.Point(12, 297);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 209);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // lbHSIvalue
            // 
            this.lbHSIvalue.AutoSize = true;
            this.lbHSIvalue.Location = new System.Drawing.Point(338, 19);
            this.lbHSIvalue.Name = "lbHSIvalue";
            this.lbHSIvalue.Size = new System.Drawing.Size(13, 13);
            this.lbHSIvalue.TabIndex = 12;
            this.lbHSIvalue.Text = "0";
            // 
            // lbHSI
            // 
            this.lbHSI.AutoSize = true;
            this.lbHSI.Location = new System.Drawing.Point(311, 19);
            this.lbHSI.Name = "lbHSI";
            this.lbHSI.Size = new System.Drawing.Size(28, 13);
            this.lbHSI.TabIndex = 11;
            this.lbHSI.Text = "HSI:";
            // 
            // lbCMYvalue
            // 
            this.lbCMYvalue.AutoSize = true;
            this.lbCMYvalue.Location = new System.Drawing.Point(232, 19);
            this.lbCMYvalue.Name = "lbCMYvalue";
            this.lbCMYvalue.Size = new System.Drawing.Size(13, 13);
            this.lbCMYvalue.TabIndex = 10;
            this.lbCMYvalue.Text = "0";
            // 
            // lbCMY
            // 
            this.lbCMY.AutoSize = true;
            this.lbCMY.Location = new System.Drawing.Point(200, 19);
            this.lbCMY.Name = "lbCMY";
            this.lbCMY.Size = new System.Drawing.Size(33, 13);
            this.lbCMY.TabIndex = 9;
            this.lbCMY.Text = "CMY:";
            // 
            // lbRGBvalue
            // 
            this.lbRGBvalue.AutoSize = true;
            this.lbRGBvalue.Location = new System.Drawing.Point(128, 19);
            this.lbRGBvalue.Name = "lbRGBvalue";
            this.lbRGBvalue.Size = new System.Drawing.Size(13, 13);
            this.lbRGBvalue.TabIndex = 8;
            this.lbRGBvalue.Text = "0";
            // 
            // lbRGB
            // 
            this.lbRGB.AutoSize = true;
            this.lbRGB.Location = new System.Drawing.Point(96, 19);
            this.lbRGB.Name = "lbRGB";
            this.lbRGB.Size = new System.Drawing.Size(33, 13);
            this.lbRGB.TabIndex = 7;
            this.lbRGB.Text = "RGB:";
            // 
            // lbS
            // 
            this.lbS.AutoSize = true;
            this.lbS.Location = new System.Drawing.Point(220, 52);
            this.lbS.Name = "lbS";
            this.lbS.Size = new System.Drawing.Size(13, 13);
            this.lbS.TabIndex = 6;
            this.lbS.Text = "0";
            // 
            // lbH
            // 
            this.lbH.AutoSize = true;
            this.lbH.Location = new System.Drawing.Point(44, 52);
            this.lbH.Name = "lbH";
            this.lbH.Size = new System.Drawing.Size(13, 13);
            this.lbH.TabIndex = 5;
            this.lbH.Text = "0";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(203, 71);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Minimum = -100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(172, 45);
            this.trackBar2.TabIndex = 4;
            this.trackBar2.TickFrequency = 5;
            this.trackBar2.Scroll += new System.EventHandler(this.TrackBar2_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "S:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "H:";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 71);
            this.trackBar1.Maximum = 360;
            this.trackBar1.Minimum = -360;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(175, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            // 
            // btAbrirImagem
            // 
            this.btAbrirImagem.Location = new System.Drawing.Point(12, 14);
            this.btAbrirImagem.Name = "btAbrirImagem";
            this.btAbrirImagem.Size = new System.Drawing.Size(75, 23);
            this.btAbrirImagem.TabIndex = 0;
            this.btAbrirImagem.Text = "Abrir";
            this.btAbrirImagem.UseVisualStyleBackColor = true;
            this.btAbrirImagem.Click += new System.EventHandler(this.BtAbrirImagem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(382, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "I:";
            // 
            // lbI
            // 
            this.lbI.AutoSize = true;
            this.lbI.Location = new System.Drawing.Point(402, 52);
            this.lbI.Name = "lbI";
            this.lbI.Size = new System.Drawing.Size(13, 13);
            this.lbI.TabIndex = 14;
            this.lbI.Text = "0";
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(381, 71);
            this.trackBar3.Maximum = 255;
            this.trackBar3.Minimum = -255;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(172, 45);
            this.trackBar3.TabIndex = 15;
            this.trackBar3.TickFrequency = 5;
            this.trackBar3.Scroll += new System.EventHandler(this.TrackBar3_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btAbrirImagem;
        private System.Windows.Forms.Label lbS;
        private System.Windows.Forms.Label lbH;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbCMYvalue;
        private System.Windows.Forms.Label lbCMY;
        private System.Windows.Forms.Label lbRGBvalue;
        private System.Windows.Forms.Label lbRGB;
        private System.Windows.Forms.Label lbHSIvalue;
        private System.Windows.Forms.Label lbHSI;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label lbI;
        private System.Windows.Forms.Label label6;
    }
}

