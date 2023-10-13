using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap06_Turmas
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Atributos
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Turmas
            Turma gi1 = null;           // Objeto vazio
            Turma gi2 = new Turma();    // Objeto válido (recebeu uma cópia da classe)
            Turma gi3 = new Turma();    // Objeto válido (recebeu uma cópia da classe)
            gi1 = new Turma();          // Objeto passa a ser válido

            // Array de 3 turmas
            Turma[] Turmas = new Turma[1];

            // Professores
            Professor p1 = new Professor(); // Objeto válido (recebeu uma cópia da classe)
            Professor p2 = new Professor(); // Objeto válido (recebeu uma cópia da classe)
            Professor p3 = new Professor(); // Objeto válido (recebeu uma cópia da classe)

            // Array de 3 professores
            Professor[] Professores = new Professor[1];

            // Alunos
            Aluno a1, a2, a3 = new Aluno(); // 3 objetos válidos do tipo aluno

            // Array de 3 alunos
            Aluno[] Alunos = new Aluno[1];

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // APP
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Declaração de variáveis
            int nTurmas = 0, nAlunos = 0, nProfessores = 0;                                             // Variáveis que fazem a contagem do nr de turmas, alunos e professores, que são usadas para as proteções na APP
            string opcao, opcoes, opcoes1, opcoes2, opcoes3, opcoes4, opcoes5, opcoes6;                 // Variáveis para as opções introduzidas na APP;
            int nAlunosmatriculados = 0, nProfessoresmatriculados = 0;                                  // Variáveis para as matriculas
            int aT1 = 0, aT2 = 0, aT3 = 0, pT1 = 0, pT2 = 0, pT3 = 0;                                   // Variáveis para mostrar os alunos e professores conforme o número de matriculas
            
            // Execução da tarefa de acordo com o que o opcao escolher do Menu, e voltar a pedir caso este introduza uma opção não válida
            do
            {
                Console.Clear();
                // Chamada do Menu na Main
                desenhaMenu();

                // Conforme aquilo que o utilizador introduzir o menu executa essa opção
                System.Console.WriteLine(" ");
                opcao = System.Console.ReadLine();
                System.Console.WriteLine(" ");

                // Opções do Menu
                switch (opcao)
                {
                    case "1":

                        for (int k = 0; k < Turmas.Length; k++)
                        {
                            Turmas[k] = new Turma();

                            // Id da Turma
                            Turmas[k].setId(k + 1);

                            // Nome
                            System.Console.WriteLine(" Introduza o Nome da " + (k + 1) + "ª turma");
                            Turmas[k].setNomeTurma(System.Console.ReadLine());
                            System.Console.WriteLine();

                            // nº de alunos
                            System.Console.WriteLine(" Introduza o nº de alunos da " + (k + 1) + "ª turma");
                            Turmas[k].setnAlunos(System.Convert.ToInt32(System.Console.ReadLine()));
                            System.Console.WriteLine();

                            // Ano Letivo
                            System.Console.WriteLine(" Introduza o ano letivo da " + (k + 1) + "ª turma");
                            Turmas[k].setAnoLetivo(System.Convert.ToInt32(System.Console.ReadLine()));
                            System.Console.WriteLine();

                            // Ciclo
                            System.Console.WriteLine(" Introduza o ciclo da " + (k + 1) + "ª turma");
                            Turmas[k].setCiclo(System.Console.ReadLine());
                            System.Console.WriteLine();

                            // Curso
                            System.Console.WriteLine(" Introduza o tipo de curso da " + (k + 1) + "ª turma");
                            Turmas[k].setCurso(System.Console.ReadLine());
                            System.Console.WriteLine();

                            // Turno
                            System.Console.WriteLine(" Introduza o Turno da " + (k + 1) + "ª turma");
                            Turmas[k].setTurnoDiurno(System.Console.ReadLine());
                            System.Console.WriteLine();
                            System.Console.WriteLine();

                        }

                        // Exceção para quando o programa for apresentar os dados
                        nTurmas = Turmas.Length;

                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case "2":

                        // Caso o nTurmas for == 0, este ciclo for não pode ser executado, porque não existem turmas, se nTurmas >0 então o ciclo for para o preechimento dos alunos poderá ser executado
                        if (nTurmas != 0)
                        {
                            // Preenche 3 Alunos
                            for (int j = 0; j < Alunos.Length; j++)
                            {
                                Alunos[j] = new Aluno();

                                //Id do aluno
                                Alunos[j].setId(j + 1);

                                // Nome
                                System.Console.WriteLine(" Introduza o Nome do " + (j + 1) + "º aluno");
                                Alunos[j].setNomeAluno(System.Console.ReadLine());
                                Alunos[j].setNumeroProcesso(j + 1);
                                System.Console.WriteLine();

                                // Idade
                                System.Console.WriteLine(" Introduza a Idade do " + (j + 1) + "º aluno");
                                Alunos[j].setIdadeAluno(System.Convert.ToInt32(System.Console.ReadLine()));
                                Alunos[j].setDataNascimento(new DateTime());
                                System.Console.WriteLine();

                                // nº cartão de identificação
                                System.Console.WriteLine(" Introduza o nº CC do " + (j + 1) + "º aluno");
                                Alunos[j].setIdCivil(System.Convert.ToInt32(System.Console.ReadLine()));
                                System.Console.WriteLine();

                                // nº cartão de seg social
                                System.Console.WriteLine(" Introduza o nº Seg. Social " + (j + 1) + "º aluno");
                                Alunos[j].setIdSegSocial(System.Convert.ToInt32(System.Console.ReadLine()));
                                System.Console.WriteLine();

                                // nº cartão de sist. de saúde
                                System.Console.WriteLine(" Introduza o nº Sist.de saúde " + (j + 1) + "º aluno");
                                Alunos[j].setIdSistSaude(System.Convert.ToInt32(System.Console.ReadLine()));
                                System.Console.WriteLine();

                                // Morada  
                                             
                                string rua, codigoPostal, numeroPorta, cidade;
                                int andar;

                                System.Console.WriteLine(" Introduza os seguintes dados da Morada do " + (j + 1) + "º aluno");
                                System.Console.WriteLine();

                                // Cidade
                                System.Console.WriteLine(" Introduza a cidade do " + (j + 1) + "º aluno");
                                cidade = System.Console.ReadLine();
                                System.Console.WriteLine();

                                // Rua
                                System.Console.WriteLine(" Introduza a rua do " + (j + 1) + "º aluno");
                                rua = System.Console.ReadLine();
                                System.Console.WriteLine();

                                // Código postal
                                System.Console.WriteLine(" Introduza o código postal do " + (j + 1) + "º aluno");
                                codigoPostal = System.Console.ReadLine();
                                System.Console.WriteLine();

                                // Número da porta
                                System.Console.WriteLine(" Introduza o número da porta do " + (j + 1) + "º aluno");
                                numeroPorta = System.Console.ReadLine();
                                System.Console.WriteLine();

                                // Andar
                                System.Console.WriteLine(" Introduza o andar do " + (j + 1) + "º aluno");
                                andar = System.Convert.ToInt32(System.Console.ReadLine());
                                System.Console.WriteLine();

                                Alunos[j].setMorada(rua, andar, codigoPostal, cidade, numeroPorta);          

                                // Fim Morada.

                                // Género - repete até a resposta ser válida
                                bool validoAluno = true;
                                do
                                {
                                    validoAluno = true;
                                    System.Console.WriteLine(" Género Masculino? (S/N)");
                                    switch (System.Console.ReadLine())
                                    {
                                        case "s":
                                        case "S":
                                            Alunos[j].setSexoMasculino(true);
                                            break;

                                        case "n":
                                        case "N":
                                            Alunos[j].setSexoMasculino(false);
                                            break;

                                        default:
                                            System.Console.WriteLine();
                                            System.Console.WriteLine(" Wrong answer - repita sff");
                                            System.Console.WriteLine();
                                            validoAluno = false;
                                            break;
                                    }
                                } while (!validoAluno);

                                // nº de telefone
                                System.Console.WriteLine();
                                System.Console.WriteLine(" Introduza o número de telefone do " + (j + 1) + "º aluno");
                                Alunos[j].setTelefone(System.Console.ReadLine());
                                System.Console.WriteLine();

                                // nº de identificação Civil
                                System.Console.WriteLine(" Introduza o número de identificação Civil do " + (j + 1) + "º aluno");
                                Alunos[j].setIdCivil(System.Convert.ToInt32(System.Console.ReadLine()));
                                System.Console.WriteLine();

                                // Pergunta se o aluno está matriculado - repete até a resposta ser válida
                                do
                                {
                                    validoAluno = true;     // Variável para se for um aluno válido ou não

                                    System.Console.WriteLine(" Está Matriculado? (S/N)");
                                    switch (System.Console.ReadLine())
                                    {
                                        case "s":
                                        case "S":
                                            Alunos[j].setEstaMatriculado(true);
                                            break;

                                        case "n":
                                        case "N":
                                            Alunos[j].setEstaMatriculado(false);

                                            // Faz o Switch enquanto o valor que vier do utilizador for default, ou seja incorreto
                                            do
                                            {

                                                // Pergunta em que turma deseja matricular o aluno
                                                System.Console.WriteLine();
                                                System.Console.WriteLine(" Em qual das seguintes turmas deseja matricular o aluno criado?");
                                                System.Console.WriteLine();

                                                // Ciclo for que mostra as turmas criadas
                                                for (int a = 0; a < Alunos.Length; a++)
                                                {
                                                    System.Console.WriteLine(" Press '" + (a + 1) + "' se quiser inserir o aluno na - " + (a + 1) + "ª Turma ---> " + Turmas[a].getNomeTurma());
                                                }

                                                // Lê o que vier do teclado
                                                opcoes = System.Console.ReadLine();
                                                System.Console.WriteLine();

                                                // Switch para a turma que o utilizador escolher matricular o aluno
                                                switch (opcoes)
                                                {
                                                    case "1":
                                                        System.Console.WriteLine(" O aluno foi matriculado na turma " + Turmas[0].getNomeTurma());
                                                        nAlunosmatriculados = aT1 + 1;
                                                 
                                                        Alunos[j].setEstaMatriculado(true);
                                                        System.Console.WriteLine();

                                                        // Faz o Switch enquanto o valor que vier do utilizador for default, ou seja incorreto
                                                        do
                                                        {

                                                            // Pergunta se deseja inserir este aluno como delegado de turma
                                                            System.Console.WriteLine(" Deseja inserir este aluno como delegado de turma? (S/N)");

                                                            // Lê o que vier do teclado
                                                            opcoes1 = System.Console.ReadLine();
                                                            System.Console.WriteLine();

                                                            // Switch para aquilo que o utilizador introduzir se "S" o aluno é colocado como delegado, se "N", ele pergunta se quer o aluno como subdelegado
                                                            switch (opcoes1)
                                                            {
                                                                case "s":
                                                                case "S":
                                                                    System.Console.WriteLine(" O aluno foi colocado como Delegado na turma " + Turmas[0].getNomeTurma());
                                                                    Turmas[0].setAlunoDelegado(Alunos[j].getNomeAluno());
                                                                    System.Console.WriteLine();
                                                                    System.Console.WriteLine();
                                                                    break;

                                                                case "n":
                                                                case "N":

                                                                    // Faz o Switch enquanto o valor que vier do utilizador for default, ou seja incorreto
                                                                    do
                                                                    {

                                                                        // Pergunta ao utilizador se então deseja inserir o aluno como delegado de turma
                                                                        System.Console.WriteLine(" Deseja então inserir o aluno como Sub-Delegado? (S/N)");

                                                                        // Lê o que o utilizador introduzir no teclado                               
                                                                        opcoes2 = System.Console.ReadLine();
                                                                        System.Console.WriteLine();

                                                                        // Switch para as turmas que o utilizador pode selecionar
                                                                        switch (opcoes2)
                                                                        {
                                                                            case "s":
                                                                            case "S":
                                                                                System.Console.WriteLine(" O aluno foi colocado como Sub-Delegado na turma " + Turmas[0].getNomeTurma());
                                                                                Turmas[0].setSubDelegado(Alunos[j].getNomeAluno());
                                                                                System.Console.WriteLine();
                                                                                System.Console.WriteLine();
                                                                                break;

                                                                            case "n":
                                                                            case "N":
                                                                                break;

                                                                            default:
                                                                                System.Console.WriteLine(" A opção introduzida não é válida, porfavor insira uma opção válida");
                                                                                System.Console.WriteLine();
                                                                                opcoes2 = "0";
                                                                                break;
                                                                        }
                                                                    } while (opcoes2 == "0");
                                                                    break;

                                                                default:
                                                                    System.Console.WriteLine(" A opção introduzida não é válida, porfavor insira uma opção válida");
                                                                    System.Console.WriteLine();
                                                                    opcoes1 = "0";
                                                                    break;
                                                            }
                                                        } while (opcoes1 == "0");
                                                        break;

                                                    case "2":
                                                        System.Console.WriteLine(" O aluno foi matriculado na turma " + Turmas[1].getNomeTurma());
                                                     
                                                        nAlunosmatriculados = aT2 + 1;
                                                        Alunos[j].setEstaMatriculado(true);
                                                        System.Console.WriteLine();

                                                        // Faz o Switch enquanto o valor que vier do utilizador for default, ou seja incorreto
                                                        do
                                                        {

                                                            // Pergunta se deseja inserir este aluno como delegado de turma
                                                            System.Console.WriteLine(" Deseja inserir este aluno como delegado de turma? (S/N)");

                                                            // Lê o que vier do teclado
                                                            opcoes3 = System.Console.ReadLine();
                                                            System.Console.WriteLine();

                                                            // Switch para aquilo que o utilizador introduzir se "S" o aluno é colocado como delegado, se "N", ele pergunta se quer o aluno como subdelegado
                                                            switch (opcoes3)
                                                            {
                                                                case "s":
                                                                case "S":
                                                                    System.Console.WriteLine(" O aluno foi colocado como Delegado na turma " + Turmas[1].getNomeTurma());
                                                                    Turmas[1].setAlunoDelegado(Alunos[j].getNomeAluno());
                                                                    System.Console.WriteLine();
                                                                    System.Console.WriteLine();
                                                                    break;

                                                                case "n":
                                                                case "N":

                                                                    do
                                                                    {

                                                                        // Pergunta ao utilizador se então deseja inserir o aluno como delegado de turma
                                                                        System.Console.WriteLine(" Deseja então inserir o aluno como Sub-Delegado? (S/N)");

                                                                        // Lê o que o utilizador introduzir no teclado                               
                                                                        opcoes4 = System.Console.ReadLine();
                                                                        System.Console.WriteLine();

                                                                        // Switch para as turmas que o utilizador pode selecionar
                                                                        switch (opcoes4)
                                                                        {
                                                                            case "s":
                                                                            case "S":
                                                                                System.Console.WriteLine(" O aluno foi colocado como Sub-Delegado na turma " + Turmas[1].getNomeTurma());
                                                                                Turmas[1].setSubDelegado(Alunos[j].getNomeAluno());
                                                                                System.Console.WriteLine();
                                                                                System.Console.WriteLine();
                                                                                break;

                                                                            case "n":
                                                                            case "N":
                                                                                break;

                                                                            default:
                                                                                System.Console.WriteLine(" A opção introduzida não é válida, porfavor insira uma opção válida");
                                                                                System.Console.WriteLine();
                                                                                opcoes4 = "0";
                                                                                break;
                                                                        }
                                                                    } while (opcoes4 == "0");
                                                                    break;

                                                                default:
                                                                    System.Console.WriteLine(" A opção introduzida não é válida, porfavor insira uma opção válida");
                                                                    System.Console.WriteLine();
                                                                    opcoes3 = "0";
                                                                    break;
                                                            }
                                                        } while (opcoes3 == "0");
                                                        break;

                                                    case "3":
                                                        System.Console.WriteLine(" O aluno foi matriculado na turma " + Turmas[2].getNomeTurma());
                                                      
                                                        nAlunosmatriculados = aT3 + 1;
                                                        Alunos[j].setEstaMatriculado(true);
                                                        System.Console.WriteLine();

                                                        // Faz o Switch enquanto o valor que vier do utilizador for default, ou seja incorreto
                                                        do
                                                        {

                                                            // Pergunta se deseja inserir este aluno como delegado de turma
                                                            System.Console.WriteLine(" Deseja inserir este aluno como delegado de turma? (S/N)");

                                                            // Lê o que vier do teclado
                                                            opcoes5 = System.Console.ReadLine();
                                                            System.Console.WriteLine();

                                                            // Switch para aquilo que o utilizador introduzir se "S" o aluno é colocado como delegado, se "N", ele pergunta se quer o aluno como subdelegado
                                                            switch (opcoes5)
                                                            {
                                                                case "s":
                                                                case "S":
                                                                    System.Console.WriteLine(" O aluno foi colocado como Delegado na turma " + Turmas[2].getNomeTurma());
                                                                    Turmas[2].setAlunoDelegado(Alunos[j].getNomeAluno());
                                                                    System.Console.WriteLine();
                                                                    System.Console.WriteLine();
                                                                    break;

                                                                case "n":
                                                                case "N":

                                                                    // Faz o Switch enquanto o valor que vier do utilizador for default, ou seja incorreto
                                                                    do
                                                                    {

                                                                        // Pergunta ao utilizador se então deseja inserir o aluno como delegado de turma
                                                                        System.Console.WriteLine(" Deseja então inserir o aluno como Sub-Delegado? (S/N)");

                                                                        // Lê o que o utilizador introduzir no teclado                               
                                                                        opcoes6 = System.Console.ReadLine();
                                                                        System.Console.WriteLine();

                                                                        // Switch para as turmas que o utilizador pode selecionar
                                                                        switch (opcoes6)
                                                                        {
                                                                            case "s":
                                                                            case "S":
                                                                                System.Console.WriteLine(" O aluno foi colocado como Sub-Delegado na turma " + Turmas[2].getNomeTurma());
                                                                                Turmas[2].setSubDelegado(Alunos[j].getNomeAluno());
                                                                                System.Console.WriteLine();
                                                                                System.Console.WriteLine();
                                                                                break;

                                                                            case "n":
                                                                            case "N":
                                                                                break;

                                                                            default:
                                                                                System.Console.WriteLine(" A opção introduzida não é válida, porfavor insira uma opção válida");
                                                                                System.Console.WriteLine();
                                                                                opcoes6 = "0";
                                                                                break;
                                                                        }
                                                                    } while (opcoes6 == "0");
                                                                    break;

                                                                default:
                                                                    System.Console.WriteLine(" A opção introduzida não é válida, porfavor insira uma opção válida");
                                                                    System.Console.WriteLine();
                                                                    opcoes5 = "0";
                                                                    break;
                                                            }
                                                        } while (opcoes5 == "0");
                                                        break;

                                                    default:
                                                        System.Console.WriteLine(" A opção introduzida não é válida, porfavor insira uma opção válida");
                                                        System.Console.WriteLine();
                                                        opcoes = "0";
                                                        break;
                                                }
                                            } while (opcoes == "0");
                                            break;

                                        default:
                                            System.Console.WriteLine(" Wrong answer - repita sff");
                                            System.Console.WriteLine();
                                            validoAluno = false;
                                            break;
                                    }
                                } while (!validoAluno);
                            }
                        }
                        else
                        {
                            System.Console.WriteLine(" Não existem turmas criadas, porfavor crie uma turma");
                        }

                        // Exceção para quando o programa for apresentar os dados
                        nAlunos = Alunos.Length;

                        System.Console.ReadKey();
                        System.Console.Clear();
                        break;

                    case "3":

                        // Caso o nTurmas for == 0, este ciclo for não pode ser executado, porque não existem turmas, se nTurmas >0 então o ciclo for para o preechimento dos alunos poderá ser executado
                        if (nTurmas != 0)
                        {
                            // Preenche 3 Professores
                            for (int i = 0; i < Professores.Length; i++)
                            {
                                Professores[i] = new Professor();

                                // Id do professor
                                Professores[i].setId(i + 1);

                                // Nome
                                System.Console.WriteLine(" Introduza o Nome do " + (i + 1) + "º professor");
                                Professores[i].setNomeProfessor(System.Console.ReadLine());
                                Professores[i].setNumeroProcesso(i + 1);
                                System.Console.WriteLine();

                                // Idade
                                System.Console.WriteLine(" Introduza a Idade do " + (i + 1) + "º professor");
                                Professores[i].setIdadeProfessor(System.Convert.ToInt32(System.Console.ReadLine()));
                                Professores[i].setDataNascimento(new DateTime());
                                System.Console.WriteLine();

                                // nº cartão de identificação
                                System.Console.WriteLine(" Introduza o nº CC do " + (i + 1) + "º professor");
                                Professores[i].setIdCivil(System.Convert.ToInt32(System.Console.ReadLine()));
                                System.Console.WriteLine();

                                // nº cartão de seg social
                                System.Console.WriteLine(" Introduza o nº Seg. Social " + (i + 1) + "º professor");
                                Professores[i].setIdSegSocial(System.Convert.ToInt32(System.Console.ReadLine()));
                                System.Console.WriteLine();

                                // nº cartão de sist. de saúde
                                System.Console.WriteLine(" Introduza o nº Sist.de saúde " + (i + 1) + "º professor");
                                Professores[i].setIdSistSaude(System.Convert.ToInt32(System.Console.ReadLine()));
                                System.Console.WriteLine();

                                // Morada                              

                                string rua, codigoPostal, numeroPorta, cidade;
                                int andar;

                                System.Console.WriteLine(" Introduza os seguintes dados da Morada do " + (i + 1) + "º Professor");
                                System.Console.WriteLine();

                                // Cidade
                                System.Console.WriteLine(" Introduza a cidade do " + (i + 1) + "º Professor");
                                cidade = System.Console.ReadLine();
                                System.Console.WriteLine();

                                // Rua
                                System.Console.WriteLine(" Introduza a rua do " + (i + 1) + "º Professor");
                                rua = System.Console.ReadLine();
                                System.Console.WriteLine();

                                // Código postal
                                System.Console.WriteLine(" Introduza o código postal do " + (i + 1) + "º Professor");
                                codigoPostal = System.Console.ReadLine();
                                System.Console.WriteLine();

                                // Número da porta
                                System.Console.WriteLine(" Introduza o número da porta do " + (i + 1) + "º Professor");
                                numeroPorta = System.Console.ReadLine();
                                System.Console.WriteLine();

                                // Andar
                                System.Console.WriteLine(" Introduza o andar do " + (i + 1) + "º Professor");
                                andar = System.Convert.ToInt32(System.Console.ReadLine());
                                System.Console.WriteLine();

                                Professores[i].setMorada(rua, andar, codigoPostal, cidade, numeroPorta);

                                // Género - repete até a resposta ser válida
                                bool validoProf = true;
                                do
                                {
                                    validoProf = true;
                                    System.Console.WriteLine(" Género Masculino? (S/N)");
                                    switch (System.Console.ReadLine())
                                    {
                                        case "s":
                                        case "S":
                                            Professores[i].setSexoMasculino(true);
                                            break;
                                        case "n":
                                        case "N":
                                            Professores[i].setSexoMasculino(false);
                                            break;

                                        default:
                                            System.Console.WriteLine();
                                            System.Console.WriteLine(" Wrong answer - repita sff");
                                            System.Console.WriteLine();
                                            validoProf = false;
                                            break;
                                    }
                                } while (!validoProf);

                                // nº de telefone
                                System.Console.WriteLine();
                                System.Console.WriteLine(" Introduza o número de telefone do " + (i + 1) + "º professor");
                                Professores[i].setTelefone(System.Console.ReadLine());
                                System.Console.WriteLine();

                                // nº de identificação Civil
                                System.Console.WriteLine(" Introduza o número de identificação Civil do " + (i + 1) + "º professor");
                                Professores[i].setIdCivil(System.Convert.ToInt32(System.Console.ReadLine()));
                                System.Console.WriteLine();

                                // Pergunta se o professor está matriculado - repete até a resposta ser válida
                                do
                                {
                                    validoProf = true;
                                    System.Console.WriteLine(" Está Matriculado? (S/N)");
                                    switch (System.Console.ReadLine())
                                    {
                                        case "s":
                                        case "S":
                                            Professores[i].setEstaMatriculado(true);
                                            break;

                                        case "n":
                                        case "N":
                                            Professores[i].setEstaMatriculado(false);

                                            // Faz o Switch enquanto o valor que vier do utilizador for default, ou seja incorreto
                                            do
                                            {

                                                // Pergunta em que turma deseja matricular o professor
                                                System.Console.WriteLine();
                                                System.Console.WriteLine(" Em qual das seguintes turmas deseja matricular o professor criado?");
                                                System.Console.WriteLine();

                                                // Ciclo for que mostra as turmas criadas                                         
                                                for (int p = 0; p < Professores.Length; p++)
                                                {
                                                    System.Console.WriteLine(" Press '" + (p + 1) + "' se quiser inserir o professor na - " + (p + 1) + "ª Turma ---> " + Turmas[p].getNomeTurma());
                                                }

                                                // Lê o que vier do teclado
                                                opcoes = System.Console.ReadLine();
                                                System.Console.WriteLine();

                                                // Switch para a turma que o utilizador escolher matricular o aluno
                                                switch (opcoes)
                                                {
                                                    case "1":
                                                        System.Console.WriteLine(" O professor foi matriculado na turma " + Turmas[0].getNomeTurma());
                                                        nProfessoresmatriculados = pT1 + 1;
                                                      
                                                        Professores[i].setEstaMatriculado(true);
                                                        System.Console.WriteLine();

                                                        // Faz o Switch enquanto o valor que vier do utilizador for default, ou seja incorreto
                                                        do
                                                        {

                                                            // Pergunta se deseja inserir este professor como DT de turma
                                                            System.Console.WriteLine(" Deseja inserir este professor como DT de turma? (S/N)");

                                                            // Lê o que vier do teclado
                                                            opcoes1 = System.Console.ReadLine();
                                                            System.Console.WriteLine();

                                                            // Switch para aquilo que o utilizador introduzir se "S" o professor é colocado como DT, se "N", ignora e continua o código
                                                            switch (opcoes1)
                                                            {
                                                                case "s":
                                                                case "S":
                                                                    System.Console.WriteLine(" O professor foi colocado como DT da turma " + Turmas[0].getNomeTurma());
                                                                    Turmas[0].setProfessorDt(Professores[i].getNomeProfessor());
                                                                    System.Console.WriteLine();
                                                                    System.Console.WriteLine();
                                                                    break;

                                                                case "n":
                                                                case "N":
                                                                    break;

                                                                default:
                                                                    System.Console.WriteLine(" A opção introduzida não é válida, porfavor introduza uma opção válida");
                                                                    System.Console.WriteLine();
                                                                    opcoes1 = "0";
                                                                    break;
                                                            }
                                                        } while (opcoes1 == "0");
                                                        break;

                                                    case "2":
                                                        System.Console.WriteLine(" O professor foi matriculado na turma " + Turmas[1].getNomeTurma());
                                                        nProfessoresmatriculados = pT2 + 1;                                                       

                                                        Professores[i].setEstaMatriculado(true);
                                                        System.Console.WriteLine();

                                                        // Faz o Switch enquanto o valor que vier do utilizador for default, ou seja incorreto
                                                        do
                                                        {

                                                            // Pergunta se deseja inserir este professor como DT de turma
                                                            System.Console.WriteLine(" Deseja inserir este professor como DT de turma? (S/N)");

                                                            // Lê o que vier do teclado
                                                            opcoes3 = System.Console.ReadLine();
                                                            System.Console.WriteLine();

                                                            // Switch para aquilo que o utilizador introduzir se "S" o professor é colocado como DT, se "N", ignora e continua o código
                                                            switch (opcoes3)
                                                            {
                                                                case "s":
                                                                case "S":
                                                                    System.Console.WriteLine(" O professor foi colocado como DT de turma " + Turmas[1].getNomeTurma());
                                                                    Turmas[1].setProfessorDt(Professores[i].getNomeProfessor());
                                                                    System.Console.WriteLine();
                                                                    System.Console.WriteLine();
                                                                    break;

                                                                case "n":
                                                                case "N":
                                                                    break;

                                                                default:
                                                                    System.Console.WriteLine(" A opção introduzida não é válida, porfavor introduza uma opção válida");
                                                                    System.Console.WriteLine();
                                                                    opcoes3 = "0";
                                                                    break;
                                                            }
                                                        } while (opcoes3 == "0");
                                                        break;

                                                    case "3":
                                                        System.Console.WriteLine(" O professor foi matriculado na turma " + Turmas[2].getNomeTurma());
                                                        nProfessoresmatriculados = pT3 + 1;
                                                      
                                                        Professores[i].setEstaMatriculado(true);
                                                        Professores[i].setEstaMatriculado(true);
                                                        System.Console.WriteLine();

                                                        // Faz o Switch enquanto o valor que vier do utilizador for default, ou seja incorreto
                                                        do
                                                        {

                                                            // Pergunta se deseja inserir este professor como DT de turma
                                                            System.Console.WriteLine(" Deseja inserir este professor como DT de turma? (S/N)");

                                                            // Lê o que vier do teclado
                                                            opcoes5 = System.Console.ReadLine();
                                                            System.Console.WriteLine();

                                                            // Switch para aquilo que o utilizador introduzir se "S" o professor é colocado como DT, se "N", ignora e continua o código
                                                            switch (opcoes5)
                                                            {
                                                                case "s":
                                                                case "S":
                                                                    System.Console.WriteLine(" O professor foi colocado como DT de turma " + Turmas[2].getNomeTurma());
                                                                    Turmas[2].setProfessorDt(Professores[i].getNomeProfessor());
                                                                    System.Console.WriteLine();
                                                                    System.Console.WriteLine();
                                                                    break;

                                                                case "n":
                                                                case "N":
                                                                    break;

                                                                default:
                                                                    System.Console.WriteLine(" A opção introduzida não é válida, porfavor introduza uma opção válida");
                                                                    System.Console.WriteLine();
                                                                    opcoes5 = "0";
                                                                    break;
                                                            }
                                                        } while (opcoes5 == "0");
                                                        break;

                                                    default:
                                                        System.Console.WriteLine(" A opção introduzida não é válida, porfavor introduza uma opção válida");
                                                        System.Console.WriteLine();
                                                        opcoes = "0";
                                                        break;
                                                }
                                            } while (opcoes == "0");
                                            break;

                                        default:
                                            System.Console.WriteLine(" Wrong answer - repita sff");
                                            System.Console.WriteLine();
                                            validoProf = false;
                                            break;
                                    }
                                } while (!validoProf);
                            }
                        }
                        else
                        {
                            System.Console.WriteLine(" Não existem turmas criadas, porfavor crie uma turma");
                        }

                        // Exceção para quando o programa for apresentar os dados
                        nProfessores = Professores.Length;

                        System.Console.ReadKey();
                        System.Console.Clear();
                        break;

                    case "4":

                        Console.Clear();

                        // Variável para a turma que o utilizador quiser ver no ecrã na lista de dados
                        string opcaoDados;

                        // Mostra Dados
                        if (nTurmas == 0)
                        {
                            System.Console.WriteLine(" Não contêm dados em relação ás Turmas ");
                            System.Console.WriteLine();
                        }
                        else
                        {
                            System.Console.WriteLine(" Qual das seguintes turmas pretende visualizar?");
                            System.Console.WriteLine();

                            // Ciclo for que mostra as turmas criadas      
                            for (int t = 0; t < Turmas.Length; t++)
                            {
                                System.Console.WriteLine((t + 1) + " - " + (t + 1) + "ª Turma ---> " + Turmas[t].getNomeTurma());
                            }
                            opcaoDados = System.Console.ReadLine();
                            Console.Clear();

                            // Switch para a turma escolhida
                            switch (opcaoDados)
                            {
                                case "1":

                                    System.Console.WriteLine(" Turma nº: " + Turmas[0].getId());
                                    System.Console.WriteLine(" Nome: " + Turmas[0].getNomeTurma());
                                    System.Console.WriteLine(" Número de alunos: " + Turmas[0].getnAlunos());
                                    System.Console.WriteLine(" Ciclo: " + Turmas[0].getCiclo());
                                    System.Console.WriteLine(" Curso: " + Turmas[0].getCurso());
                                    System.Console.WriteLine(" Turno: " + Turmas[0].getTurnoDiurno());
                                    System.Console.WriteLine(" Ano letivo: " + Turmas[0].getAnoLetivo());
                                    System.Console.WriteLine(" DT de Turma: " + Turmas[0].getProfessorDt());
                                    System.Console.WriteLine(" Delegado de turma: " + Turmas[0].getAlunoDelegado());
                                    System.Console.WriteLine(" Sub - Delegado de turma: " + Turmas[0].getSubDelegado());
                                    System.Console.WriteLine();
                                    System.Console.WriteLine();
                                    System.Console.WriteLine();

                                    if (nAlunosmatriculados == 0)
                                    {
                                        System.Console.WriteLine(" Não contêm Alunos matriculados nesta turma ");
                                        System.Console.WriteLine();
                                    }
                                    else
                                    {

                                        System.Console.WriteLine(" Aluno nº: " + Alunos[0].getId());
                                        System.Console.WriteLine(" Nº do Processo: " + Alunos[0].getNumeroProcesso());
                                        System.Console.WriteLine(" Nome: " + Alunos[0].getNomeAluno());
                                        System.Console.WriteLine(" Idade: " + Alunos[0].getIdadeAluno());
                                        System.Console.WriteLine(" Género Masculino: " + Alunos[0].getSexoMasculino());
                                        System.Console.WriteLine(" Número de telefone: " + Alunos[0].getTelefone());
                                        System.Console.WriteLine(" Morada: ");
                                        System.Console.WriteLine(" Cidade: " + Alunos[0].getMorada().cidade);
                                        System.Console.WriteLine(" Rua: " + Alunos[0].getMorada().rua);
                                        System.Console.WriteLine(" Código Postal: " + Alunos[0].getMorada().codigoPostal);
                                        System.Console.WriteLine(" Número da porta: " + Alunos[0].getMorada().numeroPorta);
                                        System.Console.WriteLine(" Andar: " + Alunos[0].getMorada().andar);
                                        System.Console.WriteLine(" Data de nascimento: " + Alunos[0].getDataNascimento());
                                        System.Console.WriteLine(" Tipo ID civil: " + Alunos[0].getTipoIdCivil());
                                        System.Console.WriteLine(" ID civil: " + Alunos[0].getIdCivil());
                                        System.Console.WriteLine(" ID segurança social: " + Alunos[0].getIdSegSocial());
                                        System.Console.WriteLine(" ID  sistema de saude: " + Alunos[0].getIdSistSaude());
                                        System.Console.WriteLine(" Tem turma: " + Alunos[0].getEstaMatriculado());
                                        System.Console.WriteLine();
                                        System.Console.WriteLine();

                                    }

                                    if (nProfessoresmatriculados == 0)
                                    {
                                        System.Console.WriteLine(" Não contêm Professores matriculados nesta turma ");
                                        System.Console.WriteLine();
                                    }
                                    else
                                    {

                                        System.Console.WriteLine(" Professor nº: " + Professores[0].getId());
                                        System.Console.WriteLine(" Nº do processo: " + Professores[0].getNumeroProcesso());
                                        System.Console.WriteLine(" Nome: " + Professores[0].getNomeProfessor());
                                        System.Console.WriteLine(" Idade: " + Professores[0].getIdadeProfessor());
                                        System.Console.WriteLine(" Género Masculino: " + Professores[0].getSexoMasculino());
                                        System.Console.WriteLine(" Número de telefone: " + Professores[0].getTelefone());
                                        System.Console.WriteLine(" Morada: ");
                                        System.Console.WriteLine(" Cidade: " + Professores[0].getMorada().cidade);
                                        System.Console.WriteLine(" Rua: " + Professores[0].getMorada().rua);
                                        System.Console.WriteLine(" Código Postal: " + Professores[0].getMorada().codigoPostal);
                                        System.Console.WriteLine(" Número da porta: " + Professores[0].getMorada().numeroPorta);
                                        System.Console.WriteLine(" Andar: " + Professores[0].getMorada().andar);
                                        System.Console.WriteLine(" Tipo ID civil: " + Professores[0].getTipoIdCivil());
                                        System.Console.WriteLine(" ID civil: " + Professores[0].getIdCivil());
                                        System.Console.WriteLine(" ID segurança social: " + Professores[0].getIdSegSocial());
                                        System.Console.WriteLine(" ID sistema saude: " + Professores[0].getIdSistSaude());
                                        System.Console.WriteLine(" Tem Turma: " + Professores[0].getEstaMatriculado());
                                        System.Console.WriteLine();
                                        System.Console.WriteLine();
                                    }
                                    break;

                                case "2":
                                
                                    System.Console.WriteLine(" Turma nº: " + Turmas[1].getId());
                                    System.Console.WriteLine(" Nome: " + Turmas[1].getNomeTurma());
                                    System.Console.WriteLine(" Número de alunos: " + Turmas[1].getnAlunos());
                                    System.Console.WriteLine(" Ciclo: " + Turmas[1].getCiclo());
                                    System.Console.WriteLine(" Curso: " + Turmas[1].getCurso());
                                    System.Console.WriteLine(" Turno: " + Turmas[1].getTurnoDiurno());
                                    System.Console.WriteLine(" Ano letivo: " + Turmas[1].getAnoLetivo());
                                    System.Console.WriteLine(" DT de Turma: " + Turmas[1].getProfessorDt());
                                    System.Console.WriteLine(" Delegado de turma: " + Turmas[1].getAlunoDelegado());
                                    System.Console.WriteLine(" Sub - Delegado de turma: " + Turmas[1].getSubDelegado());
                                    System.Console.WriteLine();
                                    System.Console.WriteLine();
                                    System.Console.WriteLine();

                                    if (nAlunosmatriculados == 0)
                                    {
                                        System.Console.WriteLine(" Não contêm Alunos matriculados nesta turma ");
                                        System.Console.WriteLine();
                                    }
                                    else
                                    {
                                        System.Console.WriteLine(" Aluno nº: " + Alunos[1].getId());
                                        System.Console.WriteLine(" Nº do Processo: " + Alunos[1].getNumeroProcesso());
                                        System.Console.WriteLine(" Nome: " + Alunos[1].getNomeAluno());
                                        System.Console.WriteLine(" Idade: " + Alunos[1].getIdadeAluno());
                                        System.Console.WriteLine(" Género Masculino: " + Alunos[1].getSexoMasculino());
                                        System.Console.WriteLine(" Número de telefone: " + Alunos[1].getTelefone());
                                        System.Console.WriteLine(" Morada: ");
                                        System.Console.WriteLine(" Cidade: " + Alunos[1].getMorada().cidade);
                                        System.Console.WriteLine(" Rua: " + Alunos[1].getMorada().rua);
                                        System.Console.WriteLine(" Código Postal: " + Alunos[1].getMorada().codigoPostal);
                                        System.Console.WriteLine(" Número da porta: " + Alunos[1].getMorada().numeroPorta);
                                        System.Console.WriteLine(" Andar: " + Alunos[1].getMorada().andar);
                                        System.Console.WriteLine(" Data de nascimento: " + Alunos[1].getDataNascimento());
                                        System.Console.WriteLine(" Tipo ID civil: " + Alunos[1].getTipoIdCivil());
                                        System.Console.WriteLine(" ID civil: " + Alunos[1].getIdCivil());
                                        System.Console.WriteLine(" ID segurança social: " + Alunos[1].getIdSegSocial());
                                        System.Console.WriteLine(" ID  sistema de saude: " + Alunos[1].getIdSistSaude());
                                        System.Console.WriteLine(" Tem turma: " + Alunos[1].getEstaMatriculado());
                                        System.Console.WriteLine();
                                        System.Console.WriteLine();
                                    }

                                    if (nProfessoresmatriculados == 0)
                                    {
                                        System.Console.WriteLine(" Não contêm Professores matriculados nesta turma ");
                                        System.Console.WriteLine();
                                    }
                                    else
                                    {
                                        System.Console.WriteLine(" Professor nº: " + Professores[1].getId());
                                        System.Console.WriteLine(" Nº do processo: " + Professores[1].getNumeroProcesso());
                                        System.Console.WriteLine(" Nome: " + Professores[1].getNomeProfessor());
                                        System.Console.WriteLine(" Idade: " + Professores[1].getIdadeProfessor());
                                        System.Console.WriteLine(" Género Masculino: " + Professores[1].getSexoMasculino());
                                        System.Console.WriteLine(" Número de telefone: " + Professores[1].getTelefone());
                                        System.Console.WriteLine(" Morada: ");
                                        System.Console.WriteLine(" Cidade: " + Professores[1].getMorada().cidade);
                                        System.Console.WriteLine(" Rua: " + Professores[1].getMorada().rua);
                                        System.Console.WriteLine(" Código Postal: " + Professores[1].getMorada().codigoPostal);
                                        System.Console.WriteLine(" Número da porta: " + Professores[1].getMorada().numeroPorta);
                                        System.Console.WriteLine(" Andar: " + Professores[1].getMorada().andar);
                                        System.Console.WriteLine(" Data de nascimento: " + Professores[1].getDataNascimento());
                                        System.Console.WriteLine(" Tipo ID civil: " + Professores[1].getTipoIdCivil());
                                        System.Console.WriteLine(" ID civil: " + Professores[1].getIdCivil());
                                        System.Console.WriteLine(" ID segurança social: " + Professores[1].getIdSegSocial());
                                        System.Console.WriteLine(" ID sistema saude: " + Professores[1].getIdSistSaude());
                                        System.Console.WriteLine(" Tem Turma: " + Professores[1].getEstaMatriculado());
                                        System.Console.WriteLine();
                                        System.Console.WriteLine();
                                    }
                                    break;

                                case "3":

                                    System.Console.WriteLine(" Turma nº: " + Turmas[2].getId());
                                    System.Console.WriteLine(" Nome: " + Turmas[2].getNomeTurma());
                                    System.Console.WriteLine(" Número de alunos: " + Turmas[2].getnAlunos());
                                    System.Console.WriteLine(" Ciclo: " + Turmas[2].getCiclo());
                                    System.Console.WriteLine(" Curso: " + Turmas[2].getCurso());
                                    System.Console.WriteLine(" Turno: " + Turmas[2].getTurnoDiurno());
                                    System.Console.WriteLine(" Ano letivo: " + Turmas[2].getAnoLetivo());
                                    System.Console.WriteLine(" DT de Turma: " + Turmas[2].getProfessorDt());
                                    System.Console.WriteLine(" Delegado de turma: " + Turmas[2].getAlunoDelegado());
                                    System.Console.WriteLine(" Sub - Delegado de turma: " + Turmas[2].getSubDelegado());
                                    System.Console.WriteLine();
                                    System.Console.WriteLine();
                                    System.Console.WriteLine();

                                    if (nAlunosmatriculados == 0)
                                    {
                                        System.Console.WriteLine(" Não contêm Alunos matriculados nesta turma ");
                                        System.Console.WriteLine();
                                    }
                                    else
                                    {
                                        System.Console.WriteLine(" Aluno nº: " + Alunos[2].getId());
                                        System.Console.WriteLine(" Nº do Processo: " + Alunos[2].getNumeroProcesso());
                                        System.Console.WriteLine(" Nome: " + Alunos[2].getNomeAluno());
                                        System.Console.WriteLine(" Idade: " + Alunos[2].getIdadeAluno());
                                        System.Console.WriteLine(" Género Masculino: " + Alunos[2].getSexoMasculino());
                                        System.Console.WriteLine(" Número de telefone: " + Alunos[2].getTelefone());
                                        System.Console.WriteLine(" Morada: ");
                                        System.Console.WriteLine(" Cidade: " + Alunos[2].getMorada().cidade);
                                        System.Console.WriteLine(" Rua: " + Alunos[2].getMorada().rua);
                                        System.Console.WriteLine(" Código Postal: " + Alunos[2].getMorada().codigoPostal);
                                        System.Console.WriteLine(" Número da porta: " + Alunos[2].getMorada().numeroPorta);
                                        System.Console.WriteLine(" Andar: " + Alunos[2].getMorada().andar);            
                                        System.Console.WriteLine(" Data de nascimento: " + Alunos[2].getDataNascimento());
                                        System.Console.WriteLine(" Tipo ID civil: " + Alunos[2].getTipoIdCivil());
                                        System.Console.WriteLine(" ID civil: " + Alunos[2].getIdCivil());
                                        System.Console.WriteLine(" ID segurança social: " + Alunos[2].getIdSegSocial());
                                        System.Console.WriteLine(" ID  sistema de saude: " + Alunos[2].getIdSistSaude());
                                        System.Console.WriteLine(" Tem turma: " + Alunos[2].getEstaMatriculado());
                                        System.Console.WriteLine();
                                        System.Console.WriteLine();
                                    }

                                    if (nProfessoresmatriculados == 0)
                                    {
                                        System.Console.WriteLine(" Não contêm Professores matriculados nesta turma ");
                                        System.Console.WriteLine();
                                    }
                                    else
                                    {
                                        System.Console.WriteLine(" Professor nº: " + Professores[2].getId());
                                        System.Console.WriteLine(" Nº do processo: " + Professores[2].getNumeroProcesso());
                                        System.Console.WriteLine(" Nome: " + Professores[2].getNomeProfessor());
                                        System.Console.WriteLine(" Idade: " + Professores[2].getIdadeProfessor());
                                        System.Console.WriteLine(" Género Masculino: " + Professores[2].getSexoMasculino());
                                        System.Console.WriteLine(" Número de telefone: " + Professores[2].getTelefone());
                                        System.Console.WriteLine(" Morada: ");
                                        System.Console.WriteLine(" Cidade: " + Alunos[2].getMorada().cidade);
                                        System.Console.WriteLine(" Rua: " + Professores[2].getMorada().rua);
                                        System.Console.WriteLine(" Código Postal: " + Professores[2].getMorada().codigoPostal);
                                        System.Console.WriteLine(" Número da porta: " + Professores[2].getMorada().numeroPorta);
                                        System.Console.WriteLine(" Andar: " + Professores[2].getMorada().andar);
                                        System.Console.WriteLine(" Data de Nascimento: " + Professores[2].getDataNascimento());
                                        System.Console.WriteLine(" Tipo ID civil: " + Professores[2].getTipoIdCivil());
                                        System.Console.WriteLine(" ID civil: " + Professores[2].getIdCivil());
                                        System.Console.WriteLine(" ID segurança social: " + Professores[2].getIdSegSocial());
                                        System.Console.WriteLine(" ID sistema saude: " + Professores[2].getIdSistSaude());
                                        System.Console.WriteLine(" Tem Turma: " + Professores[2].getEstaMatriculado());
                                        System.Console.WriteLine();
                                        System.Console.WriteLine();
                                   
                                    }
                                    break;

                                default:

                                    System.Console.WriteLine(" A opção introduzida não é válida, porfavor introduza uma opção válida");
                                    System.Console.ReadKey();
                                    break;
                            }
                            System.Console.ReadKey();
                            System.Console.Clear();
                        }
                        break;

                    case "0":

                        System.Console.WriteLine(" Cya!");
                        break;
                }
            } while (opcao != "0");            
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Métodos
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Número de astericos e tipo de carater que pretendemos utilizar para desenhar o Menu
        /// </summary>
        /// <param name="contador">Número de asteriscos</param>
        /// <param name="carater">Carater que pretendemos utilizar para desenhar o Menu</param>

        static void desenhaChar(int contador, char carater)
        {
            for (int i = 1; i <= contador; i++)
            {
                System.Console.Write(carater);
            }
        }

        /// <summary>
        /// Desenho e Opções do Menu
        /// </summary>
        static void desenhaMenu()
        {

            string menu = "Menu";
            string opcao1 = "Criar Turma";
            string opcao2 = "Adicionar Aluno";
            string opcao3 = "Adicionar Professor";
            string opcao4 = "Listar Dados";
            string opcao5 = "Sair";

            int conta;

            // Cabeçalho do Menu
            desenhaChar(35, ' ');
            desenhaChar(50, '*');
            System.Console.WriteLine(" ");
            desenhaChar(35, ' ');
            desenhaChar(2, '*');
            desenhaChar(20, ' ');
            conta = menu.Length;
            System.Console.Write(menu);
            desenhaChar(26 - conta, ' ');
            desenhaChar(2, '*');
            System.Console.WriteLine(" ");
            desenhaChar(35, ' ');
            desenhaChar(50, '*');

            // Linhas Laterais
            System.Console.WriteLine(" ");
            desenhaChar(35, ' ');
            desenhaChar(1, '*');
            desenhaChar(48, ' ');
            desenhaChar(1, '*');

            // Linhas Laterais e 1 ª opção do Menu
            System.Console.WriteLine(" ");
            desenhaChar(35, ' ');
            desenhaChar(1, '*');
            desenhaChar(5, ' ');
            System.Console.Write(" 1 - ");
            conta = opcao1.Length;
            System.Console.Write(opcao1);
            desenhaChar(38 - conta, ' ');
            desenhaChar(1, '*');

            // Linhas Laterais
            System.Console.WriteLine(" ");
            desenhaChar(35, ' ');
            desenhaChar(1, '*');
            desenhaChar(48, ' ');
            desenhaChar(1, '*');

            System.Console.WriteLine(" ");
            desenhaChar(35, ' ');
            desenhaChar(1, '*');
            desenhaChar(48, ' ');
            desenhaChar(1, '*');

            // Linhas Laterais e 2 ª opção do Menu
            System.Console.WriteLine(" ");
            desenhaChar(35, ' ');
            desenhaChar(1, '*');
            desenhaChar(5, ' ');
            System.Console.Write(" 2 - ");
            conta = opcao2.Length;
            System.Console.Write(opcao2);
            desenhaChar(38 - conta, ' ');
            desenhaChar(1, '*');

            // Linhas Laterais
            System.Console.WriteLine(" ");
            desenhaChar(35, ' ');
            desenhaChar(1, '*');
            desenhaChar(48, ' ');
            desenhaChar(1, '*');

            System.Console.WriteLine(" ");
            desenhaChar(35, ' ');
            desenhaChar(1, '*');
            desenhaChar(48, ' ');
            desenhaChar(1, '*');

            // Linhas Laterais e 3 ª opção do Menu
            System.Console.WriteLine(" ");
            desenhaChar(35, ' ');
            desenhaChar(1, '*');
            desenhaChar(5, ' ');
            System.Console.Write(" 3 - ");
            conta = opcao3.Length;
            System.Console.Write(opcao3);
            desenhaChar(38 - conta, ' ');
            desenhaChar(1, '*');

            // Linhas Laterais
            System.Console.WriteLine(" ");
            desenhaChar(35, ' ');
            desenhaChar(1, '*');
            desenhaChar(48, ' ');
            desenhaChar(1, '*');

            System.Console.WriteLine(" ");
            desenhaChar(35, ' ');
            desenhaChar(1, '*');
            desenhaChar(48, ' ');
            desenhaChar(1, '*');

            // Linhas Laterais e 4 ª opção do Menu
            System.Console.WriteLine(" ");
            desenhaChar(35, ' ');
            desenhaChar(1, '*');
            desenhaChar(5, ' ');
            System.Console.Write(" 4 - ");
            conta = opcao4.Length;
            System.Console.Write(opcao4);
            desenhaChar(38 - conta, ' ');
            desenhaChar(1, '*');

            // Linhas Laterais
            System.Console.WriteLine(" ");
            desenhaChar(35, ' ');
            desenhaChar(1, '*');
            desenhaChar(48, ' ');
            desenhaChar(1, '*');

            System.Console.WriteLine(" ");
            desenhaChar(35, ' ');
            desenhaChar(1, '*');
            desenhaChar(48, ' ');
            desenhaChar(1, '*');

            // Linhas Laterais e 5 ª opção do Menu
            System.Console.WriteLine(" ");
            desenhaChar(35, ' ');
            desenhaChar(1, '*');
            desenhaChar(5, ' ');
            System.Console.Write(" 0 - ");
            conta = opcao5.Length;
            System.Console.Write(opcao5);
            desenhaChar(38 - conta, ' ');
            desenhaChar(1, '*');

            // Linhas Laterais
            System.Console.WriteLine(" ");
            desenhaChar(35, ' ');
            desenhaChar(1, '*');
            desenhaChar(48, ' ');
            desenhaChar(1, '*');

            // Linha de baixo do Menu
            System.Console.WriteLine(" ");
            desenhaChar(35, ' ');
            desenhaChar(50, '*');
            System.Console.WriteLine(" ");
            System.Console.WriteLine(" ");
        }
    }
    public struct Morada
    {
        public string rua;
        public string codigoPostal;
        public string numeroPorta;
        public int andar;
        public string cidade;
    }
}

        
    
