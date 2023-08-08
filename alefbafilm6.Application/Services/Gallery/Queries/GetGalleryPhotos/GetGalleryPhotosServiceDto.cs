namespace alefbafilm6.Application.Services.Gallery.Queries.GetGalleryPhotos
{
    public class GetGalleryPhotosServiceDto
    {
        public long IdPhoto { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public string Filename { get; set; }
        public int IdCategory { get; set; }
        public string NameCategory { get; set; }
    }
}
