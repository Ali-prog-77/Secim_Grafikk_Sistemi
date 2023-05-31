namespace Secim_Grafikk_Sistemi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtilce = new System.Windows.Forms.TextBox();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txtc = new System.Windows.Forms.TextBox();
            this.btnoygiris = new System.Windows.Forms.Button();
            this.btncıkıs = new System.Windows.Forms.Button();
            this.btngrafik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(115, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "İstanbul Seçim Grafiği \r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(29, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "İlçe Giriniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(53, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "A Partisi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(52, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "B Partisi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(51, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "C Partisi:";
            // 
            // txtilce
            // 
            this.txtilce.Location = new System.Drawing.Point(135, 84);
            this.txtilce.Name = "txtilce";
            this.txtilce.Size = new System.Drawing.Size(164, 20);
            this.txtilce.TabIndex = 1;
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(135, 126);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(164, 20);
            this.txta.TabIndex = 1;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(135, 152);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(164, 20);
            this.txtb.TabIndex = 1;
            this.txtb.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(135, 182);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(164, 20);
            this.txtc.TabIndex = 1;
            this.txtc.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnoygiris
            // 
            this.btnoygiris.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnoygiris.Location = new System.Drawing.Point(135, 208);
            this.btnoygiris.Name = "btnoygiris";
            this.btnoygiris.Size = new System.Drawing.Size(164, 38);
            this.btnoygiris.TabIndex = 2;
            this.btnoygiris.Text = "Oy Girişi Yap!";
            this.btnoygiris.UseVisualStyleBackColor = true;
            this.btnoygiris.Click += new System.EventHandler(this.btnoygiris_Click);
            // 
            // btncıkıs
            // 
            this.btncıkıs.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncıkıs.Location = new System.Drawing.Point(217, 252);
            this.btncıkıs.Name = "btncıkıs";
            this.btncıkıs.Size = new System.Drawing.Size(82, 38);
            this.btncıkıs.TabIndex = 2;
            this.btncıkıs.Text = "Çıkış";
            this.btncıkıs.UseVisualStyleBackColor = true;
            // 
            // btngrafik
            // 
            this.btngrafik.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngrafik.Location = new System.Drawing.Point(135, 252);
            this.btngrafik.Name = "btngrafik";
            this.btngrafik.Size = new System.Drawing.Size(76, 38);
            this.btngrafik.TabIndex = 2;
            this.btngrafik.Text = "Grafikler";
            this.btngrafik.UseVisualStyleBackColor = true;
            this.btngrafik.Click += new System.EventHandler(this.btngrafik_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(394, 327);
            this.Controls.Add(this.btngrafik);
            this.Controls.Add(this.btncıkıs);
            this.Controls.Add(this.btnoygiris);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.txtilce);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Seçim Grafik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtilce;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.Button btnoygiris;
        private System.Windows.Forms.Button btncıkıs;
        private System.Windows.Forms.Button btngrafik;
    }
}

