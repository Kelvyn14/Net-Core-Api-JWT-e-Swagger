using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteApiNetCore_Swagger_v1.IServices;
using TesteApiNetCore_Swagger_v1.Models;

namespace TesteApiNetCore_Swagger_v1.Service
{
    public class EstudanteService : IEstudanteService
    {

        List<Estudante> _estudantes = new List<Estudante>();
        public EstudanteService()
        {
            for (int i = 0; i <= 9; i++)
            {
                _estudantes.Add(new Estudante()
                {
                    EstudanteId = i,
                    Nome = "Estu" + i,
                    Roll = "100" + i
                });
            }
        }

        public List<Estudante> Delete(int estudanteId)
        {
            _estudantes.RemoveAll(x => x.EstudanteId == estudanteId);
            return _estudantes;
        }

        public Estudante Get(int estudanteId)
        {
            return _estudantes.SingleOrDefault(x => x.EstudanteId == estudanteId);
        }

        public List<Estudante> Gets()
        {
            return _estudantes;
        }

        public List<Estudante> Save(Estudante estudante)
        {
            _estudantes.Add(estudante);
            return _estudantes;
        }
    }
}
