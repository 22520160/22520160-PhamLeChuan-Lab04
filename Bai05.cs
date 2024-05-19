using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Bai05 : Form
    {
        private readonly HttpClient _httpClient;

        public Bai05()
        {
            InitializeComponent();
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(@"https://nt106.uitiot.vn")
            };
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            var formData = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("username", username),
                new KeyValuePair<string, string>("password", password)
            });

            HttpResponseMessage response = await _httpClient.PostAsync("auth/token", formData);

            if (response.IsSuccessStatusCode)
            {
                await HandleSuccessResponse(response);
            }
            else
            {
                await HandleErrorResponse(response);
            }
        }

        private async Task HandleSuccessResponse(HttpResponseMessage response)
        {
            string res = await response.Content.ReadAsStringAsync();
            JObject jsonResponse = JObject.Parse(res);

            if (jsonResponse["access_token"] != null)
            {
                string tokenType = jsonResponse["token_type"].ToString();
                string accessToken = jsonResponse["access_token"].ToString();

                richTextBox1.AppendText($"{tokenType} {accessToken}\n");
                richTextBox1.AppendText("Đăng nhập thành công\n");
            }
        }

        private async Task HandleErrorResponse(HttpResponseMessage response)
        {
            string errorResponse = await response.Content.ReadAsStringAsync();
            JObject errorJson = JObject.Parse(errorResponse);
            string detail = errorJson["detail"].ToString();
            richTextBox1.AppendText($"{detail}\n");
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
