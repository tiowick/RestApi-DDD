﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Aplication.DTOS
{
    public class ClienteDto
    {
        public int Id { get; set; }

        public string Nome { get; set;}

        public string Sobrenome { get; set;}

        public string Email { get; set;}
    }
}
