namespace Dashboard
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.grpBuilds = new System.Windows.Forms.GroupBox();
            this.btnBuild = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblEnvironment = new System.Windows.Forms.Label();
            this.cmbEnvironment = new System.Windows.Forms.ComboBox();
            this.grpDeployments = new System.Windows.Forms.GroupBox();
            this.picSSTAGING = new System.Windows.Forms.PictureBox();
            this.picWSTAGING = new System.Windows.Forms.PictureBox();
            this.picSTEST = new System.Windows.Forms.PictureBox();
            this.picWTEST = new System.Windows.Forms.PictureBox();
            this.picSDEV = new System.Windows.Forms.PictureBox();
            this.picWDEV = new System.Windows.Forms.PictureBox();
            this.lblPROD = new System.Windows.Forms.Label();
            this.txtSPROD = new System.Windows.Forms.TextBox();
            this.txtWPROD = new System.Windows.Forms.TextBox();
            this.txtSSTAGING = new System.Windows.Forms.TextBox();
            this.txtSTEST = new System.Windows.Forms.TextBox();
            this.txtWTEST = new System.Windows.Forms.TextBox();
            this.txtSDEV = new System.Windows.Forms.TextBox();
            this.txtWDEV = new System.Windows.Forms.TextBox();
            this.lblSTAGING = new System.Windows.Forms.Label();
            this.txtWSTAGING = new System.Windows.Forms.TextBox();
            this.lblTEST = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDEV = new System.Windows.Forms.Label();
            this.grpBuilds.SuspendLayout();
            this.grpDeployments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSSTAGING)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWSTAGING)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSTEST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWTEST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSDEV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWDEV)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBuilds
            // 
            this.grpBuilds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBuilds.Controls.Add(this.btnBuild);
            this.grpBuilds.Controls.Add(this.lblStatus);
            this.grpBuilds.Controls.Add(this.lblEnvironment);
            this.grpBuilds.Controls.Add(this.cmbEnvironment);
            this.grpBuilds.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBuilds.Location = new System.Drawing.Point(8, 8);
            this.grpBuilds.Name = "grpBuilds";
            this.grpBuilds.Size = new System.Drawing.Size(1059, 114);
            this.grpBuilds.TabIndex = 0;
            this.grpBuilds.TabStop = false;
            this.grpBuilds.Text = "Builds";
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(374, 33);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(426, 32);
            this.btnBuild.TabIndex = 3;
            this.btnBuild.Text = "Build and Deploy!";
            this.btnBuild.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblStatus.Location = new System.Drawing.Point(54, 76);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(75, 24);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Ready!";
            // 
            // lblEnvironment
            // 
            this.lblEnvironment.AutoSize = true;
            this.lblEnvironment.Location = new System.Drawing.Point(24, 37);
            this.lblEnvironment.Name = "lblEnvironment";
            this.lblEnvironment.Size = new System.Drawing.Size(128, 24);
            this.lblEnvironment.TabIndex = 1;
            this.lblEnvironment.Text = "Environment";
            // 
            // cmbEnvironment
            // 
            this.cmbEnvironment.FormattingEnabled = true;
            this.cmbEnvironment.Items.AddRange(new object[] {
            "DEVTEST",
            "STAGING",
            "PROD"});
            this.cmbEnvironment.Location = new System.Drawing.Point(160, 33);
            this.cmbEnvironment.Name = "cmbEnvironment";
            this.cmbEnvironment.Size = new System.Drawing.Size(208, 32);
            this.cmbEnvironment.TabIndex = 0;
            this.cmbEnvironment.SelectionChangeCommitted += new System.EventHandler(this.cmbEnvironment_SelectionChangeCommitted);
            this.cmbEnvironment.SelectedValueChanged += new System.EventHandler(this.cmbEnvironment_SelectedValueChanged);
            // 
            // grpDeployments
            // 
            this.grpDeployments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDeployments.Controls.Add(this.picSSTAGING);
            this.grpDeployments.Controls.Add(this.picWSTAGING);
            this.grpDeployments.Controls.Add(this.picSTEST);
            this.grpDeployments.Controls.Add(this.picWTEST);
            this.grpDeployments.Controls.Add(this.picSDEV);
            this.grpDeployments.Controls.Add(this.picWDEV);
            this.grpDeployments.Controls.Add(this.lblPROD);
            this.grpDeployments.Controls.Add(this.txtSPROD);
            this.grpDeployments.Controls.Add(this.txtWPROD);
            this.grpDeployments.Controls.Add(this.txtSSTAGING);
            this.grpDeployments.Controls.Add(this.txtSTEST);
            this.grpDeployments.Controls.Add(this.txtWTEST);
            this.grpDeployments.Controls.Add(this.txtSDEV);
            this.grpDeployments.Controls.Add(this.txtWDEV);
            this.grpDeployments.Controls.Add(this.lblSTAGING);
            this.grpDeployments.Controls.Add(this.txtWSTAGING);
            this.grpDeployments.Controls.Add(this.lblTEST);
            this.grpDeployments.Controls.Add(this.label3);
            this.grpDeployments.Controls.Add(this.label2);
            this.grpDeployments.Controls.Add(this.lblDEV);
            this.grpDeployments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDeployments.Location = new System.Drawing.Point(8, 128);
            this.grpDeployments.Name = "grpDeployments";
            this.grpDeployments.Size = new System.Drawing.Size(1059, 191);
            this.grpDeployments.TabIndex = 1;
            this.grpDeployments.TabStop = false;
            this.grpDeployments.Text = "Deployments";
            // 
            // picSSTAGING
            // 
            this.picSSTAGING.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSSTAGING.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picSSTAGING.ErrorImage")));
            this.picSSTAGING.Image = ((System.Drawing.Image)(resources.GetObject("picSSTAGING.Image")));
            this.picSSTAGING.InitialImage = ((System.Drawing.Image)(resources.GetObject("picSSTAGING.InitialImage")));
            this.picSSTAGING.Location = new System.Drawing.Point(806, 124);
            this.picSSTAGING.Name = "picSSTAGING";
            this.picSSTAGING.Size = new System.Drawing.Size(34, 29);
            this.picSSTAGING.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSSTAGING.TabIndex = 25;
            this.picSSTAGING.TabStop = false;
            // 
            // picWSTAGING
            // 
            this.picWSTAGING.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picWSTAGING.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picWSTAGING.ErrorImage")));
            this.picWSTAGING.Image = ((System.Drawing.Image)(resources.GetObject("picWSTAGING.Image")));
            this.picWSTAGING.InitialImage = ((System.Drawing.Image)(resources.GetObject("picWSTAGING.InitialImage")));
            this.picWSTAGING.Location = new System.Drawing.Point(806, 85);
            this.picWSTAGING.Name = "picWSTAGING";
            this.picWSTAGING.Size = new System.Drawing.Size(34, 29);
            this.picWSTAGING.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWSTAGING.TabIndex = 24;
            this.picWSTAGING.TabStop = false;
            // 
            // picSTEST
            // 
            this.picSTEST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSTEST.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picSTEST.ErrorImage")));
            this.picSTEST.Image = ((System.Drawing.Image)(resources.GetObject("picSTEST.Image")));
            this.picSTEST.InitialImage = ((System.Drawing.Image)(resources.GetObject("picSTEST.InitialImage")));
            this.picSTEST.Location = new System.Drawing.Point(560, 124);
            this.picSTEST.Name = "picSTEST";
            this.picSTEST.Size = new System.Drawing.Size(34, 29);
            this.picSTEST.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSTEST.TabIndex = 23;
            this.picSTEST.TabStop = false;
            // 
            // picWTEST
            // 
            this.picWTEST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picWTEST.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picWTEST.ErrorImage")));
            this.picWTEST.Image = ((System.Drawing.Image)(resources.GetObject("picWTEST.Image")));
            this.picWTEST.InitialImage = ((System.Drawing.Image)(resources.GetObject("picWTEST.InitialImage")));
            this.picWTEST.Location = new System.Drawing.Point(560, 85);
            this.picWTEST.Name = "picWTEST";
            this.picWTEST.Size = new System.Drawing.Size(34, 29);
            this.picWTEST.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWTEST.TabIndex = 22;
            this.picWTEST.TabStop = false;
            // 
            // picSDEV
            // 
            this.picSDEV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSDEV.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picSDEV.ErrorImage")));
            this.picSDEV.Image = ((System.Drawing.Image)(resources.GetObject("picSDEV.Image")));
            this.picSDEV.InitialImage = ((System.Drawing.Image)(resources.GetObject("picSDEV.InitialImage")));
            this.picSDEV.Location = new System.Drawing.Point(316, 124);
            this.picSDEV.Name = "picSDEV";
            this.picSDEV.Size = new System.Drawing.Size(34, 29);
            this.picSDEV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSDEV.TabIndex = 21;
            this.picSDEV.TabStop = false;
            // 
            // picWDEV
            // 
            this.picWDEV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picWDEV.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picWDEV.ErrorImage")));
            this.picWDEV.Image = ((System.Drawing.Image)(resources.GetObject("picWDEV.Image")));
            this.picWDEV.InitialImage = ((System.Drawing.Image)(resources.GetObject("picWDEV.InitialImage")));
            this.picWDEV.Location = new System.Drawing.Point(316, 85);
            this.picWDEV.Name = "picWDEV";
            this.picWDEV.Size = new System.Drawing.Size(34, 29);
            this.picWDEV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWDEV.TabIndex = 20;
            this.picWDEV.TabStop = false;
            // 
            // lblPROD
            // 
            this.lblPROD.AutoSize = true;
            this.lblPROD.Location = new System.Drawing.Point(869, 58);
            this.lblPROD.Name = "lblPROD";
            this.lblPROD.Size = new System.Drawing.Size(67, 24);
            this.lblPROD.TabIndex = 19;
            this.lblPROD.Text = "PROD";
            // 
            // txtSPROD
            // 
            this.txtSPROD.Location = new System.Drawing.Point(873, 124);
            this.txtSPROD.Name = "txtSPROD";
            this.txtSPROD.ReadOnly = true;
            this.txtSPROD.Size = new System.Drawing.Size(180, 29);
            this.txtSPROD.TabIndex = 18;
            this.txtSPROD.Text = "1.00.20201016.00";
            this.txtSPROD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWPROD
            // 
            this.txtWPROD.Location = new System.Drawing.Point(873, 85);
            this.txtWPROD.Name = "txtWPROD";
            this.txtWPROD.ReadOnly = true;
            this.txtWPROD.Size = new System.Drawing.Size(180, 29);
            this.txtWPROD.TabIndex = 9;
            this.txtWPROD.Text = "1.00.20201016.00";
            this.txtWPROD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSSTAGING
            // 
            this.txtSSTAGING.Location = new System.Drawing.Point(620, 124);
            this.txtSSTAGING.Name = "txtSSTAGING";
            this.txtSSTAGING.ReadOnly = true;
            this.txtSSTAGING.Size = new System.Drawing.Size(180, 29);
            this.txtSSTAGING.TabIndex = 17;
            this.txtSSTAGING.Text = "1.00.20201016.00";
            this.txtSSTAGING.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSTEST
            // 
            this.txtSTEST.Location = new System.Drawing.Point(374, 124);
            this.txtSTEST.Name = "txtSTEST";
            this.txtSTEST.ReadOnly = true;
            this.txtSTEST.Size = new System.Drawing.Size(180, 29);
            this.txtSTEST.TabIndex = 16;
            this.txtSTEST.Text = "1.00.20201016.00";
            this.txtSTEST.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWTEST
            // 
            this.txtWTEST.Location = new System.Drawing.Point(374, 85);
            this.txtWTEST.Name = "txtWTEST";
            this.txtWTEST.ReadOnly = true;
            this.txtWTEST.Size = new System.Drawing.Size(180, 29);
            this.txtWTEST.TabIndex = 15;
            this.txtWTEST.Text = "1.00.20201016.00";
            this.txtWTEST.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSDEV
            // 
            this.txtSDEV.Location = new System.Drawing.Point(130, 124);
            this.txtSDEV.Name = "txtSDEV";
            this.txtSDEV.ReadOnly = true;
            this.txtSDEV.Size = new System.Drawing.Size(180, 29);
            this.txtSDEV.TabIndex = 14;
            this.txtSDEV.Text = "1.00.20201016.00";
            this.txtSDEV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWDEV
            // 
            this.txtWDEV.Location = new System.Drawing.Point(130, 85);
            this.txtWDEV.Name = "txtWDEV";
            this.txtWDEV.ReadOnly = true;
            this.txtWDEV.Size = new System.Drawing.Size(180, 29);
            this.txtWDEV.TabIndex = 13;
            this.txtWDEV.Text = "1.00.20201016.00";
            this.txtWDEV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSTAGING
            // 
            this.lblSTAGING.AutoSize = true;
            this.lblSTAGING.Location = new System.Drawing.Point(616, 58);
            this.lblSTAGING.Name = "lblSTAGING";
            this.lblSTAGING.Size = new System.Drawing.Size(100, 24);
            this.lblSTAGING.TabIndex = 12;
            this.lblSTAGING.Text = "STAGING";
            // 
            // txtWSTAGING
            // 
            this.txtWSTAGING.Location = new System.Drawing.Point(620, 85);
            this.txtWSTAGING.Name = "txtWSTAGING";
            this.txtWSTAGING.ReadOnly = true;
            this.txtWSTAGING.Size = new System.Drawing.Size(180, 29);
            this.txtWSTAGING.TabIndex = 8;
            this.txtWSTAGING.Text = "1.00.20201016.00";
            this.txtWSTAGING.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTEST
            // 
            this.lblTEST.AutoSize = true;
            this.lblTEST.Location = new System.Drawing.Point(370, 56);
            this.lblTEST.Name = "lblTEST";
            this.lblTEST.Size = new System.Drawing.Size(63, 24);
            this.lblTEST.TabIndex = 7;
            this.lblTEST.Text = "TEST";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "SERVICES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "WEB APPS";
            // 
            // lblDEV
            // 
            this.lblDEV.AutoSize = true;
            this.lblDEV.Location = new System.Drawing.Point(126, 56);
            this.lblDEV.Name = "lblDEV";
            this.lblDEV.Size = new System.Drawing.Size(52, 24);
            this.lblDEV.TabIndex = 0;
            this.lblDEV.Text = "DEV";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 331);
            this.Controls.Add(this.grpDeployments);
            this.Controls.Add(this.grpBuilds);
            this.Name = "Dashboard";
            this.Text = "Build Dashboard";
            this.grpBuilds.ResumeLayout(false);
            this.grpBuilds.PerformLayout();
            this.grpDeployments.ResumeLayout(false);
            this.grpDeployments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSSTAGING)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWSTAGING)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSTEST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWTEST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSDEV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWDEV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBuilds;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblEnvironment;
        private System.Windows.Forms.ComboBox cmbEnvironment;
        private System.Windows.Forms.GroupBox grpDeployments;
        private System.Windows.Forms.PictureBox picSSTAGING;
        private System.Windows.Forms.PictureBox picWSTAGING;
        private System.Windows.Forms.PictureBox picSTEST;
        private System.Windows.Forms.PictureBox picWTEST;
        private System.Windows.Forms.PictureBox picSDEV;
        private System.Windows.Forms.PictureBox picWDEV;
        private System.Windows.Forms.Label lblPROD;
        private System.Windows.Forms.TextBox txtSPROD;
        private System.Windows.Forms.TextBox txtWPROD;
        private System.Windows.Forms.TextBox txtSSTAGING;
        private System.Windows.Forms.TextBox txtSTEST;
        private System.Windows.Forms.TextBox txtWTEST;
        private System.Windows.Forms.TextBox txtSDEV;
        private System.Windows.Forms.TextBox txtWDEV;
        private System.Windows.Forms.Label lblSTAGING;
        private System.Windows.Forms.TextBox txtWSTAGING;
        private System.Windows.Forms.Label lblTEST;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDEV;
    }
}

