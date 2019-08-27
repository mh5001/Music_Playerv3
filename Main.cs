using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Media;
using System.Net;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
// HSOtku1j600
namespace YT_MOOSIK_v3 {
    public partial class Main : Form {
        private readonly MediaPlayer player = new MediaPlayer();
        private readonly YoutubeVideoInfo videoInfo = new YoutubeVideoInfo();
        private YoutubeResults.Item CurrentVideo;
        private List<YoutubeResults.Item> CurrentVideoPlaylist;
        private int CurrentVideoPlaylistLocation = 0;
        private string CurrentVideoId;
        private bool isPlaylist;
        private bool isInfoOpen = false;
        private bool hazMoosik = false;
        private readonly Info info;
        private bool isBack = false;

        private bool wasBackClicked = true;
        private bool wasSkipClicked = false;

        private readonly ToolTip toolTip = new ToolTip();

        private Size thumbSizeNormal = new Size(149, 84);
        private Size thumbSizeSmol = new Size(135, 76);
        private bool isPlaying = false;

        public Main() {
            InitializeComponent();

            videoInfo.onVideoReady += onVideoReady;
            videoInfo.onPlaylistReady += onPlaylistReady;

            player.MediaFailed += Player_MediaFailed;
            player.MediaEnded += Player_MediaEnded;

            ToolTip tool = new ToolTip();
            info = new Info(this);
        }

        private void PlayAudio(string id) {
            player.Open(new Uri("http://youtube2mp3.glitch.me/api/?id=" + id));
            this.PlayPause.Image = YT_MOOSIK_v3.Properties.Resources.pause_normal;
            isPlaying = true;

            player.Play();
            if (!hazMoosik) hazMoosik = true;
        }

        private void PauseMusic() {
            player.Pause();
            this.PlayPause.Image = YT_MOOSIK_v3.Properties.Resources.play_down;

            isPlaying = false;
        }

        private void PlayMusic() {
            player.Play();
            this.PlayPause.Image = YT_MOOSIK_v3.Properties.Resources.pause_down;

            isPlaying = true;
        }

        private void Player_MediaFailed(object sender, ExceptionEventArgs e) {
            Debug.WriteLine(e.ToString());
        }

        // When the music ends ---------------------------------------------------------------------------------
        private void Player_MediaEnded(object sender, EventArgs e) {
            if (isPlaylist) {
                if (CurrentVideoPlaylistLocation < CurrentVideoPlaylist.Count && !isBack) {
                    YoutubeResults.Item current = CurrentVideoPlaylist[CurrentVideoPlaylistLocation];

                    toolTip.SetToolTip(this.CurrentThumb, current.snippet.title);
                    this.CurrentThumb.Load(current.snippet.thumbnails.medium.url);
                    if (CurrentVideoPlaylistLocation > 0) {
                        YoutubeResults.Item previous = CurrentVideoPlaylist[CurrentVideoPlaylistLocation - 1];
                        this.PrevThumb.Load(previous.snippet.thumbnails.medium.url);
                        toolTip.SetToolTip(this.PrevThumb, previous.snippet.title);
                    }
                    if (CurrentVideoPlaylistLocation < CurrentVideoPlaylist.Count - 1) {
                        YoutubeResults.Item next = CurrentVideoPlaylist[CurrentVideoPlaylistLocation + 1];
                        this.NextThumb.Load(next.snippet.thumbnails.medium.url);
                        toolTip.SetToolTip(this.NextThumb, next.snippet.title);
                    } else {
                        this.NextThumb.Image = null;
                        toolTip.SetToolTip(this.NextThumb, null);
                    }

                    PlayAudio(current.snippet.resourceId.videoId);
                    CurrentVideoPlaylistLocation++;
                } else if (CurrentVideoPlaylistLocation > 0 && isBack) {
                    YoutubeResults.Item current = CurrentVideoPlaylist[CurrentVideoPlaylistLocation - 1];

                    toolTip.SetToolTip(this.CurrentThumb, current.snippet.title);
                    this.CurrentThumb.Load(current.snippet.thumbnails.medium.url);
                    if (CurrentVideoPlaylistLocation > 1) {
                        YoutubeResults.Item previous = CurrentVideoPlaylist[CurrentVideoPlaylistLocation - 2];
                        this.PrevThumb.Load(previous.snippet.thumbnails.medium.url);
                        toolTip.SetToolTip(this.PrevThumb, previous.snippet.title);
                    } else {
                        this.PrevThumb.Image = null;
                        toolTip.SetToolTip(this.NextThumb, null);
                    }
                    if (CurrentVideoPlaylistLocation < CurrentVideoPlaylist.Count) {
                        YoutubeResults.Item next = CurrentVideoPlaylist[CurrentVideoPlaylistLocation];
                        this.NextThumb.Load(next.snippet.thumbnails.medium.url);
                        toolTip.SetToolTip(this.NextThumb, next.snippet.title);
                    } else {
                        this.NextThumb.Image = null;
                        toolTip.SetToolTip(this.NextThumb, null);
                    }

                    PlayAudio(current.snippet.resourceId.videoId);
                    CurrentVideoPlaylistLocation--;
                    isBack = false;
                } else player.Stop();
            }
        }

