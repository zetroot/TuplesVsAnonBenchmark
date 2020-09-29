``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
Intel Core i5-7400 CPU 3.00GHz (Kaby Lake), 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|                         Method |         N |            Mean |         Error |        StdDev |           Median |
|------------------------------- |---------- |----------------:|--------------:|--------------:|-----------------:|
|             **AnonTransformation** |      **1000** |        **10.15 μs** |      **0.202 μs** |      **0.507 μs** |         **9.870 μs** |
|      ValueTuplesTransformation |      1000 |        16.94 μs |      0.216 μs |      0.202 μs |        16.907 μs |
| NamedValueTuplesTransformation |      1000 |        16.60 μs |      0.107 μs |      0.100 μs |        16.610 μs |
|           TuplesTransformation |      1000 |        10.48 μs |      0.086 μs |      0.076 μs |        10.505 μs |
|             **AnonTransformation** |     **10000** |       **103.63 μs** |      **1.807 μs** |      **1.690 μs** |       **103.491 μs** |
|      ValueTuplesTransformation |     10000 |       168.83 μs |      0.856 μs |      0.800 μs |       168.870 μs |
| NamedValueTuplesTransformation |     10000 |       168.87 μs |      0.958 μs |      0.896 μs |       168.736 μs |
|           TuplesTransformation |     10000 |        98.95 μs |      1.972 μs |      5.398 μs |        97.454 μs |
|             **AnonTransformation** |    **100000** |     **1,135.54 μs** |     **22.672 μs** |     **39.108 μs** |     **1,137.467 μs** |
|      ValueTuplesTransformation |    100000 |     1,672.37 μs |      8.864 μs |      8.291 μs |     1,672.032 μs |
| NamedValueTuplesTransformation |    100000 |     1,685.81 μs |     17.630 μs |     16.491 μs |     1,686.113 μs |
|           TuplesTransformation |    100000 |     1,140.92 μs |     10.573 μs |      9.372 μs |     1,141.871 μs |
|             **AnonTransformation** |   **1000000** |    **14,346.91 μs** |    **284.264 μs** |    **723.543 μs** |    **14,273.902 μs** |
|      ValueTuplesTransformation |   1000000 |    17,430.62 μs |    255.171 μs |    226.202 μs |    17,429.627 μs |
| NamedValueTuplesTransformation |   1000000 |    17,481.72 μs |    339.208 μs |    390.632 μs |    17,335.300 μs |
|           TuplesTransformation |   1000000 |    13,972.26 μs |    328.802 μs |    969.479 μs |    13,960.817 μs |
|             **AnonTransformation** |  **10000000** |   **120,193.42 μs** |  **2,398.287 μs** |  **5,364.113 μs** |   **119,147.325 μs** |
|      ValueTuplesTransformation |  10000000 |   176,877.66 μs |  3,531.998 μs |  6,633.949 μs |   177,123.083 μs |
| NamedValueTuplesTransformation |  10000000 |   176,010.36 μs |  3,519.627 μs |  6,610.712 μs |   177,736.967 μs |
|           TuplesTransformation |  10000000 |   110,470.00 μs |  1,825.863 μs |  1,707.914 μs |   109,931.560 μs |
|             **AnonTransformation** | **100000000** | **1,159,228.80 μs** |  **6,825.374 μs** |  **6,384.459 μs** | **1,159,509.800 μs** |
|      ValueTuplesTransformation | 100000000 | 1,781,727.36 μs | 22,585.914 μs | 21,126.878 μs | 1,776,186.100 μs |
| NamedValueTuplesTransformation | 100000000 | 1,758,624.86 μs |  3,226.270 μs |  2,694.082 μs | 1,759,681.700 μs |
|           TuplesTransformation | 100000000 | 1,068,097.05 μs |  6,476.781 μs |  5,741.498 μs | 1,068,632.350 μs |
