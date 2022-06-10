namespace s3_dreamcatcher_api.ViewModels
{
    public class TagViewModel
    {
        public int ID { get; set; }
        public string TagName { get; set; } = string.Empty;
        public ICollection<DreamViewModel>? Dreams { get; set; }
    }
}
