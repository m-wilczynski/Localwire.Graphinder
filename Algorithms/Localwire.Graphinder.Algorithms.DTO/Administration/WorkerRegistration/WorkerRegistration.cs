﻿namespace Localwire.Graphinder.Algorithms.DTO.Administration.WorkerRegistration
{
    using System;
    using System.ComponentModel.DataAnnotations;


    public class WorkerRegistration
    {
        [Required]
        public Uri WorkerAddress { get; set; }
    }
}