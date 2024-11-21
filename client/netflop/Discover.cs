using HLS_GUI;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace netflop
{
    public partial class Discover : Form
    {
        public string url = "http://192.168.101.238:8090/";
        string token;
        public int player_id = 0;
       
        class FilmData
        {
            public string uuid { get; set; }
            public string filmName { get; set; }
            public string path { get; set; }
            public string poster { get; set; }
            public string releaseDate { get; set; }
            public string description { get; set; }
        }
        private void load()
        {
            try
            {               
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(url + "user/getAllFilmsInfo");
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                var response = client.GetAsync(url + "user/getAllFilmsInfo").Result;
                var responseString = response.Content.ReadAsStringAsync().Result;
                var responseData = Newtonsoft.Json.JsonConvert.DeserializeObject<List<FilmData>>(responseString);
                dataGridView1.Rows.Clear();
                foreach (var film in responseData)
                {
                    dataGridView1.Rows.Add(film.filmName, film.description, "View", film.uuid);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString(), "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }
        public Discover(string token, bool isAdmin = false)
        {
            InitializeComponent();
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Description", "Description");
            dataGridView1.Columns.Add("View", "View");
            dataGridView1.Columns.Add("uuid", "uuid");

            dataGridView1.Columns[3].Visible = false;
            //change column width   
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 400;
            dataGridView1.Columns[2].Width = 80;
            this.token = token;
            if (isAdmin)
            {
                uploadBtn.Visible = true;
            }
            //grid view columns
            load();
        }
        //row click event
       

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 2)
            {
                MessageBox.Show("Please wait", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                string uuid = row.Cells["uuid"].Value.ToString();
                string link_movie = url + "public/media/" + uuid + "/master.m3u8";
                uuid = "Source_ID_" + player_id.ToString();
                player_id += 1;
                player player_hls = new player(link_movie, uuid);
                player_hls.Show();
                load();

            }
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            new Upload(token).Show();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            load();
        }
    }  
}
