using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoShimmming
{
    //定义委托

    public delegate void connectStatusChanged(object sender, EventArgs e);
   

    public delegate void DataChangeHandler(object sender, DataChangeEventArgs args);

    public delegate void FilesRead(string files);

    public enum dataFormat { Real, Comp };

    public enum ConnectStatus { Connecting, NotConnected, Connected };

}
