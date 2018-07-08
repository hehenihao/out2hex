using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace O2H
{
    public partial class Form1 : Form
    {
        private string hexFileDir = string.Empty;
        public Form1()
        {
            InitializeComponent();
            outLabel.DragEnter += OutLabel_DragEnter;
            outLabel.DragDrop += OutLabel_DragDrop;
            outLabel.DragLeave += OutLabel_DragLeave;

            hexLabel.DragEnter += HexLabel_DragEnter;
            hexLabel.DragDrop += HexLabel_DragDrop;
            hexLabel.MouseDown += HexLabel_MouseDown;
            hexLabel.MouseUp += HexLabel_MouseUp;

            hexName.LostFocus += HexName_LostFocus1;
        }

        private void HexName_LostFocus1(object sender, EventArgs e)
        {
            Console.WriteLine("lose focus");
        }

        private void HexLabel_MouseUp(object sender, MouseEventArgs e)
        {
            Console.WriteLine("up");
            // File.Copy()
        }

        private void HexLabel_DragDrop(object sender, DragEventArgs e)
        {
            // string data = e.Data.GetData(DataFormats.Text).ToString();
            string fileName = (e.Data.GetData(DataFormats.FileDrop, false) as string[])[0];
            Console.WriteLine(fileName);
        }

        private void HexLabel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void HexLabel_MouseDown(object sender, MouseEventArgs e)
        {
            Label lb = (Label)sender;
            this.Cursor = Cursors.IBeam;
            if (lb.Text != "HEX")
            {
                Console.WriteLine(Path.GetTempPath() + hexName.Text + ".hex");
                File.Delete(Path.GetTempPath() + @"\" + hexName.Text + ".hex");
                File.Copy(hexFileDir, Path.GetTempPath() + hexName.Text + ".hex");
                string[] files = new string[] { Path.GetTempPath() + hexName.Text + ".hex" };
                hexLabel.DoDragDrop(new DataObject(DataFormats.FileDrop, files),
                  DragDropEffects.Copy);
                File.Delete(Path.GetTempPath() + @"\" + hexName.Text + ".hex");
                // hexLabel.DoDragDrop(hexFileDir, DragDropEffects.Copy);
            }
        }

        private void HexName_LostFocus(object sender, EventArgs e)
        {
            TextBox TB = (TextBox)sender;
            TB.BorderStyle = BorderStyle.None;
        }

        private void HexName_Enter(object sender, EventArgs e)
        {
            TextBox TB = (TextBox)sender;
            TB.BorderStyle = BorderStyle.Fixed3D;
        }

        private void OutLabel_DragLeave(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OutLabel_DragDrop(object sender, DragEventArgs e)
        {
            string fileName = (e.Data.GetData(DataFormats.FileDrop, false) as string[])[0];
            if (fileName.EndsWith(".out"))
            {
                Console.WriteLine(fileName);
                Label lb = (Label)sender;
                lb.Image = O2H.Properties.Resources.outImg;
                lb.Text = "";
                outName.Text = fileName.Split('\\').Last().Replace(".out", "");
                hexName.Text = outName.Text;
                hexFileDir = fileName.Replace(".out", ".hex");
                processOut(fileName);
            }
            else
            {
                Label lb = (Label)sender;
                lb.Image = null;
                lb.Text = "OUT";
                outName.Text = "拖入文件";
                hexLabel.Image = null;
                hexLabel.Text = "HEX";
                hexName.Text = "修改名称";
                hexFileDir = string.Empty;
            }
        }

        private void OutLabel_DragEnter(object sender, DragEventArgs e)
        {
            string fileName = (e.Data.GetData(DataFormats.FileDrop, false) as string[])[0];
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {

                e.Effect = DragDropEffects.Copy;
            }
            else
                e.Effect = DragDropEffects.None;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void processOut(string fileName)
        {
            hexLabel.Text = "";
            hexLabel.Image = Properties.Resources.hexImg;
            Process myProcess = new Process();
            myProcess.Exited += MyProcess_Exited;
            try
            {
                myProcess.StartInfo.UseShellExecute = false;
                myProcess.StartInfo.FileName = Environment.CurrentDirectory + @"\hex2000.exe";
                myProcess.StartInfo.Arguments = fileName + " -o " + hexFileDir;
                myProcess.StartInfo.CreateNoWindow = true;
                myProcess.Start();
                myProcess.WaitForExit(3000);
                File.Delete(fileName.Replace(".out", ".x01"));
                File.Delete(fileName.Replace(".out", ".x02"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        private void MyProcess_Exited(object sender, EventArgs e)
        {
            Console.WriteLine("hehehe");
        }
    }
}
