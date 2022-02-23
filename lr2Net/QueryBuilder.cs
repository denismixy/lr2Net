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
                " startParkingDate varchar(100)," +
                " endParkingDate varchar(100), " +
                "parkingPlace varchar(100)," +
                " cost varchar(100), " +
                "id int not null auto_increment, " +
                "primary key(id)" +
                " )";
        }

        public static string CreateVisit(Visit visit) {
            StringBuilder query = new StringBuilder();
            query.Append("insert into visits " +
                        " (fio, carBrand, carNumber, carModel, startParkingDate, endParkingDate, parkingPlace, cost)" +
                        " values");
            query.Append(" (");
            List<String> inputFields = new List<string> {visit.Fio, visit.CarBrand, visit.CarNumber, visit.CarModel,
                                                        visit.StartParkingDate, visit.EndParkingDate, visit.ParkingPlace, visit.Cost};
            inputFields.ForEach(inputField => {
                if (inputField != null && inputField != string.Empty) {
                    query = query.Append($" \"{inputField}\",");
                } else {
                    query.Append(" null,");
                }
            });
            query.Remove(query.Length - 1, 1); // for delete last "," else raise SQL Syntax Error
            query.Append(")");
            return query.ToString();
        }
        private static string AssembleWhereCondition(Visit visit) {
            StringBuilder query = new StringBuilder();
            query.Append("where ");
            query.Append("(");
            Dictionary<String, Object> inputFields = new Dictionary<string, object> {
                [nameof(visit.Fio)] = visit.Fio,
                [nameof(visit.CarBrand)] = visit.CarBrand,
                [nameof(visit.CarNumber)] = visit.CarNumber,
                [nameof(visit.CarModel)] = visit.CarModel,
                [nameof(visit.StartParkingDate)] = visit.StartParkingDate,
                [nameof(visit.EndParkingDate)] = visit.EndParkingDate,
                [nameof(visit.ParkingPlace)] = visit.ParkingPlace,
                [nameof(visit.Cost)] = visit.Cost,
                [nameof(visit.Id)] = visit.Id,
            };
            foreach (KeyValuePair<String, Object> inputField in inputFields) {
                if (inputField.Value != null && (string) inputField.Value != string.Empty) {
                    query = query.Append($"{inputField.Key} = \"{inputField.Value}\" and ");
                }
            }
            query.Remove(query.Length - 5, 5); // for delete last " and " else raise SQL Syntax Error
            query.Append(")");
            return query.ToString();
        }

        public static string SearchVisitsByParams(Visit visit) {
            StringBuilder query = new StringBuilder();
            query.Append("select * " +
                        "from visits ");
            string wherePart = AssembleWhereCondition(visit);
            query.Append(wherePart);
            return query.ToString();
        }

        public static string DeleteVisit(Visit visit) {
            StringBuilder query = new StringBuilder();
            query.Append("delete " +
                        "from visits ");
            string wherePart = AssembleWhereCondition(visit);
            query.Append(wherePart);
            return query.ToString();
        }

        public static string UpdateVisit(Visit oldVisit, Visit newVisit) {
            StringBuilder query = new StringBuilder();
            query.Append("update visits " +
                        "set ");
            Dictionary<String, Object> inputFields = new Dictionary<string, object> {
                [nameof(newVisit.Fio)] = newVisit.Fio,
                [nameof(newVisit.CarBrand)] = newVisit.CarBrand,
                [nameof(newVisit.CarNumber)] = newVisit.CarNumber,
                [nameof(newVisit.CarModel)] = newVisit.CarModel,
                [nameof(newVisit.StartParkingDate)] = newVisit.StartParkingDate,
                [nameof(newVisit.EndParkingDate)] = newVisit.EndParkingDate,
                [nameof(newVisit.ParkingPlace)] = newVisit.ParkingPlace,
                [nameof(newVisit.Cost)] = newVisit.Cost
            };
            foreach (KeyValuePair<String, Object> inputField in inputFields) {
                if (inputField.Value != null && (string)inputField.Value != string.Empty) {
                    query = query.Append($"{inputField.Key} = \"{inputField.Value}\", ");
                } else {
                    query = query.Append($"{inputField.Key} = null, ");
                }
            }
            query.Remove(query.Length - 2, 2); // for delete last ", " else raise SQL Syntax Error
            string wherePart = AssembleWhereCondition(oldVisit);
            query.Append(" "); // adds space in end of command 
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
