using Logbook.Models;

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
           
        }

        private void myRadioButton1_Click(object sender, EventArgs e)
        {
            MyRadioButton? rb = sender as MyRadioButton;

            if(rb!.Checked)
                rb.Checked = false;
            else
                rb.Checked = true;
        }
    }
}