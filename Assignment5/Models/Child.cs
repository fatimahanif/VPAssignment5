using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment5.Models
{
    public class Child
    {
        //to make identity
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ChildID { get; set; }
        public byte Age { get; set; }
        public string Name { get; set; }
        public int ParentID { get; set; }

        //foreign key
        public virtual Employee Parent { get; set; }
    }
}