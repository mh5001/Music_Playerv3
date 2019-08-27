public class YoutubeResults {
    public string nextPageToken;
    public Item[] items;

    public class Item {
        public Snippet snippet;
    }

    public class Snippet {
        public ResourceId resourceId;
        public string title;
        public string description;
        public string channelTitle;

        public Thumbnail thumbnails;

        public class Thumbnail {
            public Medium medium;
            public class Medium {
                public string url;
            }
        }
    }

    public class ResourceId {
        public string videoId;
    }
}