using System;
using System.Collections.Generic;
using System.Text;

namespace dvoshLibCore.DTO
{
    internal class ThreadInBoard
    {
        public string comment { get; set; }
        public long lasthit { get; set; }
        public long num { get; set; }
        public long posts_count { get; set; }
        public double score { get; set; }
        public string subject { get; set; }
        public long timestamp { get; set; }
        public long views { get; set; }
    }

    internal class BoardDto
    {
        public string board { get; set; }
        public ThreadInBoard[] threads { get; set; }
    }
}
