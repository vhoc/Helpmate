
namespace Helpmate
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabObregon = new System.Windows.Forms.TabPage();
			this.tabGuaymas = new System.Windows.Forms.TabPage();
			this.tabHermosillo = new System.Windows.Forms.TabPage();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabObregon.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(3, 3);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 25;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridView1.Size = new System.Drawing.Size(538, 467);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabObregon);
			this.tabControl1.Controls.Add(this.tabGuaymas);
			this.tabControl1.Controls.Add(this.tabHermosillo);
			this.tabControl1.Location = new System.Drawing.Point(12, 13);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(552, 501);
			this.tabControl1.TabIndex = 1;
			// 
			// tabObregon
			// 
			this.tabObregon.Controls.Add(this.dataGridView1);
			this.tabObregon.Location = new System.Drawing.Point(4, 24);
			this.tabObregon.Name = "tabObregon";
			this.tabObregon.Padding = new System.Windows.Forms.Padding(3);
			this.tabObregon.Size = new System.Drawing.Size(544, 473);
			this.tabObregon.TabIndex = 0;
			this.tabObregon.Text = "Obregón";
			this.tabObregon.UseVisualStyleBackColor = true;
			// 
			// tabGuaymas
			// 
			this.tabGuaymas.Location = new System.Drawing.Point(4, 24);
			this.tabGuaymas.Name = "tabGuaymas";
			this.tabGuaymas.Padding = new System.Windows.Forms.Padding(3);
			this.tabGuaymas.Size = new System.Drawing.Size(544, 473);
			this.tabGuaymas.TabIndex = 1;
			this.tabGuaymas.Text = "Guaymas";
			this.tabGuaymas.UseVisualStyleBackColor = true;
			// 
			// tabHermosillo
			// 
			this.tabHermosillo.Location = new System.Drawing.Point(4, 24);
			this.tabHermosillo.Name = "tabHermosillo";
			this.tabHermosillo.Size = new System.Drawing.Size(544, 473);
			this.tabHermosillo.TabIndex = 2;
			this.tabHermosillo.Text = "Hermosillo";
			this.tabHermosillo.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(576, 526);
			this.Controls.Add(this.tabControl1);
			this.Name = "MainForm";
			this.Text = "Helpmate";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabObregon.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabObregon;
		private System.Windows.Forms.TabPage tabGuaymas;
		private System.Windows.Forms.TabPage tabHermosillo;
	}
}

