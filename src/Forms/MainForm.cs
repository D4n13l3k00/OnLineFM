using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using VideoLibrary;
using WMPLib;
using System.IO;

namespace OnLineFM
{
    public partial class MainForm : Form
    {
        private List<API.API_Object> stations;
        private List<FavObj> favlst;
        private WindowsMediaPlayer player = new WindowsMediaPlayer();
        private System.Windows.Forms.Timer SleepTimer = new System.Windows.Forms.Timer();
        private long SleepTime = 0;
        public MainForm()
        {
            InitializeComponent();
            loadFav(true);
            player.PlayStateChange += (int NewState) =>
            {
                if (NewState == (int)WMPPlayState.wmppsPlaying)
                {
                    noti.Text = "OnLineFM - Playing...";
                    stateLabel.Text = "Playing...";
                }
                else if (NewState == (int)WMPPlayState.wmppsBuffering) {
                    noti.Text = "OnLineFM - Buffering...";
                    stateLabel.Text = "Buffering...";
                }
                else if (NewState == (int)WMPPlayState.wmppsReconnecting)
                {
                    noti.Text = "OnLineFM - Reconnectiong...";
                    stateLabel.Text = "Reconnectiong...";
                }
                else if (NewState == (int)WMPPlayState.wmppsStopped)
                {
                    noti.Text = "OnLineFM - Waiting...";
                    stateLabel.Text = "Waiting...";
                }
            };
            SleepTimer.Interval = 1000;
            SleepTimer.Tick += (object sender, EventArgs e) => {
                if (SleepTime == 0)
                {
                    SleepTime = -1;
                    player.controls.stop();
                    sleepTimerBtn.Text = "Start";
                    SleepTimer.Stop();
                    noti.Text = "OnLineFM - Waiting...";
                    stateLabel.Text = "Waiting...";
                } else if (SleepTime > 0)
                {
                    SleepTime--;
                    var ts = TimeSpan.FromSeconds(SleepTime);
                    sleepTimerBtn.Text = ts.Hours.ToString("00") + ":" + ts.Minutes.ToString("00") + ":" + ts.Seconds.ToString("00");
                }
            };
        }

