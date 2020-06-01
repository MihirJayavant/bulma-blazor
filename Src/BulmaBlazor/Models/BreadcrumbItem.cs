namespace BulmaBlazor.Models
{
    public class BreadcrumbItem
    {
        public string Text { get; set; }
        public string Link { get; set; }
        public bool IsActive { get; set; } = false;
        public string IconClass { get; set; } = "";
        public string ActiveClass => IsActive ? "is-active" : "";
    }
}