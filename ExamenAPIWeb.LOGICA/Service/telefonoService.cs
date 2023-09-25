using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenAPIWeb.LOGICA.Service
{
    public class telefonoService
    {
        private TelfRepository _telfRepository;

        public TelfRepository(TelfRepository telfRepository)
        {
            _telfRepository = telfRepository;
        }

        public Usuario CrearTelf(string Nombre, string NumeroTelefonico)
        {
            return _telfRepository.Agregar(Nombre, NumeroTelefonico);
        }
    }
}
