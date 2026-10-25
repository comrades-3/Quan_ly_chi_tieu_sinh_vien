using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_chi_tieu_sinh_vien
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (true)
            {
                using (FrmDangNhap frmLogin = new FrmDangNhap())
                {
                    if (frmLogin.ShowDialog() != DialogResult.OK)
                    {
                        break;
                    }
                }

                using (FrmDashboard frmMain = new FrmDashboard())
                {
                    Application.Run(frmMain);
                    if (!frmMain.IsDangXuat)
                    {
                        break;
                    }
                }
            }
        }
    }
}
