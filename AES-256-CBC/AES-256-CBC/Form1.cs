using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Xml;

namespace AES_256_CBC
{
    public partial class Form1 : Form
    {
        //32byte
        static string aes_key = "01234567890123456789012345678901"; 
        //16byte
        static string aes_iv = aes_key.Substring(0, 16);
        string _txt = @"<Request>
  <Request-Data>
    <Method>GET</Method>
    <URL>https://www.naver.com</URL>
    <Cookie>
    </Cookie>
    <Msg>
    </Msg>
  </Request-Data>
</Request>";
        string _en_str;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEc_Click(object sender, EventArgs e)
        {
            // XML 파일 읽어서 암호화
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(@"C:\TEMP\test.xml");

            XmlNode root = xdoc.DocumentElement;

            _txt = root.OuterXml;
            _en_str = EncryptAES(_txt);
            MessageBox.Show(_en_str);
        }

        public string EncryptAES(string input)
        {
            byte[] encrypted;

            using(AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
            {
                aes.KeySize = 256;
                aes.BlockSize = 128;

                // 키와 iv를 평문이 아닌 base64로 남긴다면
                // Convert.FromBase64String() >> Base64문자열을 string으로 바꿔주는 함수
                //aes.Key = Convert.FromBase64String(aes_key);
                //aes.IV = Convert.FromBase64String(aes_iv);


                // Encoding.UTF8.GetBytes() >> String을 Byte로 바꿔주는 함수
                aes.Key = Encoding.UTF8.GetBytes(aes_key);
                aes.IV = Encoding.UTF8.GetBytes(aes_iv);
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                // 암호문을 만들 수 있는 객체 enc 선언
                ICryptoTransform enc = aes.CreateEncryptor(aes.Key, aes.IV);
                

                using(MemoryStream ms = new MemoryStream())
                {
                    using(CryptoStream cs = new CryptoStream(ms, enc, CryptoStreamMode.Write))
                    {
                        using(StreamWriter sw = new StreamWriter(cs))
                        {
                            sw.Write(input);
                        }
                        encrypted = ms.ToArray();
                    }
                }
            }

            // base64로 반환하길 원한다면
            return Convert.ToBase64String(encrypted);

            //string으로 반환하길 원한다면
            //return Encoding.Default.GetString(encrypted);
        }

        public string DecryptAES(string encryptedText)
        {
            string decrypted = null;
            byte[] cipher = Convert.FromBase64String(encryptedText);

            using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
            {
                aes.KeySize = 256;
                aes.BlockSize = 128;
                aes.Key = Encoding.UTF8.GetBytes(aes_key);
                aes.IV = Encoding.UTF8.GetBytes(aes_iv);
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                // 복호문을 만들 수 있는 dec 객체 선언
                ICryptoTransform dec = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream ms = new MemoryStream(cipher))
                {
                    using (CryptoStream cs = new CryptoStream(ms, dec, CryptoStreamMode.Read))
                    {
                        using (StreamReader sr = new StreamReader(cs))
                        {
                            decrypted = sr.ReadToEnd();
                        }
                    }
                }
            }
            return decrypted;
        }

        private void btnDc_Click(object sender, EventArgs e)
        {
            string str = DecryptAES(_en_str);
            MessageBox.Show(str);
        }
    }
}
