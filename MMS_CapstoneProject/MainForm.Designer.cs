
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabClient = new System.Windows.Forms.TabPage();
            this.btnClientSearch = new System.Windows.Forms.Button();
            this.txtClientSearch = new System.Windows.Forms.TextBox();
            this.btnClientAddNew = new System.Windows.Forms.Button();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.tabTrackWorker = new System.Windows.Forms.TabPage();
            this.btnTrackWorkerSearch = new System.Windows.Forms.Button();
            this.txtTrackWorkerSearch = new System.Windows.Forms.TextBox();
            this.btnTrackWorkerAddNew = new System.Windows.Forms.Button();
            this.dgvTrackWorker = new System.Windows.Forms.DataGridView();
            this.tabTrack = new System.Windows.Forms.TabPage();
            this.btnTrackSearch = new System.Windows.Forms.Button();
            this.txtTrackSearch = new System.Windows.Forms.TextBox();
            this.btnTrackAddNew = new System.Windows.Forms.Button();
            this.dgvTrack = new System.Windows.Forms.DataGridView();
            this.tabClientEvent = new System.Windows.Forms.TabPage();
            this.btnClientEventSearch = new System.Windows.Forms.Button();
            this.txtClientEventSearch = new System.Windows.Forms.TextBox();
            this.btnClientEventAddNew = new System.Windows.Forms.Button();
            this.dgvClientEvent = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.tabTrackWorker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrackWorker)).BeginInit();
            this.tabTrack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrack)).BeginInit();
            this.tabClientEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabClient);
            this.tabControl1.Controls.Add(this.tabTrackWorker);
            this.tabControl1.Controls.Add(this.tabTrack);
            this.tabControl1.Controls.Add(this.tabClientEvent);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabClient
            // 
            this.tabClient.Controls.Add(this.btnClientSearch);
            this.tabClient.Controls.Add(this.txtClientSearch);
            this.tabClient.Controls.Add(this.btnClientAddNew);
            this.tabClient.Controls.Add(this.dgvClient);
            this.tabClient.Location = new System.Drawing.Point(4, 22);
            this.tabClient.Name = "tabClient";
            this.tabClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabClient.Size = new System.Drawing.Size(768, 400);
            this.tabClient.TabIndex = 0;
            this.tabClient.Text = "Client";
            this.tabClient.UseVisualStyleBackColor = true;
            // 
            // btnClientSearch
            // 
            this.btnClientSearch.Location = new System.Drawing.Point(416, 12);
            this.btnClientSearch.Name = "btnClientSearch";
            this.btnClientSearch.Size = new System.Drawing.Size(100, 45);
            this.btnClientSearch.TabIndex = 3;
            this.btnClientSearch.Text = "Search";
            this.btnClientSearch.UseVisualStyleBackColor = true;
            // 
            // txtClientSearch
            // 
            this.txtClientSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientSearch.Location = new System.Drawing.Point(270, 16);
            this.txtClientSearch.Name = "txtClientSearch";
            this.txtClientSearch.Size = new System.Drawing.Size(140, 29);
            this.txtClientSearch.TabIndex = 2;
            this.txtClientSearch.TextChanged += new System.EventHandler(this.txtClientSearch_TextChanged);
            // 
            // btnClientAddNew
            // 
            this.btnClientAddNew.Location = new System.Drawing.Point(6, 12);
            this.btnClientAddNew.Name = "btnClientAddNew";
            this.btnClientAddNew.Size = new System.Drawing.Size(100, 45);
            this.btnClientAddNew.TabIndex = 1;
            this.btnClientAddNew.Text = "Add New";
            this.btnClientAddNew.UseVisualStyleBackColor = true;
            this.btnClientAddNew.Click += new System.EventHandler(this.btnClientAddNew_Click);
            // 
            // dgvClient
            // 
            this.dgvClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Location = new System.Drawing.Point(0, 63);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.Size = new System.Drawing.Size(768, 331);
            this.dgvClient.TabIndex = 0;
            this.dgvClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClient_CellClick);
            // 
            // tabTrackWorker
            // 
            this.tabTrackWorker.Controls.Add(this.btnTrackWorkerSearch);
            this.tabTrackWorker.Controls.Add(this.txtTrackWorkerSearch);
            this.tabTrackWorker.Controls.Add(this.btnTrackWorkerAddNew);
            this.tabTrackWorker.Controls.Add(this.dgvTrackWorker);
            this.tabTrackWorker.Location = new System.Drawing.Point(4, 22);
            this.tabTrackWorker.Name = "tabTrackWorker";
            this.tabTrackWorker.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrackWorker.Size = new System.Drawing.Size(768, 400);
            this.tabTrackWorker.TabIndex = 1;
            this.tabTrackWorker.Text = "Track Worker";
            this.tabTrackWorker.UseVisualStyleBackColor = true;
            // 
            // btnTrackWorkerSearch
            // 
            this.btnTrackWorkerSearch.Location = new System.Drawing.Point(419, 9);
            this.btnTrackWorkerSearch.Name = "btnTrackWorkerSearch";
            this.btnTrackWorkerSearch.Size = new System.Drawing.Size(100, 45);
            this.btnTrackWorkerSearch.TabIndex = 7;
            this.btnTrackWorkerSearch.Text = "Search";
            this.btnTrackWorkerSearch.UseVisualStyleBackColor = true;
            // 
            // txtTrackWorkerSearch
            // 
            this.txtTrackWorkerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrackWorkerSearch.Location = new System.Drawing.Point(273, 13);
            this.txtTrackWorkerSearch.Name = "txtTrackWorkerSearch";
            this.txtTrackWorkerSearch.Size = new System.Drawing.Size(140, 29);
            this.txtTrackWorkerSearch.TabIndex = 6;
            this.txtTrackWorkerSearch.TextChanged += new System.EventHandler(this.txtTrackWorkerSearch_TextChanged);
            // 
            // btnTrackWorkerAddNew
            // 
            this.btnTrackWorkerAddNew.Location = new System.Drawing.Point(9, 9);
            this.btnTrackWorkerAddNew.Name = "btnTrackWorkerAddNew";
            this.btnTrackWorkerAddNew.Size = new System.Drawing.Size(100, 45);
            this.btnTrackWorkerAddNew.TabIndex = 5;
            this.btnTrackWorkerAddNew.Text = "Add New";
            this.btnTrackWorkerAddNew.UseVisualStyleBackColor = true;
            this.btnTrackWorkerAddNew.Click += new System.EventHandler(this.btnTrackWorkerAddNew_Click);
            // 
            // dgvTrackWorker
            // 
            this.dgvTrackWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTrackWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrackWorker.Location = new System.Drawing.Point(3, 60);
            this.dgvTrackWorker.Name = "dgvTrackWorker";
            this.dgvTrackWorker.Size = new System.Drawing.Size(762, 331);
            this.dgvTrackWorker.TabIndex = 4;
            this.dgvTrackWorker.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrackWorker_CellClick);
            // 
            // tabTrack
            // 
            this.tabTrack.Controls.Add(this.btnTrackSearch);
            this.tabTrack.Controls.Add(this.txtTrackSearch);
            this.tabTrack.Controls.Add(this.btnTrackAddNew);
            this.tabTrack.Controls.Add(this.dgvTrack);
            this.tabTrack.Location = new System.Drawing.Point(4, 22);
            this.tabTrack.Name = "tabTrack";
            this.tabTrack.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrack.Size = new System.Drawing.Size(768, 400);
            this.tabTrack.TabIndex = 2;
            this.tabTrack.Text = "Track";
            this.tabTrack.UseVisualStyleBackColor = true;
            // 
            // btnTrackSearch
            // 
            this.btnTrackSearch.Location = new System.Drawing.Point(419, 9);
            this.btnTrackSearch.Name = "btnTrackSearch";
            this.btnTrackSearch.Size = new System.Drawing.Size(100, 45);
            this.btnTrackSearch.TabIndex = 7;
            this.btnTrackSearch.Text = "Search";
            this.btnTrackSearch.UseVisualStyleBackColor = true;
            // 
            // txtTrackSearch
            // 
            this.txtTrackSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrackSearch.Location = new System.Drawing.Point(273, 13);
            this.txtTrackSearch.Name = "txtTrackSearch";
            this.txtTrackSearch.Size = new System.Drawing.Size(140, 29);
            this.txtTrackSearch.TabIndex = 6;
            // 
            // btnTrackAddNew
            // 
            this.btnTrackAddNew.Location = new System.Drawing.Point(9, 9);
            this.btnTrackAddNew.Name = "btnTrackAddNew";
            this.btnTrackAddNew.Size = new System.Drawing.Size(100, 45);
            this.btnTrackAddNew.TabIndex = 5;
            this.btnTrackAddNew.Text = "Add New";
            this.btnTrackAddNew.UseVisualStyleBackColor = true;
            this.btnTrackAddNew.Click += new System.EventHandler(this.btnTrackAddNew_Click);
            // 
            // dgvTrack
            // 
            this.dgvTrack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTrack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrack.Location = new System.Drawing.Point(3, 60);
            this.dgvTrack.Name = "dgvTrack";
            this.dgvTrack.Size = new System.Drawing.Size(762, 331);
            this.dgvTrack.TabIndex = 4;
            // 
            // tabClientEvent
            // 
            this.tabClientEvent.Controls.Add(this.btnClientEventSearch);
            this.tabClientEvent.Controls.Add(this.txtClientEventSearch);
            this.tabClientEvent.Controls.Add(this.btnClientEventAddNew);
            this.tabClientEvent.Controls.Add(this.dgvClientEvent);
            this.tabClientEvent.Location = new System.Drawing.Point(4, 22);
            this.tabClientEvent.Name = "tabClientEvent";
            this.tabClientEvent.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientEvent.Size = new System.Drawing.Size(768, 400);
            this.tabClientEvent.TabIndex = 3;
            this.tabClientEvent.Text = "Client Event";
            this.tabClientEvent.UseVisualStyleBackColor = true;
            // 
            // btnClientEventSearch
            // 
            this.btnClientEventSearch.Location = new System.Drawing.Point(419, 9);
            this.btnClientEventSearch.Name = "btnClientEventSearch";
            this.btnClientEventSearch.Size = new System.Drawing.Size(100, 45);
            this.btnClientEventSearch.TabIndex = 7;
            this.btnClientEventSearch.Text = "Search";
            this.btnClientEventSearch.UseVisualStyleBackColor = true;
            // 
            // txtClientEventSearch
            // 
            this.txtClientEventSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientEventSearch.Location = new System.Drawing.Point(273, 13);
            this.txtClientEventSearch.Name = "txtClientEventSearch";
            this.txtClientEventSearch.Size = new System.Drawing.Size(140, 29);
            this.txtClientEventSearch.TabIndex = 6;
            // 
            // btnClientEventAddNew
            // 
            this.btnClientEventAddNew.Location = new System.Drawing.Point(9, 9);
            this.btnClientEventAddNew.Name = "btnClientEventAddNew";
            this.btnClientEventAddNew.Size = new System.Drawing.Size(100, 45);
            this.btnClientEventAddNew.TabIndex = 5;
            this.btnClientEventAddNew.Text = "Add New";
            this.btnClientEventAddNew.UseVisualStyleBackColor = true;
            this.btnClientEventAddNew.Click += new System.EventHandler(this.btnClientEventAddNew_Click);
            // 
            // dgvClientEvent
            // 
            this.dgvClientEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientEvent.Location = new System.Drawing.Point(3, 60);
            this.dgvClientEvent.Name = "dgvClientEvent";
            this.dgvClientEvent.Size = new System.Drawing.Size(762, 331);
            this.dgvClientEvent.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabClient.ResumeLayout(false);
            this.tabClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.tabTrackWorker.ResumeLayout(false);
            this.tabTrackWorker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrackWorker)).EndInit();
            this.tabTrack.ResumeLayout(false);
            this.tabTrack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrack)).EndInit();
            this.tabClientEvent.ResumeLayout(false);
            this.tabClientEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientEvent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabClient;
        private System.Windows.Forms.TabPage tabTrackWorker;
        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.Button btnClientSearch;
        private System.Windows.Forms.TextBox txtClientSearch;
        private System.Windows.Forms.Button btnClientAddNew;
        private System.Windows.Forms.Button btnTrackWorkerSearch;
        private System.Windows.Forms.TextBox txtTrackWorkerSearch;
        private System.Windows.Forms.Button btnTrackWorkerAddNew;
        private System.Windows.Forms.DataGridView dgvTrackWorker;
        private System.Windows.Forms.TabPage tabTrack;
        private System.Windows.Forms.Button btnTrackSearch;
        private System.Windows.Forms.TextBox txtTrackSearch;
        private System.Windows.Forms.Button btnTrackAddNew;
        private System.Windows.Forms.DataGridView dgvTrack;
        private System.Windows.Forms.TabPage tabClientEvent;
        private System.Windows.Forms.Button btnClientEventSearch;
        private System.Windows.Forms.TextBox txtClientEventSearch;
        private System.Windows.Forms.Button btnClientEventAddNew;
        private System.Windows.Forms.DataGridView dgvClientEvent;
    }
}