using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        //Private só pode ser acessado ou modificado dentro da própria classe onde está definido
        private string[] nomes = new string[3];
        private int vetor = 0;

        public Form1()
        {
            InitializeComponent();
        }

      
        private void btnInserirNome_Click(object sender, EventArgs e)
        {
            //é usado para garantir que a string não contenha espaços em branco extras no começo ou no final
            string nome = combBoxNome.Text.Trim(); 

            
            if (string.IsNullOrEmpty(nome)) //usada para verificar se uma string do nome está nula ou vazia
            {
                MessageBox.Show("Por favor, insira um nome.");
                return;
            }

            foreach (var nomeExistente in nomes) // o foreach é para iterar (Repetir) a coleção dos nomes 
            {
                if (nomeExistente == nome)
                {
                    MessageBox.Show("Nome já cadastrado.");
                    return;
                }
            }

           
            if (vetor < 3 )
            {
                nomes[vetor] = nome;
                vetor++;
                MessageBox.Show("Nome cadastrado com sucesso!");

               
            }
            else
            {
                MessageBox.Show("O array de nomes está completo.");
               string todosNomes = string.Join(Environment.NewLine, nomes.Where(n => !string.IsNullOrEmpty(n)));
            MessageBox.Show("Nomes armazenados:\n\n" + todosNomes);
            }


            combBoxNome.ResetText(); //Limpa o nome que acabou de ser escrito
        }

 

        private void btnNome1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nomes[0] ?? "Nome 1 está vazio.");
        }

  
        private void btnNome2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nomes[1] ?? "Nome 2 está vazio.");
        }


        private void btnNome3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nomes[2] ?? "Nome 3 está vazio.");
        }

        private void btnLimparArray_Click(object sender, EventArgs e)
        {
            nomes = new string[3]; 
            vetor = 0; 
           
            MessageBox.Show("Todos os nomes foram limpos.");
        }

 
    }
}  
