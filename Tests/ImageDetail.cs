using NK_TEST.Tests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NK_TEST.Users
{
    public partial class ImageDetail : Form
    {


        public ImageDetail(int image_id)
        {
            InitializeComponent();

            // Запустить в отдельном потоке
            if (bwDownloadImage.IsBusy != true) bwDownloadImage.RunWorkerAsync();
            TestDB.Images obj = new TestDB.Images(image_id);
            tbName.Text = obj.name;
            pbImage.Image = ConvertBinToImage(obj.image_obj);
            tbComment.Text = obj.comment;
            bwDownloadImage.CancelAsync();


        }

        public Image ConvertBinToImage(byte[] image_bin)
        { 
            MemoryStream ms_image = new MemoryStream(image_bin, 0, image_bin.Length);
            
            return Image.FromStream(ms_image);
 
        }

        private void bwDownloadImage_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            //test.Save();

            for (int i = 1; i <= 10; i++) // 0..90%
            {

                if (worker.CancellationPending == true)
                {
                    worker.ReportProgress(100); // полная загрузка
                }

                worker.ReportProgress(i * 10);
                System.Threading.Thread.Sleep(50);

            }
        }

        private void bwDownloadImage_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressLoadImage.Value = e.ProgressPercentage;
        }

        private void bwDownloadImage_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
