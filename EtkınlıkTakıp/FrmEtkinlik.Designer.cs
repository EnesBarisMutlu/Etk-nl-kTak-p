namespace EtkınlıkTakıp
{
    partial class FrmEtkinlik
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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAçıklama = new System.Windows.Forms.TextBox();
            this.txtTarih = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(86, 30);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(235, 23);
            this.txtAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tarih:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yer";
            // 
            // txtYer
            // 
            this.txtYer.Location = new System.Drawing.Point(86, 118);
            this.txtYer.Name = "txtYer";
            this.txtYer.Size = new System.Drawing.Size(235, 23);
            this.txtYer.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Açıklama:";
            // 
            // txtAçıklama
            // 
            this.txtAçıklama.Location = new System.Drawing.Point(86, 147);
            this.txtAçıklama.Multiline = true;
            this.txtAçıklama.Name = "txtAçıklama";
            this.txtAçıklama.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAçıklama.Size = new System.Drawing.Size(235, 196);
            this.txtAçıklama.TabIndex = 1;
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(86, 73);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(235, 23);
            this.txtTarih.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tamam";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Tamam);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(228, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FrmEtkinlik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 426);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.txtAçıklama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtYer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.Name = "FrmEtkinlik";
            this.Text = "FrmEtkinlik";
            this.Click += new System.EventHandler(this.İptal);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtAd;
        private Label label2;
        private Label label3;
        private TextBox txtYer;
        private Label label4;
        private TextBox txtAçıklama;
        private DateTimePicker txtTarih;
        private Button button1;
        private Button button2;
    }
}