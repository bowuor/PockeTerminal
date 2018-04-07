using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PockeTerminal.DB
{
	class DBHelper
	{
		private MySqlConnection connection;
		private string server;
		private string database;
		private string uid;
		private string password;

		//Constructor
		public DBHelper()
		{
			Initialize();
		}

		//Initialize values
		private void Initialize(){
			server = "localhost";
			database = "pockeclient";
			uid = "root";
			password = "toor";
			string connectionString;
			connectionString = "SERVER=" + server + ";" + "DATABASE=" +
			database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

			connection = new MySqlConnection(connectionString);
		}

		//open connection to database
		private bool OpenConnection(){
		}

		//Close connection
		private bool CloseConnection(){
		}

		//Insert statement
		public static void Insert(){
		}

		//Update statement
		public static void Update(){
		}

		//Delete statement
		public static void Delete(){
		}

		//Select statement
		public List<string>[] Select(){
		}

		//Count statement
		public int Count(){
		}

		//Backup
		public void Backup(){
		}

		//Restore
		public void Restore(){
		}

	}
}
