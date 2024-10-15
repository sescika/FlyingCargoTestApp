namespace CargoTest.GUI
{
	partial class EditProductForm
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
			this.btnBack = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tbName = new System.Windows.Forms.TextBox();
			this.btnEdit = new System.Windows.Forms.Button();
			this.tbDescription = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbPrice = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbQuantity = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.lvCategories = new System.Windows.Forms.ListView();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(247, 305);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(75, 50);
			this.btnBack.TabIndex = 0;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Name:";
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(12, 25);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(310, 20);
			this.tbName.TabIndex = 2;
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(141, 305);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(100, 50);
			this.btnEdit.TabIndex = 3;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// tbDescription
			// 
			this.tbDescription.Location = new System.Drawing.Point(12, 64);
			this.tbDescription.Name = "tbDescription";
			this.tbDescription.Size = new System.Drawing.Size(310, 20);
			this.tbDescription.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Description:";
			// 
			// tbPrice
			// 
			this.tbPrice.Location = new System.Drawing.Point(12, 103);
			this.tbPrice.Name = "tbPrice";
			this.tbPrice.Size = new System.Drawing.Size(310, 20);
			this.tbPrice.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Price:";
			// 
			// tbQuantity
			// 
			this.tbQuantity.Location = new System.Drawing.Point(12, 142);
			this.tbQuantity.Name = "tbQuantity";
			this.tbQuantity.Size = new System.Drawing.Size(310, 20);
			this.tbQuantity.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 126);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Stock Quantity:";
			// 
			// lvCategories
			// 
			this.lvCategories.HideSelection = false;
			this.lvCategories.Location = new System.Drawing.Point(12, 181);
			this.lvCategories.Name = "lvCategories";
			this.lvCategories.Size = new System.Drawing.Size(310, 118);
			this.lvCategories.TabIndex = 10;
			this.lvCategories.UseCompatibleStateImageBehavior = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 165);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(63, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Categories: ";
			// 
			// EditProductForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 366);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lvCategories);
			this.Controls.Add(this.tbQuantity);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbPrice);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbDescription);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnBack);
			this.Name = "EditProductForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "EditProductForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.TextBox tbDescription;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbPrice;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbQuantity;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ListView lvCategories;
		private System.Windows.Forms.Label label5;
	}
}