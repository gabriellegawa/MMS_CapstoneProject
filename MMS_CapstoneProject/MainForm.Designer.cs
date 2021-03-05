
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
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
            this.tabEmail = new System.Windows.Forms.TabPage();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnSelectEvent = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.txtEmailBody = new System.Windows.Forms.TextBox();
            this.lblEmailBody = new System.Windows.Forms.Label();
            this.txtEmailSubject = new System.Windows.Forms.TextBox();
            this.lblEmailSubject = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.tabTrackWorker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrackWorker)).BeginInit();
            this.tabTrack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrack)).BeginInit();
            this.tabClientEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientEvent)).BeginInit();
            this.tabEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabClient);
            this.tabControl.Controls.Add(this.tabTrackWorker);
            this.tabControl.Controls.Add(this.tabTrack);
            this.tabControl.Controls.Add(this.tabClientEvent);
            this.tabControl.Controls.Add(this.tabEmail);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(776, 426);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
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
            this.btnClientSearch.TabIndex = 2;
            this.btnClientSearch.Text = "Search";
            this.btnClientSearch.UseVisualStyleBackColor = true;
            // 
            // txtClientSearch
            // 
            this.txtClientSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientSearch.Location = new System.Drawing.Point(270, 16);
            this.txtClientSearch.Name = "txtClientSearch";
            this.txtClientSearch.Size = new System.Drawing.Size(140, 29);
            this.txtClientSearch.TabIndex = 1;
            this.txtClientSearch.TextChanged += new System.EventHandler(this.txtClientSearch_TextChanged);
            // 
            // btnClientAddNew
            // 
            this.btnClientAddNew.Location = new System.Drawing.Point(6, 12);
            this.btnClientAddNew.Name = "btnClientAddNew";
            this.btnClientAddNew.Size = new System.Drawing.Size(100, 45);
            this.btnClientAddNew.TabIndex = 0;
            this.btnClientAddNew.Text = "Add New";
            this.btnClientAddNew.UseVisualStyleBackColor = true;
            this.btnClientAddNew.Click += new System.EventHandler(this.btnClientAddNew_Click);
            // 
            // dgvClient
            // 
            this.dgvClient.AllowUserToAddRows = false;
            this.dgvClient.AllowUserToDeleteRows = false;
            this.dgvClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClient.Location = new System.Drawing.Point(0, 63);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.ReadOnly = true;
            this.dgvClient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvClient.Size = new System.Drawing.Size(768, 331);
            this.dgvClient.TabIndex = 3;
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
            this.btnTrackWorkerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrackWorkerSearch.Location = new System.Drawing.Point(419, 9);
            this.btnTrackWorkerSearch.Name = "btnTrackWorkerSearch";
            this.btnTrackWorkerSearch.Size = new System.Drawing.Size(100, 45);
            this.btnTrackWorkerSearch.TabIndex = 2;
            this.btnTrackWorkerSearch.Text = "Search";
            this.btnTrackWorkerSearch.UseVisualStyleBackColor = true;
            // 
            // txtTrackWorkerSearch
            // 
            this.txtTrackWorkerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrackWorkerSearch.Location = new System.Drawing.Point(273, 18);
            this.txtTrackWorkerSearch.Name = "txtTrackWorkerSearch";
            this.txtTrackWorkerSearch.Size = new System.Drawing.Size(140, 26);
            this.txtTrackWorkerSearch.TabIndex = 1;
            this.txtTrackWorkerSearch.TextChanged += new System.EventHandler(this.txtTrackWorkerSearch_TextChanged);
            // 
            // btnTrackWorkerAddNew
            // 
            this.btnTrackWorkerAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrackWorkerAddNew.Location = new System.Drawing.Point(9, 9);
            this.btnTrackWorkerAddNew.Name = "btnTrackWorkerAddNew";
            this.btnTrackWorkerAddNew.Size = new System.Drawing.Size(100, 45);
            this.btnTrackWorkerAddNew.TabIndex = 0;
            this.btnTrackWorkerAddNew.Text = "Add &New";
            this.btnTrackWorkerAddNew.UseVisualStyleBackColor = true;
            this.btnTrackWorkerAddNew.Click += new System.EventHandler(this.btnTrackWorkerAddNew_Click);
            // 
            // dgvTrackWorker
            // 
            this.dgvTrackWorker.AllowUserToAddRows = false;
            this.dgvTrackWorker.AllowUserToDeleteRows = false;
            this.dgvTrackWorker.AllowUserToOrderColumns = true;
            this.dgvTrackWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTrackWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTrackWorker.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTrackWorker.Location = new System.Drawing.Point(3, 60);
            this.dgvTrackWorker.Name = "dgvTrackWorker";
            this.dgvTrackWorker.ReadOnly = true;
            this.dgvTrackWorker.Size = new System.Drawing.Size(762, 331);
            this.dgvTrackWorker.TabIndex = 3;
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
            this.btnTrackSearch.TabIndex = 2;
            this.btnTrackSearch.Text = "Search";
            this.btnTrackSearch.UseVisualStyleBackColor = true;
            // 
            // txtTrackSearch
            // 
            this.txtTrackSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrackSearch.Location = new System.Drawing.Point(273, 13);
            this.txtTrackSearch.Name = "txtTrackSearch";
            this.txtTrackSearch.Size = new System.Drawing.Size(140, 29);
            this.txtTrackSearch.TabIndex = 1;
            this.txtTrackSearch.TextChanged += new System.EventHandler(this.txtTrackSearch_TextChanged);
            // 
            // btnTrackAddNew
            // 
            this.btnTrackAddNew.Location = new System.Drawing.Point(9, 9);
            this.btnTrackAddNew.Name = "btnTrackAddNew";
            this.btnTrackAddNew.Size = new System.Drawing.Size(100, 45);
            this.btnTrackAddNew.TabIndex = 0;
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
            this.dgvTrack.TabIndex = 3;
            this.dgvTrack.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrack_CellClick);
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
            this.btnClientEventSearch.TabIndex = 2;
            this.btnClientEventSearch.Text = "Search";
            this.btnClientEventSearch.UseVisualStyleBackColor = true;
            // 
            // txtClientEventSearch
            // 
            this.txtClientEventSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientEventSearch.Location = new System.Drawing.Point(273, 13);
            this.txtClientEventSearch.Name = "txtClientEventSearch";
            this.txtClientEventSearch.Size = new System.Drawing.Size(140, 29);
            this.txtClientEventSearch.TabIndex = 1;
            // 
            // btnClientEventAddNew
            // 
            this.btnClientEventAddNew.Location = new System.Drawing.Point(9, 9);
            this.btnClientEventAddNew.Name = "btnClientEventAddNew";
            this.btnClientEventAddNew.Size = new System.Drawing.Size(100, 45);
            this.btnClientEventAddNew.TabIndex = 0;
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
            this.dgvClientEvent.TabIndex = 3;
            this.dgvClientEvent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientEvent_CellClick);
            // 
            // tabEmail
            // 
            this.tabEmail.Controls.Add(this.btnSend);
            this.tabEmail.Controls.Add(this.btnSelectEvent);
            this.tabEmail.Controls.Add(this.webBrowser);
            this.tabEmail.Controls.Add(this.txtEmailBody);
            this.tabEmail.Controls.Add(this.lblEmailBody);
            this.tabEmail.Controls.Add(this.txtEmailSubject);
            this.tabEmail.Controls.Add(this.lblEmailSubject);
            this.tabEmail.Location = new System.Drawing.Point(4, 22);
            this.tabEmail.Name = "tabEmail";
            this.tabEmail.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmail.Size = new System.Drawing.Size(768, 400);
            this.tabEmail.TabIndex = 4;
            this.tabEmail.Text = "Email";
            this.tabEmail.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(493, 11);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnSelectEvent
            // 
            this.btnSelectEvent.Location = new System.Drawing.Point(372, 10);
            this.btnSelectEvent.Name = "btnSelectEvent";
            this.btnSelectEvent.Size = new System.Drawing.Size(115, 24);
            this.btnSelectEvent.TabIndex = 5;
            this.btnSelectEvent.Text = "Select Event";
            this.btnSelectEvent.UseVisualStyleBackColor = true;
            this.btnSelectEvent.Click += new System.EventHandler(this.btnSelectEvent_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(95, 147);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(473, 250);
            this.webBrowser.TabIndex = 4;
            // 
            // txtEmailBody
            // 
            this.txtEmailBody.Location = new System.Drawing.Point(95, 41);
            this.txtEmailBody.Multiline = true;
            this.txtEmailBody.Name = "txtEmailBody";
            this.txtEmailBody.Size = new System.Drawing.Size(473, 100);
            this.txtEmailBody.TabIndex = 3;
            // 
            // lblEmailBody
            // 
            this.lblEmailBody.AutoSize = true;
            this.lblEmailBody.Location = new System.Drawing.Point(48, 44);
            this.lblEmailBody.Name = "lblEmailBody";
            this.lblEmailBody.Size = new System.Drawing.Size(31, 13);
            this.lblEmailBody.TabIndex = 2;
            this.lblEmailBody.Text = "Body";
            // 
            // txtEmailSubject
            // 
            this.txtEmailSubject.Location = new System.Drawing.Point(95, 13);
            this.txtEmailSubject.Name = "txtEmailSubject";
            this.txtEmailSubject.Size = new System.Drawing.Size(271, 20);
            this.txtEmailSubject.TabIndex = 1;
            // 
            // lblEmailSubject
            // 
            this.lblEmailSubject.AutoSize = true;
            this.lblEmailSubject.Location = new System.Drawing.Point(36, 16);
            this.lblEmailSubject.Name = "lblEmailSubject";
            this.lblEmailSubject.Size = new System.Drawing.Size(43, 13);
            this.lblEmailSubject.TabIndex = 0;
            this.lblEmailSubject.Text = "Subject";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Motorsport Marshalling Services";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
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
            this.tabEmail.ResumeLayout(false);
            this.tabEmail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
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
        private System.Windows.Forms.TabPage tabEmail;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.TextBox txtEmailBody;
        private System.Windows.Forms.Label lblEmailBody;
        private System.Windows.Forms.TextBox txtEmailSubject;
        private System.Windows.Forms.Label lblEmailSubject;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnSelectEvent;
    }
}