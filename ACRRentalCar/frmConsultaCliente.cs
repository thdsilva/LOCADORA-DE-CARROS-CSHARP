using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//inclui namespace para o banco SqlServer
using System.Data.SqlClient;

namespace ACRRentalCar
{
    public partial class frmConsultaCliente : Form
    {
        //declara uma variável (objeto) do tipo fmrCadastroCliente
        fmrCadastroCliente fmrCliente; // Variável da classe

        //Passando por parametro o form fmrCadastroCliente
        //construtor recebe como parametro declara uma variável
        //(objeto) do tipofmrCliente
        public frmConsultaCliente(fmrCadastroCliente fmrCliente)
        {
            //variável da classe = parametro do construtor
            this.fmrCliente = fmrCliente;

            InitializeComponent();
        }

        public void frmConsultaCliente_Load(object sender, EventArgs e)
        {
            //declaração da variável para guardar as instruções SQL
            string sqlQuery;

            //cria conexão chamando o método getConnection da classe Conexao
            SqlConnection conCliente = conectar.GetConnection();

            //cria a instrução sql, parametrizada para selecionar todos os clientes em ordem crescente por nome
            sqlQuery = "SELECT id_cliente, nome, cpf, data_nasc FROM cliente ORDER BY nome";

            //declara um DataAdapter
            SqlDataAdapter dta = new SqlDataAdapter(sqlQuery, conCliente);

            //Declara um DataTable
            DataTable dt = new DataTable();

            //Tratamento de exceções
            try
            {
                //chama o método Fill() do DataAdapter passando como parâmetro o DataTable dt
                dta.Fill(dt);

                //configura a fonte de dados no DataGridView
                dvgCliente.DataSource = dt;

                //altera a cor das linhas alternadas no grid
                dvgCliente.RowsDefaultCellStyle.BackColor = Color.White;
                dvgCliente.AlternatingRowsDefaultCellStyle.BackColor = Color.Aquamarine;

                //cria as colunas no DataGridView e coloca o texto do nome das colunas
                dvgCliente.Columns[0].HeaderCell.Value = "Código do Cliente"; //primeira coluna
                dvgCliente.Columns[1].HeaderCell.Value = "Nome"; //segunda coluna
                dvgCliente.Columns[2].HeaderCell.Value = "CPF"; //terciera coluna
                dvgCliente.Columns[3].HeaderCell.Value = "Dt. Nasc."; //Quarta coluna
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema ao listar clientes " + ex, "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (conCliente != null)
                {
                    conCliente.Close();
                }
            }
        }

        public void btnSelecionar_Click(object sender, EventArgs e)
        {
            //variável para guardar o código do cliente selecionado no DataGridView
            string codigoCliente;

            //seleciona o código da linha atual da coluna[0] do DataGridView
            codigoCliente = dvgCliente.CurrentRow.Cells[0].Value.ToString();

            //declaração da variável para guardar as instruções SQL
            string sqlQuery;

            //cria conexão chamando o método getConnection da classe Conexao
            SqlConnection conClienteConsulta = conectar.GetConnection();

            //declara e inicializa um DataReader como null
            SqlDataReader dtr = null;

            //cria a instrução sql, parametrizada
            sqlQuery = "SELECT id_cliente, nome, cpf, data_nasc FROM cliente WHERE id_cliente = @id_cliente";

            //tratamento de exceções
            try
            {
                //abrir conexão
                conClienteConsulta.Open();

                // cria um command para esta conexão
                SqlCommand cmd = new SqlCommand(sqlQuery, conClienteConsulta);

                //adiciona um parâmetro
                cmd.Parameters.Add(new SqlParameter("@id_cliente", Convert.ToInt32(codigoCliente)));

                //Atribui o comando ao DataReader
                dtr = cmd.ExecuteReader();

                //verifica se retornou registro na consulta SQL
                //se retornou, preenche a tela do frmCadastroCliente com os dados armazenados no DataReader dtr
                //chama o método Read( ) para ler os registros no dtr
                if (dtr.Read())
                {
                    //para o Form frmCadastroCliente
                    //atribui ao TextBox o valor do campo ID_CLIENTE do banco de dados retornado na consulta
                    fmrCliente.txtCodigo.Text = dtr["ID_CLIENTE"].ToString();

                    fmrCliente.txtNome.Text = dtr["NOME"].ToString();
                    fmrCliente.mskDtNasc.Text = dtr["DATA_NASC"].ToString();
                    fmrCliente.mskCPF.Text = dtr["CPF"].ToString();
                }
            }
            //se houve exceção as instruções do bloco catch serão executadas
            catch (Exception ex)
            {
                //exibe a mensagem sobre a exceção ocorrida no bloco try
                MessageBox.Show(ex.ToString());
            }
            //as instruções de finally sempre serão executadas independente se houve exceção ou não
            finally
            {
                //fecha o DataReader se for diferente de null, ou sej,a se estiver conectado
                if (dtr != null)
                {
                    dtr.Close();
                }
                //fecha a conexão se for diferente de null
                if (conClienteConsulta != null)
                {
                    conClienteConsulta.Close();
                }
            }

            //fecha o form
            this.Close();
        }

        public void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
