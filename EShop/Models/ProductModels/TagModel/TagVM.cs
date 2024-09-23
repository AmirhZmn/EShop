namespace EShop.Models.ProductModels.TagModel
{
    public class TagVM
    {
        public double Id { get; set; }
        public string description { get; set; }

        public TagVM(string description)
        {
            this.description = description;
        }
    }
}
