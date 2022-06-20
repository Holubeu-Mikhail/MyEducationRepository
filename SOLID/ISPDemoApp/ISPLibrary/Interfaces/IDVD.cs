using System.Collections.Generic;
using ISPLibrary.Interfaces;

namespace ISPLibrary
{
    public interface IDVD : ILibraryItem
    {
        List<string> Actors { get; set; }

        int RuntimeInMinutes { get; set; }
    }
}
