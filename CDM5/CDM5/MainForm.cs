/*
 * Created by SharpDevelop.
 * User: Lioner
 * Date: 11/08/2021
 * Time: 12:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using System.IO;

namespace CDM5
{ 
	public partial class MainForm : Form
	{
		public MainForm(){InitializeComponent();}
		public string cifrar(string x, string y) 
		   {
                byte[] A; 
                byte[] B = UTF8Encoding.UTF8.GetBytes(x); 
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                A = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(y));
                md5.Clear();
                TripleDESCryptoServiceProvider tripledes = new TripleDESCryptoServiceProvider();
                tripledes.Key = A;
                tripledes.Mode = CipherMode.ECB;
                tripledes.Padding = PaddingMode.PKCS7;
                ICryptoTransform T = tripledes.CreateEncryptor(); 
                byte[] C = T.TransformFinalBlock(B, 0, B.Length); 
                tripledes.Clear();
                return Convert.ToBase64String(C, 0, C.Length); 
            }
		public string descifrar(string x, string y) 
            {
                byte[] A;
                byte[] B = Convert.FromBase64String(x); 
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                A = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(y));
                md5.Clear();
                TripleDESCryptoServiceProvider tripledes = new TripleDESCryptoServiceProvider();
                tripledes.Key = A;
                tripledes.Mode = CipherMode.ECB;
                tripledes.Padding = PaddingMode.PKCS7;
                ICryptoTransform T = tripledes.CreateDecryptor();
                byte[] C = T.TransformFinalBlock(B, 0, B.Length);
                tripledes.Clear();
                string D = UTF8Encoding.UTF8.GetString(C); 
                return D; 
            }
		void CifrarClick(object sender, EventArgs e)
		{
			try{MessageBox.Show(cifrar(richTextBox1.Text,textBox2.Text));}
			catch(Exception){MessageBox.Show("La Clave o la Cadena a trabajar es incorrecta");}
			
		}
		void Button3Click(object sender, EventArgs e)
		{
			try{MessageBox.Show(descifrar(richTextBox1.Text,textBox2.Text));}
			catch(Exception){MessageBox.Show("La Clave o la Cadena a trabajar es incorrecta");}
		}
		void GenerarCClick(object sender, EventArgs e)
		{
			try{
			string R = descifrar("9MUi7Z7Whl98n0+MjsYdEA==","og3MvBDd1/hTy85TKw5csA==");
			File.WriteAllText("Cifrado.txt",cifrar(richTextBox1.Text,textBox2.Text)+"\n\n\n\n\nClave: "+cifrar(textBox2.Text,R));}
			catch(Exception){MessageBox.Show("La Clave o la Cadena a trabajar es incorrecta");}
		}
		void Button4Click(object sender, EventArgs e)
		{   
			try{
			string R = descifrar("9MUi7Z7Whl98n0+MjsYdEA==","og3MvBDd1/hTy85TKw5csA==");
			File.WriteAllText("Descifrado.txt",descifrar(richTextBox1.Text,textBox2.Text)+"\n\n\n\n\nClave: "+cifrar(textBox2.Text,R));}
			catch(Exception){MessageBox.Show("La Clave o la Cadena a trabajar es incorrecta");}
		}
	}
}
