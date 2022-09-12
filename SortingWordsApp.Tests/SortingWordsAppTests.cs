
using NUnit.Framework;
using FluentAssertions;
using System.Collections.Generic;
using System;
namespace SortingWordsApp.Tests;

public class Tests
{
    private SortingWordApp _sortingWordApp;
    [SetUp]
    public void Setup()
    {
        _sortingWordApp = new SortingWordApp();
    }

    [Test]
    public void Test1()
    {
        
        string[] wordsToSort = { "how", "are", "you" };
        _sortingWordApp.Sort("how are you").Should().BeEquivalentTo(wordsToSort);
    }
}