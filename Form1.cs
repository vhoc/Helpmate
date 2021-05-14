using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helpmate
{
	public partial class MainForm : Form
	{
		public string vncExeLocation = AppDomain.CurrentDomain.BaseDirectory + "vncv.exe";

		public MainForm()
		{
			InitializeComponent();
			DataTable dtComputers = BuildDtComputers();

			dataGridView1.DataSource = dtComputers;
		}

		private static DataTable BuildDtComputers()
		{
			DataTable table = new DataTable();
			table.Columns.Add("PcName", typeof(string));
			table.Columns.Add("IP_Local", typeof(string));
			table.Columns.Add("IP_Radmin", typeof(string));

			table.Rows.Add("Obregón Servidor (MER01-SERVER)", "MER01-SERVER", "26.174.15.21");
			table.Rows.Add("Obregón Caja 1 (PC-PC)", "PC-PC", "26.130.149.5");
			table.Rows.Add("Obregón Caja 2 Refrigeradores (MERO-CAJA2)", "MERO-CAJA2", "26.24.222.154");
			table.Rows.Add("Obregón Caja 3 Esquina (OBR-PEDIDOS04)", "OBR-PEDIDOS04", "26.15.156.113");
			table.Rows.Add("Obregón Caja 4 Pasillo (OBR-PEDIDOS5)", "OBR-PEDIDOS5", "26.105.113.182");

			return table;
		}


		private void MainForm_Load(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && dataGridView1.Columns[e.ColumnIndex].Index != 0)
			{
				//MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
				System.Diagnostics.Process.Start(vncExeLocation, dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() + " -Username admin");
			}
			
		}
	}
}
