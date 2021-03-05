
namespace MMS_CapstoneProject
{
    partial class TrackWorkerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrackWorkerForm));
            this.lblTrackWorkerId = new System.Windows.Forms.Label();
            this.txtTrackWorkerId = new System.Windows.Forms.TextBox();
            this.txtTrackWorkerFirstName = new System.Windows.Forms.TextBox();
            this.lblTrackWorkerFirstName = new System.Windows.Forms.Label();
            this.txtTrackWorkerLastName = new System.Windows.Forms.TextBox();
            this.lblTrackWorkerLastName = new System.Windows.Forms.Label();
            this.lblTrackWorkerCell = new System.Windows.Forms.Label();
            this.txtTrackWorkerCell = new System.Windows.Forms.MaskedTextBox();
            this.lblClientWorkerEmail = new System.Windows.Forms.Label();
            this.txtTrackWorkerEmail = new System.Windows.Forms.TextBox();
            this.lblTrackWorkerIsCapableCaptain = new System.Windows.Forms.Label();
            this.gbIsCapableCaptain = new System.Windows.Forms.GroupBox();
            this.rdoIsCapableCaptain_False = new System.Windows.Forms.RadioButton();
            this.rdoIsCapableCaptain_True = new System.Windows.Forms.RadioButton();
            this.gbIsDeleted = new System.Windows.Forms.GroupBox();
            this.rdoIsDeleted_Disabled = new System.Windows.Forms.RadioButton();
            this.rdoIsDeleted_Enabled = new System.Windows.Forms.RadioButton();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnEscape = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.errorProviderApp = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTipApp = new System.Windows.Forms.ToolTip(this.components);
            this.gbIsCapableCaptain.SuspendLayout();
            this.gbIsDeleted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTrackWorkerId
            // 
            this.lblTrackWorkerId.AutoSize = true;
            this.lblTrackWorkerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackWorkerId.Location = new System.Drawing.Point(114, 9);
            this.lblTrackWorkerId.Name = "lblTrackWorkerId";
            this.lblTrackWorkerId.Size = new System.Drawing.Size(30, 20);
            this.lblTrackWorkerId.TabIndex = 0;
            this.lblTrackWorkerId.Text = "ID:";
            // 
            // txtTrackWorkerId
            // 
            this.txtTrackWorkerId.Enabled = false;
            this.txtTrackWorkerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrackWorkerId.Location = new System.Drawing.Point(150, 6);
            this.txtTrackWorkerId.Name = "txtTrackWorkerId";
            this.txtTrackWorkerId.Size = new System.Drawing.Size(66, 26);
            this.txtTrackWorkerId.TabIndex = 1;
            // 
            // txtTrackWorkerFirstName
            // 
            this.txtTrackWorkerFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrackWorkerFirstName.Location = new System.Drawing.Point(150, 38);
            this.txtTrackWorkerFirstName.Name = "txtTrackWorkerFirstName";
            this.txtTrackWorkerFirstName.Size = new System.Drawing.Size(190, 26);
            this.txtTrackWorkerFirstName.TabIndex = 3;
            this.toolTipApp.SetToolTip(this.txtTrackWorkerFirstName, "Track Worker First Name");
            // 
            // lblTrackWorkerFirstName
            // 
            this.lblTrackWorkerFirstName.AutoSize = true;
            this.lblTrackWorkerFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackWorkerFirstName.Location = new System.Drawing.Point(56, 41);
            this.lblTrackWorkerFirstName.Name = "lblTrackWorkerFirstName";
            this.lblTrackWorkerFirstName.Size = new System.Drawing.Size(90, 20);
            this.lblTrackWorkerFirstName.TabIndex = 2;
            this.lblTrackWorkerFirstName.Text = "First Name:";
            // 
            // txtTrackWorkerLastName
            // 
            this.txtTrackWorkerLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrackWorkerLastName.Location = new System.Drawing.Point(150, 70);
            this.txtTrackWorkerLastName.Name = "txtTrackWorkerLastName";
            this.txtTrackWorkerLastName.Size = new System.Drawing.Size(190, 26);
            this.txtTrackWorkerLastName.TabIndex = 5;
            this.toolTipApp.SetToolTip(this.txtTrackWorkerLastName, "Track Worker Last Name");
            // 
            // lblTrackWorkerLastName
            // 
            this.lblTrackWorkerLastName.AutoSize = true;
            this.lblTrackWorkerLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackWorkerLastName.Location = new System.Drawing.Point(54, 73);
            this.lblTrackWorkerLastName.Name = "lblTrackWorkerLastName";
            this.lblTrackWorkerLastName.Size = new System.Drawing.Size(90, 20);
            this.lblTrackWorkerLastName.TabIndex = 4;
            this.lblTrackWorkerLastName.Text = "Last Name:";
            // 
            // lblTrackWorkerCell
            // 
            this.lblTrackWorkerCell.AutoSize = true;
            this.lblTrackWorkerCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackWorkerCell.Location = new System.Drawing.Point(105, 105);
            this.lblTrackWorkerCell.Name = "lblTrackWorkerCell";
            this.lblTrackWorkerCell.Size = new System.Drawing.Size(39, 20);
            this.lblTrackWorkerCell.TabIndex = 6;
            this.lblTrackWorkerCell.Text = "Cell:";
            // 
            // txtTrackWorkerCell
            // 
            this.txtTrackWorkerCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrackWorkerCell.Location = new System.Drawing.Point(150, 102);
            this.txtTrackWorkerCell.Mask = "(999) 000-0000";
            this.txtTrackWorkerCell.Name = "txtTrackWorkerCell";
            this.txtTrackWorkerCell.Size = new System.Drawing.Size(117, 26);
            this.txtTrackWorkerCell.TabIndex = 7;
            this.txtTrackWorkerCell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipApp.SetToolTip(this.txtTrackWorkerCell, "Track Worker Cell Number");
            // 
            // lblClientWorkerEmail
            // 
            this.lblClientWorkerEmail.AutoSize = true;
            this.lblClientWorkerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientWorkerEmail.Location = new System.Drawing.Point(92, 137);
            this.lblClientWorkerEmail.Name = "lblClientWorkerEmail";
            this.lblClientWorkerEmail.Size = new System.Drawing.Size(52, 20);
            this.lblClientWorkerEmail.TabIndex = 8;
            this.lblClientWorkerEmail.Text = "Email:";
            // 
            // txtTrackWorkerEmail
            // 
            this.txtTrackWorkerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrackWorkerEmail.Location = new System.Drawing.Point(150, 134);
            this.txtTrackWorkerEmail.Name = "txtTrackWorkerEmail";
            this.txtTrackWorkerEmail.Size = new System.Drawing.Size(190, 26);
            this.txtTrackWorkerEmail.TabIndex = 9;
            this.toolTipApp.SetToolTip(this.txtTrackWorkerEmail, "Track Worker Email Address");
            // 
            // lblTrackWorkerIsCapableCaptain
            // 
            this.lblTrackWorkerIsCapableCaptain.AutoSize = true;
            this.lblTrackWorkerIsCapableCaptain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackWorkerIsCapableCaptain.Location = new System.Drawing.Point(13, 179);
            this.lblTrackWorkerIsCapableCaptain.Name = "lblTrackWorkerIsCapableCaptain";
            this.lblTrackWorkerIsCapableCaptain.Size = new System.Drawing.Size(131, 20);
            this.lblTrackWorkerIsCapableCaptain.TabIndex = 10;
            this.lblTrackWorkerIsCapableCaptain.Text = "Capable Captain:";
            // 
            // gbIsCapableCaptain
            // 
            this.gbIsCapableCaptain.Controls.Add(this.rdoIsCapableCaptain_False);
            this.gbIsCapableCaptain.Controls.Add(this.rdoIsCapableCaptain_True);
            this.gbIsCapableCaptain.Location = new System.Drawing.Point(150, 166);
            this.gbIsCapableCaptain.Name = "gbIsCapableCaptain";
            this.gbIsCapableCaptain.Size = new System.Drawing.Size(193, 46);
            this.gbIsCapableCaptain.TabIndex = 11;
            this.gbIsCapableCaptain.TabStop = false;
            this.toolTipApp.SetToolTip(this.gbIsCapableCaptain, "Track Worker Capable Captain");
            // 
            // rdoIsCapableCaptain_False
            // 
            this.rdoIsCapableCaptain_False.AutoSize = true;
            this.rdoIsCapableCaptain_False.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoIsCapableCaptain_False.Location = new System.Drawing.Point(101, 16);
            this.rdoIsCapableCaptain_False.Name = "rdoIsCapableCaptain_False";
            this.rdoIsCapableCaptain_False.Size = new System.Drawing.Size(66, 24);
            this.rdoIsCapableCaptain_False.TabIndex = 1;
            this.rdoIsCapableCaptain_False.Text = "False";
            this.rdoIsCapableCaptain_False.UseVisualStyleBackColor = true;
            // 
            // rdoIsCapableCaptain_True
            // 
            this.rdoIsCapableCaptain_True.AutoSize = true;
            this.rdoIsCapableCaptain_True.Checked = true;
            this.rdoIsCapableCaptain_True.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoIsCapableCaptain_True.Location = new System.Drawing.Point(9, 16);
            this.rdoIsCapableCaptain_True.Name = "rdoIsCapableCaptain_True";
            this.rdoIsCapableCaptain_True.Size = new System.Drawing.Size(59, 24);
            this.rdoIsCapableCaptain_True.TabIndex = 0;
            this.rdoIsCapableCaptain_True.TabStop = true;
            this.rdoIsCapableCaptain_True.Text = "True";
            this.rdoIsCapableCaptain_True.UseVisualStyleBackColor = true;
            // 
            // gbIsDeleted
            // 
            this.gbIsDeleted.Controls.Add(this.rdoIsDeleted_Disabled);
            this.gbIsDeleted.Controls.Add(this.rdoIsDeleted_Enabled);
            this.gbIsDeleted.Location = new System.Drawing.Point(151, 218);
            this.gbIsDeleted.Name = "gbIsDeleted";
            this.gbIsDeleted.Size = new System.Drawing.Size(193, 47);
            this.gbIsDeleted.TabIndex = 12;
            this.gbIsDeleted.TabStop = false;
            this.toolTipApp.SetToolTip(this.gbIsDeleted, "Track Worker Is Deleted");
            // 
            // rdoIsDeleted_Disabled
            // 
            this.rdoIsDeleted_Disabled.AutoSize = true;
            this.rdoIsDeleted_Disabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoIsDeleted_Disabled.Location = new System.Drawing.Point(100, 12);
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
            this.rdoIsDeleted_Enabled.Location = new System.Drawing.Point(8, 12);
            this.rdoIsDeleted_Enabled.Name = "rdoIsDeleted_Enabled";
            this.rdoIsDeleted_Enabled.Size = new System.Drawing.Size(86, 24);
            this.rdoIsDeleted_Enabled.TabIndex = 0;
            this.rdoIsDeleted_Enabled.TabStop = true;
            this.rdoIsDeleted_Enabled.Text = "Enabled";
            this.rdoIsDeleted_Enabled.UseVisualStyleBackColor = true;
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(17, 291);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(100, 39);
            this.btnEnter.TabIndex = 13;
            this.btnEnter.Text = "&Add";
            this.btnEnter.UseVisualStyleBackColor = true;
            // 
            // btnEscape
            // 
            this.btnEscape.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEscape.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscape.Location = new System.Drawing.Point(240, 291);
            this.btnEscape.Name = "btnEscape";
            this.btnEscape.Size = new System.Drawing.Size(100, 39);
            this.btnEscape.TabIndex = 15;
            this.btnEscape.Text = "&Cancel";
            this.btnEscape.UseVisualStyleBackColor = true;
            this.btnEscape.Click += new System.EventHandler(this.btnEscape_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(130, 291);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 39);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // errorProviderApp
            // 
            this.errorProviderApp.ContainerControl = this;
            // 
            // TrackWorkerForm
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnEscape;
            this.ClientSize = new System.Drawing.Size(368, 358);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEscape);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.gbIsDeleted);
            this.Controls.Add(this.gbIsCapableCaptain);
            this.Controls.Add(this.lblTrackWorkerIsCapableCaptain);
            this.Controls.Add(this.txtTrackWorkerEmail);
            this.Controls.Add(this.lblClientWorkerEmail);
            this.Controls.Add(this.txtTrackWorkerCell);
            this.Controls.Add(this.lblTrackWorkerCell);
            this.Controls.Add(this.txtTrackWorkerLastName);
            this.Controls.Add(this.lblTrackWorkerLastName);
            this.Controls.Add(this.txtTrackWorkerFirstName);
            this.Controls.Add(this.lblTrackWorkerFirstName);
            this.Controls.Add(this.txtTrackWorkerId);
            this.Controls.Add(this.lblTrackWorkerId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrackWorkerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Track Worker Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrackWorkerForm_FormClosing);
            this.gbIsCapableCaptain.ResumeLayout(false);
            this.gbIsCapableCaptain.PerformLayout();
            this.gbIsDeleted.ResumeLayout(false);
            this.gbIsDeleted.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrackWorkerId;
        private System.Windows.Forms.TextBox txtTrackWorkerFirstName;
        private System.Windows.Forms.Label lblTrackWorkerFirstName;
        private System.Windows.Forms.TextBox txtTrackWorkerLastName;
        private System.Windows.Forms.Label lblTrackWorkerLastName;
        private System.Windows.Forms.Label lblTrackWorkerCell;
        private System.Windows.Forms.MaskedTextBox txtTrackWorkerCell;
        private System.Windows.Forms.Label lblClientWorkerEmail;
        private System.Windows.Forms.TextBox txtTrackWorkerEmail;
        private System.Windows.Forms.Label lblTrackWorkerIsCapableCaptain;
        private System.Windows.Forms.GroupBox gbIsCapableCaptain;
        private System.Windows.Forms.RadioButton rdoIsCapableCaptain_False;
        private System.Windows.Forms.RadioButton rdoIsCapableCaptain_True;
        private System.Windows.Forms.GroupBox gbIsDeleted;
        private System.Windows.Forms.RadioButton rdoIsDeleted_Disabled;
        private System.Windows.Forms.RadioButton rdoIsDeleted_Enabled;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnEscape;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ErrorProvider errorProviderApp;
        private System.Windows.Forms.TextBox txtTrackWorkerId;
        private System.Windows.Forms.ToolTip toolTipApp;
    }
}