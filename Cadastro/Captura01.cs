﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    internal class Captura01
    {
        public Captura01()
        {
            this.Nome = "";
            this.Cpf = "";
            this.FecNac = "";
            this.RendaMes = "";
            this.EdoCivil = "";
            this.Dependentes = "";

        }

        public Captura01(string nome, string cpf, string fecnac, string rendames, string edocivil, string dependentes)
        {

            this.Nome = nome;
            this.Cpf = cpf;
            this.FecNac = fecnac;
            this.RendaMes = rendames;
            this.EdoCivil = edocivil;
            this.Dependentes = dependentes;


        }

        private String nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string cpf;

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }

        }

        private string fecnac;

        public string FecNac
        {
            get { return fecnac; }
            set { fecnac = value; }
        }

        private string rendames;

        public string RendaMes
        {
            get { return rendames; }
            set { rendames = value; }
        }
        private String edocivil;

        public String EdoCivil
        {
            get { return edocivil; }
            set { edocivil = value.ToUpper(); }
        }

        private string dependentes;

        public string Dependentes
        {
            get { return dependentes; }
            set { dependentes = value; }

        }

        
        public string Ler(string txt)
        {
            Console.WriteLine(txt);
            string val = Console.ReadLine();
            if (val.Length < 1 )
            {
               
                Ler(txt);     
            }
            
            return val;
        }

        public void LerUser()
        {
            Valida01 valida01 = new Valida01(); 
            if (valida01.Nome == "error") valida01.Nome = Convert.ToString(Ler("Nombre cccc:"));
            if (Cpf == "error") Cpf = Convert.ToString(Ler("CPF:"));
            if (FecNac == "error") FecNac = Convert.ToString(Ler("DDMMAAAA:"));
            if (RendaMes == "error") RendaMes = Convert.ToString(Ler("Renda Mesual: "));
            if (EdoCivil == "error") EdoCivil = Convert.ToString(Ler("Estado Civil (C, S, V ou D): "));
            if (Dependentes == "error") Dependentes = Convert.ToString(Ler("Dependentes: "));


            if ((Nome == "") &&
            (Cpf == "") &&
            (FecNac == "") &&
            (RendaMes == "") &&
            (EdoCivil == "") &&
            (Dependentes == ""))
        {
            Nome = Convert.ToString(Ler("Nombre:"));
            Cpf = Convert.ToString(Ler("CPF:"));
            string Ano = Convert.ToString(Ler("Ano Nacimiento - aaaa: "));
            string Mes = Convert.ToString(Ler("Mes Nacimiento - mm: "));
            string Dia = Convert.ToString(Ler("Dia Nacimiento - dd: "));
            FecNac += Dia + "/" + Mes + "/" + Ano;
            RendaMes = Convert.ToString(Ler("Renda Mesual: "));
            EdoCivil = Convert.ToString(Ler("Estado Civil (C, S, V ou D): "));
            Dependentes = Convert.ToString(Ler("Dependentes: "));
        }
       
            
        /*
        Nome = Convert.ToString(Ler("Nombre:"));
        Cpf = Convert.ToString(Ler("CPF:"));
        string Ano = Convert.ToString(Ler("Ano Nacimiento - aaaa: "));
        string Mes = Convert.ToString(Ler("Mes Nacimiento - mm: "));
        string Dia = Convert.ToString(Ler("Dia Nacimiento - dd: "));
        FecNac += Dia + "/" + Mes + "/" + Ano;
        RendaMes = Convert.ToString(Ler("Renda Mesual: "));
        EdoCivil = Convert.ToString(Ler("Estado Civil (C, S, V ou D): "));
        Dependentes = Convert.ToString(Ler("Dependentes: "));
        */
        Console.WriteLine("\n\n        IMPRESION DEL REGISTRO CAPTURADO  (captura)\n\n");
        Console.WriteLine("      Nome             = " + Nome + "\n " +
                            "     Cpf              = " + Cpf + "\n " +
                            "     Fecha Nacimiento = " + FecNac + "\n " +
                            "     Renda Mesual     = " + RendaMes + "\n " +
                            "     Estado Civil     = " + EdoCivil + "\n " +
                            "     Dependentes      = " + Dependentes + "\n\n\n");
        

        Console.ReadLine();
           
            //https://www.youtube.com/watch?v=IhV-oGgeaXc
            //https://social.msdn.microsoft.com/Forums/es-ES/b2c94668-5507-450e-902e-f8f8f66daf3a/pasar-datos-de-una-clase-a-otra?forum=vcses
        }    
    }
}
