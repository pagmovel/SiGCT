﻿using System;
using System.ComponentModel.DataAnnotations;

namespace SiGCT.Models
{
    public class Cliente
    {
        /// <summary>
        /// Código interno na operadora
        /// </summary>
        public virtual Int64 Id { get; set; }

        /// <summary>
        /// Nome definido no contrato
        /// </summary>
        [Required, MinLength(5), MaxLength(30)]
        public virtual String Nome { get; set; }

        /// <summary>
        /// CNPJ definido no contrato
        /// </summary>
        [Required,StringLength(15)]
        public virtual String CNPJ { get; set; }


    }
}