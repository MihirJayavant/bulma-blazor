namespace BulmaBlazor.Models
{
    public record BreadcrumbItem
    {
        public string Text { get; init; }
        public string Link { get; init; }
        public bool IsActive { get; init; } = false;
        public string IconClass { get; init; } = "";
        public string ActiveClass => IsActive ? "is-active" : "";
    }
}