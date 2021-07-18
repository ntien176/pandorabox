using DataProvider;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_IO
{
    public class DBIO
    {
        PandoraDB myDB = new PandoraDB();
        public PandoraTable GetObject_Data(string uid, string pwd)
        {
            //Khoong su dung Parameters
            string SQL = "SELECT * FROM PandoraTable WHERE Uid='" + uid + "' AND Pwd='" + pwd + "'";
            return myDB.Database.SqlQuery<PandoraTable>(SQL).FirstOrDefault();
            //Co su dung parameters
            //return myDB.Database.SqlQuery<PandoraTable>(
            //    "SELECT * FROM PandoraTable WHERE Uid=@U AND Pwd=@P)",
            //    new SqlParameter("@U", uid),
            //    new SqlParameter("@P", pwd)
            //    ).FirstOrDefault();

        }
    }
}
