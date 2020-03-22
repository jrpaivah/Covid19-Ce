using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COVID.Application.Interfaces;
using COVID.Application.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace COVID.Service.Api.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CasosController : ControllerBase
  {
    private readonly ICasoService _casoService;
    private readonly ITotalRegiaoService _totalRegiaoService;

    public CasosController(ICasoService casoService, ITotalRegiaoService totalRegiaoService)
    {
      _casoService = casoService;
      _totalRegiaoService = totalRegiaoService;
    }

    [HttpGet]
    public IEnumerable<CasoViewModel> Get()
    {
      return _casoService.GetAll();
    }

    [HttpGet("{id}", Name = "Get")]
    public CasoViewModel Get(Guid id)
    {
      return  _casoService.GetById(id);
    }

    [HttpGet("totais")]
    public IEnumerable<TotalRegiaoViewModel> Totais()
    {
      return _totalRegiaoService.Total();
    }

    //[HttpPost]
    //public void Post([FromBody] string value)
    //{
    //}

    //[HttpPut("{id}")]
    //public void Put(int id, [FromBody] string value)
    //{
    //}

    //[HttpDelete("{id}")]
    //public void Delete(int id)
    //{
    //}
  }
}
