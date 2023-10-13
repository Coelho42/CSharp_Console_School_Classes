using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap06_Turmas
{
    class Professor
    {

        ////////////////////////////////
        /// Atributos e propriedades ///
        ////////////////////////////////

        private int numeroProcesso;         // Número do processo do Professor (institucional)
        private string nomeProfessor;       // Nome do Professor
        private int idadeProfessor;         // Idade do Professor
        private bool sexoMasculino;         // True se for masculino false se for femenino
        private bool estaMatriculado;       // True se estiver matriculado false se não estiver matriculado
        private string telefone;            // Número de telefone do Professor
        private int id;                     // ID do Professor no programa
        private Morada morada;              // Morada do Professor
        private int idCivil;                // Tipo id Civil
        private string tipoIdCivil;         // nome do documento de identificação civil
        private int idSegSocial;            // numero de identificação de segurança social
        private int idSistSaude;            // numero de identificação do sistema de saude
        private DateTime dataNascimento;    // Data de nascimento do Professor

        //////////////
        // Métodos  //
        //////////////

        /////////////////////////
        /// Getters & Setters ///
        /////////////////////////

        public int getNumeroProcesso()
        {
            return numeroProcesso;
        }

        public void setNumeroProcesso(int numeroProcesso)
        {
            this.numeroProcesso = numeroProcesso;
        }

        public string getNomeProfessor()
        {
            return nomeProfessor;
        }

        public void setNomeProfessor(string nomeProfessor)
        {
            this.nomeProfessor = nomeProfessor;
        }

        public int getIdadeProfessor()
        {
            return idadeProfessor;
        }

        public void setIdadeProfessor(int idadeProfessor)
        {
            this.idadeProfessor = idadeProfessor;
        }

        public bool getSexoMasculino()
        {
            return sexoMasculino;
        }

        public void setSexoMasculino(bool sexoMasculino)
        {
            this.sexoMasculino = sexoMasculino;
        }

        public bool getEstaMatriculado()
        {
            return estaMatriculado;
        }

        public void setEstaMatriculado(bool estaMatriculado)
        {
            this.estaMatriculado = estaMatriculado;
        }

        public string getTelefone()
        {
            return telefone;
        }

        public void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public int getIdCivil()
        {
            return idCivil;
        }

        public void setIdCivil(int idCivil)
        {
            this.idCivil = idCivil;
        }

        public string getTipoIdCivil()
        {
            return tipoIdCivil;
        }

        public void setTipoIdCivil(string tipoIdCivil)
        {
            this.tipoIdCivil = tipoIdCivil;
        }

        public int getIdSegSocial()
        {
            return idSegSocial;
        }

        public void setIdSegSocial(int idSegSocial)
        {
            this.idSegSocial = idSegSocial;
        }

        public int getIdSistSaude()
        {
            return idSistSaude;
        }

        public void setIdSistSaude(int idSistSaude)
        {
            this.idSistSaude = idSistSaude;
        }

        public DateTime getDataNascimento()
        {
            return dataNascimento;
        }

        public void setDataNascimento(DateTime dataNascimento)
        {
            this.dataNascimento = dataNascimento;
        }

        public Morada getMorada()
        {
            return morada;
        }

        public void setMorada(string rua, int andar, string codigoPostal, string cidade, string numeroPorta)   
        {
            this.morada.rua = rua;
            this.morada.andar = andar;
            this.morada.codigoPostal = codigoPostal;
            this.morada.cidade = cidade;
            this.morada.numeroPorta = numeroPorta;
        }
    }
}

    

