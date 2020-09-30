using NReco.VideoConverter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNet_Converter
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBox2.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem == ".ac3")
                {
                    var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
                    ffMpeg.ConvertMedia(openFileDialog1.FileName, folderBrowserDialog1.SelectedPath + "\\" + System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.SafeFileName) + " - Converted by .NET Converter.ac3", Format.ac3);
                }
                if (comboBox1.SelectedItem == ".aiff")
                {
                    var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
                    ffMpeg.ConvertMedia(openFileDialog1.FileName, folderBrowserDialog1.SelectedPath + "\\" + System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.SafeFileName) + " - Converted by .NET Converter.aiff", Format.aiff);
                }
                if (comboBox1.SelectedItem == ".alaw")
                {
                    var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
                    ffMpeg.ConvertMedia(openFileDialog1.FileName, folderBrowserDialog1.SelectedPath + "\\" + System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.SafeFileName) + " - Converted by .NET Converter.alaw", Format.alaw);
                }
                if (comboBox1.SelectedItem == ".asf")
                {
                    var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
                    ffMpeg.ConvertMedia(openFileDialog1.FileName, folderBrowserDialog1.SelectedPath + "\\" + System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.SafeFileName) + " - Converted by .NET Converter.asf", Format.asf);
                }
                if (comboBox1.SelectedItem == ".ast")
                {
                    var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
                    ffMpeg.ConvertMedia(openFileDialog1.FileName, folderBrowserDialog1.SelectedPath + "\\" + System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.SafeFileName) + " - Converted by .NET Converter.ast", Format.ast);
                }
                if (comboBox1.SelectedItem == ".au")
                {
                    var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
                    ffMpeg.ConvertMedia(openFileDialog1.FileName, folderBrowserDialog1.SelectedPath + "\\" + System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.SafeFileName) + " - Converted by .NET Converter.au", Format.au);
                }
                if (comboBox1.SelectedItem == ".avi")
                {
                    var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
                    ffMpeg.ConvertMedia(openFileDialog1.FileName, folderBrowserDialog1.SelectedPath + "\\" + System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.SafeFileName) + " - Converted by .NET Converter.avi", Format.avi);
                }
                if (comboBox1.SelectedItem == ".vaf")
                {
                    var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
                    ffMpeg.ConvertMedia(openFileDialog1.FileName, folderBrowserDialog1.SelectedPath + "\\" + System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.SafeFileName) + " - Converted by .NET Converter.caf", Format.caf);
                }
                if (comboBox1.SelectedItem == ".dts")
                {
                    var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
                    ffMpeg.ConvertMedia(openFileDialog1.FileName, folderBrowserDialog1.SelectedPath + "\\" + System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.SafeFileName) + " - Converted by .NET Converter.dts", Format.dts);
                }
                if (comboBox1.SelectedItem == ".eac3")
                {
                    var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
                    ffMpeg.ConvertMedia(openFileDialog1.FileName, folderBrowserDialog1.SelectedPath + "\\" + System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.SafeFileName) + " - Converted by .NET Converter.eac3", Format.eac3);
                }
                if (comboBox1.SelectedItem == ".ffm")
                {
                    var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
                    ffMpeg.ConvertMedia(openFileDialog1.FileName, folderBrowserDialog1.SelectedPath + "\\" + System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.SafeFileName) + " - Converted by .NET Converter.ffm", Format.ffm);
                }
                if (comboBox1.SelectedItem == ".flac")
                {
                    var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
                    ffMpeg.ConvertMedia(openFileDialog1.FileName, folderBrowserDialog1.SelectedPath + "\\" + System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.SafeFileName) + " - Converted by .NET Converter.flac", Format.flac);
                }
                if (comboBox1.SelectedItem == ".flv")
                {
                    var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
                    ffMpeg.ConvertMedia(openFileDialog1.FileName, folderBrowserDialog1.SelectedPath + "\\" + System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.SafeFileName) + " - Converted by .NET Converter.flv", Format.flv);
                }
                if (comboBox1.SelectedItem == ".gif")
                {
                    var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
                    ffMpeg.ConvertMedia(openFileDialog1.FileName, folderBrowserDialog1.SelectedPath + "\\" + System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.SafeFileName) + " - Converted by .NET Converter.gif", Format.gif);
                }
                if (comboBox1.SelectedItem == ".m4v")
                {
                    var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
                    ffMpeg.ConvertMedia(openFileDialog1.FileName, folderBrowserDialog1.SelectedPath + "\\" + System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.SafeFileName) + " - Converted by .NET Converter.m4v", Format.m4v);
                }
                if (comboBox1.SelectedItem == ".matroska")
                {
                    var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
                    ffMpeg.ConvertMedia(openFileDialog1.FileName, folderBrowserDialog1.SelectedPath + "\\" + System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.SafeFileName) + " - Converted by .NET Converter.matroska", Format.matroska);
                }
                if (comboBox1.SelectedItem == ".mjpeg")
                {
                    var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
                    ffMpeg.ConvertMedia(openFileDialog1.FileName, folderBrowserDialog1.SelectedPath + "\\" + System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.SafeFileName) + " - Converted by .NET Converter.mjpeg", Format.mjpeg);
                }
                if (comboBox1.SelectedItem == ".mov")
                {
                    var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
                    ffMpeg.ConvertMedia(openFileDialog1.FileName, folderBrowserDialog1.SelectedPath + "\\" + System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.SafeFileName) + " - Converted by .NET Converter.mov", Format.mov);
                }
                if (comboBox1.SelectedItem == ".mp4")
                {
                    var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
                    ffMpeg.ConvertMedia(openFileDialog1.FileName, folderBrowserDialog1.SelectedPath + "\\" + System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.SafeFileName) + " - Converted by .NET Converter.mp4", Format.mp4);
                }
                if (comboBox1.SelectedItem == ".mpeg")
                {
                    var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
                    ffMpeg.ConvertMedia(openFileDialog1.FileName, folderBrowserDialog1.SelectedPath + "\\" + System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.SafeFileName) + " - Converted by .NET Converter.mpeg", Format.mpeg);
                }
                if (comboBox1.SelectedItem == ".mulaw")
                {
                    var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
                    ffMpeg.ConvertMedia(openFileDialog1.FileName, folderBrowserDialog1.SelectedPath + "\\" + System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.SafeFileName) + " - Converted by .NET Converter.mulaw", Format.mulaw);
                }
                if (comboBox1.SelectedItem == ".ogg")
                {
                    var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
                    ffMpeg.ConvertMedia(openFileDialog1.FileName, folderBrowserDialog1.SelectedPath + "\\" + System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.SafeFileName) + " - Converted by .NET Converter.ogg", Format.ogg);
                }
                if (comboBox1.SelectedItem == ".oma")
                {
                    var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
                    ffMpeg.ConvertMedia(openFileDialog1.FileName, folderBrowserDialog1.SelectedPath + "\\" + System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.SafeFileName) + " - Converted by .NET Converter.oma", Format.oma);
                }
                if (comboBox1.SelectedItem == ".rm")
                {
                    var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
                    ffMpeg.ConvertMedia(openFileDialog1.FileName, folderBrowserDialog1.SelectedPath + "\\" + System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.SafeFileName) + " - Converted by .NET Converter.rm", Format.rm);
                }
                if (comboBox1.SelectedItem == ".swf")
                {
                    var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
                    ffMpeg.ConvertMedia(openFileDialog1.FileName, folderBrowserDialog1.SelectedPath + "\\" + System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.SafeFileName) + " - Converted by .NET Converter.swf", Format.swf);
                }
                if (comboBox1.SelectedItem == ".webm")
                {
                    var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
                    ffMpeg.ConvertMedia(openFileDialog1.FileName, folderBrowserDialog1.SelectedPath + "\\" + System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.SafeFileName) + " - Converted by .NET Converter.webm", Format.webm);
                }
                if (comboBox1.SelectedItem == ".wmv")
                {
                    var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
                    ffMpeg.ConvertMedia(openFileDialog1.FileName, folderBrowserDialog1.SelectedPath + "\\" + System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.SafeFileName) + " - Converted by .NET Converter.wmv", Format.wmv);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), error.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                button3.Enabled = false;
            }
            else
            {
                if (textBox2.Text == string.Empty)
                {
                    button3.Enabled = false;
                }
                else
                {
                    if (comboBox1.SelectedIndex == -1)
                    {
                        button3.Enabled = false;
                    }
                    else
                    {
                        button3.Enabled = true;
                    }
                }
            }
        }
    }
}
