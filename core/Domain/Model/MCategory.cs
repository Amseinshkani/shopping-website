using System;

namespace core.Domain.Model
{
    public class MCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Parentid { get; set; }
        public bool status { get; set; }
    }
}