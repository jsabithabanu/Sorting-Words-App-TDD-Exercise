
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
        
        List<char> wordsToSort = new List<char>();
        wordsToSort.Add('w');
        wordsToSort.Add('e');
        wordsToSort.Add('u');
        _sortingWordApp.Sort("how are you").Should().BeEquivalentTo(wordsToSort);
    }
}