using MusicForm.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MusicForm
{
    public partial class Frm2 : Form
    {
        FrmMain Main = new FrmMain();
        
        public Frm2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void Back_Click(object sender, EventArgs e)
        {
            Main.ShowDialog();
        }

        private void tBPrice_TextChanged(object sender, EventArgs e)
        {
            decimal price = 0;
            Decimal.TryParse(tBPrice.Text, out price);
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            MusicDto musicsList = new MusicDto
            {
                Id = null,
                Title = tBTitle.Text,
                ReleaseDate = dateTimePickerSortie.Value,
                Genre = tBGenre.Text,
                Price = tBPrice.Text,
                Rating = tBRating.Text
            };
            string musicJson = JsonConvert.SerializeObject(musicsList);
            Console.WriteLine(musicJson);


            // Create a request using a URL that can receive a post.
            WebRequest request = WebRequest.Create("https://localhost:44306/api/musicAPI/WinForm");
            // Set the Method property of the request to POST.
            request.Method = "POST";
            // Set the ContentType property of the WebRequest.
            request.ContentType = "application/json";

            // Create POST data and convert it to a byte array.
            string postData = musicJson;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData); 
            // Set the ContentLength property of the WebRequest.
            request.ContentLength = byteArray.Length;

            // Get the request stream.
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.
            dataStream.Write(byteArray, 0, byteArray.Length);
            // Close the Stream object.
            dataStream.Close();

            // Get the response.
            using (WebResponse response = request.GetResponse())
            {
                // Display the status.
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader rdr = new StreamReader(responseStream, Encoding.UTF8);
                    string Json = rdr.ReadToEnd(); // response from server
                }
                // Close the response.
                response.Close();

            }

            
            Close();
                
        }

        
    }
}
