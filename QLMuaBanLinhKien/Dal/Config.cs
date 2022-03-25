using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLMuaBanLinhKien.Dal
{
    public class Config
    {
        public static string ConnectionString = $"Data Source= {Environment.GetEnvironmentVariable("Data Source")}; Initial Catalog=QuanLyLinhKien; Integrated Security=True";
    }
}
