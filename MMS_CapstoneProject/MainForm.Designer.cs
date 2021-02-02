
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblPrimaryContactEmail = new System.Windows.Forms.Label();
            this.lblPrimaryContactCell = new System.Windows.Forms.Label();
            this.lblPrimaryContactName = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtPrimaryContactName = new System.Windows.Forms.TextBox();
            this.txtPrimaryContactCell = new System.Windows.Forms.TextBox();
            this.txtPrimaryContactEmail = new System.Windows.Forms.TextBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRefreshData = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TabControl1.SuspendLayout();
            this.tpClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.tpClient.Controls.Add(this.dataGridView1);
            this.tpClient.Controls.Add(this.btnExit);
            this.tpClient.Controls.Add(this.btnRefreshData);
            this.tpClient.Controls.Add(this.btnUpdate);
            this.tpClient.Controls.Add(this.btnAddNew);
            this.tpClient.Controls.Add(this.btnDelete);
            this.tpClient.Controls.Add(this.btnLast);
            this.tpClient.Controls.Add(this.btnNext);
            this.tpClient.Controls.Add(this.btnPrevious);
            this.tpClient.Controls.Add(this.btnFirst);
            this.tpClient.Controls.Add(this.txtPrimaryContactEmail);
            this.tpClient.Controls.Add(this.txtPrimaryContactCell);
            this.tpClient.Controls.Add(this.txtPrimaryContactName);
            this.tpClient.Controls.Add(this.txtClientName);
            this.tpClient.Controls.Add(this.lblPrimaryContactEmail);
            this.tpClient.Controls.Add(this.lblPrimaryContactCell);
            this.tpClient.Controls.Add(this.lblPrimaryContactName);
            this.tpClient.Controls.Add(this.lblClientName);
            this.tpClient.Location = new System.Drawing.Point(4, 22);
            this.tpClient.Name = "tpClient";
            this.tpClient.Padding = new System.Windows.Forms.Padding(3);
            this.tpClient.Size = new System.Drawing.Size(735, 404);
            this.tpClient.TabIndex = 0;
            this.tpClient.Text = "Client";
            this.tpClient.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(904, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblPrimaryContactEmail
            // 
            this.lblPrimaryContactEmail.AutoSize = true;
            this.lblPrimaryContactEmail.Location = new System.Drawing.Point(25, 128);
            this.lblPrimaryContactEmail.Name = "lblPrimaryContactEmail";
            this.lblPrimaryContactEmail.Size = new System.Drawing.Size(112, 13);
            this.lblPrimaryContactEmail.TabIndex = 6;
            this.lblPrimaryContactEmail.Text = "Primary Contact Email:";
            // 
            // lblPrimaryContactCell
            // 
            this.lblPrimaryContactCell.AutoSize = true;
            this.lblPrimaryContactCell.Location = new System.Drawing.Point(33, 99);
            this.lblPrimaryContactCell.Name = "lblPrimaryContactCell";
            this.lblPrimaryContactCell.Size = new System.Drawing.Size(104, 13);
            this.lblPrimaryContactCell.TabIndex = 4;
            this.lblPrimaryContactCell.Text = "Primary Contact Cell:";
            // 
            // lblPrimaryContactName
            // 
            this.lblPrimaryContactName.AutoSize = true;
            this.lblPrimaryContactName.Location = new System.Drawing.Point(22, 69);
            this.lblPrimaryContactName.Name = "lblPrimaryContactName";
            this.lblPrimaryContactName.Size = new System.Drawing.Size(115, 13);
            this.lblPrimaryContactName.TabIndex = 2;
            this.lblPrimaryContactName.Text = "Primary Contact Name:";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(70, 40);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(67, 13);
            this.lblClientName.TabIndex = 0;
            this.lblClientName.Text = "Client Name:";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(178, 40);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(100, 20);
            this.txtClientName.TabIndex = 1;
            // 
            // txtPrimaryContactName
            // 
            this.txtPrimaryContactName.Location = new System.Drawing.Point(178, 69);
            this.txtPrimaryContactName.Name = "txtPrimaryContactName";
            this.txtPrimaryContactName.Size = new System.Drawing.Size(100, 20);
            this.txtPrimaryContactName.TabIndex = 3;
            // 
            // txtPrimaryContactCell
            // 
            this.txtPrimaryContactCell.Location = new System.Drawing.Point(178, 99);
            this.txtPrimaryContactCell.Name = "txtPrimaryContactCell";
            this.txtPrimaryContactCell.Size = new System.Drawing.Size(100, 20);
            this.txtPrimaryContactCell.TabIndex = 5;
            // 
            // txtPrimaryContactEmail
            // 
            this.txtPrimaryContactEmail.Location = new System.Drawing.Point(178, 128);
            this.txtPrimaryContactEmail.Name = "txtPrimaryContactEmail";
            this.txtPrimaryContactEmail.Size = new System.Drawing.Size(100, 20);
            this.txtPrimaryContactEmail.TabIndex = 7;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(25, 190);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 8;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(106, 190);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 9;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(187, 190);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(268, 190);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 11;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(25, 219);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(106, 219);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 13;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(187, 219);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnRefreshData
            // 
            this.btnRefreshData.Location = new System.Drawing.Point(25, 248);
            this.btnRefreshData.Name = "btnRefreshData";
            this.btnRefreshData.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshData.TabIndex = 15;
            this.btnRefreshData.Text = "Refresh Data";
            this.btnRefreshData.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(106, 248);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(353, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(374, 393);
            this.dataGridView1.TabIndex = 17;
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
            this.tpClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage tpClient;
        private System.Windows.Forms.TextBox txtPrimaryContactEmail;
        private System.Windows.Forms.TextBox txtPrimaryContactCell;
        private System.Windows.Forms.TextBox txtPrimaryContactName;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label lblPrimaryContactEmail;
        private System.Windows.Forms.Label lblPrimaryContactCell;
        private System.Windows.Forms.Label lblPrimaryContactName;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRefreshData;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
    }
}

