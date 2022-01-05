using System.Collections.Generic;

namespace AtvSenac03.Models
{
    public class Agenda
    {
        private List<Agendamento> agendar;

        public Agenda()
        {
            agendar = new List<Agendamento>();
        }

         public void adicionar(Agendamento Ag){
            agendar.Clear();
            agendar.Add(Ag);
        }

        public List<Agendamento> listar()
        {
            return agendar;
        }


    }
}