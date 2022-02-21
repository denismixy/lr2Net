using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2Net {
    class QueryBuilder {
        public static string CreateTableVisits() {
            return "create table visits(" +
                "fio varchar(100)," +
                " carBrand varchar(100)," +
                " carNumber varchar(100)," +
                " carModel varchar(100)," +
                " startParking varchar(100)," +
                " endParking varchar(100), " +
                "parkingPlace varchar(100)," +
                " cost varchar(100)" +
                " )";
        }
    }
}
