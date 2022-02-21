using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2Net {

    class VisitLogger {
        private List<Visit> visits;
        private Visit visitForEdit;

        public void AddVisit(string fio = null, string carBrand = null, string carNumber = null, string carModel = null,
                            string startParkingDate = null, string endParkingDate = null, string parkingPlace = null, string cost = null) {
            Visit visit = new Visit(fio, carBrand, carNumber, carModel, startParkingDate, endParkingDate, parkingPlace, cost);
            visits.Add(visit);
        }

        public void ChoiceVisitForChange(string fio = null, string carBrand = null, string carNumber = null, string carModel = null,
                            string startParkingDate = null, string endParkingDate = null, string parkingPlace = null, string cost = null) {
            visitForEdit = new Visit(fio, carBrand, carNumber, carModel, startParkingDate, endParkingDate, parkingPlace, cost);
        }

        public void DeleteVisit() {
            visits.RemoveAll(element => element.Equals(visitForEdit));
        }

        public void EditVisit(string fio = null, string carBrand = null, string carNumber = null, string carModel = null,
                            string startParkingDate = null, string endParkingDate = null, string parkingPlace = null, string cost = null) {
            Visit visit = new Visit(fio, carBrand, carNumber, carModel, startParkingDate, endParkingDate, parkingPlace, cost);
            visits[visits.IndexOf(visitForEdit)] = visit;
        }

        public List<Visit> GetAllVisits() {
            return new List<Visit>(visits);
        }

        public List<Visit> GetVisitsByClient(string fio) {
            return visits.Where(element => element.Fio == fio).ToList();
        }

    }
}
