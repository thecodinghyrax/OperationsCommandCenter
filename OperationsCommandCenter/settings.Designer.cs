
namespace OperationsCommandCenter
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.lbl_header = new System.Windows.Forms.Label();
            this.input_sap_location = new System.Windows.Forms.TextBox();
            this.lbl_SAP = new System.Windows.Forms.Label();
            this.lbl_windows = new System.Windows.Forms.Label();
            this.input_win_location = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.BackColor = System.Drawing.SystemColors.Desktop;
            this.lbl_header.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.ForeColor = System.Drawing.Color.White;
            this.lbl_header.Location = new System.Drawing.Point(28, 18);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(182, 60);
            this.lbl_header.TabIndex = 0;
            this.lbl_header.Text = "Settings";
            // 
            // input_sap_location
            // 
            this.input_sap_location.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input_sap_location.Location = new System.Drawing.Point(25, 117);
            this.input_sap_location.Name = "input_sap_location";
            this.input_sap_location.Size = new System.Drawing.Size(357, 38);
            this.input_sap_location.TabIndex = 1;
            this.input_sap_location.TextChanged += new System.EventHandler(this.input_sap_location_TextChanged);
            // 
            // lbl_SAP
            // 
            this.lbl_SAP.AutoSize = true;
            this.lbl_SAP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SAP.ForeColor = System.Drawing.Color.White;
            this.lbl_SAP.Location = new System.Drawing.Point(26, 91);
            this.lbl_SAP.Name = "lbl_SAP";
            this.lbl_SAP.Size = new System.Drawing.Size(162, 23);
            this.lbl_SAP.TabIndex = 2;
            this.lbl_SAP.Text = "SAP Folder Location";
            // 
            // lbl_windows
            // 
            this.lbl_windows.AutoSize = true;
            this.lbl_windows.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_windows.ForeColor = System.Drawing.Color.White;
            this.lbl_windows.Location = new System.Drawing.Point(26, 163);
            this.lbl_windows.Name = "lbl_windows";
            this.lbl_windows.Size = new System.Drawing.Size(201, 23);
            this.lbl_windows.TabIndex = 4;
            this.lbl_windows.Text = "Windows Folder Location";
            this.lbl_windows.Click += new System.EventHandler(this.label1_Click);
            // 
            // input_win_location
            // 
            this.input_win_location.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input_win_location.Location = new System.Drawing.Point(25, 189);
            this.input_win_location.Name = "input_win_location";
            this.input_win_location.Size = new System.Drawing.Size(357, 38);
            this.input_win_location.TabIndex = 3;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Location = new System.Drawing.Point(25, 250);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(108, 43);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(410, 322);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_windows);
            this.Controls.Add(this.input_win_location);
            this.Controls.Add(this.lbl_SAP);
            this.Controls.Add(this.input_sap_location);
            this.Controls.Add(this.lbl_header);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Settings";
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.TextBox input_sap_location;
        private System.Windows.Forms.Label lbl_SAP;
        private System.Windows.Forms.Label lbl_windows;
        private System.Windows.Forms.TextBox input_win_location;
        private System.Windows.Forms.Button btn_save;
    }
}