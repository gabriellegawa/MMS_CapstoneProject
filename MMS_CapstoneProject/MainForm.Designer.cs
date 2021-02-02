
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
            this.Client = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblPrimaryContactEmail = new System.Windows.Forms.Label();
            this.lblPrimaryContactCell = new System.Windows.Forms.Label();
            this.lblPrimaryContactName = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtPrimaryContactName = new System.Windows.Forms.TextBox();
            this.txtPrimaryContactCell = new System.Windows.Forms.TextBox();
            this.txtPrimaryContactEmail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Client.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Client
            // 
            this.Client.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Client.Controls.Add(this.tabPage1);
            this.Client.Controls.Add(this.tabPage2);
            this.Client.Location = new System.Drawing.Point(1, 0);
            this.Client.Name = "Client";
            this.Client.SelectedIndex = 0;
            this.Client.Size = new System.Drawing.Size(878, 556);
            this.Client.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.txtPrimaryContactEmail);
            this.tabPage1.Controls.Add(this.txtPrimaryContactCell);
            this.tabPage1.Controls.Add(this.txtPrimaryContactName);
            this.tabPage1.Controls.Add(this.txtClientName);
            this.tabPage1.Controls.Add(this.lblPrimaryContactEmail);
            this.tabPage1.Controls.Add(this.lblPrimaryContactCell);
            this.tabPage1.Controls.Add(this.lblPrimaryContactName);
            this.tabPage1.Controls.Add(this.lblClientName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(870, 530);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(870, 530);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(106, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(187, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(268, 190);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(25, 219);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(106, 219);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(187, 219);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 14;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(25, 248);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 15;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(106, 248);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 16;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(496, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 557);
            this.Controls.Add(this.Client);
            this.Name = "MainForm";
            this.Text = "Motorsport Marshalling Services Track Day Management Suite";
            this.Client.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Client;
        private System.Windows.Forms.TabPage tabPage1;
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
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

