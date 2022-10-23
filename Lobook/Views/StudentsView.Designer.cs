namespace Logbook.Views
{
    partial class StudentsView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PhotoGb = new System.Windows.Forms.GroupBox();
            this.StudentPictureBox = new System.Windows.Forms.PictureBox();
            this.CommentGb = new System.Windows.Forms.GroupBox();
            this.CommentText = new System.Windows.Forms.TextBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CommentBtn = new System.Windows.Forms.PictureBox();
            this.NumGb = new System.Windows.Forms.GroupBox();
            this.AllcrystallGb = new System.Windows.Forms.GroupBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.Crystal3 = new System.Windows.Forms.Button();
            this.Crystal2 = new System.Windows.Forms.Button();
            this.Crystal1 = new System.Windows.Forms.Button();
            this.ClassworkGb = new System.Windows.Forms.GroupBox();
            this.ClassworkScore = new System.Windows.Forms.ComboBox();
            this.TestGb = new System.Windows.Forms.GroupBox();
            this.TestPoint = new System.Windows.Forms.ComboBox();
            this.MarkAllGb = new System.Windows.Forms.GroupBox();
            this.NotComingRadioBtn = new Logbook.Models.MyRadioButton();
            this.LingeronRadioBtn = new Logbook.Models.MyRadioButton();
            this.ComeRadioBtn = new Logbook.Models.MyRadioButton();
            this.LastseenGb = new System.Windows.Forms.GroupBox();
            this.LastseenColumn = new System.Windows.Forms.Label();
            this.FullNameGb = new System.Windows.Forms.GroupBox();
            this.FullNameColumn = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PhotoGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentPictureBox)).BeginInit();
            this.CommentGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CommentBtn)).BeginInit();
            this.AllcrystallGb.SuspendLayout();
            this.ClassworkGb.SuspendLayout();
            this.TestGb.SuspendLayout();
            this.MarkAllGb.SuspendLayout();
            this.LastseenGb.SuspendLayout();
            this.FullNameGb.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PhotoGb
            // 
            this.PhotoGb.Controls.Add(this.StudentPictureBox);
            this.PhotoGb.Location = new System.Drawing.Point(65, -13);
            this.PhotoGb.Name = "PhotoGb";
            this.PhotoGb.Size = new System.Drawing.Size(71, 76);
            this.PhotoGb.TabIndex = 26;
            this.PhotoGb.TabStop = false;
            // 
            // StudentPictureBox
            // 
            this.StudentPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.StudentPictureBox.Location = new System.Drawing.Point(0, 13);
            this.StudentPictureBox.Name = "StudentPictureBox";
            this.StudentPictureBox.Size = new System.Drawing.Size(71, 62);
            this.StudentPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.StudentPictureBox.TabIndex = 0;
            this.StudentPictureBox.TabStop = false;
            // 
            // CommentGb
            // 
            this.CommentGb.Controls.Add(this.CommentText);
            this.CommentGb.Controls.Add(this.CancelBtn);
            this.CommentGb.Controls.Add(this.SaveBtn);
            this.CommentGb.Controls.Add(this.CommentBtn);
            this.CommentGb.Location = new System.Drawing.Point(1030, -13);
            this.CommentGb.Name = "CommentGb";
            this.CommentGb.Size = new System.Drawing.Size(250, 76);
            this.CommentGb.TabIndex = 22;
            this.CommentGb.TabStop = false;
            // 
            // CommentText
            // 
            this.CommentText.Location = new System.Drawing.Point(37, 15);
            this.CommentText.Multiline = true;
            this.CommentText.Name = "CommentText";
            this.CommentText.Size = new System.Drawing.Size(148, 57);
            this.CommentText.TabIndex = 4;
            this.CommentText.Visible = false;
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.CancelBtn.BackgroundImage = global::Logbook.Properties.Resources.cancel;
            this.CancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelBtn.Location = new System.Drawing.Point(191, 44);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(38, 31);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Visible = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Transparent;
            this.SaveBtn.BackgroundImage = global::Logbook.Properties.Resources.save;
            this.SaveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveBtn.Location = new System.Drawing.Point(191, 13);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(38, 31);
            this.SaveBtn.TabIndex = 2;
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Visible = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CommentBtn
            // 
            this.CommentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CommentBtn.Image = global::Logbook.Properties.Resources.comment;
            this.CommentBtn.Location = new System.Drawing.Point(6, 28);
            this.CommentBtn.Name = "CommentBtn";
            this.CommentBtn.Size = new System.Drawing.Size(25, 25);
            this.CommentBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CommentBtn.TabIndex = 0;
            this.CommentBtn.TabStop = false;
            this.CommentBtn.Click += new System.EventHandler(this.CommentBtn_Click);
            // 
            // NumGb
            // 
            this.NumGb.Location = new System.Drawing.Point(8, -13);
            this.NumGb.Name = "NumGb";
            this.NumGb.Size = new System.Drawing.Size(58, 76);
            this.NumGb.TabIndex = 25;
            this.NumGb.TabStop = false;
            // 
            // AllcrystallGb
            // 
            this.AllcrystallGb.Controls.Add(this.DeleteBtn);
            this.AllcrystallGb.Controls.Add(this.Crystal3);
            this.AllcrystallGb.Controls.Add(this.Crystal2);
            this.AllcrystallGb.Controls.Add(this.Crystal1);
            this.AllcrystallGb.Location = new System.Drawing.Point(928, -13);
            this.AllcrystallGb.Name = "AllcrystallGb";
            this.AllcrystallGb.Size = new System.Drawing.Size(104, 76);
            this.AllcrystallGb.TabIndex = 24;
            this.AllcrystallGb.TabStop = false;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteBtn.BackgroundImage = global::Logbook.Properties.Resources.deletedeactive;
            this.DeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Location = new System.Drawing.Point(70, 24);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(28, 26);
            this.DeleteBtn.TabIndex = 4;
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // Crystal3
            // 
            this.Crystal3.BackColor = System.Drawing.Color.Transparent;
            this.Crystal3.BackgroundImage = global::Logbook.Properties.Resources.diamonddeactive;
            this.Crystal3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Crystal3.FlatAppearance.BorderSize = 0;
            this.Crystal3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Crystal3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Crystal3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Crystal3.Location = new System.Drawing.Point(44, 28);
            this.Crystal3.Name = "Crystal3";
            this.Crystal3.Size = new System.Drawing.Size(20, 18);
            this.Crystal3.TabIndex = 3;
            this.Crystal3.Tag = "false";
            this.Crystal3.UseVisualStyleBackColor = false;
            this.Crystal3.Click += new System.EventHandler(this.CrystalBtn_Click);
            // 
            // Crystal2
            // 
            this.Crystal2.BackColor = System.Drawing.Color.Transparent;
            this.Crystal2.BackgroundImage = global::Logbook.Properties.Resources.diamonddeactive;
            this.Crystal2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Crystal2.FlatAppearance.BorderSize = 0;
            this.Crystal2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Crystal2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Crystal2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Crystal2.Location = new System.Drawing.Point(25, 28);
            this.Crystal2.Name = "Crystal2";
            this.Crystal2.Size = new System.Drawing.Size(20, 18);
            this.Crystal2.TabIndex = 2;
            this.Crystal2.Tag = "false";
            this.Crystal2.UseVisualStyleBackColor = false;
            this.Crystal2.Click += new System.EventHandler(this.CrystalBtn_Click);
            // 
            // Crystal1
            // 
            this.Crystal1.BackColor = System.Drawing.Color.Transparent;
            this.Crystal1.BackgroundImage = global::Logbook.Properties.Resources.diamonddeactive;
            this.Crystal1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Crystal1.FlatAppearance.BorderSize = 0;
            this.Crystal1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Crystal1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Crystal1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Crystal1.Location = new System.Drawing.Point(6, 28);
            this.Crystal1.Name = "Crystal1";
            this.Crystal1.Size = new System.Drawing.Size(20, 18);
            this.Crystal1.TabIndex = 1;
            this.Crystal1.Tag = "false";
            this.Crystal1.UseVisualStyleBackColor = false;
            this.Crystal1.Click += new System.EventHandler(this.CrystalBtn_Click);
            // 
            // ClassworkGb
            // 
            this.ClassworkGb.Controls.Add(this.ClassworkScore);
            this.ClassworkGb.Location = new System.Drawing.Point(827, -13);
            this.ClassworkGb.Name = "ClassworkGb";
            this.ClassworkGb.Size = new System.Drawing.Size(112, 76);
            this.ClassworkGb.TabIndex = 23;
            this.ClassworkGb.TabStop = false;
            // 
            // ClassworkScore
            // 
            this.ClassworkScore.BackColor = System.Drawing.SystemColors.Window;
            this.ClassworkScore.FormattingEnabled = true;
            this.ClassworkScore.Items.AddRange(new object[] {
            "-",
            "12",
            "11",
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.ClassworkScore.Location = new System.Drawing.Point(23, 28);
            this.ClassworkScore.Name = "ClassworkScore";
            this.ClassworkScore.Size = new System.Drawing.Size(72, 23);
            this.ClassworkScore.TabIndex = 1;
            this.ClassworkScore.Text = "-";
            // 
            // TestGb
            // 
            this.TestGb.Controls.Add(this.TestPoint);
            this.TestGb.Location = new System.Drawing.Point(743, -13);
            this.TestGb.Name = "TestGb";
            this.TestGb.Size = new System.Drawing.Size(86, 76);
            this.TestGb.TabIndex = 21;
            this.TestGb.TabStop = false;
            // 
            // TestPoint
            // 
            this.TestPoint.BackColor = System.Drawing.SystemColors.Window;
            this.TestPoint.FormattingEnabled = true;
            this.TestPoint.Items.AddRange(new object[] {
            "-",
            "12",
            "11",
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.TestPoint.Location = new System.Drawing.Point(6, 28);
            this.TestPoint.Name = "TestPoint";
            this.TestPoint.Size = new System.Drawing.Size(72, 23);
            this.TestPoint.TabIndex = 0;
            this.TestPoint.Text = "-";
            // 
            // MarkAllGb
            // 
            this.MarkAllGb.Controls.Add(this.NotComingRadioBtn);
            this.MarkAllGb.Controls.Add(this.LingeronRadioBtn);
            this.MarkAllGb.Controls.Add(this.ComeRadioBtn);
            this.MarkAllGb.Location = new System.Drawing.Point(561, -13);
            this.MarkAllGb.Name = "MarkAllGb";
            this.MarkAllGb.Size = new System.Drawing.Size(193, 76);
            this.MarkAllGb.TabIndex = 20;
            this.MarkAllGb.TabStop = false;
            // 
            // NotComingRadioBtn
            // 
            this.NotComingRadioBtn.AutoSize = true;
            this.NotComingRadioBtn.Checked = true;
            this.NotComingRadioBtn.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.NotComingRadioBtn.Location = new System.Drawing.Point(108, 29);
            this.NotComingRadioBtn.MinimumSize = new System.Drawing.Size(0, 21);
            this.NotComingRadioBtn.Name = "NotComingRadioBtn";
            this.NotComingRadioBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.NotComingRadioBtn.Size = new System.Drawing.Size(24, 21);
            this.NotComingRadioBtn.TabIndex = 18;
            this.NotComingRadioBtn.TabStop = true;
            this.NotComingRadioBtn.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.NotComingRadioBtn.UseVisualStyleBackColor = true;
            // 
            // LingeronRadioBtn
            // 
            this.LingeronRadioBtn.AutoSize = true;
            this.LingeronRadioBtn.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.LingeronRadioBtn.Location = new System.Drawing.Point(79, 29);
            this.LingeronRadioBtn.MinimumSize = new System.Drawing.Size(0, 21);
            this.LingeronRadioBtn.Name = "LingeronRadioBtn";
            this.LingeronRadioBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.LingeronRadioBtn.Size = new System.Drawing.Size(24, 21);
            this.LingeronRadioBtn.TabIndex = 17;
            this.LingeronRadioBtn.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.LingeronRadioBtn.UseVisualStyleBackColor = true;
            // 
            // ComeRadioBtn
            // 
            this.ComeRadioBtn.AutoSize = true;
            this.ComeRadioBtn.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(205)))), ((int)(((byte)(105)))));
            this.ComeRadioBtn.Location = new System.Drawing.Point(49, 29);
            this.ComeRadioBtn.MinimumSize = new System.Drawing.Size(0, 21);
            this.ComeRadioBtn.Name = "ComeRadioBtn";
            this.ComeRadioBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ComeRadioBtn.Size = new System.Drawing.Size(24, 21);
            this.ComeRadioBtn.TabIndex = 16;
            this.ComeRadioBtn.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(205)))), ((int)(((byte)(105)))));
            this.ComeRadioBtn.UseVisualStyleBackColor = true;
            // 
            // LastseenGb
            // 
            this.LastseenGb.Controls.Add(this.LastseenColumn);
            this.LastseenGb.Location = new System.Drawing.Point(359, -13);
            this.LastseenGb.Name = "LastseenGb";
            this.LastseenGb.Size = new System.Drawing.Size(206, 76);
            this.LastseenGb.TabIndex = 19;
            this.LastseenGb.TabStop = false;
            // 
            // LastseenColumn
            // 
            this.LastseenColumn.AutoSize = true;
            this.LastseenColumn.Location = new System.Drawing.Point(47, 33);
            this.LastseenColumn.Name = "LastseenColumn";
            this.LastseenColumn.Size = new System.Drawing.Size(113, 15);
            this.LastseenColumn.TabIndex = 9;
            this.LastseenColumn.Text = "Last seen in MyStat";
            // 
            // FullNameGb
            // 
            this.FullNameGb.Controls.Add(this.FullNameColumn);
            this.FullNameGb.Location = new System.Drawing.Point(134, -13);
            this.FullNameGb.Name = "FullNameGb";
            this.FullNameGb.Size = new System.Drawing.Size(228, 76);
            this.FullNameGb.TabIndex = 18;
            this.FullNameGb.TabStop = false;
            // 
            // FullNameColumn
            // 
            this.FullNameColumn.AutoSize = true;
            this.FullNameColumn.Location = new System.Drawing.Point(55, 33);
            this.FullNameColumn.Name = "FullNameColumn";
            this.FullNameColumn.Size = new System.Drawing.Size(118, 15);
            this.FullNameColumn.TabIndex = 8;
            this.FullNameColumn.Text = "Student\'s Full Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PhotoGb);
            this.groupBox1.Controls.Add(this.CommentGb);
            this.groupBox1.Controls.Add(this.NumGb);
            this.groupBox1.Controls.Add(this.AllcrystallGb);
            this.groupBox1.Controls.Add(this.ClassworkGb);
            this.groupBox1.Controls.Add(this.TestGb);
            this.groupBox1.Controls.Add(this.MarkAllGb);
            this.groupBox1.Controls.Add(this.LastseenGb);
            this.groupBox1.Controls.Add(this.FullNameGb);
            this.groupBox1.Location = new System.Drawing.Point(-7, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1279, 62);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // StudentsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "StudentsView";
            this.Size = new System.Drawing.Size(1289, 62);
            this.PhotoGb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentPictureBox)).EndInit();
            this.CommentGb.ResumeLayout(false);
            this.CommentGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CommentBtn)).EndInit();
            this.AllcrystallGb.ResumeLayout(false);
            this.ClassworkGb.ResumeLayout(false);
            this.TestGb.ResumeLayout(false);
            this.MarkAllGb.ResumeLayout(false);
            this.MarkAllGb.PerformLayout();
            this.LastseenGb.ResumeLayout(false);
            this.LastseenGb.PerformLayout();
            this.FullNameGb.ResumeLayout(false);
            this.FullNameGb.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox PhotoGb;
        private GroupBox CommentGb;
        private GroupBox NumGb;
        private GroupBox AllcrystallGb;
        private GroupBox ClassworkGb;
        private GroupBox TestGb;
        private GroupBox MarkAllGb;
        private Models.MyRadioButton ComeRadioBtn;
        private GroupBox LastseenGb;
        private Label LastseenColumn;
        private GroupBox FullNameGb;
        private Label FullNameColumn;
        private GroupBox groupBox1;
        private PictureBox StudentPictureBox;
        private Models.MyRadioButton NotComingRadioBtn;
        private Models.MyRadioButton LingeronRadioBtn;
        private ComboBox TestPoint;
        private ComboBox ClassworkScore;
        private PictureBox CommentBtn;
        private Button Crystal3;
        private Button Crystal2;
        private Button Crystal1;
        private Button DeleteBtn;
        private Button CancelBtn;
        private Button SaveBtn;
        private TextBox CommentText;
    }
}
