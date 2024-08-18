using System;

namespace PacktLibraryNetStandard2;

// public enum AncientWondersOfWorld//stores single value
// {
//     GreatPyramidOfGiza,
//     HangingGardensOfBabylon,
//     StatueOfZeusAtOlympia,
//     TempleOfArtemisAtEphesus,
//     MausoleumAtHalicarnassus,
//     ColossusOfRhodes,
//     LighthouseOfAlexandria
// }
//The enum value is internally stored as an int for efficiency. The int values are automatically assigned 
//starting at 0, so the third-world wonder in our enum has a value of 2

[Flags]
public enum WondersOfTheAncientWorld : byte
{
 None = 0b_0000_0000, // i.e. 0
 GreatPyramidOfGiza = 0b_0000_0001, // i.e. 1
 HangingGardensOfBabylon = 0b_0000_0010, // i.e. 2
 StatueOfZeusAtOlympia = 0b_0000_0100, // i.e. 4
 TempleOfArtemisAtEphesus = 0b_0000_1000, // i.e. 8
 MausoleumAtHalicarnassus = 0b_0001_0000, // i.e. 16
 ColossusOfRhodes = 0b_0010_0000, // i.e. 32
 LighthouseOfAlexandria = 0b_0100_0000 // i.e. 64
}
