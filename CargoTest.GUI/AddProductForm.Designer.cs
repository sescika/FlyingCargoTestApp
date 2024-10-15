namespace CargoTest.GUI
{
	partial class AddProductForm
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
			this.btnAdd = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbStock = new System.Windows.Forms.TextBox();
			this.tbDesc = new System.Windows.Forms.TextBox();
			this.tbPrice = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbName = new System.Windows.Forms.TextBox();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(12, 134);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(89, 35);
			this.btnAdd.TabIndex = 27;
			this.btnAdd.Text = "Create";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 97);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 13);
			this.label3.TabIndex = 24;
			this.label3.Text = "Stock Quantity *";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(17, 71);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 13);
			this.label4.TabIndex = 23;
			this.label4.Text = "Description *";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 22;
			this.label2.Text = "Price *";
			// 
			// tbStock
			// 
			this.tbStock.Location = new System.Drawing.Point(102, 94);
			this.tbStock.Name = "tbStock";
			this.tbStock.Size = new System.Drawing.Size(220, 20);
			this.tbStock.TabIndex = 21;
			// 
			// tbDesc
			// 
			this.tbDesc.Location = new System.Drawing.Point(102, 64);
			this.tbDesc.Name = "tbDesc";
			this.tbDesc.Size = new System.Drawing.Size(220, 20);
			this.tbDesc.TabIndex = 20;
			// 
			// tbPrice
			// 
			this.tbPrice.Location = new System.Drawing.Point(102, 38);
			this.tbPrice.Name = "tbPrice";
			this.tbPrice.Size = new System.Drawing.Size(220, 20);
			this.tbPrice.TabIndex = 19;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 17;
			this.label1.Text = "Name *";
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(102, 12);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(220, 20);
			this.tbName.TabIndex = 16;
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(233, 134);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(89, 35);
			this.btnBack.TabIndex = 28;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(124, 134);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(89, 35);
			this.btnReset.TabIndex = 29;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// AddProductForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 191);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbStock);
			this.Controls.Add(this.tbDesc);
			this.Controls.Add(this.tbPrice);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbName);
			this.Name = "AddProductForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddProductForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbStock;
		private System.Windows.Forms.TextBox tbDesc;
		private System.Windows.Forms.TextBox tbPrice;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnReset;
	}
}