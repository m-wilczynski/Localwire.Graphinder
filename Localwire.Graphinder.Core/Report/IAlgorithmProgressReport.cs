﻿namespace Localwire.Graphinder.Core.Report
{
    using System;
    using System.Collections.Generic;
    using Graph;

    public interface IAlgorithmProgressReport
    {
        /// <summary>
        /// Date on which report was generated
        /// </summary>
        DateTime ReportDate { get; }

        /// <summary>
        /// Process time used up so far by algorithm
        /// </summary>
        long ProcessorTime { get; }

        /// <summary>
        /// Current solution produced by algorithm
        /// </summary>
        ICollection<Node> CurrentSolution { get; }

        /// <summary>
        /// Fitness of current solution
        /// </summary>
        uint CurrentFitness { get; } 
    }
}