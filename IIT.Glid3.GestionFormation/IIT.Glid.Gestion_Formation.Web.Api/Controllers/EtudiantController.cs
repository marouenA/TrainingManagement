using IIT.Glid.Gestion_Formation.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IIT.Glid.Gestion_Formation.Web.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EtudiantController: ControllerBase
    {
        private readonly ILogger<EtudiantController> _logger;
        private readonly IDataRepository<Etudiant> _etudiantRepository;

        public EtudiantController(ILogger<EtudiantController> logger, IDataRepository<Etudiant> etudiantRepository)
        {
            _logger = logger;
            _etudiantRepository = etudiantRepository;
        }
        [HttpGet]
        public IEnumerable<Etudiant> GetAll()
        {
            return _etudiantRepository.GetAll();
        }
        [HttpPost]
        public void Add(Etudiant entity)
        {
            _etudiantRepository.Add(entity);
        }
        [HttpGet("/Etudiant/{Id}")]
        public Etudiant Get(long id)
        {
            return _etudiantRepository.Get(id);
        }
        
        [HttpDelete("/Etudiant/{Id}")]
        public void Delete(long id)
        {
            _etudiantRepository.Delete(id);
        }
        [HttpPut("/Etudiant/{Id}")]
        public void Update(Etudiant etudiant)
        {
            _etudiantRepository.Update(etudiant);
        }
    }
    
}
