namespace API.RequestHelpers
{
    public class ProductParams : PaginationParams
    {
        public string orderBy { get; set; }
        public string searchTerm { get; set; }
        public string categories { get; set; }
        public string types { get; set; }
    }
}