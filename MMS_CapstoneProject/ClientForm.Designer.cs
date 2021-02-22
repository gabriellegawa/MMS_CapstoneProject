
namespace MMS_CapstoneProject
{
    partial class ClientForm
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEscape = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.gbIsDeleted = new System.Windows.Forms.GroupBox();
            this.rdoIsDeleted_Disabled = new System.Windows.Forms.RadioButton();
            this.rdoIsDeleted_Enabled = new System.Windows.Forms.RadioButton();
            this.txtClientPrimaryContactEmail = new System.Windows.Forms.TextBox();
            this.lblClientPrimaryContactEmail = new System.Windows.Forms.Label();
            this.txtClientPrimaryContactCell = new System.Windows.Forms.MaskedTextBox();
            this.lblClientPrimaryContactCell = new System.Windows.Forms.Label();
            this.txtClientPrimaryContactName = new System.Windows.Forms.TextBox();
            this.lblClientPrimaryContactName = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.lblClientName = new System.Windows.Forms.Label();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.lblClientId = new System.Windows.Forms.Label();
            this.gbIsDeleted.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(88, 189);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 30;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEscape
            // 
            this.btnEscape.Location = new System.Drawing.Point(169, 189);
            this.btnEscape.Name = "btnEscape";
            this.btnEscape.Size = new System.Drawing.Size(75, 23);
            this.btnEscape.TabIndex = 31;
            this.btnEscape.Text = "Cancel";
            this.btnEscape.UseVisualStyleBackColor = true;
            this.btnEscape.Click += new System.EventHandler(this.btnEscape_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(7, 189);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 29;
            this.btnEnter.Text = "Create";
            this.btnEnter.UseVisualStyleBackColor = true;
            // 
            // gbIsDeleted
            // 
            this.gbIsDeleted.Controls.Add(this.rdoIsDeleted_Disabled);
            this.gbIsDeleted.Controls.Add(this.rdoIsDeleted_Enabled);
            this.gbIsDeleted.Location = new System.Drawing.Point(123, 137);
            this.gbIsDeleted.Name = "gbIsDeleted";
            this.gbIsDeleted.Size = new System.Drawing.Size(148, 35);
            this.gbIsDeleted.TabIndex = 28;
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
            // txtClientPrimaryContactEmail
            // 
            this.txtClientPrimaryContactEmail.Location = new System.Drawing.Point(123, 111);
            this.txtClientPrimaryContactEmail.Name = "txtClientPrimaryContactEmail";
            this.txtClientPrimaryContactEmail.Size = new System.Drawing.Size(100, 20);
            this.txtClientPrimaryContactEmail.TabIndex = 25;
            // 
            // lblClientPrimaryContactEmail
            // 
            this.lblClientPrimaryContactEmail.AutoSize = true;
            this.lblClientPrimaryContactEmail.Location = new System.Drawing.Point(81, 114);
            this.lblClientPrimaryContactEmail.Name = "lblClientPrimaryContactEmail";
            this.lblClientPrimaryContactEmail.Size = new System.Drawing.Size(35, 13);
            this.lblClientPrimaryContactEmail.TabIndex = 24;
            this.lblClientPrimaryContactEmail.Text = "Email:";
            // 
            // txtClientPrimaryContactCell
            // 
            this.txtClientPrimaryContactCell.Location = new System.Drawing.Point(123, 85);
            this.txtClientPrimaryContactCell.Mask = "(999) 000-0000";
            this.txtClientPrimaryContactCell.Name = "txtClientPrimaryContactCell";
            this.txtClientPrimaryContactCell.Size = new System.Drawing.Size(100, 20);
            this.txtClientPrimaryContactCell.TabIndex = 23;
            // 
            // lblClientPrimaryContactCell
            // 
            this.lblClientPrimaryContactCell.AutoSize = true;
            this.lblClientPrimaryContactCell.Location = new System.Drawing.Point(89, 88);
            this.lblClientPrimaryContactCell.Name = "lblClientPrimaryContactCell";
            this.lblClientPrimaryContactCell.Size = new System.Drawing.Size(27, 13);
            this.lblClientPrimaryContactCell.TabIndex = 22;
            this.lblClientPrimaryContactCell.Text = "Cell:";
            // 
            // txtClientPrimaryContactName
            // 
            this.txtClientPrimaryContactName.Location = new System.Drawing.Point(123, 59);
            this.txtClientPrimaryContactName.Name = "txtClientPrimaryContactName";
            this.txtClientPrimaryContactName.Size = new System.Drawing.Size(100, 20);
            this.txtClientPrimaryContactName.TabIndex = 21;
            // 
            // lblClientPrimaryContactName
            // 
            this.lblClientPrimaryContactName.AutoSize = true;
            this.lblClientPrimaryContactName.Location = new System.Drawing.Point(2, 62);
            this.lblClientPrimaryContactName.Name = "lblClientPrimaryContactName";
            this.lblClientPrimaryContactName.Size = new System.Drawing.Size(115, 13);
            this.lblClientPrimaryContactName.TabIndex = 20;
            this.lblClientPrimaryContactName.Text = "Primary Contact Name:";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(123, 33);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(100, 20);
            this.txtClientName.TabIndex = 19;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(78, 36);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(38, 13);
            this.lblClientName.TabIndex = 18;
            this.lblClientName.Text = "Name:";
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(123, 7);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(100, 20);
            this.txtClientId.TabIndex = 17;
            // 
            // lblClientId
            // 
            this.lblClientId.AutoSize = true;
            this.lblClientId.Location = new System.Drawing.Point(95, 10);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(21, 13);
            this.lblClientId.TabIndex = 16;
            this.lblClientId.Text = "ID:";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 216);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEscape);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.gbIsDeleted);
            this.Controls.Add(this.txtClientPrimaryContactEmail);
            this.Controls.Add(this.lblClientPrimaryContactEmail);
            this.Controls.Add(this.txtClientPrimaryContactCell);
            this.Controls.Add(this.lblClientPrimaryContactCell);
            this.Controls.Add(this.txtClientPrimaryContactName);
            this.Controls.Add(this.lblClientPrimaryContactName);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.txtClientId);
            this.Controls.Add(this.lblClientId);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.gbIsDeleted.ResumeLayout(false);
            this.gbIsDeleted.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEscape;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.GroupBox gbIsDeleted;
        private System.Windows.Forms.RadioButton rdoIsDeleted_Disabled;
        private System.Windows.Forms.RadioButton rdoIsDeleted_Enabled;
        private System.Windows.Forms.TextBox txtClientPrimaryContactEmail;
        private System.Windows.Forms.Label lblClientPrimaryContactEmail;
        private System.Windows.Forms.MaskedTextBox txtClientPrimaryContactCell;
        private System.Windows.Forms.Label lblClientPrimaryContactCell;
        private System.Windows.Forms.TextBox txtClientPrimaryContactName;
        private System.Windows.Forms.Label lblClientPrimaryContactName;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.Label lblClientId;
    }
}