        private void onVideoReady(object sender, EventArgs e) {
            isPlaylist = false;
            YoutubeVideoInfo videoInfo = (YoutubeVideoInfo)sender;
            this.CurrentThumb.Load(videoInfo.Video.snippet.thumbnails.medium.url);
            this.CurrentVideo = videoInfo.Video;

            PlayAudio(CurrentVideoId);
        }

        private void onPlaylistReady(object sender, EventArgs e) {
            isPlaylist = true;
            CurrentVideoPlaylistLocation = 0;

            YoutubeVideoInfo videoInfo = (YoutubeVideoInfo)sender;
            CurrentVideoPlaylist = videoInfo.Playlist;

            if (CurrentVideoPlaylistLocation < CurrentVideoPlaylist.Count) {
                YoutubeResults.Item current = CurrentVideoPlaylist[CurrentVideoPlaylistLocation];
                toolTip.SetToolTip(this.CurrentThumb, current.snippet.title);

                this.CurrentThumb.Load(current.snippet.thumbnails.medium.url);
                if (CurrentVideoPlaylist.Count > 1) {
                    YoutubeResults.Item next = CurrentVideoPlaylist[CurrentVideoPlaylistLocation + 1];
                    this.NextThumb.Load(next.snippet.thumbnails.medium.url);

                    toolTip.SetToolTip(this.NextThumb, next.snippet.title);
                }
                PlayAudio(current.snippet.resourceId.videoId);
            }
        }

        private void LoadButton_Click(object sender, EventArgs e) {
            string id = videoInfo.GetId(this.InputURL.Text);

            if (id == null) throw new Exception("No ID provided in URL");
            if (id.Length > 11) videoInfo.GetPlaylistInfo(id);
            else {
                CurrentVideoId = id;
                videoInfo.GetVideoInfo(id);
            }
        }

        private void Skip_Click(object sender, EventArgs e) {
            if (isPlaylist) Player_MediaEnded(null, EventArgs.Empty);
            this.wasSkipClicked = true;

            if (wasBackClicked) {
                wasBackClicked = false;

                this.Skip_Click(null, EventArgs.Empty);
            }
        }

        private void Close_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Minimize_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        // Drag Pannel ------------------------------------------------------------------------------------------
        private int downXPos, downYPos;
        private bool isMouseDown;
        private void DragPanel_MouseMove(object sender, MouseEventArgs e) {
            if (isMouseDown) {
                this.Left += e.X - downXPos;
                this.Top += e.Y - downYPos;
            }
        }

        private void DragPanel_MouseUp(object sender, MouseEventArgs e) {
            isMouseDown = false;
        }

        private void DragPanel_MouseDown(object sender, MouseEventArgs e) {
            downXPos = e.X;
            downYPos = e.Y;
            isMouseDown = true;
        }

        // Mouse Enter/Leaves buttons ----------------------------------------------------------------------------
        private void Minimize_MouseEnter(object sender, EventArgs e) {
            this.Minimize.BackColor = System.Drawing.Color.FromArgb(55, 91, 91);
        }


        private void Minimize_MouseLeave(object sender, EventArgs e) {
            this.Minimize.BackColor = System.Drawing.Color.FromArgb(47, 79, 79);
        }

        private void Close_MouseEnter(object sender, EventArgs e) {
            this.Close.BackColor = System.Drawing.Color.FromArgb(255, 0, 0);
        }

        private void Close_MouseLeave(object sender, EventArgs e) {
            this.Close.BackColor = System.Drawing.Color.FromArgb(47, 79, 79);
        }

        // Mouse Enter/Leaves thumbnails -------------------------------------------------------------------------
        private void NextThumb_MouseLeave(object sender, EventArgs e) {
            if (this.NextThumb.Image == null) return;
            SmolThumb(this.NextThumb);
            BigThumb(this.CurrentThumb);
        }

        private void NextThumb_MouseEnter(object sender, EventArgs e) {
            if (this.NextThumb.Image == null) {
                this.NextThumb.Cursor = Cursors.Arrow;
                return;
            }
            this.NextThumb.Cursor = Cursors.Hand;
            SmolThumb(this.CurrentThumb);
            BigThumb(this.NextThumb);
        }

