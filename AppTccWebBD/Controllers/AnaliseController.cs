using AppTccWebBD.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppTccWebBD.Controllers
{
    [Route("api/[controller]")]
    public class AnaliseController : Controller
    {
        private readonly ITccDAL tccDeAlunoAnalise;
        public AnaliseController(ITccDAL tccs)
        {
            tccDeAlunoAnalise = tccs;
        }


        [HttpGet]
        public List<Tcc> Get()
        {
                    
            List<Tcc> listaTcc = new List<Tcc>();
            listaTcc = tccDeAlunoAnalise.GetAllTcc().ToList();
            return listaTcc;
           
        }
    }
}
