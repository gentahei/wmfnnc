using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Wmfnnc.Data.Interface;
using Wmfnnc.DTO;
using Wmfnnc.Models;

namespace Wmfnnc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DukcapilController : ControllerBase
    {
        private readonly IDukcapilRepo _repository;
        private readonly IMapper _mapper;

        public DukcapilController(IDukcapilRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet("{nik}", Name = "GetByNik")]
        public ActionResult GetByNik(string nik)
        {
            var dukcapil = _repository.GetDukcapilByNik(nik);
            return Ok(_mapper.Map<DukcapilRead>(dukcapil));
        }

        [HttpGet]
        public ActionResult GetByNikQuery([FromQuery(Name = "nik")] string nik)
        {
            var dukcapil = _repository.GetDukcapilByNik(nik);
            return Ok(_mapper.Map<DukcapilRead>(dukcapil));
        }

        [HttpPost]
        public ActionResult GetByNikBody(DukcapilFind dukcapilFind)
        {
            var dukcapil = _repository.GetDukcapilByNik(dukcapilFind.nik);
            return Ok(_mapper.Map<DukcapilRead>(dukcapil));
        }

        [HttpPost("create")]
        public ActionResult CreateDukcapil(DukcapilCreate dukcapilCreate)
        {
            var dukcapil = _mapper.Map<m_dukcapil_data>(dukcapilCreate);

            _repository.CreateDukcapil(dukcapil);

            var dukcapilRead = _mapper.Map<DukcapilRead>(dukcapil);

            return CreatedAtRoute(nameof(GetByNik), new { nik = dukcapil.nik }, dukcapilRead);
        }

    }
}