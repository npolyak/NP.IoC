﻿namespace MultyPartBootstrappingTest.Interfaces
{
    public interface IPerson
    {
        string PersonName { get; set; }

        IAddress Address { get; set; }
    }
}
