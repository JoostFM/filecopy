namespace FileCopy.Wif
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
            BtnSet = new Button();
            panel1 = new Panel();
            LblStatus = new Label();
            TxtlblArtistTitleValue = new TextBox();
            lblArtistTitle = new Label();
            BtnClose = new Button();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnSet
            // 
            BtnSet.Dock = DockStyle.Right;
            BtnSet.Location = new Point(731, 0);
            BtnSet.Margin = new Padding(3, 4, 3, 4);
            BtnSet.Name = "BtnSet";
            BtnSet.Size = new Size(90, 85);
            BtnSet.TabIndex = 0;
            BtnSet.Text = "Set";
            BtnSet.UseVisualStyleBackColor = true;
            BtnSet.Click += BtnSelect_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(LblStatus);
            panel1.Controls.Add(TxtlblArtistTitleValue);
            panel1.Controls.Add(lblArtistTitle);
            panel1.Controls.Add(BtnClose);
            panel1.Controls.Add(BtnSet);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 495);
            panel1.Name = "panel1";
            panel1.Size = new Size(821, 85);
            panel1.TabIndex = 1;
            // 
            // LblStatus
            // 
            LblStatus.AutoSize = true;
            LblStatus.Location = new Point(79, 56);
            LblStatus.Name = "LblStatus";
            LblStatus.Size = new Size(50, 20);
            LblStatus.TabIndex = 3;
            LblStatus.Text = "label1";
            // 
            // TxtlblArtistTitleValue
            // 
            TxtlblArtistTitleValue.Location = new Point(212, 6);
            TxtlblArtistTitleValue.Name = "TxtlblArtistTitleValue";
            TxtlblArtistTitleValue.Size = new Size(489, 27);
            TxtlblArtistTitleValue.TabIndex = 2;
            // 
            // lblArtistTitle
            // 
            lblArtistTitle.AutoSize = true;
            lblArtistTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblArtistTitle.Location = new Point(79, 8);
            lblArtistTitle.Name = "lblArtistTitle";
            lblArtistTitle.Size = new Size(98, 20);
            lblArtistTitle.TabIndex = 1;
            lblArtistTitle.Text = "Artist - Title:";
            // 
            // BtnClose
            // 
            BtnClose.Dock = DockStyle.Left;
            BtnClose.Location = new Point(0, 0);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(65, 85);
            BtnClose.TabIndex = 0;
            BtnClose.Text = "Close";
            BtnClose.UseVisualStyleBackColor = true;
            BtnClose.Click += BtnClose_Click;
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 18;
            listBox1.Location = new Point(0, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(821, 495);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 580);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnSet;
        private Panel panel1;
        private Button BtnClose;
        private ListBox listBox1;
        private Label lblArtistTitle;
        private TextBox TxtlblArtistTitleValue;
        private Label LblStatus;
    }
}