        private void PrevThumb_MouseEnter(object sender, EventArgs e) {
            if (this.PrevThumb.Image == null) {
                this.PrevThumb.Cursor = Cursors.Arrow;
                return;
            }
            this.PrevThumb.Cursor = Cursors.Hand;
            SmolThumb(this.CurrentThumb);
            BigThumb(this.PrevThumb);
        }

        private void PrevThumb_MouseLeave(object sender, EventArgs e) {
            if (this.PrevThumb.Image == null) return;
            SmolThumb(this.PrevThumb);
            BigThumb(this.CurrentThumb);
        }

        private void SmolThumb(PictureBox thumbnail) {
            thumbnail.Size = thumbSizeSmol;
            Point point = new Point(thumbnail.Location.X + 7, thumbnail.Location.Y + 8);

            thumbnail.Location = point;
        }

        private void BigThumb(PictureBox thumbnail) {
            thumbnail.Size = thumbSizeNormal;
            Point point = new Point(thumbnail.Location.X - 7, thumbnail.Location.Y - 8);

            thumbnail.Location = point;
            if (!isInfoOpen) thumbnail.BringToFront();
        }

        private void CurrentThumb_Click(object sender, EventArgs e) {
            ShowInfo();
            if (isPlaylist) info.DickplayInfo(CurrentVideoPlaylist[CurrentVideoPlaylistLocation]);
            else info.DickplayInfo(CurrentVideo);
        }

        private void NextThumb_Click(object sender, EventArgs e) {
            ShowInfo();
            if (isPlaylist) info.DickplayInfo(CurrentVideoPlaylist[CurrentVideoPlaylistLocation + 1]);

            isInfoOpen = true;
        }

        private void PrevThumb_Click(object sender, EventArgs e) {
            ShowInfo();
            if (isPlaylist) info.DickplayInfo(CurrentVideoPlaylist[CurrentVideoPlaylistLocation - 1]);

            isInfoOpen = true;
        }

        private void ShowInfo() {
            this.InfoPanel.Controls.Clear();
            this.InfoPanel.BringToFront();

            info.TopLevel = false;
            info.Dock = DockStyle.Fill;
            this.InfoPanel.Controls.Add(info);
            info.Show();
        }

        private void PlayPause_MouseEnter(object sender, EventArgs e) {
            if (!isPlaying) this.PlayPause.Image = YT_MOOSIK_v3.Properties.Resources.play_down;
            else this.PlayPause.Image = YT_MOOSIK_v3.Properties.Resources.pause_down;

            Point point = new Point(this.PlayPause.Location.X + 2, this.PlayPause.Location.Y + 2);

            this.PlayPause.Location = point;
        }

        private void PlayPause_MouseLeave(object sender, EventArgs e) {
            if (!isPlaying) this.PlayPause.Image = YT_MOOSIK_v3.Properties.Resources.play_normal;
            else this.PlayPause.Image = YT_MOOSIK_v3.Properties.Resources.pause_normal;
            Point point = new Point(this.PlayPause.Location.X - 2, this.PlayPause.Location.Y - 2);

            this.PlayPause.Location = point;
        }

        private void PlayPause_Click(object sender, EventArgs e) {
            if (!hazMoosik) {
                if (this.InputURL.Text.Length > 0) {
                    LoadButton_Click(null, EventArgs.Empty);
                }
            }
            if (isPlaying) PauseMusic();
            else PlayMusic();
        }

        private void CurrentThumb_MouseEnter(object sender, EventArgs e) {
            if (this.CurrentThumb.Image == null) {
                this.CurrentThumb.Cursor = Cursors.Arrow;
            } else {
                this.CurrentThumb.Cursor = Cursors.Hand;
            }
        }

        private void SkipButton_MouseEnter(object sender, EventArgs e) {
            this.SkipButton.Image = YT_MOOSIK_v3.Properties.Resources.skip_down;
        }

        private void SkipButton_MouseLeave(object sender, EventArgs e) {
            this.SkipButton.Image = YT_MOOSIK_v3.Properties.Resources.skip_normal;
        }

        private void BackButton_MouseEnter(object sender, EventArgs e) {
            this.BackButton.Image = YT_MOOSIK_v3.Properties.Resources.back_down;
        }

        private void BackButton_MouseLeave(object sender, EventArgs e) {
            this.BackButton.Image = YT_MOOSIK_v3.Properties.Resources.back_normal;
        }

        private void BackButton_Click(object sender, EventArgs e) {
            isBack = true;
            wasBackClicked = true;

            if (isPlaylist) {
                Player_MediaEnded(null, EventArgs.Empty);
            }
            if (wasSkipClicked) {
                wasSkipClicked = false;
                BackButton_Click(null, EventArgs.Empty);
            }
        }

        public void HideInfo() {
            this.InfoPanel.Controls.Clear();
            this.InfoPanel.SendToBack();

            this.CurrentThumb.BringToFront();

            isInfoOpen = false;
        }
    }
}
