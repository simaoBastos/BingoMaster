using System.Media;

namespace BingoMaster
{
    public partial class Form1 : Form
    {
        private List<int> globoDeNumeros = new List<int>();
        private Random random = new Random();

        SoundPlayer tick = new SoundPlayer("tick.wav");
        SoundPlayer ding = new SoundPlayer("ding.wav");


        public Form1()
        {
            InitializeComponent();
            ConfigurarNovoJogo();
        }

        private void ConfigurarNovoJogo()
        {
            //Limpar o globo de números
            globoDeNumeros.Clear();

            // Preencher o globo de números de 1 a 75
            for (int i = 1; i <= 75; i++)
            {
                globoDeNumeros.Add(i);
            }

            // Limpar a lista de números sorteados
            lstHistorico.Items.Clear();
            //Zerar o número no contador
            lblNumeroGrande.Text = "--";
            //Habilitar o botão de sortear
            btnSortear.Enabled = true;
        }

        private async Task AnimacaoSorteador()
        {
            int tempoLoop = 80;

            while (tempoLoop < 1000)
            {
                int tempIndex = random.Next(globoDeNumeros.Count);
                int tempNumero = globoDeNumeros[tempIndex];

                lblNumeroGrande.Text = tempNumero.ToString("D2");


                //System.Media.SystemSounds.Exclamation.Play();
                tick.Play();

                await Task.Delay(tempoLoop);
                tempoLoop = (int)(tempoLoop * 1.15);
            }
        }

        private async void btnSortear_Click(object sender, EventArgs e)
        {
            //SE o o globo não estiver vazio;
            if (globoDeNumeros.Count > 0)
            {

                //SE o checkbox tiver ativo, a animação rodará 
                if (chkAnimacao.Checked)
                {
                    btnSortear.Enabled = false;
                    btnReiniciar.Enabled = false;
                    chkAnimacao.Enabled = false;
                    await AnimacaoSorteador();
                    btnReiniciar.Enabled = true;
                    btnSortear.Enabled = true;
                    chkAnimacao.Enabled = true;
                }
                

                //1. O índiceSorteado recebe um indice aleatório do globo de números
                int indiceSorteado = random.Next(globoDeNumeros.Count);

                //2. o numeroSorteado recebe o número correspondente ao índice sorteado
                int numeroSorteado = globoDeNumeros[indiceSorteado];

                //3. Exibir o número sorteado no lblNumeroGrande
                lblNumeroGrande.Text = numeroSorteado.ToString("D2");

                //SFX toca
                ding.Play();

                //4. Adicionar o número sorteado ao lstHistorico
                lstHistorico.Items.Insert(0, $"Nº {numeroSorteado.ToString("D2")}");

                //5. Remover o número sorteado do globo de números
                globoDeNumeros.RemoveAt(indiceSorteado);

                
            }
            else
            {
                btnSortear.Enabled = false;
                MessageBox.Show("Fim do bingo! Todos os números foram sorteados");
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            ConfigurarNovoJogo();
        }
    }
}
