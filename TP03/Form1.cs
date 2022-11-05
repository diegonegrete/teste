using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace TP03
{
    public partial class Form1 : Form
    {
        string URI="";
        int codigoLivro = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private async void GetAllLivros()
        {
            URI = txtURI.Text;
            using (var client=new HttpClient())
            {
                using(var response=await client.GetAsync(URI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var LivroJsonString=await response.Content.ReadAsStringAsync();
                        gdvDados.DataSource = JsonConvert.DeserializeObject<Livro[]>(LivroJsonString).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter o livro: " + response.StatusCode);
                    }
                }
            }
        }

        private async void GetLivroById(int codLivro)
        {
            using(var client=new HttpClient())
            {
                BindingSource bsDados = new BindingSource();
                URI=txtURI.Text+"/"+codLivro.ToString();
                HttpResponseMessage response = await client.GetAsync(URI);
                if (response.IsSuccessStatusCode)
                {
                    var LivroJsonString = await response.Content.ReadAsStringAsync();
                    bsDados.DataSource= JsonConvert.DeserializeObject<Livro>(LivroJsonString);
                    gdvDados.DataSource = bsDados;
                }
                else
                {
                    MessageBox.Show("Falha ao obter o livro: " + response.StatusCode);
                }
            }
        }

        private async void AddLivro()
        {
            URI = txtURI.Text;
            Livro livro = new Livro();
            livro.Titulo = "Titulo";
            livro.Subtitulo = "Subtitulo";
            livro.Resumo = "Resumo";
            livro.Autor = "Autor";
            using(var client=new HttpClient())
            {
                var serializedLivro=JsonConvert.SerializeObject(livro);
                var content=new StringContent(serializedLivro,Encoding.UTF8,"application/json");
                var result=await client.PostAsync(URI,content);
            }
            GetAllLivros();
        }

        private async void UpdateLivro(int codLivro)
        {
            URI=txtURI.Text;
            Livro livro = new Livro();
            livro.Id=codLivro;
            livro.Titulo = "Titulo2";
            livro.Subtitulo = "Subtitulo2";
            livro.Resumo = "Resumo2";
            livro.Autor = "Autor2";
            using(var client =new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.PutAsJsonAsync(URI + "/" + livro.Id, livro);
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Livro atualizado");
                }
                else
                {
                    MessageBox.Show("Falha ao atualizar o livro: " + responseMessage.StatusCode);
                }
            }
            GetAllLivros();
        }

        private async void DeleteLivro(int codLivro)
        {
            URI= txtURI.Text;
            int LivroID = codLivro;
            using(var client=new HttpClient())
            {
                client.BaseAddress = new Uri(URI);
                HttpResponseMessage responseMessage = await client.DeleteAsync(String.Format("{0}/{1}", URI, LivroID));
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Livro excluído com sucesso");
                }
                else
                {
                    MessageBox.Show("Falha ao excluir o livro: "+responseMessage.StatusCode);
                }
            }
            GetAllLivros();
        }

        private void InputBox()
        {
            string Prompt = "Informe o código do livro";
            string Titulo = "SWII6 - TP03";
            string Resultado = Microsoft.VisualBasic.Interaction.InputBox(Prompt,Titulo,"9",600,350);
            if (Resultado != "")
            {
                codigoLivro = Convert.ToInt32(Resultado);
            }
            else
            {
                codigoLivro = -1;
            }
        }

        private void btnObterLivros_Click(object sender, EventArgs e)
        {
            GetAllLivros();
        }

        private void btnLivrosPorId_Click(object sender, EventArgs e)
        {
            InputBox();
            if (codigoLivro != -1)
            {
                GetLivroById(codigoLivro);
            }
        }

        private void btnIncluirLivro_Click(object sender, EventArgs e)
        {
            AddLivro();
        }

        private void btnAtualizaLivro_Click(object sender, EventArgs e)
        {
            InputBox();
            if(codigoLivro != -1)
            {
                UpdateLivro(codigoLivro);
            }
        }

        private void btnDeletarLivro_Click(object sender, EventArgs e)
        {
            InputBox();
            if(codigoLivro!= -1)
            {
                DeleteLivro(codigoLivro);
            }
        }
    }
}