using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Tester
{
    class Test{

            static void Main(String[] args)
            {
                
                        Console.WriteLine("--------------");
                        TableCon();
                        Console.ReadKey();

            }

            public static void TableCon(){
                try
                    {
                        String connectionString = "Data Source=ALFREDO-SURFACE\\SQLEXPRESS;Initial Catalog=mystore;Integrated Security=True";
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            String sql = "SELECT * FROM clients";
                            using (SqlCommand command = new SqlCommand(sql, connection))
                            {
                                SqlDataReader r = command.ExecuteReader();
                                if(r.HasRows){
                                    while(r.Read())
                                    {

                                    Console.WriteLine("{0} {1} {2} {3} {4} {5}" , r["id"], r["name"], r["email"],
                                        r["phone"], r["address"], r["created_at"]);
                                    }

                                    
                                }

                                    connection.Close();
                                    r.Close();
                            }

                            
                        }
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
            }

            public static void SpecificUser(){
                try
                    {
                        String connectionString = "Data Source=ALFREDO-SURFACE\\SQLEXPRESS;Initial Catalog=mystore;Integrated Security=True";
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            String sql = "SELECT * FROM clients WHERE name='Freddy Mercury'";
                            using (SqlCommand command = new SqlCommand(sql, connection))
                            {
                                SqlDataReader r = command.ExecuteReader();
                                if(r.HasRows){
                                    while(r.Read())
                                    {

                                    Console.WriteLine("{0} {1} {2} {3} {4} {5}" , r["id"], r["name"], r["email"],
                                        r["phone"], r["address"], r["created_at"]);
                                    }

                                    
                                }

                                    connection.Close();
                                    r.Close();
                            }

                            
                        }
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
            }

            public static void AddUser(string name, string email, string phone, string address){
                    try
                    {
                        String connectionString = "Data Source=ALFREDO-SURFACE\\SQLEXPRESS;Initial Catalog=mystore;Integrated Security=True";
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            String sql = "INSERT INTO clients" + "(name, email, phone, address) VALUES " +
                                "(@name, @email, @phone, @address);";
                            using (SqlCommand command = new SqlCommand(sql, connection))
                            {
                                command.Parameters.AddWithValue("@name", name);
                                command.Parameters.AddWithValue("@email", email);
                                command.Parameters.AddWithValue("@phone", phone);
                                command.Parameters.AddWithValue("@address", address);

                                command.ExecuteNonQuery();


                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    Console.WriteLine("Client added correctly");
            }

    }
    
}