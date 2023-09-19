using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Modelos
{
    public class Professor
    {
        protected readonly float SalarioMaximo;
        float salarioAtual;

        public Professor(float salarioMaximo)
        {
            SalarioMaximo = salarioMaximo;
        }

        protected float ModificarSalario(float modf)
        {
            float novoSalario = salarioAtual + modf;

            if(novoSalario < 0)
            {
                salarioAtual = 0;
            }
            else if(novoSalario > SalarioMaximo)
            {
                salarioAtual = SalarioMaximo;
            }
            else
            {
                salarioAtual = novoSalario;
            }
            return salarioAtual;
        }

        public float AumentaSalario()
        {
            return ModificarSalario(+500);
        }

        public float DiminuirSalario()
        {
            return ModificarSalario(-500);
        }
    }
}
