using BlogUser.Helpers;
using BlogUser.Models;
using System.Data;

namespace BlogUser.Services
{
    public class UserService : IBaseService<Users>
    {
        public int Create(Users data)
        {
            string query = $"INSERT INTO Users\r\nVALUES (N'{data.Name}', N'{data.Surname}', '{data.Password}')";
            return SqlHelper.Exec(query);
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Users> GetAll()
        {
            DataTable dt = SqlHelper.GetDatas("SELECT * FROM Users");
            List<Users> list = new List<Users>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Users
                {
                    Id = (int)row["Id"],
                    Name = (string)row["Name"],
                    Surname = (string)row["Surname"],
                    Password = (string)row["Password"],
                });
            }
            return list;
        }

        public Users GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Users> GetWhere(string query)
        {
            throw new NotImplementedException();
        }

        public int Update(int id, Users data)
        {
            throw new NotImplementedException();
        }
    }
}
