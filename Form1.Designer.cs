namespace BitmapFontGenerator
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
            this.lsbFontList = new System.Windows.Forms.ListBox();
            this.lblFontName = new System.Windows.Forms.Label();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.cmsPreview = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSaveImage = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudCharacterWidth = new System.Windows.Forms.NumericUpDown();
            this.nudCharacterHeight = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudFontSize = new System.Windows.Forms.NumericUpDown();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.btnForeground = new System.Windows.Forms.Button();
            this.btnBackground = new System.Windows.Forms.Button();
            this.cbTransparentBackground = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudCorrectionX = new System.Windows.Forms.NumericUpDown();
            this.nudCorrectionY = new System.Windows.Forms.NumericUpDown();
            this.pnlPreview = new System.Windows.Forms.Panel();
            this.btnLoadCustomFont = new System.Windows.Forms.Button();
            this.cbUseCustomFont = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            this.cmsPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharacterWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharacterHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCorrectionX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCorrectionY)).BeginInit();
            this.pnlPreview.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsbFontList
            // 
            this.lsbFontList.FormattingEnabled = true;
            this.lsbFontList.ItemHeight = 16;
            this.lsbFontList.Location = new System.Drawing.Point(13, 42);
            this.lsbFontList.Margin = new System.Windows.Forms.Padding(4);
            this.lsbFontList.Name = "lsbFontList";
            this.lsbFontList.Size = new System.Drawing.Size(191, 244);
            this.lsbFontList.TabIndex = 0;
            this.lsbFontList.SelectedIndexChanged += new System.EventHandler(this.lsbFontList_SelectedIndexChanged);
            // 
            // lblFontName
            // 
            this.lblFontName.AutoSize = true;
            this.lblFontName.Location = new System.Drawing.Point(211, 12);
            this.lblFontName.Name = "lblFontName";
            this.lblFontName.Size = new System.Drawing.Size(87, 16);
            this.lblFontName.TabIndex = 1;
            this.lblFontName.Text = "Font name: []";
            // 
            // pbPreview
            // 
            this.pbPreview.ContextMenuStrip = this.cmsPreview;
            this.pbPreview.Location = new System.Drawing.Point(3, 3);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(100, 100);
            this.pbPreview.TabIndex = 2;
            this.pbPreview.TabStop = false;
            // 
            // cmsPreview
            // 
            this.cmsPreview.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSaveImage});
            this.cmsPreview.Name = "cmsPreview";
            this.cmsPreview.Size = new System.Drawing.Size(99, 26);
            // 
            // tsmiSaveImage
            // 
            this.tsmiSaveImage.Name = "tsmiSaveImage";
            this.tsmiSaveImage.Size = new System.Drawing.Size(98, 22);
            this.tsmiSaveImage.Text = "Save";
            this.tsmiSaveImage.Click += new System.EventHandler(this.tsmiSaveImage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(520, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Character width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Character height";
            // 
            // nudCharacterWidth
            // 
            this.nudCharacterWidth.Location = new System.Drawing.Point(575, 143);
            this.nudCharacterWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCharacterWidth.Name = "nudCharacterWidth";
            this.nudCharacterWidth.Size = new System.Drawing.Size(50, 23);
            this.nudCharacterWidth.TabIndex = 5;
            this.nudCharacterWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudCharacterWidth.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudCharacterWidth.ValueChanged += new System.EventHandler(this.nudCharacterWidth_ValueChanged);
            // 
            // nudCharacterHeight
            // 
            this.nudCharacterHeight.Location = new System.Drawing.Point(575, 188);
            this.nudCharacterHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCharacterHeight.Name = "nudCharacterHeight";
            this.nudCharacterHeight.Size = new System.Drawing.Size(50, 23);
            this.nudCharacterHeight.TabIndex = 6;
            this.nudCharacterHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudCharacterHeight.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudCharacterHeight.ValueChanged += new System.EventHandler(this.nudCharacterHeight_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Preview";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(520, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Font size (em)";
            // 
            // nudFontSize
            // 
            this.nudFontSize.Location = new System.Drawing.Point(575, 70);
            this.nudFontSize.Name = "nudFontSize";
            this.nudFontSize.Size = new System.Drawing.Size(50, 23);
            this.nudFontSize.TabIndex = 9;
            this.nudFontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudFontSize.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudFontSize.ValueChanged += new System.EventHandler(this.nudFontSize_ValueChanged);
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(12, 12);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(192, 23);
            this.txbSearch.TabIndex = 10;
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // btnForeground
            // 
            this.btnForeground.Location = new System.Drawing.Point(554, 230);
            this.btnForeground.Name = "btnForeground";
            this.btnForeground.Size = new System.Drawing.Size(40, 40);
            this.btnForeground.TabIndex = 11;
            this.btnForeground.UseVisualStyleBackColor = true;
            this.btnForeground.Click += new System.EventHandler(this.btnForeground_Click);
            // 
            // btnBackground
            // 
            this.btnBackground.Location = new System.Drawing.Point(573, 249);
            this.btnBackground.Name = "btnBackground";
            this.btnBackground.Size = new System.Drawing.Size(40, 40);
            this.btnBackground.TabIndex = 12;
            this.btnBackground.UseVisualStyleBackColor = true;
            this.btnBackground.Click += new System.EventHandler(this.btnBackground_Click);
            // 
            // cbTransparentBackground
            // 
            this.cbTransparentBackground.AutoSize = true;
            this.cbTransparentBackground.Location = new System.Drawing.Point(526, 314);
            this.cbTransparentBackground.Name = "cbTransparentBackground";
            this.cbTransparentBackground.Size = new System.Drawing.Size(166, 20);
            this.cbTransparentBackground.TabIndex = 13;
            this.cbTransparentBackground.Text = "Transparent background";
            this.cbTransparentBackground.UseVisualStyleBackColor = true;
            this.cbTransparentBackground.CheckedChanged += new System.EventHandler(this.cbTransparentBackground_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(655, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Output correction";
            // 
            // nudCorrectionX
            // 
            this.nudCorrectionX.Location = new System.Drawing.Point(658, 143);
            this.nudCorrectionX.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudCorrectionX.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            -2147483648});
            this.nudCorrectionX.Name = "nudCorrectionX";
            this.nudCorrectionX.Size = new System.Drawing.Size(50, 23);
            this.nudCorrectionX.TabIndex = 15;
            this.nudCorrectionX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudCorrectionX.ValueChanged += new System.EventHandler(this.nudCorrectionX_ValueChanged);
            // 
            // nudCorrectionY
            // 
            this.nudCorrectionY.Location = new System.Drawing.Point(714, 143);
            this.nudCorrectionY.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudCorrectionY.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            -2147483648});
            this.nudCorrectionY.Name = "nudCorrectionY";
            this.nudCorrectionY.Size = new System.Drawing.Size(50, 23);
            this.nudCorrectionY.TabIndex = 16;
            this.nudCorrectionY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudCorrectionY.ValueChanged += new System.EventHandler(this.nudCorrectionY_ValueChanged);
            // 
            // pnlPreview
            // 
            this.pnlPreview.AutoScroll = true;
            this.pnlPreview.ContextMenuStrip = this.cmsPreview;
            this.pnlPreview.Controls.Add(this.pbPreview);
            this.pnlPreview.Location = new System.Drawing.Point(211, 51);
            this.pnlPreview.Name = "pnlPreview";
            this.pnlPreview.Size = new System.Drawing.Size(303, 283);
            this.pnlPreview.TabIndex = 17;
            // 
            // btnLoadCustomFont
            // 
            this.btnLoadCustomFont.Location = new System.Drawing.Point(111, 293);
            this.btnLoadCustomFont.Name = "btnLoadCustomFont";
            this.btnLoadCustomFont.Size = new System.Drawing.Size(93, 41);
            this.btnLoadCustomFont.TabIndex = 18;
            this.btnLoadCustomFont.Text = "Load Custom";
            this.btnLoadCustomFont.UseVisualStyleBackColor = true;
            this.btnLoadCustomFont.Click += new System.EventHandler(this.btnLoadCustomFont_Click);
            // 
            // cbUseCustomFont
            // 
            this.cbUseCustomFont.AutoSize = true;
            this.cbUseCustomFont.Enabled = false;
            this.cbUseCustomFont.Location = new System.Drawing.Point(13, 296);
            this.cbUseCustomFont.Name = "cbUseCustomFont";
            this.cbUseCustomFont.Size = new System.Drawing.Size(92, 36);
            this.cbUseCustomFont.TabIndex = 19;
            this.cbUseCustomFont.Text = "Use custom\r\nfont";
            this.cbUseCustomFont.UseVisualStyleBackColor = true;
            this.cbUseCustomFont.CheckedChanged += new System.EventHandler(this.cbUseCustomFont_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 349);
            this.Controls.Add(this.cbUseCustomFont);
            this.Controls.Add(this.btnLoadCustomFont);
            this.Controls.Add(this.pnlPreview);
            this.Controls.Add(this.nudCorrectionY);
            this.Controls.Add(this.nudCorrectionX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbTransparentBackground);
            this.Controls.Add(this.btnForeground);
            this.Controls.Add(this.btnBackground);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.nudFontSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudCharacterHeight);
            this.Controls.Add(this.nudCharacterWidth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFontName);
            this.Controls.Add(this.lsbFontList);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CP437 Font Generator - By Hevanafa (Sep 2024)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            this.cmsPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudCharacterWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharacterHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCorrectionX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCorrectionY)).EndInit();
            this.pnlPreview.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbFontList;
        private System.Windows.Forms.Label lblFontName;
        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudCharacterWidth;
        private System.Windows.Forms.NumericUpDown nudCharacterHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudFontSize;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Button btnForeground;
        private System.Windows.Forms.Button btnBackground;
        private System.Windows.Forms.CheckBox cbTransparentBackground;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudCorrectionX;
        private System.Windows.Forms.NumericUpDown nudCorrectionY;
        private System.Windows.Forms.Panel pnlPreview;
        private System.Windows.Forms.ContextMenuStrip cmsPreview;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveImage;
        private System.Windows.Forms.Button btnLoadCustomFont;
        private System.Windows.Forms.CheckBox cbUseCustomFont;
    }
}

