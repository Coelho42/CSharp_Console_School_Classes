using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap06_Turmas
{
    class Turma
    {
        ////////////////////////////////
        /// Atributos e propriedades ///
        ////////////////////////////////

        private int id;                 // nº interno da turma
        private string nomeTurma;       // Nome da turma
        private string professorDt;     // Diretor de turma
        private int nAlunos;            // Número de alunos na turma
        private string alunoDelegado;   // Delegado de turma
        private string subDelegado;     // Subdelegado de turma
        private int anoLetivo;          // Ano letivo em vigor
        private string ciclo;           // Nível de ensino da turma: 1º, 2º, 3º ciclo ou secundário
        private string curso;           // Regular, profissional, vocacional, etc
        private string turnoDiurno;     // Diurno ou noturno

        //////////////
        // Métodos  //
        //////////////

        /////////////////////////
        /// Getters & Setters ///
        /////////////////////////

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getNomeTurma()
        {
            return nomeTurma;
        }

        public void setNomeTurma(string nomeTurma)
        {
            this.nomeTurma = nomeTurma;
        }

        public string getProfessorDt()
        {
            return professorDt;
        }

        public void setProfessorDt(string professorDt)
        {
            this.professorDt = professorDt;
        }

        public int getnAlunos()
        {
            return nAlunos;
        }

        public void setnAlunos(int nAlunos)
        {
            this.nAlunos = nAlunos;
        }

        public string getAlunoDelegado()
        {
            return alunoDelegado;
        }

        public void setAlunoDelegado(string alunoDelegado)
        {
            this.alunoDelegado = alunoDelegado;
        }

        public string getSubDelegado()
        {
            return subDelegado;
        }

        public void setSubDelegado(string subDelegado)
        {
            this.subDelegado = subDelegado;
        }

        public int getAnoLetivo()
        {
            return anoLetivo;
        }

        public void setAnoLetivo(int anoLetivo)
        {
            this.anoLetivo = anoLetivo;
        }

        public string getCiclo()
        {
            return ciclo;
        }

        public void setCiclo(string ciclo)
        {
            this.ciclo = ciclo;
        }

        public string getCurso()
        {
            return curso;
        }

        public void setCurso(string curso)
        {
            this.curso = curso;
        }

        public string getTurnoDiurno()
        {
            return turnoDiurno;
        }

        public void setTurnoDiurno(string turnoDiurno)
        {
            this.turnoDiurno = turnoDiurno;
        }
    }
}

    

