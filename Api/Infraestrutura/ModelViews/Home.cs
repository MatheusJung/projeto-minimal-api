using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minimal_api.Infraestrutura.ModelViews
{
    public struct Home
    {
        public string Msg { get => "/Bem vindo a API de veiculos - Minimal Api"; }
        public string Doc { get => "/swagger"; }
    }
}