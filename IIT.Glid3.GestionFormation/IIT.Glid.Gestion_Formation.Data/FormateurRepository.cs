using IIT.Glid.Gestion_Formation.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIT.Glid.Gestion_Formation.Data
{
    public class FormateurRepository : IDataRepository<Formateur>
    {
        public readonly MyContext _formateurContext;
        public FormateurRepository(MyContext context)
        {
            _formateurContext = context;
        }
        public void Add(Formateur entity)
        {
            _formateurContext.Formateur.Add(entity);
            _formateurContext.SaveChanges();
        }

        public Formateur Get(long id)
        {
            return _formateurContext.Formateur.FirstOrDefault(v => id.Equals(v.ID));
        }

        public IList<Formateur> GetAll()
        {
            return _formateurContext.Formateur.ToList();

            /*
              var F1 = new Formateur
             {
                 ID = 1,
                 Nom = "ali",
                 Prenom = "aydi",
                 Telephone = "112233",
                 Adresse = "rout sidi mansour",
                 Couts = 100
             };
             var F2 = new Formateur
             {
                 ID = 2,
                 Nom = "samir",
                 Prenom = "aydi",
                 Telephone = "778899",
                 Adresse = "rout sidi mansour",
                 Couts = 200
             };
             var list = new List<Formateur>();
             list.Add(F1);
             list.Add(F2);
             return list;
             */
        }
        public void Delete(long id)
        {
            Formateur Formateur = _formateurContext.Formateur.Find(id);
            _formateurContext.Formateur.Remove(Formateur);
        }
        public void Update(Formateur Formateur)
        {
            _formateurContext.Entry(Formateur).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
