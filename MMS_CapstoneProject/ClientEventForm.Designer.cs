
namespace MMS_CapstoneProject
{
    partial class ClientEventForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientEventForm));
            this.lblClientEventId = new System.Windows.Forms.Label();
            this.lblClientEventClientId = new System.Windows.Forms.Label();
            this.lblClientEventTrackId = new System.Windows.Forms.Label();
            this.lblClientEventDate = new System.Windows.Forms.Label();
            this.lblClientEventWorkersRequested = new System.Windows.Forms.Label();
            this.gbClientEventIsLunchProvided = new System.Windows.Forms.GroupBox();
            this.rdoClientEventIsLunchProvided_False = new System.Windows.Forms.RadioButton();
            this.rdoClientEventIsLunchProvided_True = new System.Windows.Forms.RadioButton();
            this.gbClientEventIsUsingPaddock = new System.Windows.Forms.GroupBox();
            this.cbClientEventIsUsingLowerPaddock = new System.Windows.Forms.CheckBox();
            this.cbClientEventIsUsingMiddlePaddock = new System.Windows.Forms.CheckBox();
            this.cbClientEventIsUsingUpperPaddock = new System.Windows.Forms.CheckBox();
            this.lblClientEventIsLunchProvided = new System.Windows.Forms.Label();
            this.lblClientEventIsUsingPaddock = new System.Windows.Forms.Label();
            this.lblClientEventWorkerCalloutSent = new System.Windows.Forms.Label();
            this.lblClientEventRequireSafetyDemo = new System.Windows.Forms.Label();
            this.gbClientEventWorkerCalloutSent = new System.Windows.Forms.GroupBox();
            this.rdoClientEventWorkerCalloutSent_False = new System.Windows.Forms.RadioButton();
            this.rdoClientEventWorkerCalloutSent_True = new System.Windows.Forms.RadioButton();
            this.txtClientEventId = new System.Windows.Forms.TextBox();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.btnClientAdd = new System.Windows.Forms.Button();
            this.btnTrackAdd = new System.Windows.Forms.Button();
            this.txtTrackID = new System.Windows.Forms.TextBox();
            this.txtWorkerRequested = new System.Windows.Forms.TextBox();
            this.gbClientEventRequireSafetyDemo = new System.Windows.Forms.GroupBox();
            this.rdoClientEventRequireSafetyDemo_False = new System.Windows.Forms.RadioButton();
            this.rdoClientEventRequireSafetyDemo_True = new System.Windows.Forms.RadioButton();
            this.gbClientEventIsDeleted = new System.Windows.Forms.GroupBox();
            this.rdoClientEventIsDeleted_Disabled = new System.Windows.Forms.RadioButton();
            this.rdoClientEventIsDeleted_Enabled = new System.Windows.Forms.RadioButton();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEscape = new System.Windows.Forms.Button();
            this.errorProviderApp = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnManageTrackWorker = new System.Windows.Forms.Button();
            this.txtClientEventDate = new System.Windows.Forms.MaskedTextBox();
            this.btnManageAttendance = new System.Windows.Forms.Button();
            this.gbClientEventIsLunchProvided.SuspendLayout();
            this.gbClientEventIsUsingPaddock.SuspendLayout();
            this.gbClientEventWorkerCalloutSent.SuspendLayout();
            this.gbClientEventRequireSafetyDemo.SuspendLayout();
            this.gbClientEventIsDeleted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClientEventId
            // 
            this.lblClientEventId.AutoSize = true;
            this.lblClientEventId.Location = new System.Drawing.Point(107, 9);
            this.lblClientEventId.Name = "lblClientEventId";
            this.lblClientEventId.Size = new System.Drawing.Size(21, 13);
            this.lblClientEventId.TabIndex = 0;
            this.lblClientEventId.Text = "ID:";
            // 
            // lblClientEventClientId
            // 
            this.lblClientEventClientId.AutoSize = true;
            this.lblClientEventClientId.Location = new System.Drawing.Point(78, 35);
            this.lblClientEventClientId.Name = "lblClientEventClientId";
            this.lblClientEventClientId.Size = new System.Drawing.Size(50, 13);
            this.lblClientEventClientId.TabIndex = 2;
            this.lblClientEventClientId.Text = "Client ID:";
            // 
            // lblClientEventTrackId
            // 
            this.lblClientEventTrackId.AutoSize = true;
            this.lblClientEventTrackId.Location = new System.Drawing.Point(73, 58);
            this.lblClientEventTrackId.Name = "lblClientEventTrackId";
            this.lblClientEventTrackId.Size = new System.Drawing.Size(52, 13);
            this.lblClientEventTrackId.TabIndex = 5;
            this.lblClientEventTrackId.Text = "Track ID:";
            // 
            // lblClientEventDate
            // 
            this.lblClientEventDate.AutoSize = true;
            this.lblClientEventDate.Location = new System.Drawing.Point(92, 84);
            this.lblClientEventDate.Name = "lblClientEventDate";
            this.lblClientEventDate.Size = new System.Drawing.Size(33, 13);
            this.lblClientEventDate.TabIndex = 8;
            this.lblClientEventDate.Text = "Date:";
            // 
            // lblClientEventWorkersRequested
            // 
            this.lblClientEventWorkersRequested.AutoSize = true;
            this.lblClientEventWorkersRequested.Location = new System.Drawing.Point(28, 114);
            this.lblClientEventWorkersRequested.Name = "lblClientEventWorkersRequested";
            this.lblClientEventWorkersRequested.Size = new System.Drawing.Size(100, 13);
            this.lblClientEventWorkersRequested.TabIndex = 10;
            this.lblClientEventWorkersRequested.Text = "Worker Requested:";
            // 
            // gbClientEventIsLunchProvided
            // 
            this.gbClientEventIsLunchProvided.Controls.Add(this.rdoClientEventIsLunchProvided_False);
            this.gbClientEventIsLunchProvided.Controls.Add(this.rdoClientEventIsLunchProvided_True);
            this.gbClientEventIsLunchProvided.Location = new System.Drawing.Point(134, 136);
            this.gbClientEventIsLunchProvided.Name = "gbClientEventIsLunchProvided";
            this.gbClientEventIsLunchProvided.Size = new System.Drawing.Size(114, 34);
            this.gbClientEventIsLunchProvided.TabIndex = 13;
            this.gbClientEventIsLunchProvided.TabStop = false;
            // 
            // rdoClientEventIsLunchProvided_False
            // 
            this.rdoClientEventIsLunchProvided_False.AutoSize = true;
            this.rdoClientEventIsLunchProvided_False.Location = new System.Drawing.Point(59, 12);
            this.rdoClientEventIsLunchProvided_False.Name = "rdoClientEventIsLunchProvided_False";
            this.rdoClientEventIsLunchProvided_False.Size = new System.Drawing.Size(50, 17);
            this.rdoClientEventIsLunchProvided_False.TabIndex = 1;
            this.rdoClientEventIsLunchProvided_False.TabStop = true;
            this.rdoClientEventIsLunchProvided_False.Text = "False";
            this.rdoClientEventIsLunchProvided_False.UseVisualStyleBackColor = true;
            // 
            // rdoClientEventIsLunchProvided_True
            // 
            this.rdoClientEventIsLunchProvided_True.AutoSize = true;
            this.rdoClientEventIsLunchProvided_True.Location = new System.Drawing.Point(6, 12);
            this.rdoClientEventIsLunchProvided_True.Name = "rdoClientEventIsLunchProvided_True";
            this.rdoClientEventIsLunchProvided_True.Size = new System.Drawing.Size(47, 17);
            this.rdoClientEventIsLunchProvided_True.TabIndex = 0;
            this.rdoClientEventIsLunchProvided_True.TabStop = true;
            this.rdoClientEventIsLunchProvided_True.Text = "True";
            this.rdoClientEventIsLunchProvided_True.UseVisualStyleBackColor = true;
            // 
            // gbClientEventIsUsingPaddock
            // 
            this.gbClientEventIsUsingPaddock.Controls.Add(this.cbClientEventIsUsingLowerPaddock);
            this.gbClientEventIsUsingPaddock.Controls.Add(this.cbClientEventIsUsingMiddlePaddock);
            this.gbClientEventIsUsingPaddock.Controls.Add(this.cbClientEventIsUsingUpperPaddock);
            this.gbClientEventIsUsingPaddock.Location = new System.Drawing.Point(134, 176);
            this.gbClientEventIsUsingPaddock.Name = "gbClientEventIsUsingPaddock";
            this.gbClientEventIsUsingPaddock.Size = new System.Drawing.Size(221, 63);
            this.gbClientEventIsUsingPaddock.TabIndex = 15;
            this.gbClientEventIsUsingPaddock.TabStop = false;
            // 
            // cbClientEventIsUsingLowerPaddock
            // 
            this.cbClientEventIsUsingLowerPaddock.AutoSize = true;
            this.cbClientEventIsUsingLowerPaddock.Location = new System.Drawing.Point(59, 40);
            this.cbClientEventIsUsingLowerPaddock.Name = "cbClientEventIsUsingLowerPaddock";
            this.cbClientEventIsUsingLowerPaddock.Size = new System.Drawing.Size(101, 17);
            this.cbClientEventIsUsingLowerPaddock.TabIndex = 2;
            this.cbClientEventIsUsingLowerPaddock.Text = "Lower Paddock";
            this.cbClientEventIsUsingLowerPaddock.UseVisualStyleBackColor = true;
            // 
            // cbClientEventIsUsingMiddlePaddock
            // 
            this.cbClientEventIsUsingMiddlePaddock.AutoSize = true;
            this.cbClientEventIsUsingMiddlePaddock.Location = new System.Drawing.Point(112, 15);
            this.cbClientEventIsUsingMiddlePaddock.Name = "cbClientEventIsUsingMiddlePaddock";
            this.cbClientEventIsUsingMiddlePaddock.Size = new System.Drawing.Size(103, 17);
            this.cbClientEventIsUsingMiddlePaddock.TabIndex = 1;
            this.cbClientEventIsUsingMiddlePaddock.Text = "Middle Paddock";
            this.cbClientEventIsUsingMiddlePaddock.UseVisualStyleBackColor = true;
            // 
            // cbClientEventIsUsingUpperPaddock
            // 
            this.cbClientEventIsUsingUpperPaddock.AutoSize = true;
            this.cbClientEventIsUsingUpperPaddock.Location = new System.Drawing.Point(8, 17);
            this.cbClientEventIsUsingUpperPaddock.Name = "cbClientEventIsUsingUpperPaddock";
            this.cbClientEventIsUsingUpperPaddock.Size = new System.Drawing.Size(101, 17);
            this.cbClientEventIsUsingUpperPaddock.TabIndex = 0;
            this.cbClientEventIsUsingUpperPaddock.Text = "Upper Paddock";
            this.cbClientEventIsUsingUpperPaddock.UseVisualStyleBackColor = true;
            // 
            // lblClientEventIsLunchProvided
            // 
            this.lblClientEventIsLunchProvided.AutoSize = true;
            this.lblClientEventIsLunchProvided.Location = new System.Drawing.Point(40, 150);
            this.lblClientEventIsLunchProvided.Name = "lblClientEventIsLunchProvided";
            this.lblClientEventIsLunchProvided.Size = new System.Drawing.Size(85, 13);
            this.lblClientEventIsLunchProvided.TabIndex = 12;
            this.lblClientEventIsLunchProvided.Text = "Lunch Provided:";
            // 
            // lblClientEventIsUsingPaddock
            // 
            this.lblClientEventIsUsingPaddock.AutoSize = true;
            this.lblClientEventIsUsingPaddock.Location = new System.Drawing.Point(72, 195);
            this.lblClientEventIsUsingPaddock.Name = "lblClientEventIsUsingPaddock";
            this.lblClientEventIsUsingPaddock.Size = new System.Drawing.Size(53, 13);
            this.lblClientEventIsUsingPaddock.TabIndex = 14;
            this.lblClientEventIsUsingPaddock.Text = "Paddock:";
            // 
            // lblClientEventWorkerCalloutSent
            // 
            this.lblClientEventWorkerCalloutSent.AutoSize = true;
            this.lblClientEventWorkerCalloutSent.Location = new System.Drawing.Point(23, 258);
            this.lblClientEventWorkerCalloutSent.Name = "lblClientEventWorkerCalloutSent";
            this.lblClientEventWorkerCalloutSent.Size = new System.Drawing.Size(105, 13);
            this.lblClientEventWorkerCalloutSent.TabIndex = 16;
            this.lblClientEventWorkerCalloutSent.Text = "Worker Callout Sent:";
            // 
            // lblClientEventRequireSafetyDemo
            // 
            this.lblClientEventRequireSafetyDemo.AutoSize = true;
            this.lblClientEventRequireSafetyDemo.Location = new System.Drawing.Point(14, 306);
            this.lblClientEventRequireSafetyDemo.Name = "lblClientEventRequireSafetyDemo";
            this.lblClientEventRequireSafetyDemo.Size = new System.Drawing.Size(111, 13);
            this.lblClientEventRequireSafetyDemo.TabIndex = 18;
            this.lblClientEventRequireSafetyDemo.Text = "Require Safety Demo:";
            // 
            // gbClientEventWorkerCalloutSent
            // 
            this.gbClientEventWorkerCalloutSent.Controls.Add(this.rdoClientEventWorkerCalloutSent_False);
            this.gbClientEventWorkerCalloutSent.Controls.Add(this.rdoClientEventWorkerCalloutSent_True);
            this.gbClientEventWorkerCalloutSent.Location = new System.Drawing.Point(134, 245);
            this.gbClientEventWorkerCalloutSent.Name = "gbClientEventWorkerCalloutSent";
            this.gbClientEventWorkerCalloutSent.Size = new System.Drawing.Size(114, 34);
            this.gbClientEventWorkerCalloutSent.TabIndex = 17;
            this.gbClientEventWorkerCalloutSent.TabStop = false;
            // 
            // rdoClientEventWorkerCalloutSent_False
            // 
            this.rdoClientEventWorkerCalloutSent_False.AutoSize = true;
            this.rdoClientEventWorkerCalloutSent_False.Location = new System.Drawing.Point(58, 11);
            this.rdoClientEventWorkerCalloutSent_False.Name = "rdoClientEventWorkerCalloutSent_False";
            this.rdoClientEventWorkerCalloutSent_False.Size = new System.Drawing.Size(50, 17);
            this.rdoClientEventWorkerCalloutSent_False.TabIndex = 1;
            this.rdoClientEventWorkerCalloutSent_False.TabStop = true;
            this.rdoClientEventWorkerCalloutSent_False.Text = "False";
            this.rdoClientEventWorkerCalloutSent_False.UseVisualStyleBackColor = true;
            // 
            // rdoClientEventWorkerCalloutSent_True
            // 
            this.rdoClientEventWorkerCalloutSent_True.AutoSize = true;
            this.rdoClientEventWorkerCalloutSent_True.Location = new System.Drawing.Point(6, 11);
            this.rdoClientEventWorkerCalloutSent_True.Name = "rdoClientEventWorkerCalloutSent_True";
            this.rdoClientEventWorkerCalloutSent_True.Size = new System.Drawing.Size(47, 17);
            this.rdoClientEventWorkerCalloutSent_True.TabIndex = 0;
            this.rdoClientEventWorkerCalloutSent_True.TabStop = true;
            this.rdoClientEventWorkerCalloutSent_True.Text = "True";
            this.rdoClientEventWorkerCalloutSent_True.UseVisualStyleBackColor = true;
            // 
            // txtClientEventId
            // 
            this.txtClientEventId.Enabled = false;
            this.txtClientEventId.Location = new System.Drawing.Point(134, 6);
            this.txtClientEventId.Name = "txtClientEventId";
            this.txtClientEventId.Size = new System.Drawing.Size(100, 20);
            this.txtClientEventId.TabIndex = 1;
            // 
            // txtClientId
            // 
            this.txtClientId.Enabled = false;
            this.txtClientId.Location = new System.Drawing.Point(134, 32);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(100, 20);
            this.txtClientId.TabIndex = 3;
            // 
            // btnClientAdd
            // 
            this.btnClientAdd.Location = new System.Drawing.Point(240, 30);
            this.btnClientAdd.Name = "btnClientAdd";
            this.btnClientAdd.Size = new System.Drawing.Size(75, 23);
            this.btnClientAdd.TabIndex = 4;
            this.btnClientAdd.Text = "Add";
            this.btnClientAdd.UseVisualStyleBackColor = true;
            this.btnClientAdd.Click += new System.EventHandler(this.btnClientAdd_Click);
            // 
            // btnTrackAdd
            // 
            this.btnTrackAdd.Location = new System.Drawing.Point(240, 53);
            this.btnTrackAdd.Name = "btnTrackAdd";
            this.btnTrackAdd.Size = new System.Drawing.Size(75, 23);
            this.btnTrackAdd.TabIndex = 7;
            this.btnTrackAdd.Text = "Add";
            this.btnTrackAdd.UseVisualStyleBackColor = true;
            this.btnTrackAdd.Click += new System.EventHandler(this.btnTrackAdd_Click);
            // 
            // txtTrackID
            // 
            this.txtTrackID.Enabled = false;
            this.txtTrackID.Location = new System.Drawing.Point(134, 55);
            this.txtTrackID.Name = "txtTrackID";
            this.txtTrackID.Size = new System.Drawing.Size(100, 20);
            this.txtTrackID.TabIndex = 6;
            // 
            // txtWorkerRequested
            // 
            this.txtWorkerRequested.Location = new System.Drawing.Point(134, 107);
            this.txtWorkerRequested.Name = "txtWorkerRequested";
            this.txtWorkerRequested.Size = new System.Drawing.Size(100, 20);
            this.txtWorkerRequested.TabIndex = 11;
            this.txtWorkerRequested.Validating += new System.ComponentModel.CancelEventHandler(this.txtWorkerRequested_Validating);
            // 
            // gbClientEventRequireSafetyDemo
            // 
            this.gbClientEventRequireSafetyDemo.Controls.Add(this.rdoClientEventRequireSafetyDemo_False);
            this.gbClientEventRequireSafetyDemo.Controls.Add(this.rdoClientEventRequireSafetyDemo_True);
            this.gbClientEventRequireSafetyDemo.Location = new System.Drawing.Point(134, 285);
            this.gbClientEventRequireSafetyDemo.Name = "gbClientEventRequireSafetyDemo";
            this.gbClientEventRequireSafetyDemo.Size = new System.Drawing.Size(114, 34);
            this.gbClientEventRequireSafetyDemo.TabIndex = 19;
            this.gbClientEventRequireSafetyDemo.TabStop = false;
            // 
            // rdoClientEventRequireSafetyDemo_False
            // 
            this.rdoClientEventRequireSafetyDemo_False.AutoSize = true;
            this.rdoClientEventRequireSafetyDemo_False.Location = new System.Drawing.Point(59, 11);
            this.rdoClientEventRequireSafetyDemo_False.Name = "rdoClientEventRequireSafetyDemo_False";
            this.rdoClientEventRequireSafetyDemo_False.Size = new System.Drawing.Size(50, 17);
            this.rdoClientEventRequireSafetyDemo_False.TabIndex = 1;
            this.rdoClientEventRequireSafetyDemo_False.TabStop = true;
            this.rdoClientEventRequireSafetyDemo_False.Text = "False";
            this.rdoClientEventRequireSafetyDemo_False.UseVisualStyleBackColor = true;
            // 
            // rdoClientEventRequireSafetyDemo_True
            // 
            this.rdoClientEventRequireSafetyDemo_True.AutoSize = true;
            this.rdoClientEventRequireSafetyDemo_True.Location = new System.Drawing.Point(6, 11);
            this.rdoClientEventRequireSafetyDemo_True.Name = "rdoClientEventRequireSafetyDemo_True";
            this.rdoClientEventRequireSafetyDemo_True.Size = new System.Drawing.Size(47, 17);
            this.rdoClientEventRequireSafetyDemo_True.TabIndex = 0;
            this.rdoClientEventRequireSafetyDemo_True.TabStop = true;
            this.rdoClientEventRequireSafetyDemo_True.Text = "True";
            this.rdoClientEventRequireSafetyDemo_True.UseVisualStyleBackColor = true;
            // 
            // gbClientEventIsDeleted
            // 
            this.gbClientEventIsDeleted.Controls.Add(this.rdoClientEventIsDeleted_Disabled);
            this.gbClientEventIsDeleted.Controls.Add(this.rdoClientEventIsDeleted_Enabled);
            this.gbClientEventIsDeleted.Location = new System.Drawing.Point(134, 325);
            this.gbClientEventIsDeleted.Name = "gbClientEventIsDeleted";
            this.gbClientEventIsDeleted.Size = new System.Drawing.Size(148, 35);
            this.gbClientEventIsDeleted.TabIndex = 20;
            this.gbClientEventIsDeleted.TabStop = false;
            // 
            // rdoClientEventIsDeleted_Disabled
            // 
            this.rdoClientEventIsDeleted_Disabled.AutoSize = true;
            this.rdoClientEventIsDeleted_Disabled.Location = new System.Drawing.Point(76, 13);
            this.rdoClientEventIsDeleted_Disabled.Name = "rdoClientEventIsDeleted_Disabled";
            this.rdoClientEventIsDeleted_Disabled.Size = new System.Drawing.Size(66, 17);
            this.rdoClientEventIsDeleted_Disabled.TabIndex = 1;
            this.rdoClientEventIsDeleted_Disabled.TabStop = true;
            this.rdoClientEventIsDeleted_Disabled.Text = "Disabled";
            this.rdoClientEventIsDeleted_Disabled.UseVisualStyleBackColor = true;
            // 
            // rdoClientEventIsDeleted_Enabled
            // 
            this.rdoClientEventIsDeleted_Enabled.AutoSize = true;
            this.rdoClientEventIsDeleted_Enabled.Location = new System.Drawing.Point(6, 13);
            this.rdoClientEventIsDeleted_Enabled.Name = "rdoClientEventIsDeleted_Enabled";
            this.rdoClientEventIsDeleted_Enabled.Size = new System.Drawing.Size(64, 17);
            this.rdoClientEventIsDeleted_Enabled.TabIndex = 0;
            this.rdoClientEventIsDeleted_Enabled.TabStop = true;
            this.rdoClientEventIsDeleted_Enabled.Text = "Enabled";
            this.rdoClientEventIsDeleted_Enabled.UseVisualStyleBackColor = true;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(76, 381);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 22;
            this.btnEnter.Text = "Create";
            this.btnEnter.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(159, 381);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnEscape
            // 
            this.btnEscape.Location = new System.Drawing.Point(240, 381);
            this.btnEscape.Name = "btnEscape";
            this.btnEscape.Size = new System.Drawing.Size(75, 23);
            this.btnEscape.TabIndex = 24;
            this.btnEscape.Text = "Cancel";
            this.btnEscape.UseVisualStyleBackColor = true;
            this.btnEscape.Click += new System.EventHandler(this.btnEscape_Click);
            // 
            // errorProviderApp
            // 
            this.errorProviderApp.ContainerControl = this;
            // 
            // btnManageTrackWorker
            // 
            this.btnManageTrackWorker.Location = new System.Drawing.Point(255, 247);
            this.btnManageTrackWorker.Name = "btnManageTrackWorker";
            this.btnManageTrackWorker.Size = new System.Drawing.Size(100, 42);
            this.btnManageTrackWorker.TabIndex = 21;
            this.btnManageTrackWorker.Text = "Manage Track Worker";
            this.btnManageTrackWorker.UseVisualStyleBackColor = true;
            this.btnManageTrackWorker.Click += new System.EventHandler(this.btnManageTrackWorker_Click);
            // 
            // txtClientEventDate
            // 
            this.txtClientEventDate.Location = new System.Drawing.Point(134, 81);
            this.txtClientEventDate.Mask = "00/00/0000";
            this.txtClientEventDate.Name = "txtClientEventDate";
            this.txtClientEventDate.Size = new System.Drawing.Size(100, 20);
            this.txtClientEventDate.TabIndex = 9;
            this.txtClientEventDate.ValidatingType = typeof(System.DateTime);
            this.txtClientEventDate.Validating += new System.ComponentModel.CancelEventHandler(this.txtClientEventDate_Validating);
            // 
            // btnManageAttendance
            // 
            this.btnManageAttendance.Location = new System.Drawing.Point(250, 295);
            this.btnManageAttendance.Name = "btnManageAttendance";
            this.btnManageAttendance.Size = new System.Drawing.Size(75, 23);
            this.btnManageAttendance.TabIndex = 25;
            this.btnManageAttendance.Text = "ManageAttendance";
            this.btnManageAttendance.UseVisualStyleBackColor = true;
            this.btnManageAttendance.Click += new System.EventHandler(this.btnManageAttendance_Click);
            // 
            // ClientEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 416);
            this.Controls.Add(this.btnManageAttendance);
            this.Controls.Add(this.btnManageTrackWorker);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEscape);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.gbClientEventIsDeleted);
            this.Controls.Add(this.gbClientEventRequireSafetyDemo);
            this.Controls.Add(this.txtWorkerRequested);
            this.Controls.Add(this.txtClientEventDate);
            this.Controls.Add(this.btnTrackAdd);
            this.Controls.Add(this.txtTrackID);
            this.Controls.Add(this.btnClientAdd);
            this.Controls.Add(this.txtClientId);
            this.Controls.Add(this.txtClientEventId);
            this.Controls.Add(this.gbClientEventWorkerCalloutSent);
            this.Controls.Add(this.lblClientEventRequireSafetyDemo);
            this.Controls.Add(this.lblClientEventWorkerCalloutSent);
            this.Controls.Add(this.lblClientEventIsUsingPaddock);
            this.Controls.Add(this.lblClientEventIsLunchProvided);
            this.Controls.Add(this.gbClientEventIsUsingPaddock);
            this.Controls.Add(this.gbClientEventIsLunchProvided);
            this.Controls.Add(this.lblClientEventWorkersRequested);
            this.Controls.Add(this.lblClientEventDate);
            this.Controls.Add(this.lblClientEventTrackId);
            this.Controls.Add(this.lblClientEventClientId);
            this.Controls.Add(this.lblClientEventId);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientEventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Client Event Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientEventForm_FormClosing);
            this.gbClientEventIsLunchProvided.ResumeLayout(false);
            this.gbClientEventIsLunchProvided.PerformLayout();
            this.gbClientEventIsUsingPaddock.ResumeLayout(false);
            this.gbClientEventIsUsingPaddock.PerformLayout();
            this.gbClientEventWorkerCalloutSent.ResumeLayout(false);
            this.gbClientEventWorkerCalloutSent.PerformLayout();
            this.gbClientEventRequireSafetyDemo.ResumeLayout(false);
            this.gbClientEventRequireSafetyDemo.PerformLayout();
            this.gbClientEventIsDeleted.ResumeLayout(false);
            this.gbClientEventIsDeleted.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClientEventId;
        private System.Windows.Forms.Label lblClientEventClientId;
        private System.Windows.Forms.Label lblClientEventTrackId;
        private System.Windows.Forms.Label lblClientEventDate;
        private System.Windows.Forms.Label lblClientEventWorkersRequested;
        private System.Windows.Forms.GroupBox gbClientEventIsLunchProvided;
        private System.Windows.Forms.RadioButton rdoClientEventIsLunchProvided_False;
        private System.Windows.Forms.RadioButton rdoClientEventIsLunchProvided_True;
        private System.Windows.Forms.GroupBox gbClientEventIsUsingPaddock;
        private System.Windows.Forms.Label lblClientEventIsLunchProvided;
        private System.Windows.Forms.Label lblClientEventIsUsingPaddock;
        private System.Windows.Forms.Label lblClientEventWorkerCalloutSent;
        private System.Windows.Forms.Label lblClientEventRequireSafetyDemo;
        private System.Windows.Forms.GroupBox gbClientEventWorkerCalloutSent;
        private System.Windows.Forms.RadioButton rdoClientEventWorkerCalloutSent_False;
        private System.Windows.Forms.RadioButton rdoClientEventWorkerCalloutSent_True;
        private System.Windows.Forms.TextBox txtClientEventId;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.Button btnClientAdd;
        private System.Windows.Forms.Button btnTrackAdd;
        private System.Windows.Forms.TextBox txtTrackID;
        private System.Windows.Forms.TextBox txtWorkerRequested;
        private System.Windows.Forms.GroupBox gbClientEventRequireSafetyDemo;
        private System.Windows.Forms.RadioButton rdoClientEventRequireSafetyDemo_False;
        private System.Windows.Forms.RadioButton rdoClientEventRequireSafetyDemo_True;
        private System.Windows.Forms.GroupBox gbClientEventIsDeleted;
        private System.Windows.Forms.RadioButton rdoClientEventIsDeleted_Disabled;
        private System.Windows.Forms.RadioButton rdoClientEventIsDeleted_Enabled;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEscape;
        private System.Windows.Forms.ErrorProvider errorProviderApp;
        private System.Windows.Forms.Button btnManageTrackWorker;
        private System.Windows.Forms.CheckBox cbClientEventIsUsingUpperPaddock;
        private System.Windows.Forms.CheckBox cbClientEventIsUsingLowerPaddock;
        private System.Windows.Forms.CheckBox cbClientEventIsUsingMiddlePaddock;
        private System.Windows.Forms.MaskedTextBox txtClientEventDate;
        private System.Windows.Forms.Button btnManageAttendance;
    }
}