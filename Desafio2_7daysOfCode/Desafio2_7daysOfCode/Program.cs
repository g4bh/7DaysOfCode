namespace Desafio2_7daysOfCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listaPaciente = new ListaPaciente();

            var paciente1 = new Paciente() { Id_Paciente = 1, Nome_Paciente = "Gabriella", Estado_Paciente = "saudavel" };
            var paciente2 = new Paciente() { Id_Paciente = 2, Nome_Paciente = "Alexandre", Estado_Paciente = "estado critico" };
            var paciente3 = new Paciente() { Id_Paciente = 3, Nome_Paciente = "Elizabete", Estado_Paciente = "estável" };
            var paciente4 = new Paciente() { Id_Paciente = 4, Nome_Paciente = "Joana", Estado_Paciente = "tratamento intensivo" };

            listaPaciente.CadastrarPaciente(paciente1);
            listaPaciente.CadastrarPaciente(paciente2);
            listaPaciente.CadastrarPaciente(paciente3);
            listaPaciente.CadastrarPaciente(paciente4);

            listaPaciente.MostrarPaciente();

            var paciente5 = new Paciente() { Id_Paciente = 3, Nome_Paciente = "Caue", Estado_Paciente = "estado critico" };
            listaPaciente.AtualizarPaciente(paciente5);

            listaPaciente.MostrarPaciente();

            listaPaciente.DeletarPaciente(3);

            listaPaciente.MostrarPaciente();

        }

        
    }
}