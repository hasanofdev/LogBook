using Logbook.Models;
using Logbook.Views;

namespace Logbook
{
    public partial class MainView : Form
    {
        static int _allcrystals = 5;
        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            AllCrystallColumn.Text = _allcrystals.ToString();
            StudentsView students = new StudentsView("3");
            StudentsView students2 = new StudentsView("3");
            
            students2.Dock = DockStyle.Top;
            students.Dock = DockStyle.Top;

            StudentsPanel.Controls.Add(students);
            StudentsPanel.Controls.Add(students2);
        }
    }
}