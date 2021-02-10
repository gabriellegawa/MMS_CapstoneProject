
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
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.btnEditMode = new System.Windows.Forms.Button();
            this.btnCreateNewMode = new System.Windows.Forms.Button();
            this.gbCreate = new System.Windows.Forms.GroupBox();
            this.btnBackMenu_1 = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.btnBackMenu = new System.Windows.Forms.Button();
            this.btnClear_1 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.dataGridViewTrack = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.rbTrackIsDeleted = new System.Windows.Forms.RadioButton();
            this.rbTrackIsDeleted_1 = new System.Windows.Forms.RadioButton();
            this.gbMenu.SuspendLayout();
            this.gbCreate.SuspendLayout();
            this.gbEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrack)).BeginInit();
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
            // gbMenu
            // 
            this.gbMenu.Controls.Add(this.btnEditMode);
            this.gbMenu.Controls.Add(this.btnCreateNewMode);
            this.gbMenu.Location = new System.Drawing.Point(49, 298);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(318, 34);
            this.gbMenu.TabIndex = 16;
            this.gbMenu.TabStop = false;
            // 
            // btnEditMode
            // 
            this.btnEditMode.Location = new System.Drawing.Point(162, 8);
            this.btnEditMode.Name = "btnEditMode";
            this.btnEditMode.Size = new System.Drawing.Size(156, 23);
            this.btnEditMode.TabIndex = 1;
            this.btnEditMode.Text = "&Edit Mode";
            this.btnEditMode.UseVisualStyleBackColor = true;
            // 
            // btnCreateNewMode
            // 
            this.btnCreateNewMode.Location = new System.Drawing.Point(0, 8);
            this.btnCreateNewMode.Name = "btnCreateNewMode";
            this.btnCreateNewMode.Size = new System.Drawing.Size(156, 23);
            this.btnCreateNewMode.TabIndex = 0;
            this.btnCreateNewMode.Text = "Create &New Mode";
            this.btnCreateNewMode.UseVisualStyleBackColor = true;
            // 
            // gbCreate
            // 
            this.gbCreate.Controls.Add(this.btnBackMenu_1);
            this.gbCreate.Controls.Add(this.btnAddNew);
            this.gbCreate.Controls.Add(this.btnClear);
            this.gbCreate.Location = new System.Drawing.Point(49, 270);
            this.gbCreate.Name = "gbCreate";
            this.gbCreate.Size = new System.Drawing.Size(318, 62);
            this.gbCreate.TabIndex = 17;
            this.gbCreate.TabStop = false;
            this.gbCreate.Visible = false;
            // 
            // btnBackMenu_1
            // 
            this.btnBackMenu_1.Location = new System.Drawing.Point(0, 38);
            this.btnBackMenu_1.Name = "btnBackMenu_1";
            this.btnBackMenu_1.Size = new System.Drawing.Size(318, 23);
            this.btnBackMenu_1.TabIndex = 2;
            this.btnBackMenu_1.Text = "&Back to Menu";
            this.btnBackMenu_1.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(0, 9);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(156, 23);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "&Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(162, 9);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(156, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // gbEdit
            // 
            this.gbEdit.Controls.Add(this.btnBackMenu);
            this.gbEdit.Controls.Add(this.btnClear_1);
            this.gbEdit.Controls.Add(this.btnUpdate);
            this.gbEdit.Controls.Add(this.btnDelete);
            this.gbEdit.Controls.Add(this.btnLast);
            this.gbEdit.Controls.Add(this.btnNext);
            this.gbEdit.Controls.Add(this.btnPrevious);
            this.gbEdit.Controls.Add(this.btnFirst);
            this.gbEdit.Location = new System.Drawing.Point(49, 244);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Size = new System.Drawing.Size(318, 88);
            this.gbEdit.TabIndex = 18;
            this.gbEdit.TabStop = false;
            this.gbEdit.Visible = false;
            // 
            // btnBackMenu
            // 
            this.btnBackMenu.Location = new System.Drawing.Point(0, 65);
            this.btnBackMenu.Name = "btnBackMenu";
            this.btnBackMenu.Size = new System.Drawing.Size(318, 23);
            this.btnBackMenu.TabIndex = 7;
            this.btnBackMenu.Text = "&Back to Menu";
            this.btnBackMenu.UseVisualStyleBackColor = true;
            // 
            // btnClear_1
            // 
            this.btnClear_1.Location = new System.Drawing.Point(217, 36);
            this.btnClear_1.Name = "btnClear_1";
            this.btnClear_1.Size = new System.Drawing.Size(101, 23);
            this.btnClear_1.TabIndex = 6;
            this.btnClear_1.Text = "&Clear";
            this.btnClear_1.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(0, 36);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(101, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(107, 36);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(243, 10);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 3;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(162, 10);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(81, 10);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(0, 10);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTrack
            // 
            this.dataGridViewTrack.AllowUserToAddRows = false;
            this.dataGridViewTrack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTrack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrack.Enabled = false;
            this.dataGridViewTrack.Location = new System.Drawing.Point(377, 29);
            this.dataGridViewTrack.Name = "dataGridViewTrack";
            this.dataGridViewTrack.ReadOnly = true;
            this.dataGridViewTrack.Size = new System.Drawing.Size(374, 393);
            this.dataGridViewTrack.TabIndex = 20;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(49, 338);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(318, 23);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
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
            // TracksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbTrackIsDeleted_1);
            this.Controls.Add(this.rbTrackIsDeleted);
            this.Controls.Add(this.gbMenu);
            this.Controls.Add(this.gbCreate);
            this.Controls.Add(this.gbEdit);
            this.Controls.Add(this.dataGridViewTrack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cbTrackConfiguration);
            this.Controls.Add(this.lblTrackConfiguration);
            this.Controls.Add(this.txtTrackName);
            this.Controls.Add(this.lblTrackName);
            this.Name = "TracksForm";
            this.Text = "TracksForm";
            this.Load += new System.EventHandler(this.TracksForm_Load);
            this.gbMenu.ResumeLayout(false);
            this.gbCreate.ResumeLayout(false);
            this.gbEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrackName;
        private System.Windows.Forms.TextBox txtTrackName;
        private System.Windows.Forms.Label lblTrackConfiguration;
        private System.Windows.Forms.ComboBox cbTrackConfiguration;
        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.Button btnEditMode;
        private System.Windows.Forms.Button btnCreateNewMode;
        private System.Windows.Forms.GroupBox gbCreate;
        private System.Windows.Forms.Button btnBackMenu_1;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.Button btnBackMenu;
        private System.Windows.Forms.Button btnClear_1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.DataGridView dataGridViewTrack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rbTrackIsDeleted;
        private System.Windows.Forms.RadioButton rbTrackIsDeleted_1;
    }
}