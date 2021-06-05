using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace AB__Log_Viewer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            Instance = this; //Unsafe, dirty and whatever you want, but meh
        }

        public static frmMain Instance;

        private string[] LastLines = new string[0];
        private int prevCount = 0;
        private long prevBytes = 0;
        private long currBytes = 0;

        private string LogPath
        {
            get
            {
                return Config.Inst.LogPath;
            }
            set
            {
                Config.Inst.LogPath = value;
            }
        }

        #region Forms
        private void txtLogPath_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(Path.Combine(txtLogPath.Text, "log.txt")))
            {
                LogPath = txtLogPath.Text;

                ClearAll();

                LoadChanges();
                txtLogPath.ForeColor = Color.Black;
            }
            else
            {
                if (txtLogPath.Text.EndsWith("log.txt"))
                {
                    txtLogPath.Text = Path.GetDirectoryName(txtLogPath.Text);
                }
                else
                {
                    txtLogPath.ForeColor = Color.Red;
                }
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            lvLog.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(lvLog, true);
            Config.Load();
            chkInfo.Checked = Config.Inst.showInfo;
            chkError.Checked = Config.Inst.showError;
            chkDebug.Checked = Config.Inst.showDebug;
            var dslkfj = this.Size;
            var nsize = new Size { Width = Config.Inst.frmWidth, Height = Config.Inst.frmHeight };
            this.Size = nsize;

            ColumnHeader header = new ColumnHeader();
            header.Text = "";
            header.Name = "col1";
            lvLog.HeaderStyle = ColumnHeaderStyle.None;
            lvLog.Columns.Add(header);
            lvLog.AutoResizeColumns(ColumnHeaderAutoResizeStyle.Head‌​erSize);

            txtLogPath.Text = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "My Games\\Binding of Isaac Repentance");
            LogPath = txtLogPath.Text;
            LoadChanges();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Config.Inst.frmWidth = this.Width;
            Config.Inst.frmHeight = this.Height;
            lvLog.AutoResizeColumns(ColumnHeaderAutoResizeStyle.Head‌​erSize);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadChanges();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (ofdLog.ShowDialog() == DialogResult.OK)
            {
                txtLogPath.Text = ofdLog.FileName;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Config.Save();
        }
        #endregion

        #region Logic
        private void LoadChanges()
        {
            if (LogPath == "")
                return;
            string[] lines = new string[0];
            try
            {
                string p = Path.Combine(LogPath, "log.txt");
                using (var stream = new FileStream(p, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using (StreamReader cmdLogReader = new StreamReader(stream))
                    {
                        currBytes = cmdLogReader.BaseStream.Length;
                        if (currBytes > prevBytes)
                        {
                            cmdLogReader.BaseStream.Seek(-(currBytes - prevBytes), System.IO.SeekOrigin.End);
                            lines = cmdLogReader.ReadToEnd().Trim('\n').Split('\n');
                            //lvLog.BeginUpdate();
                            foreach (var line in lines)
                            {
                                bool visible = ShouldSee(line);
                                ListViewItem lvitem = new ListViewItem(line);
                                lvitem.ForeColor = IsErrorLine(line) ? Color.Red : IsDebugLine(line) ? Color.DarkOrange : Color.Black;
                                foreach (var filter in Config.Inst.CustomFilters)
                                {
                                    //var aa = filter.Regex;
                                    Regex rx = new Regex(filter.Regex, RegexOptions.IgnoreCase);
                                    if (filter.Enabled && rx.IsMatch(line))
                                    {
                                        if (!filter.Visible)
                                            visible = false;
                                        if (filter.BackEnable) { lvitem.BackColor = filter.BackColor; }
                                        if (filter.ForeEnable) { lvitem.ForeColor = filter.ForeColor; }
                                    }
                                }
                                if (visible) {
                                    lvLog.Items.Add(lvitem);
                                }
                            }
                            //lvLog.EndUpdate();
                            if (lvLog.Items.Count > 0 && (lvLog.Items.Count != prevCount))
                            {
                                lvLog.Items[lvLog.Items.Count - 1].EnsureVisible();
                                prevCount = lvLog.Items.Count;
                            }
                                
                        }
                        else if (currBytes < prevBytes)
                        {
                            Reload();
                        }
                        prevBytes = currBytes;
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Can't access the specified path: Access denied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void Reload()
        {
            ClearAll();
            LoadChanges();
        }

        public void ClearAll()
        {
            prevBytes = 0;
            LastLines = new string[0];
            lvLog.Items.Clear();
        }

        public bool IsErrorLine(string line)
        {
            return line.Contains("Error") || line.Contains("error") || line.Contains("ERR");
        }

        public bool IsDebugLine(string line)
        {
            return line.StartsWith("[INFO] - Lua Debug:");
        }

        public bool IsInfoLine(string line)
        {
            return (!IsErrorLine(line)) && (!IsDebugLine(line));
        }

        public bool ShouldSee(string line)
        {
            return !((IsErrorLine(line) && !chkError.Checked) || (IsDebugLine(line) && !chkDebug.Checked) || (IsInfoLine(line) && !chkInfo.Checked));
        }

        private void chkInfo_CheckedChanged(object sender, EventArgs e)
        {
            Config.Inst.showInfo = chkInfo.Checked;
            ClearAll();
            LoadChanges();
        }
        private void chkError_CheckedChanged(object sender, EventArgs e)
        {
            Config.Inst.showError = chkError.Checked;
            ClearAll();
            LoadChanges();
        }
        private void chkDebug_CheckedChanged(object sender, EventArgs e)
        {
            Config.Inst.showDebug = chkDebug.Checked;
            ClearAll();
            LoadChanges();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            new frmCustomFilters().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                if (File.Exists(Path.Combine(txtLogPath.Text, "log.txt")))
                {
                    File.WriteAllText(Path.Combine(txtLogPath.Text, "log.txt"), "");
                }
            }
            catch(Exception ex) {
            }
        }
    }
}
