

using Entities;

namespace Business
{
    public interface INoteService
    {
        List<Note> GetAll();
        List<Note> Get5denKucukleri();

        void Add(Note note);
        bool DeleteById(int id);

        void Update(Note note);

        Note GetById(int id);

        List<Note> GetByStatus(bool Status);
    }
}
