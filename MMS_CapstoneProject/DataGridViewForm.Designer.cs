
namespace MMS_CapstoneProject
{
    partial class DataGridViewForm
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.txtDataGridViewSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvData.Location = new System.Drawing.Point(0, 56);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(434, 403);
            this.dgvData.TabIndex = 0;
            // 
            // txtDataGridViewSearch
            // 
            this.txtDataGridViewSearch.Location = new System.Drawing.Point(153, 18);
            this.txtDataGridViewSearch.Name = "txtDataGridViewSearch";
            this.txtDataGridViewSearch.Size = new System.Drawing.Size(100, 20);
            this.txtDataGridViewSearch.TabIndex = 1;
            this.txtDataGridViewSearch.TextChanged += new System.EventHandler(this.txtDataGridViewSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(278, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(13, 18);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // DataGridViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 459);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtDataGridViewSearch);
            this.Controls.Add(this.dgvData);
            this.Name = "DataGridViewForm";
            this.Text = "DataGridViewForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TextBox txtDataGridViewSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSelect;
    }
}