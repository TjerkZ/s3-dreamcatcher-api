namespace s3_dreamcatcher_api.ViewModels
{
    public class DreamViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string UserID { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public virtual ICollection<TagViewModel>? Tags { get; set; }
    }
}
