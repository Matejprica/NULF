using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nineinchers_BL_farmer
{
    public partial class Form1 : Form
    {
        static string folderPath = System.IO.Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments), "NineinchersBLfarmer");

        string path = System.IO.Path.Combine(folderPath, "data.txt");
       
        public Form1()
        {
            InitializeComponent();
            LoadFromFile();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            string picked = DateTime.Now.ToString("HH:mm");
            string next = DateTime.Now.AddMinutes(45).ToString("HH:mm") + " - " + DateTime.Now.AddMinutes(75).ToString("HH:mm");

            switch ((sender as Button).Name)
            {
                case "btnEPL":
                    tbEplPicked.Text = picked;
                    tbEplNext.Text = next;
                    break;
                case "btnBS":
                    tbBsPicked.Text = picked;
                    tbBsNext.Text = next;
                    break;
                case "btnWS":
                    tbWsPicked.Text = picked;
                    tbWsNext.Text = next;
                    break;
                case "btnSili":
                    tbSiliPicked.Text = picked;
                    tbSiliNext.Text = next;
                    break;
                default:
                    break;
            }
        }

        private void BtnAddPlayer_Click(object sender, EventArgs e)
        {
            Form2 formAddPlayer = new Form2();
            if(formAddPlayer.ShowDialog() == DialogResult.OK)
            {                          
                FlowLayoutPanel flpPlayer = initPlayer(formAddPlayer.getPlayerName(), 0);

                flp.Controls.Add(flpPlayer);
            }               
        }

        private FlowLayoutPanel initPlayer(string playerName, int nrOfLotus)
        {
            TextBox tbName = new TextBox();
            tbName.ReadOnly = true;
            tbName.Text = playerName;
            tbName.BorderStyle = BorderStyle.None;

            NumericUpDown numericUpDown = new NumericUpDown();
            numericUpDown.Value = nrOfLotus;
            numericUpDown.Minimum = 0;
            numericUpDown.Size = new Size(40, 10);

            Button btnRemovePlayer = new Button();
            btnRemovePlayer.Click += btnRemovePlayer_Click;
            btnRemovePlayer.Text = "-";
            btnRemovePlayer.Size = new Size(20, 20);
            btnRemovePlayer.BackColor = Color.Red;
            btnRemovePlayer.ForeColor = Color.White;

            FlowLayoutPanel flpPlayer = new FlowLayoutPanel();
            flpPlayer.AutoSize = true;
            flpPlayer.Controls.AddRange(new Control[] { tbName, numericUpDown, btnRemovePlayer });

            return flpPlayer;
        }

        private void btnRemovePlayer_Click(object sender, EventArgs e)
        {
            (sender as Button).Parent.Dispose();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            flp.Controls.Clear();
            ClearTimers();
        }

        private void ClearTimers()
        {
            foreach (var ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox textBox = ctrl as TextBox;
                    textBox.Text = "";
                }
            }
        }

        private void SaveToFile()
        {
            if (File.Exists(path))
                File.Delete(path);

            Directory.CreateDirectory(folderPath);

            try
            {
                using(StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(tbEplPicked.Text);
                    sw.WriteLine(tbEplNext.Text);
                    sw.WriteLine(tbBsPicked.Text);
                    sw.WriteLine(tbBsNext.Text);
                    sw.WriteLine(tbWsPicked.Text);
                    sw.WriteLine(tbWsNext.Text);
                    sw.WriteLine(tbSiliPicked.Text);
                    sw.WriteLine(tbSiliNext.Text);

                    foreach (FlowLayoutPanel flpPlayer in flp.Controls)
                    {
                        NumericUpDown nrOfLotus = (NumericUpDown)flpPlayer.Controls[1];
                        sw.WriteLine(flpPlayer.Controls[0].Text + "|" + nrOfLotus.Value);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private void LoadFromFile()
        {
            if (!File.Exists(path))
                return;

            try
            {            
                using(StreamReader sr = new StreamReader(path))
                {
                    tbEplPicked.Text = sr.ReadLine();
                    tbEplNext.Text = sr.ReadLine();
                    tbBsPicked.Text = sr.ReadLine();
                    tbBsNext.Text = sr.ReadLine();
                    tbWsPicked.Text = sr.ReadLine();
                    tbWsNext.Text = sr.ReadLine();
                    tbSiliPicked.Text = sr.ReadLine();
                    tbSiliNext.Text = sr.ReadLine();

                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        flp.Controls.Add(initPlayer(line.Split('|')[0], int.Parse(line.Split('|')[1])));
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveToFile();
        }
    }
}
