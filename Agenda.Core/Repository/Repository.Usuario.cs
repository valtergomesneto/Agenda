using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agenda.Entity;
using MySql.Data.MySqlClient;

namespace Agenda.Core.Repository
{
    public class Repository : Interface.ContactRepository
    {
        private Entity.Usuario objUsuario;
        private StringBuilder sqlquery;
        private List<MySqlParameter> paramentos;


        public Entity.Usuario LoginUsuario(string login, string senha)
        {
            try
            {
                sqlquery = new StringBuilder();
                objUsuario = new Entity.Usuario();
                paramentos = new List<MySqlParameter>();

                sqlquery.Append("SELECT IDUSUARIO, NOME,LOGIN, SENHA, STATUS, NIVEL FROM USUARIO  WHERE LOGIN = @login AND SENHA = @senha");

                paramentos.Add(new MySqlParameter() { ParameterName = "@login", Value = login.ToUpper().Trim() });
                paramentos.Add(new MySqlParameter() { ParameterName = "@senha", Value = senha });

                var dataSet = new DataContext.Banco().Read(sqlquery.ToString(), paramentos.ToArray());

                if (dataSet.Tables.Count > 0)
                    if (dataSet.Tables[0].Rows.Count > 0)
                    {
                        objUsuario.idusuario = Convert.ToInt32(dataSet.Tables[0].Rows[0][0]);
                        objUsuario.nome = Convert.ToString(dataSet.Tables[0].Rows[0][1]);
                        objUsuario.login = Convert.ToString(dataSet.Tables[0].Rows[0][2]);
                        objUsuario.senha = Convert.ToString(dataSet.Tables[0].Rows[0][3]);
                        objUsuario.status = Convert.ToInt32(dataSet.Tables[0].Rows[0][4]);
                        objUsuario.nivelAcesso = Convert.ToInt32(dataSet.Tables[0].Rows[0][5]);
                    }

                return objUsuario;


            }
            catch (Exception ex)
            {
                new Exception(ex.Message.ToString());
            }
            return new Entity.Usuario();
        }
    }
}
