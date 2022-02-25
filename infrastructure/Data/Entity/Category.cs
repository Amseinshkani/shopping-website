using System;

namespace infrastructure.Data.Entity
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Parentid { get; set; }
        public bool status { get; set; }
    }
}