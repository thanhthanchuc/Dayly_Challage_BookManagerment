using Fa.Model.Model;
using System.Collections.Generic;

namespace Fa.Service.Interface
{
    public interface IAuthor
    {
        IEnumerable<Author> GetAuthors();
        Author GetAuthor(int authorId);
        void Insert(Author author);
        void Update(Author author);
        void Delete(int authorId);
    }
}
