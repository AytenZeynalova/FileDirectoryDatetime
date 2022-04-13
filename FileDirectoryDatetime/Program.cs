using System;
using ClassLibrary;
namespace FileDirectoryDatetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Meeting meeting1 = new Meeting();
            meeting1.Name = "meeting1";
            meeting1.FromDate = new DateTime(2022, 1, 10, 11, 24, 0);
            meeting1.ToDate = new DateTime(2022, 1, 10, 15, 0, 0);

            Meeting meeting2 = new Meeting();
            meeting2.Name = "meeting1";
            meeting2.FromDate = new DateTime(2022,1 , 10, 7, 24, 0);
            meeting2.ToDate = new DateTime(2022, 1, 10, 10, 0, 0);

            MeetingSchedule meetingSchedule = new MeetingSchedule();
            meetingSchedule.Meetings.Add(meeting1);
            meetingSchedule.Meetings.Add(meeting2);


            DateTime from = new DateTime(2022, 1, 10,8 , 25, 0);
            DateTime to = new DateTime(2022, 1, 10, 11, 0, 0);
            meetingSchedule.SetMeeting("meeting3", from, to);


            Console.WriteLine(";;;;;;;;;;;;;;;;;;;All Meetings;;;;;;;;;;;;;;;;;;\n");
            foreach (var item in meetingSchedule.Meetings)
            {
                Console.WriteLine(item.Name + "\n");
            }

            Console.WriteLine(";;;;;;;;;;;;;;;;;;Find Meetings Count;;;;;;;;;;;;;;;;;;\n");
            Console.WriteLine(meetingSchedule.FindMeetingsCount(new DateTime(2022, 4, 13, 11, 30, 0)) + "\n");


            Console.WriteLine(";;;;;;;;;;;;;;;;;;Is Exists Meeting By Name;;;;;;;;;;;;;;;;;\n");
            Console.WriteLine(meetingSchedule.IsExistsMeetingByName("meeting4"));


            Console.WriteLine(";;;;;;;;;;;;;;;;Get Exist Meetings;;;;;;;;;;;;;\n");
            foreach (var item in meetingSchedule.GetExistMeetings("meeting3"))
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
