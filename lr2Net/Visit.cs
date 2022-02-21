using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2Net
{
    class Visit {
        private string fio;
        private string carBrand;
        private string carNumber;
        private string carModel;
        private string startParkingDate;
        private string endParkingDate;
        private string parkingPlace;
        private string cost;

        public Visit() {
        }

        public Visit(string fio, string carBrand, string carNumber, string carModel, string startParkingDate, string endParkingDate, string parkingPlace, string cost) {
            this.Fio = fio;
            this.CarBrand = carBrand;
            this.CarNumber = carNumber;
            this.CarModel = carModel;
            this.startParkingDate = startParkingDate;
            this.endParkingDate = endParkingDate;
            this.parkingPlace = parkingPlace;
            this.cost = cost;

        }

        public string StartParkingDate { get => startParkingDate; set => startParkingDate = value; }
        public string EndParkingDate { get => endParkingDate; set => endParkingDate = value; }
        public string ParkingPlace { get => parkingPlace; set => parkingPlace = value; }
        public string Cost { get => cost; set => cost = value; }
        public string Fio { get => fio; set => fio = value; }
        public string CarBrand { get => carBrand; set => carBrand = value; }
        public string CarNumber { get => carNumber; set => carNumber = value; }
        public string CarModel { get => carModel; set => carModel = value; }

        public override bool Equals(object obj) {
            return obj is Visit visit &&
                   fio == visit.fio &&
                   carBrand == visit.carBrand &&
                   carNumber == visit.carNumber &&
                   carModel == visit.carModel &&
                   startParkingDate == visit.startParkingDate &&
                   endParkingDate == visit.endParkingDate &&
                   parkingPlace == visit.parkingPlace &&
                   cost == visit.cost &&
                   StartParkingDate == visit.StartParkingDate &&
                   EndParkingDate == visit.EndParkingDate &&
                   ParkingPlace == visit.ParkingPlace &&
                   Cost == visit.Cost &&
                   Fio == visit.Fio &&
                   CarBrand == visit.CarBrand &&
                   CarNumber == visit.CarNumber &&
                   CarModel == visit.CarModel;
        }

        public override int GetHashCode() {
            int hashCode = -793728220;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(fio);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(carBrand);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(carNumber);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(carModel);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(startParkingDate);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(endParkingDate);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(parkingPlace);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(cost);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(StartParkingDate);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(EndParkingDate);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ParkingPlace);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Cost);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Fio);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CarBrand);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CarNumber);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CarModel);
            return hashCode;
        }
    }
}
