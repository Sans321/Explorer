
namespace Exploer
{
    partial class Search
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this._tbFile = new System.Windows.Forms.TextBox();
            this._tbView = new System.Windows.Forms.TextBox();
            this._bView = new System.Windows.Forms.Button();
            this._bFind = new System.Windows.Forms.Button();
            this._lbAnser = new System.Windows.Forms.ListBox();
            this._fBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this._lSearchFileName = new System.Windows.Forms.Label();
            this._lSearchPath = new System.Windows.Forms.Label();
            this._cbRecurs = new System.Windows.Forms.CheckBox();
            this._lSearchResult = new System.Windows.Forms.Label();
            this._bClear = new System.Windows.Forms.Button();
            this._bClearAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _tbFile
            // 
            this._tbFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbFile.Location = new System.Drawing.Point(145, 13);
            this._tbFile.Name = "_tbFile";
            this._tbFile.Size = new System.Drawing.Size(488, 20);
            this._tbFile.TabIndex = 0;
            // 
            // _tbView
            // 
            this._tbView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbView.Location = new System.Drawing.Point(145, 40);
            this._tbView.Name = "_tbView";
            this._tbView.Size = new System.Drawing.Size(400, 20);
            this._tbView.TabIndex = 1;
            // 
            // _bView
            // 
            this._bView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._bView.Location = new System.Drawing.Point(552, 38);
            this._bView.Name = "_bView";
            this._bView.Size = new System.Drawing.Size(81, 23);
            this._bView.TabIndex = 2;
            this._bView.Text = "Обзор...";
            this._bView.UseVisualStyleBackColor = true;
            this._bView.Click += new System.EventHandler(this._bView_Click);
            // 
            // _bFind
            // 
            this._bFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._bFind.Location = new System.Drawing.Point(145, 66);
            this._bFind.Name = "_bFind";
            this._bFind.Size = new System.Drawing.Size(488, 23);
            this._bFind.TabIndex = 3;
            this._bFind.Text = "Искать!";
            this._bFind.UseVisualStyleBackColor = true;
            this._bFind.Click += new System.EventHandler(this._bFind_Click);
            // 
            // _lbAnser
            // 
            this._lbAnser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lbAnser.FormattingEnabled = true;
            this._lbAnser.Location = new System.Drawing.Point(145, 96);
            this._lbAnser.Name = "_lbAnser";
            this._lbAnser.Size = new System.Drawing.Size(488, 277);
            this._lbAnser.TabIndex = 4;
            this._lbAnser.SelectedIndexChanged += new System.EventHandler(this._lbAnser_SelectedIndexChanged);
            // 
            // _lSearchFileName
            // 
            this._lSearchFileName.AutoSize = true;
            this._lSearchFileName.Location = new System.Drawing.Point(12, 16);
            this._lSearchFileName.Name = "_lSearchFileName";
            this._lSearchFileName.Size = new System.Drawing.Size(127, 13);
            this._lSearchFileName.TabIndex = 5;
            this._lSearchFileName.Text = "Имя файла для поиска:";
            // 
            // _lSearchPath
            // 
            this._lSearchPath.AutoSize = true;
            this._lSearchPath.Location = new System.Drawing.Point(12, 43);
            this._lSearchPath.Name = "_lSearchPath";
            this._lSearchPath.Size = new System.Drawing.Size(66, 13);
            this._lSearchPath.TabIndex = 6;
            this._lSearchPath.Text = "Где искать:";
            // 
            // _cbRecurs
            // 
            this._cbRecurs.AutoSize = true;
            this._cbRecurs.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._cbRecurs.Checked = true;
            this._cbRecurs.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbRecurs.Location = new System.Drawing.Point(11, 70);
            this._cbRecurs.Name = "_cbRecurs";
            this._cbRecurs.Size = new System.Drawing.Size(128, 17);
            this._cbRecurs.TabIndex = 8;
            this._cbRecurs.Text = "Искать в подпапках";
            this._cbRecurs.UseVisualStyleBackColor = true;
            // 
            // _lSearchResult
            // 
            this._lSearchResult.AutoSize = true;
            this._lSearchResult.Location = new System.Drawing.Point(12, 96);
            this._lSearchResult.Name = "_lSearchResult";
            this._lSearchResult.Size = new System.Drawing.Size(109, 13);
            this._lSearchResult.TabIndex = 9;
            this._lSearchResult.Text = "Результаты поиска:";
            // 
            // _bClear
            // 
            this._bClear.Location = new System.Drawing.Point(15, 123);
            this._bClear.Name = "_bClear";
            this._bClear.Size = new System.Drawing.Size(124, 23);
            this._bClear.TabIndex = 10;
            this._bClear.Text = "Очистить результаты";
            this._bClear.UseVisualStyleBackColor = true;
            this._bClear.Click += new System.EventHandler(this._bClear_Click);
            // 
            // _bClearAll
            // 
            this._bClearAll.Location = new System.Drawing.Point(15, 153);
            this._bClearAll.Name = "_bClearAll";
            this._bClearAll.Size = new System.Drawing.Size(124, 23);
            this._bClearAll.TabIndex = 11;
            this._bClearAll.Text = "Очистить все";
            this._bClearAll.UseVisualStyleBackColor = true;
            this._bClearAll.Click += new System.EventHandler(this._bClearAll_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 377);
            this.Controls.Add(this._bClearAll);
            this.Controls.Add(this._bClear);
            this.Controls.Add(this._lSearchResult);
            this.Controls.Add(this._cbRecurs);
            this.Controls.Add(this._lSearchPath);
            this.Controls.Add(this._lSearchFileName);
            this.Controls.Add(this._lbAnser);
            this.Controls.Add(this._bFind);
            this.Controls.Add(this._bView);
            this.Controls.Add(this._tbView);
            this.Controls.Add(this._tbFile);
            this.Name = "Search";
            this.Text = "Форма поиска файлов";
            this.Load += new System.EventHandler(this.Search_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _tbFile;
        private System.Windows.Forms.TextBox _tbView;
        private System.Windows.Forms.Button _bView;
        private System.Windows.Forms.Button _bFind;
        private System.Windows.Forms.ListBox _lbAnser;
        private System.Windows.Forms.FolderBrowserDialog _fBrowserDialog;
        private System.Windows.Forms.Label _lSearchFileName;
        private System.Windows.Forms.Label _lSearchPath;
        private System.Windows.Forms.CheckBox _cbRecurs;
        private System.Windows.Forms.Label _lSearchResult;
        private System.Windows.Forms.Button _bClear;
        private System.Windows.Forms.Button _bClearAll;
    }
}