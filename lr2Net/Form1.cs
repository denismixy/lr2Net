using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace lr2Net {
    public partial class Form1 : Form {
        
        public Form1(MySqlCommand mySqlCommand) {
            InitializeComponent(mySqlCommand);            
        }

        private void InitializeComponent(MySqlCommand mySqlCommand) {
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(793, 467);
            this.Controls.Add(this.button10);
            this.Name = "Form1";
            this.ResumeLayout(false);
            TestInit(mySqlCommand);

        }

        private void TestInit(MySqlCommand mySqlCommand) {
            this.currentVisitIndex = 0;
            this.visits = new List<Visit>();
            this.mySqlCommand = mySqlCommand;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fio = new System.Windows.Forms.TextBox();
            this.carBrand = new System.Windows.Forms.TextBox();
            this.carModel = new System.Windows.Forms.TextBox();
            this.carNumber = new System.Windows.Forms.TextBox();
            this.startParkingDate = new System.Windows.Forms.TextBox();
            this.endParkingDate = new System.Windows.Forms.TextBox();
            this.parkingPlace = new System.Windows.Forms.TextBox();
            this.cost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1 StartMenu
            // 
            this.button1.Location = new System.Drawing.Point(97, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 110);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add visit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ShowAddVisitWindow);
            // 
            // button2 StartMenu
            // 
            this.button2.Location = new System.Drawing.Point(321, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 110);
            this.button2.TabIndex = 1;
            this.button2.Text = "Show all visits";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ShowAllVisitsWindow);
            // 
            // button3 StartMenu
            // 
            this.button3.Location = new System.Drawing.Point(561, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 110);
            this.button3.TabIndex = 2;
            this.button3.Text = "Show visits by client";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ShowVisitsByClientWindow);
            // 
            // button4 AddVisit
            // 
            this.button4.Location = new System.Drawing.Point(108, 406);
            this.button4.Name = "Return to menu";
            this.button4.Size = new System.Drawing.Size(141, 62);
            this.button4.TabIndex = 0;
            this.button4.Text = "Return to menu";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ReturnToMenu);
            // 
            // button5 AddVisit
            // 
            this.button5.Location = new System.Drawing.Point(544, 406);
            this.button5.Name = "Add Visit";
            this.button5.Size = new System.Drawing.Size(154, 62);
            this.button5.TabIndex = 1;
            this.button5.Text = "Add Visit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ExecuteAddVisitQuery);
            // 
            // button6 SearchVisits
            // 
            this.button6.Location = new System.Drawing.Point(544, 406);
            this.button6.Name = "Search Visits";
            this.button6.Size = new System.Drawing.Size(154, 62);
            this.button6.TabIndex = 1;
            this.button6.Text = "Search Visits";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.ExecuteShowVisitsByParamsQuery);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(718, 1);
            this.button7.Name = "Next";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 0;
            this.button7.Text = "Next";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.ShowNextVisit);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(2, 1);
            this.button8.Name = "Previous";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 1;
            this.button8.Text = "Previous";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.ShowPreviousVisit);
            // 
            // button9 AddVisit
            // 
            this.button9.Location = new System.Drawing.Point(544, 406);
            this.button9.Name = "Edit Visit";
            this.button9.Size = new System.Drawing.Size(154, 62);
            this.button9.TabIndex = 1;
            this.button9.Text = "Edit Visit";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.EditVisit);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(320, 406);
            this.button10.Name = "Delete Visit";
            this.button10.Size = new System.Drawing.Size(154, 62);
            this.button10.TabIndex = 0;
            this.button10.Text = "Delete Visit";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.DeleteVisit);
            // 
            // label1 AddVisit
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CarBrand";
            /*this.label1.Click += new System.EventHandler(this.label1_Click);*/
            // 
            // label2 AddVisit
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "FIO";
            // 
            // label3 AddVisit
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CarModel";
            // 
            // label4 AddVisit
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(669, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "CarNumber";
            // 
            // label5 AddVisit
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "StartParking";
            // 
            // label6 AddVisit
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "EndPaking";
            // 
            // label7 AddVisit
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(497, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "ParkingPlace";
            // 
            // label8 AddVisit
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(701, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Cost";
            // 
            // textBox1 AddVisit
            // 
            this.fio.Location = new System.Drawing.Point(151, 46);
            this.fio.Name = "FIO";
            this.fio.Size = new System.Drawing.Size(502, 20);
            this.fio.TabIndex = 10;
            /*this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);*/
            // 
            // textBox2 AddVisit
            // 
            this.carBrand.Location = new System.Drawing.Point(47, 157);
            this.carBrand.Name = "CarBrand";
            this.carBrand.Size = new System.Drawing.Size(127, 20);
            this.carBrand.TabIndex = 11;
            // 
            // textBox3 AddVisit
            // 
            this.carModel.Location = new System.Drawing.Point(322, 157);
            this.carModel.Name = "CarModel;";
            this.carModel.Size = new System.Drawing.Size(172, 20);
            this.carModel.TabIndex = 12;
            // 
            // textBox4 AddVisit
            // 
            this.carNumber.Location = new System.Drawing.Point(629, 157);
            this.carNumber.Name = "CarNumber";
            this.carNumber.Size = new System.Drawing.Size(126, 20);
            this.carNumber.TabIndex = 13;
            // 
            // textBox5 AddVisit
            // 
            this.startParkingDate.Location = new System.Drawing.Point(31, 317);
            this.startParkingDate.Name = "StartParking";
            this.startParkingDate.Size = new System.Drawing.Size(127, 20);
            this.startParkingDate.TabIndex = 14;
            // 
            // textBox6 AddVisit
            // 
            this.endParkingDate.Location = new System.Drawing.Point(244, 317);
            this.endParkingDate.Name = "EndParking";
            this.endParkingDate.Size = new System.Drawing.Size(136, 20);
            this.endParkingDate.TabIndex = 15;
            // 
            // textBox7 AddVisit
            // 
            this.parkingPlace.Location = new System.Drawing.Point(462, 317);
            this.parkingPlace.Name = "ParkingPlace";
            this.parkingPlace.Size = new System.Drawing.Size(139, 20);
            this.parkingPlace.TabIndex = 16;
            // 
            // textBox8 AddVisit
            //
            this.cost.Location = new System.Drawing.Point(651, 317);
            this.cost.Name = "Cost";
            this.cost.Size = new System.Drawing.Size(121, 20);
            this.cost.TabIndex = 17;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(809, 506);
            this.Name = "Form1";
            ShowStartWindow();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void ClearAllTextBoxes() {
            this.fio.Text = string.Empty;
            this.carBrand.Text = string.Empty;
            this.carModel.Text = string.Empty;
            this.carNumber.Text = string.Empty;
            this.startParkingDate.Text = string.Empty;
            this.endParkingDate.Text = string.Empty;
            this.parkingPlace.Text = string.Empty;
            this.cost.Text = string.Empty;
        }

        private void ShowStartWindow() {
            this.Controls.Clear();
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
        }

        private void ShowAddVisitWindow(object sender, EventArgs e) {
            ClearAllTextBoxes();
            this.Controls.Clear();
            this.Controls.Add(this.cost);
            this.Controls.Add(this.parkingPlace);
            this.Controls.Add(this.endParkingDate);
            this.Controls.Add(this.startParkingDate);
            this.Controls.Add(this.carNumber);
            this.Controls.Add(this.carModel);
            this.Controls.Add(this.carBrand);
            this.Controls.Add(this.fio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
        }

        private void ShowVisitsByClientWindow(object sender, EventArgs e) {
            this.currentVisitIndex = 0;
            this.visits.Clear();
            ClearAllTextBoxes();
            this.Controls.Clear();
            this.Controls.Add(this.cost);
            this.Controls.Add(this.parkingPlace);
            this.Controls.Add(this.endParkingDate);
            this.Controls.Add(this.startParkingDate);
            this.Controls.Add(this.carNumber);
            this.Controls.Add(this.carModel);
            this.Controls.Add(this.carBrand);
            this.Controls.Add(this.fio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
        }

        private void ShowAllVisitsWindow(object sender, EventArgs e) {
            this.currentVisitIndex = 0;
            this.visits.Clear();
            ExecuteShowAllVisitsQuery();
            try {
                this.visits.ElementAt(currentVisitIndex);
            } catch (ArgumentOutOfRangeException) {
                MessageBox.Show("Table is empty");
                ShowStartWindow();
                return;
            }
            ShowClientByIndex();
        }

        private void ShowClientByIndex() {
            ClearAllTextBoxes();
            Visit visit = new Visit();
            try {
                visit = this.visits.ElementAt(currentVisitIndex);
            } catch (ArgumentOutOfRangeException) {
                MessageBox.Show("Exception in ShowClientByIndex");
                return;
            }
            this.fio.Text = visit.Fio;
            this.carBrand.Text = visit.CarBrand;
            this.carModel.Text = visit.CarNumber;
            this.carNumber.Text = visit.CarModel;
            this.startParkingDate.Text = visit.StartParkingDate;
            this.endParkingDate.Text = visit.EndParkingDate;
            this.parkingPlace.Text = visit.ParkingPlace;
            this.cost.Text = visit.Cost;
            this.Controls.Clear();
            this.Controls.Add(this.cost);
            this.Controls.Add(this.parkingPlace);
            this.Controls.Add(this.endParkingDate);
            this.Controls.Add(this.startParkingDate);
            this.Controls.Add(this.carNumber);
            this.Controls.Add(this.carModel);
            this.Controls.Add(this.carBrand);
            this.Controls.Add(this.fio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button10);
        }

        private void ShowNextVisit(object sender, EventArgs e) {
            this.currentVisitIndex++;
            try {
                this.visits.ElementAt(currentVisitIndex);
            } catch (ArgumentOutOfRangeException) {
                MessageBox.Show("You have reached the end of the list");
                this.currentVisitIndex--;
                return;
            }
            ShowClientByIndex();
        }

        private void ShowPreviousVisit(object sender, EventArgs e) {
            this.currentVisitIndex--;
            try {
                this.visits.ElementAt(currentVisitIndex);
            } catch (ArgumentOutOfRangeException) {
                MessageBox.Show("You have reached the top of the list");
                this.currentVisitIndex++;
                return;
            }
            ShowClientByIndex();
        }

        private void EditVisit(object sender, EventArgs e) {
            Visit visit = new Visit(fio.Text, carBrand.Text, carNumber.Text, carModel.Text,
                                    startParkingDate.Text, endParkingDate.Text, parkingPlace.Text, cost.Text);
            Visit verificationVisit = new Visit("", "", "", "", "", "", "", "");
            if (verificationVisit.Equals(visit)) {
                MessageBox.Show("All the fields can't be empty");
                return;
            }
            this.mySqlCommand.CommandText = QueryBuilder.UpdateVisit(this.visits[currentVisitIndex], visit);
            MessageBox.Show("affected rows: " + this.mySqlCommand.ExecuteNonQuery().ToString());
            this.visits[currentVisitIndex] = visit;
            ShowClientByIndex();
        }

        private void DeleteVisit(object sender, EventArgs e) {
            Visit visit = this.visits[currentVisitIndex];
            this.mySqlCommand.CommandText = QueryBuilder.DeleteVisit(visit);
            MessageBox.Show("affected rows: " + this.mySqlCommand.ExecuteNonQuery().ToString());
            this.visits.RemoveAt(currentVisitIndex);
            if (visits.Count == 0) {
                MessageBox.Show("Table is empty");
                ShowStartWindow();
            } else {
                ShowAllVisitsWindow(sender, e);
            }
        }

        private void ReturnToMenu(object sender, EventArgs e) {
            this.ShowStartWindow();
        }

        private void ExecuteAddVisitQuery(object sender, EventArgs e) {
            Visit visit = new Visit(fio.Text, carBrand.Text, carNumber.Text, carModel.Text,
                                    startParkingDate.Text, endParkingDate.Text, parkingPlace.Text, cost.Text);
            Visit verificationVisit = new Visit("", "", "", "", "", "", "", "");
            if (verificationVisit.Equals(visit)) {
                MessageBox.Show("All the fields can't be empty");
                return;
            }
            this.mySqlCommand.CommandText = QueryBuilder.CreateVisit(visit);
            MessageBox.Show("affected rows: " + this.mySqlCommand.ExecuteNonQuery().ToString());
        }

        private void ExecuteShowVisitsByParamsQuery(object sender, EventArgs e) {
            Visit searchParams = new Visit(fio.Text, carBrand.Text, carNumber.Text, carModel.Text,
                                    startParkingDate.Text, endParkingDate.Text, parkingPlace.Text, cost.Text);
            Visit verificationVisit = new Visit("", "", "", "", "", "", "", "");
            if (verificationVisit.Equals(searchParams)) {
                MessageBox.Show("All the fields can't be empty");
                return;
            }
            this.mySqlCommand.CommandText = QueryBuilder.SearchVisitsByParams(searchParams);
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            while (mySqlDataReader.Read()) {
                Visit visit = new Visit(mySqlDataReader.IsDBNull(mySqlDataReader.GetOrdinal("fio")) ?
                                        "" : mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("fio")),
                                        mySqlDataReader.IsDBNull(mySqlDataReader.GetOrdinal("carBrand")) ?
                                        "" : mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("carBrand")),
                                        mySqlDataReader.IsDBNull(mySqlDataReader.GetOrdinal("carNumber")) ?
                                        "" : mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("carNumber")),
                                        mySqlDataReader.IsDBNull(mySqlDataReader.GetOrdinal("carModel")) ?
                                        "" : mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("carModel")),
                                        mySqlDataReader.IsDBNull(mySqlDataReader.GetOrdinal("startParkingDate")) ?
                                        "" : mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("startParkingDate")),
                                        mySqlDataReader.IsDBNull(mySqlDataReader.GetOrdinal("endParkingDate")) ?
                                        "" : mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("endParkingDate")),
                                        mySqlDataReader.IsDBNull(mySqlDataReader.GetOrdinal("parkingPlace")) ?
                                        "" : mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("parkingPlace")),
                                        mySqlDataReader.IsDBNull(mySqlDataReader.GetOrdinal("cost")) ?
                                        "" : mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("cost")),
                                        mySqlDataReader.IsDBNull(mySqlDataReader.GetOrdinal("id")) ?
                                        "" : mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("id")));
                this.visits.Add(visit);
            }
            if (!mySqlDataReader.HasRows) {
                MessageBox.Show("Records missing");
                mySqlDataReader.Close();
            } else {
                ShowClientByIndex();
                mySqlDataReader.Close();
            }
        }

        private void ExecuteShowAllVisitsQuery() {
            mySqlCommand.CommandText = QueryBuilder.ShowAllVisits();
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            while (mySqlDataReader.Read()) {
                Visit visit = new Visit(mySqlDataReader.IsDBNull(mySqlDataReader.GetOrdinal("fio")) ?
                                        "" : mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("fio")),
                                        mySqlDataReader.IsDBNull(mySqlDataReader.GetOrdinal("carBrand")) ?
                                        "" : mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("carBrand")),
                                        mySqlDataReader.IsDBNull(mySqlDataReader.GetOrdinal("carNumber")) ?
                                        "" : mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("carNumber")),
                                        mySqlDataReader.IsDBNull(mySqlDataReader.GetOrdinal("carModel")) ?
                                        "" : mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("carModel")),
                                        mySqlDataReader.IsDBNull(mySqlDataReader.GetOrdinal("startParkingDate")) ?
                                        "" : mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("startParkingDate")),
                                        mySqlDataReader.IsDBNull(mySqlDataReader.GetOrdinal("endParkingDate")) ?
                                        "" : mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("endParkingDate")),
                                        mySqlDataReader.IsDBNull(mySqlDataReader.GetOrdinal("parkingPlace")) ?
                                        "" : mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("parkingPlace")),
                                        mySqlDataReader.IsDBNull(mySqlDataReader.GetOrdinal("cost")) ?
                                        "" : mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("cost")),
                                        mySqlDataReader.IsDBNull(mySqlDataReader.GetOrdinal("id")) ?
                                        "" : mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("id")));
                this.visits.Add(visit);
            }
            mySqlDataReader.Close();
        }
    }
}
