using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoShimmming
{
    

    public partial class SelectDataForm : Form
    {
        
        //声明事件
        public event DataChangeHandler DataChange;
        public void OnDataChange(object sender, DataChangeEventArgs args)
        {
            if (DataChange != null)
            {
                DataChange(this, args);
            }

        }
        
        //mainForm pForm;
        public SelectDataForm()
        {
            InitializeComponent();
        }

        private void SelectDataForm_Load(object sender, EventArgs e)
        {
            DataChangeEventArgs args = new DataChangeEventArgs(
                (Int32)nudSlice.Value,
                (Int32)nudScan.Value,
                (Int32)nudEcho.Value,
                (Int32)nudAverage.Value
                );
            DataChange(this, args);
        }

        private void Control_ValueChanged(object sender, EventArgs e)
        {
            DataChangeEventArgs args=new DataChangeEventArgs(
                (Int32)nudSlice.Value,
                (Int32)nudScan.Value,
                (Int32)nudEcho.Value,
                (Int32)nudAverage.Value
                );
            DataChange(this, args);
        }
    }

    public class DataChangeEventArgs : EventArgs
    {
        public int Slice { get; set; }
        public int Scan { get; set; }
        public int Echo { get; set; }
        public int Average { get; set; }
        public DataChangeEventArgs(int slice, int scan, int echo, int average)
        {
            Slice = slice;
            Scan = scan;
            Echo = echo;
            Average = average;
        }
    }
}
