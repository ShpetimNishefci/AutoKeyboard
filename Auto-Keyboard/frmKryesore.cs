using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using WindowsInput;
using WindowsInput.Native;

namespace Auto_Keyboard
{
    public partial class frmKryesore : Form
    {
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        public frmKryesore()
        {
            InitializeComponent();
        }

        private void linkF7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.buymeacoffee.com/Shpettimn");
        }

        private void linkFkeys_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("F1 KEY - Delete Position" + Environment.NewLine + "F2 KEY - Add Position" + Environment.NewLine + "F6 KEY - To Tray" + Environment.NewLine + "F7 KEY - Show" + Environment.NewLine + "F8 KEY - Send Message" + Environment.NewLine + "F9 KEY - Send Message", "HotKeys",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //Move List UP DOWN
        private enum MoveDirection { Up = -1, Down = 1 };

        private void MoveListViewItems(ListView sourceListView, MoveDirection direction)
        {
            int dir = (int)direction;

            foreach (ListViewItem lvi in sourceListView.SelectedItems)
            {
                int index = lvi.Index + dir;
                if (index >= sourceListView.Items.Count)
                    index = 0;
                else if (index < 0)
                    index = sourceListView.Items.Count + dir;

                sourceListView.Items.RemoveAt(lvi.Index);
                sourceListView.Items.Insert(index, lvi);
            }
        }
        private void btnUP_Click(object sender, EventArgs e)
        {
            MoveListViewItems(PositionsListView, MoveDirection.Up);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            MoveListViewItems(PositionsListView, MoveDirection.Down);
            
        }

        private void tsShow_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void tsExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmKryesore_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon.Visible = true;

                notifyIcon.ShowBalloonTip(1000); ;
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon.Visible = false;
            }
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void frmKryesore_Load(object sender, EventArgs e)
        {
           
            int FirstHotkeyId = 1;

            int FirstHotKeyKey = (int)Keys.F1;
            // Register the "F9" hotkey
            Boolean F1Registered = RegisterHotKey(
                this.Handle, FirstHotkeyId, 0x0000, FirstHotKeyKey
            );

            int SecondHotkeyId = 2;
            int SecondHotKeyKey = (int)Keys.F2;
            Boolean F2Registered = RegisterHotKey(
                this.Handle, SecondHotkeyId, 0x0000, SecondHotKeyKey
            );
            int ThirdHotkeyId = 3;
            int ThirdHotkeyKey = (int)Keys.F3;
            Boolean F3Registered = RegisterHotKey(
                this.Handle, ThirdHotkeyId, 0x0000, ThirdHotkeyKey
            );
            int FourthHotkeyId = 4;
            int FourhthHotkeyKey = (int)Keys.F4;
            Boolean F4Registered = RegisterHotKey(
                this.Handle, FourthHotkeyId, 0x0000, FourhthHotkeyKey
            );
            int SixHotkeyId = 6;
            int SixHotkeyKey = (int)Keys.F6;
            Boolean F6Registered = RegisterHotKey(
                this.Handle, SixHotkeyId, 0x0000, SixHotkeyKey
            );

            int SeventhHotkeyId = 7;
            int SevethHotkeyKey = (int)Keys.F7;
            Boolean F7Registered = RegisterHotKey(
                this.Handle, SeventhHotkeyId, 0x0000, SevethHotkeyKey
            );
            int EightHotkeyId = 8;
            int EightHotkeyKey = (int)Keys.F8;
            Boolean F8Registered = RegisterHotKey(
                this.Handle, EightHotkeyId, 0x0000, EightHotkeyKey
            );
            int NineHotkeyId = 9;
            int NineHotkeyKey = (int)Keys.F9;
            Boolean F9Registered = RegisterHotKey(
                this.Handle, NineHotkeyId, 0x0000, NineHotkeyKey
            );
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg==0x0312)
            {
                int id = m.WParam.ToInt32();
                switch (id)
                {
                    case 1:
                        try
                        {
                            PositionsListView.SelectedItems[0].Remove();

                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Please select what you want to remove", "Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    case 2:
                        SavemsgtoList();
                        txtMessage.Focus();
                        break;
                    case 6:
                        this.WindowState = FormWindowState.Minimized;
                        break;
                    case 7:
                        tsShow_Click(null, null);
                        break;
                    case 8:
                        SendTexti();
                        break;
                    case 9:
                        SendTexti();
                        break;

                        
                        
                }
            }
            base.WndProc(ref m);
        }

