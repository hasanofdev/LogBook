using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logbook;
using Logbook.Models;

namespace Logbook.Views
{
    public partial class StudentsView : UserControl
    {
        Label _allcrystallLabel;
        MyRadioButton _myradio;
        public StudentsView( ref Label allCrystallbl,Student student,ref MyRadioButton myRadio)
        {
            InitializeComponent();
            _allcrystallLabel = allCrystallbl;
            StudentPictureBox.Image = Image.FromFile($"../../../Images And Icons/{student.ImageName}.png");
            FullNameColumn.Text = student.FullName;
            LastseenColumn.Text = student.LastSeen;
            _myradio = myRadio;

            myRadio.CheckedChanged += MyRadio_CheckedChanged;
        }

        private void MyRadio_CheckedChanged(object? sender, EventArgs e)
        {
            ComeRadioBtn.Checked = true;
        }

        private void CrystalBtn_Click(object sender, EventArgs e)
        {
            var pb = sender as Button;
            int score = 0;

            for (int i = Crystal3.TabIndex; i > 0; i--)
                if (AllcrystallGb.Controls[i] is Button b)
                    if (b.Tag.ToString() == "true")
                        score--;


            if (!ChangeScore(score + pb!.TabIndex))
                return;

            for (int i = Crystal3.TabIndex; i > 0; i--)
                if (AllcrystallGb.Controls[i] is Button b)
                    if (b.TabIndex <= pb!.TabIndex) { b.BackgroundImage = Properties.Resources.diamondactive; b.Tag = "true"; }
                    else { b.BackgroundImage = Properties.Resources.diamonddeactive; b.Tag = "false"; }
        }

        private bool ChangeScore(int score)
        {
            int totalScore = MainView._allcrystals;

            if (totalScore - score < 0)
                return false;

            totalScore -= score;
            MainView._allcrystals = totalScore;

            _allcrystallLabel.Text = MainView._allcrystals.ToString();
            return true;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            int score = 0;

            for (int i = Crystal3.TabIndex; i > 0; i--)
                if (AllcrystallGb.Controls[i] is Button b)
                    if (b.Tag.ToString() == "true")
                    {
                        score--;
                        b.Tag = "false";
                        b.BackgroundImage = Properties.Resources.diamonddeactive;
                    }

            if(score < 0)
                ChangeScore(score);
        }


        private void CommentBtn_Click(object sender, EventArgs e)
        {
            if (!CommentText.Enabled)
                CommentText.Enabled = true;
            CommentText.Visible = true;
            SaveBtn.Visible = !SaveBtn.Visible;
            CancelBtn.Visible = !CancelBtn.Visible;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            CommentText.Enabled = false;
            SaveBtn.Visible = false;
            CancelBtn.Visible = false;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            CommentText.Visible = false;
            SaveBtn.Visible = false;
            CancelBtn.Visible = false;
        }
    }
}

