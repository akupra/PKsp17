namespace PKsp17
{
    partial class FormStudentInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudentInfo));
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.chbxViewMark1 = new System.Windows.Forms.CheckBox();
            this.chbxViewMark2 = new System.Windows.Forms.CheckBox();
            this.chbxTimelyLaboratories = new System.Windows.Forms.CheckBox();
            this.txtbxLaboratoriesMark = new System.Windows.Forms.TextBox();
            this.lblLaboratoriesMark = new System.Windows.Forms.Label();
            this.grbxLaboratories = new System.Windows.Forms.GroupBox();
            this.grbxCourseWork = new System.Windows.Forms.GroupBox();
            this.lblAutoMark = new System.Windows.Forms.Label();
            this.cmbxAutoMark = new System.Windows.Forms.ComboBox();
            this.lblMaxMark = new System.Windows.Forms.Label();
            this.cmbxMaxMark = new System.Windows.Forms.ComboBox();
            this.txtbxCourseWorkBall = new System.Windows.Forms.TextBox();
            this.lblCourseWorkBall = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbxStatus = new System.Windows.Forms.ComboBox();
            this.chbxAllLaboratoriesPassed = new System.Windows.Forms.CheckBox();
            this.pnlPhoto = new System.Windows.Forms.Panel();
            this.pctrbxPhoto = new System.Windows.Forms.PictureBox();
            this.tlspImage = new System.Windows.Forms.ToolStrip();
            this.btnSelectImage = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteImage = new System.Windows.Forms.ToolStripButton();
            this.pnlExercise = new System.Windows.Forms.Panel();
            this.txtbxExercise = new System.Windows.Forms.TextBox();
            this.lblExercise = new System.Windows.Forms.Label();
            this.lblMark = new System.Windows.Forms.Label();
            this.cmbxMark = new System.Windows.Forms.ComboBox();
            this.pnlButtons.SuspendLayout();
            this.grbxLaboratories.SuspendLayout();
            this.grbxCourseWork.SuspendLayout();
            this.pnlPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxPhoto)).BeginInit();
            this.tlspImage.SuspendLayout();
            this.pnlExercise.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(53, 7);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(235, 20);
            this.txtbxName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(3, 7);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "ФИО";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.SystemColors.Control;
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnSave);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 324);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(493, 36);
            this.pnlButtons.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(409, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.LightGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(325, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chbxViewMark1
            // 
            this.chbxViewMark1.AutoSize = true;
            this.chbxViewMark1.Location = new System.Drawing.Point(6, 16);
            this.chbxViewMark1.Name = "chbxViewMark1";
            this.chbxViewMark1.Size = new System.Drawing.Size(199, 17);
            this.chbxViewMark1.TabIndex = 5;
            this.chbxViewMark1.Text = "Своевременность 1-го просмотра";
            this.chbxViewMark1.UseVisualStyleBackColor = true;
            // 
            // chbxViewMark2
            // 
            this.chbxViewMark2.AutoSize = true;
            this.chbxViewMark2.Location = new System.Drawing.Point(6, 37);
            this.chbxViewMark2.Name = "chbxViewMark2";
            this.chbxViewMark2.Size = new System.Drawing.Size(199, 17);
            this.chbxViewMark2.TabIndex = 6;
            this.chbxViewMark2.Text = "Своевременность 2-го просмотра";
            this.chbxViewMark2.UseVisualStyleBackColor = true;
            // 
            // chbxTimelyLaboratories
            // 
            this.chbxTimelyLaboratories.AutoSize = true;
            this.chbxTimelyLaboratories.Location = new System.Drawing.Point(8, 41);
            this.chbxTimelyLaboratories.Name = "chbxTimelyLaboratories";
            this.chbxTimelyLaboratories.Size = new System.Drawing.Size(118, 17);
            this.chbxTimelyLaboratories.TabIndex = 7;
            this.chbxTimelyLaboratories.Text = "Своевременность";
            this.chbxTimelyLaboratories.UseVisualStyleBackColor = true;
            // 
            // txtbxLaboratoriesMark
            // 
            this.txtbxLaboratoriesMark.Location = new System.Drawing.Point(78, 18);
            this.txtbxLaboratoriesMark.Name = "txtbxLaboratoriesMark";
            this.txtbxLaboratoriesMark.Size = new System.Drawing.Size(42, 20);
            this.txtbxLaboratoriesMark.TabIndex = 9;
            this.txtbxLaboratoriesMark.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxLaboratoriesMark_KeyPress);
            // 
            // lblLaboratoriesMark
            // 
            this.lblLaboratoriesMark.Location = new System.Drawing.Point(8, 18);
            this.lblLaboratoriesMark.Name = "lblLaboratoriesMark";
            this.lblLaboratoriesMark.Size = new System.Drawing.Size(69, 20);
            this.lblLaboratoriesMark.TabIndex = 8;
            this.lblLaboratoriesMark.Text = "Общий балл";
            this.lblLaboratoriesMark.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grbxLaboratories
            // 
            this.grbxLaboratories.Controls.Add(this.chbxTimelyLaboratories);
            this.grbxLaboratories.Controls.Add(this.txtbxLaboratoriesMark);
            this.grbxLaboratories.Controls.Add(this.lblLaboratoriesMark);
            this.grbxLaboratories.Location = new System.Drawing.Point(6, 64);
            this.grbxLaboratories.Name = "grbxLaboratories";
            this.grbxLaboratories.Size = new System.Drawing.Size(133, 65);
            this.grbxLaboratories.TabIndex = 10;
            this.grbxLaboratories.TabStop = false;
            this.grbxLaboratories.Text = "Первые 6-ть лаб";
            // 
            // grbxCourseWork
            // 
            this.grbxCourseWork.Controls.Add(this.lblMark);
            this.grbxCourseWork.Controls.Add(this.cmbxMark);
            this.grbxCourseWork.Controls.Add(this.lblAutoMark);
            this.grbxCourseWork.Controls.Add(this.cmbxAutoMark);
            this.grbxCourseWork.Controls.Add(this.lblMaxMark);
            this.grbxCourseWork.Controls.Add(this.cmbxMaxMark);
            this.grbxCourseWork.Controls.Add(this.txtbxCourseWorkBall);
            this.grbxCourseWork.Controls.Add(this.lblCourseWorkBall);
            this.grbxCourseWork.Controls.Add(this.chbxViewMark1);
            this.grbxCourseWork.Controls.Add(this.chbxViewMark2);
            this.grbxCourseWork.Location = new System.Drawing.Point(145, 64);
            this.grbxCourseWork.Name = "grbxCourseWork";
            this.grbxCourseWork.Size = new System.Drawing.Size(209, 154);
            this.grbxCourseWork.TabIndex = 11;
            this.grbxCourseWork.TabStop = false;
            this.grbxCourseWork.Text = "Курсовая работа";
            // 
            // lblAutoMark
            // 
            this.lblAutoMark.Location = new System.Drawing.Point(3, 104);
            this.lblAutoMark.Name = "lblAutoMark";
            this.lblAutoMark.Size = new System.Drawing.Size(127, 21);
            this.lblAutoMark.TabIndex = 15;
            this.lblAutoMark.Text = "Автомат";
            this.lblAutoMark.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbxAutoMark
            // 
            this.cmbxAutoMark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxAutoMark.FormattingEnabled = true;
            this.cmbxAutoMark.Location = new System.Drawing.Point(131, 104);
            this.cmbxAutoMark.Name = "cmbxAutoMark";
            this.cmbxAutoMark.Size = new System.Drawing.Size(57, 21);
            this.cmbxAutoMark.TabIndex = 14;
            // 
            // lblMaxMark
            // 
            this.lblMaxMark.Location = new System.Drawing.Point(3, 80);
            this.lblMaxMark.Name = "lblMaxMark";
            this.lblMaxMark.Size = new System.Drawing.Size(127, 21);
            this.lblMaxMark.TabIndex = 13;
            this.lblMaxMark.Text = "Максимальная оценка";
            this.lblMaxMark.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbxMaxMark
            // 
            this.cmbxMaxMark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxMaxMark.FormattingEnabled = true;
            this.cmbxMaxMark.Location = new System.Drawing.Point(131, 80);
            this.cmbxMaxMark.Name = "cmbxMaxMark";
            this.cmbxMaxMark.Size = new System.Drawing.Size(57, 21);
            this.cmbxMaxMark.TabIndex = 12;
            // 
            // txtbxCourseWorkBall
            // 
            this.txtbxCourseWorkBall.Location = new System.Drawing.Point(73, 57);
            this.txtbxCourseWorkBall.Name = "txtbxCourseWorkBall";
            this.txtbxCourseWorkBall.Size = new System.Drawing.Size(42, 20);
            this.txtbxCourseWorkBall.TabIndex = 11;
            this.txtbxCourseWorkBall.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxLaboratoriesMark_KeyPress);
            // 
            // lblCourseWorkBall
            // 
            this.lblCourseWorkBall.Location = new System.Drawing.Point(3, 57);
            this.lblCourseWorkBall.Name = "lblCourseWorkBall";
            this.lblCourseWorkBall.Size = new System.Drawing.Size(69, 20);
            this.lblCourseWorkBall.TabIndex = 10;
            this.lblCourseWorkBall.Text = "Балл за КР";
            this.lblCourseWorkBall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(7, 31);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 21);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Статус";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbxStatus
            // 
            this.cmbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxStatus.FormattingEnabled = true;
            this.cmbxStatus.Location = new System.Drawing.Point(53, 31);
            this.cmbxStatus.Name = "cmbxStatus";
            this.cmbxStatus.Size = new System.Drawing.Size(108, 21);
            this.cmbxStatus.TabIndex = 14;
            // 
            // chbxAllLaboratoriesPassed
            // 
            this.chbxAllLaboratoriesPassed.AutoSize = true;
            this.chbxAllLaboratoriesPassed.Location = new System.Drawing.Point(183, 35);
            this.chbxAllLaboratoriesPassed.Name = "chbxAllLaboratoriesPassed";
            this.chbxAllLaboratoriesPassed.Size = new System.Drawing.Size(109, 17);
            this.chbxAllLaboratoriesPassed.TabIndex = 16;
            this.chbxAllLaboratoriesPassed.Text = "Сданы все лабы";
            this.chbxAllLaboratoriesPassed.UseVisualStyleBackColor = true;
            // 
            // pnlPhoto
            // 
            this.pnlPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPhoto.Controls.Add(this.pctrbxPhoto);
            this.pnlPhoto.Controls.Add(this.tlspImage);
            this.pnlPhoto.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlPhoto.Location = new System.Drawing.Point(359, 0);
            this.pnlPhoto.Name = "pnlPhoto";
            this.pnlPhoto.Size = new System.Drawing.Size(134, 224);
            this.pnlPhoto.TabIndex = 17;
            // 
            // pctrbxPhoto
            // 
            this.pctrbxPhoto.BackColor = System.Drawing.Color.White;
            this.pctrbxPhoto.BackgroundImage = global::PKsp17.Properties.Resources.face;
            this.pctrbxPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctrbxPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctrbxPhoto.Location = new System.Drawing.Point(0, 25);
            this.pctrbxPhoto.Name = "pctrbxPhoto";
            this.pctrbxPhoto.Size = new System.Drawing.Size(132, 197);
            this.pctrbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrbxPhoto.TabIndex = 2;
            this.pctrbxPhoto.TabStop = false;
            // 
            // tlspImage
            // 
            this.tlspImage.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tlspImage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSelectImage,
            this.btnDeleteImage});
            this.tlspImage.Location = new System.Drawing.Point(0, 0);
            this.tlspImage.Name = "tlspImage";
            this.tlspImage.Size = new System.Drawing.Size(132, 25);
            this.tlspImage.TabIndex = 0;
            this.tlspImage.Text = "toolStrip1";
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSelectImage.Image = global::PKsp17.Properties.Resources.add;
            this.btnSelectImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(23, 22);
            this.btnSelectImage.Text = "toolStripButton1";
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // btnDeleteImage
            // 
            this.btnDeleteImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteImage.Image = global::PKsp17.Properties.Resources.delete;
            this.btnDeleteImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteImage.Name = "btnDeleteImage";
            this.btnDeleteImage.Size = new System.Drawing.Size(23, 22);
            this.btnDeleteImage.Text = "toolStripButton2";
            this.btnDeleteImage.Click += new System.EventHandler(this.btnDeleteImage_Click);
            // 
            // pnlExercise
            // 
            this.pnlExercise.BackColor = System.Drawing.SystemColors.Control;
            this.pnlExercise.Controls.Add(this.txtbxExercise);
            this.pnlExercise.Controls.Add(this.lblExercise);
            this.pnlExercise.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlExercise.Location = new System.Drawing.Point(0, 224);
            this.pnlExercise.Name = "pnlExercise";
            this.pnlExercise.Padding = new System.Windows.Forms.Padding(2);
            this.pnlExercise.Size = new System.Drawing.Size(493, 100);
            this.pnlExercise.TabIndex = 18;
            // 
            // txtbxExercise
            // 
            this.txtbxExercise.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbxExercise.Location = new System.Drawing.Point(2, 15);
            this.txtbxExercise.Multiline = true;
            this.txtbxExercise.Name = "txtbxExercise";
            this.txtbxExercise.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbxExercise.Size = new System.Drawing.Size(489, 83);
            this.txtbxExercise.TabIndex = 4;
            // 
            // lblExercise
            // 
            this.lblExercise.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblExercise.Location = new System.Drawing.Point(2, 2);
            this.lblExercise.Name = "lblExercise";
            this.lblExercise.Size = new System.Drawing.Size(489, 13);
            this.lblExercise.TabIndex = 0;
            this.lblExercise.Text = "Задание на защиту";
            // 
            // lblMark
            // 
            this.lblMark.Location = new System.Drawing.Point(3, 127);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(127, 21);
            this.lblMark.TabIndex = 17;
            this.lblMark.Text = "Финальная оценка";
            this.lblMark.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbxMark
            // 
            this.cmbxMark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxMark.FormattingEnabled = true;
            this.cmbxMark.Location = new System.Drawing.Point(131, 127);
            this.cmbxMark.Name = "cmbxMark";
            this.cmbxMark.Size = new System.Drawing.Size(57, 21);
            this.cmbxMark.TabIndex = 16;
            // 
            // FormStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(493, 360);
            this.Controls.Add(this.pnlPhoto);
            this.Controls.Add(this.chbxAllLaboratoriesPassed);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbxStatus);
            this.Controls.Add(this.grbxCourseWork);
            this.Controls.Add(this.grbxLaboratories);
            this.Controls.Add(this.txtbxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pnlExercise);
            this.Controls.Add(this.pnlButtons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStudentInfo";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormStudentInfo";
            this.pnlButtons.ResumeLayout(false);
            this.grbxLaboratories.ResumeLayout(false);
            this.grbxLaboratories.PerformLayout();
            this.grbxCourseWork.ResumeLayout(false);
            this.grbxCourseWork.PerformLayout();
            this.pnlPhoto.ResumeLayout(false);
            this.pnlPhoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxPhoto)).EndInit();
            this.tlspImage.ResumeLayout(false);
            this.tlspImage.PerformLayout();
            this.pnlExercise.ResumeLayout(false);
            this.pnlExercise.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chbxViewMark1;
        private System.Windows.Forms.CheckBox chbxViewMark2;
        private System.Windows.Forms.CheckBox chbxTimelyLaboratories;
        private System.Windows.Forms.TextBox txtbxLaboratoriesMark;
        private System.Windows.Forms.Label lblLaboratoriesMark;
        private System.Windows.Forms.GroupBox grbxLaboratories;
        private System.Windows.Forms.GroupBox grbxCourseWork;
        private System.Windows.Forms.TextBox txtbxCourseWorkBall;
        private System.Windows.Forms.Label lblCourseWorkBall;
        private System.Windows.Forms.Label lblAutoMark;
        private System.Windows.Forms.ComboBox cmbxAutoMark;
        private System.Windows.Forms.Label lblMaxMark;
        private System.Windows.Forms.ComboBox cmbxMaxMark;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbxStatus;
        private System.Windows.Forms.CheckBox chbxAllLaboratoriesPassed;
        private System.Windows.Forms.Panel pnlPhoto;
        private System.Windows.Forms.ToolStrip tlspImage;
        private System.Windows.Forms.PictureBox pctrbxPhoto;
        private System.Windows.Forms.ToolStripButton btnSelectImage;
        private System.Windows.Forms.ToolStripButton btnDeleteImage;
        private System.Windows.Forms.Panel pnlExercise;
        private System.Windows.Forms.TextBox txtbxExercise;
        private System.Windows.Forms.Label lblExercise;
        private System.Windows.Forms.Label lblMark;
        private System.Windows.Forms.ComboBox cmbxMark;
    }
}