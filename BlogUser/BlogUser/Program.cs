using BlogUser.Models;
using BlogUser.Services;

namespace BlogUser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserService userService = new UserService();
            BlogService blogService = new BlogService();
            while (true)
            {
                Console.WriteLine("Secim edin: \n 1.Register\n 2.Login");
                int choose = Convert.ToInt32(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        Users a = new Users
                        {
                            Name = Console.ReadLine(),
                            Surname = Console.ReadLine(),
                            Password = Console.ReadLine(),
                        };
                        userService.Create(a);
                        Console.WriteLine("User yaradildi!!!");
                        break;
                    case 2:
                        Console.WriteLine("Name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Password:");
                        string password = Console.ReadLine();
                        foreach (var user in userService.GetAll())
                        {
                            if (name == user.Name && password == user.Password)
                            {
                                Console.WriteLine("Login ugurlu...");
                                Abc:
                                Console.WriteLine("Secim edin: \n 1.All blogs.\n 2.Get blogs BY id.\n 3.Create blog.\n 4.Delete blog");
                                int choose1 = Convert.ToInt32(Console.ReadLine());

                                switch (choose1)
                                {
                                    case 1:
                                        foreach (var blog in blogService.GetAll())
                                        {
                                            Console.WriteLine($"{blog.Id}. {blog.Title + " " + blog.Description}");
                                        }
                                        goto Abc;
                                        break;
                                    case 2:
                                        Console.WriteLine("id: ");
                                        int id = Convert.ToInt32(Console.ReadLine());

                                        Blogs blogs = blogService.GetById(id);
                                        Console.WriteLine(blogs.ToString());
                                        goto Abc;
                                        break;
                                    case 3:
                                        Blogs b = new Blogs
                                        {
                                            Title = Console.ReadLine(),
                                            Description = Console.ReadLine(),
                                            UsersID = Convert.ToInt32(Console.ReadLine()),
                                        };
                                        blogService.Create(b);
                                        Console.WriteLine("Blog yaradildi!!!");
                                        goto Abc;
                                        break;
                                    case 4:
                                        Console.WriteLine("id: ");
                                        int rid = Convert.ToInt32(Console.ReadLine());
                                        blogService.Delete(rid);
                                        Console.WriteLine("Blog deleted...");
                                        goto Abc;
                                        break;
                                }
                            }
                        }
                        break;
                }
            }
        }
    }
}