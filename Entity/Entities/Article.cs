using Core.Entities;

namespace Entity.Entities
{
    public class Article : EntityBase
    {
       

        public string name { get; set; }

        public string writer { get; set; }

        public string numberPages { get; set; }

        public DateTime yearOfRelease { get; set; }

        public string country { get; set; }

        public Category category { get; set; }


    }
}