        private void LoadirateListen()
        {
            PositionsListView.Items.Clear();
            XDocument doc = XDocument.Load("List.xml");

            foreach (var dm in doc.Descendants("Places"))
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    dm.Element("ID").Value,
                    dm.Element("Message").Value
                });
                PositionsListView.Items.Add(item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (File.Exists("List.xml"))
            {
                DialogResult dr = MessageBox.Show("Do you want to load list from file", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    LoadirateListen();
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Config File doesn`t exist!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
        private string ID;
        private string mesazhi;

        public void RuajiTeDhenat()
        {
            RemoveAll();
            foreach (ListViewItem item in PositionsListView.Items)
            {

                foreach (object t in item.SubItems)
                    mesazhi = item.SubItems[1].Text.ToString();
                ID = item.SubItems[0].Text.ToString();

                XmlDocument xmlDoc = new XmlDocument();
                if (File.Exists("List.xml"))
                {
                    XmlDocument readDoc = new XmlDocument();
                    readDoc.Load(("List.xml"));
                    int count = readDoc.SelectNodes("PlacesDetail/Places").Count;
                    count++;

                    xmlDoc.Load("List.xml");
                    XmlElement elmRoot = xmlDoc.DocumentElement;
                    XmlElement elmNew = xmlDoc.CreateElement("Places");
                    elmRoot.AppendChild(elmNew);

                    elmRoot = xmlDoc.DocumentElement;

                    elmNew = xmlDoc.CreateElement("ID");
                    XmlText txtEditori = xmlDoc.CreateTextNode("" + count + "");
                    elmRoot.LastChild.AppendChild(elmNew);
                    elmRoot.LastChild.LastChild.AppendChild(txtEditori);

                    elmNew = xmlDoc.CreateElement("Message");
                    txtEditori = xmlDoc.CreateTextNode("" + mesazhi + "");
                    elmRoot.LastChild.AppendChild(elmNew);
                    elmRoot.LastChild.LastChild.AppendChild(txtEditori);

                    xmlDoc.Save("List.xml");
                    LoadirateListen();
                }
                else
                {
                    MessageBox.Show("Config File doesn`t exist!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private string captionii;
        private void RemoveSelectedFromFile()
        {

            try
            {
                captionii = PositionsListView.SelectedItems[0].Text;
                string conect = "List.xml";
                XmlDocument doc = new XmlDocument();
                doc.Load(conect);
                XmlNode root = doc.SelectSingleNode("PlacesDetail/Places[ID='" + captionii + "']");
                root.ParentNode.RemoveChild(root);
                doc.Save(conect);
                Cursor.Current = Cursors.WaitCursor;
                Thread.Sleep(500);
              
            }

            catch (Exception)
            {
                MessageBox.Show("Selected item isn`t from file you can`t delete it", "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            finally
            {
                PositionsListView.SelectedItems[0].Remove();
                
            }

        }

        private void RemoveAll()
        {
            foreach (ListViewItem item in PositionsListView.Items)
            {

                try
                {
                    string conect = "List.xml";
                    XmlDocument doc = new XmlDocument();
                    doc.Load(conect);
                    XmlNode root = doc.SelectSingleNode("PlacesDetail/Places");
                    root.ParentNode.RemoveChild(root);
                    doc.Save(conect);
                    Thread.Sleep(400);
                   
                }
             
                catch (Exception)
                {
                    
                }

            }
        }

        public void SavemsgtoList()
        {
            if (string.IsNullOrEmpty(txtMessage.Text))
            {
                MessageBox.Show("Text box couldn`t be empty", "Invalid Input", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                int? index = null;

                ListViewItem item = new ListViewItem();
                item.SubItems.Add(txtMessage.Text);
                PositionsListView.Items.Add(item);
            }
            txtMessage.Text = "";
        
        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (PositionsListView.Items.Count==0)
            {
                MessageBox.Show("List is empty, you don`t have what to save", "Invalid", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                    
            
            DialogResult dr = MessageBox.Show("Are you sure you want to save to file", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                RuajiTeDhenat();
            }
            else
            {
                    
            }
            }
        }

        private void btnAddPositions_Click(object sender, EventArgs e)
        {
            SavemsgtoList();
            txtMessage.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (PositionsListView.Items.Count == 0)
            {
                MessageBox.Show("List is empty, you don`t have what to delete", "Invalid", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    PositionsListView.SelectedItems[0].Remove();

                }
                catch (Exception)
                {
                    MessageBox.Show("Please select what you want to remove", "Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void upSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoveListViewItems(PositionsListView, MoveDirection.Up);
        }

        private void downToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoveListViewItems(PositionsListView, MoveDirection.Down);
        }

        private void RemoveAllMenuItem_Click(object sender, EventArgs e)
        {
            PositionsListView.Items.Clear();
        }

        private void RemoveSelectedMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PositionsListView.SelectedItems[0].Remove();

            }
            catch (Exception)
            {
                MessageBox.Show("Please select what you want to remove", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void remotefromfileMenuItem1_Click(object sender, EventArgs e)
        {
            RemoveSelectedFromFile();
        }
        public void SendTexti()
        {

            try
            {

                foreach (ListViewItem item in PositionsListView.Items)
                {

                    foreach (object t in item.SubItems)
                        mesazhi = item.SubItems[1].Text.ToString();
                    int sleepTime = Convert.ToInt32(numSleepTime.Text);
                    Thread.Sleep(sleepTime);

                    //  Thread.Sleep(sleepTime);
                    InputSimulator Simulator = new InputSimulator();
                    Simulator.Keyboard.TextEntry("" + mesazhi + "" + Spejsi + "");

                    if (chckEnter.Checked==true)
                    {
                        var sim = new InputSimulator();
                        sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                    }
                    else
                    {
                         
                    }
                   
                }

            }


            catch (Exception exc)
            {
                  MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private string Spejsi;
        private void chckSpace_CheckedChanged(object sender, EventArgs e)
        {
            if (chckSpace.Checked==true)
            {
                Spejsi = " ";
            }
            else
            {
                Spejsi = "";
            }
        }

       
    }
}
