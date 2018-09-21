﻿using dvoshLibCore.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dvoshLibCore.Objects
{
    /// <summary>
    /// Хранит тред
    /// </summary>
    public class Thread
    {
        private ThreadDto _dto;

        public string Subject { get => this.Posts.First().Text; }
        public List<Post> Posts { get; }

        internal Thread(ThreadDto dto)
        {
            _dto = dto;
            this.Posts = _dto.threads.First().posts.Select(x => new Post(x)).ToList();
        }
    }

    /// <summary>
    /// Отдельный пост в треде
    /// </summary>
    public class Post
    {
        private PostInThread _dto;

        public string Text { get => _dto.comment; }
        public string Date { get => _dto.date; }
        public bool IsOp { get => _dto.op == 1 ? true : false; }
        public long Id { get => _dto.num; }
        public long Number { get => _dto.number; }

        internal Post(PostInThread dto)
        {
            _dto = dto;
        }
    }
}
