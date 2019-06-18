using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
//using System;
using System.Data;
using Npgsql;
//using System.Data;
using System.Data.OleDb;



namespace Cake
{
    class Class1
    {
        static string serverName = "127.0.0.1";                                          //localhost
        static string port = "5432";                                                            //porta default
        static string userName = "postgres";                                               //nome do administrador
        static string password = "SENHA";                                             //senha do administrador
        static string databaseName = "cake";                                       //nome do banco de dados
       NpgsqlConnection pgsqlConnection = null;
        string connString = null;

        public Class1()
        {
            // classe de conecção com o banco de dados teste
            connString = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",
                                                   serverName, port, userName, password, databaseName);

        }

        public void cadastrarAdm(String codigo, String nome, String senha)
        {
            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                {
                    //Abra a conexão com o PgSQL                  
                    pgsqlConnection.Open();

                    string cmdInserir = String.Format("Insert Into adm(cod_adm,nome_adm,senha) values('{0}','{1}',{2})", codigo, nome, senha);

                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(cmdInserir, pgsqlConnection))
                    {
                        pgsqlcommand.ExecuteNonQuery();
                    }
                    MessageBox.Show("Cadastro Realizado com sucesso !");
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //pgsqlConnection.Close();
            }

        }
        //
        // ------------------------Método de login -------------------------------------
        public void FazerLogin(String usuario, String senha)
        {
            DataTable dt = new DataTable();
            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                {
                    //Abra a conexão com o PgSQL
                    pgsqlConnection.Open();
                    string pass= "'" + senha + "'"; // tratamento para bug de string do visual estudio
                    string name = "'" + usuario + "'"; // tratamento para bug de string do visual estudio

                    string cmdSeleciona = "Select * from adm where senha = " + pass + "and nome_adm = " + name;

                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSeleciona, pgsqlConnection))

                    {

                        Adpt.Fill(dt);

                        DataRow dr = dt.Rows[0];
                        string cod = dr[0].ToString();
                        string nome= dr[1].ToString();
                        string s = dr[2].ToString();

                        //fazendo o teste da senha
                        if (senha == s && usuario == nome)
                        {
                            MessageBox.Show("Bem vindo ! " + nome);
                            FrmBolos outroForm = new FrmBolos();
                            //outroForm.Show();
                            //this.Close();
                            
                            
                        }
                        else
                        {
                            MessageBox.Show("senha incorreta!");
                        }

                    }


                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
                //MessageBox.Show("senha incorreta!");

            }
            finally
            {
                //pgsqlConnection.Close();
            }
            //return dt;




        }

        private void Close()
        {
            throw new NotImplementedException();
        }





        //----------------------Métodos para CRUD do bolo--------------------------------------------
        // Metodo para Cadastrar Bolo
        public void cadastrarBolo(String codigoBolo, String nomeBolo, String descricaoBolo, float precoKg)
        {
            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                {
                    //Abra a conexão com o PgSQL                  
                    pgsqlConnection.Open();

                    string cmdInserir = String.Format("Insert Into bolos(cod_bolo,nome_bolo,descricao_bolo, preco_por_kg) values('{0}','{1}','{2}','{3}')", codigoBolo, nomeBolo, descricaoBolo, precoKg);

                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(cmdInserir, pgsqlConnection))
                    {
                        pgsqlcommand.ExecuteNonQuery();
                    }
                    MessageBox.Show("Bolo cadastrado com sucesso !");
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //pgsqlConnection.Close();
            }

        }
        //
        //--------------- Metodo de alterar bolo--------------------------------------------
         public void alterarBolo(String codigoBolo, String nomeBolo, String descricaoBolo, float precoKg)
    {
        try
        {
            using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
            {
                //Abra a conexão com o PgSQL                  
                pgsqlConnection.Open();

                    string codigo = "'" + codigoBolo + "'"; // tratamento para bug de string do visual estudio

                    string cmdAtualiza = String.Format( "UPDATE bolos SET  cod_bolo =  ' "+ codigoBolo + " ',nome_bolo =  '"+ nomeBolo +"' , descricao_bolo =  '"+ descricaoBolo +"', preco_por_kg = '"+precoKg+"'" + "WHERE cod_bolo =  " + codigo );

                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(cmdAtualiza, pgsqlConnection))
                {
                    pgsqlcommand.ExecuteNonQuery();
                }

                MessageBox.Show("Alteração Realizada com sucesso !");
            }
        }
        catch (NpgsqlException ex)
        {
            throw ex;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            //pgsqlConnection.Close();
        }
    }
    //
        // ------------------- para carregar a tabela com os bolos -------------------------

         public DataTable CarregaTabelaBolo()
         {
             DataTable dt = new DataTable();
             try
             {
                 using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                 {
                     //Abra a conexão com o PgSQL
                     pgsqlConnection.Open();
                     string cmdSeleciona = "select * from bolos"; 
                     using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSeleciona, pgsqlConnection))
                     {

                         Adpt.Fill(dt);

                         DataRow dr = dt.Rows[0];
                         string cod_bolo = dr[0].ToString();
                         string nome_bolo = dr[1].ToString();
                         string descricao_bolo = dr[2].ToString();
                         string preco_por_kg = dr[3].ToString();
                     }


                 }
             }
             catch (NpgsqlException ex)
             {
                 throw ex;
             }
             catch (Exception ex)
             {
                 throw ex;
             }
             finally
             {
                 //pgsqlConnection.Close();
             }
             return dt;
         }


         //--------------------  Metodo para pesquisar bolo--------------------------------------------
         public String pesquisaBolo(string codBolo)
         {
             DataTable dt = new DataTable();
             try
             {
                 using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                 {
                     //Abra a conexão com o PgSQL
                     pgsqlConnection.Open();
                     string cBolo = "'" + codBolo + "'"; // tratamento para bug de string do visual estudio
                     string cmdSeleciona = "select * from bolos where cod_bolo = " + cBolo;


                     using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSeleciona, pgsqlConnection))
                     {

                         Adpt.Fill(dt);

                         DataRow dr = dt.Rows[0];
                         string cod_bolo = dr[0].ToString();
                         string nome_bolo = dr[1].ToString();
                         string descricao_bolo = dr[2].ToString();
                         string preco_por_kg = dr[3].ToString();

                         
                        string Pesquisa = ("Codigo: " +cod_bolo + " Nome: " + nome_bolo + " Descrição: " + descricao_bolo + " Preço: R$" +preco_por_kg);
                         //MessageBox.Show("Pesquisa Realizada com Sucesso !" );
                         return Pesquisa;
                     }


                 }
             }
             catch (NpgsqlException ex)
             {
                 
                 throw ex;
             }
             catch (Exception ex)
             {
                 throw ex;
             }
             finally
             {
                 //pgsqlConnection.Close();
             }
             //return dt;
             
         }

        //

         // função para excluir bolo--------------------------------------------
         public void ExcluirBolo(string nomeBolo)
         {
             try
             {
                 using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                 {
                     //abre a conexao                
                     pgsqlConnection.Open();

                     string cmdDeletar = String.Format("Delete From bolos Where nome_bolo = '" + nomeBolo + "'");

                     using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(cmdDeletar, pgsqlConnection))
                     {
                         pgsqlcommand.ExecuteNonQuery();
                     }
                     MessageBox.Show("Bolo excluído com sucesso !");
                 }
             }
             catch (NpgsqlException ex)
             {
                 throw ex;
             }
             catch (Exception ex)
             {
                 throw ex;
             }
             finally
             {
                 //pgsqlConnection.Close();
             }
         }
        //

        //------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------

        //----------------------- CRUD dos Clientes -------------------------------------------------

        // Metodo de inserir Clientes
         public void cadastrarClientes(String nomeC, String cpfC, String enderecoC, string ruaC, string telefonec, string emailC, int numC)
         {
             try
             {
                 using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                 {
                     //Abra a conexão com o PgSQL                  
                     pgsqlConnection.Open();

                     string cmdInserir = String.Format("Insert Into clientes(nome_cliente, cpf_cliente, endereco_cliente, rua_cliente, telefone_cliente, email_clientes, num_cliente  ) values('{0}','{1}','{2}','{3}', '{4}', '{5}' , '{6}')", nomeC, cpfC, enderecoC, ruaC, telefonec, emailC, numC);

                     using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(cmdInserir, pgsqlConnection))
                     {
                         pgsqlcommand.ExecuteNonQuery();
                     }
                     MessageBox.Show("Cliente cadastrado com sucesso !");
                 }
             }
             catch (NpgsqlException ex)
             {
                 throw ex;
             }
             catch (Exception ex)
             {
                 throw ex;
             }
             finally
             {
                 //pgsqlConnection.Close();
             }

         }
        //
        
        // método para alterar clientes
         public void alterarClientes(String nomeC, String cpfC, String enderecoC, string ruaC, int numC, string telefonec)
         {
             try
             {
                 using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                 {
                     //Abra a conexão com o PgSQL                  
                     pgsqlConnection.Open();
                     string codCliente = "'" + cpfC + "'"; // tratamento para bug de string do visual estudio

                     string cmdAtualiza = String.Format("UPDATE clientes SET  nome_cliente = ' " + nomeC + " ',cpf_cliente = '" + cpfC + "', endereco_cliente = '" + enderecoC + "', rua_cliente = '" + ruaC + "'" + ", num_cliente = " + numC  + ", telefone_cliente = '" + telefonec + "'"  +" WHERE cpf_cliente =  " + codCliente);

                     using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(cmdAtualiza, pgsqlConnection))
                     {
                         pgsqlcommand.ExecuteNonQuery();
                     }

                     MessageBox.Show("Alteração Realizada com sucesso !");
                 }
             }
             catch (NpgsqlException ex)
             {
                 throw ex;
             }
             catch (Exception ex)
             {
                 throw ex;
             }
             finally
             {
                 //pgsqlConnection.Close();
             }
         }
        //

         // ------------------------------metodo para carregar tabela Clientes ----------------------------------
         public DataTable CarregaTabelaCliente()
         {
             DataTable dt = new DataTable();
             try
             {
                 using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                 {
                     //Abra a conexão com o PgSQL
                     pgsqlConnection.Open();
                     string cmdSeleciona = "select * from clientes";
                     using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSeleciona, pgsqlConnection))
                     {

                         Adpt.Fill(dt);

                         DataRow dr = dt.Rows[0];
                         string NomeCliente = dr[0].ToString();
                         string cpfCliente = dr[1].ToString();
                         string enderecoCliente = dr[2].ToString();
                         string ruaCliente = dr[3].ToString();
                         string numeroCliente = dr[4].ToString();
                         string telefoneCliente = dr[5].ToString();

                     }
                 }
             }
             catch (NpgsqlException ex)
             {
                 throw ex;
             }
             catch (Exception ex)
             {
                 throw ex;
             }
             finally
             {
                 //pgsqlConnection.Close();
             }
             return dt;
         }
        //
         //--------------------  Metodo para pesquisar Cliente--------------------------------------------
         public DataTable pesquisaCliente(string nomeCliente)
         {
             DataTable dt = new DataTable();
             try
             {
                 using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                 {
                     //Abra a conexão com o PgSQL
                     pgsqlConnection.Open();
                     string nomeC = "'" + nomeCliente + "'"; // tratamento para bug de string do visual estudio
                     string cmdSeleciona = "select * from clientes where nome_cliente = " + nomeC;


                     using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSeleciona, pgsqlConnection))
                     {

                         Adpt.Fill(dt);

                         DataRow dr = dt.Rows[0];
                         string NomeCliente = dr[0].ToString();
                         string cpfCliente = dr[1].ToString();
                         string enderecoCliente = dr[2].ToString();
                         string ruaCliente = dr[3].ToString();
                         string telefoneCliente = dr[4].ToString();
                         string emailCliente = dr[5].ToString();
                         string numeroCliente = dr[6].ToString();
                         


                         string Pesquisa = ("Nome: " + NomeCliente + " CPF: " + cpfCliente + " Endereco: " + enderecoCliente + " Rua: " + ruaCliente +  " Telefone: " + telefoneCliente + " E-amail: "+ emailCliente + " N°: " + numeroCliente);
                         //MessageBox.Show("Pesquisa Realizada com Sucesso !" );
                        // return Pesquisa;
                     }


                 }
             }
             catch (NpgsqlException ex)
             {

                 throw ex;
             }
             catch (Exception ex)
             {
                 throw ex;
             }
             finally
             {
                 //pgsqlConnection.Close();
             }
             return dt;

         }

        //

         // Método para excluir Clientes--------------------------------------------
         public void ExcluirCliente(string nomeCliente)
         {
             try
             {
                 using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                 {
                     //abre a conexao                
                     pgsqlConnection.Open();

                     string cmdDeletar = String.Format("Delete From clientes Where nome_cliente = '" + nomeCliente + "'");

                     using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(cmdDeletar, pgsqlConnection))
                     {
                         pgsqlcommand.ExecuteNonQuery();
                     }
                     MessageBox.Show("Cliente excluído com sucesso !");
                 }
             }
             catch (NpgsqlException ex)
             {
                 throw ex;
             }
             catch (Exception ex)
             {
                 throw ex;
             }
             finally
             {
                 //pgsqlConnection.Close();
             }
         }
        //

        //------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------

        //----------------------- CRUD das Encomendas -------------------------------------------------
         // Metodo de inserir Encomendas
         public void InserirEncomenda(int idEncomenda, String dataEncomenda, String dataEntrega, string status, string descricao, double kg, double valorTotal, string codBolo, string codCliente) { 
         
             try
             {
                 using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                 {
                     //Abra a conexão com o PgSQL                  
                     pgsqlConnection.Open();

                     string cmdInserir = String.Format("Insert into encomenda_bolo (id_encomenda,  data_encomenda,  data_entrega, status, descricao_encomenda, kg, valor_total, cod_bolo, cod_cliente) values('{0}','{1}','{2}','{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", idEncomenda, dataEncomenda, dataEntrega, status, descricao, kg, valorTotal, codBolo, codCliente);

                     using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(cmdInserir, pgsqlConnection))
                     {
                         pgsqlcommand.ExecuteNonQuery();
                     }
                     MessageBox.Show("Encomenda cadastrada com sucesso !");
                 }
             }
             catch (NpgsqlException ex)
             {
                 throw ex;
             }
             catch (Exception ex)
             {
                 throw ex;
             }
             finally
             {
                 //pgsqlConnection.Close();
             }

         }
        //
        // método para alterar Encomenda
        public void alterarEncomenda(int idEncomenda, String dataEncomenda, String dataEntrega, string status, string descricao, double kg, double valorTotal, string codBolo, string codCliente)
        {
            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                {
                    //Abra a conexão com o PgSQL                  
                    pgsqlConnection.Open();
 
                    string cmdAtualiza = String.Format("UPDATE encomenda_bolo SET  id_encomenda = ' " + idEncomenda + " ',  data_encomenda = ' " + dataEncomenda + " ',  data_entrega = ' " + dataEntrega + " ', status = ' " + status + " ', descricao_encomenda = ' " + descricao + " ', kg = ' " + kg + " ', valor_total = ' " + valorTotal + " ', cod_bolo = ' " + codBolo+ " ', cod_cliente =' " + codCliente + " ' WHERE id_encomenda = " + idEncomenda);

                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(cmdAtualiza, pgsqlConnection))
                    {
                        pgsqlcommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Alteração Realizada com sucesso !");
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //pgsqlConnection.Close();
            }
        }
        //

        //------------------Método para carregar tabela de encomendas------------------------
        public DataTable CarregaTabelaEncomendas()
        {
            DataTable dt = new DataTable();
            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                {
                    //Abra a conexão com o PgSQL
                    pgsqlConnection.Open();
                    string cmdSeleciona = "select * from encomenda_bolo";
                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSeleciona, pgsqlConnection))
                    {

                        Adpt.Fill(dt);

                        DataRow dr = dt.Rows[0];
                        string idEncomenda = dr[0].ToString();
                        string dataEncomenda = dr[1].ToString();
                        string dataEntrega = dr[2].ToString();
                        string status = dr[3].ToString();
                        string descricao = dr[4].ToString();
                        string Kg = dr[5].ToString();
                        string valorTotal = dr[6].ToString();
                        string codBolo = dr[7].ToString();
                        string codCliente = dr[8].ToString();

                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //pgsqlConnection.Close();
            }
            return dt;
        }
        //
        //--------------------  Metodo para pesquisar Encomenda POR NOME --------------------------------------------
        public DataTable pesquisaEncomenda(string nomeClienteP)
        {
            DataTable dt = new DataTable();
            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                {
                    //Abra a conexão com o PgSQL
                    pgsqlConnection.Open();
                    string nomeC = "'" + nomeClienteP + "'"; // tratamento para bug de string do visual estudio
                    string cmdSeleciona = "SELECT * FROM encomenda_bolo INNER JOIN clientes ON(encomenda_bolo.cod_cliente = clientes.cpf_cliente) WHERE nome_cliente = " + nomeC;


                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSeleciona, pgsqlConnection))
                    {

                        Adpt.Fill(dt);

                        DataRow dr = dt.Rows[0];
                        string idEncomenda = dr[0].ToString();
                        string dataEncomenda = dr[1].ToString();
                        string dataEntrega = dr[2].ToString();
                        string status = dr[3].ToString();
                        string descricao = dr[4].ToString();
                        string Kg = dr[5].ToString();
                        string valorTotal = dr[6].ToString();
                        string codBolo = dr[7].ToString();
                        string codCliente = dr[8].ToString();



                        //MessageBox.Show("Pesquisa Realizada com Sucesso !" );
                        // return Pesquisa;
                    }


                }
            }
            catch (NpgsqlException ex)
            {

                throw ex;
            }
            catch (Exception ex)
            {
                //throw ex;
                MessageBox.Show("Nome de cliente Não encontrado para encomendas de bolo.");
            }
            finally
            {
                //pgsqlConnection.Close();
            }
            return dt;

        }

        //

        //-------------METODO PARA PESQUISAR ENCOMENDA ENTRE DATAS-------------
        public DataTable pesquisaEncomendaDatas(string de, string para)
        {
            DataTable dt = new DataTable();
            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                {
                    //Abra a conexão com o PgSQL
                    pgsqlConnection.Open();
                    string DE= "'" + de + "'"; // tratamento para bug de string do visual estudio
                    string PARA = "'" + para + "'"; // tratamento para bug de string do visual estudio

                    string cmdSeleciona = "SELECT * FROM encomenda_bolo where data_encomenda >=" + DE + " and data_encomenda <= " + PARA + "order by data_encomenda";


                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSeleciona, pgsqlConnection))
                    {

                        Adpt.Fill(dt);

                        DataRow dr = dt.Rows[0];
                        string idEncomenda = dr[0].ToString();
                        string dataEncomenda = dr[1].ToString();
                        string dataEntrega = dr[2].ToString();
                        string status = dr[3].ToString();
                        string descricao = dr[4].ToString();
                        string Kg = dr[5].ToString();
                        string valorTotal = dr[6].ToString();
                        string codBolo = dr[7].ToString();
                        string codCliente = dr[8].ToString();



                        //MessageBox.Show("Pesquisa Realizada com Sucesso !" );
                        // return Pesquisa;
                    }


                }
            }
            catch (NpgsqlException ex)
            {

                throw ex;
            }
            catch (Exception ex)
            {
                //throw ex;
                MessageBox.Show("Nome de cliente Não encontrado para encomendas de bolo.");
            }
            finally
            {
                //pgsqlConnection.Close();
            }
            return dt;

        }

        //


        // ----- Método para deletar Encomenda------------------------------------
        public void ExcluirEncomenda(int idEncomenda)
        {
            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                {
                    //abre a conexao                
                    pgsqlConnection.Open();

                    string cmdDeletar = String.Format("Delete From encomenda_bolo Where id_encomenda = " + idEncomenda);

                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(cmdDeletar, pgsqlConnection))
                    {
                        pgsqlcommand.ExecuteNonQuery();
                    }
                    MessageBox.Show("Encomenda excluída com sucesso !");
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //pgsqlConnection.Close();
            }
        }
        //



    }
}
