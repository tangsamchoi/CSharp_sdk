using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tencent.YoutuYun.Common;

namespace WindowsFormsApplication_Sample
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 设置为你自己的密钥对
            string appid = "1000031";
            string secretId = "AKIDUIDlPDt5mZutfr46NT0GisFcQh1nMOox";
            string secretKey = "ind5yAd55ZspBc7MCANcxEjuXi8YU8RL";
            string userid = "380549494";

            Conf.Instance().setAppInfo(appid, secretId, secretKey, userid, Conf.Instance().YOUTU_END_POINT);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
