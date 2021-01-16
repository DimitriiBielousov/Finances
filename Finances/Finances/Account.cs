using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Finances.Models
{
    public class Account
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Currency { get; set; }
        public object Icon { get; set; }
        public bool IsDefault { get; set; }
    }
}
