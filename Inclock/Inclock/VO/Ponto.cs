﻿using System;
using System.Collections.Generic;


namespace Inclock.VO
{
    public class Ponto
    {
        public string Id { get; set; }
        public int Funcionario { get; set; }
        public string Data { get; set; }
        public string Entrada { get; set; }
        public string Saida { get; set; }
        public string Logitude { get; set; }
        public string Latitude { get; set; }
        public int Periodo { get; set; }
        public string EntradaPausa { get; set; }
        public string SaidaPausa { get; set; }
        private List<string> status = new List<string>();
        public List<string> Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }
        public string Obs { get; set; }

        public TimeSpan TimeEntrada
        {
            get
            {
                DateTime time;
                DateTime.TryParse(Entrada, out time);
                return time.TimeOfDay;
            }
        }
        public TimeSpan TimeSaida
        {
            get
            {
                DateTime time;
                DateTime.TryParse(Saida, out time);
                return time.TimeOfDay;
            }
        }
        public TimeSpan TimeSaidaPausa
        {
            get
            {
                DateTime time;
                DateTime.TryParse(SaidaPausa, out time);
                return time.TimeOfDay;
            }
        }
        public TimeSpan TimeEntradaPausa
        {
            get
            {
                DateTime time;
                DateTime.TryParse(EntradaPausa, out time);
                return time.TimeOfDay;
            }
        }

    }

}
