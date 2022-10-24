namespace Vetor_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVetor_Click(object sender, EventArgs e)
        {
            //Declaração de um vetor de 10 posições

            int[] vetor = new int[10];
            
            int i; //Variável i para o índice

            lstVetor.Items.Clear();

            for(i = 0; i < 10; i++)
            {
                //atribuindo o valor de i para o vetor no índice i
                vetor[i] = i;

                lstVetor.Items.Add("Vetor índice [" + i + "] = " + vetor[i]);
            }
        }
    }
}