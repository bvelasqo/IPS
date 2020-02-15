using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace mejoraTuSalud
{
    class Operaciones
    {
        public static string conexion = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ..\..\..\BaseDeDatosMejoraTuSalud.accdb";
        string SQL;
        OleDbDataAdapter Adaptador = new OleDbDataAdapter();
        DataTable tabla = new DataTable();
        //Operacion para acceder al sistema
        public DataTable acceso(string usuario)
        {
            tabla.Clear();
            SQL = "Select Usuario, contraseña from administradores where Usuario = '" + usuario + "'";
            Adaptador = new OleDbDataAdapter(SQL, conexion);
            Adaptador.Fill(tabla);
            return tabla;
        }
        //Citas que no se han realizado
        public DataTable CitasPendientes(string id)
        {
            tabla.Clear();
            SQL = "SELECT idPaciente, idMedico, FechaDeCita FROM tbCita WHERE idPaciente = '" + id + "' and FechaDeCita >= Date() and Asistio = false";
            Adaptador = new OleDbDataAdapter(SQL, conexion);
            Adaptador.Fill(tabla);
            return tabla;
        }
        //Citas a las cuales el paciente no asistió
        public DataTable CitasIncumplidas(string id)
        {
            tabla.Clear();
            SQL = "SELECT idPaciente, idMedico, FechaDeCita, Asistio FROM tbCita WHERE idPaciente = '" + id + "' and Asistio = false and FechaDeCita < Date()";
            Adaptador = new OleDbDataAdapter(SQL, conexion);
            Adaptador.Fill(tabla);
            return tabla;
        }
        //Trae todas las citas
        public DataTable historialDeCitas(string id)
        {
            tabla.Clear();
            SQL = "SELECT idPaciente, idMedico, FechaDeCita, Asistio FROM tbCita WHERE idPaciente = '" + id + "' ";
            Adaptador = new OleDbDataAdapter(SQL, conexion);
            Adaptador.Fill(tabla);
            return tabla;
        }
        //Utilizado para la validacion de la nueva cita
        public DataTable CitasRepetidas(string idpaciente, string idmedico, string fecha)
        {
            tabla.Clear();
            SQL = "SELECT idPaciente, idMedico, FechaDeCita FROM tbCita WHERE idPaciente = '" + idpaciente + "' and idMedico='" + idmedico + "' and FechaDeCita = #" + fecha + "#";
            Adaptador = new OleDbDataAdapter(SQL, conexion);
            Adaptador.Fill(tabla);
            return tabla;
        }
        //Utlizado para la Validacion de la fecha de la nueva cita
        public DataTable FechaCitaRepetida(string fecha, string idpaciente)
        {
            tabla.Clear();
            SQL = @"SELECT tbCita.idPaciente, tbCita.FechaDeCita FROM tbCita
WHERE(((tbCita.idPaciente) = '"+idpaciente+"') AND((tbCita.FechaDeCita) = #"+fecha+"#))";
            Adaptador = new OleDbDataAdapter(SQL, conexion);
            Adaptador.Fill(tabla);
            return tabla;
        }
        //Cancelar la cita de un paciente
        public void CancelarCita(string idp, string idm)
        {
            tabla.Clear();
            SQL = "Delete from tbCita where idPaciente = '" + idp + "' and idMedico = '" + idm + "' and FechaDeCita > Date()";
            Adaptador = new OleDbDataAdapter(SQL, conexion);
            Adaptador.Fill(tabla);
        }
        //Utilizado para la validacion de una nueva cita verificando si ya tiene cita con ese mismo especialista
        public DataTable CitasRepetidasMismoEspecialista(string idpaciente, string idmedico)
        {
            tabla.Clear();
            SQL = "SELECT idPaciente, idMedico, FechaDeCita FROM tbCita WHERE idPaciente = '" + idpaciente + "' and FechaDeCita >= Date() and idMedico = '"+idmedico+"' ";
            Adaptador = new OleDbDataAdapter(SQL, conexion);
            Adaptador.Fill(tabla);
            return tabla;
        }
        //Registrar un paciente a la base de datos
        public Boolean RegistrarPaciente(string id, string nombres, string apellidos, DateTime FHN, string Direccion, string Tel)
        {
            try
            {
                tabla.Clear();
                SQL = "Insert into tbPaciente values('" + id + "' , '" + nombres + "' , '" + apellidos + "' , '" + FHN.Date.ToShortDateString() + "' , '" + Direccion + "', '" + Tel + "' , Date() , 0)";
                Adaptador = new OleDbDataAdapter(SQL, conexion);
                Adaptador.Fill(tabla);
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Busca los pacientes que no asistieron a las citas(utilizado en form1)
        public DataTable buscarNoAsistidos()
        {
            tabla.Clear();
            SQL = "Select idPaciente from tbCita where FechaDeCita < Date() and Asistio = false and Revisado = false";
            Adaptador = new OleDbDataAdapter(SQL, conexion);
            Adaptador.Fill(tabla);
            return tabla;
        }
        //Actualiza el campo Revisado de la base de datos para saber que el programa ya multo al paciente(Utilizado en Form1)
        public DataTable revisar()
        {
            tabla.Clear();
            SQL = "Update tbCita Set Revisado = true Where FechaDeCita < Date() and Asistio = false and Revisado = false";
            Adaptador = new OleDbDataAdapter(SQL, conexion);
            Adaptador.Fill(tabla);
            return tabla;
        }
        //Multa a un paciente si no asistio a una cita(Utilizado en form1)
        public void multar(string id, int multas)
        {
            tabla.Clear();
            SQL = "UPDATE tbPaciente SET Multas = " + multas + " WHERE idPaciente = '" + id + "'";
            Adaptador = new OleDbDataAdapter(SQL, conexion);
            Adaptador.Fill(tabla);
        }
        //Busca todas las nultas de un paciente
        public DataTable buscarMultas(string id)
        {
            tabla.Clear();
            SQL = "Select idPaciente, Multas from tbPaciente where idPaciente = '" + id + "' ;";
            Adaptador = new OleDbDataAdapter(SQL, conexion);
            Adaptador.Fill(tabla);
            return tabla;
        }
        //Paga la multa de un paciente
        public void pagarMulta(string id)
        {
            tabla.Clear();
            SQL = "Update tbPaciente Set Multas = 0 Where idPaciente = '" + id + "';";
            Adaptador = new OleDbDataAdapter(SQL, conexion);
            Adaptador.Fill(tabla);
        }
        //Pone la nueva cita en la base de datos
        public Boolean insertarCita(string idp, string idm, string fecha, string hora)
        {
            try
            {
                tabla.Clear();
                SQL = "Insert into tbCita(idPaciente,idMedico,FechaDeCita,Hora) values('" + idp + "' , '" + idm + "' , '" + fecha + "', '" + hora + "')";
                Adaptador = new OleDbDataAdapter(SQL, conexion);
                Adaptador.Fill(tabla);
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Busca los medicos en denominada especialidad
        public DataTable buscarMedico(string especialidad)
        {
            tabla.Clear();
            SQL = "Select idMedico from tbMedico where Especialidad = '" + especialidad + "' ;";
            Adaptador = new OleDbDataAdapter(SQL, conexion);
            Adaptador.Fill(tabla);
            return tabla;
        }
        //Busca el nombre completo del medico dado
        public DataTable buscarNombreMedico(string id)
        {
            tabla.Clear();
            SQL = "Select Nombres, Apellidos, SalarioPorCita from tbMedico where idMedico = '" + id + "' ;";
            Adaptador = new OleDbDataAdapter(SQL, conexion);
            Adaptador.Fill(tabla);
            return tabla;
        }
        //Busca todo del paciente dado
        public DataTable buscarPaciente(string id)
        {
            tabla.Clear();
            SQL = "Select * from tbPaciente where idPaciente = '" + id + "' ;";
            Adaptador = new OleDbDataAdapter(SQL, conexion);
            Adaptador.Fill(tabla);
            return tabla;
        }
        //Busca la cita de hoy del paciente dado
        public DataTable citashoy(string idp)
        {
            tabla.Clear();
            SQL = "SELECT idPaciente, idMedico, FechaDeCita FROM tbCita WHERE idPaciente = '" + idp + "' and FechaDeCita = Date() and Asistio = false";
            Adaptador = new OleDbDataAdapter(SQL, conexion);
            Adaptador.Fill(tabla);
            return tabla;
        }
        //Busca el nombre completo del medico dado
        public DataTable Nombremedico(string id)
        {
            tabla.Clear();
            SQL = "Select Nombres, Apellidos from tbMedico where idMedico='" + id + "'";
            Adaptador = new OleDbDataAdapter(SQL, conexion);
            Adaptador.Fill(tabla);
            return tabla;
        }
        //Aprueba la asistencia del paciente dado en la cita de hoy
        public void registrarAsistencia(string idp)
        {
            tabla.Clear();
            SQL = "update tbCita set asistio = true WHERE idPaciente = '" + idp + "' and FechaDeCita = Date()";
            Adaptador = new OleDbDataAdapter(SQL, conexion);
            Adaptador.Fill(tabla);
        }
        //Busca las citas que no se la han pagado al medico dado
        public DataTable buscarCitasSinPagar(string id)
        {
            tabla.Clear();
            SQL = "Select idMedico from tbCita where idMedico = '" + id + "' and PagadoAlMedico = false and FechaDeCita < Date()";
            Adaptador = new OleDbDataAdapter(SQL, conexion);
            Adaptador.Fill(tabla);
            return tabla;
        }
        //Le paga las citas no pagadas al medico dado
        public void pagarCitas(string id)
        {
            tabla.Clear();
            SQL = "UPDATE tbCita SET pagadoAlMedico=true where idMedico = '" + id + "' and PagadoAlMedico = false";
            Adaptador = new OleDbDataAdapter(SQL, conexion);
            Adaptador.Fill(tabla);
        }
        //Actualiza el salario del medico dado
        public void actualizarSalario(string id,string salario)
        {
            tabla.Clear();
            SQL = "Update tbMedico set SalarioPorCita = " + salario + " where idMedico = '" + id + "' ";
            Adaptador = new OleDbDataAdapter(SQL, conexion);
            Adaptador.Fill(tabla);
        }
        //Actualiza los años de experiencia del medico dado
        public void actualizarAnios(string id, string anios)
        {
            tabla.Clear();
            SQL = "Update tbMedico set AñosDeExperiencia = " + anios + " where idMedico = '" + id + "' ";
            Adaptador = new OleDbDataAdapter(SQL, conexion);
            Adaptador.Fill(tabla);
        }
    }
}