using IIT.Glid.Gestion_Formation.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIT.Glid.Gestion_Formation.Data
{
    public class EtudiantRepository : IDataRepository<Etudiant>
    {
        private readonly MyContext _etudiantContext;
        public EtudiantRepository(MyContext context)
        {
            _etudiantContext = context;
        }
        public void Add(Etudiant entity)
        {
            entity.DateInscription = DateTime.Now;
            _etudiantContext.Etudiant.Add(entity);
            _etudiantContext.SaveChanges();
        }

        public Etudiant Get(long id)
        {
           return  _etudiantContext.Etudiant.FirstOrDefault(v => id.Equals(v.ID)); 
            
        }

        public IList<Etudiant> GetAll()
        {
            return _etudiantContext.Etudiant.ToList();
            /*var E1 = new Etudiant
            {
                ID = 1,
                Nom = "ali",
                Prenom = "aydi",
                Telephone = "112233",
                //DateInscription= 0001-01-01T00:00:00,
                Payement=true
            };
            var E2 = new Etudiant
            {
                ID = 2,
                Nom = "samir",
                Prenom = "aydi",
                Telephone = "778899",
                //DateInscription= 0001-01-01T00:00:00,
                Payement = false
            };
            var list = new List<Etudiant>();
            list.Add(E1);
            list.Add(E2);
            return list;*/
        }
        public void Delete(long id)
        {
            Etudiant etudiant = _etudiantContext.Etudiant.Find(id);
            _etudiantContext.Etudiant.Remove(etudiant);
        }
        public void Update(Etudiant etudiant)
        {
            _etudiantContext.Entry(etudiant).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _etudiantContext.SaveChanges();
        }
    }
}
