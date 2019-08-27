using System;
using System.Collections.Generic;
using System.Web;
using System.Net.Http;
using System.Web.Script.Serialization;
using System.Diagnostics;

namespace YT_MOOSIK_v3 {
    class YoutubeVideoInfo {
        public YoutubeResults.Item Video;
        public List<YoutubeResults.Item> Playlist = new List<YoutubeResults.Item>();

        public event EventHandler onVideoReady;
        public event EventHandler onPlaylistReady;

        private JavaScriptSerializer serializer = new JavaScriptSerializer();
        private HttpClient client = new HttpClient();

        // Your Google API key here
        private string APIKey = "";
        async public void GetPlaylistInfo(string id) {
            Playlist.Clear();

            Uri requestUri = new Uri("https://www.googleapis.com/youtube/v3/playlistItems/?");
            var query = HttpUtility.ParseQueryString(requestUri.Query);
            query["key"] = APIKey;
            query["part"] = "snippet";
            query["playlistId"] = id;
            query["maxResults"] = "50";

            int PlaylistCount = 0;
            bool nextPage = true;
            do {
                string getResults = await client.GetStringAsync(requestUri.ToString() + query.ToString());

                var result = serializer.Deserialize<YoutubeResults>(getResults);
                if (result.nextPageToken != null) {
                    query["pageToken"] = result.nextPageToken;
                }

                int len = result.items.Length;
                for (int i = 0; i < len; i++) {
                    Playlist.Add(result.items[i]);
                    PlaylistCount++;
                }
            } while (nextPage && PlaylistCount < 100);

            onPlaylistReady(this, EventArgs.Empty);
        }

        async public void GetVideoInfo(string id) {
            Uri requestUri = new Uri("https://www.googleapis.com/youtube/v3/videos/?");
            var query = HttpUtility.ParseQueryString(requestUri.Query);
            query["key"] = APIKey;
            query["part"] = "snippet";
            query["id"] = id;

            string getResults = await client.GetStringAsync(requestUri.ToString() + query.ToString());

            var result = serializer.Deserialize<YoutubeResults>(getResults);

            Video = result.items[0];
            onVideoReady(this, EventArgs.Empty);
        }

        public string GetId(string url) {
            string id;
            if (url.StartsWith("http")) {
                Uri uri = new Uri(url);
                var query = HttpUtility.ParseQueryString(uri.Query);
                if (query["list"] != null) id = query["list"];
                else if (query["v"] != null) id = query["v"];
                else id = null;
            } else id = url;

            return id;
        }
    }
}
