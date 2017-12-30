using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double [] amPreset = new double[5] { 1, 2, 3, 4, 5 };
        double [] fmPreset = new double[5] { 1, 2, 3, 4, 5 };
        string radioStation = "540";
        int lastPressed = 0;
        bool setPressed = false;

        private void onOffButton_Click(object sender, EventArgs e)
        {
            if(onOffButton.Text == "Off")
            {
                onOffButton.Text = "On";
                onOffButton.BackColor = Color.GreenYellow;
                amFmBtn.Enabled = true;
                VolgroupBox.Enabled = true;
                PresetgroupBox.Enabled = true;
                tuneUpBtn.Enabled = true;
                tuneDownBtn.Enabled = true;

                if (fmStereoBtn.Checked && onOffButton.Text == "On")
                {
                    timeRadioLbl.Text = radioStation + " FM Stereo";
                }
                else if(!fmStereoBtn.Checked)
                {
                    timeRadioLbl.Text = radioStation + " " + amFmBtn.Text;
                }
            }
            else if (onOffButton.Text == "On")
            {
                onOffButton.Text = "Off";
                onOffButton.BackColor = Color.Empty;
                timeRadioLbl.Text = DateTime.Now.ToString("h:mm:ss tt");
                fmStereoBtn.Enabled = false;
                fmStereoBtn.BackColor = Color.Empty;
                amFmBtn.Enabled = false;
                VolgroupBox.Enabled = false;
                PresetgroupBox.Enabled = false;
                tuneUpBtn.Enabled = false;
                tuneDownBtn.Enabled = false;
            }
        }

        private void amFmBtn_Click(object sender, EventArgs e)
        {
            if(amFmBtn.Text == "AM")
            {
                amFmBtn.Text = "FM";
                radioStation = "87.5";
                fmStereoBtn.Enabled = true;
            }
            else if (amFmBtn.Text == "FM")
            {
                amFmBtn.Text = "AM";
                fmStereoBtn.Checked = false;
                radioStation = "540";
                fmStereoBtn.Enabled = false;
            }
            
            if (fmStereoBtn.Checked)
            {
                timeRadioLbl.Text = radioStation + " " + amFmBtn.Text + " Stereo";
            }
            else if (!fmStereoBtn.Checked)
            {
                timeRadioLbl.Text = radioStation + " " + amFmBtn.Text;
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            timeRadioLbl.Text = DateTime.Now.ToString("h:mm:ss tt");
            amFmBtn.Enabled = false;
            VolgroupBox.Enabled = false;
            PresetgroupBox.Enabled = false;
            timeRadioLbl.ForeColor = Color.Red;
            tuneUpBtn.Enabled = false;
            tuneDownBtn.Enabled = false;
            amFmBtn.Text = "FM";
            fmStereoBtn.Checked = true;
            radioStation = "95.5";
        }

        private void fmStereoBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (fmStereoBtn.Checked && onOffButton.Text == "On")
            {
                timeRadioLbl.Text = radioStation + " FM Stereo";                
            }
            else if (!fmStereoBtn.Checked && onOffButton.Text == "On")
            {
                timeRadioLbl.Text = radioStation + " " + amFmBtn.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (setPressed)
            {
                setPressed = false;

                if (amFmBtn.Text == "AM")
                {
                    if (amFmBtn.Text == "AM")
                    {
                        amPreset[0] = Convert.ToDouble(radioStation);
                    }
                    else if (amFmBtn.Text == "FM")
                    {
                        fmPreset[0] = Convert.ToDouble(radioStation);
                    }
                }
                else if (amFmBtn.Text == "FM")
                {
                    radioStation = Convert.ToString(fmPreset[0]);
                }
                fmStereoBtn.Enabled = true;
                amFmBtn.Enabled = true;
                VolgroupBox.Enabled = true;
            }
            else
            {
                if (amFmBtn.Text == "AM")
                {
                    radioStation = Convert.ToString(amPreset[0]);
                }
                else if (amFmBtn.Text == "FM")
                {
                    radioStation = Convert.ToString(fmPreset[0]);
                }
            }

            lastPressed = 0;
            if (fmStereoBtn.Checked)
            {
                timeRadioLbl.Text = radioStation + " " + amFmBtn.Text + " Stereo";
            }
            else if (!fmStereoBtn.Checked)
            {
                timeRadioLbl.Text = radioStation + " " + amFmBtn.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (setPressed)
            {
                setPressed = false;

                if (amFmBtn.Text == "AM")
                {
                    if (amFmBtn.Text == "AM")
                    {
                        amPreset[1] = Convert.ToDouble(radioStation);
                    }
                    else if (amFmBtn.Text == "FM")
                    {
                        fmPreset[1] = Convert.ToDouble(radioStation);
                    }
                }
                else if (amFmBtn.Text == "FM")
                {
                    radioStation = Convert.ToString(fmPreset[0]);
                }
                fmStereoBtn.Enabled = true;
                amFmBtn.Enabled = true;
                VolgroupBox.Enabled = true;
            }
            else
            {
                if (amFmBtn.Text == "AM")
                {
                    radioStation = Convert.ToString(amPreset[1]);
                }
                else if (amFmBtn.Text == "FM")
                {
                    radioStation = Convert.ToString(fmPreset[1]);
                }
            }

            lastPressed = 1;
            if (fmStereoBtn.Checked)
            {
                timeRadioLbl.Text = radioStation + " " + amFmBtn.Text + " Stereo";
            }
            else if (!fmStereoBtn.Checked)
            {
                timeRadioLbl.Text = radioStation + " " + amFmBtn.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (setPressed)
            {
                setPressed = false;

                if (amFmBtn.Text == "AM")
                {
                    if (amFmBtn.Text == "AM")
                    {
                        amPreset[2] = Convert.ToDouble(radioStation);
                    }
                    else if (amFmBtn.Text == "FM")
                    {
                        fmPreset[2] = Convert.ToDouble(radioStation);
                    }
                }
                else if (amFmBtn.Text == "FM")
                {
                    radioStation = Convert.ToString(fmPreset[2]);
                }
                fmStereoBtn.Enabled = true;
                amFmBtn.Enabled = true;
                VolgroupBox.Enabled = true;
            }
            else
            {
                if (amFmBtn.Text == "AM")
                {
                    radioStation = Convert.ToString(amPreset[2]);
                }
                else if (amFmBtn.Text == "FM")
                {
                    radioStation = Convert.ToString(fmPreset[2]);
                }
            }

            lastPressed = 2;
            if (fmStereoBtn.Checked)
            {
                timeRadioLbl.Text = radioStation + " " + amFmBtn.Text + " Stereo";
            }
            else if (!fmStereoBtn.Checked)
            {
                timeRadioLbl.Text = radioStation + " " + amFmBtn.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (setPressed)
            {
                setPressed = false;

                if (amFmBtn.Text == "AM")
                {
                    if (amFmBtn.Text == "AM")
                    {
                        amPreset[3] = Convert.ToDouble(radioStation);
                    }
                    else if (amFmBtn.Text == "FM")
                    {
                        fmPreset[3] = Convert.ToDouble(radioStation);
                    }
                }
                else if (amFmBtn.Text == "FM")
                {
                    radioStation = Convert.ToString(fmPreset[3]);
                }
                fmStereoBtn.Enabled = true;
                amFmBtn.Enabled = true;
                VolgroupBox.Enabled = true;
            }
            else
            {
                if (amFmBtn.Text == "AM")
                {
                    radioStation = Convert.ToString(amPreset[3]);
                }
                else if (amFmBtn.Text == "FM")
                {
                    radioStation = Convert.ToString(fmPreset[3]);
                }
            }

            lastPressed = 3;
            if (fmStereoBtn.Checked)
            {
                timeRadioLbl.Text = radioStation + " " + amFmBtn.Text + " Stereo";
            }
            else if (!fmStereoBtn.Checked)
            {
                timeRadioLbl.Text = radioStation + " " + amFmBtn.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (setPressed)
            {
                setPressed = false;

                if (amFmBtn.Text == "AM")
                {
                    if (amFmBtn.Text == "AM")
                    {
                        amPreset[4] = Convert.ToDouble(radioStation);
                    }
                    else if (amFmBtn.Text == "FM")
                    {
                        fmPreset[4] = Convert.ToDouble(radioStation);
                    }
                }
                else if (amFmBtn.Text == "FM")
                {
                    radioStation = Convert.ToString(fmPreset[4]);
                }
                fmStereoBtn.Enabled = true;
                amFmBtn.Enabled = true;
                VolgroupBox.Enabled = true;
            }
            else
            {
                if (amFmBtn.Text == "AM")
                {
                    radioStation = Convert.ToString(amPreset[4]);
                }
                else if (amFmBtn.Text == "FM")
                {
                    radioStation = Convert.ToString(fmPreset[4]);
                }
            }

            lastPressed = 4;

            if (fmStereoBtn.Checked)
            {
                timeRadioLbl.Text = radioStation + " " + amFmBtn.Text + " Stereo";
            }
            else if (!fmStereoBtn.Checked)
            {
                timeRadioLbl.Text = radioStation + " " + amFmBtn.Text;
            }
        }

        private void setBtn_Click(object sender, EventArgs e)
        {
            if (!setPressed)
            {
                setPressed = true;
                fmStereoBtn.Enabled = false;
                amFmBtn.Enabled = false;
                VolgroupBox.Enabled = false;
                tuneUpBtn.Enabled = false;
                tuneDownBtn.Enabled = false;
            }
            else if (setPressed)
            {
                setPressed = false;
                fmStereoBtn.Enabled = true;
                amFmBtn.Enabled = true;
                VolgroupBox.Enabled = true;
                tuneUpBtn.Enabled = true;
                tuneDownBtn.Enabled = true;
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 5; i++)
            {
                amPreset[i] = i + 1;
            }
            for (int i = 0; i < 5; i++)
            {
                fmPreset[i] = i + 1;
            }
        }

        private void volUpbtn_Click(object sender, EventArgs e)
        {
            VolumeBar.Increment(1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            VolumeBar.Increment(-1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double radio;
            if (amFmBtn.Text == "AM")
            {
                if(Convert.ToDouble(radioStation)>0 && Convert.ToDouble(radioStation) < 5)
                {
                    radioStation = "540";
                }
                radio = Convert.ToDouble(radioStation) + 10;
                if (radio > 1610)
                {
                    radio = 540;
                }
                radioStation = Convert.ToString(radio);
            }
            else if (amFmBtn.Text == "FM")
            {
                if (Convert.ToDouble(radioStation) > 0 && Convert.ToDouble(radioStation) < 5)
                {
                    radioStation = "87.5";
                }
                radio = Convert.ToDouble(radioStation) + 0.5;
                if (radio > 108.0)
                {
                    radio = 87.5;
                }
                radioStation = Convert.ToString(radio);
            }


            if (fmStereoBtn.Checked)
            {
                timeRadioLbl.Text = radioStation + " " + amFmBtn.Text + " Stereo";
            }
            else if (!fmStereoBtn.Checked)
            {
                timeRadioLbl.Text = radioStation + " " + amFmBtn.Text;
            }
        }

        private void tuneDownBtn_Click(object sender, EventArgs e)
        {
            double radio;
            if (amFmBtn.Text == "AM")
            {
                if (Convert.ToDouble(radioStation) > 0 && Convert.ToDouble(radioStation) < 5)
                {
                    radioStation = "540";
                }
                radio = Convert.ToDouble(radioStation) - 10;
                if (radio > 540)
                {
                    radio = 1610;
                }
                radioStation = Convert.ToString(radio);
            }
            else if (amFmBtn.Text == "FM")
            {
                if (Convert.ToDouble(radioStation) > 0 && Convert.ToDouble(radioStation) < 5)
                {
                    radioStation = "87.5";
                }
                radio = Convert.ToDouble(radioStation) - 0.5;
                if (radio > 87.5)
                {
                    radio = 108.0;
                }
                radioStation = Convert.ToString(radio);
            }
        }
    }
}
