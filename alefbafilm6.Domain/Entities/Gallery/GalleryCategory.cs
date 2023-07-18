namespace alefbafilm6.Domain.Entities.Gallery
{
    public class GalleryCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<GalleryInCategory> GalleryInCategory{ get; set; }
    }
}
