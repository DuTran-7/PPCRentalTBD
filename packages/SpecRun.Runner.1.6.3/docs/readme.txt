Changes since 1.6.2:
Bug fixes:
- Fix CommunicationObjectFaultedException when using Process separation & DateTime - https://github.com/techtalk/SpecFlow/issues/945
- Fix CommunicationObjectFaultedException when having long running scenarios (> 10min) - https://stackoverflow.com/questions/46307110/specrun-timeout-on-test-execution-when-performing-a-selenium-wait-longer-than-10


Changes since 1.6.0:
New Features:
- Support for "Run functional Tests"- Task on TFS/VSTS

Bug fixes:
- System.NullReferenceException during parse [BeforeFeature] hook with FeatureContext parameter - https://github.com/techtalk/SpecFlow/issues/886
- Executing tests fails if the project path contains a # characters
- Tests are duplicated/doubled up in Visual Studio Test Explorer - https://github.com/techtalk/SpecFlow/issues/900
- Thread.Current.Name is again set to "Test Thread #<Number>" when you execute the tests in more than one thread
- Workaround for issue https://github.com/techtalk/SpecFlow/issues/935 and https://github.com/NuGet/Home/issues/5880


Changes since 1.5.2:
New Features
- Report Template for JSON output
- Report Template for XML output
- Added option for CopyFolder DeploymentStep to disable cleanup of target folder before copying
- New config value how to react on existing report files.
- Support for placeholder and formating of them in output name of reports added
- Support for Visual Studio 2017 RC (tested with 15.0.25928.0 D15REL)
	Known Issues:
		- No tests are found if lightweigth load is enabled
		- If XUnit or MSTest test runners are used, no tests are found
- Duration of Scenarios and Features are displayed in standard report template

Bug fixes:
- Execution via VisualStudio TestAdapter (VS or TFS) consideres now entries in TestAssemblyPaths and does not anymore execute all given assemblies.
- testpath filter works now with colon (:) in scenario title
- Use projectName if no name is given in srProfile as project name in SpecFlow+Server
- Fix a bug if you combine SharedAppDomain isolation and targets (https://groups.google.com/d/msg/specrun/GeVoqsHlmNY/TbnvbfSoAwAJ)


Changes since 1.5:
Bug fixes:
- Links to custom files in reports
- VS 2013 Debugger asks for source files of SpecFlow+Runner at stepping through bindings

Changes since 1.4:
New features:
- Generate multiple reports from a single test run
- Formatting fixes in report output

Bug fixes:
- Bugfix for error when using SpecRun+MsTest/SpecRun+NUnit Unit test provider and running the tests with MsTest/NUnit.


Changes since 1.3:

New features:
- Support for SpecFlow V2's Shared AppDomain parallelization 
- Output additional license info (expiry date, upgrade until date) when running from the console


Bug fixes:
- Under certain conditions, failed tests are not retried
- In Visual Studio 2015 Update 2 not all tags where displayed as traits


Changes since 1.2:

New features:
- Visual Studio 2015 support
- VB.Net support
- Support for project licenses
- Added completion state to console title
- Default report template included (ReportTemplate.cshtml)
- API for stopping the test run
- TechTalk.SpecRun.dll is now signed
- Error message if filter syntax is incorrect
- Add new setting to copy the report to the base folder (<Report copyAlsoToBaseFolder="true"/>)


Bug fixes:
- Escape '<' and '>' correctly in Visual Studio Test discovery
- Fixed an occurance of locking an assembly
- Fixed an issue with adaptive test scheduling and tests with a long history
- Enabled useLegacyV2RuntimeActivationPolicy="true" on test executor to support multi-mode assemblies by default 
- use more than 64 threads for test run


Note to Visual Studio 2015 users:
Tests may not initially be displayed in the Test Explorer window when using SpecFlow+ Runner, as Visual Studio seems to handle solution-level NuGet packages differently from previous versions. 
Solution-level NuGet packages now need to be listed at the project-level. If this is not the case, the Test Explorer will not recognise the test runner. 
The easiest way to fix this issue is to reinstall the SpecFlow+ Runner NuGet package. 
Alternatively, you can add the SpecRun.Runner package (<package id="SpecRun.Runner" version="1.3.0" />) to the packages.config file used by your SpecFlow projects. 
You may need to restart Visual Studio to see your tests.

There is also a minor cosmetic issue with tests turning greyish-green once the tests have been executed.


For a complete version history, see changelog.txt