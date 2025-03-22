namespace RichTextBox
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            rtbText = new System.Windows.Forms.RichTextBox();
            cmbFont = new ComboBox();
            numFontSize = new NumericUpDown();
            btnBold = new Button();
            btnItalic = new Button();
            btnUnderline = new Button();
            btnAlignLeft = new Button();
            btnAlignCenter = new Button();
            btnAlignRight = new Button();
            btnColorPalette2 = new ColorDialog();
            btnColorPalette = new Button();
            btnBulletedList = new Button();
            trackBarZoom = new TrackBar();
            btnSuperscript = new Button();
            btnSubscript = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            label1 = new Label();
            btnSave = new Button();
            label2 = new Label();
            ToolTip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)numFontSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarZoom).BeginInit();
            SuspendLayout();
            // 
            // rtbText
            // 
            rtbText.Location = new Point(12, 63);
            rtbText.Name = "rtbText";
            rtbText.Size = new Size(1062, 513);
            rtbText.TabIndex = 0;
            rtbText.Text = "";
            // 
            // cmbFont
            // 
            cmbFont.FormattingEnabled = true;
            cmbFont.Location = new Point(12, 21);
            cmbFont.Name = "cmbFont";
            cmbFont.Size = new Size(167, 23);
            cmbFont.TabIndex = 1;
            cmbFont.SelectedIndexChanged += cmbFont_SelectedIndexChanged;
            // 
            // numFontSize
            // 
            numFontSize.Location = new Point(194, 21);
            numFontSize.Name = "numFontSize";
            numFontSize.Size = new Size(111, 23);
            numFontSize.TabIndex = 2;
            numFontSize.ValueChanged += numFontSize_ValueChanged;
            // 
            // btnBold
            // 
            btnBold.Image = (Image)resources.GetObject("btnBold.Image");
            btnBold.Location = new Point(319, 16);
            btnBold.Name = "btnBold";
            btnBold.Size = new Size(30, 30);
            btnBold.TabIndex = 3;
            btnBold.UseVisualStyleBackColor = true;
            btnBold.Click += btnBold_Click;
            // 
            // btnItalic
            // 
            btnItalic.Image = (Image)resources.GetObject("btnItalic.Image");
            btnItalic.Location = new Point(356, 16);
            btnItalic.Name = "btnItalic";
            btnItalic.Size = new Size(30, 30);
            btnItalic.TabIndex = 4;
            btnItalic.UseVisualStyleBackColor = true;
            btnItalic.Click += btnItalic_Click;
            // 
            // btnUnderline
            // 
            btnUnderline.Image = (Image)resources.GetObject("btnUnderline.Image");
            btnUnderline.Location = new Point(393, 16);
            btnUnderline.Name = "btnUnderline";
            btnUnderline.Size = new Size(30, 30);
            btnUnderline.TabIndex = 5;
            btnUnderline.UseVisualStyleBackColor = true;
            btnUnderline.Click += btnUnderline_Click;
            // 
            // btnAlignLeft
            // 
            btnAlignLeft.Image = (Image)resources.GetObject("btnAlignLeft.Image");
            btnAlignLeft.Location = new Point(440, 16);
            btnAlignLeft.Name = "btnAlignLeft";
            btnAlignLeft.RightToLeft = RightToLeft.No;
            btnAlignLeft.Size = new Size(30, 30);
            btnAlignLeft.TabIndex = 6;
            btnAlignLeft.UseVisualStyleBackColor = true;
            btnAlignLeft.Click += btnAlignLeft_Click;
            // 
            // btnAlignCenter
            // 
            btnAlignCenter.Image = (Image)resources.GetObject("btnAlignCenter.Image");
            btnAlignCenter.Location = new Point(476, 16);
            btnAlignCenter.Name = "btnAlignCenter";
            btnAlignCenter.RightToLeft = RightToLeft.No;
            btnAlignCenter.Size = new Size(30, 30);
            btnAlignCenter.TabIndex = 7;
            btnAlignCenter.UseVisualStyleBackColor = true;
            btnAlignCenter.Click += btnAlignCenter_Click;
            // 
            // btnAlignRight
            // 
            btnAlignRight.Image = (Image)resources.GetObject("btnAlignRight.Image");
            btnAlignRight.Location = new Point(512, 16);
            btnAlignRight.Name = "btnAlignRight";
            btnAlignRight.RightToLeft = RightToLeft.No;
            btnAlignRight.Size = new Size(30, 30);
            btnAlignRight.TabIndex = 8;
            btnAlignRight.UseVisualStyleBackColor = true;
            btnAlignRight.Click += btnAlignRight_Click;
            // 
            // btnColorPalette
            // 
            btnColorPalette.Image = (Image)resources.GetObject("btnColorPalette.Image");
            btnColorPalette.Location = new Point(559, 16);
            btnColorPalette.Name = "btnColorPalette";
            btnColorPalette.Size = new Size(30, 30);
            btnColorPalette.TabIndex = 9;
            btnColorPalette.UseVisualStyleBackColor = true;
            btnColorPalette.Click += btnColorPalette_Click;
            // 
            // btnBulletedList
            // 
            btnBulletedList.Image = (Image)resources.GetObject("btnBulletedList.Image");
            btnBulletedList.Location = new Point(604, 16);
            btnBulletedList.Name = "btnBulletedList";
            btnBulletedList.Size = new Size(30, 30);
            btnBulletedList.TabIndex = 10;
            btnBulletedList.UseVisualStyleBackColor = true;
            btnBulletedList.Click += btnBulletedList_Click;
            // 
            // trackBarZoom
            // 
            trackBarZoom.Location = new Point(732, 12);
            trackBarZoom.Maximum = 200;
            trackBarZoom.Minimum = 10;
            trackBarZoom.Name = "trackBarZoom";
            trackBarZoom.Size = new Size(120, 45);
            trackBarZoom.TabIndex = 11;
            trackBarZoom.TickFrequency = 10;
            trackBarZoom.Value = 10;
            trackBarZoom.Scroll += trackBarZoom_Scroll;
            // 
            // btnSuperscript
            // 
            btnSuperscript.Image = (Image)resources.GetObject("btnSuperscript.Image");
            btnSuperscript.Location = new Point(649, 16);
            btnSuperscript.Name = "btnSuperscript";
            btnSuperscript.Size = new Size(30, 30);
            btnSuperscript.TabIndex = 12;
            btnSuperscript.UseVisualStyleBackColor = true;
            btnSuperscript.Click += btnSuperscript_Click;
            // 
            // btnSubscript
            // 
            btnSubscript.Image = (Image)resources.GetObject("btnSubscript.Image");
            btnSubscript.Location = new Point(685, 16);
            btnSubscript.Name = "btnSubscript";
            btnSubscript.Size = new Size(30, 30);
            btnSubscript.TabIndex = 13;
            btnSubscript.UseVisualStyleBackColor = true;
            btnSubscript.Click += btnSubscript_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(863, 32);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(78, 23);
            txtSearch.TabIndex = 14;
            // 
            // btnSearch
            // 
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(947, 27);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(30, 30);
            btnSearch.TabIndex = 15;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(863, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 16;
            label1.Text = "Sök något:";
            // 
            // btnSave
            // 
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.Location = new Point(1018, 27);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(41, 30);
            btnSave.TabIndex = 17;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1018, 9);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 18;
            label2.Text = "Spara:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 588);
            Controls.Add(label2);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnSubscript);
            Controls.Add(btnSuperscript);
            Controls.Add(trackBarZoom);
            Controls.Add(btnBulletedList);
            Controls.Add(btnColorPalette);
            Controls.Add(btnAlignRight);
            Controls.Add(btnAlignCenter);
            Controls.Add(btnAlignLeft);
            Controls.Add(btnUnderline);
            Controls.Add(btnItalic);
            Controls.Add(btnBold);
            Controls.Add(numFontSize);
            Controls.Add(cmbFont);
            Controls.Add(rtbText);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numFontSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarZoom).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbText;
        private ComboBox cmbFont;
        private NumericUpDown numFontSize;
        private Button btnBold;
        private Button btnItalic;
        private Button btnUnderline;
        private Button btnAlignLeft;
        private Button btnAlignCenter;
        private Button btnAlignRight;
        private ColorDialog btnColorPalette2;
        private Button btnColorPalette;
        private Button btnBulletedList;
        private TrackBar trackBarZoom;
        private Button btnSuperscript;
        private Button btnSubscript;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label label1;
        private Button btnSave;
        private Label label2;
        private ToolTip ToolTip;
    }
}
