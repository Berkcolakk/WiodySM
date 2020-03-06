using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WiodySM.Updater
{
    public partial class frmUpdater : Form
    {
        private string destPath = Application.StartupPath + "\\update.zip"; 
        private string GuncelDosya = "https://smupdate.wiody.com/update.zip"; 
        private string DosyaAdi;
        public frmUpdater()
        {
            InitializeComponent();
        }

        private void frmUpdater_Load(object sender, EventArgs e)
        {
            tmrUpdate.Start();
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            tmrUpdate.Enabled = false;
            if (System.IO.File.Exists(Application.StartupPath + "\\update.zip"))
            {
                System.IO.File.Delete(Application.StartupPath + "\\update.zip");
            }
            WebClient webClient = new WebClient(); 
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed); 
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            webClient.DownloadFileAsync(new Uri(GuncelDosya), destPath); 
        }
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBarControl1.EditValue= e.ProgressPercentage; 
            lblStatus.Text = DosyaAdi + " (%" + e.ProgressPercentage.ToString() + ")"; 
        }

        private void Completed(object sender, AsyncCompletedEventArgs e) 
        {
            lblStatus.Text = "İndirme Tamamlandı";
            lblStatus.Text = "Dosyalar Güncelleniyor";
            using (ZipFile zip = ZipFile.Read(destPath))
            {
                foreach (ZipEntry zipEnt in zip)
                {
                    zipEnt.Extract(Application.StartupPath, ExtractExistingFileAction.OverwriteSilently);
                }
            }
            lblStatus.Text = "Güncelleme Tamamlandı";
            Process.Start(Application.StartupPath + "\\OskarNET.exe");
            Application.Exit();
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }
    }
}
