namespace BlogUser.Models
{
    public class Blogs
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int? UsersID { get; set; }

        public override string ToString()
        {
            return $"{Id}. {Title} - {Description}";
        }
    }
}
