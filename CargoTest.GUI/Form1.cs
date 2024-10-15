using Newtonsoft.Json;
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
using CargoTest.GUI.Models;

namespace CargoTest.GUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			LoadData();
			this.dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		}
		
		private ProductDto SelectedProduct
		{
			get
			{
				if(this.dgv1.SelectedRows.Count == 0)
				{
					return null;
				}

				return this.dgv1.SelectedRows[0].DataBoundItem as ProductDto;
			}
		}

		private async void LoadData()
		{
			//restsharp client
			var client = ApiClient.Client;
			var request = new RestRequest("products", Method.Get);
			try
			{
				var response = await client.ExecuteAsync(request);

				if (response.IsSuccessful)
				{
					var data = JsonConvert.DeserializeObject<List<ProductDto>>(response.Content);

					dgv1.DataSource = data;
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
		private async void SearchData(SearchDto dto)
		{
			//restsharp client
			var client = ApiClient.Client;
			var request = new RestRequest("products", Method.Get);

			if (!string.IsNullOrEmpty(dto.Name))
			{
				request.AddQueryParameter("name", dto.Name);
			}
			if (!string.IsNullOrEmpty(dto.Description))
			{
				request.AddQueryParameter("description", dto.Description);
			}
			if (!string.IsNullOrEmpty(dto.Id))
			{
				request.AddQueryParameter("id", dto.Id);
			}
			if (!string.IsNullOrEmpty(dto.Price))
			{
				request.AddQueryParameter("priceGreaterThan", dto.Price);
			}
			if (!string.IsNullOrEmpty(dto.StockQuantity))
			{
				request.AddQueryParameter("stockQuantity", dto.StockQuantity);
			}

			try
			{
				var response = await client.ExecuteAsync(request);

				if (response.IsSuccessful)
				{
					var data = JsonConvert.DeserializeObject<List<ProductDto>>(response.Content);

					dgv1.DataSource = data;
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

		private async void btnSearch_Click(object sender, EventArgs e)
		{
			//textbox values
			var name = tbName.Text.ToString().ToLower();
			var desc = tbDesc.Text.ToString().ToLower();
			var id = tbId.Text.ToString();
			var price = tbPrice.Text.ToString();
			var stockQuantity = tbStockQuantity.Text.ToString();

			var searchObj = new SearchDto
			{
				Name = name,
				Description = desc,
				Id = id,
				Price = price,
				StockQuantity = stockQuantity
			};

			SearchData(searchObj);
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			tbDesc.Clear();
			tbName.Clear();
			tbPrice.Clear();
			tbId.Clear();
			tbStockQuantity.Clear();
			LoadData();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			AddProductForm addForm = new AddProductForm();
			addForm.Show();

			addForm.Disposed += (x, y) =>
			{
				this.LoadData();
			};
		}

		private async void btnEdit_Click(object sender, EventArgs e)
		{
			if(SelectedProduct == null)
			{
				MessageBox.Show("Product not selected.");
				return;
			};
			EditProductForm editForm = new EditProductForm(SelectedProduct);
			editForm.Show();

			editForm.Disposed += (x, y) =>
			{
				this.LoadData();
			};
		}

		private async void btnDelete_Click(object sender, EventArgs e)
		{
			if(this.SelectedProduct == null)
			{
				return;
			}

			var client = ApiClient.Client;
			var request = new RestRequest($"products/{this.SelectedProduct.Id}", Method.Delete);

			try
			{
				var response = await client.ExecuteAsync(request);

				if (response.IsSuccessful)
				{
					this.LoadData();
					MessageBox.Show($"Product with ID: {this.SelectedProduct.Id} was deleted successfully.");
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
	}
}
