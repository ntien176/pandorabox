using Data_Provider;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseIO2
{
    public class DBIO
    {
        MyDB mydb = new MyDB();
        public we_users GetObject_User(string uid, string pwd)
        {
            /// TRA VE MOT OBJECT

            //Khong su dung Parameters
            //string SQL = "SELECT * FROM we_users WHERE Uid='" + uid + "' AND Pwd='" + pwd + "'";
            //return mydb.Database.SqlQuery<we_users>(SQL).FirstOrDefault();

            //Co su dung parameters
            //return mydb.Database.SqlQuery<we_users>(
            //    "SELECT * FROM we_users WHERE Uid=@U AND Pwd=@P",
            //    new SqlParameter("@U", uid),
            //    new SqlParameter("@P", pwd)
            //    ).FirstOrDefault();

            //Truy van Thong minh, thuong duoc su dung:
            return mydb.we_users.Where(c => c.Uid == uid & c.Pwd == pwd).FirstOrDefault();

        }

        ///TRẢ VỀ MỘT LIST
        public List<we_users> GetList_Users()
        {
            return mydb.we_users.ToList();

            //Tra ve mot List co sap xep
            //return mydb.we_users.OrderBy(c => c.Fullname).Take(2).ToList();
        }
        public void AddObject_User(string id, string uid, string pwd, string name)
        {
            mydb.Database.ExecuteSqlCommand(
                "INSERT INTO we_users(ID, Uid, Pwd, Fullname) VALUES(@I, @U, @P, @F)",
                new SqlParameter("@I", id),
                new SqlParameter("@U", uid),
                new SqlParameter("@P", pwd),
                new SqlParameter("@F", name)
                );
        }
        public we_users GetObject_UserByUsername(string Username)
        {
            return mydb.we_users.Where(c => c.Uid == Username).FirstOrDefault();
        }
    }
}
