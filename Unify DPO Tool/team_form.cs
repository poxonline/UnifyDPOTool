using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unify_DPO_Tool
{
    public partial class team_form : Form
    {
        public team_form(string modus)
        {
            InitializeComponent();
            if(modus=="neu")
            {
                cb_teamauswahl.Visible = false;
            }
            else
            {

            }
        }
    }
}
