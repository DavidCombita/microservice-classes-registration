﻿using System;
using DistriLab2.Models;
using DistriLab2.Models.DB;
using Microsoft.AspNetCore.Mvc;

namespace DistriLab2.Controllers{
	public class InscriptionController{
        private readonly dblab2Context _context;

        public InscriptionController(dblab2Context context)
        {
            _context = context;
        }
        /*
        [HttpGet]
        [Route("getInscription")]
        public ActionResult<Student> getInscription()
        {
            var client = _context.Students.ToList();
            return Ok(client);
        }

        [HttpPost]
        [Route("addStudent")]
        public async Task<IActionResult> AddSubasta(StudentXD student)
        {


            Student stuAux = new()
            {
                CodStudent = student.CodStudent,
                FirstNameStudent = student.FirstNameStudent,
                LastNameStudent = student.LastNameStudent,
                TypeDocument = student.TypeDocument,
                NumDocument = student.NumDocument,
                StatusStudent = student.StatusStudent,
                GenderStudent = student.GenderStudent,
                Inscriptions = null

            };
            Student studentAux = _context.Students.Add(stuAux).Entity;


            await _context.SaveChangesAsync();
            return Created($"/Student/{stuAux.CodStudent}", stuAux);

        }

        [HttpPut]
        public async Task<IActionResult> Put(Student student)
        {
            var update = await _context.Students.FindAsync(student.CodStudent);

            if (update == null)
                return BadRequest();

            update.CodStudent = student.CodStudent;
            update.FirstNameStudent = student.FirstNameStudent;
            update.LastNameStudent = student.LastNameStudent;
            update.TypeDocument = student.TypeDocument;
            update.NumDocument = student.NumDocument;
            update.StatusStudent = student.StatusStudent;
            update.GenderStudent = student.GenderStudent;

            var aux = await _context.SaveChangesAsync() > 0;
            if (!aux)
            {
                return NoContent();
            }
            return Ok(update);
        }*/
    
	}
}

