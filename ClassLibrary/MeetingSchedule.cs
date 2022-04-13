using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
   public class MeetingSchedule
    {
        public List<Meeting> Meetings = new List<Meeting>();

        public void SetMeeting(string fullname, DateTime from, DateTime to)
        {
           
            
                if(Meetings.Exists(x=>(x.FromDate>from && from<x.ToDate)||(x.ToDate<from && x.FromDate<from)))
                {
                    Meeting meeting = new Meeting();
                    meeting.Name = fullname;
                    meeting.FromDate = from;
                    meeting.ToDate = to;

                    Meetings.Add(meeting);
                }
                else
                {
                    throw new Exception("bu vaxt intervalinda artiq meeting vardir");
                }
            
        }

        public int FindMeetingsCount(DateTime datetime)
        {
            return Meetings.FindAll(x => x.FromDate > datetime).Count;
        }

        public bool IsExistsMeetingByName(string name)
        {
            return Meetings.Exists(x => x.Name == name);
        }

        public List<Meeting> GetExistMeetings(string name)
        {
            List<Meeting> ExistingMeeting = new List<Meeting>();

            return Meetings.FindAll(x => x.Name.Contains(name));

        }
    }
}
