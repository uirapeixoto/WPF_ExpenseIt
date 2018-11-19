using Expenselt.Model;
using System.Collections.Generic;
using System.Linq;

namespace Expenselt.Services
{
    public class EstadoService
    {
        public ICollection<Estado> GetEstados()
        {
            return new List<Estado>
            {
                new Estado {Id=1,  Nome = "ACRE",               UF = "AC"},
                new Estado {Id=2,  Nome = "ALAGOAS",            UF = "AL"},
                new Estado {Id=3,  Nome = "AMAZONAS",           UF = "AM"},
                new Estado {Id=4,  Nome = "AMAPÁ",              UF = "AP"},
                new Estado {Id=5,  Nome = "BAHIA",              UF = "BA"},
                new Estado {Id=6,  Nome = "CEARÁ",              UF = "CE "},
                new Estado {Id=7,  Nome = "ESPÍRITO SANTO",     UF = "ES"},
                new Estado {Id=8,  Nome = "DiSTRITO FEDERAL",   UF = "DF"},
                new Estado {Id=9,  Nome = "GOIÁS",              UF = "GO"},
                new Estado {Id=10, Nome = "MARANHÃO",           UF = "MA"},
                new Estado {Id=11, Nome = "MINAS GERAIS",       UF = "MG"},
                new Estado {Id=12, Nome = "MATO GROSSO DO SUL", UF = "MS"},
                new Estado {Id=13, Nome = "MATO GROSSO",        UF = "MT"},
                new Estado {Id=14, Nome = "PARÁ",               UF = "PA"},
                new Estado {Id=15, Nome = "PARAÍBA",            UF = "PB"},
                new Estado {Id=16, Nome = "PERNAMBUCO",         UF = "PE"},
                new Estado {Id=17, Nome = "PIAUÍ",              UF = "PI"},
                new Estado {Id=18, Nome = "PARANÁ",             UF = "PR"},
                new Estado {Id=19, Nome = "RIO DE JANEIRO",     UF = "RJ"},
                new Estado {Id=20, Nome = "RIO GRANDE DO NORTE", UF = "RN"},
                new Estado {Id=21, Nome = "RONDÔNIA",           UF = "RO"},
                new Estado {Id=22, Nome = "RORAIMA",            UF = "RR"},
                new Estado {Id=23, Nome = "RIO GRANDE DO SUL",  UF = "RS"},
                new Estado {Id=24, Nome = "SANTA CATARINA",     UF = "SC"},
                new Estado {Id=25, Nome = "SERGIPE",            UF = "SE"},
                new Estado {Id=26, Nome = "SÃO PAULO",          UF = "SP"},
                new Estado {Id=27, Nome = "TOCANTINS",          UF = "TO"}

            };
        }

        public Estado GetEstadoById(int Id)
        {
            return GetEstados().FirstOrDefault(x => x.Id == Id);
        }

        public List<string> EstadoComboList()
        {
            List<string> result = new List<string>();
            var itemList = GetEstados();
            foreach (var item in itemList)
                result.Add(item.UF);

            return result;
        }
    }
}
