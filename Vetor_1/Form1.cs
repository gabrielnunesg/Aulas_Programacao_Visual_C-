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
            //Declara��o de um vetor de 10 posi��es

            int[] vetor = new int[10];
            
            int i; //Vari�vel i para o �ndice

            lstVetor.Items.Clear();

            for(i = 0; i < 10; i++)
            {
                //atribuindo o valor de i para o vetor no �ndice i
                vetor[i] = i;

                lstVetor.Items.Add("Vetor �ndice [" + i + "] = " + vetor[i]);
            }
        }
    }
}