/****************************** Code 21 ******************************
 Code 21  : Classes Abstratas
 Autor    : Rafael Padilla
 Data     : 07 de outubro de 2017
 Versão   : 1.0
**********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Code_21
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    //Esse abstract da classe é para que possamos ter métodos abstract nesta classe
    //Na verdade não existe classe Abstrata. O que existe são classes que implementam métodos abstracts e por isso,
    //elas devem ser Abstratas.
    public abstract class BaseEmpregado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public string GetNomeCompleto()
        {
            return this.Nome + " " + this.Sobrenome;
        }

        //Abstract -> Somente para métodos. Não é possível implementar classes abstratas
        //Obriga classes que a implementam a fazer um override do método abstrato
        //!!! Atenção: só pode ser feito se a classe for abstract
        //!!! Atenção: só pode ser feito se o método for públic
        public abstract float GetSalarioMensal();
        //Diferença entre métodosvirtuais e abstratos:
        //Um método abstrada DEVE ser sobrescrita. Um método virtual function PODE ou NÃO ser sobrescrito.
    }

    public class EmpregadosComContrato : BaseEmpregado
    {
        public float SalarioAnual { get; set; }

        public override float GetSalarioMensal()
        {
            return this.SalarioAnual / 12;
        }
    }

    public class EmpregadosHorista : BaseEmpregado
    {
        public float SalarioHora { get; set; }
        public float HorasTrabalhadasMes { get; set; }

        public override float GetSalarioMensal()
        {
            return this.SalarioHora * HorasTrabalhadasMes;
        }
    }

}
