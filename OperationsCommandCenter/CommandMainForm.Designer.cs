
namespace OperationsCommandCenter
{
    partial class CommandMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommandMainForm));
            this.lbl_search = new System.Windows.Forms.Label();
            this.textB_search = new System.Windows.Forms.TextBox();
            this.listbox_result = new System.Windows.Forms.ListBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_openDoc = new System.Windows.Forms.Button();
            this.btn_openFolder = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_search.Location = new System.Drawing.Point(12, 9);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(307, 24);
            this.lbl_search.TabIndex = 0;
            this.lbl_search.Text = "Enter a Job Name to Search for";
            // 
            // textB_search
            // 
            this.textB_search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB_search.Location = new System.Drawing.Point(16, 44);
            this.textB_search.Name = "textB_search";
            this.textB_search.Size = new System.Drawing.Size(303, 34);
            this.textB_search.TabIndex = 1;
            // 
            // listbox_result
            // 
            this.listbox_result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listbox_result.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_result.FormattingEnabled = true;
            this.listbox_result.ItemHeight = 31;
            this.listbox_result.Location = new System.Drawing.Point(16, 137);
            this.listbox_result.Name = "listbox_result";
            this.listbox_result.Size = new System.Drawing.Size(956, 97);
            this.listbox_result.TabIndex = 3;
            this.listbox_result.Visible = false;
            // 
            // btn_search
            // 
            this.btn_search.AutoEllipsis = true;
            this.btn_search.BackColor = System.Drawing.Color.Lime;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.Black;
            this.btn_search.Location = new System.Drawing.Point(16, 94);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(133, 29);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_openDoc
            // 
            this.btn_openDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_openDoc.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_openDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_openDoc.ForeColor = System.Drawing.Color.Black;
            this.btn_openDoc.Location = new System.Drawing.Point(16, 259);
            this.btn_openDoc.Name = "btn_openDoc";
            this.btn_openDoc.Size = new System.Drawing.Size(139, 38);
            this.btn_openDoc.TabIndex = 5;
            this.btn_openDoc.Text = "Open Document";
            this.btn_openDoc.UseVisualStyleBackColor = false;
            this.btn_openDoc.Visible = false;
            this.btn_openDoc.Click += new System.EventHandler(this.btn_openDoc_Click);
            // 
            // btn_openFolder
            // 
            this.btn_openFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_openFolder.BackColor = System.Drawing.Color.Yellow;
            this.btn_openFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_openFolder.Location = new System.Drawing.Point(306, 259);
            this.btn_openFolder.Name = "btn_openFolder";
            this.btn_openFolder.Size = new System.Drawing.Size(125, 38);
            this.btn_openFolder.TabIndex = 6;
            this.btn_openFolder.Text = "Open Folder";
            this.btn_openFolder.UseVisualStyleBackColor = false;
            this.btn_openFolder.Visible = false;
            this.btn_openFolder.Click += new System.EventHandler(this.btn_openFolder_Click);
            // 
            // btn_update
            // 
            this.btn_update.AutoEllipsis = true;
            this.btn_update.BackColor = System.Drawing.Color.DimGray;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(227, 94);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(92, 29);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_settings.AutoSize = true;
            this.btn_settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_settings.BackgroundImage")));
            this.btn_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_settings.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Location = new System.Drawing.Point(915, 9);
            this.btn_settings.Margin = new System.Windows.Forms.Padding(0);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(57, 46);
            this.btn_settings.TabIndex = 8;
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // CommandMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(984, 337);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_openFolder);
            this.Controls.Add(this.btn_openDoc);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.listbox_result);
            this.Controls.Add(this.textB_search);
            this.Controls.Add(this.lbl_search);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CommandMainForm";
            this.Text = "Operations Command Center";
            this.Load += new System.EventHandler(this.CommandMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.TextBox textB_search;
        private System.Windows.Forms.ListBox listbox_result;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_openDoc;
        private System.Windows.Forms.Button btn_openFolder;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_settings;
    }
}

