using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Design;

namespace VideoEditor
{
    class myControl: Control
    {
        public myControl()
        {
            InitializeComponent();
        }
        public void InitializeComponent()
        {
            BackColor = System.Drawing.Color.Black; 
        }
     
    }
}
