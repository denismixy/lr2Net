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

        public static string CreateVisit(string fio = null, string carBand = null, string carNumber = null, string carModel = null,
                                        string startParking = null, string endParking = null, string parkingPlace = null, 
                                        string cost = null) {
            return ("insert into visits " +
                "(fio, carBrand, carNumber, carModel, startParking, endParking, parkingPlace, cost)" +
                "" +
                "values" +
                $"({fio}, {carBand}, {carNumber}, {carModel} {startParking}, {endParking}, {parkingPlace}, {cost})");
        }
    }
}
