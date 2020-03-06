using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WiodySM.UI.Utilities;
using WiodySM.Data.Model.Context;
using System.Diagnostics;
using WiodySM.Data.Utilities;
using System.Data.SqlClient;

namespace WiodySM.UI.Forms.Main
{
    public partial class frmLogin : BaseForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (validationResult() == true)
            {
                var user = dbContext.User.FirstOrDefault(x => x.USER_ACCESSNAME == txtUsername.EditValue.ToString() && x.USER_ACCESSPASSWORD == txtPassword.EditValue.ToString());
                if (user != null)
                {
                    SystemActive.UserId = user.ID;
                    SystemActive.NameSurname = user.USER_NAME_SURNAME;
                    this.Hide();
                    frmMain frm = new frmMain();
                    frm.Show();
                }
                else
                {
                    XtraMessageBox.Show("Hatalı bilgi . Lütfen kullanıcı adınızı şifrenizi kontrol ediniz !");
                    txtPassword.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                    txtPassword.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                    txtUsername.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                    txtUsername.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                    txtPassword.EditValue = "";
                    txtUsername.EditValue = "";
                    txtUsername.Focus();
                }
            }

        }

        private async void frmLogin_Shown(object sender, EventArgs e)
        {
            int versionNew = 102;
            string connectionString = "Data Source = 185.248.57.239; User ID = wiody; Password = xrwatxN3MM4uEZyV; Initial Catalog = WiodyUpdate; MultipleActiveResultSets = True";
            string query = "SELECT TOP 1 * FROM[WiodySMVersion] ORDER BY ID DESC";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    List<string> list = new List<string>();
                    while (reader.Read())
                    {
                        if (Convert.ToInt32(reader["VERSION"]) != versionNew && Convert.ToBoolean(reader["REQUIRE"]) == false)
                        {
                            var messageBox = XtraMessageBox.Show("ŞU AN KULLANDIĞINIZ SÜRÜM ESKİDİR. YENİSİNE GEÇMEK İÇİN EVET'E TIKLAYINIZ !", "YENİ SÜRÜM GELMİŞTİR.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (messageBox == DialogResult.Yes)
                            {
                                ProcessStartInfo proc = new ProcessStartInfo
                                {
                                    WorkingDirectory = Application.StartupPath,
                                    FileName = "WiodySMUpdater.exe",
                                    Verb = "runas"
                                };
                                Process.Start(proc);
                                Application.Exit();
                                break;
                            }
                            else if (messageBox == DialogResult.No)
                            {
                                break;
                            }
                        }
                        else if (Convert.ToBoolean(reader["REQUIRE"]) == true && Convert.ToInt32(reader["VERSION"]) != versionNew)
                        {
                            var messageBox = XtraMessageBox.Show("ŞU AN KULLANDIĞINIZ SÜRÜM ESKİDİR. YENİSİNE GEÇMEK İÇİN EVET'E TIKLAYINIZ. AKSİ HALDE PROGRAM KAPANACAKTIR !!", "ZORUNLU SÜRÜM GÜNCELLEMESİ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (messageBox == DialogResult.Yes)
                            {
                                ProcessStartInfo proc = new ProcessStartInfo
                                {
                                    WorkingDirectory = Application.StartupPath,
                                    FileName = "WiodySMUpdater.exe",
                                    Verb = "runas"
                                };
                                Process.Start(proc);
                                Application.Exit();
                                break;
                            }
                            else if (messageBox == DialogResult.No)
                            {
                                Application.Exit();
                                break;
                            }
                        }
                        else if (Convert.ToInt32(reader["VERSION"]) == versionNew)
                        {
                            break;
                        }
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Veri Tabanı Bağlantısı Başarısız. Lütfen sistem yöneticiniz ile iletişime geçin veya daha sonra tekrar deneyin", "Hata");
                    Application.Exit();
                }
            }
            string buffer = "";
            for (int i = 0; i < versionNew.ToString().Length; i++)
            {
                buffer += versionNew.ToString()[i] + ".";
            }
            lblnumberversion.Text = buffer.Remove(5, 1);
            using (var db = new WiodySMContext())
            {
                System.Data.Common.DbConnection conn = db.Database.Connection;
                try
                {
                    await conn.OpenAsync();
                    conn.Close();
                    btnLogin.Enabled = true;
                    this.marqueeProgressBarControl1.Properties.Stopped = true;
                    lblLoading.Text = "Bağlantı Başarılı.";


                }
                catch
                {
                    this.marqueeProgressBarControl1.Properties.Stopped = true;
                    lblLoading.Text = "Bağlantı Hatası.";
                    XtraMessageBox.Show("Veri Tabanı Bağlantısı Başarısız. Lütfen sistem yöneticiniz ile iletişime geçin veya daha sonra tekrar deneyin", "Hata");
                    Application.Exit();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.WorkingDirectory = Application.StartupPath;
            proc.FileName = "WiodySMUpdater.exe";
            proc.Verb = "runas";
            Process.Start(proc);
            Application.Exit();
        }
        private bool validationResult()
        {
            bool validationRules = true;
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                txtUsername.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtUsername.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                txtUsername.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtUsername.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtPassword.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#c0392b");
                validationRules = false;
            }
            else
            {
                txtPassword.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                txtPassword.Properties.Appearance.BorderColor = ColorTranslator.FromHtml("#2ecc71");
                validationRules = true;
            }
            return validationRules;
        }
    }
}