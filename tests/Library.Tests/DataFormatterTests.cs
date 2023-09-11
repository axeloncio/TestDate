using System;
using System.Collections.Generic;
using NUnit.Framework;
using Ucu.Poo.Persons;

namespace Ucu.Poo.Persons;
public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CorrectDate()
    {
        const string validDate = "25/01/2006";

        const string newFirstDate = "2006-01-25";

        string valid = DateFormatter.ChangeFormat(validDate);

        Assert.AreEqual(valid, newFirstDate);
    }
    
    [Test]
    public void InvalidDate()
    {
        const string invalidDate = "32/01/2006"; //Tiene que retornar un error
        string invalid = DateFormatter.ChangeFormat(invalidDate);

        Assert.AreEqual(invalid, string.Empty);
    }

    [Test]
    public void NullDate()
    {
        const string nullDate = "";
        string invalidNull = DateFormatter.ChangeFormat(nullDate);

        Assert.AreEqual(invalidNull, string.Empty);
    }
}