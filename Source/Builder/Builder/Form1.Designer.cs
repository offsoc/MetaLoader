namespace Builder
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BuildBtn = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Obfuscate_Box = new MaterialSkin.Controls.MaterialCheckbox();
            this.HideFile_Box = new MaterialSkin.Controls.MaterialCheckbox();
            this.Autorun_Box = new MaterialSkin.Controls.MaterialCheckbox();
            this.MutexControl_Box = new MaterialSkin.Controls.MaterialCheckbox();
            this.AntiCis_Box = new MaterialSkin.Controls.MaterialCheckbox();
            this.AntiAnyRun_Box = new MaterialSkin.Controls.MaterialCheckbox();
            this.AntiVM_Box = new MaterialSkin.Controls.MaterialCheckbox();
            this.AntiDebugBox = new MaterialSkin.Controls.MaterialCheckbox();
            this.Mutex_Box = new MaterialSkin.Controls.MaterialTextBox();
            this.FileName_Box = new MaterialSkin.Controls.MaterialTextBox();
            this.RemoteUrl_Box = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "about.png");
            this.imageList1.Images.SetKeyName(1, "builder.png");
            this.imageList1.Images.SetKeyName(2, "about2.ico");
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(652, 376);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BuildBtn);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.Mutex_Box);
            this.tabPage1.Controls.Add(this.FileName_Box);
            this.tabPage1.Controls.Add(this.RemoteUrl_Box);
            this.tabPage1.Controls.Add(this.materialLabel3);
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.ImageKey = "builder.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(644, 333);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Builder";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BuildBtn
            // 
            this.BuildBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BuildBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BuildBtn.Depth = 0;
            this.BuildBtn.HighEmphasis = true;
            this.BuildBtn.Icon = null;
            this.BuildBtn.Location = new System.Drawing.Point(214, 297);
            this.BuildBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BuildBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.BuildBtn.Name = "BuildBtn";
            this.BuildBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BuildBtn.Size = new System.Drawing.Size(117, 36);
            this.BuildBtn.TabIndex = 8;
            this.BuildBtn.Text = "Compile File";
            this.BuildBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BuildBtn.UseAccentColor = false;
            this.BuildBtn.UseVisualStyleBackColor = true;
            this.BuildBtn.Click += new System.EventHandler(this.BuildBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Obfuscate_Box);
            this.groupBox1.Controls.Add(this.HideFile_Box);
            this.groupBox1.Controls.Add(this.Autorun_Box);
            this.groupBox1.Controls.Add(this.MutexControl_Box);
            this.groupBox1.Controls.Add(this.AntiCis_Box);
            this.groupBox1.Controls.Add(this.AntiAnyRun_Box);
            this.groupBox1.Controls.Add(this.AntiVM_Box);
            this.groupBox1.Controls.Add(this.AntiDebugBox);
            this.groupBox1.Location = new System.Drawing.Point(9, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 105);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Functions";
            // 
            // Obfuscate_Box
            // 
            this.Obfuscate_Box.AutoSize = true;
            this.Obfuscate_Box.Depth = 0;
            this.Obfuscate_Box.Location = new System.Drawing.Point(421, 58);
            this.Obfuscate_Box.Margin = new System.Windows.Forms.Padding(0);
            this.Obfuscate_Box.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Obfuscate_Box.MouseState = MaterialSkin.MouseState.HOVER;
            this.Obfuscate_Box.Name = "Obfuscate_Box";
            this.Obfuscate_Box.ReadOnly = false;
            this.Obfuscate_Box.Ripple = true;
            this.Obfuscate_Box.Size = new System.Drawing.Size(108, 37);
            this.Obfuscate_Box.TabIndex = 8;
            this.Obfuscate_Box.Text = "Obfuscate";
            this.Obfuscate_Box.UseVisualStyleBackColor = true;
            // 
            // HideFile_Box
            // 
            this.HideFile_Box.AutoSize = true;
            this.HideFile_Box.Depth = 0;
            this.HideFile_Box.Location = new System.Drawing.Point(421, 12);
            this.HideFile_Box.Margin = new System.Windows.Forms.Padding(0);
            this.HideFile_Box.MouseLocation = new System.Drawing.Point(-1, -1);
            this.HideFile_Box.MouseState = MaterialSkin.MouseState.HOVER;
            this.HideFile_Box.Name = "HideFile_Box";
            this.HideFile_Box.ReadOnly = false;
            this.HideFile_Box.Ripple = true;
            this.HideFile_Box.Size = new System.Drawing.Size(92, 37);
            this.HideFile_Box.TabIndex = 7;
            this.HideFile_Box.Text = "HideFile";
            this.HideFile_Box.UseVisualStyleBackColor = true;
            // 
            // Autorun_Box
            // 
            this.Autorun_Box.AutoSize = true;
            this.Autorun_Box.Depth = 0;
            this.Autorun_Box.Location = new System.Drawing.Point(319, 54);
            this.Autorun_Box.Margin = new System.Windows.Forms.Padding(0);
            this.Autorun_Box.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Autorun_Box.MouseState = MaterialSkin.MouseState.HOVER;
            this.Autorun_Box.Name = "Autorun_Box";
            this.Autorun_Box.ReadOnly = false;
            this.Autorun_Box.Ripple = true;
            this.Autorun_Box.Size = new System.Drawing.Size(91, 37);
            this.Autorun_Box.TabIndex = 6;
            this.Autorun_Box.Text = "Autorun";
            this.Autorun_Box.UseVisualStyleBackColor = true;
            // 
            // MutexControl_Box
            // 
            this.MutexControl_Box.AutoSize = true;
            this.MutexControl_Box.Depth = 0;
            this.MutexControl_Box.Location = new System.Drawing.Point(244, 12);
            this.MutexControl_Box.Margin = new System.Windows.Forms.Padding(0);
            this.MutexControl_Box.MouseLocation = new System.Drawing.Point(-1, -1);
            this.MutexControl_Box.MouseState = MaterialSkin.MouseState.HOVER;
            this.MutexControl_Box.Name = "MutexControl_Box";
            this.MutexControl_Box.ReadOnly = false;
            this.MutexControl_Box.Ripple = true;
            this.MutexControl_Box.Size = new System.Drawing.Size(130, 37);
            this.MutexControl_Box.TabIndex = 5;
            this.MutexControl_Box.Text = "MutexControl";
            this.MutexControl_Box.UseVisualStyleBackColor = true;
            this.MutexControl_Box.CheckedChanged += new System.EventHandler(this.MutexControl_Box_CheckedChanged);
            // 
            // AntiCis_Box
            // 
            this.AntiCis_Box.AutoSize = true;
            this.AntiCis_Box.Depth = 0;
            this.AntiCis_Box.Location = new System.Drawing.Point(144, 58);
            this.AntiCis_Box.Margin = new System.Windows.Forms.Padding(0);
            this.AntiCis_Box.MouseLocation = new System.Drawing.Point(-1, -1);
            this.AntiCis_Box.MouseState = MaterialSkin.MouseState.HOVER;
            this.AntiCis_Box.Name = "AntiCis_Box";
            this.AntiCis_Box.ReadOnly = false;
            this.AntiCis_Box.Ripple = true;
            this.AntiCis_Box.Size = new System.Drawing.Size(160, 37);
            this.AntiCis_Box.TabIndex = 4;
            this.AntiCis_Box.Text = "AntiCIS(cis-block)";
            this.AntiCis_Box.UseVisualStyleBackColor = true;
            // 
            // AntiAnyRun_Box
            // 
            this.AntiAnyRun_Box.AutoSize = true;
            this.AntiAnyRun_Box.Depth = 0;
            this.AntiAnyRun_Box.Location = new System.Drawing.Point(14, 58);
            this.AntiAnyRun_Box.Margin = new System.Windows.Forms.Padding(0);
            this.AntiAnyRun_Box.MouseLocation = new System.Drawing.Point(-1, -1);
            this.AntiAnyRun_Box.MouseState = MaterialSkin.MouseState.HOVER;
            this.AntiAnyRun_Box.Name = "AntiAnyRun_Box";
            this.AntiAnyRun_Box.ReadOnly = false;
            this.AntiAnyRun_Box.Ripple = true;
            this.AntiAnyRun_Box.Size = new System.Drawing.Size(118, 37);
            this.AntiAnyRun_Box.TabIndex = 3;
            this.AntiAnyRun_Box.Text = "AntiAnyRun";
            this.AntiAnyRun_Box.UseVisualStyleBackColor = true;
            // 
            // AntiVM_Box
            // 
            this.AntiVM_Box.AutoSize = true;
            this.AntiVM_Box.Depth = 0;
            this.AntiVM_Box.Location = new System.Drawing.Point(144, 12);
            this.AntiVM_Box.Margin = new System.Windows.Forms.Padding(0);
            this.AntiVM_Box.MouseLocation = new System.Drawing.Point(-1, -1);
            this.AntiVM_Box.MouseState = MaterialSkin.MouseState.HOVER;
            this.AntiVM_Box.Name = "AntiVM_Box";
            this.AntiVM_Box.ReadOnly = false;
            this.AntiVM_Box.Ripple = true;
            this.AntiVM_Box.Size = new System.Drawing.Size(87, 37);
            this.AntiVM_Box.TabIndex = 2;
            this.AntiVM_Box.Text = "AntiVM";
            this.AntiVM_Box.UseVisualStyleBackColor = true;
            // 
            // AntiDebugBox
            // 
            this.AntiDebugBox.AutoSize = true;
            this.AntiDebugBox.Depth = 0;
            this.AntiDebugBox.Location = new System.Drawing.Point(14, 16);
            this.AntiDebugBox.Margin = new System.Windows.Forms.Padding(0);
            this.AntiDebugBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.AntiDebugBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.AntiDebugBox.Name = "AntiDebugBox";
            this.AntiDebugBox.ReadOnly = false;
            this.AntiDebugBox.Ripple = true;
            this.AntiDebugBox.Size = new System.Drawing.Size(109, 37);
            this.AntiDebugBox.TabIndex = 0;
            this.AntiDebugBox.Text = "AntiDebug";
            this.AntiDebugBox.UseVisualStyleBackColor = true;
            // 
            // Mutex_Box
            // 
            this.Mutex_Box.AnimateReadOnly = false;
            this.Mutex_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mutex_Box.Depth = 0;
            this.Mutex_Box.Enabled = false;
            this.Mutex_Box.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Mutex_Box.Hint = "MUTEX(IF ENABLED)";
            this.Mutex_Box.LeadingIcon = null;
            this.Mutex_Box.Location = new System.Drawing.Point(66, 118);
            this.Mutex_Box.MaxLength = 50;
            this.Mutex_Box.MouseState = MaterialSkin.MouseState.OUT;
            this.Mutex_Box.Multiline = false;
            this.Mutex_Box.Name = "Mutex_Box";
            this.Mutex_Box.Size = new System.Drawing.Size(490, 50);
            this.Mutex_Box.TabIndex = 6;
            this.Mutex_Box.Text = "";
            this.Mutex_Box.TrailingIcon = null;
            // 
            // FileName_Box
            // 
            this.FileName_Box.AnimateReadOnly = false;
            this.FileName_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileName_Box.Depth = 0;
            this.FileName_Box.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FileName_Box.Hint = "FILENAME.exe";
            this.FileName_Box.LeadingIcon = null;
            this.FileName_Box.Location = new System.Drawing.Point(88, 62);
            this.FileName_Box.MaxLength = 50;
            this.FileName_Box.MouseState = MaterialSkin.MouseState.OUT;
            this.FileName_Box.Multiline = false;
            this.FileName_Box.Name = "FileName_Box";
            this.FileName_Box.Size = new System.Drawing.Size(468, 50);
            this.FileName_Box.TabIndex = 5;
            this.FileName_Box.Text = "";
            this.FileName_Box.TrailingIcon = null;
            // 
            // RemoteUrl_Box
            // 
            this.RemoteUrl_Box.AnimateReadOnly = false;
            this.RemoteUrl_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RemoteUrl_Box.Depth = 0;
            this.RemoteUrl_Box.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.RemoteUrl_Box.Hint = "URL-REMOTE-FILE";
            this.RemoteUrl_Box.LeadingIcon = null;
            this.RemoteUrl_Box.Location = new System.Drawing.Point(70, 6);
            this.RemoteUrl_Box.MaxLength = 450;
            this.RemoteUrl_Box.MouseState = MaterialSkin.MouseState.OUT;
            this.RemoteUrl_Box.Multiline = false;
            this.RemoteUrl_Box.Name = "RemoteUrl_Box";
            this.RemoteUrl_Box.Size = new System.Drawing.Size(486, 50);
            this.RemoteUrl_Box.TabIndex = 4;
            this.RemoteUrl_Box.Text = "";
            this.RemoteUrl_Box.TrailingIcon = null;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(6, 136);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(54, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "MUTEX";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(6, 79);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(76, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "FILENAME";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(20, 20);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(30, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "URL";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.ImageKey = "about2.ico";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(644, 333);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "About";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Pink;
            this.label2.Location = new System.Drawing.Point(62, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Author: K3rnel-Dev";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Builder.Properties.Resources.github;
            this.pictureBox2.Location = new System.Drawing.Point(33, 231);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(243, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 170);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "About | Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "Loader of your files, packed with many functions.\r\nEnjoy using it, I am not respo" +
    "nsible for the use\r\nof this program. C0d3d by k3rnel-dev\r\nhttps://github.com/k3r" +
    "nel-dev\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Builder.Properties.Resources.zxc;
            this.pictureBox1.Location = new System.Drawing.Point(36, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 443);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meta Builder";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTextBox RemoteUrl_Box;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox Mutex_Box;
        private MaterialSkin.Controls.MaterialTextBox FileName_Box;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialCheckbox Autorun_Box;
        private MaterialSkin.Controls.MaterialCheckbox MutexControl_Box;
        private MaterialSkin.Controls.MaterialCheckbox AntiCis_Box;
        private MaterialSkin.Controls.MaterialCheckbox AntiAnyRun_Box;
        private MaterialSkin.Controls.MaterialCheckbox AntiVM_Box;
        private MaterialSkin.Controls.MaterialCheckbox AntiDebugBox;
        private MaterialSkin.Controls.MaterialCheckbox Obfuscate_Box;
        private MaterialSkin.Controls.MaterialCheckbox HideFile_Box;
        private MaterialSkin.Controls.MaterialButton BuildBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

