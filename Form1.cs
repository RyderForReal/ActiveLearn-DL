using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using Aspose.Words;

namespace ActiveLearn_DL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BackColor = Color.FromArgb(20, 20, 20);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void descriptionL2_Click(object sender, EventArgs e)
        {
        }

        private void start_Click(object sender, EventArgs e)
        {
            var export = new Document();
            if (!Uri.IsWellFormedUriString(baseUrl.Text, UriKind.Absolute))
            {
                MessageBox.Show(@"Please enter a valid URL!");
                console.Items.Add($"{baseUrl.Text} is not a valid ActiveLearn base URL.");
            }
            else
            {
                if (!Directory.Exists(saveLocation.Text))
                {
                    MessageBox.Show(@"Please enter a valid file path!");
                    console.Items.Add($"{saveLocation.Text} does not exist!");
                }
                else
                {
                    console.Items.Add("INFO: Creating directory " + Path.Combine(saveLocation.Text, bookName.Text));
                    var path = Path.Combine(saveLocation.Text, bookName.Text);
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                        console.Items.Add("INFO: Created directory.");
                    }

                    console.Items.Add($"{path} already exists, continuing anyway.");
                    //Directory.CreateDirectory(path);

                    var getPages = new WebClient();
                    var i = 1;

                    try
                    {
                        while (i < 10)
                        {
                            console.Items.Add($"INFO: Downloading {baseUrl.Text}-00{i.ToString()}.jpg");
                            if (!File.Exists($"{path}\\00{i.ToString()}.jpg"))
                            {
                                try
                                {
                                    getPages.DownloadFile($"{baseUrl.Text}-00{i.ToString()}.jpg",
                                        $"{path}\\00{i.ToString()}.jpg");
                                    console.Items.Add($"INFO: Downloaded page {i.ToString()}.");
                                    console.TopIndex = console.Items.Count - 1;
                                }
                                catch (WebException ex)
                                {
                                    if (((HttpWebResponse)ex.Response).StatusCode == HttpStatusCode.NotFound)
                                    {
                                        console.Items.Add(
                                            $"ERROR: {baseUrl.Text}-{i.ToString()}.jpg not found, assuming that this is the end of the book.");
                                        console.TopIndex = console.Items.Count - 1;
                                        break;
                                    }

                                    console.Items.Add($"ALERT: {ex.Message}");
                                }
                            }
                            else
                            {
                                console.Items.Add($"INFO: Page {i.ToString()} already exists, skipping.");
                                console.TopIndex = console.Items.Count - 1;
                            }


                            i++;
                        }

                        while (i < 100)
                        {
                            console.Items.Add($"INFO: Downloading {baseUrl.Text}-0{i.ToString()}.jpg");
                            if (!File.Exists($"{path}\\0{i.ToString()}.jpg"))
                            {
                                try
                                {
                                    getPages.DownloadFile($"{baseUrl.Text}-0{i.ToString()}.jpg",
                                        $"{path}\\0{i.ToString()}.jpg");
                                    console.Items.Add($"INFO: Downloaded page {i.ToString()}.");
                                    console.TopIndex = console.Items.Count - 1;
                                }
                                catch (WebException ex)
                                {
                                    if (((HttpWebResponse)ex.Response).StatusCode == HttpStatusCode.NotFound)
                                    {
                                        console.Items.Add(
                                            $"ERROR: {baseUrl.Text}-{i.ToString()}.jpg not found, assuming that this is the end of the book.");
                                        console.TopIndex = console.Items.Count - 1;
                                        break;
                                    }

                                    console.Items.Add($"ALERT: {ex.Message}");
                                }
                            }
                            else
                            {
                                console.Items.Add($"INFO: Page {i.ToString()} already exists, skipping.");
                                console.TopIndex = console.Items.Count - 1;
                            }

                            i++;
                        }

                        while (i < 1000)
                        {
                            console.Items.Add($"INFO: Downloading {baseUrl.Text}-{i.ToString()}.jpg");
                            if (!File.Exists($"{path}\\{i.ToString()}.jpg"))
                            {
                                try
                                {
                                    getPages.DownloadFile($"{baseUrl.Text}-{i.ToString()}.jpg",
                                        $"{path}\\{i.ToString()}.jpg");
                                    console.Items.Add($"INFO: Downloaded page {i.ToString()}.");
                                    console.TopIndex = console.Items.Count - 1;
                                }
                                catch (WebException ex)
                                {
                                    if (((HttpWebResponse)ex.Response).StatusCode == HttpStatusCode.NotFound)
                                    {
                                        console.Items.Add(
                                            $"INFO: {baseUrl.Text}-{i.ToString()}.jpg not found, assuming that this is the end of the book.");
                                        console.TopIndex = console.Items.Count - 1;
                                        break;
                                    }

                                    console.Items.Add($"ALERT: {ex.Message}");
                                }
                            }
                            else
                            {
                                console.Items.Add($"INFO: Page {i.ToString()} already exists, skipping.");
                                console.TopIndex = console.Items.Count - 1;
                            }

                            i++;
                        }
                    }
                    catch (Exception ex)
                    {
                        console.Items.Add($"ALERT: An exception has occured. {ex.Message}");
                        console.TopIndex = console.Items.Count - 1;
                        Directory.Delete(Path.Combine(saveLocation.Text, bookName.Text));
                    }

                    var exportPath = $"{path}\\{bookName.Text}.pdf";
                    if (File.Exists(exportPath))
                    {
                        console.Items.Add("INFO: Export file exists, deleting...");
                        console.TopIndex = console.Items.Count - 1;
                        File.Delete(exportPath);
                    }

                    if (this.conv.Checked)
                    {
                        var reverse = Directory.GetFiles(path);
                        //foreach (var img in Directory.GetFiles(path))
                        foreach (var img in reverse.Reverse())
                        {
                            var imgName = Path.GetFileName(img);
                            var imgPath = Path.Combine(saveLocation.Text, bookName.Text, imgName);
                            var exportBuilder = new DocumentBuilder(export);
                            console.Items.Add($"INFO: Adding page {img} to PDF.");
                            console.TopIndex = console.Items.Count - 1;
                            exportBuilder.InsertImage(imgPath);
                            
                            console.Items.Add("Saving PDF...");
                            console.TopIndex = console.Items.Count - 1;
                            export.Save(exportPath);
                            console.Items.Add("Done!");
                            console.TopIndex = console.Items.Count - 1;
                        }
                    }
                    else
                    {
                        console.Items.Add("INFO: Convert to PDF unchecked, skipping conversion.");
                    }

                    if (rmTemp.Checked)
                    {
                        foreach (var file in Directory.GetFiles(path, "*.jpg"))
                        {
                            try
                            {
                                File.Delete(file);
                                console.Items.Add($"INFO: Deleted file {file}.");
                            }
                            catch (IOException ex)
                            {
                                console.Items.Add($"INFO: An IOException has occured: {ex.Message}");
                            }
                        }
                    }
                    else
                    {
                        console.Items.Add($"INFO: Delete temporary files unchecked, not deleting images.");
                    }

                }
            }
        }

        private void conv_CheckedChanged(object sender, EventArgs e)
        {
            this.rmTemp.Enabled = this.conv.Checked;
            if (!this.rmTemp.Enabled) { this.rmTemp.Checked = false; }
        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/RyderForReal/ActiveLearn-DL/blob/master/BASEURL.md");
        }
    }
    }