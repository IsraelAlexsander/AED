using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TrabalhoHashTable
{
    internal class Dados
    {
        private Hashtable Cadastro;

        public Dados()
        {
            Cadastro = new Hashtable();
        }

        public void inserirPaciente(Paciente P)
        {
            Cadastro.Add(P.RG, P);      //Chave será o RG
        }

        public Hashtable listar()
        {
            return Cadastro;
        }

        public Paciente pesquisarPaciente(string RG)
        {
            foreach(Paciente P in Cadastro.Values)
            {
                if (RG.ToUpper() == P.RG.ToUpper())
                    return P;
            }
            return null;
        }

        public void excluirPaciente(string RG)
        {
            Cadastro.Remove(RG);                     
        }

        public int salvarArquivo()
        {
            TextWriter meuWriter = new StreamWriter(@".\CadastroPaciente.xml");

            Paciente[] listaPaciente = criarVetor();

            XmlSerializer serializacao = new XmlSerializer(listaPaciente.GetType());

            serializacao.Serialize(meuWriter, listaPaciente);

            meuWriter.Close();

            return Cadastro.Count;
        }
        
        public int lerArquivo()
        {
            FileStream Arquivo = new FileStream(@".\CadastroPaciente.xml", FileMode.Open);

            Paciente[] listaPaciente = criarVetor();

            XmlSerializer deserializacao = new XmlSerializer(listaPaciente.GetType());

            listaPaciente = (Paciente[])deserializacao.Deserialize(Arquivo);

            Cadastro.Clear();

            Cadastro = lerVetor(listaPaciente);

            Arquivo.Close();

            return Cadastro.Count;
        }

        public Paciente[] criarVetor()
        {            
            Paciente[] Vetor = new Paciente[Cadastro.Count];

            int i = 0;

            foreach (Paciente P in Cadastro.Values)
            {
                Vetor[i] = P;
                i++;
            }

            return Vetor;
        }

        public Hashtable lerVetor(Paciente[] Vetor)
        {            
            Hashtable C = new Hashtable();
            foreach (Paciente P in Vetor)
            {
                C.Add(P.RG, P);
            }
            return C;
        }
    }
}
