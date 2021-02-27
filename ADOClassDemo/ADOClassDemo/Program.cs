using System;
using System.Data;
using System.Data.SqlClient;

namespace ADOClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using DataSet
            // Step 1: Connection
            SqlConnection objCon = new SqlConnection("Data Source=localhost;Initial Catalog=soch;Integrated Security=True");
            objCon.Open();

            // Step 2: Command
            SqlCommand objCommand = new SqlCommand("SELECT * FROM tblStudent", objCon);

            // Step 3: DataAdapter
            // first we need to create data adapter so as to fill into dataset
            SqlDataAdapter objAdapter = new SqlDataAdapter(objCommand);

            DataSet objDs = new DataSet();
            objAdapter.Fill(objDs);

            foreach(DataRow objRow in objDs.Tables[0].Rows)
            {
                Console.WriteLine("Student name " + objRow["stdName"] + " Roll no: " + objRow["stdRoll"]);
            }

            objCon.Close();
            Console.ReadLine();
        }
    }
}

//// Using DataReader
//// Step 1: Connection
//SqlConnection objCon = new SqlConnection("Data Source=localhost;Initial Catalog=soch;Integrated Security=True");
//objCon.Open();

//// Step 2: Command
//SqlCommand objCommand = new SqlCommand("SELECT * FROM tblStudent", objCon);

//// Step 3: DataReader
//SqlDataReader objDr = objCommand.ExecuteReader();

//// Display the data from DataReader
//while (objDr.Read())
//{
//    Console.WriteLine("Roll no: " + objDr["stdRoll"] + " Name: " + objDr["stdName"]);
//}

//objCon.Close();
//Console.ReadLine();
