using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace SQL.Config
{
    [Table("Notes")]
    public class Note
    {
        [PrimaryKey,AutoIncrement,Column("_id")]
        public int Id { get; set; }
        public string Content { get; set; }
    }
}
