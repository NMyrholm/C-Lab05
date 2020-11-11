using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly List<string> _imageUrls = new List<string>();

        private void buttonExtract_Click(object sender, EventArgs e)
        {
            textBoxImages.Clear();
            _imageUrls.Clear();
            var url = textBoxUrl.Text;
            if (!url.StartsWith("http"))
            {
                url = "https://" + url;
                textBoxUrl.Text = url;
            }
            var client = new HttpClient();

            var getSite = client.GetStringAsync(url);

            const string imagePattern = "<img class.*src=\"(.*?)\"";

            var regex = new Regex(imagePattern, RegexOptions.IgnoreCase);
            try
            {
                var imageMatches = regex.Matches(getSite.Result);
                for (int i = 0; i < imageMatches.Count; i++)
                {
                    var imageStart = imageMatches[i].ToString().IndexOf("data-src");
                    _imageUrls.Add($"{url}{imageMatches[i].ToString().Substring(imageStart + 10, imageMatches[i].Length - imageStart - 11)}");
                }

                textBoxImages.Lines = _imageUrls.ToArray();


                labelMatches.Text = $"Found {imageMatches.Count} images.";
                buttonSaveImages.Enabled = imageMatches.Count != 0;
            }
            catch
            {
                MessageBox.Show($"Invalid link!", "ERROR!", MessageBoxButtons.OK);
            }
        }

        private void textBoxUrl_TextChanged(object sender, EventArgs e)
        {
            buttonExtract.Enabled = textBoxUrl.Text != "";
        }

        private void buttonSaveImages_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    GetImages(dialog.SelectedPath);
                }
            }
        }

        private async void GetImages(string savePath)
        {
            var client = new HttpClient();
            List<Task<byte[]>> listOfBytes = new List<Task<byte[]>>();
            foreach (var url in _imageUrls)
            {
                listOfBytes.Add(client.GetByteArrayAsync(url));
            }
            int i = 0;
            while (listOfBytes.Count > 0)
            {
                try
                {
                    Task<byte[]> downloadedImages = await Task.WhenAny(listOfBytes);
                    using (var fs = new FileStream(savePath + "\\" + $"image{i}.jpg", FileMode.Create, FileAccess.Write))
                    {
                        await fs.WriteAsync(downloadedImages.Result, 0, downloadedImages.Result.Length);
                        i++;
                    }

                    listOfBytes.Remove(downloadedImages);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }

            }
        }
    }
}
