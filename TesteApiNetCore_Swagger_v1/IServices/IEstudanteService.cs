using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteApiNetCore_Swagger_v1.Models;

namespace TesteApiNetCore_Swagger_v1.IServices
{
    public interface IEstudanteService
    {
        List<Estudante> Gets();
        Estudante Get(int estudanteId);
        List<Estudante> Save(Estudante estudante);
        List<Estudante> Delete(int estudanteId);
    }
}
