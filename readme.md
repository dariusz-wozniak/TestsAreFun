Welcome to the demo of different types of tests. The following table explains what tests are included along with the used tools and pre-requisities to run tests.

| Tests type |  Tools  | Comments  |
|---|---|---|
|  Unit tests | [NUnit](https://nunit.org/)<br/>[Moq](https://github.com/moq/moq4)<br />[FluentAssertions](https://fluentassertions.com/)<br />[AutoMoq](https://github.com/dariusz-wozniak/AutoMoq) (fork)<br />[Bogus](https://github.com/bchavez/Bogus)<br />[AutoFixture](https://github.com/AutoFixture/AutoFixture)   |   |
|  Integration tests |  [Flurl](https://flurl.dev/)<br />[ExcelDataReader](https://github.com/ExcelDataReader/ExcelDataReader) |  - Excel read tests<br />- REST API tests |
| Approval tests  | [Verify](https://github.com/VerifyTests/Verify)  |   Optional:<br />- Install diff tray tool (Windows): `dotnet tool install -g DiffEngineTray`<br />- Run: `diffenginetray`
| Load tests | [NBomber](https://nbomber.com/) | Reports are under `\bin\[Debug\|Release]\net6.0\`
| Acceptance tests | [Playwright](https://playwright.dev/) | Installation: `dotnet tool install -g Microsoft.Playwright.CLI`<br />More:<br />- Run tests: `dotnet test`<br />- Run tests in parallel: `dotnet test -- NUnit.NumberOfTestWorkers=5`<br />- Generate test: `playwright codegen github.com`<br />- Show trace: `playwright show-trace PATHTOZIPTRACEFILE`<br />- Reports are under `\bin\[Debug\|Release]\net6.0\test_reports`
| Specification tests #1 | [SpecFlow](https://specflow.org/) | Installation:<br />- [Visual Studio](https://docs.specflow.org/projects/specflow/en/latest/visualstudio/visual-studio-installation.html)<br />- [Rider](https://docs.specflow.org/projects/specflow/en/latest/Rider/rider-installation.html)
| Specification tests #2 | [LoFu](https://github.com/hlaueriksson/LoFuUnit)

# Note
- The repository is forked from https://github.com/dariusz-wozniak/TddBook-Code
- ExcelDataReader is rather an obsolete library
