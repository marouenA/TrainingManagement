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
    public class FormationController: ControllerBase
    {
        private readonly ILogger<FormationController> _logger;
        private readonly IDataRepository<Formation> _formationRepository;

        public FormationController(ILogger<FormationController> logger, IDataRepository<Formation> formationRepository)
        {
            _logger = logger;
            _formationRepository = formationRepository;
        }
        [HttpGet]
        public IEnumerable<Formation> GetAll()
        {
            return _formationRepository.GetAll();
        }
        [HttpPost]
        public void Add(Formation entity)
        {
            _formationRepository.Add(entity);
        }
        [HttpGet("/Formation/{Id}")]
        public Formation Get(long id)
        {
            return _formationRepository.Get(id);
        }

        [HttpDelete("/Formation/{Id}")]
        public void Delete(long id)
        {
            _formationRepository.Delete(id);
        }
        [HttpPut("/Formation/{Id}")]
        public void Update(Formation Formation)
        {
            _formationRepository.Update(Formation);
        }
    }
    
}
