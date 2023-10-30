using InjecaoDependencia.API.Models;

namespace InjecaoDependencia.API.Services
{
    public class TesteService
    {
        private readonly ObjetoDI _objeto;

        public TesteService(ObjetoDI objeto)
        {
            _objeto = objeto;
        }

        public int ObterContador() => _objeto.Contador;
    }
}
