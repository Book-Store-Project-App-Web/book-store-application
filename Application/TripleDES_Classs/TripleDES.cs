using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace TripleDES_Classs
{
    public class TripleDES
    {
        //Khai báo khóa(KEY)
        private byte[] key;
        //Khai báo vector(IV)
        private byte[] iv;

        TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider();

        public TripleDES()
        {
            //Tạo key bằng 24 ký tự bắt kỳ (càng khóc đọc càng tốt)
            key = System.Text.UnicodeEncoding.UTF8.GetBytes("3#@!@#%!'>;sdf2^(*sfd>:,");
            //Tạo Intialization Vector (IV) bằng 8 ký tự bất kỳ
            iv = System.Text.UnicodeEncoding.UTF8.GetBytes("asd,;$^7");
            //Khởi tạo đối tượng mã hóa Data Encryption Standad(DES)
        }
        public TripleDES(string _key, string _iv)
        {
            key = System.Text.UnicodeEncoding.UTF8.GetBytes(_key);
            iv = System.Text.UnicodeEncoding.UTF8.GetBytes(_iv);
        }

        //Hàm mã hóa
        public string EnCrypt(string strToEnCrypt)
        {
            byte[] input = System.Text.UnicodeEncoding.UTF8.GetBytes(strToEnCrypt);
            MemoryStream output = new MemoryStream();
            CryptoStream objCryptoStream = new CryptoStream(output, DES.CreateDecryptor(), CryptoStreamMode.Write);
            objCryptoStream.Write(input, 0, input.Length);
            objCryptoStream.FlushFinalBlock();
            return Convert.ToBase64String(output.ToArray());
        }

        public string Decrypt(string strToDeCrypt)
        {
            byte[] input = Convert.FromBase64String(strToDeCrypt);
            MemoryStream output = new MemoryStream();
            CryptoStream objCryptoStream = new CryptoStream(output, DES.CreateDecryptor(), CryptoStreamMode.Write);
            objCryptoStream.Write(input, 0, input.Length);
            objCryptoStream.FlushFinalBlock();
            return System.Text.UnicodeEncoding.UTF8.GetString(output.ToArray());
        }

    }
}
