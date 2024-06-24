namespace EPOS2_Controller
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
            this.mConnectBtn = new System.Windows.Forms.Button();
            this.mDataShowTxtBox = new System.Windows.Forms.TextBox();
            this.mSetrpmBtn = new System.Windows.Forms.Button();
            this.mSetRpmLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mVelocityActualLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mVelocityDemandLbl = new System.Windows.Forms.Label();
            this.mActualValueGrpBox = new System.Windows.Forms.GroupBox();
            this.mHaltBtn = new System.Windows.Forms.Button();
            this.mEnableBtn = new System.Windows.Forms.Button();
            this.mDisplayModeLbl = new System.Windows.Forms.Label();
            this.mDisableBtn = new System.Windows.Forms.Button();
            this.mActualValueGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mConnectBtn
            // 
            this.mConnectBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mConnectBtn.Location = new System.Drawing.Point(21, 113);
            this.mConnectBtn.Name = "mConnectBtn";
            this.mConnectBtn.Size = new System.Drawing.Size(125, 33);
            this.mConnectBtn.TabIndex = 0;
            this.mConnectBtn.Text = "Connect";
            this.mConnectBtn.UseVisualStyleBackColor = true;
            this.mConnectBtn.Click += new System.EventHandler(this.mConnectBtn_Click);
            // 
            // mDataShowTxtBox
            // 
            this.mDataShowTxtBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mDataShowTxtBox.Location = new System.Drawing.Point(21, 72);
            this.mDataShowTxtBox.Name = "mDataShowTxtBox";
            this.mDataShowTxtBox.Size = new System.Drawing.Size(275, 23);
            this.mDataShowTxtBox.TabIndex = 2;
            // 
            // mSetrpmBtn
            // 
            this.mSetrpmBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mSetrpmBtn.Location = new System.Drawing.Point(162, 113);
            this.mSetrpmBtn.Name = "mSetrpmBtn";
            this.mSetrpmBtn.Size = new System.Drawing.Size(134, 33);
            this.mSetrpmBtn.TabIndex = 1;
            this.mSetrpmBtn.Text = "Set Rpm";
            this.mSetrpmBtn.UseVisualStyleBackColor = true;
            this.mSetrpmBtn.Click += new System.EventHandler(this.mSetrpmBtn_Click);
            // 
            // mSetRpmLbl
            // 
            this.mSetRpmLbl.AutoSize = true;
            this.mSetRpmLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mSetRpmLbl.Location = new System.Drawing.Point(21, 47);
            this.mSetRpmLbl.Name = "mSetRpmLbl";
            this.mSetRpmLbl.Size = new System.Drawing.Size(33, 15);
            this.mSetRpmLbl.TabIndex = 3;
            this.mSetRpmLbl.Text = "RPM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Velocity Actual Value";
            // 
            // mVelocityActualLbl
            // 
            this.mVelocityActualLbl.AutoSize = true;
            this.mVelocityActualLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mVelocityActualLbl.Location = new System.Drawing.Point(201, 27);
            this.mVelocityActualLbl.Name = "mVelocityActualLbl";
            this.mVelocityActualLbl.Size = new System.Drawing.Size(0, 17);
            this.mVelocityActualLbl.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Velocity Demand Value";
            // 
            // mVelocityDemandLbl
            // 
            this.mVelocityDemandLbl.AutoSize = true;
            this.mVelocityDemandLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mVelocityDemandLbl.Location = new System.Drawing.Point(201, 64);
            this.mVelocityDemandLbl.Name = "mVelocityDemandLbl";
            this.mVelocityDemandLbl.Size = new System.Drawing.Size(0, 17);
            this.mVelocityDemandLbl.TabIndex = 3;
            // 
            // mActualValueGrpBox
            // 
            this.mActualValueGrpBox.Controls.Add(this.mVelocityDemandLbl);
            this.mActualValueGrpBox.Controls.Add(this.label4);
            this.mActualValueGrpBox.Controls.Add(this.mVelocityActualLbl);
            this.mActualValueGrpBox.Controls.Add(this.label2);
            this.mActualValueGrpBox.Location = new System.Drawing.Point(24, 223);
            this.mActualValueGrpBox.Name = "mActualValueGrpBox";
            this.mActualValueGrpBox.Size = new System.Drawing.Size(364, 106);
            this.mActualValueGrpBox.TabIndex = 4;
            this.mActualValueGrpBox.TabStop = false;
            this.mActualValueGrpBox.Text = "Actual Value";
            // 
            // mHaltBtn
            // 
            this.mHaltBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mHaltBtn.Location = new System.Drawing.Point(162, 166);
            this.mHaltBtn.Name = "mHaltBtn";
            this.mHaltBtn.Size = new System.Drawing.Size(134, 33);
            this.mHaltBtn.TabIndex = 1;
            this.mHaltBtn.Text = "Halt";
            this.mHaltBtn.UseVisualStyleBackColor = true;
            this.mHaltBtn.Click += new System.EventHandler(this.mHaltBtn_Click);
            // 
            // mEnableBtn
            // 
            this.mEnableBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mEnableBtn.Location = new System.Drawing.Point(21, 166);
            this.mEnableBtn.Name = "mEnableBtn";
            this.mEnableBtn.Size = new System.Drawing.Size(125, 33);
            this.mEnableBtn.TabIndex = 1;
            this.mEnableBtn.Text = "Enable";
            this.mEnableBtn.UseVisualStyleBackColor = true;
            this.mEnableBtn.Click += new System.EventHandler(this.mEnableBtn_Click);
            // 
            // mDisplayModeLbl
            // 
            this.mDisplayModeLbl.AutoSize = true;
            this.mDisplayModeLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mDisplayModeLbl.Location = new System.Drawing.Point(123, 25);
            this.mDisplayModeLbl.Name = "mDisplayModeLbl";
            this.mDisplayModeLbl.Size = new System.Drawing.Size(71, 15);
            this.mDisplayModeLbl.TabIndex = 3;
            this.mDisplayModeLbl.Text = "Unavailable";
            // 
            // mDisableBtn
            // 
            this.mDisableBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mDisableBtn.Location = new System.Drawing.Point(302, 166);
            this.mDisableBtn.Name = "mDisableBtn";
            this.mDisableBtn.Size = new System.Drawing.Size(125, 33);
            this.mDisableBtn.TabIndex = 1;
            this.mDisableBtn.Text = "Disable";
            this.mDisableBtn.UseVisualStyleBackColor = true;
            this.mDisableBtn.Click += new System.EventHandler(this.mDisableBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 348);
            this.Controls.Add(this.mActualValueGrpBox);
            this.Controls.Add(this.mDisplayModeLbl);
            this.Controls.Add(this.mSetRpmLbl);
            this.Controls.Add(this.mDataShowTxtBox);
            this.Controls.Add(this.mDisableBtn);
            this.Controls.Add(this.mEnableBtn);
            this.Controls.Add(this.mHaltBtn);
            this.Controls.Add(this.mSetrpmBtn);
            this.Controls.Add(this.mConnectBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.mActualValueGrpBox.ResumeLayout(false);
            this.mActualValueGrpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mConnectBtn;
        private System.Windows.Forms.TextBox mDataShowTxtBox;
        private System.Windows.Forms.Button mSetrpmBtn;
        private System.Windows.Forms.Label mSetRpmLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label mVelocityActualLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label mVelocityDemandLbl;
        private System.Windows.Forms.GroupBox mActualValueGrpBox;
        private System.Windows.Forms.Button mHaltBtn;
        private System.Windows.Forms.Button mEnableBtn;
        private System.Windows.Forms.Label mDisplayModeLbl;
        private System.Windows.Forms.Button mDisableBtn;
    }
}

