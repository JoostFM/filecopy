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
            BtnSet.BackColor = Color.Orange;
            BtnSet.Dock = DockStyle.Right;
            BtnSet.Location = new Point(639, 0);
            BtnSet.Name = "BtnSet";
            BtnSet.Size = new Size(79, 64);
            BtnSet.TabIndex = 0;
            BtnSet.Text = "Set";
            BtnSet.UseVisualStyleBackColor = false;
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
            panel1.Location = new Point(0, 371);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(718, 64);
            panel1.TabIndex = 1;
            // 
            // LblStatus
            // 
            LblStatus.AutoSize = true;
            LblStatus.Location = new Point(69, 42);
            LblStatus.Name = "LblStatus";
            LblStatus.Size = new Size(38, 15);
            LblStatus.TabIndex = 3;
            LblStatus.Text = "label1";
            // 
            // TxtlblArtistTitleValue
            // 
            TxtlblArtistTitleValue.Location = new Point(186, 4);
            TxtlblArtistTitleValue.Margin = new Padding(3, 2, 3, 2);
            TxtlblArtistTitleValue.Name = "TxtlblArtistTitleValue";
            TxtlblArtistTitleValue.Size = new Size(412, 23);
            TxtlblArtistTitleValue.TabIndex = 2;
            // 
            // lblArtistTitle
            // 
            lblArtistTitle.AutoSize = true;
            lblArtistTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblArtistTitle.Location = new Point(69, 6);
            lblArtistTitle.Name = "lblArtistTitle";
            lblArtistTitle.Size = new Size(77, 15);
            lblArtistTitle.TabIndex = 1;
            lblArtistTitle.Text = "Artist - Title:";
            // 
            // BtnClose
            // 
            BtnClose.Dock = DockStyle.Left;
            BtnClose.Location = new Point(0, 0);
            BtnClose.Margin = new Padding(3, 2, 3, 2);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(57, 64);
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
            listBox1.ItemHeight = 14;
            listBox1.Location = new Point(0, 0);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(718, 371);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 435);
            Controls.Add(listBox1);
            Controls.Add(panel1);
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