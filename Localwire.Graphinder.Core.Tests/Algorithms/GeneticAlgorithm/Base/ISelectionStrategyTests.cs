﻿namespace Localwire.Graphinder.Core.Tests.Algorithms.GeneticAlgorithm.Base
{
    using System;
    using System.Collections.Generic;
    using Core.Algorithms.GeneticAlgorithm;
    using Core.Algorithms.GeneticAlgorithm.SelectionStrategies;
    using Providers;
    using Providers.TestData;
    using Xunit;

    public abstract class ISelectionStrategyTests
    {
        protected ISelectionStrategy _strategy;
        private readonly ITestDataProvider<Individual> _individualProvider = new TestIndividualProvider();

        protected ISelectionStrategyTests()
        {
        }

        [Fact]
        public void ISelectionStrategy_Set_ThrowsOnNullPopulation()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                _strategy.Set(null);
            });

            _strategy.Set(new List<Individual>());
        }

        [Fact]
        public void ISelectionStrategy_Next_ThrowsOnEmptyPopulation()
        {
            _strategy.Set(new List<Individual>());
            Assert.Throws<InvalidOperationException>(() =>
            {
                _strategy.Next();
            });
        }

        [Fact]
        public void ISelectionStrategy_Next_ReturnsProperValueIfOneIndividualPopulation()
        {
            _strategy.Set(new List<Individual> { _individualProvider.ProvideValid() });
            _strategy.Next();
        }
    }
}