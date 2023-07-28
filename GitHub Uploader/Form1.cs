using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using System.Text;

namespace GitHub_Uploader
{
    public partial class Form1 : Form
    {
        private string LogPath;
        private static string RepoPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        private System.Threading.Timer timer;
        private int Intervall;
        private TimeSpan nextSave;
        bool Saving;
        public Form1()
        {
            InitializeComponent();

            LogPath = Path.Combine(Path.GetTempPath(), "GitHubLogs");
            if (!Directory.Exists(LogPath)) Directory.CreateDirectory(LogPath);

            LogPath = Path.Combine(LogPath, "Log - " + DateTime.Now.ToString("dd.MM.yyyy") + ".log");

            Update(5);

            timer = new System.Threading.Timer(Callback, null, TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(1));

            AutosaveNextSave.Text = "Initializing...";
            AutosaveInfo3.ForeColor = Color.Yellow;
            AutosaveNextSave.ForeColor = Color.Yellow;

            Saving = false;
            Intervall = 5;
            nextSave = TimeSpan.FromMinutes(Intervall);
        }

        public void Callback(object state)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => { Callback(state); }));
                return;
            }

            // Code here:

            if (!Saving)
            {
                AutosaveNextSave.Text = nextSave.Minutes.ToString("00") + ":" + nextSave.Seconds.ToString("00");
                AutosaveInfo3.ForeColor = Color.Green;
                AutosaveNextSave.ForeColor = Color.Green;

                if (nextSave == TimeSpan.Zero) Upload("Auto Save - " + DateTime.Now.ToString("dd.MM.yyyy - HH:mm"));
                else nextSave = nextSave - TimeSpan.FromSeconds(1);
            }



        }


        private bool Update(int skip = 0)
        {
            UpdateFail.Visible = false;
            UpdateSuccess.Visible = false;
            UpdateRunning.Visible = true;

            string output = "";

            for (int i = 0; i < 3; i++)
            {

                output = SendCommand("git pull");
                ChangeLog("git pull", output, false);

                if (output.Contains("Already up to date."))
                {
                    UpdateRunning.Visible = false;
                    UpdateSuccess.Visible = true;
                    i = 3;

                    return true;
                }
            }
            if (!(output.Contains("Already up to date.")))
            {
                UpdateRunning.Visible = false;
                UpdateFail.Visible = true;
                return false;
            }
            return false;

        }

        private bool Push(string Name)
        {

            CommitNowName.Visible = false;
            CommitNowUpdating.Visible = true;
            CommitNowError.Visible = false;

            ChangeLog("git add -A", SendCommand("git add -A"), false);

            ChangeLog("git commit -m \"" + Name + "\"", SendCommand("git commit -m \"" + Name + "\""), false);

            string PushOut = SendCommand("git push");

            ChangeLog("git push", PushOut, true);

            if (PushOut.Contains("error: failed to push some refs"))
            {
                CommitNowUpdating.Visible = false;
                CommitNowError.Visible = true;
                return false;
            }
            else
            {
                CommitNowUpdating.Visible = false;
                CommitNowName.Visible = true;
                return true;
            }

        }

        private void ChangeLog(string Command, string Output, bool End)
        {
            using (StreamWriter sw = File.AppendText(LogPath))
            {
                sw.WriteLine(DateTime.Now.ToString("HH:mm:ss") + ": Executed Command:\n >>> " + Command);
                sw.WriteLine(" <<< " + Output);
                if (End) sw.WriteLine("\n");
            }
        }

        private string SendCommand(string command)
        {
            try
            {
                ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", "/c " + command);

                procStartInfo.RedirectStandardError = procStartInfo.RedirectStandardInput = procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                procStartInfo.CreateNoWindow = true;
                procStartInfo.WorkingDirectory = RepoPath;

                Process proc = new Process();
                proc.StartInfo = procStartInfo;

                StringBuilder sb = new StringBuilder();
                proc.OutputDataReceived += delegate (object sender, DataReceivedEventArgs e)
                {
                    sb.AppendLine(e.Data);
                };
                proc.ErrorDataReceived += delegate (object sender, DataReceivedEventArgs e)
                {
                    sb.AppendLine(e.Data);
                };

                proc.Start();
                proc.BeginOutputReadLine();
                proc.BeginErrorReadLine();
                proc.WaitForExit();
                return sb.ToString();
            }
            catch (Exception objException)
            {
                return $"Error in command: {command}, {objException.Message}";
            }
        }

        private void Pull_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void OpenLog_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", LogPath);
        }

        private void Upload(string Name)
        {
            Saving = true;

            AutosaveNextSave.Text = "Uploading...";
            AutosaveInfo3.ForeColor = Color.Yellow;
            AutosaveNextSave.ForeColor = Color.Yellow;
            nextSave = TimeSpan.FromMinutes(Intervall);

            Update();

            if (!Push(Name))
            {
                DialogResult result = MessageBox.Show("There are differences between the Github version and the local version.\r\nShould it be tried to merge these two versions?", "Warnung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Update();
                    Push("Merging" + DateTime.Now.ToString("dd.MM.yyyy - HH:mm"));
                }
                else
                {
                    CommitNowError.Visible = false;
                    CommitNowName.Visible = true;

                    AutosaveActive_CheckedChanged(null, null);
                }

            }
            Update();
            nextSave = TimeSpan.FromMinutes(Intervall);
            Saving = false;
            if (!AutosaveActive.Checked)
            {

            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string SaveName = CommitNowName.Text;

            if (SaveName == "") SaveName = "Manual Save - " + DateTime.Now.ToString("dd.MM.yyyy - HH:mm");

            Upload(SaveName);

            CommitNowName.Text = "";
        }

        private void AutosaveActive_CheckedChanged(object sender, EventArgs e)
        {
            if (AutosaveActive.Checked && sender != null)
            {
                AutosaveInfo2.ForeColor = SystemColors.Window;
                AutosaveIntervall1min.Enabled = true;
                AutosaveIntervall2min.Enabled = true;
                AutosaveIntervall3min.Enabled = true;
                AutosaveIntervall4min.Enabled = true;
                AutosaveIntervall5min.Enabled = true;
                AutosaveIntervall6min.Enabled = true;
                AutosaveIntervall7min.Enabled = true;
                AutosaveIntervall8min.Enabled = true;
                AutosaveIntervall9min.Enabled = true;
                AutosaveIntervall10min.Enabled = true;

                timer = new System.Threading.Timer(Callback, null, TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1));

                nextSave = TimeSpan.FromMinutes(Intervall);
                AutosaveNextSave.Text = "Initializing...";
                AutosaveInfo3.ForeColor = Color.Yellow;
                AutosaveNextSave.ForeColor = Color.Yellow;
            }
            else
            {
                AutosaveInfo2.ForeColor = SystemColors.ScrollBar;
                AutosaveIntervall1min.Enabled = false;
                AutosaveIntervall2min.Enabled = false;
                AutosaveIntervall3min.Enabled = false;
                AutosaveIntervall4min.Enabled = false;
                AutosaveIntervall5min.Enabled = false;
                AutosaveIntervall6min.Enabled = false;
                AutosaveIntervall7min.Enabled = false;
                AutosaveIntervall8min.Enabled = false;
                AutosaveIntervall9min.Enabled = false;
                AutosaveIntervall10min.Enabled = false;
                timer.Dispose();

                AutosaveInfo3.ForeColor = Color.Red;
                AutosaveNextSave.ForeColor = Color.Red;
                AutosaveNextSave.Text = "Disabled";
                AutosaveActive.Checked = false;
            }
        }

        private void AutosaveIntervallmin_Click(object sender, EventArgs e)
        {
            AutosaveIntervall1min.BackColor = SystemColors.Window;
            AutosaveIntervall2min.BackColor = SystemColors.Window;
            AutosaveIntervall3min.BackColor = SystemColors.Window;
            AutosaveIntervall4min.BackColor = SystemColors.Window;
            AutosaveIntervall5min.BackColor = SystemColors.Window;
            AutosaveIntervall6min.BackColor = SystemColors.Window;
            AutosaveIntervall7min.BackColor = SystemColors.Window;
            AutosaveIntervall8min.BackColor = SystemColors.Window;
            AutosaveIntervall9min.BackColor = SystemColors.Window;
            AutosaveIntervall10min.BackColor = SystemColors.Window;

            if (sender == AutosaveIntervall1min)
            {
                AutosaveIntervall1min.BackColor = Color.DarkTurquoise;
                Intervall = 1;
            }
            if (sender == AutosaveIntervall2min)
            {
                AutosaveIntervall2min.BackColor = Color.DarkTurquoise;
                Intervall = 2;
            }
            if (sender == AutosaveIntervall3min)
            {
                AutosaveIntervall3min.BackColor = Color.DarkTurquoise;
                Intervall = 3;
            }
            if (sender == AutosaveIntervall4min)
            {
                AutosaveIntervall4min.BackColor = Color.DarkTurquoise;
                Intervall = 4;
            }
            if (sender == AutosaveIntervall5min)
            {
                AutosaveIntervall5min.BackColor = Color.DarkTurquoise;
                Intervall = 5;
            }
            if (sender == AutosaveIntervall6min)
            {
                AutosaveIntervall6min.BackColor = Color.DarkTurquoise;
                Intervall = 6;
            }
            if (sender == AutosaveIntervall7min)
            {
                AutosaveIntervall7min.BackColor = Color.DarkTurquoise;
                Intervall = 7;
            }
            if (sender == AutosaveIntervall8min)
            {
                AutosaveIntervall8min.BackColor = Color.DarkTurquoise;
                Intervall = 8;
            }
            if (sender == AutosaveIntervall9min)
            {
                AutosaveIntervall9min.BackColor = Color.DarkTurquoise;
                Intervall = 9;
            }
            if (sender == AutosaveIntervall10min)
            {
                AutosaveIntervall10min.BackColor = Color.DarkTurquoise;
                Intervall = 10;
            }

            if (nextSave > TimeSpan.FromMinutes(Intervall)) nextSave = TimeSpan.FromMinutes(Intervall);
        }
    }
}