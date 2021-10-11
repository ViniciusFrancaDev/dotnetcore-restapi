using System.Collections.Generic;
using dotnetcore_restapi.Models;

namespace dotnetcore_restapi.Data
{
    public interface ISubjectRepo
    {
        IEnumerable<Subject> GetSubjects();
        Subject GetSubjectById(int id);
    }
}
