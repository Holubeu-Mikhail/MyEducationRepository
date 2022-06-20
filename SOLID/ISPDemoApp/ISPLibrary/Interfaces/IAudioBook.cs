namespace ISPLibrary.Interfaces
{
    public interface IAudioBook : ILibraryItem
    {
        int RuntimeInMinutes { get; set; }

        string Author { get; set; }
    }
}
