namespace WindowsFormsApp1
{
    partial class SortAISettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SortAISettings));
            this.txtSourceLocation = new System.Windows.Forms.TextBox();
            this.txtDestLocation = new System.Windows.Forms.TextBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.btnSetSource = new System.Windows.Forms.Button();
            this.btnSetDestination = new System.Windows.Forms.Button();
            this.btnForceSort = new System.Windows.Forms.Button();
            this.sourceDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.destinationDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtLogFiles = new System.Windows.Forms.TextBox();
            this.lblLogFiles = new System.Windows.Forms.Label();
            this.SortAIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSourceLocation
            // 
            this.txtSourceLocation.Location = new System.Drawing.Point(83, 12);
            this.txtSourceLocation.Name = "txtSourceLocation";
            this.txtSourceLocation.Size = new System.Drawing.Size(210, 20);
            this.txtSourceLocation.TabIndex = 1;
            // 
            // txtDestLocation
            // 
            this.txtDestLocation.Location = new System.Drawing.Point(83, 52);
            this.txtDestLocation.Name = "txtDestLocation";
            this.txtDestLocation.Size = new System.Drawing.Size(210, 20);
            this.txtDestLocation.TabIndex = 3;
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(14, 15);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(41, 13);
            this.lblSource.TabIndex = 2;
            this.lblSource.Text = "Source";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(14, 55);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(60, 13);
            this.lblDestination.TabIndex = 3;
            this.lblDestination.Text = "Destination";
            // 
            // btnSetSource
            // 
            this.btnSetSource.Location = new System.Drawing.Point(299, 10);
            this.btnSetSource.Name = "btnSetSource";
            this.btnSetSource.Size = new System.Drawing.Size(75, 23);
            this.btnSetSource.TabIndex = 2;
            this.btnSetSource.Text = "Browse";
            this.btnSetSource.UseVisualStyleBackColor = true;
            this.btnSetSource.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSetDestination
            // 
            this.btnSetDestination.Location = new System.Drawing.Point(299, 50);
            this.btnSetDestination.Name = "btnSetDestination";
            this.btnSetDestination.Size = new System.Drawing.Size(75, 23);
            this.btnSetDestination.TabIndex = 4;
            this.btnSetDestination.Text = "Browse";
            this.btnSetDestination.UseVisualStyleBackColor = true;
            this.btnSetDestination.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnForceSort
            // 
            this.btnForceSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForceSort.Location = new System.Drawing.Point(299, 92);
            this.btnForceSort.Name = "btnForceSort";
            this.btnForceSort.Size = new System.Drawing.Size(75, 43);
            this.btnForceSort.TabIndex = 5;
            this.btnForceSort.Text = "Force Sort";
            this.btnForceSort.UseVisualStyleBackColor = true;
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.lblInfo);
            this.grpInfo.Location = new System.Drawing.Point(17, 87);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(276, 100);
            this.grpInfo.TabIndex = 7;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Information";
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(7, 20);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(263, 77);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Set the Source folder as your folder that needs to be sorted by Sort.AI\r\n\r\nSet th" +
    "e Destination folder to the folder you would like the sorted files to be placed " +
    "once organised by Sort.AI";
            // 
            // txtLogFiles
            // 
            this.txtLogFiles.Location = new System.Drawing.Point(400, 31);
            this.txtLogFiles.Multiline = true;
            this.txtLogFiles.Name = "txtLogFiles";
            this.txtLogFiles.ReadOnly = true;
            this.txtLogFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogFiles.Size = new System.Drawing.Size(370, 218);
            this.txtLogFiles.TabIndex = 6;
            // 
            // lblLogFiles
            // 
            this.lblLogFiles.AutoSize = true;
            this.lblLogFiles.Location = new System.Drawing.Point(397, 15);
            this.lblLogFiles.Name = "lblLogFiles";
            this.lblLogFiles.Size = new System.Drawing.Size(49, 13);
            this.lblLogFiles.TabIndex = 2;
            this.lblLogFiles.Text = "Log Files";
            // 
            // SortAIcon
            // 
            this.SortAIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("SortAIcon.Icon")));
            this.SortAIcon.Text = "SortAIcon";
            this.SortAIcon.Visible = true;
            // 
            // SortAISettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 261);
            this.Controls.Add(this.txtLogFiles);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.btnForceSort);
            this.Controls.Add(this.btnSetDestination);
            this.Controls.Add(this.btnSetSource);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblLogFiles);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.txtDestLocation);
            this.Controls.Add(this.txtSourceLocation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SortAISettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sort.AI Settings";
            this.ResizeBegin += new System.EventHandler(this.SortAISettings_ResizeBegin);
            this.grpInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSourceLocation;
        private System.Windows.Forms.TextBox txtDestLocation;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Button btnSetSource;
        private System.Windows.Forms.Button btnSetDestination;
        private System.Windows.Forms.Button btnForceSort;
        private System.Windows.Forms.FolderBrowserDialog sourceDialog;
        private System.Windows.Forms.FolderBrowserDialog destinationDialog;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtLogFiles;
        private System.Windows.Forms.Label lblLogFiles;
        private System.Windows.Forms.NotifyIcon SortAIcon;
    }
}

