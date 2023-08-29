namespace RSS_Ile_Haber_Basliklari_Cekme
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnHurriyet = new Button();
            btnMilliyet = new Button();
            btnNtv = new Button();
            btnSabah = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btnHurriyet
            // 
            btnHurriyet.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnHurriyet.Font = new Font("Sitka Banner Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHurriyet.Location = new Point(12, 392);
            btnHurriyet.Name = "btnHurriyet";
            btnHurriyet.Size = new Size(147, 40);
            btnHurriyet.TabIndex = 0;
            btnHurriyet.Text = "HÜRRİYET";
            btnHurriyet.UseVisualStyleBackColor = true;
            btnHurriyet.Click += btnHurriyet_Click;
            // 
            // btnMilliyet
            // 
            btnMilliyet.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnMilliyet.Font = new Font("Sitka Banner Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMilliyet.Location = new Point(165, 392);
            btnMilliyet.Name = "btnMilliyet";
            btnMilliyet.Size = new Size(147, 40);
            btnMilliyet.TabIndex = 1;
            btnMilliyet.Text = "MİLLİYET";
            btnMilliyet.UseVisualStyleBackColor = true;
            btnMilliyet.Click += btnMilliyet_Click;
            // 
            // btnNtv
            // 
            btnNtv.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnNtv.Font = new Font("Sitka Banner Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNtv.Location = new Point(318, 392);
            btnNtv.Name = "btnNtv";
            btnNtv.Size = new Size(147, 40);
            btnNtv.TabIndex = 2;
            btnNtv.Text = "NTV";
            btnNtv.UseVisualStyleBackColor = true;
            btnNtv.Click += btnNtv_Click;
            // 
            // btnSabah
            // 
            btnSabah.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSabah.Font = new Font("Sitka Banner Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSabah.Location = new Point(471, 392);
            btnSabah.Name = "btnSabah";
            btnSabah.Size = new Size(147, 40);
            btnSabah.TabIndex = 3;
            btnSabah.Text = "SABAH";
            btnSabah.UseVisualStyleBackColor = true;
            btnSabah.Click += btnSabah_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Location = new Point(12, 344);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox2.Location = new Point(165, 344);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(147, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox3.Location = new Point(318, 344);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(147, 42);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox4.Location = new Point(471, 344);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(147, 42);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(606, 319);
            listBox1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(151, 178, 172);
            ClientSize = new Size(630, 444);
            Controls.Add(listBox1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnSabah);
            Controls.Add(btnNtv);
            Controls.Add(btnMilliyet);
            Controls.Add(btnHurriyet);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(35, 28, 176);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "RSS İle Haber Başlıkları";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnHurriyet;
        private Button btnMilliyet;
        private Button btnNtv;
        private Button btnSabah;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private ListBox listBox1;
    }
}