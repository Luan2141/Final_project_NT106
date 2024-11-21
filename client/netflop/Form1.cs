using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace netflop
{
    public partial class Form1 : Form
    {
        public string url = "http://192.168.101.238:8090/";
        public Form1()
        {
            InitializeComponent();
        }

        class LoginPostData
        {
            public string email { get; set; }
            public string password { get; set; }
        }

        class LoginResponseData
        {
            public string token { get; set; }
            public string role { get; set; }
        }

        class publicKey
        {
            public BigInteger e { get; set; }
            public BigInteger n { get; set; }
            public int keySize { get; set; }
        }

        publicKey key;

        private string encrypt(string plain, BigInteger e, BigInteger n, int size)
        {
            string encrypted = "";
            byte[] plainByte = Encoding.UTF8.GetBytes(plain);
            Array.Reverse(plainByte);
            BigInteger plainInt = new BigInteger(plainByte);
            if (plainInt < 0)
            {
                plainInt = new BigInteger(new byte[] { 0 }.Concat(plainByte).ToArray());
            }
            BigInteger encryptedInt = BigInteger.ModPow(plainInt, e, n);
            plainByte = encryptedInt.ToByteArray();
            if(plainByte.Length > size / 8)
            {
                plainByte = plainByte.Take(plainByte.Count() - 1).ToArray();
            }
            Array.Reverse(plainByte);
            encrypted = Convert.ToBase64String(plainByte);
            return encrypted;
        }

        private string sessionConnect()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(url + "auth/generate");
                var response = client.GetAsync(url + "auth/generate").Result;
                var sessionID = response.Content.ReadAsStringAsync().Result;
                response = client.GetAsync(url + "auth/publicKey/" + sessionID).Result;
                var responseStr = response.Content.ReadAsStringAsync().Result;
                key = Newtonsoft.Json.JsonConvert.DeserializeObject<publicKey>(responseStr);
                return sessionID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }


        private void loginBtn_Click(object sender, EventArgs e)
        {
            string sessionID = sessionConnect();
            try
            {
                HttpClient client = new HttpClient();
                var loginData = new LoginPostData
                {
                    email = encrypt(loginEmailBox.Text, key.e, key.n, key.keySize),
                    password = encrypt(loginPasswordBox.Text, key.e, key.n, key.keySize)

                };
                //MessageBox.Show(loginData.email + '\n' + loginData.password);
                loginEmailBox.Clear();
                loginPasswordBox.Clear();
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(loginData);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                var response = client.PostAsync(url + "auth/signin/" + sessionID, data).Result;
                var responseString = response.Content.ReadAsStringAsync().Result;
                var responseData = Newtonsoft.Json.JsonConvert.DeserializeObject<LoginResponseData>(responseString);
                if (responseData.token == null)
                {
                    MessageBox.Show("Login failed", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Login successfully", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                var DiscoverForm = new Discover(responseData.token, (responseData.role == "admin"));
                DiscoverForm.Closed += (s, args) => this.Close();
                DiscoverForm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        class RegisterPostData
        {
            public string name { get; set; }
            public string email { get; set; }
            public string password { get; set; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string sessionID = sessionConnect();
            var registerData = new RegisterPostData
            {
                name = encrypt(registerNameBox.Text, key.e, key.n, key.keySize),
                email = encrypt(registerEmailBox.Text, key.e, key.n, key.keySize),
                password = encrypt(registerPasswordBox.Text, key.e, key.n, key.keySize)
            };

            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(url + "auth/signup/" + sessionID);
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(registerData);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                var response = client.PostAsync(url + "auth/signup/" + sessionID, data).Result;
                var responseString = response.Content.ReadAsStringAsync().Result;
                MessageBox.Show("Register successfully", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
