using System.Collections.Generic;

namespace Models
{
    public class Book
    {
        public int Id { get;set;}
        public string Title { get; set; } 
        public bool Active {get;set;}
        //public ICollection<People> Peoples { get; set; }       
    }
}