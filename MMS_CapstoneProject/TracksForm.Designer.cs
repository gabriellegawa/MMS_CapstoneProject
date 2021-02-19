
namespace MMS_CapstoneProject
{
    partial class TracksForm
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
            this.lblTrackName = new System.Windows.Forms.Label();
            this.txtTrackName = new System.Windows.Forms.TextBox();
            this.lblTrackConfiguration = new System.Windows.Forms.Label();
            this.cbTrackConfiguration = new System.Windows.Forms.ComboBox();
            this.lblTrackId = new System.Windows.Forms.Label();
            this.txtTrackId = new System.Windows.Forms.TextBox();
            this.gbIsDeleted = new System.Windows.Forms.GroupBox();
            this.rdoIsDeleted_Disabled = new System.Windows.Forms.RadioButton();
            this.rdoIsDeleted_Enabled = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEscape = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.gbIsDeleted.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTrackName
            // 
            this.lblTrackName.AutoSize = true;
            this.lblTrackName.Location = new System.Drawing.Point(68, 41);
            this.lblTrackName.Name = "lblTrackName";
            this.lblTrackName.Size = new System.Drawing.Size(69, 13);
            this.lblTrackName.TabIndex = 0;
            this.lblTrackName.Text = "Track Name:";
            // 
            // txtTrackName
            // 
            this.txtTrackName.Location = new System.Drawing.Point(147, 38);
            this.txtTrackName.Name = "txtTrackName";
            this.txtTrackName.Size = new System.Drawing.Size(100, 20);
            this.txtTrackName.TabIndex = 1;
            // 
            // lblTrackConfiguration
            // 
            this.lblTrackConfiguration.AutoSize = true;
            this.lblTrackConfiguration.Location = new System.Drawing.Point(34, 72);
            this.lblTrackConfiguration.Name = "lblTrackConfiguration";
            this.lblTrackConfiguration.Size = new System.Drawing.Size(103, 13);
            this.lblTrackConfiguration.TabIndex = 2;
            this.lblTrackConfiguration.Text = "Track Configuration:";
            // 
            // cbTrackConfiguration
            // 
            this.cbTrackConfiguration.FormattingEnabled = true;
            this.cbTrackConfiguration.Location = new System.Drawing.Point(147, 64);
            this.cbTrackConfiguration.Name = "cbTrackConfiguration";
            this.cbTrackConfiguration.Size = new System.Drawing.Size(121, 21);
            this.cbTrackConfiguration.TabIndex = 3;
            // 
            // lblTrackId
            // 
            this.lblTrackId.AutoSize = true;
            this.lblTrackId.Location = new System.Drawing.Point(117, 15);
            this.lblTrackId.Name = "lblTrackId";
            this.lblTrackId.Size = new System.Drawing.Size(21, 13);
            this.lblTrackId.TabIndex = 25;
            this.lblTrackId.Text = "ID:";
            // 
            // txtTrackId
            // 
            this.txtTrackId.Location = new System.Drawing.Point(147, 12);
            this.txtTrackId.Name = "txtTrackId";
            this.txtTrackId.Size = new System.Drawing.Size(100, 20);
            this.txtTrackId.TabIndex = 26;
            // 
            // gbIsDeleted
            // 
            this.gbIsDeleted.Controls.Add(this.rdoIsDeleted_Disabled);
            this.gbIsDeleted.Controls.Add(this.rdoIsDeleted_Enabled);
            this.gbIsDeleted.Location = new System.Drawing.Point(147, 91);
            this.gbIsDeleted.Name = "gbIsDeleted";
            this.gbIsDeleted.Size = new System.Drawing.Size(148, 35);
            this.gbIsDeleted.TabIndex = 27;
            this.gbIsDeleted.TabStop = false;
            // 
            // rdoIsDeleted_Disabled
            // 
            this.rdoIsDeleted_Disabled.AutoSize = true;
            this.rdoIsDeleted_Disabled.Location = new System.Drawing.Point(76, 12);
            this.rdoIsDeleted_Disabled.Name = "rdoIsDeleted_Disabled";
            this.rdoIsDeleted_Disabled.Size = new System.Drawing.Size(66, 17);
            this.rdoIsDeleted_Disabled.TabIndex = 1;
            this.rdoIsDeleted_Disabled.Text = "Disabled";
            this.rdoIsDeleted_Disabled.UseVisualStyleBackColor = true;
            // 
            // rdoIsDeleted_Enabled
            // 
            this.rdoIsDeleted_Enabled.AutoSize = true;
            this.rdoIsDeleted_Enabled.Checked = true;
            this.rdoIsDeleted_Enabled.Location = new System.Drawing.Point(8, 12);
            this.rdoIsDeleted_Enabled.Name = "rdoIsDeleted_Enabled";
            this.rdoIsDeleted_Enabled.Size = new System.Drawing.Size(64, 17);
            this.rdoIsDeleted_Enabled.TabIndex = 0;
            this.rdoIsDeleted_Enabled.TabStop = true;
            this.rdoIsDeleted_Enabled.Text = "Enabled";
            this.rdoIsDeleted_Enabled.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(118, 141);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEscape
            // 
            this.btnEscape.Location = new System.Drawing.Point(199, 141);
            this.btnEscape.Name = "btnEscape";
            this.btnEscape.Size = new System.Drawing.Size(75, 23);
            this.btnEscape.TabIndex = 30;
            this.btnEscape.Text = "Cancel";
            this.btnEscape.UseVisualStyleBackColor = true;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(37, 141);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 28;
            this.btnEnter.Text = "Create";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // TracksForm
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(324, 198);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEscape);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.gbIsDeleted);
            this.Controls.Add(this.txtTrackId);
            this.Controls.Add(this.lblTrackId);
            this.Controls.Add(this.cbTrackConfiguration);
            this.Controls.Add(this.lblTrackConfiguration);
            this.Controls.Add(this.txtTrackName);
            this.Controls.Add(this.lblTrackName);
            this.Name = "TracksForm";
            this.Text = "TracksForm";
            this.gbIsDeleted.ResumeLayout(false);
            this.gbIsDeleted.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrackName;
        private System.Windows.Forms.TextBox txtTrackName;
        private System.Windows.Forms.Label lblTrackConfiguration;
        private System.Windows.Forms.ComboBox cbTrackConfiguration;
        private System.Windows.Forms.Label lblTrackId;
        private System.Windows.Forms.TextBox txtTrackId;
        private System.Windows.Forms.GroupBox gbIsDeleted;
        private System.Windows.Forms.RadioButton rdoIsDeleted_Disabled;
        private System.Windows.Forms.RadioButton rdoIsDeleted_Enabled;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEscape;
        private System.Windows.Forms.Button btnEnter;
    }
}