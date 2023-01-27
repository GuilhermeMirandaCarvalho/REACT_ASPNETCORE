using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProAtividade.API.Models;

namespace ProAtividade.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AtividadeController : ControllerBase
    {
        [HttpGet]
        public Atividade Get()
        {
            return new Atividade();
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"Este é meu Primeiro get com id {id}";
        }


        [HttpPost]
        public Atividade Post(Atividade atividade)
        {
            return atividade;
        }


    }
}