using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public static class MonedasDAL
    {

        public static List<Turnos> GetAll()
        {

            List<Turnos> list = new List<Turnos>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Cnn"].ToString()))
            {
                conn.Open();

                string sql = @"ListaTurnos";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(ObtenerListadoTurnos(reader));
                }
            }

            return list;
        }
        public static Turnos ObtenerListadoTurnos(SqlDataReader reader)
        {
            Turnos turno = new Turnos();
            turno.Horario = Convert.ToString(reader["horario"]);
            turno.Disponible = Convert.ToBoolean(reader["disponible"]);
           
            return turno;
        }
    }
        
    }

