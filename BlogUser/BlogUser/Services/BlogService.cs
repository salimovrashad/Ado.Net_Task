using BlogUser.Helpers;
using BlogUser.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogUser.Services
{
    public class BlogService : IBaseService<Blogs>
    {
        public int Create(Blogs data)
        {
            string query = $"INSERT INTO Blogs\r\nVALUES (N'{data.Title}', N'{data.Description}', '{data.UsersID}')";
            return SqlHelper.Exec(query);
        }

        public int Delete(int id)
        {
            string query = $"DELETE FROM Blogs WHERE ID = {id}";
            return SqlHelper.Exec(query);
        }

        public List<Blogs> GetAll()
        {
            DataTable dt = SqlHelper.GetDatas("SELECT * FROM Blogs");
            List<Blogs> list = new List<Blogs>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Blogs
                {
                    Id = (int)row["Id"],
                    Title = (string)row["Title"],
                    Description = (string)row["Description"],
                    UsersID = (int)row["UsersID"],
                });
            }
            return list;
        }

        public Blogs GetById(int id)
        {
            DataTable dt = SqlHelper.GetDatas($"SELECT * FROM Blogs WHERE ID = {id}");

            Blogs blog = new Blogs();

            foreach (DataRow row in dt.Rows)
            {
                blog.Id = (int)row["Id"];
                blog.Title = (string)row["Title"];
                blog.Description = (string)row["Description"];
            }

            return blog;
        }

        public List<Blogs> GetWhere(string query)
        {
            throw new NotImplementedException();
        }

        public int Update(int id, Blogs data)
        {
            throw new NotImplementedException();
        }
    }
}
