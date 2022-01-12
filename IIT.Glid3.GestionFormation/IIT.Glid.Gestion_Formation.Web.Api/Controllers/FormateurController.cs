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
    public class FormateurController: ControllerBase
    {
        private readonly ILogger<FormateurController> _logger;
        private readonly IDataRepository<Formateur> _formateurRepository;

        public FormateurController(ILogger<FormateurController> logger, IDataRepository<Formateur> formateurRepository)
        {
            _logger = logger;
            _formateurRepository = formateurRepository;
        }
        [HttpGet]
        public IEnumerable<Formateur> GetAll()
        {
            return _formateurRepository.GetAll();
        }
        [HttpGet("/Formateur/{Id}")]
        public Formateur Get(long id)
        {
            return _formateurRepository.Get(id);
        }
        [HttpPost]
        public void Add(Formateur entity)
        {
            _formateurRepository.Add(entity);
        }
        [HttpDelete("/Formateur/{Id}")]
        public void Delete(long id)
        {
            _formateurRepository.Delete(id);
        }
        [HttpPut("/Formateur/{Id}")]
        public void Update(Formateur formateur)
        {
            _formateurRepository.Update(formateur);
        }
    }
    
}
