using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SelectData
{
    public partial class SelectDataForm : Form
    {
        public SelectDataForm()
        {
            
            InitializeComponent();
            
        }

        private void SelectDataForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Owner.ToString());
            
            
        }
    }
}
