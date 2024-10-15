using CargoProject.API.DTO;
using CargoTest.GUI.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CargoTest.GUI
{
	public partial class EditProductForm : Form
	{
		private ProductDto _product;
		public EditProductForm(ProductDto dto)
		{
			InitializeComponent();
			this._product = dto;
			this.PreloadData(_product);
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private async void btnEdit_Click(object sender, EventArgs e)
		{
			var name = tbName.Text.ToString().ToLower();
			var desc = tbDescription.Text.ToString().ToLower();
			var price = tbPrice.Text.ToString();
			var quantity = tbQuantity.Text.ToString();

			var productToEdit = new AddProductDto
			{
				Name = name,
				Description = desc,
				StockQuantity = quantity,
				Price = price,
			};

			//restsharp client
			var client = ApiClient.Client;
			var request = new RestRequest($"products/{_product.Id}", Method.Put);
			request.AddJsonBody(productToEdit);

			try
			{
				var response = await client.ExecuteAsync(request);

				if (response.IsSuccessful)
				{
					MessageBox.Show($"Successfully updated product.");
					this.Dispose();
				}
				else
				{
					MessageBox.Show($"API Call Failed: {response.ErrorMessage}");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
			}
		}

		private void PreloadData(ProductDto dto)
		{
			this.tbName.Text = dto.Name;
			this.tbDescription.Text = dto.Description;
			this.tbPrice.Text = Convert.ToInt32(dto.Price).ToString();	
			this.tbQuantity.Text = dto.StockQuantity.ToString();
			this.lvCategories.View = View.Details;

			lvCategories.Columns.Add("Name");
			foreach (var item in dto.Categories)
			{
				ListViewItem listItem = new ListViewItem(item.Name);
				lvCategories.Items.Add(listItem);
			}
		}
	}
}
