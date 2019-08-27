using System;
using System.Drawing;
using System.Windows.Forms;

namespace YT_MOOSIK_v3 {
    public partial class Info : Form {
        private Main main;
        public Info(Main _main) {
            InitializeComponent();
            main = _main;
        }

        private void InfoClose_Click(object sender, EventArgs e) {
            main.HideInfo();
        }

        public void DickplayInfo(YoutubeResults.Item item) {
            if (item != null) {
                this.InfoTitle.Text = item.snippet.title;
                this.Thumbnail.Load(item.snippet.thumbnails.medium.url);
                this.Description.Text = item.snippet.description;
                this.Author.Text = "Author:\n" + item.snippet.channelTitle;

                float wd = this.InfoTitle.Width / 2;
                float wa = this.Author.Width / 2;

                Point pointd = new Point((int)(this.Width / 2 - wd), this.InfoTitle.Location.Y);
                Point pointa = new Point((int)(this.Width / 2 - wa), this.Author.Location.Y);

                this.InfoTitle.Location = pointd;
                this.Author.Location = pointa;
            }
        }

        private void InfoClose_MouseEnter(object sender, EventArgs e) {
            this.InfoClose.BackColor = System.Drawing.Color.FromArgb(132, 147, 165);
        }

        private void InfoClose_MouseLeave(object sender, EventArgs e) {
            this.InfoClose.BackColor = System.Drawing.Color.FromArgb(176, 196, 222);
        }
    }
}
