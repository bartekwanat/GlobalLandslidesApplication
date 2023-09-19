namespace GlobalLandslidesServer.Database.Entities
{
    public class Landslide : BaseEntity
    {
        public virtual LandslideNews LandslideNews { get; set; }
        public virtual LandslideDetails LandslideDetails{ get; set; }
        public virtual LandslideLocation LandslideLocation { get; set; }
    }
}
