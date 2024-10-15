namespace CargoTest.GUI
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dgv1 = new System.Windows.Forms.DataGridView();
			this.tbName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.tbPrice = new System.Windows.Forms.TextBox();
			this.tbDesc = new System.Windows.Forms.TextBox();
			this.tbId = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tbStockQuantity = new System.Windows.Forms.TextBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv1
			// 
			this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.dgv1.Location = new System.Drawing.Point(12, 12);
			this.dgv1.Name = "dgv1";
			this.dgv1.ReadOnly = true;
			this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv1.Size = new System.Drawing.Size(684, 637);
			this.dgv1.TabIndex = 0;
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(818, 15);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(154, 20);
			this.tbName.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(702, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Product Name?";
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(705, 149);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(267, 35);
			this.btnSearch.TabIndex = 3;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// tbPrice
			// 
			this.tbPrice.Location = new System.Drawing.Point(818, 41);
			this.tbPrice.Name = "tbPrice";
			this.tbPrice.Size = new System.Drawing.Size(154, 20);
			this.tbPrice.TabIndex = 5;
			// 
			// tbDesc
			// 
			this.tbDesc.Location = new System.Drawing.Point(818, 67);
			this.tbDesc.Name = "tbDesc";
			this.tbDesc.Size = new System.Drawing.Size(154, 20);
			this.tbDesc.TabIndex = 6;
			// 
			// tbId
			// 
			this.tbId.Location = new System.Drawing.Point(818, 97);
			this.tbId.Name = "tbId";
			this.tbId.Size = new System.Drawing.Size(154, 20);
			this.tbId.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(702, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Product Price? (>=)";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(702, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Product Id?";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(702, 74);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(106, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Product Description?";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(702, 126);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(104, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "Stock Quantity? (>=)";
			// 
			// tbStockQuantity
			// 
			this.tbStockQuantity.Location = new System.Drawing.Point(818, 123);
			this.tbStockQuantity.Name = "tbStockQuantity";
			this.tbStockQuantity.Size = new System.Drawing.Size(154, 20);
			this.tbStockQuantity.TabIndex = 11;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(705, 614);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(267, 35);
			this.btnDelete.TabIndex = 13;
			this.btnDelete.Text = "Delete Product";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(705, 532);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(267, 35);
			this.btnAdd.TabIndex = 14;
			this.btnAdd.Text = "Add Product";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(702, 190);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(267, 35);
			this.btnReset.TabIndex = 15;
			this.btnReset.Text = "Reset and Refresh";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(705, 573);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(267, 35);
			this.btnEdit.TabIndex = 16;
			this.btnEdit.Text = "Edit Product";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 661);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tbStockQuantity);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbId);
			this.Controls.Add(this.tbDesc);
			this.Controls.Add(this.tbPrice);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.dgv1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgv1;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox tbPrice;
		private System.Windows.Forms.TextBox tbDesc;
		private System.Windows.Forms.TextBox tbId;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbStockQuantity;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnEdit;
	}
}

