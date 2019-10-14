namespace ConvertImage
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
            this.btn_sec = new DevExpress.XtraEditors.SimpleButton();
            this.btn_kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sifirla = new DevExpress.XtraEditors.SimpleButton();
            this.btn_getir = new DevExpress.XtraEditors.SimpleButton();
            this.pictureDbSet1 = new ConvertImage.PictureDbSet();
            this.pb_secilen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDbSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_secilen)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sec
            // 
            this.btn_sec.Location = new System.Drawing.Point(12, 12);
            this.btn_sec.Name = "btn_sec";
            this.btn_sec.Size = new System.Drawing.Size(266, 23);
            this.btn_sec.TabIndex = 1;
            this.btn_sec.Text = "Resim Seç";
            this.btn_sec.Click += new System.EventHandler(this.btn_sec_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(12, 267);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(266, 23);
            this.btn_kaydet.TabIndex = 2;
            this.btn_kaydet.Text = "Db ye kaydet";
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_sifirla
            // 
            this.btn_sifirla.Location = new System.Drawing.Point(158, 296);
            this.btn_sifirla.Name = "btn_sifirla";
            this.btn_sifirla.Size = new System.Drawing.Size(120, 23);
            this.btn_sifirla.TabIndex = 3;
            this.btn_sifirla.Text = "Sıfırla";
            this.btn_sifirla.Click += new System.EventHandler(this.btn_sifirla_Click);
            // 
            // btn_getir
            // 
            this.btn_getir.Location = new System.Drawing.Point(12, 296);
            this.btn_getir.Name = "btn_getir";
            this.btn_getir.Size = new System.Drawing.Size(125, 23);
            this.btn_getir.TabIndex = 4;
            this.btn_getir.Text = "Db den getir";
            this.btn_getir.Click += new System.EventHandler(this.btn_getir_Click);
            // 
            // pictureDbSet1
            // 
            this.pictureDbSet1.DataSetName = "PictureDbSet";
            this.pictureDbSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pb_secilen
            // 
            this.pb_secilen.Location = new System.Drawing.Point(12, 41);
            this.pb_secilen.Name = "pb_secilen";
            this.pb_secilen.Size = new System.Drawing.Size(266, 220);
            this.pb_secilen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_secilen.TabIndex = 5;
            this.pb_secilen.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 332);
            this.Controls.Add(this.pb_secilen);
            this.Controls.Add(this.btn_getir);
            this.Controls.Add(this.btn_sifirla);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.btn_sec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureDbSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_secilen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_sec;
        private DevExpress.XtraEditors.SimpleButton btn_kaydet;
        private DevExpress.XtraEditors.SimpleButton btn_sifirla;
        private DevExpress.XtraEditors.SimpleButton btn_getir;
        private PictureDbSet pictureDbSet1;
        private System.Windows.Forms.PictureBox pb_secilen;

    }
}

