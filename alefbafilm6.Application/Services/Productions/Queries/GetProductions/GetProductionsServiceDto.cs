namespace alefbafilm6.Application.Services.Productions.Queries.GetProductions
{
    public class GetProductionsServiceDto
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string Genre { get; set; }
        public string Time { get; set; }
        public string ProductionDate { get; set; }
        public string PhotoBig { get; set; }
        public string PhotoSmall { get; set; }
        public string InsertTime{ get; set; }
    }
}
