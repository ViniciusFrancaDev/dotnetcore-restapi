using System.Collections.Generic;
using System.Linq;
using dotnetcore_restapi.Models;

namespace dotnetcore_restapi.Data
{
    public class SqlSubjectRepo : ISubjectRepo
    {
        private readonly SubjectContext _context;

        public SqlSubjectRepo(SubjectContext context)
        {
            _context = context;
        }

        public IEnumerable<Subject> GetSubjects()
        {
            return _context.Subjects.ToList();
        }

        public Subject GetSubjectById(int id)
        {
            return _context.Subjects.FirstOrDefault(p => p.Id == id);
        }
    }
}
