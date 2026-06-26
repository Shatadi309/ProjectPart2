using System;
using System.Data.SqlClient;
using System.Windows;

namespace Project_Part2
{//start of namespace
   public class tasks
    {//start of class


        //global connection string, with variable declaration
        string connection = @"Data source=(localdb)\MSSQLLocalDB;Database=prog_tasks";

        //creating method to test the connection
        public void test_connection()
        {//start of test connection method

            /*SQLConnection -used to make connection with Database 
             *SQLCommand - used to run queries, all of them 
             *SQLDataReader - used to read what id collected by the 
              SQLCommand, and show the user data  
             */

            //connect to the database 
            SqlConnection connect = new SqlConnection(connection);

            //try and catch any error that will be thrown
            try
            {

                //open a connection and close the connection
                connect.Open();

                //put the database query and run it
                MessageBox.Show("connected successfully..");
                //then close it after it is done
                connect.Close();
            }
            catch(Exception error)
            {
                //show message error
                MessageBox.Show(error.Message);
            }
        }//end of test connection method
        
        //method to insert or store the tasks
        public void insert_task(string name, string description, string dueDate, string status)
        {//start of insert method

            //create the connection instance
           // SqlConnection connects = new SqlConnection(connection);

             

            using (SqlConnection connects = new SqlConnection(connection))
            {//start of using

                //try and catch any error
                try
                {
                    //open the connection
                    connects.Open();

                    //do the query
                    string query = $"insert into tasks values('{name}', '{description}','{dueDate}','{status}')";

                    //then use the SqlCommand to run the query
                    SqlCommand run_query = new SqlCommand(query, connects);

                    //run the query as a nonExecuteQuery()
                    run_query.ExecuteNonQuery();

                    MessageBox.Show("Task added successfully.");

                    //close the connection
                    connects.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }

                connects.Close();

            }//end of using


        }//end of insert method


    }//end of class
}//end of namespace