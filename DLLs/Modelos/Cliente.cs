using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Cliente
    {
        public string Titular { get; private set; }
        public string CPF { get; private set; }
        public string Profissao { get; set; }

        public Cliente(string titular, string cpf, string profissao)
        {
            if(titular == null || cpf == null || cpf == "" || profissao == null)
            {
                throw new ArgumentException();
            }
            this.Titular = titular;
            this.CPF = cpf;
            this.Profissao = profissao;
        }
    }
}
