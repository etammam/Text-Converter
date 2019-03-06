namespace String_Cases
{
    partial class Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Converter));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.toUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toTitleCaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toLowerCaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.materialContextMenuStrip2 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTitle = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnUpper = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnLower = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialContextMenuStrip1.SuspendLayout();
            this.materialContextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 77);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(130, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Add your text here";
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toUToolStripMenuItem,
            this.toTitleCaseToolStripMenuItem,
            this.toLowerCaseToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(151, 92);
            // 
            // toUToolStripMenuItem
            // 
            this.toUToolStripMenuItem.Name = "toUToolStripMenuItem";
            this.toUToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.toUToolStripMenuItem.Text = "To Upper Case";
            this.toUToolStripMenuItem.Click += new System.EventHandler(this.toUToolStripMenuItem_Click);
            // 
            // toTitleCaseToolStripMenuItem
            // 
            this.toTitleCaseToolStripMenuItem.Name = "toTitleCaseToolStripMenuItem";
            this.toTitleCaseToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.toTitleCaseToolStripMenuItem.Text = "To Title Case";
            this.toTitleCaseToolStripMenuItem.Click += new System.EventHandler(this.toTitleCaseToolStripMenuItem_Click);
            // 
            // toLowerCaseToolStripMenuItem
            // 
            this.toLowerCaseToolStripMenuItem.Name = "toLowerCaseToolStripMenuItem";
            this.toLowerCaseToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.toLowerCaseToolStripMenuItem.Text = "To Lower Case";
            this.toLowerCaseToolStripMenuItem.Click += new System.EventHandler(this.toLowerCaseToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.ContextMenuStrip = this.materialContextMenuStrip2;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(16, 99);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(659, 109);
            this.textBox1.TabIndex = 3;
            // 
            // materialContextMenuStrip2
            // 
            this.materialContextMenuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip2.Depth = 0;
            this.materialContextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToClipboardToolStripMenuItem,
            this.clearTextToolStripMenuItem});
            this.materialContextMenuStrip2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip2.Name = "materialContextMenuStrip2";
            this.materialContextMenuStrip2.Size = new System.Drawing.Size(174, 48);
            // 
            // copyToClipboardToolStripMenuItem
            // 
            this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
            this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.copyToClipboardToolStripMenuItem.Text = "Copy To Clipboard";
            this.copyToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyToClipboardToolStripMenuItem_Click);
            // 
            // clearTextToolStripMenuItem
            // 
            this.clearTextToolStripMenuItem.Name = "clearTextToolStripMenuItem";
            this.clearTextToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.clearTextToolStripMenuItem.Text = "Clear Text";
            this.clearTextToolStripMenuItem.Click += new System.EventHandler(this.clearTextToolStripMenuItem_Click);
            // 
            // btnTitle
            // 
            this.btnTitle.AutoSize = true;
            this.btnTitle.Depth = 0;
            this.btnTitle.Font = new System.Drawing.Font("Roboto", 10F);
            this.btnTitle.Location = new System.Drawing.Point(17, 214);
            this.btnTitle.Margin = new System.Windows.Forms.Padding(0);
            this.btnTitle.MouseLocation = new System.Drawing.Point(-1, -1);
            this.btnTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Ripple = true;
            this.btnTitle.Size = new System.Drawing.Size(91, 30);
            this.btnTitle.TabIndex = 5;
            this.btnTitle.TabStop = true;
            this.btnTitle.Text = "Title Case";
            this.btnTitle.UseVisualStyleBackColor = true;
            // 
            // btnUpper
            // 
            this.btnUpper.AutoSize = true;
            this.btnUpper.Depth = 0;
            this.btnUpper.Font = new System.Drawing.Font("Roboto", 10F);
            this.btnUpper.Location = new System.Drawing.Point(116, 214);
            this.btnUpper.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpper.MouseLocation = new System.Drawing.Point(-1, -1);
            this.btnUpper.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpper.Name = "btnUpper";
            this.btnUpper.Ripple = true;
            this.btnUpper.Size = new System.Drawing.Size(100, 30);
            this.btnUpper.TabIndex = 5;
            this.btnUpper.TabStop = true;
            this.btnUpper.Text = "Upper Case";
            this.btnUpper.UseVisualStyleBackColor = true;
            // 
            // btnLower
            // 
            this.btnLower.AutoSize = true;
            this.btnLower.Depth = 0;
            this.btnLower.Font = new System.Drawing.Font("Roboto", 10F);
            this.btnLower.Location = new System.Drawing.Point(224, 214);
            this.btnLower.Margin = new System.Windows.Forms.Padding(0);
            this.btnLower.MouseLocation = new System.Drawing.Point(-1, -1);
            this.btnLower.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLower.Name = "btnLower";
            this.btnLower.Ripple = true;
            this.btnLower.Size = new System.Drawing.Size(101, 30);
            this.btnLower.TabIndex = 5;
            this.btnLower.TabStop = true;
            this.btnLower.Text = "Lower Case";
            this.btnLower.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(532, 214);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(143, 30);
            this.materialRaisedButton1.TabIndex = 6;
            this.materialRaisedButton1.Text = "Convert";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 259);
            this.ContextMenuStrip = this.materialContextMenuStrip1;
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.btnLower);
            this.Controls.Add(this.btnUpper);
            this.Controls.Add(this.btnTitle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.materialLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "String Case Converter";
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.materialContextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toTitleCaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toLowerCaseToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearTextToolStripMenuItem;
        private MaterialSkin.Controls.MaterialRadioButton btnTitle;
        private MaterialSkin.Controls.MaterialRadioButton btnUpper;
        private MaterialSkin.Controls.MaterialRadioButton btnLower;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}

