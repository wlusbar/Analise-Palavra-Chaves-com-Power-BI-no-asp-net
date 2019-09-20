using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AppTccWebBD.Models
{
    public class TccDAL : ITccDAL

       
    {
        string connectionString = @"Data Source=DESKTOP-FRR9M4P;Initial Catalog=Tcc;Integrated Security=SSPI;";

        
        public IEnumerable<Tcc> GetAllTcc()
        {
            List<Tcc> lsttccPucMinas_Contagem = new List<Tcc>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * from RepositorioTccExcel", con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Tcc tcc= new Tcc();
                    tcc.AlunoId = Convert.ToInt32(rdr["alunoId"]);
                    tcc.Aluno = rdr["aluno"].ToString();
                    tcc.OrientatadorTcc = rdr["orientadorTcc"].ToString();
                    tcc.AvaliadorApresentacao= rdr["avaliadorApresentacao"].ToString();
                    tcc.Titulo = rdr["titulo"].ToString();
                    tcc.Resumo = rdr["resumo"].ToString();
                    tcc.Semestre = Convert.ToInt32(rdr["semestre"]);
                    tcc.Ano = Convert.ToInt32(rdr["ano"]);
                    tcc.Mencao = Convert.ToBoolean(rdr["mencao"]);
                    tcc.Chave1 = rdr["chave1"].ToString();
                    tcc.Chave2 = rdr["chave2"].ToString();
                    tcc.Chave3 = rdr["chave3"].ToString();
                    tcc.Chave4 = rdr["chave4"].ToString();
                    tcc.Chave5 = rdr["chave5"].ToString();

                    lsttccPucMinas_Contagem.Add(tcc);
                }
                con.Close();
            }
            return lsttccPucMinas_Contagem;
        }


        public void AddTcc(Tcc tcc)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comandoSQL =string.Format( "Insert into RepositorioTccExcel (Aluno,OrientadorTcc,AvaliadorApresentacao,Titulo,Resumo,Semestre,Ano,Mencao,Chave1,Chave2 ,Chave3,Chave4,Chave5) Values (@Aluno, @orientadorTcc, @AvaliadorApresentacao, @titulo,@resumo,@semestre,@ano,@mencao,@chave1,@chave2,@chave3,@chave4,@chave5)");
                SqlCommand cmd = new SqlCommand(comandoSQL, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@aluno", tcc.Aluno);
                cmd.Parameters.AddWithValue("@orientadorTcc", tcc.OrientatadorTcc);
                cmd.Parameters.AddWithValue("@avaliadorApresentacao", tcc.AvaliadorApresentacao);
                cmd.Parameters.AddWithValue("@titulo", tcc.Titulo);
                cmd.Parameters.AddWithValue("@resumo", tcc.Resumo);
                cmd.Parameters.AddWithValue("@semestre", tcc.Semestre);
                cmd.Parameters.AddWithValue("@ano", tcc.Ano);
                cmd.Parameters.AddWithValue("@mencao", tcc.Mencao);
                cmd.Parameters.AddWithValue("@chave1", tcc.Chave1);
                cmd.Parameters.AddWithValue("@chave2", tcc.Chave2);
                cmd.Parameters.AddWithValue("@chave3", tcc.Chave3);
                cmd.Parameters.AddWithValue("@chave4", tcc.Chave4);
                cmd.Parameters.AddWithValue("@chave5", tcc.Chave5);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        public void DeleteTcc(int? id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comandoSQL = "Delete from RepositorioTccExcel where alunoId = @AlunoId";
                SqlCommand cmd = new SqlCommand(comandoSQL, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@AlunoId", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        
        public Tcc GetTcc(int? id)
        {
            Tcc tcc = new Tcc();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM RepositorioTccExcel WHERE alunoId= " + id;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tcc.AlunoId = Convert.ToInt32(rdr["alunoId"]);
                    tcc.Aluno = rdr["aluno"].ToString();
                    tcc.OrientatadorTcc = rdr["orientadorTcc"].ToString();
                    tcc.AvaliadorApresentacao = rdr["avaliadorApresentacao"].ToString();
                    tcc.Titulo = rdr["titulo"].ToString();
                    tcc.Resumo = rdr["resumo"].ToString();
                    tcc.Semestre = Convert.ToInt32(rdr["semestre"]);
                    tcc.Ano = Convert.ToInt32(rdr["ano"]);
                    tcc.Mencao = Convert.ToBoolean(rdr["mencao"]);
                    tcc.Chave1 = rdr["chave1"].ToString();
                    tcc.Chave2 = rdr["chave2"].ToString();
                    tcc.Chave3 = rdr["chave3"].ToString();
                    tcc.Chave4 = rdr["chave4"].ToString();
                    tcc.Chave5 = rdr["chave5"].ToString();

                }
            }
            return tcc;
        }


        public void UpdateTcc(Tcc tcc)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comandoSQL = string.Format("Insert into RepositorioTccExcel (Aluno,OrientadorTcc,AvaliadorApresentacao,Titulo,Resumo,Semestre,Ano,Mencao,Chave1,Chave2,Chave3,Chave4,Chave5) Values (@Aluno,@orientadorTcc,@AvaliadorApresentacao,@titulo,@resumo,@semestre,@ano,@mencao,@chave1,@chave2,@chave3,@chave4,@chave5)");
                SqlCommand cmd = new SqlCommand(comandoSQL, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@aluno", tcc.Aluno);
                cmd.Parameters.AddWithValue("@orientadorTcc", tcc.OrientatadorTcc);
                cmd.Parameters.AddWithValue("@avaliadorApresentacao", tcc.AvaliadorApresentacao);
                cmd.Parameters.AddWithValue("@titulo", tcc.Titulo);
                cmd.Parameters.AddWithValue("@resumo", tcc.Resumo);
                cmd.Parameters.AddWithValue("@semestre", tcc.Semestre);
                cmd.Parameters.AddWithValue("@ano", tcc.Ano);
                cmd.Parameters.AddWithValue("@mencao", tcc.Mencao);
                cmd.Parameters.AddWithValue("@chave1", tcc.Chave1);
                cmd.Parameters.AddWithValue("@chave2", tcc.Chave2);
                cmd.Parameters.AddWithValue("@chave3", tcc.Chave3);
                cmd.Parameters.AddWithValue("@chave4", tcc.Chave4);
                cmd.Parameters.AddWithValue("@chave5", tcc.Chave5);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
