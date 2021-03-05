
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TracksForm));
            this.lblTrackName = new System.Windows.Forms.Label();
            this.txtTrackName = new System.Windows.Forms.TextBox();
            this.lblTrackId = new System.Windows.Forms.Label();
            this.txtTrackId = new System.Windows.Forms.TextBox();
            this.gbIsDeleted = new System.Windows.Forms.GroupBox();
            this.rdoIsDeleted_Disabled = new System.Windows.Forms.RadioButton();
            this.rdoIsDeleted_Enabled = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEscape = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.errorProviderApp = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbIsDeleted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTrackName
            // 
            this.lblTrackName.AutoSize = true;
            this.lblTrackName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackName.Location = new System.Drawing.Point(37, 43);
            this.lblTrackName.Name = "lblTrackName";
            this.lblTrackName.Size = new System.Drawing.Size(98, 20);
            this.lblTrackName.TabIndex = 2;
            this.lblTrackName.Text = "Track Name:";
            // 
            // txtTrackName
            // 
            this.txtTrackName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrackName.Location = new System.Drawing.Point(141, 40);
            this.txtTrackName.Name = "txtTrackName";
            this.txtTrackName.Size = new System.Drawing.Size(100, 26);
            this.txtTrackName.TabIndex = 3;
            this.txtTrackName.Validating += new System.ComponentModel.CancelEventHandler(this.txtTrackName_Validating);
            // 
            // lblTrackId
            // 
            this.lblTrackId.AutoSize = true;
            this.lblTrackId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackId.Location = new System.Drawing.Point(105, 11);
            this.lblTrackId.Name = "lblTrackId";
            this.lblTrackId.Size = new System.Drawing.Size(30, 20);
            this.lblTrackId.TabIndex = 0;
            this.lblTrackId.Text = "ID:";
            // 
            // txtTrackId
            // 
            this.txtTrackId.Enabled = false;
            this.txtTrackId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrackId.Location = new System.Drawing.Point(141, 8);
            this.txtTrackId.Name = "txtTrackId";
            this.txtTrackId.Size = new System.Drawing.Size(100, 26);
            this.txtTrackId.TabIndex = 1;
            // 
            // gbIsDeleted
            // 
            this.gbIsDeleted.Controls.Add(this.rdoIsDeleted_Disabled);
            this.gbIsDeleted.Controls.Add(this.rdoIsDeleted_Enabled);
            this.gbIsDeleted.Location = new System.Drawing.Point(141, 72);
            this.gbIsDeleted.Name = "gbIsDeleted";
            this.gbIsDeleted.Size = new System.Drawing.Size(193, 47);
            this.gbIsDeleted.TabIndex = 4;
            this.gbIsDeleted.TabStop = false;
            // 
            // rdoIsDeleted_Disabled
            // 
            this.rdoIsDeleted_Disabled.AutoSize = true;
            this.rdoIsDeleted_Disabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoIsDeleted_Disabled.Location = new System.Drawing.Point(98, 12);
            this.rdoIsDeleted_Disabled.Name = "rdoIsDeleted_Disabled";
            this.rdoIsDeleted_Disabled.Size = new System.Drawing.Size(89, 24);
            this.rdoIsDeleted_Disabled.TabIndex = 1;
            this.rdoIsDeleted_Disabled.Text = "Disabled";
            this.rdoIsDeleted_Disabled.UseVisualStyleBackColor = true;
            // 
            // rdoIsDeleted_Enabled
            // 
            this.rdoIsDeleted_Enabled.AutoSize = true;
            this.rdoIsDeleted_Enabled.Checked = true;
            this.rdoIsDeleted_Enabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoIsDeleted_Enabled.Location = new System.Drawing.Point(6, 12);
            this.rdoIsDeleted_Enabled.Name = "rdoIsDeleted_Enabled";
            this.rdoIsDeleted_Enabled.Size = new System.Drawing.Size(86, 24);
            this.rdoIsDeleted_Enabled.TabIndex = 0;
            this.rdoIsDeleted_Enabled.TabStop = true;
            this.rdoIsDeleted_Enabled.Text = "Enabled";
            this.rdoIsDeleted_Enabled.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(124, 137);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 39);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEscape
            // 
            this.btnEscape.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscape.Location = new System.Drawing.Point(234, 137);
            this.btnEscape.Name = "btnEscape";
            this.btnEscape.Size = new System.Drawing.Size(100, 39);
            this.btnEscape.TabIndex = 7;
            this.btnEscape.Text = "&Cancel";
            this.btnEscape.UseVisualStyleBackColor = true;
            this.btnEscape.Click += new System.EventHandler(this.btnEscape_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(12, 137);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(100, 39);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "&Add";
            this.btnEnter.UseVisualStyleBackColor = true;
            // 
            // errorProviderApp
            // 
            this.errorProviderApp.ContainerControl = this;
            // 
            // TracksForm
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(347, 198);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEscape);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.gbIsDeleted);
            this.Controls.Add(this.txtTrackId);
            this.Controls.Add(this.lblTrackId);
            this.Controls.Add(this.txtTrackName);
            this.Controls.Add(this.lblTrackName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(363, 237);
            this.MinimumSize = new System.Drawing.Size(363, 237);
            this.Name = "TracksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tracks Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TracksForm_FormClosing);
            this.gbIsDeleted.ResumeLayout(false);
            this.gbIsDeleted.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrackName;
        private System.Windows.Forms.TextBox txtTrackName;
        private System.Windows.Forms.Label lblTrackId;
        private System.Windows.Forms.TextBox txtTrackId;
        private System.Windows.Forms.GroupBox gbIsDeleted;
        private System.Windows.Forms.RadioButton rdoIsDeleted_Disabled;
        private System.Windows.Forms.RadioButton rdoIsDeleted_Enabled;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEscape;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.ErrorProvider errorProviderApp;
    }
}