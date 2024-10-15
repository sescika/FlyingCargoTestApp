using CargoProject.API.DTO;
using CargoTest.GUI.Models;
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

namespace CargoTest.GUI
{
	public partial class AddProductForm : Form
	{
		public AddProductForm()
		{
			InitializeComponent();
		}

		private async void btnAdd_Click(object sender, EventArgs e)
		{
			var name = tbName.Text.ToString().ToLower();
			var desc = tbDesc.Text.ToString().ToLower();
			var price = tbPrice.Text.ToString();
			var quantity = tbStock.Text.ToString();

			var productToAdd = new AddProductDto
			{
				Name = name,
				Description = desc,
				StockQuantity =quantity,
				Price = price,
			};

			//restsharp client
			var client = ApiClient.Client;
			var request = new RestRequest("products", Method.Post);
			request.AddJsonBody(productToAdd);
			try
			{
				var response = await client.ExecuteAsync(request);

				if (response.IsSuccessful)
				{
					MessageBox.Show($"Successfully added product.");
					this.Reset();
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

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			this.Reset();
		}

		private void Reset()
		{
			tbDesc.Clear();
			tbName.Clear();
			tbPrice.Clear();
			tbStock.Clear();
		}
	}
}
