using System;
using System.Collections.Generic;
using System.Text;

namespace dvoshLibCore.DTO
{
    internal class ThreadDto
    {
        public string Board { get; set; }
        public string BoardInfo { get; set; }
        public string BoardInfoOuter { get; set; }
        public string BoardName { get; set; }
        public string advert_bottom_image { get; set; }
        public string advert_bottom_link { get; set; }
        public string advert_mobile_image { get; set; }
        public string advert_mobile_link { get; set; }
        public string advert_top_image { get; set; }
        public string advert_top_link { get; set; }
        public string board_banner_image { get; set; }
        public string board_banner_link { get; set; }
        public long bump_limit { get; set; }
        public string current_thread { get; set; }
        public string default_nam { get; set; }
        public long enable_dices { get; set; }
        public long enable_flags { get; set; }
        public long enable_icons { get; set; }
        public long enable_images { get; set; }
        public long enable_likes { get; set; }
        public long enable_names { get; set; }
        public long enable_oekaki { get; set; }
        public long enable_posting { get; set; }
        public long enable_sage { get; set; }
        public long enable_shield { get; set; }
        public long enable_subject { get; set; }
        public long enable_thread_tags { get; set; }
        public long enable_trips { get; set; }
        public long enable_video { get; set; }
        public long files_count { get; set; }
        public long is_board { get; set; }
        public long is_closed { get; set; }
        public long is_index { get; set; }
        public long max_comment { get; set; }
        public long max_files_size { get; set; }
        public long max_num { get; set; }
        public News_abu[] news_abu { get; set; }
        public long posts_count { get; set; }
        public Top[] top { get; set; }
        public string title { get; set; }
        public long unique_posters { get; set; }
        public Threads[] threads { get; set; }
    }

    internal class News_abu
    {
        public string date { get; set; }
        public long num { get; set; }
        public string subject { get; set; }
        public long views { get; set; }
    }

    internal class Threads
    {
        public PostInThread[] posts { get; set; }
    }

    internal class Top
    {
        public string board { get; set; }
        public string info { get; set; }
        public string name { get; set; }
    }

    internal class PostInThread
    {
        public long banned { get; set; }
        public long closed { get; set; }
        public string comment { get; set; }
        public string date { get; set; }
        public string email { get; set; }
        public long endless { get; set; }
        public File[] files { get; set; }
        public long lasthit { get; set; }
        public string name { get; set; }
        public long num { get; set; }
        public long number { get; set; }
        public long op { get; set; }
        public string parent { get; set; }
        public long sticky { get; set; }
        public string subject { get; set; }
        public long timestamp { get; set; }
        public string trip { get; set; }
    }

    internal class File
    {
        public string displayname { get; set; }
        public string fullname { get; set; }
        public long height { get; set; }
        public string md5 { get; set; }
        public string name { get; set; }
        public long nsfw { get; set; }
        public string path { get; set; }
        public long size { get; set; }
        public string thumbnail { get; set; }
        public long tn_height { get; set; }
        public long tn_width { get; set; }
        public long type { get; set; }
        public long width { get; set; }
    }
}
