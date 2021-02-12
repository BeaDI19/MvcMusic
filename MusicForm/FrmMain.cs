using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft;



namespace MusicForm
{
    public partial class FrmMain : Form
    { 
        public FrmMain()
        {  
            this.Load += new EventHandler(Form1_Load);
        }

        private Button button1;
        public ListBox listBox1;
 

        private BindingSource binding1;
        void Form1_Load(object sender, EventArgs e)
        {
            listBox1 = new ListBox();
            binding1 = new BindingSource();
            button1 = new Button();

            listBox1.Location = new Point(140, 25);
            listBox1.Size = new Size(123, 160);

            button1.Location = new Point(23, 25);
            button1.Size = new Size(75, 23);
            button1.Text = "Ajouter";
            button1.Click += new EventHandler(this.button1_Click);

            this.ClientSize = new Size(400, 250);
            this.Text = "Liste des musiques validées";

            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);

            UpdateMusicGrid();

        }

        private void UpdateMusicGrid()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44306/api/MusicAPI/validation");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = client.GetAsync(client.BaseAddress).Result;
            if(response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsStringAsync().Result;
                var musics = new List<Models.MusicDto>();
                Newtonsoft.Json.JsonConvert.PopulateObject(data.ToString(), musics);
                System.Console.WriteLine(data.ToString());

                binding1.DataSource = musics;
                listBox1.DataSource = binding1;
                listBox1.DisplayMember = "title";
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Frm2 frmAjout = new Frm2();
            frmAjout.ShowDialog();
        }
    }

  


}
