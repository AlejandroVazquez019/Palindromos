using Microsoft.AspNetCore.Mvc;
using palindromos.Entities;
using System;
using System.Linq;
using System.Collections;
using System.Text.RegularExpressions;
/* Nombre de la escuela: Universidad Tecnologica Metropolitana
    Asignatura: Aplicaciones Web Orientadas a Objetos
    Nombre del Maestro: Chuc Uc Joel Ivan
    Nombre de la actividad: Actividad 2, Ejercicio 2: Palindromos
    Nombre del alumno: Jose Alejandro Vazquez Suaste
    Cuatrimestre: 4
    Grupo: A
    Parcial: 1
    */
namespace palindromos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PalindromoController : ControllerBase
    {
         [HttpPost]

        public string Post (Palabra pal)
        {
            string Noti;
            string Palabra = pal.frase.Replace(" ", "").ToLower();
            string A;
            string Rev = "";
            

            int i = Palabra.Length;
            MatchCollection wordColl = Regex.Matches(pal.frase, @"[\W]+");

            for(int x = (i - 1); x >= 0; x--)
            {
                A = Palabra.Substring(x, 1);
                Rev = Rev + A;
            }

            if (Palabra == Rev)
            {
                Noti = "Esto si es palindromio";
            }
            else
            {
                Noti = "Esto no es palindromo";
            }
            return (Noti+ "Usted cuentas con estos numero de palabras:"+(wordColl.Count+1));
          
        }

    }
}