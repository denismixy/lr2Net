﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace lr2Net {
    class DBMySQLUtils {
        public static MySqlConnection GetDBConnection(string host, int port, string database, string username, string password) {
            String connectionString = "Server=" + host + ";Database=" + database + ";port=" + port 
                                    + ";User Id=" + username + ";password=" + password;
            MySqlConnection connection = new MySqlConnection(connectionString);
            return connection;
        }
    }
}
