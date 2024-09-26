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
            this.lsbFontList = new System.Windows.Forms.ListBox();
            this.lblFontName = new System.Windows.Forms.Label();
            this.pbPreview = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharacterWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharacterHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // lsbFontList
            // 
            this.lsbFontList.FormattingEnabled = true;
            this.lsbFontList.ItemHeight = 16;
            this.lsbFontList.Location = new System.Drawing.Point(13, 42);
            this.lsbFontList.Margin = new System.Windows.Forms.Padding(4);
            this.lsbFontList.Name = "lsbFontList";
            this.lsbFontList.Size = new System.Drawing.Size(191, 292);
            this.lsbFontList.TabIndex = 0;
            this.lsbFontList.SelectedIndexChanged += new System.EventHandler(this.lsbFontList_SelectedIndexChanged);
            // 
            // lblFontName
            // 
            this.lblFontName.AutoSize = true;
            this.lblFontName.Location = new System.Drawing.Point(296, 9);
            this.lblFontName.Name = "lblFontName";
            this.lblFontName.Size = new System.Drawing.Size(87, 16);
            this.lblFontName.TabIndex = 1;
            this.lblFontName.Text = "Font name: []";
            // 
            // pbPreview
            // 
            this.pbPreview.Location = new System.Drawing.Point(299, 51);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(218, 255);
            this.pbPreview.TabIndex = 2;
            this.pbPreview.TabStop = false;
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
            this.label3.Location = new System.Drawing.Point(523, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Character height";
            // 
            // nudCharacterWidth
            // 
            this.nudCharacterWidth.Location = new System.Drawing.Point(523, 147);
            this.nudCharacterWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCharacterWidth.Name = "nudCharacterWidth";
            this.nudCharacterWidth.Size = new System.Drawing.Size(120, 23);
            this.nudCharacterWidth.TabIndex = 5;
            this.nudCharacterWidth.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudCharacterWidth.ValueChanged += new System.EventHandler(this.nudCharacterWidth_ValueChanged);
            // 
            // nudCharacterHeight
            // 
            this.nudCharacterHeight.Location = new System.Drawing.Point(523, 192);
            this.nudCharacterHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCharacterHeight.Name = "nudCharacterHeight";
            this.nudCharacterHeight.Size = new System.Drawing.Size(120, 23);
            this.nudCharacterHeight.TabIndex = 6;
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
            this.label4.Location = new System.Drawing.Point(296, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Preview";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(523, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Font size (em)";
            // 
            // nudFontSize
            // 
            this.nudFontSize.Location = new System.Drawing.Point(523, 70);
            this.nudFontSize.Name = "nudFontSize";
            this.nudFontSize.Size = new System.Drawing.Size(120, 23);
            this.nudFontSize.TabIndex = 9;
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
            this.txbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbSearch_KeyDown);
            // 
            // btnForeground
            // 
            this.btnForeground.Location = new System.Drawing.Point(559, 237);
            this.btnForeground.Name = "btnForeground";
            this.btnForeground.Size = new System.Drawing.Size(40, 40);
            this.btnForeground.TabIndex = 11;
            this.btnForeground.UseVisualStyleBackColor = true;
            this.btnForeground.Click += new System.EventHandler(this.btnForeground_Click);
            // 
            // btnBackground
            // 
            this.btnBackground.Location = new System.Drawing.Point(578, 256);
            this.btnBackground.Name = "btnBackground";
            this.btnBackground.Size = new System.Drawing.Size(40, 40);
            this.btnBackground.TabIndex = 12;
            this.btnBackground.UseVisualStyleBackColor = true;
            this.btnBackground.Click += new System.EventHandler(this.btnBackground_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 366);
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
            this.Controls.Add(this.pbPreview);
            this.Controls.Add(this.lblFontName);
            this.Controls.Add(this.lsbFontList);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharacterWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharacterHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).EndInit();
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
    }
}

