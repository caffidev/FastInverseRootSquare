# FastInverseRootSquare
My research of comparing the speed of different inverse root square algorithms.
## Comparison
|Algorithm|Brief Description|Speed|
|---------|-----------------|-----|
|[Usual algorithm](FastInverseRootSquare/Program.cs)|An usual algorithm, with using Math.Sqrt()| float - 1.43ms, double - ~4ms|
|[Quake algorithm](FastInverseRootSquare/Program.cs)|This algorithm was used in Quake, and was re-written without any changes. This is faster than usual algorithm, but not as fast as the next| <1ms (0.6-0,7ms)|
|[Fast algorithm ](FastInverseRootSquare/Program.cs)|This algorithm uses BitConverter, number was found with following formula: ```x = (1 + Math.M / Math.Pow(2.0, 23)) * Math.Pow(2.0, Math.E - 127) ```| <1ms (0.5-0.6 ms)|
#### To view Tests, click [**here**](FastInverseRootSquare.Tests/UnitTest1.cs)
