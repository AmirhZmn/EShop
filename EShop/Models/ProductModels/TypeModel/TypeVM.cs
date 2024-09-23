namespace EShop.Models.ProductModels.TypeModel
{
    public class TypeVM
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public TypeVM(string name)
        {
            Name = name;
        }
    }
}
