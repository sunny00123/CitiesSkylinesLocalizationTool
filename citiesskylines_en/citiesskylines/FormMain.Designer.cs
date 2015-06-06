namespace CitiesSkylines
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label_locale = new System.Windows.Forms.Label();
            this.label_po = new System.Windows.Forms.Label();
            this.export = new System.Windows.Forms.GroupBox();
            this.export_msg = new System.Windows.Forms.Label();
            this.export_ok = new System.Windows.Forms.Button();
            this.po_path = new System.Windows.Forms.TextBox();
            this.locale_path = new System.Windows.Forms.TextBox();
            this.button_po = new System.Windows.Forms.Button();
            this.button_locale = new System.Windows.Forms.Button();
            this.import = new System.Windows.Forms.GroupBox();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.button_localeo = new System.Windows.Forms.Button();
            this.localeo_path = new System.Windows.Forms.TextBox();
            this.label_localeo = new System.Windows.Forms.Label();
            this.import_msg = new System.Windows.Forms.Label();
            this.import_ok = new System.Windows.Forms.Button();
            this.language_e = new System.Windows.Forms.TextBox();
            this.lable_language_e = new System.Windows.Forms.Label();
            this.language = new System.Windows.Forms.TextBox();
            this.lable_language = new System.Windows.Forms.Label();
            this.button_olocale = new System.Windows.Forms.Button();
            this.olocale_path = new System.Windows.Forms.TextBox();
            this.button_ipo = new System.Windows.Forms.Button();
            this.ipo_path = new System.Windows.Forms.TextBox();
            this.label_olocale = new System.Windows.Forms.Label();
            this.label_ipo = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.export.SuspendLayout();
            this.import.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_locale
            // 
            this.label_locale.AutoSize = true;
            this.label_locale.Location = new System.Drawing.Point(6, 22);
            this.label_locale.Name = "label_locale";
            this.label_locale.Size = new System.Drawing.Size(71, 12);
            this.label_locale.TabIndex = 0;
            this.label_locale.Text = "locale file";
            // 
            // label_po
            // 
            this.label_po.AutoSize = true;
            this.label_po.Location = new System.Drawing.Point(6, 52);
            this.label_po.Name = "label_po";
            this.label_po.Size = new System.Drawing.Size(71, 12);
            this.label_po.TabIndex = 3;
            this.label_po.Text = "export path";
            // 
            // export
            // 
            this.export.Controls.Add(this.export_msg);
            this.export.Controls.Add(this.export_ok);
            this.export.Controls.Add(this.po_path);
            this.export.Controls.Add(this.locale_path);
            this.export.Controls.Add(this.button_po);
            this.export.Controls.Add(this.button_locale);
            this.export.Controls.Add(this.label_locale);
            this.export.Controls.Add(this.label_po);
            this.export.Location = new System.Drawing.Point(12, 12);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(460, 105);
            this.export.TabIndex = 0;
            this.export.TabStop = false;
            this.export.Text = "export";
            // 
            // export_msg
            // 
            this.export_msg.AutoSize = true;
            this.export_msg.ForeColor = System.Drawing.Color.Red;
            this.export_msg.Location = new System.Drawing.Point(6, 81);
            this.export_msg.Name = "export_msg";
            this.export_msg.Size = new System.Drawing.Size(0, 12);
            this.export_msg.TabIndex = 7;
            // 
            // export_ok
            // 
            this.export_ok.Location = new System.Drawing.Point(379, 76);
            this.export_ok.Name = "export_ok";
            this.export_ok.Size = new System.Drawing.Size(75, 23);
            this.export_ok.TabIndex = 6;
            this.export_ok.Text = "start";
            this.export_ok.UseVisualStyleBackColor = true;
            this.export_ok.Click += new System.EventHandler(this.export_ok_Click);
            // 
            // po_path
            // 
            this.po_path.Location = new System.Drawing.Point(89, 49);
            this.po_path.Name = "po_path";
            this.po_path.Size = new System.Drawing.Size(284, 21);
            this.po_path.TabIndex = 4;
            // 
            // locale_path
            // 
            this.locale_path.Location = new System.Drawing.Point(89, 19);
            this.locale_path.Name = "locale_path";
            this.locale_path.Size = new System.Drawing.Size(284, 21);
            this.locale_path.TabIndex = 1;
            // 
            // button_po
            // 
            this.button_po.Location = new System.Drawing.Point(379, 47);
            this.button_po.Name = "button_po";
            this.button_po.Size = new System.Drawing.Size(75, 23);
            this.button_po.TabIndex = 5;
            this.button_po.Text = "open";
            this.button_po.UseVisualStyleBackColor = true;
            this.button_po.Click += new System.EventHandler(this.button_po_Click);
            // 
            // button_locale
            // 
            this.button_locale.Location = new System.Drawing.Point(379, 17);
            this.button_locale.Name = "button_locale";
            this.button_locale.Size = new System.Drawing.Size(75, 23);
            this.button_locale.TabIndex = 2;
            this.button_locale.Text = "open";
            this.button_locale.UseVisualStyleBackColor = true;
            this.button_locale.Click += new System.EventHandler(this.button_locale_Click);
            // 
            // import
            // 
            this.import.Controls.Add(this.progress);
            this.import.Controls.Add(this.button_localeo);
            this.import.Controls.Add(this.localeo_path);
            this.import.Controls.Add(this.label_localeo);
            this.import.Controls.Add(this.import_msg);
            this.import.Controls.Add(this.import_ok);
            this.import.Controls.Add(this.language_e);
            this.import.Controls.Add(this.lable_language_e);
            this.import.Controls.Add(this.language);
            this.import.Controls.Add(this.lable_language);
            this.import.Controls.Add(this.button_olocale);
            this.import.Controls.Add(this.olocale_path);
            this.import.Controls.Add(this.button_ipo);
            this.import.Controls.Add(this.ipo_path);
            this.import.Controls.Add(this.label_olocale);
            this.import.Controls.Add(this.label_ipo);
            this.import.Location = new System.Drawing.Point(12, 123);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(460, 160);
            this.import.TabIndex = 0;
            this.import.TabStop = false;
            this.import.Text = "import";
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(270, 101);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(103, 23);
            this.progress.TabIndex = 15;
            this.progress.Visible = false;
            // 
            // button_localeo
            // 
            this.button_localeo.Location = new System.Drawing.Point(379, 18);
            this.button_localeo.Name = "button_localeo";
            this.button_localeo.Size = new System.Drawing.Size(75, 23);
            this.button_localeo.TabIndex = 2;
            this.button_localeo.Text = "open";
            this.button_localeo.UseVisualStyleBackColor = true;
            this.button_localeo.Click += new System.EventHandler(this.button_localeo_Click);
            // 
            // localeo_path
            // 
            this.localeo_path.Location = new System.Drawing.Point(89, 20);
            this.localeo_path.Name = "localeo_path";
            this.localeo_path.Size = new System.Drawing.Size(284, 21);
            this.localeo_path.TabIndex = 1;
            // 
            // label_localeo
            // 
            this.label_localeo.AutoSize = true;
            this.label_localeo.Location = new System.Drawing.Point(6, 23);
            this.label_localeo.Name = "label_localeo";
            this.label_localeo.Size = new System.Drawing.Size(83, 12);
            this.label_localeo.TabIndex = 0;
            this.label_localeo.Text = "origin locale";
            // 
            // import_msg
            // 
            this.import_msg.AutoSize = true;
            this.import_msg.ForeColor = System.Drawing.Color.Red;
            this.import_msg.Location = new System.Drawing.Point(270, 133);
            this.import_msg.Name = "import_msg";
            this.import_msg.Size = new System.Drawing.Size(0, 12);
            this.import_msg.TabIndex = 14;
            // 
            // import_ok
            // 
            this.import_ok.Location = new System.Drawing.Point(379, 101);
            this.import_ok.Name = "import_ok";
            this.import_ok.Size = new System.Drawing.Size(75, 23);
            this.import_ok.TabIndex = 13;
            this.import_ok.Text = "start";
            this.import_ok.UseVisualStyleBackColor = true;
            this.import_ok.Click += new System.EventHandler(this.import_ok_Click);
            // 
            // language_e
            // 
            this.language_e.Location = new System.Drawing.Point(89, 130);
            this.language_e.Name = "language_e";
            this.language_e.Size = new System.Drawing.Size(175, 21);
            this.language_e.TabIndex = 12;
            this.language_e.Text = "(ENGLISH)";
            // 
            // lable_language_e
            // 
            this.lable_language_e.AutoSize = true;
            this.lable_language_e.Location = new System.Drawing.Point(6, 133);
            this.lable_language_e.Name = "lable_language_e";
            this.lable_language_e.Size = new System.Drawing.Size(77, 12);
            this.lable_language_e.TabIndex = 11;
            this.lable_language_e.Text = "english text";
            // 
            // language
            // 
            this.language.Location = new System.Drawing.Point(89, 103);
            this.language.Name = "language";
            this.language.Size = new System.Drawing.Size(175, 21);
            this.language.TabIndex = 10;
            this.language.Text = "ENGLISH";
            // 
            // lable_language
            // 
            this.lable_language.AutoSize = true;
            this.lable_language.Location = new System.Drawing.Point(6, 106);
            this.lable_language.Name = "lable_language";
            this.lable_language.Size = new System.Drawing.Size(71, 12);
            this.lable_language.TabIndex = 9;
            this.lable_language.Text = "native text";
            // 
            // button_olocale
            // 
            this.button_olocale.Location = new System.Drawing.Point(379, 74);
            this.button_olocale.Name = "button_olocale";
            this.button_olocale.Size = new System.Drawing.Size(75, 23);
            this.button_olocale.TabIndex = 8;
            this.button_olocale.Text = "open";
            this.button_olocale.UseVisualStyleBackColor = true;
            this.button_olocale.Click += new System.EventHandler(this.button_olocale_Click);
            // 
            // olocale_path
            // 
            this.olocale_path.Location = new System.Drawing.Point(89, 76);
            this.olocale_path.Name = "olocale_path";
            this.olocale_path.Size = new System.Drawing.Size(284, 21);
            this.olocale_path.TabIndex = 7;
            // 
            // button_ipo
            // 
            this.button_ipo.Location = new System.Drawing.Point(379, 45);
            this.button_ipo.Name = "button_ipo";
            this.button_ipo.Size = new System.Drawing.Size(75, 23);
            this.button_ipo.TabIndex = 5;
            this.button_ipo.Text = "open";
            this.button_ipo.UseVisualStyleBackColor = true;
            this.button_ipo.Click += new System.EventHandler(this.button_ipo_Click);
            // 
            // ipo_path
            // 
            this.ipo_path.Location = new System.Drawing.Point(89, 47);
            this.ipo_path.Name = "ipo_path";
            this.ipo_path.Size = new System.Drawing.Size(284, 21);
            this.ipo_path.TabIndex = 4;
            // 
            // label_olocale
            // 
            this.label_olocale.AutoSize = true;
            this.label_olocale.Location = new System.Drawing.Point(6, 79);
            this.label_olocale.Name = "label_olocale";
            this.label_olocale.Size = new System.Drawing.Size(71, 12);
            this.label_olocale.TabIndex = 6;
            this.label_olocale.Text = "export path";
            // 
            // label_ipo
            // 
            this.label_ipo.AutoSize = true;
            this.label_ipo.Location = new System.Drawing.Point(6, 50);
            this.label_ipo.Name = "label_ipo";
            this.label_ipo.Size = new System.Drawing.Size(83, 12);
            this.label_ipo.TabIndex = 3;
            this.label_ipo.Text = "import pofile";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Location = new System.Drawing.Point(419, 286);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(0, 12);
            this.version.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 304);
            this.Controls.Add(this.version);
            this.Controls.Add(this.import);
            this.Controls.Add(this.export);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CitiesSkylines Localization Tool";
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.export.ResumeLayout(false);
            this.export.PerformLayout();
            this.import.ResumeLayout(false);
            this.import.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_locale;
        private System.Windows.Forms.Label label_po;
        private System.Windows.Forms.GroupBox export;
        private System.Windows.Forms.Button button_locale;
        private System.Windows.Forms.Button button_po;
        private System.Windows.Forms.TextBox po_path;
        private System.Windows.Forms.TextBox locale_path;
        private System.Windows.Forms.Button export_ok;
        private System.Windows.Forms.Label export_msg;
        private System.Windows.Forms.GroupBox import;
        private System.Windows.Forms.Label label_ipo;
        private System.Windows.Forms.Label label_olocale;
        private System.Windows.Forms.TextBox ipo_path;
        private System.Windows.Forms.Button button_ipo;
        private System.Windows.Forms.TextBox olocale_path;
        private System.Windows.Forms.Button button_olocale;
        private System.Windows.Forms.TextBox language;
        private System.Windows.Forms.Label lable_language;
        private System.Windows.Forms.Label lable_language_e;
        private System.Windows.Forms.TextBox language_e;
        private System.Windows.Forms.Button import_ok;
        private System.Windows.Forms.Label import_msg;
        private System.Windows.Forms.Label label_localeo;
        private System.Windows.Forms.TextBox localeo_path;
        private System.Windows.Forms.Button button_localeo;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Label version;
    }
}

