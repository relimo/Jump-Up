using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace JumpUp
{


public class dal
{
      //this connection is taken from the properties of the DB , from the property "Connection String"
   
    private string connection_string = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\varda sinai\Desktop\JumpUp\JumpUp\GymDB.mdf;Integrated Security=True;Connect Timeout=30";
 

   
    public string get_client_name_according_to_user_name(string u_name)
    {
        SqlConnection con = new SqlConnection(connection_string);

        con.Open();

        string sqlString = " select f_name  from clients where user_name='"+u_name+"'";
           
        SqlCommand command = new SqlCommand(sqlString, con);
        SqlDataReader rdr = command.ExecuteReader();

        string res = "";
        while (rdr.Read())
        {
          //  res = res + rdr[0] + Environment.NewLine;
            res = res + rdr[0] ;
        }

        con.Close();
        return res;

    }


    public string delete_lesson(string u_name,string date, int room)
    {
        SqlConnection con = new SqlConnection(connection_string);

        con.Open();

        string sqlString = "delete from lessons_of_clients where user_name='" + u_name + "'" + " and date_time='" + date + "' and room=" + room;

        SqlCommand command = new SqlCommand(sqlString, con);
        SqlDataReader rdr = command.ExecuteReader();

        string res = "";
        while (rdr.Read())
        {
            //  res = res + rdr[0] + Environment.NewLine;
            res = res + rdr[0];
        }

        con.Close();
        return res;

    }
    
   
  

                public string getdate_and_room_according_to_userName(string u_name)
                {
                    SqlConnection con = new SqlConnection(connection_string);
                    try
                    {
                        con.Open();
                    }
                    catch (Exception)
                    {

                        return "error";
                    }


                    string sqlString = "select date_time, room  from client's_lessons where user_name=' " + u_name + "' ";

                    SqlCommand command = new SqlCommand(sqlString, con);
                    SqlDataReader rdr = command.ExecuteReader();

                    string res = "";
                    while (rdr.Read())
                    {
                        res = res + rdr[0] + Environment.NewLine;
                    }

                    con.Close();
                    return res;

                }


     public string getLesson_name_according_to_date_and_room(string date,int room)
                {
                    SqlConnection con = new SqlConnection(connection_string);
                    try
                    {
                        con.Open();
                    }
                    catch (Exception)
                    {

                        return "error";
                    }


                    string sqlString = "select name from lessons where date_time='" + date + "' and room_num="+room;

                    SqlCommand command = new SqlCommand(sqlString, con);
                    SqlDataReader rdr = command.ExecuteReader();

                    string res = "";
                    while (rdr.Read())
                    {
                        res = res + rdr[0] + Environment.NewLine;
                    }

                    con.Close();
                    return res;

                }
     public string getLesson_name_according_to_date(string date)
     {
         SqlConnection con = new SqlConnection(connection_string);

         con.Open();

         string sqlString = "select name, room_num from lessons where date_time='" + date + "'";
         SqlCommand command = new SqlCommand(sqlString, con);
         SqlDataReader rdr = command.ExecuteReader();

         string res = "";
         while (rdr.Read())
         {
             res = res + rdr[0] + "     room: " + rdr[1] + Environment.NewLine;
         }

         con.Close();
         return res;

     } 
   

                public LinkedList<Lesson> getDetailsForUser(string user)//return list of existing  lessons of specific user
                {
                    SqlConnection con = new SqlConnection(connection_string);
                    con.Open();
                    string sqlString = "select * from lessons_of_clients where user_name='" + user + "';";
                    SqlCommand command = new SqlCommand(sqlString, con);
                    SqlDataReader rdr = command.ExecuteReader();
                    LinkedList<Lesson> res = new LinkedList<Lesson>();
                    while (rdr.Read())
                    {
                       // Lesson lesson = new Lesson("yoga", "10/10/15 16:00:00", 4);
                        string date=(string)rdr[1];
                        
                        int room=Convert.ToInt16(rdr[2]);
                        string lesson_name=getLesson_name_according_to_date_and_room(date,room);
                       Lesson lesson = new Lesson(lesson_name,date,room );
                      //  Lesson lesson = new Lesson((string)rdr[0], (string)rdr[1], 5);
                        res.AddLast(lesson);
                        //res.AddLast(new Lesson((string)rdr[0], (string)rdr[1], (int)rdr[2]));
                    }
                    con.Close();
                    return res;
                }

                public string getDateAndTime_according_to_lesson(string name)
                {
                    SqlConnection con = new SqlConnection(connection_string);
                    try
                    {
                        con.Open();
                    }
                    catch (Exception)
                    {

                        return "error";
                    }


                    string sqlString = "select date_time,room_num from lessons where name='" + name + "' ";

                    SqlCommand command = new SqlCommand(sqlString, con);
                    SqlDataReader rdr = command.ExecuteReader();

                    string res = "";
                    while (rdr.Read())
                    {
                        res = res + rdr[0] +"    room: "+rdr[1]+ Environment.NewLine;
                    }

                    con.Close();
                    return res;

                }


                public string UserName_exists(string name)
                {
                    SqlConnection con = new SqlConnection(connection_string);
                    try
                    {
                        con.Open();
                    }
                    catch (Exception)
                    {

                         return "error";
                    }
                   

                    string sqlString = "select user_name from clients where user_name='" + name + "' ";

                    SqlCommand command = new SqlCommand(sqlString, con);
                    SqlDataReader rdr = command.ExecuteReader();

                    string res = "";
                    while (rdr.Read())
                    {
                        res = res + rdr[0] + Environment.NewLine;
                    }

                    con.Close();
                    return res;

                }


                public string UserName_andPasword_exist(string name,string password)
                {
                    SqlConnection con = new SqlConnection(connection_string);

                    con.Open();

                    string sqlString = "select user_name from clients where user_name='"+name+"' and password='"+password+"'";

                    SqlCommand command = new SqlCommand(sqlString, con);
                    SqlDataReader rdr = command.ExecuteReader();

                    string res = "";
                    while (rdr.Read())
                    {
                        res = res + rdr[0] + Environment.NewLine;
                    }

                    con.Close();
                    return res;

                }
	
             
                public string getPassword(string userName)
                {
                    SqlConnection con = new SqlConnection(connection_string);

                    con.Open();

                    string sqlString = "select password from clients where user_name='" + userName + "'";
                    SqlCommand command = new SqlCommand(sqlString, con);
                    SqlDataReader rdr = command.ExecuteReader();

                    string res = "";
                    while (rdr.Read())
                    {
                        res = res + rdr[0];
                    }

                    con.Close();
                    return res;

                }
               
              
	


}//dal

} //namespace                     
      