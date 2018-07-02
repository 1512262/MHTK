using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace _1512262_YOLO_GUI_BT03
{
    public partial class YOLO : Form
    {
        public YOLO()
        {
            InitializeComponent();
        }

        private bool checkOK(string program_path)
        {

            bool darknetExist = File.Exists(program_path + "darknet.exe");
            if (darknetExist == false)
            {
                MessageBox.Show("Missing file darknet.exe", "Alert!");
                return false;
            }
            bool yolov3cfgExist = File.Exists(program_path + "tiny-yolo-mnist.cfg");
            if (yolov3cfgExist == false)
            {
                MessageBox.Show("Missing file tiny-yolo-mnist.cfg", "Alert!");
                return false;
            }
            bool yolov3weightsExist = File.Exists(program_path + "tiny-yolo-mnist_500000.weights"); ;
            if (yolov3weightsExist == false)
            {
                MessageBox.Show("Missing file tiny-yolo-mnist_500000.weights", "Alert!");
                return false;
            }
            bool cocodataExist = File.Exists(program_path + "\\cfg\\voc-mnist.data");
            if (cocodataExist == false)
            {
                MessageBox.Show("Missing file cfg/voc-mnist.data", "Alert!");
                return false;
            }
            bool pthreadVC2Exist = File.Exists(program_path + "pthreadVC2.dll");
            if (pthreadVC2Exist == false)
            {
                MessageBox.Show("Missing file pthreadVC2.dll", "Alert!");
                return false;
            }
            bool pthreadGC2Exist = File.Exists(program_path + "pthreadGC2.dll");
            if (pthreadGC2Exist == false)
            {
                MessageBox.Show("Missing file pthreadGC2.dll", "Alert!");
                return false;
            }
            if (this.ptx_beforeYOLO.Image == null)
            {
                MessageBox.Show("Missing picture file", "Alert!");
                return false;
            }
            return true;
        }

        string img_path = "";
        string program_path = "";
        string command = "darknet detector test cfg/voc-mnist.data tiny-yolo-mnist.cfg tiny-yolo-mnist_500000.weights -dont_show ";
        string res_part = " > result.txt";
        private void btn_LoadImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image file|*.jpg";
            openFileDialog.Title = "Select image file for detection";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.img_path = openFileDialog.FileName;
                this.ptx_beforeYOLO.Image = Image.FromFile(img_path);
            }
        }

        private void btn_Predict_Click(object sender, EventArgs e)
        {
            program_path = AppDomain.CurrentDomain.BaseDirectory;
            if (checkOK(program_path))
            {
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.UseShellExecute = false;
                process.Start();
                process.StandardInput.WriteLine(command + img_path + res_part);
                process.StandardInput.Flush();
                process.StandardInput.Close();
                string res = process.StandardOutput.ReadToEnd();

                if (res != null)
                {
                    ptx_afterYOLO.Image = Image.FromFile("predictions.jpg");
                    string[] lines = System.IO.File.ReadAllLines(@"result.txt");

                    int i;
                    for (i = 0; i < lines.Length; i++)
                    {
                        if (lines[i].Contains("Predicted") == true)
                            break;
                    }
                    for (int j = i + 1; j < lines.Length; j++)
                    {
                        txt_Prediction.Text += lines[j] + "\r\n";
                    }

                }


            }

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ptx_beforeYOLO.Image = null;
            ptx_beforeYOLO.Invalidate();
            ptx_afterYOLO.Image = null;
            ptx_afterYOLO.Invalidate();
            txt_Prediction.Text = null;
            txt_Prediction.Invalidate();

            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            if (File.Exists("predictions.jpg") == true)
                File.Delete("predictions.jpg");
            if (File.Exists("result.txt") == true)
                File.Delete("result.txt");



        }

        private void btn_loadFullImg_afterYOLO_Click(object sender, EventArgs e)
        {
            if (ptx_afterYOLO.Image != null)
            {
                Process.Start("predictions.jpg");
            }
            else
                MessageBox.Show("No prediction file", "Alert!");
        }

        private void btn_loadFullImg_beforeYOLO_Click(object sender, EventArgs e)
        {
            if (ptx_beforeYOLO.Image != null)
            {
                Process.Start(img_path);
            }
            else
                MessageBox.Show("No input file", "Alert!");
        }
    }
}
