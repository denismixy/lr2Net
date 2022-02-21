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
            StringBuilder query = new StringBuilder();
            query.Append("insert into visits " +
                        " (fio, carBrand, carNumber, carModel, startParking, endParking, parkingPlace, cost)" +
                        " values");
            query.Append(" (");
            List<String> inputFields = new List<string> { fio, carBand, carNumber, carModel, startParking, endParking, parkingPlace, cost };
            inputFields.ForEach(inputField => {
                if (inputField != null) {
                    query = query.Append($" \"{inputField}\",");
                } else {
                    query.Append(" null,");
                }
            });
            query.Remove(query.Length - 1, 1); // for delete last "," else raise SQL Syntax Error
            query.Append(")");
            return query.ToString();
        }
        public static string AssembleWhereCondition(string fio = null, string carBand = null, string carNumber = null, string carModel = null,
                                        string startParking = null, string endParking = null, string parkingPlace = null,
                                        string cost = null) {
            StringBuilder query = new StringBuilder();
            query.Append("where ");
            query.Append("(");
            Dictionary<String, Object> inputFields = new Dictionary<string, object> {
                [nameof(fio)] = fio,
                [nameof(carBand)] = carBand,
                [nameof(carNumber)] = carNumber,
                [nameof(carModel)] = carModel,
                [nameof(startParking)] = startParking,
                [nameof(endParking)] = endParking,
                [nameof(parkingPlace)] = parkingPlace,
                [nameof(cost)] = cost
            };
            foreach (KeyValuePair<String, Object> inputField in inputFields) {
                if (inputField.Value != null) {
                    query = query.Append($"{inputField.Key} = \"{inputField.Value}\" and ");
                }
            }
            query.Remove(query.Length - 5, 5); // for delete last " and " else raise SQL Syntax Error
            query.Append(")");
            return query.ToString();
        }

        public static string SearchVisit(string fio = null, string carBand = null, string carNumber = null, string carModel = null,
                                        string startParking = null, string endParking = null, string parkingPlace = null,
                                        string cost = null) {
            StringBuilder query = new StringBuilder();
            query.Append("select * " +
                        "from visits ");
            string wherePart = AssembleWhereCondition(fio, carBand, carNumber, carModel, startParking, endParking, parkingPlace, cost);
            query.Append(wherePart);
            return query.ToString();
        }

        public static string DeleteVisit(string fio = null, string carBand = null, string carNumber = null, string carModel = null,
                                        string startParking = null, string endParking = null, string parkingPlace = null,
                                        string cost = null) {
            StringBuilder query = new StringBuilder();
            query.Append("delete " +
                        "from visits ");
            string wherePart = AssembleWhereCondition(fio, carBand, carNumber, carModel, startParking, endParking, parkingPlace, cost);
            query.Append(wherePart);
            return query.ToString();
        }

        public static string ShowAllVisits() {
            StringBuilder query = new StringBuilder();
            query.Append("select * " +
                        "from visits ");
            return query.ToString();
        }
    }
}
