using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JumpUp
{
    public class Lesson
    {


        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string date_and_hour;

        public string Date_and_hour
        {
            get { return date_and_hour; }
            set { date_and_hour = value; }
        }
        int room;

        public int Room
        {
            get { return room; }
            set { room = value; }
        }

        public Lesson(string name, string date, int room)
        {
          
            this.date_and_hour = date;
            this.name = name;
            this.room = room;
        }
    }
}