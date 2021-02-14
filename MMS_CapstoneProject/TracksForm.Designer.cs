
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
            this.rbTrackIsDeleted = new System.Windows.Forms.RadioButton();
            this.rbTrackIsDeleted_1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTrackName
            // 
            this.lblTrackName.AutoSize = true;
            this.lblTrackName.Location = new System.Drawing.Point(26, 29);
            this.lblTrackName.Name = "lblTrackName";
            this.lblTrackName.Size = new System.Drawing.Size(69, 13);
            this.lblTrackName.TabIndex = 0;
            this.lblTrackName.Text = "Track Name:";
            // 
            // txtTrackName
            // 
            this.txtTrackName.Location = new System.Drawing.Point(174, 26);
            this.txtTrackName.Name = "txtTrackName";
            this.txtTrackName.Size = new System.Drawing.Size(100, 20);
            this.txtTrackName.TabIndex = 1;
            // 
            // lblTrackConfiguration
            // 
            this.lblTrackConfiguration.AutoSize = true;
            this.lblTrackConfiguration.Location = new System.Drawing.Point(29, 57);
            this.lblTrackConfiguration.Name = "lblTrackConfiguration";
            this.lblTrackConfiguration.Size = new System.Drawing.Size(100, 13);
            this.lblTrackConfiguration.TabIndex = 2;
            this.lblTrackConfiguration.Text = "Track Configuration";
            // 
            // cbTrackConfiguration
            // 
            this.cbTrackConfiguration.FormattingEnabled = true;
            this.cbTrackConfiguration.Location = new System.Drawing.Point(174, 49);
            this.cbTrackConfiguration.Name = "cbTrackConfiguration";
            this.cbTrackConfiguration.Size = new System.Drawing.Size(121, 21);
            this.cbTrackConfiguration.TabIndex = 3;
            // 
            // rbTrackIsDeleted
            // 
            this.rbTrackIsDeleted.AutoSize = true;
            this.rbTrackIsDeleted.Location = new System.Drawing.Point(174, 77);
            this.rbTrackIsDeleted.Name = "rbTrackIsDeleted";
            this.rbTrackIsDeleted.Size = new System.Drawing.Size(64, 17);
            this.rbTrackIsDeleted.TabIndex = 21;
            this.rbTrackIsDeleted.TabStop = true;
            this.rbTrackIsDeleted.Text = "Enabled";
            this.rbTrackIsDeleted.UseVisualStyleBackColor = true;
            // 
            // rbTrackIsDeleted_1
            // 
            this.rbTrackIsDeleted_1.AutoSize = true;
            this.rbTrackIsDeleted_1.Location = new System.Drawing.Point(174, 101);
            this.rbTrackIsDeleted_1.Name = "rbTrackIsDeleted_1";
            this.rbTrackIsDeleted_1.Size = new System.Drawing.Size(66, 17);
            this.rbTrackIsDeleted_1.TabIndex = 22;
            this.rbTrackIsDeleted_1.TabStop = true;
            this.rbTrackIsDeleted_1.Text = "Disabled";
            this.rbTrackIsDeleted_1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(143, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TracksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbTrackIsDeleted_1);
            this.Controls.Add(this.rbTrackIsDeleted);
            this.Controls.Add(this.cbTrackConfiguration);
            this.Controls.Add(this.lblTrackConfiguration);
            this.Controls.Add(this.txtTrackName);
            this.Controls.Add(this.lblTrackName);
            this.Name = "TracksForm";
            this.Text = "TracksForm";
            this.Load += new System.EventHandler(this.TracksForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrackName;
        private System.Windows.Forms.TextBox txtTrackName;
        private System.Windows.Forms.Label lblTrackConfiguration;
        private System.Windows.Forms.ComboBox cbTrackConfiguration;
        private System.Windows.Forms.RadioButton rbTrackIsDeleted;
        private System.Windows.Forms.RadioButton rbTrackIsDeleted_1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}