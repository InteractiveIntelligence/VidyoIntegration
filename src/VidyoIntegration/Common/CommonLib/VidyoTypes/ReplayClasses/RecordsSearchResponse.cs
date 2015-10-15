using System;
using System.Collections.Generic;

namespace VidyoIntegration.CommonLib.VidyoTypes.ReplayClasses
{
    [Serializable]
    public class RecordsSearchResponse
    {
        public int RoomId { get; set; }
        public int AllVideosCount { get; set; }
        public int MyVideosCount { get; set; }
        public int NewCount { get; set; }
        public int OrganizationalCount { get; set; }
        public int PrivateCount { get; set; }
        public int PublicCount { get; set; }
        public int SearchCount { get; set; }
        public int WebcastCount { get; set; }
        public List<Record> Records { get; set; }

        public void AddRecord(Record record)
        {
            if (Records == null)
            {
                Records = new List<Record>();
            }
            Records.Add(record);
        }
    }
}
