using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Sign_up : Form
    {
        string a;
        public Sign_up()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtmatkhau.Clear();
            txtemail.Clear();
            txtfirst.Clear();
            txtlast.Clear();
            txtphone.Clear();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString() == "Male")
            {
                a = "1";
            }
            else
            {
                a = "0";
            }
            var userData = new
            {
                username = txtname.Text,
                email = txtemail.Text,
                password = txtmatkhau.Text,
                first_name = txtfirst.Text,
                last_name = txtlast.Text,
                sex = a,
                birthday = dateTimePicker1.Text,
                language = comboBox1.SelectedItem.ToString(),
                phone = txtphone.Text
            };

            
            string jsonData = JsonConvert.SerializeObject(userData);

            
            string apiUrl = "https://nt106.uitiot.vn/api/v1/user/signup";

            
            using (var httpClient = new HttpClient())
            {
                try
                {
                    
                    var content = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");

                    
                    var response = await httpClient.PostAsync(apiUrl, content);

                    
                    string responseContent = await response.Content.ReadAsStringAsync();

                    
                    Console.WriteLine($"HTTP Status Code: {response.StatusCode}");
                    Console.WriteLine($"Response Content: {responseContent}");
                    this.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}
