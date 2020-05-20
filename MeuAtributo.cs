using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Atributos
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method)]
    class MeuAtributo : Attribute 
    {

        public string Nome { get; set; }
        public string Descricao { get; set; }

        public MeuAtributo(string nome)
        {
            Nome = nome;
        }
    }
}
