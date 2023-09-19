using System.Runtime.InteropServices.JavaScript;

namespace GlobalLandslidesServer.Database.Entities
{
    public class LandslideDetails
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public string Category { get; set; }
        public string Trigger { get; set; }
        public string Environment { get; set; }
        public DateOnly SubmittedDate { get; set; }
        public DateOnly LastEdited { get; set; }

    }
}
