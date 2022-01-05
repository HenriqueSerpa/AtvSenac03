using System.Collections.Generic;

namespace AtvSenac03.Models
{
    public static class dados
    {
        public static Agenda agendado {get; set;}
        static dados()
        {

            agendado = new Agenda();

        }
    }
}