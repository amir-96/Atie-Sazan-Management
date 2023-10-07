namespace Domain.ContextModels
{
    public class Engineer : BaseModel
    {
        public string Name { get; set; }
        public ETEnum Type { get; set; }
        public bool IsActive { get; set; }
    }
}