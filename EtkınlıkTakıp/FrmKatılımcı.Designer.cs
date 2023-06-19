namespace EtkınlıkTakıp
{
    partial class FrmKatılımcı
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
            this.txtAdı = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAdı
            // 
            this.txtAdı.Location = new System.Drawing.Point(67, 104);
            this.txtAdı.Name = "txtAdı";
            this.txtAdı.Size = new System.Drawing.Size(235, 23);
            this.txtAdı.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adı:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.AutoSize = true;
            this.txtTelefon.Location = new System.Drawing.Point(12, 166);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(48, 15);
            this.txtTelefon.TabIndex = 2;
            this.txtTelefon.Text = "Telefon:";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(67, 158);
            this.txtTel.Mask = "(999) 000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(235, 23);
            this.txtTel.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Tamam";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Tamam);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(190, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.İptal);
            // 
            // FrmKatılımcı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 267);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtAdı);
            this.Controls.Add(this.label1);
            this.Name = "FrmKatılımcı";
            this.Text = "FrmKatılımcı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtAdı;
        private Label label1;
        private Label txtTelefon;
        private MaskedTextBox txtTel;
        private Button button1;
        private Button button2;
        private Label label2;
        private TextBox txtID;
    }
}