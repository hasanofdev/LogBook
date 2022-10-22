using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logbook.Views
{
    public partial class StudentsView : UserControl
    {
        public StudentsView(string name)
        {
            InitializeComponent();
            this.Name = name;
        }
    }
}
