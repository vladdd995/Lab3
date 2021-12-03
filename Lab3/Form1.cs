using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        byte[] arrAfterXOR;
        bool flag = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void XOR_Click(object sender, EventArgs e)
        {
            if (K_encrypt.Text == "")
            {
                encrypt.Text = P_encrypt.Text;
                P_decrypt.Text = P_encrypt.Text;
                decrypt.Text = P_encrypt.Text;
            }
            else
            {
                string cipher = myCipher(P_encrypt, K_encrypt, encrypt);
                P_decrypt.Text = encrypt.Text;
                Key_decrypt.Text = K_encrypt.Text;
                myCipher(P_decrypt, Key_decrypt, decrypt, cipher);
            }
        }

        private void myShowToolTip(TextBox tB, byte[] arr)
        {
            string[] b = arr.Select(x => Convert.ToString(x, 2).PadLeft(8, '0')).ToArray();
            string hexValues = string.Join(" ", b);
            toolTip.SetToolTip(tB, hexValues);
        }

        private byte[] myXOR(byte[] arr_text, byte[] arr_key)
        {
            int len_text = arr_text.Length;
            int len_key = arr_key.Length;
            byte[] arr_cipher = new byte[len_text];
            for (int i = 0; i < len_text; i++)
            {
                byte p = arr_text[i];
                byte k = arr_key[i % len_key];
                byte c = (byte)(p ^ k);

                arr_cipher[i] = c;
            }
            return arr_cipher;
        }

        private string myCipher(TextBox tb_text, TextBox tb_Key, TextBox tb_cipher, string cipher = "")
        {
            string text = tb_text.Text;
            byte[] arr_text;
            if (flag == false)
            {
                arr_text = Encoding.UTF32.GetBytes(text);
                flag = true;
            }
            else
            {
                arr_text = arrAfterXOR;
                flag = false;
            }

            myShowToolTip(tb_text, arr_text);

            string key = tb_Key.Text;
            byte[] arr_key = Encoding.UTF32.GetBytes(key);
            BitArray array_key = new BitArray(Encoding.UTF8.GetBytes(key));
            myShowToolTip(tb_Key, arr_key);

            byte[] arr_cipher = myXOR(arr_text, arr_key);

            cipher = Encoding.UTF32.GetString(arr_cipher);
            tb_cipher.Text = cipher;
            BitArray cipherr = new BitArray(Encoding.UTF8.GetBytes(cipher));
            myShowToolTip(tb_cipher, arr_cipher);
            arrAfterXOR = arr_cipher;

            return cipher;
        }

        private void clean_Click(object sender, EventArgs e)
        {
            P_encrypt.Text = "";
            K_encrypt.Text = "";
            encrypt.Text = "";

            P_decrypt.Text = "";
            Key_decrypt.Text = "";
            decrypt.Text = "";
        }
    }
}
