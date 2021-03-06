﻿using Expenselt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenselt.Services
{
    public class EstadoComboListService : List<string>
    {
        private EstadoService service;
        public EstadoComboListService()
        {
            service = new EstadoService();
            var itemList = service.GetEstados();
            foreach (var item in itemList)
                this.Add(item.Nome.ToString());
        }
    }
}
