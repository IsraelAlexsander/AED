using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Xml.Serialization;

namespace Model_View_Controller__MVC_
{
    internal class Dados
    {
        private ArrayList Cadastro;

        public Dados()
        {
            Cadastro = new ArrayList();
        }

        public void InserirAluno(Aluno x)
        {
            Cadastro.Add(x);
        }

        public ArrayList ListarAlunos()
        {
            return Cadastro;
        }

        public Aluno PesquisarAluno(string cod)
        {
            foreach (Aluno x in Cadastro)
            {
                if(x.codigo == cod.ToUpper())
                {
                    return x;
                }                
                              
            }
            return null;
        }

        public void ExcluirAluno(Aluno x)
        {
            Cadastro.Remove(x);
        }

        public void AlterarAluno(Aluno Antigo, Aluno Novo)
        {
            int posicao;

            posicao = Cadastro.IndexOf(Antigo);

            Cadastro.Remove(Antigo);

            Cadastro.Insert(posicao, Novo);
        }

        public int OrdenarAlunos()
        {
            Cadastro.Sort(new MinhaOrdenacao());

            return Cadastro.Count;
        }

        public class MinhaOrdenacao : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                return ((Aluno)x).nome.CompareTo(((Aluno)y).nome);
            }
        } 

        public int SalvarArquivo()
        {
            TextWriter MeuWriter = new StreamWriter(@"D:\Arquivo XML\CadastroAlunos.xml");

            Aluno[] ListaAlunoVetor = (Aluno[])Cadastro.ToArray(typeof(Aluno));

            //Serialização

            XmlSerializer Serializacao = new XmlSerializer(ListaAlunoVetor.GetType());

            Serializacao.Serialize(MeuWriter, ListaAlunoVetor);

            MeuWriter.Close();

            return Cadastro.Count;
        }

        public int LerArquivo()
        {
            FileStream Arquivo = new FileStream(@"D:\Arquivo XML\CadastroAlunos.xml", FileMode.Open);

            Aluno[] listaAlunoVetor = (Aluno[])Cadastro.ToArray(typeof(Aluno));

            XmlSerializer Deserializacao = new XmlSerializer(listaAlunoVetor.GetType());

            listaAlunoVetor = (Aluno[])Deserializacao.Deserialize(Arquivo);

            Cadastro.Clear();

            Cadastro.AddRange(listaAlunoVetor);
            
            Arquivo.Close();

            return Cadastro.Count;
        }
    }
}
