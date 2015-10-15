using System;

namespace VidyoIntegration.CommonLib.VidyoTypes.ReplayClasses
{
    [Serializable]
    public class Record
    {
        public string Comments { get; set; }
        public DateTime DateCreated { get; set; }
        public string Duration { get; set; }
        public DateTime EndTime { get; set; }
        public string ExternalPlaybackLink { get; set; }
        public string FileLink { get; set; }
        public string FileSize { get; set; }
        public int Framerate { get; set; }
        public string Guid { get; set; }
        public int Id { get; set; }
        public bool Locked { get; set; }
        public string Pin { get; set; }
        public string RecorderId { get; set; }
        public string RecordScope { get; set; }
        public string Resolution { get; set; }
        public string RoomName { get; set; }
        public string Tags { get; set; }
        public string TenantName { get; set; }
        public string Title { get; set; }
        public string UserFullName { get; set; }
        public string Username { get; set; }
        public bool Webcast { get; set; }
    }
}
