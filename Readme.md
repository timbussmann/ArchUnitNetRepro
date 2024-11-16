Repro demo showing that ArchUnit.NET does not fail certain rule violations when tests are run in `Release` mode due to async state machine optimizations.

- Run the test in `Debug` configuration: The test should (correctly) fail
- Run the test in `Release` configuration: The test does not fail although it should