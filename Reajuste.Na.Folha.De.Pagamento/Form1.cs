using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;


namespace Reajuste.Na.Folha.De.Pagamento
{
    public partial class Form1 : Form
    {
        private RepositorioFuncionario repositorio = new RepositorioFuncionario();
        private BindingSource leituraSource = new BindingSource();
        public Form1 ()
        {
            InitializeComponent();
            leituraSource.DataSource = repositorio.ObterTodos();
            dataGridView1.DataSource = leituraSource;
        }

        private void button1_Click ( object sender , EventArgs e )
        {
            if (ofdListaFuncionarios.ShowDialog() == DialogResult.OK)
            {
                txtArquivo.Text = ofdListaFuncionarios.FileName;
                ProcessarArquivo(txtArquivo.Text);
                if (repositorio.ObterTodos().Count > 0)
                {
                    TotalizarValores(repositorio.ObterTodos());
                }

            }
        }
        private void TotalizarValores ( IList<Funcionario> funcionarios )
        {
            double? totalSemReajuste = 0, totalComReajuste = 0;
            foreach (var funcionario in funcionarios)
            {
                totalSemReajuste += funcionario.Salario;
                totalComReajuste += funcionario.NovoSalario;
            }
            double? percentual = (totalComReajuste - totalSemReajuste) / totalSemReajuste * 100;
            lblTotalSemReajuste.Text = String.Format("{0:c}" , totalSemReajuste);
            lblTotalComReajuste.Text = String.Format("{0:c}" , totalComReajuste);
            lblPorcentagem.Text = String.Format("{0:n}%" , percentual);

        }
        private void ProcessarArquivo ( string Nomearquivo )
        {
            repositorio.ObterTodos().Clear();
            string linhalida;

            var arquivo = new StreamReader(Nomearquivo);
            while ((linhalida = arquivo.ReadLine()) != null)
            {
                var dadosLidos = linhalida.Split(';');
                var funcionario = new Funcionario
                {
                    Codigo = Convert.ToInt32(dadosLidos [0]) ,
                    Salario = Convert.ToInt32(dadosLidos [1])
                };

                repositorio.Inserir(funcionario);
            }
            arquivo.Close();
        }


    }
}
