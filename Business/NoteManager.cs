using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class NoteManager : INoteService
    {
        private readonly INoteDal _noteDal;
        public NoteManager(INoteDal noteDal)
        {
            _noteDal = noteDal;
        }

        public void Add(Note note)
        {
            _noteDal.Add(note);
        }


        public List<Note> GetAll()
        {
            var result = _noteDal.GetAll();

            return result;
        }

        public Note GetById(int id)
        {
            var result = _noteDal.Get(x => x.Id == id);
            return result;
        }

        public List<Note> GetByStatus(bool status)
        {
            var result = _noteDal.GetAll(x => x.Status == status);
            return result;
        }


        public bool DeleteById(int id)
        {
            var result = _noteDal.Get(x => x.Id == id);
            _noteDal.Delete(result);
            return true;
        }


        public void Update(Note note)
        {
            _noteDal.Update(note);
        }


        public List<Note> Get5denKucukleri()
        {
            var result = _noteDal.GetAll(p => p.Id < 5);
            return result;
        }

        public List<Note> Get5denKucukleri(int id )
        {
            var result = _noteDal.GetAll(p => p.Id < id);
            return result;
        }

    }
}
