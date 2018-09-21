using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dvoshLibCore.DTO;

namespace dvoshLibCore.Objects
{
    /// <summary>
    /// Хранит список тредов по борде
    /// </summary>
    public class Board
    {
        private BoardDto _dto;

        public string BoardName { get => _dto.board; }
        public List<ThreadInfo> Threads { get; }

        internal Board(BoardDto dto)
        {
            _dto = dto;
            Threads = _dto.threads.OrderBy(x => x.posts_count).ThenBy(x => x.score).Select(x => new ThreadInfo(x)).ToList();
        }
    }

    /// <summary>
    /// Информация о треде
    /// </summary>
    public class ThreadInfo
    {
        private ThreadInBoard _dto;

        public string Subject { get => _dto.subject; }
        public long Id { get => _dto.num; }
        public double Score { get => _dto.score; }
        public long Posts { get => _dto.posts_count; }
        public long Views { get => _dto.views; }

        internal ThreadInfo(ThreadInBoard dto)
        {
            _dto = dto;
        }
    }
}
