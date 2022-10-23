using Logbook.Models;
using Logbook.Views;
using System.Linq;

namespace Logbook
{
    public partial class MainView : Form
    {
        public static int _allcrystals = 5;
        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            AllCrystallColumn.Text = _allcrystals.ToString();
            FillStudents();
        }
        private void FillStudents()
        {
            {
                Student[]? students = null;

                using FileStream fs = new FileStream(@"../../../Resources/Students.json", FileMode.Open);
                students = System.Text.Json.JsonSerializer.Deserialize<Student[]>(fs);
                students!.Reverse();


                foreach (var student in students!)
                {
                    StudentsView studentView = new StudentsView(ref AllCrystallColumn,student,ref myRadioButton1);
                    StudentsPanel.Controls.Add(studentView);
                    studentView.Dock = DockStyle.Top;
                }

            }
        }

        private void AddMaterialBtn_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(LessonTopicTxt.Text))
            StudentsPanel.Enabled = true;
            myRadioButton1.Enabled = true;
        }
    }
}