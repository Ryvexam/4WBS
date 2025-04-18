using Entities;

namespace Domain;

public interface ILibraryService
{
    IEnumerable<Library> GetAll();
    
    Library AddLibrary(Library library);
}