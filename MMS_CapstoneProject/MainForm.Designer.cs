
namespace MMS_CapstoneProject
{
    partial class MainForm
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
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tpClient = new System.Windows.Forms.TabPage();
            this.gbClientTexBox = new System.Windows.Forms.GroupBox();
            this.rbClientIsDeleted = new System.Windows.Forms.RadioButton();
            this.txtPrimaryContactCell = new System.Windows.Forms.MaskedTextBox();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.lblClientId = new System.Windows.Forms.Label();
            this.txtPrimaryContactEmail = new System.Windows.Forms.TextBox();
            this.txtPrimaryContactName = new System.Windows.Forms.TextBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.lblPrimaryContactEmail = new System.Windows.Forms.Label();
            this.lblPrimaryContactCell = new System.Windows.Forms.Label();
            this.lblPrimaryContactName = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
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
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rbClientIsDeleted_1 = new System.Windows.Forms.RadioButton();
            this.TabControl1.SuspendLayout();
            this.tpClient.SuspendLayout();
            this.gbClientTexBox.SuspendLayout();
            this.gbMenu.SuspendLayout();
            this.gbCreate.SuspendLayout();
            this.gbEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl1.Controls.Add(this.tpClient);
            this.TabControl1.Controls.Add(this.tabPage2);
            this.TabControl1.Location = new System.Drawing.Point(1, 0);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(743, 430);
            this.TabControl1.TabIndex = 0;
            // 
            // tpClient
            // 
            this.tpClient.Controls.Add(this.gbClientTexBox);
            this.tpClient.Controls.Add(this.gbMenu);
            this.tpClient.Controls.Add(this.gbCreate);
            this.tpClient.Controls.Add(this.gbEdit);
            this.tpClient.Controls.Add(this.dataGridViewClient);
            this.tpClient.Controls.Add(this.btnExit);
            this.tpClient.Location = new System.Drawing.Point(4, 22);
            this.tpClient.Name = "tpClient";
            this.tpClient.Padding = new System.Windows.Forms.Padding(3);
            this.tpClient.Size = new System.Drawing.Size(735, 404);
            this.tpClient.TabIndex = 0;
            this.tpClient.Text = "Client";
            this.tpClient.UseVisualStyleBackColor = true;
            // 
            // gbClientTexBox
            // 
            this.gbClientTexBox.Controls.Add(this.rbClientIsDeleted_1);
            this.gbClientTexBox.Controls.Add(this.rbClientIsDeleted);
            this.gbClientTexBox.Controls.Add(this.txtPrimaryContactCell);
            this.gbClientTexBox.Controls.Add(this.lblErrorMessage);
            this.gbClientTexBox.Controls.Add(this.txtClientId);
            this.gbClientTexBox.Controls.Add(this.lblClientId);
            this.gbClientTexBox.Controls.Add(this.txtPrimaryContactEmail);
            this.gbClientTexBox.Controls.Add(this.txtPrimaryContactName);
            this.gbClientTexBox.Controls.Add(this.txtClientName);
            this.gbClientTexBox.Controls.Add(this.lblPrimaryContactEmail);
            this.gbClientTexBox.Controls.Add(this.lblPrimaryContactCell);
            this.gbClientTexBox.Controls.Add(this.lblPrimaryContactName);
            this.gbClientTexBox.Controls.Add(this.lblClientName);
            this.gbClientTexBox.Enabled = false;
            this.gbClientTexBox.Location = new System.Drawing.Point(25, 6);
            this.gbClientTexBox.Name = "gbClientTexBox";
            this.gbClientTexBox.Size = new System.Drawing.Size(318, 259);
            this.gbClientTexBox.TabIndex = 17;
            this.gbClientTexBox.TabStop = false;
            // 
            // rbClientIsDeleted
            // 
            this.rbClientIsDeleted.AutoSize = true;
            this.rbClientIsDeleted.Checked = true;
            this.rbClientIsDeleted.Location = new System.Drawing.Point(45, 161);
            this.rbClientIsDeleted.Name = "rbClientIsDeleted";
            this.rbClientIsDeleted.Size = new System.Drawing.Size(64, 17);
            this.rbClientIsDeleted.TabIndex = 21;
            this.rbClientIsDeleted.TabStop = true;
            this.rbClientIsDeleted.Text = "Enabled";
            this.rbClientIsDeleted.UseVisualStyleBackColor = true;
            this.rbClientIsDeleted.CheckedChanged += new System.EventHandler(this.rbClientIsDeleted_CheckedChanged);
            // 
            // txtPrimaryContactCell
            // 
            this.txtPrimaryContactCell.Location = new System.Drawing.Point(187, 97);
            this.txtPrimaryContactCell.Mask = "(999) 000-0000";
            this.txtPrimaryContactCell.Name = "txtPrimaryContactCell";
            this.txtPrimaryContactCell.Size = new System.Drawing.Size(125, 20);
            this.txtPrimaryContactCell.TabIndex = 17;
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.Location = new System.Drawing.Point(0, 200);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(318, 62);
            this.lblErrorMessage.TabIndex = 20;
            this.lblErrorMessage.Text = "Error Message:";
            this.lblErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblErrorMessage.Visible = false;
            // 
            // txtClientId
            // 
            this.txtClientId.Enabled = false;
            this.txtClientId.Location = new System.Drawing.Point(187, 15);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(125, 20);
            this.txtClientId.TabIndex = 11;
            // 
            // lblClientId
            // 
            this.lblClientId.AutoSize = true;
            this.lblClientId.Location = new System.Drawing.Point(125, 18);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(21, 13);
            this.lblClientId.TabIndex = 10;
            this.lblClientId.Text = "ID:";
            // 
            // txtPrimaryContactEmail
            // 
            this.txtPrimaryContactEmail.Location = new System.Drawing.Point(187, 130);
            this.txtPrimaryContactEmail.Name = "txtPrimaryContactEmail";
            this.txtPrimaryContactEmail.Size = new System.Drawing.Size(125, 20);
            this.txtPrimaryContactEmail.TabIndex = 19;
            // 
            // txtPrimaryContactName
            // 
            this.txtPrimaryContactName.Location = new System.Drawing.Point(187, 71);
            this.txtPrimaryContactName.Name = "txtPrimaryContactName";
            this.txtPrimaryContactName.Size = new System.Drawing.Size(125, 20);
            this.txtPrimaryContactName.TabIndex = 15;
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(187, 42);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(125, 20);
            this.txtClientName.TabIndex = 13;
            // 
            // lblPrimaryContactEmail
            // 
            this.lblPrimaryContactEmail.AutoSize = true;
            this.lblPrimaryContactEmail.Location = new System.Drawing.Point(34, 130);
            this.lblPrimaryContactEmail.Name = "lblPrimaryContactEmail";
            this.lblPrimaryContactEmail.Size = new System.Drawing.Size(112, 13);
            this.lblPrimaryContactEmail.TabIndex = 18;
            this.lblPrimaryContactEmail.Text = "Primary Contact Email:";
            // 
            // lblPrimaryContactCell
            // 
            this.lblPrimaryContactCell.AutoSize = true;
            this.lblPrimaryContactCell.Location = new System.Drawing.Point(42, 101);
            this.lblPrimaryContactCell.Name = "lblPrimaryContactCell";
            this.lblPrimaryContactCell.Size = new System.Drawing.Size(104, 13);
            this.lblPrimaryContactCell.TabIndex = 16;
            this.lblPrimaryContactCell.Text = "Primary Contact Cell:";
            // 
            // lblPrimaryContactName
            // 
            this.lblPrimaryContactName.AutoSize = true;
            this.lblPrimaryContactName.Location = new System.Drawing.Point(31, 71);
            this.lblPrimaryContactName.Name = "lblPrimaryContactName";
            this.lblPrimaryContactName.Size = new System.Drawing.Size(115, 13);
            this.lblPrimaryContactName.TabIndex = 14;
            this.lblPrimaryContactName.Text = "Primary Contact Name:";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(79, 42);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(67, 13);
            this.lblClientName.TabIndex = 12;
            this.lblClientName.Text = "Client Name:";
            // 
            // gbMenu
            // 
            this.gbMenu.Controls.Add(this.btnEditMode);
            this.gbMenu.Controls.Add(this.btnCreateNewMode);
            this.gbMenu.Location = new System.Drawing.Point(25, 315);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(318, 34);
            this.gbMenu.TabIndex = 10;
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
            this.btnEditMode.Click += new System.EventHandler(this.btnEditMode_Click);
            // 
            // btnCreateNewMode
            // 
            this.btnCreateNewMode.Location = new System.Drawing.Point(0, 8);
            this.btnCreateNewMode.Name = "btnCreateNewMode";
            this.btnCreateNewMode.Size = new System.Drawing.Size(156, 23);
            this.btnCreateNewMode.TabIndex = 0;
            this.btnCreateNewMode.Text = "Create &New Mode";
            this.btnCreateNewMode.UseVisualStyleBackColor = true;
            this.btnCreateNewMode.Click += new System.EventHandler(this.btnCreateNewMode_Click);
            // 
            // gbCreate
            // 
            this.gbCreate.Controls.Add(this.btnBackMenu_1);
            this.gbCreate.Controls.Add(this.btnAddNew);
            this.gbCreate.Controls.Add(this.btnClear);
            this.gbCreate.Location = new System.Drawing.Point(25, 287);
            this.gbCreate.Name = "gbCreate";
            this.gbCreate.Size = new System.Drawing.Size(318, 62);
            this.gbCreate.TabIndex = 11;
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
            this.btnBackMenu_1.Click += new System.EventHandler(this.btnBackMenu_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(0, 9);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(156, 23);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "&Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(162, 9);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(156, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.gbEdit.Location = new System.Drawing.Point(25, 261);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Size = new System.Drawing.Size(318, 88);
            this.gbEdit.TabIndex = 12;
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
            this.btnBackMenu.Click += new System.EventHandler(this.btnBackMenu_Click);
            // 
            // btnClear_1
            // 
            this.btnClear_1.Location = new System.Drawing.Point(217, 36);
            this.btnClear_1.Name = "btnClear_1";
            this.btnClear_1.Size = new System.Drawing.Size(101, 23);
            this.btnClear_1.TabIndex = 6;
            this.btnClear_1.Text = "&Clear";
            this.btnClear_1.UseVisualStyleBackColor = true;
            this.btnClear_1.Click += new System.EventHandler(this.btnClear_Click);
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
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(243, 10);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 3;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(162, 10);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(81, 10);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(0, 10);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.AllowUserToAddRows = false;
            this.dataGridViewClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Enabled = false;
            this.dataGridViewClient.Location = new System.Drawing.Point(353, 6);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.ReadOnly = true;
            this.dataGridViewClient.Size = new System.Drawing.Size(374, 393);
            this.dataGridViewClient.TabIndex = 15;
            this.dataGridViewClient.CurrentCellChanged += new System.EventHandler(this.dataGridViewClient_CurrentCellChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(25, 355);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(318, 23);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(735, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rbClientIsDeleted_1
            // 
            this.rbClientIsDeleted_1.AutoSize = true;
            this.rbClientIsDeleted_1.Location = new System.Drawing.Point(187, 161);
            this.rbClientIsDeleted_1.Name = "rbClientIsDeleted_1";
            this.rbClientIsDeleted_1.Size = new System.Drawing.Size(66, 17);
            this.rbClientIsDeleted_1.TabIndex = 22;
            this.rbClientIsDeleted_1.TabStop = true;
            this.rbClientIsDeleted_1.Text = "Disabled";
            this.rbClientIsDeleted_1.UseVisualStyleBackColor = true;
            this.rbClientIsDeleted_1.CheckedChanged += new System.EventHandler(this.rbClientIsDeleted_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 431);
            this.Controls.Add(this.TabControl1);
            this.Name = "MainForm";
            this.Text = "Motorsport Marshalling Services Track Day Management Suite";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TabControl1.ResumeLayout(false);
            this.tpClient.ResumeLayout(false);
            this.gbClientTexBox.ResumeLayout(false);
            this.gbClientTexBox.PerformLayout();
            this.gbMenu.ResumeLayout(false);
            this.gbCreate.ResumeLayout(false);
            this.gbEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage tpClient;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnCreateNewMode;
        private System.Windows.Forms.Button btnEditMode;
        private System.Windows.Forms.Button btnClear_1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbCreate;
        private System.Windows.Forms.Button btnBackMenu_1;
        private System.Windows.Forms.Button btnBackMenu;
        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.GroupBox gbClientTexBox;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.Label lblClientId;
        private System.Windows.Forms.TextBox txtPrimaryContactEmail;
        private System.Windows.Forms.TextBox txtPrimaryContactName;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label lblPrimaryContactEmail;
        private System.Windows.Forms.Label lblPrimaryContactCell;
        private System.Windows.Forms.Label lblPrimaryContactName;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.MaskedTextBox txtPrimaryContactCell;
        private System.Windows.Forms.RadioButton rbClientIsDeleted;
        private System.Windows.Forms.RadioButton rbClientIsDeleted_1;
    }
}

