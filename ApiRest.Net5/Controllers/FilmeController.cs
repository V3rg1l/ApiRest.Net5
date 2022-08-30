using ApiRest.Net5.Data;
using ApiRest.Net5.Data.Dtos;
using ApiRest.Net5.Models;
using ApiRest.Net5.Services;
using AutoMapper;
using FluentResults;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ApiRest.Net5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController:ControllerBase
    {
        private FilmeService _service;

        public FilmeController(FilmeService service)
        {
            _service = service;
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public IActionResult AdicionaFilme([FromBody] CreateFilmeDto filmeDto)
        {
            ReadFilmeDto readDto =  _service.AdicionaFilme(filmeDto);

            return CreatedAtAction(nameof(RetornaFilmePorId), new { id = readDto.Id }, readDto);
        }

        [HttpGet]
        public IActionResult RecuperaFilmes([FromQuery] int? classificacaoEtaria = null)
        {
            List<ReadFilmeDto> readDto =  _service.RecuperaFilmes(classificacaoEtaria);
            if (readDto != null)
                return Ok(readDto);

            return NotFound();
        }

        [HttpGet("{id}")]
        public IActionResult RetornaFilmePorId(int id)
        {
            ReadFilmeDto readDto = _service.RetornaFilmePorId(id);
            if (readDto != null)
                return Ok(readDto);

            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaFilme(int id, [FromBody] UpdateFilmeDto filmeDto)
        {
            Result result =  _service.AtualizaFilme(id, filmeDto);
            
            if (result.IsFailed) return NotFound();

            return NoContent();

        }

        [HttpDelete("{id}")]
        public IActionResult DeletaFilme(int id)
        {
            Result result = _service.DeletaFilme(id);

            if (result.IsFailed) return NotFound();

            return NoContent();
        }
    }
}
