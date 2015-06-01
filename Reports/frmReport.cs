using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoogleChartSharp;

namespace Reports
{
    public partial class frmCharts : Form
    {
private int[] Data { get; set; }
private int PreviousState { get; set; }

public frmCharts()
{
    InitializeComponent();
}

private void frmReport_Load(object sender, EventArgs e)
{
    northwndDataSetTableAdapters.Summary_of_Sales_by_QuarterTableAdapter taQuarter = new northwndDataSetTableAdapters.Summary_of_Sales_by_QuarterTableAdapter();
    northwndDataSet.Summary_of_Sales_by_QuarterDataTable table = new northwndDataSet.Summary_of_Sales_by_QuarterDataTable();
    taQuarter.Fill(table);
    Data = new int[table.Count];

    for (int i = 0; i < table.Count; i++)
    {
        Data[i] = (int)table[i].Subtotal;
    }
    ucGraph1.Data = Data;
    PreviousState = 0;

}

private void btnPlay_Click(object sender, EventArgs e)
{
    timer.Interval = 50;
    timer.Start();
}

private void timer_Tick(object sender, EventArgs e)
{

    int[] data = new int[100];
    for (int i = 0; i < 100; i++)
    {
        data[i] = Data[i + PreviousState];
    }
    if (PreviousState >= Data.Length - 100) timer.Stop();
    PreviousState++;

    ucGraph1.Data = data;
    ucGraph1.Invalidate();
}

    }
}
