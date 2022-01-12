using IIT.Glid.Gestion_Formation.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIT.Glid.Gestion_Formation.Data
{
    public class FormationRepository : IDataRepository<Formation>
    {
        public readonly MyContext _formationContext;
        public FormationRepository (MyContext context)
        {
            _formationContext = context;
        }
        public void Add(Formation entity)
        {
            _formationContext.Formation.Add(entity);
            _formationContext.SaveChanges();
        }

        public Formation Get(long id)
        {
            return _formationContext.Formation.FirstOrDefault(v => id.Equals(v.ID));
        }

        public IList<Formation> GetAll()

        {
            return _formationContext.Formation.ToList();
            /*
             var F1 = new Formation
            {
                ID = 1,
                Sujet = "react",
                //Date = "aydi",
                Duree = 20,
                Frais = 200,
                Formateur = null,
                Etudiants = null
            };
            var F2 = new Formation
            {
                ID = 1,
                Sujet = "JEE",
                //Date = "aydi",
                Duree = 30,
                Frais = 300,
                Formateur = null,
                Etudiants = null
            };
            var list = new List<Formation>();
            list.Add(F1);
            list.Add(F2);
            return list;
             */
        }
        public void Delete(long id)
        {
            Formation Formation = _formationContext.Formation.Find(id);
            _formationContext.Formation.Remove(Formation);
        }
        public void Update(Formation Formation)
        {
            _formationContext.Entry(Formation).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
    
}
