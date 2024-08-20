using System;

namespace PacktLibraryNetStandard2;

public class BankAccount
{
    public string? AccountName; //instance member, meaning can have different value of different instances of class BankAccount. it can be null because of ?

    public decimal Balance; //instacne member, meaning can have different value of different instances of class BankAccount. default value is zero

    public static decimal InterestRate; //shared member, value is shared by all the instances. Default is zero
}
