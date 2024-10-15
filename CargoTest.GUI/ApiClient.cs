using RestSharp;

namespace CargoTest.GUI
{
	public static class ApiClient
	{
		private static RestClient _client;
		public static string BaseUrl => "http://localhost:5000/api/";
		public static RestClient Client
		{
			get
			{
				if (_client == null)
				{
					_client = new RestClient(BaseUrl);
				}

				return _client;
			}
		}
	}
}
