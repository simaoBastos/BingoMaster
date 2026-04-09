namespace BingoMaster
{
    public partial class Form1 : Form
    {
        private List<int> globoDeNumeros = new List<int>();
        private Random random = new Random();

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
            btnReiniciar.Enabled = true;
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
            //Se o o globo não estiver vazio;
            if (globoDeNumeros.Count > 0)
            {
                //1. O índiceSorteado recebe um indice aleatório do globo de números
                int indiceSorteado = random.Next(globoDeNumeros.Count);

                //2. o numeroSorteado recebe o número correspondente ao índice sorteado
                int numeroSorteado = globoDeNumeros[indiceSorteado];

                //3. Exibir o número sorteado no lblNumeroGrande
                lblNumeroGrande.Text = numeroSorteado.ToString("D2");

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