        private void srchbtn_Click(object sender, EventArgs e)
        {
            if (searchbox.Text == String.Empty)
            {
                if (MessageBox.Show("If you press YES, will be load all stations! Are you sure?", "Hey!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    new Thread(new ThreadStart(() => { collectStations(); })).Start();
            }
            else { new Thread(new ThreadStart(() => { collectStations(searchbox.Text); })).Start(); }
                
        }

        private void playbtn_Click(object sender, EventArgs e)
        {
            playbtn.Enabled = false;
            if (stationslist.SelectedIndex > -1)
            {
                var lnk = stations[stationslist.SelectedIndex].Url;
                player.URL = lnk;
                player.controls.play();
            } else
            {
                MessageBox.Show("Choose station!", "Hey!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            playbtn.Enabled = true;
        }

        private void stopbtnitem_Click(object sender, EventArgs e) => player.controls.stop();

        private void showndbtn_Click(object sender, EventArgs e) => Show();

        private void noti_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Visible) { Hide(); }
            else { Show(); }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e) => Process.Start("https://t.me/D4n13l3k00");

        private void mutebtn_Click(object sender, EventArgs e)
        {
            switch (player.settings.mute)
            {
                case true:
                    player.settings.mute = false; mutebtn.Text = "Mute"; break;

                case false:
                    player.settings.mute = true; mutebtn.Text = "UnMute"; break;
            }

        }

        private void playTbtn_Click(object sender, EventArgs e)
        {
            playTbtn.Enabled = false;
            if (YouTubeParser.yt.isYT(customTbox.Text))
            {
                YouTube yt = YouTube.Default;
                string link = customTbox.Text;
                foreach (var item in yt.GetAllVideos(link))
                {
                    if (item.AdaptiveKind == AdaptiveKind.Audio)
                    {
                        player.URL = item.Uri;
                        player.controls.play();
                        break;
                    }
                }
            } else
            {
                player.URL = customTbox.Text;
                player.controls.play();
            }
            playTbtn.Enabled = true;
        }

        private void stopbtn_Click(object sender, EventArgs e) => player.controls.stop();

        private void stateLabel_Click(object sender, EventArgs e)
        {
            if (player.playState == WMPPlayState.wmppsPlaying)
            {
                Clipboard.SetText(player.URL);
                MessageBox.Show("The link to the stream is copied to the clipboard!", "Hey!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else { MessageBox.Show("Now nothing plays!", "Hey!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            char[] arr = label2.Text.ToCharArray();
            Array.Reverse(arr);
            label2.Text = new string(arr);
        }
        private void sleepTimerBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void sleepTimerBtn_Click(object sender, EventArgs e)
        {
            if (SleepTimer.Enabled)
            {
                SleepTimer.Stop();
                sleepTimerBtn.Text = "Start";
                sleepTimerBox.ReadOnly = false;
            } else
            {
                if (sleepTimerBox.Text == string.Empty)
                {
                    MessageBox.Show("Enter time!", "Hey!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                try
                {
                    SleepTime = long.Parse(sleepTimerBox.Text) * 60;
                    SleepTimer.Start();
                    sleepTimerBox.ReadOnly = true;
                } catch
                {
                    MessageBox.Show("The number is very big!", "Hey!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void aboutbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This app made by D4n13l3k00\nt.me/D4n13l3k00\nThis app created for listening online radio!\nBut you can listen youtube streams too!\n\nEnjoy :)");
        }
        private void collectStations(string r = "")
        {
            BeginInvoke((Action)(() => {
                srchbtn.Enabled = false;
                searchbox.Enabled = false;
                stationslist.Enabled = false;
                stationslist.Items.Clear();
            }));
            stations = API.api.getStations(r).GroupBy(x => x.Name).Select(x => x.First()).GroupBy(x => x.Url).Select(x => x.First()).ToList();
            if (stations.Count() != 0)
            {
                stations.AsParallel().ForAll(x => { BeginInvoke((Action)(() => { stationslist.Items.Add(x.Name); Update(); })); });
            }
            else
            {
                noti.ShowBalloonTip(5, "Stations not found :(", "Try search another station :)", ToolTipIcon.Warning);
            }
            BeginInvoke((Action)(() => {
                srchbtn.Enabled = true;
                searchbox.Enabled = true;
                stationslist.Enabled = true;
            }));
        }

        private void playfavbtn_Click(object sender, EventArgs e)
        {
            playfavbtn.Enabled = false;
            if (favbox.SelectedIndex > -1)
            {
                var lnk = favlst[favbox.SelectedIndex].Url;
                if (YouTubeParser.yt.isYT(lnk))
                {
                    YouTube yt = YouTube.Default;
                    foreach (var item in yt.GetAllVideos(lnk))
                    {
                        if (item.AdaptiveKind == AdaptiveKind.Audio)
                        {
                            player.URL = item.Uri;
                            player.controls.play();
                            break;
                        }
                    }
                }
                else
                {
                    player.URL = lnk;
                    player.controls.play();
                }
            }
            else
            {
                MessageBox.Show("Choose favourite station!", "Hey!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            playfavbtn.Enabled = true;
        }
        private void saveFav()
        {
            File.WriteAllText("fav.xml", SerializeExtension.SerializeToString(favlst.Select(x => new FavObj() { Name = x.Name, Url = x.Url }).ToList()));
        }
        private void loadFav(bool updatelst=false)
        {
            if (File.Exists("fav.xml"))
            {
                favlst = File.ReadAllText("fav.xml").DeserializeString<List<FavObj>>();
                if (updatelst)
                {
                    favlst.ForEach(x => { favbox.Items.Add(x.Name); Update(); });
                }
            } else
            {
                favlst = new List<FavObj>();
            }
            
        }

        private void addfavbtn_Click(object sender, EventArgs e)
        {
            addfavbtn.Enabled = false;
            favbox.Enabled = false;
            if (stationslist.SelectedIndex > -1)
            {
                var obj = stations[stationslist.SelectedIndex];
                favbox.Items.Add(obj.Name);
                var no = new FavObj() { Name = obj.Name, Url = obj.Url };
                favlst.Add(no);
                saveFav();
            }
            else
            {
                MessageBox.Show("Choose station!", "Hey!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            addfavbtn.Enabled = true;
            favbox.Enabled = true;
        }

        private void rmfavbtn_Click(object sender, EventArgs e)
        {
            rmfavbtn.Enabled = false;
            favbox.Enabled = false;
            if (favbox.SelectedIndex > -1)
            {
                var obj = favlst[favbox.SelectedIndex];
                favlst.RemoveAt(favbox.SelectedIndex);
                favbox.Items.RemoveAt(favbox.SelectedIndex);
                saveFav();
            }
            else
            {
                MessageBox.Show("Choose station!", "Hey!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            rmfavbtn.Enabled = true;
            favbox.Enabled = true;
        }

        private void addfavurlbtn_Click(object sender, EventArgs e)
        {
            addfavurlbtn.Enabled = false;
            favbox.Enabled = false;
            var rq = new AddFavForm();
            rq.ShowDialog();
            if(rq.entered)
            {
                favbox.Items.Add(rq.namebox.Text);
                favlst.Add(new FavObj() { Name = rq.namebox.Text, Url = rq.urlbox.Text });
                saveFav();
            }
            favbox.Enabled = true;
            addfavurlbtn.Enabled = true;
        }

        private void editfavbtn_Click(object sender, EventArgs e)
        {
            editfavbtn.Enabled = false;
            favbox.Enabled = false;
            if (favbox.SelectedIndex > -1)
            {
                var obj = favlst[favbox.SelectedIndex];
                var rq = new AddFavForm();
                rq.namebox.Text = obj.Name;
                rq.urlbox.Text = obj.Url;
                rq.ShowDialog();
                if (rq.entered)
                {
                    favlst[favbox.SelectedIndex] = new FavObj() { Name = rq.namebox.Text, Url = rq.urlbox.Text};
                    favbox.Items[favbox.SelectedIndex] = rq.namebox.Text;
                    saveFav();
                }
            }
            else
            {
                MessageBox.Show("Choose favourite station!", "Hey!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            favbox.Enabled = true;
            editfavbtn.Enabled = true;
        }
    }
}
